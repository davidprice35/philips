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


//using Syncfusion.JavaScript.Web;


public partial class competitive_info_Competitors : System.Web.UI.Page
{
    
    public string m_UserName = string.Empty;
    public string m_UserID = string.Empty;
    public string m_UserType = string.Empty;
    List<SiteInfoData> SiteInfoData1 = new List<SiteInfoData>();
    List<AdditionalApplication> AdditionalApplication1 = new List<AdditionalApplication>();
    List<MacAddressData> MacAddressData1 = new List<MacAddressData>();
    

    [Serializable]
    public class SiteInfoData
    {
        public SiteInfoData()
        {

        }
        public SiteInfoData(string No, string HospitalName, string HospitalStreet,string Site, string Connectivity)
        {
            this.No = No;
            this.HospitalName = HospitalName;
            this.HospitalStreet = HospitalStreet;
            this.Site = Site;
            this.Connectivity = Connectivity;

        }

        public string No { get; set; }
        public string HospitalName { get; set; }
        public string HospitalStreet { get; set; }
        public string Site { get; set; }
        public string Connectivity { get; set; }
    }



    [Serializable]
    public class AdditionalApplication
    {
        public AdditionalApplication()
        {

        }
        public AdditionalApplication(string No, string Application, string ConcurrentUsers, string HospitalName)
        {
            this.No = No;            
            this.Application = Application;            
            this.ConcurrentUsers = ConcurrentUsers;
            this.HospitalName = HospitalName;
        }

        public string No { get; set; }
        public string Application { get; set; }
        public string ConcurrentUsers { get; set; }
        public string HospitalName { get; set; }        
    }


    [Serializable]
    public class MacAddressData
    {
        public MacAddressData()
        {

        }
        public MacAddressData(string No, string Menu, string MacAddress)
        {
            this.No = No;
            this.Menu = Menu;
            this.MacAddress = MacAddress;
           

        }

        public string No { get; set; }
        public string Menu { get; set; }
        public string MacAddress { get; set; }    
    }


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

            cmdApplication1.Items.Add(new ListItem("", ""));
            cmdApplication2.Items.Add(new ListItem("", ""));
            cmdApplication3.Items.Add(new ListItem("", ""));
            cmdApplication4.Items.Add(new ListItem("", ""));

