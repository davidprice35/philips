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

public partial class competitive_info_Competitors : System.Web.UI.Page
{
    List<AdditionalApplication> AdditionalApplication1 = new List<AdditionalApplication>();
    List<KeyProjectData> KeyProjectData1 = new List<KeyProjectData>();
    List<KeyPortalData> KeyPortalDat1 = new List<KeyPortalData>();
    List<CoreData> CoreDat1 = new List<CoreData>();
    

    List<SiteInfoData> SiteInfoData1 = new List<SiteInfoData>();

    public string m_centralised_concurrent_ent_users = string.Empty;
    public string m_UserName = string.Empty;
    public string m_UserID = string.Empty;
    public string m_UserType = string.Empty;

    public string m_project_name = string.Empty;
    public string m_customer_name = string.Empty;
    public string m_customer_address = string.Empty;
    public string m_customer_country = string.Empty;

    public string m_customer_key_accountOutput = string.Empty;
    public string m_customer_po = string.Empty;
    public string m_customer_key_account_email = string.Empty;
    public string m_customer_key_account_first = string.Empty;
    public string m_customer_key_account_last = string.Empty;

    public string m_portalSalesOutput = string.Empty;
    public string m_portalSales_email = string.Empty;
    public string m_portalSales_first = string.Empty;
    public string m_portalSales_last = string.Empty;

    public string m_coreOutput = string.Empty;
    public string m_core_email = string.Empty;
    public string m_core_first = string.Empty;
    public string m_core_last = string.Empty;

    public string m_HospitalOutput = string.Empty;

    public string m_hospital_name = string.Empty;
    public string m_hospital_street = string.Empty;
    public string m_hospital_site = string.Empty;
    public string m_hospital_connect = string.Empty;

    public string m_centralised_deliverymodel = string.Empty;
    public string m_centralised_deliverymodel_ISPSoftware = string.Empty;

    public string m_OutputTable = string.Empty;

    public string m_OutputTableApplicationsTable = string.Empty;
    public string m_OutputTableApplicationsTR = string.Empty;

    public string m_Block1 = string.Empty;
    public string m_Block2 = string.Empty;

    public string m_centralised_pro_storage = string.Empty;
    public string m_centralised_pro_licence = string.Empty;
    public string m_centralised_pro_testserver = string.Empty;

    public string m_centralised_pre_storage = string.Empty;
    public string m_centralised_pre_storage_total = string.Empty;
    public string m_centralised_pre_host_servers = string.Empty;
    public string m_centralised_pre_licence = string.Empty;
    public string m_centralised_pre_testserver = string.Empty;



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
        public SiteInfoData(string No, string HospitalName, string HospitalStreet, string Site, string Connectivity)
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


