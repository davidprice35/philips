using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using Microsoft.Practices.EnterpriseLibrary.Data;
using System.Data;
using System.Data.SqlClient;
using System.Data.Common;
using Newtonsoft.Json;
using System.Web.Services;
using System.Web.UI.HtmlControls;
using MySql.Data.MySqlClient;

using Syncfusion.JavaScript;
public partial class Admin_UserProfile : System.Web.UI.Page
{
    public string m_UserName = string.Empty;
    public string m_UserType = string.Empty;


    public string ShowProfileMenu()
    {
        string MyMenu = string.Empty;

        try
        {

            string MyProfile = "<a href='/Admin/UserProfile' class='view_prfl'>View profile <span><i class='fa fa-angle-right' aria-hidden='true'></i></span></a>";
            string MyTracking = "<a href='/Admin/UsageTracking' class='view_prfl'>View tracking <span><i class='fa fa-angle-right' aria-hidden='true'></i></span></a>";


            if (Session["UserType"] == null)
            {
                Response.Redirect("/Account/Signin");
            }

            switch (Session["MVMatrix"].ToString())
            {
                case "Super Admin":
                case "ADMIN":
                    MyMenu = MyProfile + MyTracking;
                    break;

                case "Editor":
                    break;
                case "Viewer":
                case "VIEW":

                    break;

                default:
                    Response.Redirect("/Account/Signin");
                    break;
            }





        }
        catch { }

        return MyMenu;
    }

    private void SaveData(string sql)
    {
        string connStr = "server=rdsipos01d.cxvevr7ci7iw.eu-west-1.rds.amazonaws.com;user=appadmin; database=innodb; password=jyMMkn9UWTrDosfNNc5zf97Iwua9NIKb9L2cp17K;Convert Zero Datetime=True";
        MySqlConnection conn = new MySqlConnection(connStr);

        try
        {
            conn.Open();


            MySqlCommand cmd = new MySqlCommand(sql, conn);
            //MySqlDataReader rdr = cmd.ExecuteReader();

            using (MySqlDataReader rdr = cmd.ExecuteReader())
            {

            }

        }
        catch (Exception ex)
        {
            string sds = ex.Message;
        }

        conn.Close();
    }

    private DataView GetData(string sql)
    {
        DataSet myDS = null;
        DataView myDV = null;


        string connStr = "server=rdsipos01d.cxvevr7ci7iw.eu-west-1.rds.amazonaws.com;user=appadmin; database=innodb; password=jyMMkn9UWTrDosfNNc5zf97Iwua9NIKb9L2cp17K;Convert Zero Datetime=True";
        MySqlConnection conn = new MySqlConnection(connStr);
        try
        {

            conn.Open();


            MySqlCommand cmd = new MySqlCommand(sql, conn);
            //MySqlDataReader rdr = cmd.ExecuteReader();

            using (MySqlDataReader rdr = cmd.ExecuteReader())
            {
                myDS = new DataSet();
                myDS.Tables.Add("Table1");

                //Load DataReader into the DataTable.
                myDS.Tables[0].Load(rdr);
                myDV = myDS.Tables[0].DefaultView;
            }
        }
        catch (Exception ex)
        {

            string sds = ex.Message;

        }

        conn.Close();

        return myDV;
    }

