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
using System.IO;
using System.Globalization;
//using Syncfusion.JavaScript.Web;
using System.Xml.Serialization;
//using System.Xml;
using Newtonsoft.Json;

using TheArtOfDev.HtmlRenderer.PdfSharp;
using System.Net;

public partial class OutputReportDistributed : System.Web.UI.Page
{
    List<AdditionalApplication> AdditionalApplication1 = new List<AdditionalApplication>();
    List<KeyProjectData> KeyProjectData1 = new List<KeyProjectData>();
    List<KeyPortalData> KeyPortalDat1 = new List<KeyPortalData>();
    List<CoreData> CoreDat1 = new List<CoreData>();
    

    List<SiteInfoData> SiteInfoData1 = new List<SiteInfoData>();

    public string m_decentralised_concurrent_ent_users = string.Empty;
    public string m_decentralised_deliverymodel_ISPSoftware = string.Empty;
    public string m_UserName = string.Empty;
    public string m_UserID = string.Empty;
    public string m_UserType = string.Empty;

    public string m_project_name = string.Empty;
    public string m_customer_name = string.Empty;
    public string m_customer_address = string.Empty;
    public string m_customer_country = string.Empty;

    public string m_customer_po = string.Empty;
    public string m_customer_key_account_email = string.Empty;
    public string m_customer_key_account_first = string.Empty;
    public string m_customer_key_account_last = string.Empty;

    public string m_portalSales_email = string.Empty;
    public string m_portalSales_first = string.Empty;
    public string m_portalSales_last = string.Empty;

    public string m_core_email = string.Empty;
    public string m_core_first = string.Empty;
    public string m_core_last = string.Empty;


    public string m_hospital_name = string.Empty;
    public string m_hospital_street = string.Empty;
    public string m_hospital_site = string.Empty;
    public string m_hospital_connect = string.Empty;
    public string m_hospital_users = string.Empty;

    public string m_centralised_deliverymodel = string.Empty;
    public string m_centralised_deliverymodel_ISPSoftware = string.Empty;

    public string m_OutputTable = string.Empty;

    public string m_OutputTableApplicationsTable = string.Empty;
    public string m_OutputTableApplicationsTR = string.Empty;


    private DataView GetData(string sql)
    {
        DataSet myDS = null;
        DataView myDV = null;

        try
        {


            string connStr = "server=rdsipos01d.cxvevr7ci7iw.eu-west-1.rds.amazonaws.com;user=appadmin; database=innodb; password=jyMMkn9UWTrDosfNNc5zf97Iwua9NIKb9L2cp17K";
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

                //rdr.Close();



                //while (rdr.Read())
                //{
                //    //Console.WriteLine(rdr[0] + " -- " + rdr[1]);
                //    //<option value="UNITED KINGDOM">UNITED KINGDOM</option>
                //    Console.WriteLine("<option value='" + rdr[1] + "'>" + rdr[1] + "</option>");

                //}


            }
            catch (Exception ex)
            {

            }
            conn.Close();




            //DatabaseProviderFactory factory = new DatabaseProviderFactory();
            //Database db = factory.Create("TSOConn");

            //DbCommand dbCommandWrapper = db.GetSqlStringCommand(sql);
            //myDS = db.ExecuteDataSet(dbCommandWrapper);
            //myDV = myDS.Tables[0].DefaultView;


            //DatabaseProviderFactory factory = new DatabaseProviderFactory();
            //Database db = factory.Create("TSOConn");

            //DbCommand dbCommandWrapper = db.GetSqlStringCommand(sql);
            //myDS = db.ExecuteDataSet(dbCommandWrapper);
            //myDV = myDS.Tables[0].DefaultView;

            //Database db = this.GetDatabase();
            //DbCommand dbc = db.GetStoredProcCommand("dbo.uspDeleteSomething");
            //dbc.CommandTimeout = 600;

            //db.AddInParameter(dbc, "@UserUUID", System.Data.DbType.Guid, userUUID);

            //rowsAffected = db.ExecuteNonQuery(dbc);


            //Dataset to daataview

            //DataView dataView = ds.Tables[0].DefaultView;

            //loop

            //foreach (DataRowView rowView in dataView)
            //{
            //    DataRow row = rowView.Row;
            //    // Do something //
            //}

        }
        catch (Exception ex)
        {

            string sds = ex.Message;

        }

