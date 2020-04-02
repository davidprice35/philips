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

public partial class competitive_info_AttachmentsEdit : System.Web.UI.Page
{
    public string m_UserName = string.Empty;




    protected void repDataGrid_ItemDataBound(object sender, RepeaterItemEventArgs e)
    {
        try
        {
            cboName1.Items.Clear();
            cboName1.Items.Add(new ListItem("Philips", "Philips"));
            cboName1.Items.Add(new ListItem("TeraRecon", "TeraRecon"));
            cboName1.Items.Add(new ListItem("Siemens", "Siemens"));
            cboName1.Items.Add(new ListItem("GE", "GE"));
            cboName1.Items.Add(new ListItem("Cannon", "Cannon"));
            cboName1.Items.Add(new ListItem("Agfa", "Agfa"));
            cboName1.Items.Add(new ListItem("Other", "Other"));

            cboName1.Items.Add(new ListItem("User Guide", "User Guide"));

            cboType1.Items.Clear();
            cboType1.Items.Add(new ListItem("Clinical", "Clinical"));
            cboType1.Items.Add(new ListItem("Enterprise", "Enterprise"));
            cboType1.Items.Add(new ListItem("Service", "Service"));


            string sSQLData = "SELECT * FROM PhilipsAttachments";
            DataView myDV = Helper.GetData(sSQLData);


            //string sSQLAttachmentList = "Select * from PhilipsAttachmentList";
            //DataView myDVAttach = GetData(sSQLAttachmentList);

            //cboFileDisplayName1.Items.Clear();
            //foreach (DataRowView rowView in myDVAttach)
            //{
            //    cboFileDisplayName1.Items.Add(new ListItem(rowView["FileDisplayName"].ToString(), rowView["FileLocation"].ToString()));
            //}


            if (e.Item.ItemType == ListItemType.Item || e.Item.ItemType == ListItemType.AlternatingItem)
            {

                DataRowView drv = e.Item.DataItem as DataRowView;

                string sID = drv.Row["PhilipsAttachmentsID"].ToString();
                string sName = drv.Row["Name"].ToString();
                string sType = drv.Row["Type"].ToString();
                string sFileDisplayName = drv.Row["FileDisplayName"].ToString();
                string sApprove = drv.Row["Approve"].ToString();

                ////Get Current




                System.Web.UI.WebControls.HiddenField HF_ID = e.Item.FindControl("HF_ID") as System.Web.UI.WebControls.HiddenField;
                System.Web.UI.WebControls.DropDownList cboName = e.Item.FindControl("cboName") as System.Web.UI.WebControls.DropDownList;

                System.Web.UI.WebControls.DropDownList cboType = e.Item.FindControl("cboType") as System.Web.UI.WebControls.DropDownList;
                //System.Web.UI.WebControls.DropDownList cboFileDisplayName = e.Item.FindControl("cboFileDisplayName") as System.Web.UI.WebControls.DropDownList;

                System.Web.UI.WebControls.TextBox txtFileName = e.Item.FindControl("txtFileName") as System.Web.UI.WebControls.TextBox;

                //System.Web.UI.WebControls.LinkButton cmdFile = e.Item.FindControl("cmdFile") as System.Web.UI.WebControls.LinkButton;
                //cmdFile.CommandArgument = sID;


                System.Web.UI.WebControls.LinkButton cmdDelete = e.Item.FindControl("cmdDelete") as System.Web.UI.WebControls.LinkButton;
                cmdDelete.CommandArgument = sID;


                System.Web.UI.WebControls.LinkButton cmdSave = e.Item.FindControl("cmdSave") as System.Web.UI.WebControls.LinkButton;
                cmdSave.CommandArgument = sID;

                //if (sApprove!="1")
                //{
                //    cmdApprove.Visible = false;
                //}



                cboName.Items.Add(new ListItem("Philips", "Philips"));
                cboName.Items.Add(new ListItem("TeraRecon", "TeraRecon"));
                cboName.Items.Add(new ListItem("Siemens", "Siemens"));
                cboName.Items.Add(new ListItem("GE", "GE"));
                cboName.Items.Add(new ListItem("Cannon", "Cannon"));
                cboName.Items.Add(new ListItem("Agfa", "Agfa"));
                cboName.Items.Add(new ListItem("Other", "Other"));

                cboName.Items.Add(new ListItem("User Guide", "User Guide"));


                cboType.Items.Add(new ListItem("Clinical", "Clinical"));
                cboType.Items.Add(new ListItem("Enterprise", "Enterprise"));
                cboType.Items.Add(new ListItem("Service", "Service"));


                //foreach (DataRowView rowView in myDVAttach)
                //{                    
                //    cboFileDisplayName.Items.Add(new ListItem(rowView["FileDisplayName"].ToString(), rowView["FileLocation"].ToString()));                    
                //}


                HF_ID.Value = sID;
                cboName.Text = sName;
                cboName1.Text = sName;
                cboType.Text = sType;
                txtFileName.Text = sFileDisplayName;


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


            txtFileName1.Text = "";
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

                    System.Web.UI.WebControls.DropDownList cboName = (System.Web.UI.WebControls.DropDownList)item.FindControl("cboName");
                    System.Web.UI.WebControls.DropDownList cboType = (System.Web.UI.WebControls.DropDownList)item.FindControl("cboType");
                    System.Web.UI.WebControls.TextBox txtFileName = (System.Web.UI.WebControls.TextBox)item.FindControl("txtFileName");
                    System.Web.UI.WebControls.TextBox txtComment = (System.Web.UI.WebControls.TextBox)item.FindControl("txtComment");


                    ///get data to compare                
                    string SQL = "select * from PhilipsAttachments where PhilipsAttachmentsID=" + ID;
                    DataView MyDVOriginal = Helper.GetData(SQL);

                    string Name = string.Empty;
                    string Type = string.Empty;
                    string FileDisplayName = string.Empty;

                    foreach (DataRowView rowView in MyDVOriginal)
                    {
                        Name = rowView["Name"].ToString();
                        Type = rowView["Type"].ToString();
                        FileDisplayName = rowView["FileDisplayName"].ToString();
                    }
                    //////


                    if (Name != cboName.Text)
                    {

                        string SUpdateName = "UPDATE PhilipsAttachments SET approve=1, Comment = '" + txtComment.Text + "', Name = '" + cboName.Text + "' WHERE(PhilipsAttachmentsID = " + HF_ID.Value + ")";
                        string SUpdateFileDisplayName = "INSERT  INTO PhilipsAttachmentsPendingUpdates(AttachmentsID, UpdateColumnName, NewDataUpdate, OldData, Comment, UserID, UserName, Status, Type) VALUES( " + HF_ID.Value + " , 'Name','" + cboName.Text + " ', '" + Name + "', '" + txtComment1.Text + "', '" + Session["UserID"] + "', '" + Session["User"] + "', 1, 'Update')";
                        Helper.InsertData(SUpdateName);
                        Helper.InsertData(SUpdateFileDisplayName);
                    }

                    if (Type != cboType.Text)
                    {

                        string SUpdateType = "UPDATE PhilipsAttachments SET approve=0, Comment = '" + txtComment.Text + "', Type = '" + cboType.Text + "' WHERE(PhilipsAttachmentsID = " + HF_ID.Value + ")";
                        string SUpdateFileDisplayName = "INSERT  INTO PhilipsAttachmentsPendingUpdates(AttachmentsID, UpdateColumnName, NewDataUpdate, OldData, Comment, UserID, UserName, Status, Type) VALUES( " + HF_ID.Value + " , 'Type','" + cboType.Text + " ', '" + Type + "', '" + txtComment1.Text + "', '" + Session["UserID"] + "', '" + Session["User"] + "', 1, 'Update')";
                        Helper.InsertData(SUpdateType);
                        Helper.InsertData(SUpdateFileDisplayName);
                    }

                    if (FileDisplayName != txtFileName.Text)
                    {

                        string sFileDisplayName = "UPDATE PhilipsAttachments SET approve=0, Comment = '" + txtComment.Text + "', FileDisplayName = '" + txtFileName.Text + "' WHERE (PhilipsAttachmentsID = " + HF_ID.Value + ")";
                        string sUpdateFileDisplayName = "INSERT  INTO PhilipsAttachmentsPendingUpdates(AttachmentsID, UpdateColumnName, NewDataUpdate, OldData, Comment, UserID, UserName, Status, Type) VALUES( " + HF_ID.Value + " , 'FileName','" + txtFileName.Text + " ', '" + FileDisplayName + "', '" + txtComment1.Text + "', '" + Session["UserID"] + "', '" + Session["User"] + "', 1, 'Update')";
                        Helper.InsertData(sFileDisplayName);
                        Helper.InsertData(sUpdateFileDisplayName);
                    }

                    SetupPage();

                }
            }


            if (PanelNewRow.Visible == true)
            {

                string SQL = "SELECT * FROM PhilipsAttachmentList order by PhilipsAttachmentListID desc";
                DataView myDV = Helper.GetData(SQL);
                string DisplayName = string.Empty;
                string FileLocation = string.Empty;

                foreach (DataRowView rowView in myDV)
                {
                    DisplayName = rowView["FileDisplayName"].ToString();
                    FileLocation = rowView["FileLocation"].ToString();
                    break;
                }

                string sInsert = "INSERT INTO PhilipsAttachments(Name, Type, FileDisplayName, FileLocation, Approve,Comment) VALUES('" + cboName1.Text + "', '" + cboType1.Text + "', '" + DisplayName + "', '" + FileLocation + "', 9,'" + txtComment1.Text + "');SELECT LAST_INSERT_ID();";
                DataView MyInsert = Helper.GetData(sInsert);

                foreach (DataRowView rowView in MyInsert)
                {
                    string sColumn1 = rowView["LAST_INSERT_ID()"].ToString();

                    string sNewData = "Competitor:" + cboName1.Text + "\r\nType:" + cboType1.Text + "\r\nFilename:" + DisplayName;

                    string SUpdateFileDisplayName = "INSERT  INTO PhilipsAttachmentsPendingUpdates(AttachmentsID, UpdateColumnName, NewDataUpdate, OldData, Comment, UserID, UserName, Status, Type) VALUES( " + sColumn1 + " , 'New Data','" + sNewData + " ', '', '" + txtComment1.Text + "', '" + Session["UserID"] + "', '" + Session["User"] + "', 1, 'Update')";
                    Helper.InsertData(SUpdateFileDisplayName);


                }

                PanelNewRow.Visible = false;
            }

            txtComment1.Text = "";

            SetupPage();


        }
        catch { }
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