    protected void cmdDeleteItems_Click(object sender, EventArgs e)
    {
        try
        {

            foreach (RepeaterItem item in repDataGrid.Items)
            {

                System.Web.UI.WebControls.HiddenField HF_DataID = (System.Web.UI.WebControls.HiddenField)item.FindControl("HF_DataID");

                System.Web.UI.WebControls.CheckBox cboSelect = (System.Web.UI.WebControls.CheckBox)item.FindControl("cboSelect");

                if (cboSelect.Checked == true)
                {

                    string SQL = "DELETE  FROM PhilipsMatrixUser WHERE(UserID = " + HF_DataID.Value + ")";
                    Helper.InsertData(SQL);
                }
            }

            PageSetUp();


        }
        catch { }

    }
    protected void repDataGrid_ItemDataBound(object sender, RepeaterItemEventArgs e)
    {
        try
        {

            if (e.Item.ItemType == ListItemType.Item || e.Item.ItemType == ListItemType.AlternatingItem)
            {

                DataRowView drv = e.Item.DataItem as DataRowView;

                System.Web.UI.WebControls.HiddenField HF_DataID = e.Item.FindControl("HF_DataID") as System.Web.UI.WebControls.HiddenField;
                System.Web.UI.WebControls.DropDownList cmdMVMatrix = e.Item.FindControl("cmdMVMatrix") as System.Web.UI.WebControls.DropDownList;
                System.Web.UI.WebControls.DropDownList cmdCompetitors = e.Item.FindControl("cmdCompetitors") as System.Web.UI.WebControls.DropDownList;
                System.Web.UI.WebControls.DropDownList cmdClinical = e.Item.FindControl("cmdClinical") as System.Web.UI.WebControls.DropDownList;
                System.Web.UI.WebControls.DropDownList cmdEnterprise = e.Item.FindControl("cmdEnterprise") as System.Web.UI.WebControls.DropDownList;
                System.Web.UI.WebControls.DropDownList cmdServices = e.Item.FindControl("cmdServices") as System.Web.UI.WebControls.DropDownList;
                System.Web.UI.WebControls.DropDownList cmdAttachments = e.Item.FindControl("cmdAttachments") as System.Web.UI.WebControls.DropDownList;
                System.Web.UI.WebControls.DropDownList cboGrantAccess = e.Item.FindControl("cboGrantAccess") as System.Web.UI.WebControls.DropDownList;

                System.Web.UI.WebControls.TextBox txtUserName = e.Item.FindControl("txtUserName") as System.Web.UI.WebControls.TextBox;
                System.Web.UI.WebControls.TextBox txtName = e.Item.FindControl("txtName") as System.Web.UI.WebControls.TextBox;
                System.Web.UI.WebControls.TextBox txtEmail = e.Item.FindControl("txtEmail") as System.Web.UI.WebControls.TextBox;
                System.Web.UI.WebControls.TextBox txtDepartment = e.Item.FindControl("txtDepartment") as System.Web.UI.WebControls.TextBox;
                System.Web.UI.WebControls.TextBox txtLocation = e.Item.FindControl("txtLocation") as System.Web.UI.WebControls.TextBox;
                System.Web.UI.WebControls.TextBox txtApprovedBy = e.Item.FindControl("txtApprovedBy") as System.Web.UI.WebControls.TextBox;

                HF_DataID.Value = drv.Row["UserID"].ToString();
                txtUserName.Text = drv.Row["UserName"].ToString();
                txtName.Text = drv.Row["UserFullName"].ToString();
                txtEmail.Text = drv.Row["UserEmail"].ToString();
                txtDepartment.Text = drv.Row["Department"].ToString();
                txtLocation.Text = drv.Row["Location"].ToString();

                txtApprovedBy.Text = drv.Row["ApprovedBy"].ToString();

                string sUserType = drv.Row["UserType"].ToString();



                switch (sUserType)
                {

                    case "Granted Access":
                        cboGrantAccess.SelectedValue = "Granted Access";
                        break;
                    case "No Access":
                        cboGrantAccess.SelectedValue = "No Access";
                        break;
                    case "Pending":
                        cboGrantAccess.SelectedValue = "Pending";
                        break;




                }


                //MVMatrix
                switch (drv.Row["MVMatrix"].ToString())
                {
                    case "Super Admin":
                        cmdMVMatrix.SelectedValue = "Super Admin";
                        break;
                    case "Super Viewer":
                        cmdMVMatrix.SelectedValue = "Super Viewer";
                        break;
                    case "Viewer":
                        cmdMVMatrix.SelectedValue = "Viewer";
                        break;
                    case "Editor":
                        cmdMVMatrix.SelectedValue = "Editor";
                        break;
                    case "None":
                        cmdMVMatrix.SelectedValue = "None";
                        break;
                }

                //Competitors
                switch (drv.Row["Competitors"].ToString())
                {
                    case "Super Admin":
                        cmdCompetitors.SelectedValue = "Super Admin";
                        break;
                    case "Super Viewer":
                        cmdCompetitors.SelectedValue = "Super Viewer";
                        break;
                    case "Viewer":
                        cmdCompetitors.SelectedValue = "Viewer";
                        break;
                    case "Editor":
                        cmdCompetitors.SelectedValue = "Editor";
                        break;
                    case "None":
                        cmdCompetitors.SelectedValue = "None";
                        break;
                }

                //Clinical
                switch (drv.Row["Clinical"].ToString())
                {
                    case "Super Admin":
                        cmdClinical.SelectedValue = "Super Admin";
                        break;
                    case "Super Viewer":
                        cmdClinical.SelectedValue = "Super Viewer";
                        break;
                    case "Viewer":
                        cmdClinical.SelectedValue = "Viewer";
                        break;
                    case "Editor":
                        cmdClinical.SelectedValue = "Editor";
                        break;
                    case "None":
                        cmdClinical.SelectedValue = "None";
                        break;
                }

                //Enterprise          
                switch (drv.Row["Enterprise"].ToString())
                {
                    case "Super Admin":
                        cmdEnterprise.SelectedValue = "Super Admin";
                        break;
                    case "Super Viewer":
                        cmdEnterprise.SelectedValue = "Super Viewer";
                        break;
                    case "Viewer":
                        cmdEnterprise.SelectedValue = "Viewer";
                        break;
                    case "Editor":
                        cmdEnterprise.SelectedValue = "Editor";
                        break;
                    case "None":
                        cmdEnterprise.SelectedValue = "None";
                        break;
                }

                //Services
                switch (drv.Row["Services"].ToString())
                {
                    case "Super Admin":
                        cmdServices.SelectedValue = "Super Admin";
                        break;
                    case "Super Viewer":
                        cmdServices.SelectedValue = "Super Viewer";
                        break;
                    case "Viewer":
                        cmdServices.SelectedValue = "Viewer";
                        break;
                    case "Editor":
                        cmdServices.SelectedValue = "Editor";
                        break;
                    case "None":
                        cmdServices.SelectedValue = "None";
                        break;
                }

                //Attachments
                switch (drv.Row["Attachments"].ToString())
                {
                    case "Super Admin":
                        cmdAttachments.SelectedValue = "Super Admin";
                        break;
                    case "Super Viewer":
                        cmdAttachments.SelectedValue = "Super Viewer";
                        break;
                    case "Viewer":
                        cmdAttachments.SelectedValue = "Viewer";
                        break;
                    case "Editor":
                        cmdAttachments.SelectedValue = "Editor";
                        break;
                    case "None":
                        cmdAttachments.SelectedValue = "None";
                        break;
                }




            }


        }
        catch (Exception ex)
        {

        }
    }

