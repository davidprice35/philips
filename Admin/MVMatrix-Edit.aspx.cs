using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Microsoft.Practices.EnterpriseLibrary.Data;
using System.Data;

using System.Data.Common;
using Newtonsoft.Json;
using MySql.Data.MySqlClient;
using System.Data.SqlClient;


using Syncfusion.JavaScript.Web;

public partial class Admin_MVMatrix_Edit : System.Web.UI.Page
{
    public string m_UserName = string.Empty;




    protected void repDataGrid_ItemDataBound(object sender, RepeaterItemEventArgs e)
    {
        try
        {
                      
            if (e.Item.ItemType == ListItemType.Item || e.Item.ItemType == ListItemType.AlternatingItem)
            {

                DataRowView drv = e.Item.DataItem as DataRowView;

                string sID = drv.Row["MatrixEditID"].ToString();
                string sData = drv.Row["Data"].ToString();              
                ////Get Current




                System.Web.UI.WebControls.HiddenField HF_ID = e.Item.FindControl("HF_ID") as System.Web.UI.WebControls.HiddenField;            
                System.Web.UI.WebControls.TextBox txtData = e.Item.FindControl("txtData") as System.Web.UI.WebControls.TextBox;
                
                System.Web.UI.WebControls.LinkButton cmdDelete = e.Item.FindControl("cmdDelete") as System.Web.UI.WebControls.LinkButton;
                cmdDelete.CommandArgument = sID;


                System.Web.UI.WebControls.LinkButton cmdSave = e.Item.FindControl("cmdSave") as System.Web.UI.WebControls.LinkButton;
                cmdSave.CommandArgument = sID;


                HF_ID.Value = sID;
                txtData.Text = sData;                


            }


        }
        catch (Exception ex)
        {

        }
    }





    protected void cmdAdd_Click(object sender, EventArgs e)
    {


        try
        {


            txtData1.Text = "";
            PanelNewRow.Visible = true;



            //Response.Redirect("AttachmentsEditFile.aspx?ID=new");


        }
        catch (Exception ex)
        {

        }
    }

    protected void cmdCancel_Click(object sender, EventArgs e)
    {
        try
        {
            PanelNewRow.Visible = false;
        }
        catch { }
    }

    private void SaveDataInGrid(string ID)
    {
        try
        {

            foreach (RepeaterItem item in repDataGrid.Items)
            {
                System.Web.UI.WebControls.HiddenField HF_ID = (System.Web.UI.WebControls.HiddenField)item.FindControl("HF_ID");

                if (HF_ID.Value == ID)
                {
                    
                    System.Web.UI.WebControls.TextBox txtData = (System.Web.UI.WebControls.TextBox)item.FindControl("txtData");
                    

                    string sUpdateData = "UPDATE PhilipsMatrixEdit SET Data = '" + txtData.Text + "' WHERE MatrixEditID  = " + HF_ID.Value ;                    
                    Helper.InsertData(sUpdateData);
                                      
                    SetupPage();

                }
            }


            if (PanelNewRow.Visible == true)
            {
                
                string sInsert = "INSERT INTO PhilipsMatrixEdit(Type, Data) VALUES('"+ cmdEditItem.Text.ToLower() + "', '"+ txtData1.Text+ "')";
                DataView MyInsert = Helper.GetData(sInsert);                

                PanelNewRow.Visible = false;
            }

            txtData1.Text = "";

            SetupPage();


        }
        catch { }
    }

