﻿using System;
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





public partial class ViewExisting : System.Web.UI.Page
{

    public string m_UserName = string.Empty;
    public string m_UserID = string.Empty;
    public string m_UserType = string.Empty;
    public string m_TableData = string.Empty;


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
        try
        {

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

                //if (Session["SwitchUser"] != null)
                //{
                //    ddlSwitchUser.SelectedValue = Session["Competitors"].ToString();
                //}                           

                //GetGridDBData();

                //this.Grid1.DataSource = PhilipsDataLST;
                //this.Grid1.DataBind();

                //this.Grid1.ToolbarSettings.ShowToolbar = false;
                //this.Grid1.EditSettings.AllowEditing = false;



                DataView myDV =Helper.GetData("Select * from PhilipsLic_Project");


                foreach (DataRowView rowView in myDV)
                {

                    //<td>-</td><td>-</td>
                    m_TableData += "<tr> <th scope='row'><a href='/lic-server/ispConcerto.aspx?id="+ rowView["PhilipsLic_ProjectID"].ToString() + "'>" + rowView["PhilipsLic_ProjectID"].ToString() + "</a></th><td>" + rowView["project_name"].ToString() + "</td><td>" + rowView["lasteditdate"].ToString() + "</td></tr>";

                }

            }

        }
        catch { }
    }


}