    private string GetAppCategoryData(DataView myApp, string findApp)
    {

        string myCat = string.Empty;

        foreach (DataRowView rowView in myApp)
        {
            if (rowView["Applications"].ToString() == findApp)
            {
                myCat = rowView["Category"].ToString();
                break;
            }

        }

        if ( myCat=="")
        {
            switch(findApp.Trim())
            {
                case "NM Amyloid Analysis":
                    myCat = "3e Party Applications";
                    break;
                case "NM EQual":
                    myCat = "3e Party Applications";
                    break;
            }
        }


        return myCat;

    }
    private string GetAppCatData(DataView myApp, string findApp)
    {

        string myCat = string.Empty;

        foreach (DataRowView rowView in myApp)
        {
            if ( rowView["Applications"].ToString() == findApp )
            {
                myCat = rowView["Cat_No"].ToString();
            }

        }

        if (myCat=="")
        {
            switch (findApp.Trim())
            {
                case "NM Amyloid Analysis":
                    myCat = "NICA965";
                    break;
                case "NM EQual":
                    myCat = "NICA358";
                    break;
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

                    m_Block1 = rowView["centralised_block1"].ToString();
                    m_Block2 = rowView["centralised_block2"].ToString();

                    m_centralised_pro_storage = rowView["centralised_pro_storage"].ToString();
                    m_centralised_pro_licence = rowView["centralised_pro_licence"].ToString();
                    m_centralised_pro_testserver = rowView["centralised_pro_testserver"].ToString();

                    m_centralised_pre_storage = rowView["centralised_pre_storage"].ToString();
                    m_centralised_pre_storage_total = rowView["centralised_pre_storage_total"].ToString();
                    m_centralised_pre_host_servers = rowView["centralised_pre_host_servers"].ToString();
                    m_centralised_pre_licence = rowView["centralised_pre_licence"].ToString();
                    m_centralised_pre_testserver = rowView["centralised_pre_testserver"].ToString();

               


                    m_centralised_concurrent_ent_users = rowView["centralised_concurrent_ent_users"].ToString();
                    m_centralised_deliverymodel_ISPSoftware = rowView["centralised_deliverymodel_ISPSoftware"].ToString();
                    m_centralised_deliverymodel = rowView["centralised_deliverymodel"].ToString();
                    m_project_name = rowView["project_name"].ToString();
                    m_customer_name = rowView["customer_name"].ToString();
                    m_customer_address = rowView["customer_address"].ToString();
                    m_customer_country = rowView["customer_country"].ToString();
                    m_customer_po = rowView["customer_po"].ToString();

                    KeyProjectData1 = JsonConvert.DeserializeObject<List<KeyProjectData>>(rowView["customer_key_account"].ToString());
                    KeyPortalDat1 = JsonConvert.DeserializeObject<List<KeyPortalData>>(rowView["customer_portalsales"].ToString());
                    CoreDat1 = JsonConvert.DeserializeObject<List<CoreData>>(rowView["customer_project_core"].ToString());
                    SiteInfoData1 = JsonConvert.DeserializeObject<List<SiteInfoData>>(rowView["centralised_siteinfo"].ToString());
                    AdditionalApplication1 = JsonConvert.DeserializeObject<List<AdditionalApplication>>(rowView["centralised_add_application"].ToString());

                    for (int i = 0; i <= KeyProjectData1.Count-1; i++)
                    {                       
                        m_customer_key_accountOutput += "<tr>";
                        if (i == 0)
                        {
                            m_customer_key_accountOutput += "<td style='vertical-align: middle;'>Key Account Manager</td><td>" + KeyProjectData1[i].FirstName + " </td><td> " + KeyProjectData1[i].LastName + "</td><td>" + KeyProjectData1[i].Email + "</td></tr>";
                        }
                        else
                        {
                            m_customer_key_accountOutput += "<td>&nbsp;</td> <td>" + KeyProjectData1[i].FirstName + " </td> <td> " + KeyProjectData1[i].LastName + "</td><td>" + KeyProjectData1[i].Email + "</td></tr>";
                        }


                        //m_customer_key_account_email += KeyProjectData1[i].Email + "<hr/>";
                        //m_customer_key_account_first += KeyProjectData1[i].FirstName + "<hr/>";
                        //m_customer_key_account_last += KeyProjectData1[i].LastName + "<hr/>";
                    }


                    for (int i = 0; i <= KeyPortalDat1.Count-1; i++)
                    {
                        m_portalSalesOutput += "<tr>";
                        if (i == 0)
                        {
                            m_portalSalesOutput += "<td style='vertical-align: middle;'>Portal Sales</td><td>" + KeyPortalDat1[i].FirstName + " </td><td> " + KeyPortalDat1[i].LastName + "</td><td>" + KeyPortalDat1[i].Email + "</td></tr>";
                        }
                        else
                        {
                            m_portalSalesOutput += "<td>&nbsp;</td> <td>" + KeyPortalDat1[i].FirstName + " </td> <td> " + KeyPortalDat1[i].LastName + "</td><td>" + KeyPortalDat1[i].Email + "</td></tr>";
                        }

                        m_portalSales_email += KeyPortalDat1[i].Email + "<hr/>";
                        m_portalSales_first += KeyPortalDat1[i].FirstName + "<hr/>";
                        m_portalSales_last += KeyPortalDat1[i].LastName + "<hr/>";
                    }


                    for (int i = 0; i <= CoreDat1.Count-1; i++)
                    {
                        m_coreOutput += "<tr>";
                        if( i==0)
                        {
                            m_coreOutput += "<td style='vertical-align: middle;'>Project core team*</td><td>" + CoreDat1[i].FirstName + " </td><td> " + CoreDat1[i].LastName + "</td><td>" + CoreDat1[i].Email + "</td></tr>";
                        }else
                        {
                            m_coreOutput += "<td>&nbsp;</td> <td>" + CoreDat1[i].FirstName + " </td> <td> " + CoreDat1[i].LastName + "</td><td>" + CoreDat1[i].Email + "</td></tr>";
                        }
                        
                        //m_core_email += CoreDat1[i].Email + "<hr/>";
                        //m_core_first += CoreDat1[i].FirstName + "<hr/>";
                        //m_core_last += CoreDat1[i].LastName + "<hr/>";
                    }


                    //Hospital
                    for (int i = 0; i <= SiteInfoData1.Count - 1; i++)
                    {
                        m_HospitalOutput += "<tr><td style='vertical-align: middle;'>"+ (i + 1) + "</td><td>" + SiteInfoData1[i].HospitalName + "</td><td>" + SiteInfoData1[i].HospitalStreet + "</td><td>" + SiteInfoData1[i].Site + "</td><td>" + SiteInfoData1[i].Connectivity + "</td></tr>";

                        //m_hospital_name += SiteInfoData1[i].HospitalName + "<br/>";
                        //m_hospital_street += SiteInfoData1[i].HospitalStreet + "<br/>";
                        //m_hospital_site += SiteInfoData1[i].Site + "<br/>";
                        //m_hospital_connect += SiteInfoData1[i].Connectivity + "<br/>";
                    }


                    //additional Applications

                    DataView myApp = Helper.GetData("SELECT * FROM travelma2_phil1.PhilipsLic_Applications");

                    //get cat list 
                    Dictionary<string, string> categorylist = new Dictionary<string, string>();
                    for (int i = 0; i <= AdditionalApplication1.Count - 1; i++)
                    {
                        string[] DataItems = AdditionalApplication1[i].Application.Split('|');
                        string category = GetAppCategoryData(myApp, DataItems[0]);
                        if (!categorylist.ContainsKey(category))
                        {
                            if (category != "")
                            {
                                categorylist.Add(category, category);
                            }
                        }
                    }
                    //get cat list 

                    //loop categories

                    foreach (KeyValuePair<string, string> kvp in categorylist)
                    {
                        m_OutputTableApplicationsTable += "<div class='table-responsive' style='margin-left: -16px;'> <p style='color:black;font-weight:bold;'>" + kvp.Value + "</p><table class='table table-bordered'> <thead> <tr> <th scope='col' style='background-color: #0b1f65;'>Option Number</th> <th scope='col' style='background-color: #0b1f65;'>Description</th> <th scope='col' style='background-color: #0b1f65;'>Overall Quantity ( select in the tool )</th> </tr></thead> <tbody> "; 

                        for (int i = 0; i <= AdditionalApplication1.Count - 1; i++)
                        {
                            if ( i==0)
                            {
                                m_OutputTableApplicationsTR = "";
                            }

                            string[] DataItems = AdditionalApplication1[i].Application.Split('|');
                            string category = GetAppCategoryData(myApp, DataItems[0]);
                            if (category== kvp.Value)
                            {
                                string cat = GetAppCatData(myApp, DataItems[0]);
                                string app = DataItems[0];
                                string appCon = AdditionalApplication1[i].ConcurrentUsers;
                                int myamount = 0;

                                switch (app.Trim())
                                {
                                    case "NM EQual":
                                        myamount = Convert.ToInt32(appCon);
                                        myamount = myamount - 1;
                                        m_OutputTableApplicationsTR += " <tr> <td> " + cat + " </td><td> NM EQual: 1 User</td><td> 1</td></tr>";
                                        m_OutputTableApplicationsTR += " <tr> <td> FIC0086 </ td><td> NM Equal: Additional Users </td><td>" + myamount + "</td></tr>";
                                        break;
                                    case "NM Amyloid Analysis":
                                        myamount = Convert.ToInt32(appCon);
                                        myamount = myamount - 1;
                                        m_OutputTableApplicationsTR += " <tr> <td> " + cat + " </td><td> NM Amyloid Analysis: 1 User</td><td> 1 </td></tr>";
                                        m_OutputTableApplicationsTR += " <tr> <td> FIC0127 </ td><td>  NM Amyloid Analysis: Additional Users </td><td>" + myamount + "</td></tr>";
                                        break;
                                    case "Zero FootPrint Viewer SW - 2 User":
                                        m_OutputTableApplicationsTR += " <tr> <td> " + cat + " </td><td> " + app + "</td><td> " + 2 + "</td></tr>";
                                        myamount = Convert.ToInt32(appCon);
                                        myamount = myamount - 2;
                                        m_OutputTableApplicationsTR += " <tr> <td> FIC0439 </td><td>ZFP Viewer Add_Usr Concerto</td><td> " + myamount + "</td></tr>";
                                        break;
                                    default:
                                        m_OutputTableApplicationsTR += " <tr> <td> " + cat + " </td><td> " + app + "</td><td> " + appCon + "</td></tr>";
                                        break;
                                }
                                
                            }
                        }

                        m_OutputTableApplicationsTable += m_OutputTableApplicationsTR + " </tbody> </table></div>";

                    }

                    //loop categories


                    //    for (int i = 0; i <= AdditionalApplication1.Count - 1; i++)
                    //{
                    //    string[] DataItems = AdditionalApplication1[i].Application.Split('|');
                    //    string cat = GetAppCatData(myApp, DataItems[0]);
                    //    string category = GetAppCategoryData(myApp, DataItems[0]);
                    //    string app = DataItems[0];
                    //   string appHos = m_hospital_street += AdditionalApplication1[i].HospitalName ;
                    //   string appCon = AdditionalApplication1[i].ConcurrentUsers ;

                    //    m_OutputTableApplicationsTR += " <tr> <td> "+ cat + " </td><td> "+ app + "</td><td> "+ appCon + "</td></tr>";


                    //}

                    //m_OutputTableApplicationsTable += "<div class='table-responsive' style='margin-left: -16px;'> <p style='color:black;font-weight:bold;'>IntelliSpace Portal Enterprise Software</p><table class='table table-bordered'> <thead> <tr> <th scope='col' style='background-color: #0b1f65;'>Option Number</th> <th scope='col' style='background-color: #0b1f65;'>Description</th> <th scope='col' style='background-color: #0b1f65;'>Overall Quantity ( select in the tool )</th> </tr></thead> <tbody> "+ m_OutputTableApplicationsTR + " </tbody> </table></div>";
                    //additional Applications




                    //
                    //Delivery model
                    //

                    if (m_centralised_deliverymodel == "SoftwareOnly")
                    {
                        m_OutputTable += "<div class='table-responsive' style='margin-left: -16px;'> <p style='color:black;font-weight:bold;'>DELIVERY MODEL : SOFTWARE ONLY</p> ";
                        m_OutputTable += "</div>";
                    }
                    else
                    {

                        m_OutputTable += "<div class='table-responsive' style='margin-left: -16px;'> <p style='color:black;font-weight:bold;'>DELIVERY MODEL : SOFTWARE & HARDWARE</p> ";

                        if (m_Block1 == "HHANR")
                        {
                            m_OutputTable += "<p style='color:black;font-weight:bold;'>Hardware High Availiabllity NOT required</p> ";
                        }
                        else
                        {
                            //HHAIR
                            m_OutputTable += "<p style='color:black;font-weight:bold;'>Hardware High Availiabllity IS required</p> ";
                        }


                        if (m_Block2 == "Pro")
                        {
                            m_OutputTable += "<p style='color:black;font-weight:bold;'>Pro</p> ";
                            m_OutputTable += "<p style='color:black;font-weight:bold;'>IntelliSpace Portal Enterprise Pro HW</p> ";
                     
                            m_OutputTable += "<p style='color:black;font-weight:bold;'>5TB Additional Storage : "+ m_centralised_pro_storage + " </p> ";
                            m_OutputTable += "<p style='color:black;font-weight:bold;'>ISP Pro License : " + m_centralised_pro_licence + "</p> ";
                            m_OutputTable += "<p style='color:black;font-weight:bold;'>ISP Test Server Software Only? : " + m_centralised_pro_testserver + "</p> ";

                        }
                        else
                        {
                            m_OutputTable += "<p style='color:black;font-weight:bold;'>Premium</p> ";

                            
                            m_OutputTable += "<p style='color:black;font-weight:bold;'>IntelliSpace Portal Enterprise Premium HW</p> ";
                            m_OutputTable += "<p style='color:black;font-weight:bold;'>Do Your Customer requires Philips to provide storage? : " + m_centralised_pre_storage + " </p> ";
                            m_OutputTable += "<p style='color:black;font-weight:bold;'>Total Storage Required : " + m_centralised_pre_storage_total + " </p> ";
                            m_OutputTable += "<p style='color:black;font-weight:bold;'>Total Host servers required : " + m_centralised_pre_host_servers + " </p> ";                            
                            m_OutputTable += "<p style='color:black;font-weight:bold;'>ISP Premium License : " + m_centralised_pre_licence + " </p> ";
                            m_OutputTable += "<p style='color:black;font-weight:bold;'>ISP Test Server Software Only? : " + m_centralised_pre_testserver + " </p> ";

                        }

                        m_OutputTable += "</div>";
                    }


                    ///////////////////////////////////////////////////////////////////////////////////////////////////////
                    //Mac Table
                    string tableelement = "";                    
                    List<MacAddressData> MacAddressData1 = new List<MacAddressData>();
                    MacAddressData1 = JsonConvert.DeserializeObject<List<MacAddressData>>(m_centralised_deliverymodel_ISPSoftware);
                    int outeridx = 0;

                    for (int i = 0; i <= MacAddressData1.Count - 1; i++)
                    {
                        //Enterprise

                        string[] DataItems = MacAddressData1[i].Menu.Split('-');
                        string option = "";
                        string desc = "";
                        int idx = 0;
                        // Part 3: loop over result array.
                        foreach (string word in DataItems)
                        {
                            if (idx == 0)
                            {
                                option = word.Trim();
                            }

                            if (idx == 1)
                            {
                                desc = word.Trim();
                            }

                            idx++;

                        }

                        if (outeridx == 0)
                        {
                            tableelement += "<tr> <p style='color:black;font-weight:bold;'>IntelliSpace Portal Software only</p><td> " + option + " </td><td> " + desc + " </td><td>" + MacAddressData1[i].MacAddress + " </td></tr>";
                        }
                        else
                        {
                            tableelement += "<tr><td> " + option + " </td><td> " + desc + " </td><td> " + MacAddressData1[i].MacAddress + " </td> </tr>";
                        }
                        outeridx++;

                    }

                    m_OutputTable += "<div class='table-responsive' style='margin-left: -16px;'> <table class='table table-bordered'> <thead> <tr> <th scope='col' style='background-color: #0b1f65;'>Option Number</th> <th scope='col' style='background-color: #0b1f65;'>Description</th> <th scope='col' style='background-color: #0b1f65;'>Overall Quantity ( select in the tool )</th> </tr></thead> <tbody> " + tableelement + " </tbody> </table> </div>";



                    





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