            if (e.CommandName == "EditFile")
            {
                Response.Redirect("AttachmentsEditFile.aspx?ID=" + e.CommandArgument);
            }

            if (e.CommandName == "DeleteFile")
            {
                //Update statue to 4
                string sURL = "UPDATE PhilipsAttachments SET Approve = 0 WHERE(PhilipsAttachmentsID = " + e.CommandArgument + ")";
                Helper.InsertData(sURL);

                //Insert attachments pending

                string SQL = "select * from PhilipsAttachments where PhilipsAttachmentsID = " + e.CommandArgument;
                DataView MyDV = Helper.GetData(SQL);
                string filename = "";

                foreach (DataRowView rowView in MyDV)
                {
                    filename = rowView["FileDisplayName"].ToString();

                }


                string SUpdateFileDisplayName = "INSERT  INTO PhilipsAttachmentsPendingUpdates(AttachmentsID, UpdateColumnName, NewDataUpdate, OldData, Comment, UserID, UserName, Status, Type) VALUES( " + e.CommandArgument + ",'Delete Data','Delete:" + filename + " ', '', '', '" + Session["UserID"] + "', '" + Session["User"] + "', 1, 'DELETE')";
                Helper.InsertData(SUpdateFileDisplayName);

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

    private void SetupPage()
    {
        try
        {

            string SQL = "select * from PhilipsAttachments where approve=1  ORDER BY Name";
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