    public string ShowMenu()
    {
        string MyMenu = string.Empty;

        try
        {

            string MyMenuMatrix = "<li><a href='/'>MV Matrix</a></li>";
            string MyMenuEdit = "<li><a href='/admin/EditGridData'>MV Edit</a></li>";
            string MyMenuApprove = "<li><a href='/admin/PendingUpdates'>MV Approve</a></li>";

            string MyMenuEditData = "<li><a href='/admin/MVMatrix-Edit.aspx'>MV Manage Data</a></li>";
            string MyMenuCopyData = "<li><a href='/admin/MVMatrix-CopyData'>MV Copy Data</a></li>";

            if (Session["UserType"] == null)
            {
                Response.Redirect("/Account/Signin");
            }

            switch (Session["MVMatrix"].ToString())
            {
                case "Super Admin":
                case "ADMIN":
                    MyMenu = MyMenuMatrix + MyMenuEdit + MyMenuApprove + MyMenuEditData + MyMenuCopyData;

                    break;
                case "Super Viewer":
                    MyMenu = MyMenuMatrix + MyMenuEdit + MyMenuApprove;
                    break;
                case "Content Admin":
                case "Editor":
                case "EDIT":
                    MyMenu = MyMenuMatrix + MyMenuEdit;
                    break;

                case "Viewer":
                case "VIEW":
                    MyMenu = MyMenuMatrix;
                    break;

                default:
                    Response.Redirect("/Account/Signin");
                    break;
            }





        }
        catch { }

        return MyMenu;
    }

    protected void repDataGrid_ItemCommand(object source, RepeaterCommandEventArgs e)
    {
        try
        {
            if (e.CommandName == "Approve")
            {
                string sURL = "UPDATE PhilipsAttachments SET Approve = 0 WHERE(PhilipsAttachmentsID = " + e.CommandArgument + ")";
                Helper.InsertData(sURL);

                string SQL = "select * from PhilipsAttachments";
                DataView MyDV = Helper.GetData(SQL);


                this.repDataGrid.DataSource = MyDV;
                this.repDataGrid.DataBind();

                PanelNewRow.Visible = false;

            }            

            if (e.CommandName == "DeleteFile")
            {
                //Update statue to 4
                string sURL = "Delete from PhilipsMatrixEdit WHERE MatrixEditID = " + e.CommandArgument ;
                Helper.InsertData(sURL);
                
                SetupPage();
            }



            if (e.CommandName == "Save")
            {
                SaveDataInGrid(e.CommandArgument.ToString());
            }


        }
        catch (Exception ex)
        {
        }
    }

    protected void cmdSaveNew_Click(object sender, EventArgs e)
    {
        try
        {

            SaveDataInGrid("");
        }
        catch { }
    }

    protected void cmdAddFile_Click(object sender, EventArgs e)
    {
        try
        {

            SaveDataInGrid("");


            string SQL = "SELECT * FROM PhilipsAttachments  order by PhilipsAttachmentsID desc";
            DataView myDV = Helper.GetData(SQL);
            string ID = string.Empty;


            foreach (DataRowView rowView in myDV)
            {
                ID = rowView["PhilipsAttachmentsID"].ToString();
            }

            Response.Redirect("AttachmentsEditFile.aspx?ID=" + ID);


        }
        catch { }
    }


    protected void cmdEditItem_SelectedIndexChanged(object sender, EventArgs e)
    {
        try {

            SetupPage();
        }
        catch { }
    }

    private void SetupPage()
    {
        try
        {

            string sItem = cmdEditItem.Text;

            string SQL = "select * from PhilipsMatrixEdit where Type='"+ sItem  + "'";
            DataView MyDV = Helper.GetData(SQL);


            this.repDataGrid.DataSource = MyDV;
            this.repDataGrid.DataBind();

            PanelNewRow.Visible = false;

        }
        catch { }
    }

    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {
            //https://help.syncfusion.com/js/uploadbox/file-size

            bool Signin = false;

            if (Session["User"] != null)
            {
                if (Session["User"] != null)
                {
                    m_UserName = Session["User"].ToString();
                    //m_UserID = Session["UserID"].ToString();
                    Signin = true;
                }

            }

            if (!Page.IsPostBack)
            {

                SetupPage();

            }


        }
        catch { }
    }


   
}
