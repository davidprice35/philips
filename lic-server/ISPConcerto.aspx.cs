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


public partial class competitive_info_Competitors : System.Web.UI.Page
{
    
    public string m_UserName = string.Empty;
    public string m_UserID = string.Empty;
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
                //Response.Redirect("/Account/Signin");
            }

            switch (Session["Competitors"].ToString())
            {
                case "Super Admin":
                case "ADMIN":
                    MyMenu = MyProfile + MyTracking;
                    break;

                case "Editor":
                case "EDIT":

                    break;

                case "Super Viewer":
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

    protected void ddlSwitchUser_SelectedIndexChanged(object sender, EventArgs e)
    {
        try
        {


            //string sSwitch = ddlSwitchUser.Text;

            //Session["SwitchUser"] = "SwitchUser";
            //Session["Competitors"] = sSwitch;

            //Session["MVMatrix"] = sSwitch;            
            //Session["Clinical"] = sSwitch;
            //Session["Enterprise"] = sSwitch;
            //Session["Services"] = sSwitch;
            //Session["Attachments"] = sSwitch;

            // SetupStartPage();


            Response.Redirect("/competitive-info/Competitors");


        }
        catch { }
    }

    
    protected void Page_Load(object sender, EventArgs e)
    {
        try {

            Session["Competitors"] = "Super Admin";
            Session["User"] = "Jonny";
            Session["UserType"] = "Granted Access";
            //bool Signin = false;




            //if (Session["User"] != null)
            //{
            //    if (Session["User"] != null)
            //    {
            //        m_UserName = Session["User"].ToString();
            //        m_UserID= Session["UserID"].ToString();
            //        m_UserType = Session["Competitors"].ToString();
            //        Signin = true;
            //    }

            //}


            //if (Signin == true)
            //{


            //}
            //else
            //{
            //    Response.Redirect("/Account/Signin");
            //}


            try
            {
                //string EmailName = Request.Headers["Federation-UserPrincipalName"].ToString();
                //Helper.InsertTracking(m_UserID, "Competitors", EmailName);
            }
            catch
            {

                //Helper.InsertTracking(m_UserID, "Competitors", "");
            }




            //if (Session["Competitors"].ToString() == "Super Admin")
            //{
            //   // PanSwitchUser.Visible = true;
            //}
            //else
            //{
            //    if (Session["SwitchUser"] != null)
            //    {
            //    }
            //    else
            //    {
            //      //  PanSwitchUser.Visible = false;
            //    }
            //}

            if (!IsPostBack)
            {

                SetUpApplicationCombo();

                //if (Session["SwitchUser"] != null)
                //{
                //    ddlSwitchUser.SelectedValue = Session["Competitors"].ToString();
                //}                           

                //GetGridDBData();

                //this.Grid1.DataSource = PhilipsDataLST;
                //this.Grid1.DataBind();

                //this.Grid1.ToolbarSettings.ShowToolbar = false;
                //this.Grid1.EditSettings.AllowEditing = false;


            }

        }
        catch { }
    }

    private void SetUpApplicationCombo()
    {
        try {

            //string myID1 = "";
            //string SQL1 = "SELECT * FROM travelma2_phil1.PhilipsLic_Applications where Category in ('Enterprise  Hardware', 'Enterprise Software') order by Applications";
            //DataView MyDV1 = Helper.GetData(SQL1);
            
            //foreach (DataRowView rowView in MyDV1)
            //{
            //    myID1 += rowView["Applications"].ToString() + "||";

            //}



                string SQL = "SELECT * FROM travelma2_phil1.PhilipsLic_Applications where Category not in ('Enterprise Software','Enterprise  Hardware')";
            DataView MyDV = Helper.GetData(SQL);
            string myID = "";
            foreach (DataRowView rowView in MyDV)
            {
                myID = rowView["Applications"].ToString();
                cmdApplication1.Items.Add(new ListItem(rowView["Applications"].ToString(), rowView["Applications"].ToString() + "|" + rowView["Concurrent_Users"].ToString() + "|" + rowView["Concurrent_Default"].ToString() + "|" + rowView["Concurrent_Range"].ToString()));
                cmdApplication2.Items.Add(new ListItem(rowView["Applications"].ToString(), rowView["Applications"].ToString() + "|" + rowView["Concurrent_Users"].ToString() + "|" + rowView["Concurrent_Default"].ToString() + "|" + rowView["Concurrent_Range"].ToString()));
                cmdApplication3.Items.Add(new ListItem(rowView["Applications"].ToString(), rowView["Applications"].ToString() + "|" + rowView["Concurrent_Users"].ToString() + "|" + rowView["Concurrent_Default"].ToString() + "|" + rowView["Concurrent_Range"].ToString()));
                cmdApplication4.Items.Add(new ListItem(rowView["Applications"].ToString(), rowView["Applications"].ToString() + "|" + rowView["Concurrent_Users"].ToString() + "|" + rowView["Concurrent_Default"].ToString() + "|" + rowView["Concurrent_Range"].ToString()));
                
            }

        }
        catch { }
    }

    protected void cmdEdit_Click(object sender, EventArgs e)
    {
        try {

            //this.Grid1.ToolbarSettings.ShowToolbar = true;
            //this.Grid1.EditSettings.AllowEditing = true;

            //GetGridDBData();

            //this.Grid1.DataSource = PhilipsDataLST;
            //this.Grid1.DataBind();

        }
        catch { }
    }

    protected void lnkCentralAddSite_Click(object sender, EventArgs e)
    {

    }
}

//http://localhost:8085/lic-server/ISPConcerto?id=10