            foreach (DataRowView rowView in MyDV)
            {
                myID = rowView["Applications"].ToString();
                cmdApplication1.Items.Add(new ListItem(rowView["Cat_No"].ToString() + " - " + rowView["Applications"].ToString(), rowView["Applications"].ToString() + "|" + rowView["Concurrent_Users"].ToString() + "|" + rowView["Concurrent_Default"].ToString() + "|" + rowView["Concurrent_Range"].ToString()));
                cmdApplication2.Items.Add(new ListItem(rowView["Cat_No"].ToString() + " - " + rowView["Applications"].ToString(), rowView["Applications"].ToString() + "|" + rowView["Concurrent_Users"].ToString() + "|" + rowView["Concurrent_Default"].ToString() + "|" + rowView["Concurrent_Range"].ToString()));
                cmdApplication3.Items.Add(new ListItem(rowView["Cat_No"].ToString() + " - " + rowView["Applications"].ToString(), rowView["Applications"].ToString() + "|" + rowView["Concurrent_Users"].ToString() + "|" + rowView["Concurrent_Default"].ToString() + "|" + rowView["Concurrent_Range"].ToString()));
                cmdApplication4.Items.Add(new ListItem(rowView["Cat_No"].ToString() + " - " + rowView["Applications"].ToString(), rowView["Applications"].ToString() + "|" + rowView["Concurrent_Users"].ToString() + "|" + rowView["Concurrent_Default"].ToString() + "|" + rowView["Concurrent_Range"].ToString()));
                
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


    private bool LoopNumberofEntries(string itemtocheck)
    {
        bool hasItem = false;

        try
        {
            foreach (string key in Request.Form)
            {
                if (key == itemtocheck)
                {
                    if (Request.Form[itemtocheck] != "")
                    {
                        hasItem = true;
                    }
                }
            }

        }
        catch { }

        return hasItem;
    }


    private int GetNumberofEntries(string itemtocheck)
    {

        int noItems = 0;
        int idx = 1;
        try
        {

            switch(itemtocheck)
            {
                case "siteinfo":
                    foreach (string key in Request.Form)
                    {

                        bool hasItem = LoopNumberofEntries("txtHospitalName" + idx);

                        if (hasItem)                        
                        {
                            noItems++;
                        }

                        idx++;

                    }
                    break;
                case "addApplication":
                    foreach (string key in Request.Form)
                    {

                        bool hasItem = LoopNumberofEntries("cmdApplication" + idx);

                        if (hasItem)
                        {
                            noItems++;
                        }

                        idx++;

                    }
                    break;
                case "macAddress":
                    foreach (string key in Request.Form)
                    {

                        bool hasItem = LoopNumberofEntries("ApplicationSoftwareOnly" + idx);

                        if (hasItem)
                        {
                            noItems++;
                        }

                        idx++;

                    }
                    break;
            }


           

        }
        catch { }

        return noItems;
    }

    protected void cmdSave_Click(object sender, EventArgs e)
    {
        string txtConcurrent1 = string.Empty;
        string cmdApplication2 = string.Empty;
        string txtConcurrent2 = string.Empty;
        string cmdApplication3 = string.Empty;
        string txtConcurrent3 = string.Empty;
        string cmdApplication4 = string.Empty;
        string txtConcurrent4 = string.Empty;

        string ApplicationSoftwareOnly1 = string.Empty;
        string MacSoftwareOnly1 = string.Empty;

        

        try {

            int siteinfoidx = GetNumberofEntries("siteinfo");


            for (int i = 1; i <= siteinfoidx; i++)
            {
                string item1 = Request.Form["txtHospitalName" + i.ToString()].ToString();
                string item2 = Request.Form["txtHospitalStreet" + i.ToString()].ToString();
                string item3 = Request.Form["HospitalSiteConnectivity" + i.ToString()].ToString();
                string item4 = Request.Form["HospitalSite" + i.ToString()].ToString();

                SiteInfoData1.Add(new SiteInfoData {  No=i.ToString(), HospitalName= item1, HospitalStreet = item2,  Site= item3, Connectivity= item4 });
            }


            
            string CONCURRENTENTERPRISEUSERS = Request.Form["CONCURRENTENTERPRISEUSERS"].ToString();



            int addApplicationidx = GetNumberofEntries("addApplication");


            for (int i = 1; i <= addApplicationidx; i++)
            {
                string item1 = Request.Form["cmdApplication" + i.ToString()].ToString();
                string item2 = Request.Form["hidtxtConcurrent" + i.ToString()].ToString();
                string item3 = "";
                if (Request.Form["cmdHospitalName" + i.ToString()] !=null)
                {
                    item3 = Request.Form["cmdHospitalName" + i.ToString()].ToString();
                }
                else
                {
                    item3 = "";
                }
                
                AdditionalApplication1.Add(new AdditionalApplication {  No = i.ToString() , Application = item1,  ConcurrentUsers = item2 , HospitalName = item3});
            }



            int macidx = GetNumberofEntries("macAddress"); 


            for (int i = 1; i <= macidx; i++)
            {
                string item1 = Request.Form["ApplicationSoftwareOnly" + i.ToString()].ToString();
                string item2 = Request.Form["MacSoftwareOnly" + i.ToString()].ToString();
                
                MacAddressData1.Add(new MacAddressData { No = i.ToString(), Menu = item1, MacAddress = item2});
            }

                       

            //SiteInfoData1.Add(new SiteInfoData { FirstName = t1.Text, LastName = t2.Text, Email = t3.Text });
            // PortalJSON = JsonConvert.SerializeObject(KeyPortalDat1, Formatting.Indented);

            //save DB
            //Request.QueryString["id"]

            //insert or Update

            //SQL = "INSERT INTO PhilipsLic_Project(project_name,customer_name,customer_address,customer_country,customer_po,customer_comments,customer_key_account,customer_portalsales,customer_project_core) VALUES('" + txtProjectName.Text + "','" + txtCustomerName.Text + "','" + txtCustomerAddress.Text + "','" + txtCountry.SelectedValue.ToString() + "','" + txtPONumber.Text + "','" + txtCommentBox.Text + "','" + KeyAccountJSON + "','" + PortalJSON + "','" + CoreJSON + "')";
            //Helper.InsertData(SQL);

            //SQL = "SELECT PhilipsLic_ProjectID FROM travelma2_phil1.PhilipsLic_Project order by PhilipsLic_ProjectID desc limit 1";
            //DataView MyDV = Helper.GetData(SQL);
            //string myID = "";
            //foreach (DataRowView rowView in MyDV)
            //{
            //    myID = rowView["PhilipsLic_ProjectID"].ToString();
            //}





        }
        catch (Exception ex)
        {

        }
    }
}

//http://localhost:8085/lic-server/ISPConcerto?id=10