    private void PageSetUp()
    {
        try
        {

            string SQL = "SELECT * FROM PhilipsMatrixUser";
            DataView MyDV = Helper.GetData(SQL);

            repDataGrid.DataSource = MyDV;
            repDataGrid.DataBind();
        }
        catch { }
    }







    protected void cmdAdd_Click(object sender, EventArgs e)
    {
        try
        {
            PanelNewRow.Visible = true;
        }
        catch { }
    }


    private string DecodeItem(string Item)
    {
        string MyItem = string.Empty;

        try
        {


            switch (Item)
            {
                case "Super Admin":
                    MyItem = "ADMIN";
                    break;
                case "Super Viewer":
                    MyItem = "ADMIN";
                    break;
                case "Content Admin":
                    MyItem = "ADMIN";
                    break;
                case "Editor":
                    MyItem = "ADMIN";
                    break;
                default:
                    MyItem = "VIEW";
                    break;
            }

        }
        catch { }

        return MyItem;

    }
    protected void cmdSave_Click(object sender, EventArgs e)
    {
        string Code1_Email = string.Empty;
        
        try
        {
           
            if (PanelNewRow.Visible == true)
            {
                string SQL1 = "INSERT  INTO PhilipsMatrixUser(UserName, UserFullName, UserEmail, Department, Location, MVMatrix, Competitors, Clinical, Enterprise, Services, Attachments,UserType,ApprovedBy) VALUES('" + txtUserName1.Text + "', '" + txtName1.Text + "', '" + txtEmail1.Text + "', '" + txtDepartment1.Text + "', '" + txtLocation1.Text + "', '" + cmdMVMatrix1.Text + "', '" + cmdCompetitors1.Text + "', '" + cmdClinical1.Text + "', '" + cmdEnterprise1.Text + "', '" + cmdServices1.Text + "', '" + cmdAttachments1.Text + "','" + cboGrantAccess1.Text + "','"+ m_UserName + "')";
                Helper.InsertData(SQL1);
            }


            PanelNewRow.Visible = false;
            txtUserName1.Text = "";
            txtName1.Text = "";
            txtEmail1.Text = "";
            txtDepartment1.Text = "";
            txtLocation1.Text = "";

            foreach (RepeaterItem item in repDataGrid.Items)
            {
                System.Web.UI.WebControls.HiddenField HF_DataID = (System.Web.UI.WebControls.HiddenField)item.FindControl("HF_DataID");

                System.Web.UI.WebControls.DropDownList cmdMVMatrix = (System.Web.UI.WebControls.DropDownList)item.FindControl("cmdMVMatrix");
                System.Web.UI.WebControls.DropDownList cmdCompetitors = (System.Web.UI.WebControls.DropDownList)item.FindControl("cmdCompetitors");
                System.Web.UI.WebControls.DropDownList cmdClinical = (System.Web.UI.WebControls.DropDownList)item.FindControl("cmdClinical");
                System.Web.UI.WebControls.DropDownList cmdEnterprise = (System.Web.UI.WebControls.DropDownList)item.FindControl("cmdEnterprise");
                System.Web.UI.WebControls.DropDownList cmdServices = (System.Web.UI.WebControls.DropDownList)item.FindControl("cmdServices");
                System.Web.UI.WebControls.DropDownList cmdAttachments = (System.Web.UI.WebControls.DropDownList)item.FindControl("cmdAttachments");
                System.Web.UI.WebControls.DropDownList cboGrantAccess = (System.Web.UI.WebControls.DropDownList)item.FindControl("cboGrantAccess");

                System.Web.UI.WebControls.TextBox txtUserName = (System.Web.UI.WebControls.TextBox)item.FindControl("txtUserName");
                System.Web.UI.WebControls.TextBox txtName = (System.Web.UI.WebControls.TextBox)item.FindControl("txtName");
                System.Web.UI.WebControls.TextBox txtEmail = (System.Web.UI.WebControls.TextBox)item.FindControl("txtEmail");
                System.Web.UI.WebControls.TextBox txtDepartment = (System.Web.UI.WebControls.TextBox)item.FindControl("txtDepartment");
                System.Web.UI.WebControls.TextBox txtLocation = (System.Web.UI.WebControls.TextBox)item.FindControl("txtLocation");


                string UserType = cboGrantAccess.Text;
                if (UserType == "")
                {

                }


                try
                {

                    Code1_Email = Request.Headers["Federation-UserPrincipalName"].ToString();
                }
                catch { }

                //check user for granted access
                if (Code1_Email != "")
                {
                    bool isSame = true;
                    string SQLCheck = "SELECT UserType,UserEmail FROM PhilipsMatrixUser where UserID = " + HF_DataID.Value;
                    DataView MyDVCheck = Helper.GetData(SQLCheck);
                    foreach (DataRowView rowView in MyDVCheck)
                    {
                        if (cboGrantAccess.Text != rowView["UserType"].ToString())
                        {
                            isSame = false;
                            if (cboGrantAccess.Text == "Granted Access")
                            {
                               Helper.SendEmail(rowView["UserEmail"].ToString(), "ISP Sales Tool", "This email is to inform you that you now have access to ISP Sales Tool.<br/><br/> https://www.ispsalestools.philips.com");
                            }

                            if (cboGrantAccess.Text == "No Access")
                            {
                               Helper.SendEmail(rowView["UserEmail"].ToString(), "ISP Sales Tool", "Unfortunately you have not been granted access at this point for more information please contact ispsalestool@philips.com");
                            }

                            string SQL1 = "UPDATE PhilipsMatrixUser SET ApprovedBy='" + m_UserName + "' WHERE (UserID = " + HF_DataID.Value + ")";
                            Helper.InsertData(SQL1);

                        }



                    }
                }
                /////                

                string SQL = "UPDATE PhilipsMatrixUser SET UserType='" + cboGrantAccess.Text + "', UserName = '" + txtUserName.Text + "', UserFullName = '" + txtName.Text + "', UserEmail = '" + txtEmail.Text + "', Department = '" + txtDepartment.Text + "', Location = '" + txtLocation.Text + "', MVMatrix = '" + cmdMVMatrix.Text + "', Competitors = '" + cmdCompetitors.Text + "', Clinical = '" + cmdClinical.Text + "', Enterprise = '" + cmdEnterprise.Text + "', Services = '" + cmdServices.Text + "', Attachments = '" + cmdAttachments.Text + "' WHERE(UserID = " + HF_DataID.Value + ")";
                Helper.InsertData(SQL);

            }

            PageSetUp();

        }
        catch { }
    }


    protected void Page_Load(object sender, EventArgs e)
    {

        try
        {

            bool Signin = false;

            if (Session["User"] != null)
            {
                if (Session["User"] != null)
                {
                    m_UserName = Session["User"].ToString();
                    m_UserType = Session["MVMatrix"].ToString();
                    if (m_UserType == "Super Admin")
                    {
                        Signin = true;
                    }
                    else
                    {
                        Response.Redirect("/", true);
                    }
                }

            }

            if (!IsPostBack)
            {
                PageSetUp();
            }

        }
        catch { }

    }
}