        return myDV;
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
    public class SiteInfoData
    {
        public SiteInfoData()
        {

        }
        public SiteInfoData(string No, string HospitalName, string HospitalStreet, string Site, string Connectivity, string Users)
        {
            this.No = No;
            this.HospitalName = HospitalName;
            this.HospitalStreet = HospitalStreet;
            this.Site = Site;
            this.Connectivity = Connectivity;
            this.Users = Users;
        }

        public string No { get; set; }
        public string HospitalName { get; set; }
        public string HospitalStreet { get; set; }
        public string Site { get; set; }
        public string Connectivity { get; set; }
        public string Users { get; set; }
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


    [Serializable]
    public class KeyProjectData
    {
        public KeyProjectData()
        {

        }
        public KeyProjectData(string FirstName , string LastName, string Email)
        {
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.Email = Email;
          
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }       
    }

    [Serializable]
    public class KeyPortalData
    {
        public KeyPortalData()
        {

        }
        public KeyPortalData(string FirstName, string LastName, string Email)
        {
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.Email = Email;

        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
    }

    [Serializable]
    public class CoreData
    {
        public CoreData()
        {

        }
        public CoreData(string FirstName, string LastName, string Email)
        {
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.Email = Email;

        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
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

   
    private string GetAppCatData(DataView myApp, string findApp)
    {

        string myCat = string.Empty;

        foreach (DataRowView rowView in myApp)
        {
            if ( rowView["Applications"].ToString() == findApp.Trim() )
            {
                myCat = rowView["Cat_No"].ToString();
            }

            if (myCat =="")
            {
                if (rowView["Applications"].ToString() == findApp.Trim() + " - 1 User")
                {
                    myCat = rowView["Cat_No"].ToString();
                }
            }

        }



        return myCat;

    }

    private string GetAppDategoryData(DataView myApp, string findApp)
    {

        string myCat = string.Empty;

        foreach (DataRowView rowView in myApp)
        {
            if (rowView["Applications"].ToString() == findApp.Trim())
            {
                myCat = rowView["category"].ToString();
            }

            if (myCat == "")
            {
                if (rowView["Applications"].ToString() == findApp.Trim() + " - 1 User")
                {
                    myCat = rowView["category"].ToString();
                }
            }

        }



        return myCat;

    }

    protected void Page_Load(object sender, EventArgs e)
    {
        try {

            Session["Competitors"] = "Super Admin";
            Session["User"] = "Jonny";
            Session["UserType"] = "Granted Access";
            //bool Signin = false;



            if (!IsPostBack)
            {

                DataView myDV = Helper.GetData("Select * from PhilipsLic_Project where PhilipsLic_ProjectID=" + Request.QueryString["id"]);


                foreach (DataRowView rowView in myDV)
                {


                    m_decentralised_concurrent_ent_users = rowView["decentralised_concurrent_ent_users"].ToString();
                    m_decentralised_deliverymodel_ISPSoftware = rowView["decentralised_deliverymodel_ISPSoftware"].ToString();
                    m_centralised_deliverymodel = rowView["centralised_deliverymodel"].ToString();
                    m_project_name = rowView["project_name"].ToString();
                    m_customer_name = rowView["customer_name"].ToString();
                    m_customer_address = rowView["customer_address"].ToString();
                    m_customer_country = rowView["customer_country"].ToString();
                    m_customer_po = rowView["customer_po"].ToString();

                    KeyProjectData1 = JsonConvert.DeserializeObject<List<KeyProjectData>>(rowView["customer_key_account"].ToString());
                    KeyPortalDat1 = JsonConvert.DeserializeObject<List<KeyPortalData>>(rowView["customer_portalsales"].ToString());
                    CoreDat1 = JsonConvert.DeserializeObject<List<CoreData>>(rowView["customer_project_core"].ToString());

                    SiteInfoData1 = JsonConvert.DeserializeObject<List<SiteInfoData>>(rowView["decentralised_siteinfo"].ToString());
                    AdditionalApplication1 = JsonConvert.DeserializeObject<List<AdditionalApplication>>(rowView["decentralised_add_application"].ToString());

                    for (int i = 0; i <= KeyProjectData1.Count-1; i++)
                    {
                        m_customer_key_account_email += KeyProjectData1[i].Email + "<hr/>";
                        m_customer_key_account_first += KeyProjectData1[i].FirstName + "<hr/>";
                        m_customer_key_account_last += KeyProjectData1[i].LastName + "<hr/>";
                    }


                    for (int i = 0; i <= KeyPortalDat1.Count-1; i++)
                    {
                        m_portalSales_email += KeyPortalDat1[i].Email + "<hr/>";
                        m_portalSales_first += KeyPortalDat1[i].FirstName + "<hr/>";
                        m_portalSales_last += KeyPortalDat1[i].LastName + "<hr/>";
                    }


                    for (int i = 0; i <= CoreDat1.Count-1; i++)
                    {
                        m_core_email += CoreDat1[i].Email + "<hr/>";
                        m_core_first += CoreDat1[i].FirstName + "<hr/>";
                        m_core_last += CoreDat1[i].LastName + "<hr/>";
                    }


                    //Hospital
                    for (int i = 0; i <= SiteInfoData1.Count - 1; i++)
                    {
                        m_hospital_name += "<tr><td style='vertical-align: middle;'>"+ (i +1) +"</td><td>" + SiteInfoData1[i].HospitalName + "</td> <td>"+ SiteInfoData1[i].HospitalStreet + "</td> <td>" + SiteInfoData1[i].Users + "</td> <td>" + SiteInfoData1[i].Connectivity + "</td> <td>" + SiteInfoData1[i].Site + " </td></tr>";                       
                    }
                    //Hospital


                    //additional Applications
                    string catName = "";
                    DataView myApp = Helper.GetData("SELECT * FROM travelma2_phil1.PhilipsLic_Applications");
                                     
                    for (int i = 0; i <= AdditionalApplication1.Count - 1; i++)
                    {
                        string[] DataItems = AdditionalApplication1[i].Application.Split('|');
                        string cat = GetAppCatData(myApp, DataItems[0]);

                        catName = GetAppDategoryData(myApp, DataItems[0]);
                        
                        string app = DataItems[0];
                       string appHos = m_hospital_street += AdditionalApplication1[i].HospitalName ;
                       string appCon = AdditionalApplication1[i].ConcurrentUsers ;
                        
                        
                        string[] hospitalarray = appHos.Split('|');

                        string[] mainhospital = hospitalarray[0].Split(':');

                        m_OutputTableApplicationsTR += " <tr> <td> "+ cat + " </td><td> "+ app + "</td><td> "+ appCon + "</td><td> " + mainhospital[0] + "</td><td> " + mainhospital[1] + "</td></tr>";

                        string[] Addtionalhospitalarray = hospitalarray[1].Split(';');

                        foreach (string value in Addtionalhospitalarray)
                        {
                            if (value !="")
                            {
                                string[] addhospitalitems = value.ToString().Split(':');
                                m_OutputTableApplicationsTR += " <tr> <td>  </td><td> </td><td> </td><td> " + addhospitalitems[0] + "</td><td> " + addhospitalitems[1] + "</td></tr>";
                            }
                           // Console.WriteLine($"Part: {value}");
                        }

                    }
                    m_OutputTableApplicationsTable += "<div class='table-responsive' style='margin-left: -16px;'> <p style='color:black;font-weight:bold;'>ADDITIONAL APPLICATIONS</p>  <p><b>"+ catName + "</b></p>  <table class='table table-bordered'> <thead> <tr> <th scope='col' style='background-color: #0b1f65;'>Option Number</th> <th scope='col' style='background-color: #0b1f65;'>Description</th> <th scope='col' style='background-color: #0b1f65;'>Users</th> <th scope='col' style='background-color: #0b1f65;'>Hospital Name</th>  <th scope='col' style='background-color: #0b1f65;'>Users</th> </tr></thead> <tbody> " + m_OutputTableApplicationsTR + " </tbody> </table></div>";
                    //additional Applications




                    string tableelement = "";
                    
                    List<MacAddressData> MacAddressData1 = new List<MacAddressData>();

                    MacAddressData1 = JsonConvert.DeserializeObject<List<MacAddressData>>(m_decentralised_deliverymodel_ISPSoftware);
                    int outeridx = 0;

                    string currentidx = string.Empty;
                    int macidx = 1;
                    string machid = "";

                    for (int i = 0; i <= MacAddressData1.Count - 1; i++)
                    {

                        string ItemNo = MacAddressData1[i].No;

                        if (currentidx == "")
                        {
                            currentidx = MacAddressData1[i].No;
                        }

                        if (ItemNo == currentidx)
                        {
                            tableelement += "<tr><td> " + MacAddressData1[i].Menu + " </td><td> " + MacAddressData1[i].MacAddress + " </td></tr>";
                        }
                        else
                        {
                            m_OutputTable += "<div class='table-responsive' style='margin-left: -16px;'> <p style='color:black;font-weight:bold;'> SITE: " + currentidx + "  </p> <table class='table table-bordered'> <thead> <tr> <th scope='col' style='background-color: #0b1f65;'>Menu</th> <th scope='col' style='background-color: #0b1f65;'>Mac address</th> </tr></thead> <tbody> " + tableelement + " </tbody> </table> </div>";

                            currentidx = MacAddressData1[i].No;
                            macidx = 1;
                            machid = "";

                            tableelement = "<tr><td> " + MacAddressData1[i].Menu + " </td><td> " + MacAddressData1[i].MacAddress + " </td></tr>";

                            macidx++;


                        }


                    }



                    m_OutputTable += "<div class='table-responsive' style='margin-left: -16px;'> <p style='color:black;font-weight:bold;'> SITE: " + currentidx + "  </p> <table class='table table-bordered'> <thead> <tr> <th scope='col' style='background-color: #0b1f65;'>Menu</th> <th scope='col' style='background-color: #0b1f65;'>Mac address</th> </tr></thead> <tbody> " + tableelement + " </tbody> </table> </div>";





                }







            }

        }
        catch (Exception ex)
        {

        }
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








    protected void Button1_Click(object sender, EventArgs e)
    {
        try {


            //HttpWebRequest myRequest = (HttpWebRequest)WebRequest.Create("http://philips.com.gridhosted.co.uk/lic-server/OutputReporta.aspx?id=10");
            //myRequest.Method = "GET";
            //WebResponse myResponse = myRequest.GetResponse();
            //StreamReader sr = new StreamReader(myResponse.GetResponseStream(), System.Text.Encoding.UTF8);
            //string result = sr.ReadToEnd();
            //sr.Close();
            //myResponse.Close();


            string result = @"<div class='body - section - design'> <div class='col - sm - 3 col - md - 3 col - lg - 2 left - padding'> <div class='left - sidebar camparision - section'> </div></div><div class='col - lg - 12 col - md - 12 col - sm - 9 right - padding'> <div class='rightbar'> <ul class='nav nav-tabs'> <li class='active'><a href=' / '>ORDERING INFORMATION</a></li></ul> <div class='tab - content toshiba - content ' style=''> <div id='home' class='tab - pane fade in active'> <div style='margin - top: 30px; height: auto; '> <div class='container'> <asp:Button ID='Button1' runat='server' OnClick='Button1_Click' Text='Download PDF'/> <div class='table - responsive' style='margin - left: -16px; '> <table class='table table-bordered'> <thead> <tr> <th scope='col' style='background - color: #0b1f65; border-right-color: #0b1f65; text-align: left; padding-left: 16px; width: 200px'>Project Name </th> <th scope='col' style='background-color: #0b1f65;'></th> </tr></thead> <tbody> <tr> <td style='vertical-align: middle;'>Project Name* </td><td> <%=m_project_name %> </td></tr></tbody> </table> </div><div class='table-responsive' style='margin-left: -16px;'> <table class='table table-bordered'> <thead> <tr> <th scope='col' style='background-color: #0b1f65; border-right-color: #0b1f65; text-align: left; padding-left: 16px; width: 200px'>Customer</th> <th scope='col' style='background-color: #0b1f65;'></th> </tr></thead> <tbody> <tr> <td style='vertical-align: middle;'>Customer Name* </td><td> <%=m_customer_name %> </td></tr><tr> <td>Customer Address*</td><td> <%=m_customer_address %> </td></tr><tr> <td>Country</td><td> <%=m_customer_country %> </td></tr></tbody> </table> </div><div class='table-responsive' style='margin-left: -16px;'> <table class='table table-bordered'> <thead> <tr> <th scope='col' style='background-color: #0b1f65; border-right-color: #0b1f65; text-align: left; padding-left: 16px; width: 200px'>Ordering Information </th> <th scope='col' style='background-color: #0b1f65;'></th> </tr></thead> <tbody> <tr> <td style='vertical-align: middle;'>PO Number*</td><td> <%=m_customer_po %></td></tr></tbody> </table> </div><div class='table-responsive' style='margin-left: -16px;'> <table class='table table-bordered' id='keydtable'> <thead> <tr> <th scope='col' style='background-color: #0b1f65; border-right-color: #0b1f65; text-align: left; padding-left: 16px; width: 640px'>Project Manager </th> <th scope='col' style='background-color: #0b1f65; border-right-color: #0b1f65; text-align: left; padding-left: 16px; width: 640px'>First Name </th> <th scope='col' style='background-color: #0b1f65; border-right-color: #0b1f65; text-align: left; padding-left: 16px; width: 640px'>Last Name </th> <th scope='col' style='background-color: #0b1f65; border-right-color: #0b1f65; text-align: left; padding-left: 16px; width: 640px'>Email </th> </tr></thead> <tbody> <tr> <td style='vertical-align: middle;'>Key Account Manager</td><td> <%=m_customer_key_account_first %> </td><td> <%=m_customer_key_account_last %> </td><td> <%=m_customer_key_account_email %> </td></tr><tr> <td style='vertical-align: middle;'>InteliSpace Portal Sales Specialist</td><td> <%=m_portalSales_first %> </td><td> <%=m_portalSales_last %> </td><td> <%=m_portalSales_email %> </td></tr><tr> <td style='vertical-align: middle;'>Project core team*</td><td> <%=m_core_first %> </td><td> <%=m_core_last %> </td><td> <%=m_core_email %> </td></tr></tbody> </table> </div><div class='table-responsive' style='margin-left: -16px;'> <table class='table table-bordered' id='keydtable'> <thead> <tr> <th scope='col' style='background-color: #0b1f65; border-right-color: #0b1f65; text-align: left; padding-left: 16px; width: 640px'>Hospital No </th> <th scope='col' style='background-color: #0b1f65; border-right-color: #0b1f65; text-align: left; padding-left: 16px; width: 640px'>Hospital Name </th> <th scope='col' style='background-color: #0b1f65; border-right-color: #0b1f65; text-align: left; padding-left: 16px; width: 640px'>Hospital Street</th> <th scope='col' style='background-color: #0b1f65; border-right-color: #0b1f65; text-align: left; padding-left: 16px; width: 640px'>Site </th> <th scope='col' style='background-color: #0b1f65; border-right-color: #0b1f65; text-align: left; padding-left: 16px; width: 640px'>Connectivity </th> </tr></thead> <tbody> <tr> <td style='vertical-align: middle;'>1</td><td> <%=m_customer_key_account_first %> </td><td> <%=m_customer_key_account_last %> </td><td> <%=m_customer_key_account_email %> </td><td> <%=m_customer_key_account_email %> </td></tr></tbody> </table> </div><div class='table-responsive' style='margin-left: -16px;'> <table class='table table-bordered'> <thead> <tr> <th scope='col' style='background-color: #0b1f65;'>Option Number</th> <th scope='col' style='background-color: #0b1f65;'>Description</th> <th scope='col' style='background-color: #0b1f65;'>Overall Quantity ( select in the tool )</th> </tr></thead> <tbody> <tr> <p style='color:black;font-weight:bold;'>IntelliSpace Portal Enterprise Software</p><td> sdsds </td><td> sdsds </td><td> sdsds </td></tr></tbody> </table> </div><div class='table-responsive' style='margin-left: -16px;'> <table class='table table-bordered'> <thead> <tr> <th scope='col' style='background-color: #0b1f65;'>Option Number</th> <th scope='col' style='background-color: #0b1f65;'>Description</th> <th scope='col' style='background-color: #0b1f65;'>Overall Quantity ( select in the tool )</th> </tr></thead> <tbody> <tr> <p style='color:black;font-weight:bold;'>IntelliSpace Portal Enterprise 3e party applications</p><td> sdsds </td><td> sdsds </td><td> sdsds </td></tr></tbody> </table> </div><div class='table-responsive' style='margin-left: -16px;'> <table class='table table-bordered'> <thead> <tr> <th scope='col' style='background-color: #0b1f65;'>Option Number</th> <th scope='col' style='background-color: #0b1f65;'>Description</th> <th scope='col' style='background-color: #0b1f65;'>Overall Quantity ( select in the tool )</th> </tr></thead> <tbody> <tr> <p style='color:black;font-weight:bold;'>IntelliSpace Portal Enterprise Software</p><td> sdsds </td><td> sdsds </td><td> sdsds </td></tr></tbody> </table> </div><div> </div></div></div></div></div></div></div></div>";




            Byte[] res = null;
            using (MemoryStream ms = new MemoryStream())
            {
                var pdf = PdfGenerator.GeneratePdf(result, PdfSharp.PageSize.A4);
                //pdf.Save(@"d:\Test.pdf");

                pdf.Save(Server.MapPath("~/generated_pdf/document.pdf"));


                Response.Clear();
                Response.ContentType = "application/pdf";
                Response.AppendHeader("Content-Disposition", "attachment; filename=FileName.pdf");
                Response.TransmitFile(Server.MapPath("~/generated_pdf/document.pdf"));
                Response.End();


                //https://htmlrenderer.codeplex.com/wikipage?title=Quick%20start


                //res = ms.ToArray();
            }
            // return res;



        }
        catch (Exception ex)
        {

        }
    }
}