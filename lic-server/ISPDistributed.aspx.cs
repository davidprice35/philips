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
    public string m_ID = string.Empty;

    public string m_NoApp = string.Empty;

    public string m_ConEnterpriseUsers = "11";

    public string m_site_info_idx = "1";

    public string m_Hospitallist = "";
    public string m_txtConcurrent1 = "0";
    public string m_txtConcurrent2 = "0";
    public string m_txtConcurrent3 = "0";
    public string m_txtConcurrent4 = "0";
    public string m_txtConcurrent5 = "0";
    public string m_txtConcurrent6 = "0";
    public string m_txtConcurrent7 = "0";
    public string m_txtConcurrent8 = "0";
    public string m_txtConcurrent9 = "0";
    public string m_txtConcurrent10 = "0";
    public string m_txtConcurrent11 = "0";
    public string m_txtConcurrent12 = "0";
    public string m_txtConcurrent13 = "0";
    public string m_txtConcurrent14 = "0";
    public string m_txtConcurrent15 = "0";


    public string m_HostpitalEntryText1 = "0";
    public string m_HostpitalEntryText2 = "0";
    public string m_HostpitalEntryText3 = "0";
    public string m_HostpitalEntryText4 = "0";
    public string m_HostpitalEntryText5 = "0";
    public string m_HostpitalEntryText6 = "0";
    public string m_HostpitalEntryText7 = "0";
    public string m_HostpitalEntryText8 = "0";
    public string m_HostpitalEntryText9 = "0";
    public string m_HostpitalEntryText10 = "0";


    public string m_connectH1 = "checked";
    public string m_connectM1 = "";
    public string m_connectL1 = "";

    public string m_hidMacTable = "NICB006 - Enterprise Engine SW:xxx1,FICO248 - ISP Server - Software only:xxxx2,FICO248 - ISP Server - Software only:xxxx3,FICO248 - ISP Server - Software only:";
    

    public string m_UserName = string.Empty;
    public string m_UserID = string.Empty;
    public string m_UserType = string.Empty;
    List<SiteInfoData> SiteInfoData1 = new List<SiteInfoData>();
    List<AdditionalApplication> AdditionalApplication1 = new List<AdditionalApplication>();

    List<MacAddressData> MacAddressData1 = new List<MacAddressData>();
    List<MacAddressData> RedundantMacAddressData1 = new List<MacAddressData>();
    List<MacAddressData> TestMacAddressData1 = new List<MacAddressData>();

    List<MacAddressData> MacAddressData2 = new List<MacAddressData>();
    List<MacAddressData> RedundantMacAddressData2 = new List<MacAddressData>();
    List<MacAddressData> TestMacAddressData2 = new List<MacAddressData>();

    List<MacAddressData> MacAddressData3 = new List<MacAddressData>();
    List<MacAddressData> RedundantMacAddressData3 = new List<MacAddressData>();
    List<MacAddressData> TestMacAddressData3 = new List<MacAddressData>();

    List<MacAddressData> MacAddressData4 = new List<MacAddressData>();
    List<MacAddressData> RedundantMacAddressData4 = new List<MacAddressData>();
    List<MacAddressData> TestMacAddressData4 = new List<MacAddressData>();

    List<MacAddressData> MacAddressData5 = new List<MacAddressData>();
    List<MacAddressData> RedundantMacAddressData5 = new List<MacAddressData>();
    List<MacAddressData> TestMacAddressData5 = new List<MacAddressData>();

    List<MacAddressData> MacAddressData6 = new List<MacAddressData>();
    List<MacAddressData> RedundantMacAddressData6 = new List<MacAddressData>();
    List<MacAddressData> TestMacAddressData6 = new List<MacAddressData>();

    List<MacAddressData> MacAddressData7 = new List<MacAddressData>();
    List<MacAddressData> RedundantMacAddressData7 = new List<MacAddressData>();
    List<MacAddressData> TestMacAddressData7 = new List<MacAddressData>();

    List<MacAddressData> MacAddressData8 = new List<MacAddressData>();
    List<MacAddressData> RedundantMacAddressData8 = new List<MacAddressData>();
    List<MacAddressData> TestMacAddressData8 = new List<MacAddressData>();

    List<MacAddressData> MacAddressData9 = new List<MacAddressData>();
    List<MacAddressData> RedundantMacAddressData9 = new List<MacAddressData>();
    List<MacAddressData> TestMacAddressData9 = new List<MacAddressData>();


    List<MacAddressData> MacAddressData10 = new List<MacAddressData>();
    List<MacAddressData> RedundantMacAddressData10 = new List<MacAddressData>();
    List<MacAddressData> TestMacAddressData10 = new List<MacAddressData>();

    //decentrailsed
    public string m_EnterpriceInstallMac = string.Empty;




    [Serializable]
    public class SiteData
    {
        public SiteData()
        {

        }
        public SiteData(string SiteNo, string SoftwareOnly, string Hardware, string MacData,string IntelliSpace_Portal_RedundantYes, string IntelliSpace_Portal_RedundantNo,string IntelliSpace_Portal_RedundantSoftwareOnly,string IntelliSpace_Portal_RedundantHardware
            , string IntelliSpace_Portal_RedundantHardwareEnvironment, string IntelliSpace_Portal_RedundantHardwareExtendedMemory,string RedundantSoftwareOnlyMacData , string IntelliSpace_Portal_TestYes, string IntelliSpace_Portal_TestNo, string IntelliSpace_Portal_TestSoftwareOnly
            , string IntelliSpace_Portal_TestHardware, string IntelliSpace_Portal_TestHardwareEnvironment, string IntelliSpace_Portal_TestHardwareExtendedMemory,string TestSoftwareOnlyMacData
            )
        {
            this.SiteNo = SiteNo;
            this.SoftwareOnly = SoftwareOnly;
            this.Hardware = Hardware;
            this.MacData = MacData;
            this.IntelliSpace_Portal_RedundantYes = IntelliSpace_Portal_RedundantYes;
            this.IntelliSpace_Portal_RedundantNo = IntelliSpace_Portal_RedundantNo;
            this.IntelliSpace_Portal_RedundantSoftwareOnly = IntelliSpace_Portal_RedundantNo;
            this.IntelliSpace_Portal_RedundantHardware = IntelliSpace_Portal_RedundantNo;
            this.IntelliSpace_Portal_RedundantHardwareEnvironment = IntelliSpace_Portal_RedundantHardwareEnvironment;
            this.IntelliSpace_Portal_RedundantHardwareExtendedMemory = IntelliSpace_Portal_RedundantHardwareExtendedMemory;
            this.RedundantSoftwareOnlyMacData = RedundantSoftwareOnlyMacData;

            this.IntelliSpace_Portal_TestYes = IntelliSpace_Portal_TestYes;
            this.IntelliSpace_Portal_TestNo = IntelliSpace_Portal_TestNo;
            this.IntelliSpace_Portal_TestSoftwareOnly = IntelliSpace_Portal_TestSoftwareOnly;
            this.IntelliSpace_Portal_TestHardware = IntelliSpace_Portal_TestHardware;
            this.IntelliSpace_Portal_TestHardwareEnvironment = IntelliSpace_Portal_RedundantHardwareEnvironment;
            this.IntelliSpace_Portal_TestHardwareExtendedMemory = IntelliSpace_Portal_RedundantHardwareExtendedMemory;
            this.TestSoftwareOnlyMacData = TestSoftwareOnlyMacData;

        }

        public string SiteNo { get; set; }
        public string SoftwareOnly { get; set; }
        public string Hardware { get; set; }
        public string MacData { get; set; }
        public string IntelliSpace_Portal_RedundantYes { get; set; }
        public string IntelliSpace_Portal_RedundantNo { get; set; }
        public string IntelliSpace_Portal_RedundantSoftwareOnly { get; set; }
        public string IntelliSpace_Portal_RedundantHardware { get; set; }
        public string IntelliSpace_Portal_RedundantHardwareEnvironment { get; set; }
        public string IntelliSpace_Portal_RedundantHardwareExtendedMemory { get; set; }
        public string RedundantSoftwareOnlyMacData { get; set; }

        public string IntelliSpace_Portal_TestYes { get; set; }
        public string IntelliSpace_Portal_TestNo { get; set; }
        public string IntelliSpace_Portal_TestSoftwareOnly { get; set; }
        public string IntelliSpace_Portal_TestHardware { get; set; }
        public string IntelliSpace_Portal_TestHardwareEnvironment { get; set; }
        public string IntelliSpace_Portal_TestHardwareExtendedMemory { get; set; }
        public string TestSoftwareOnlyMacData { get; set; }
    }



    [Serializable]
    public class SiteInfoData
    {
        public SiteInfoData()
        {

        }
        public SiteInfoData(string No, string HospitalName, string HospitalStreet,string Site, string Connectivity,string Users)
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

    
  

    private void SetupPage()
    {
        try
        {

            DataView myDV = Helper.GetData("Select * from PhilipsLic_Project where PhilipsLic_ProjectID=" + Request.QueryString["id"]);
            foreach (DataRowView rowView in myDV)
            {

                HiddenSoftwareHardwareSite1.Value = rowView["decentralised_portal_site1"].ToString(); //software / hardware portal
                HiddenRedundantSite1.Value = rowView["decentralised_portal_redundant_site1"].ToString();
                HiddenTestSite1.Value = rowView["decentralised_portal_test_site1"].ToString();

                m_EnterpriceInstallMac = rowView["decentralised_enterpriceinstallmac"].ToString();
                HiddenPlanInstallEngine.Value = rowView["decentralised_planinstallengine"].ToString();
                HiddenTabLic1.Value = rowView["decentralised_licencemodel1"].ToString();

                hidPortalISPserver1.Value = rowView["decentralised_ISPServer1"].ToString();
                hidPortalExtMemNo1.Value = rowView["decentralised_ExtendedMem1"].ToString();

                hidRedSoftwareHardwareSite1.Value = rowView["decentralised_portal_redundant_SH_site1"].ToString();
                hidRedAppEnvSite1.Value = rowView["decentralised_portal_redundant_appenv_site1"].ToString();
                hidRedExtMemNo1.Value = rowView["decentralised_portal_redundant_extmemory_site1"].ToString();

                hidTestSoftwareHardwareSite1.Value = rowView["decentralised_portal_test_SH_site1"].ToString();
                hidTestEnvSite1.Value = rowView["decentralised_portal_test_appenv_site1"].ToString();
                hidTestExtMemNo1.Value = rowView["decentralised_portal_test_extmemory_site1"].ToString();
                 
                //site info

                SiteInfoData1 = JsonConvert.DeserializeObject<List<SiteInfoData>>(rowView["decentralised_siteinfo"].ToString());
                m_site_info_idx = SiteInfoData1.Count.ToString();
                if (SiteInfoData1.Count > 1) { hidCentralSite.Value = m_site_info_idx; }

                for (int ix = 0; ix <= SiteInfoData1.Count - 1; ix++)
                {
                    switch (ix)
                    {
                        case 0:
                            txtHospitalName1.Text = SiteInfoData1[ix].HospitalName;
                            txtHospitalStreet1.Text = SiteInfoData1[ix].HospitalStreet;
                            switch (SiteInfoData1[ix].Site)
                            {
                                case "High":
                                    m_connectH1 = "checked";
                                    break;
                                case "Med":
                                    m_connectM1 = "checked";
                                    break;
                                case "Low":
                                    m_connectL1 = "checked";
                                    break;
                            }
                            m_HostpitalEntryText1 = SiteInfoData1[ix].Users;
                            break;
                        case 1:
                            txtHospitalName2.Text = SiteInfoData1[ix].HospitalName;
                            txtHospitalStreet2.Text = SiteInfoData1[ix].HospitalStreet;
                            m_HostpitalEntryText2 = SiteInfoData1[ix].Users;
                            break;
                        case 2:
                            txtHospitalName3.Text = SiteInfoData1[ix].HospitalName;
                            txtHospitalStreet3.Text = SiteInfoData1[ix].HospitalStreet;
                            m_HostpitalEntryText3 = SiteInfoData1[ix].Users;
                            break;
                        case 3:
                            txtHospitalName4.Text = SiteInfoData1[ix].HospitalName;
                            txtHospitalStreet4.Text = SiteInfoData1[ix].HospitalStreet;
                            m_HostpitalEntryText4 = SiteInfoData1[ix].Users;
                            break;
                        case 4:
                            txtHospitalName5.Text = SiteInfoData1[ix].HospitalName;
                            txtHospitalStreet5.Text = SiteInfoData1[ix].HospitalStreet;
                            m_HostpitalEntryText5 = SiteInfoData1[ix].Users;
                            break;
                        case 5:
                            txtHospitalName6.Text = SiteInfoData1[ix].HospitalName;
                            txtHospitalStreet6.Text = SiteInfoData1[ix].HospitalStreet;
                            m_HostpitalEntryText6 = SiteInfoData1[ix].Users;
                            break;
                        case 6:
                            txtHospitalName7.Text = SiteInfoData1[ix].HospitalName;
                            txtHospitalStreet7.Text = SiteInfoData1[ix].HospitalStreet;
                            m_HostpitalEntryText7 = SiteInfoData1[ix].Users;
                            break;
                        case 7:
                            txtHospitalName8.Text = SiteInfoData1[ix].HospitalName;
                            txtHospitalStreet8.Text = SiteInfoData1[ix].HospitalStreet;
                            m_HostpitalEntryText8 = SiteInfoData1[ix].Users;
                            break;
                        case 8:
                            txtHospitalName9.Text = SiteInfoData1[ix].HospitalName;
                            txtHospitalStreet9.Text = SiteInfoData1[ix].HospitalStreet;
                            m_HostpitalEntryText9 = SiteInfoData1[ix].Users;
                            break;
                        case 9:
                            txtHospitalName10.Text = SiteInfoData1[ix].HospitalName;
                            txtHospitalStreet10.Text = SiteInfoData1[ix].HospitalStreet;
                            m_HostpitalEntryText10 = SiteInfoData1[ix].Users;
                            break;
                    }
                }


                //concurrent
                m_ConEnterpriseUsers = rowView["decentralised_concurrent_ent_users"].ToString();
                if (m_ConEnterpriseUsers == "")
                {
                    m_ConEnterpriseUsers = "11";
                }

                AdditionalApplication1 = JsonConvert.DeserializeObject<List<AdditionalApplication>>(rowView["decentralised_add_application"].ToString());
                m_NoApp = Convert.ToString(AdditionalApplication1.Count - 1);

                hidadditionalapps.Value = AdditionalApplication1.Count.ToString();

                //hidHospitalData
                string[] splitHospitalname2 = null;
                string[] splitApplicationName = null;

                string[] splitMain_Hospitalname2 = null;
                string[] splitAdditon_Hospitalname2 = null;

                for (int i = 0; i <= AdditionalApplication1.Count - 1; i++)
                {

                    switch (i)
                    {
                        case 0:
                            cmdApplication1.SelectedValue = AdditionalApplication1[i].Application;
                            m_txtConcurrent1 = AdditionalApplication1[i].ConcurrentUsers;

                            string[] splitHospitalname = AdditionalApplication1[i].HospitalName.ToString().Split('|');


                            string[] splitMain_Hospitalname = splitHospitalname[0].Split(':');
                            string[] splitAdditon_Hospitalname = splitHospitalname[1].Split(';');

                            m_Hospitallist = "1:" + splitMain_Hospitalname[0] + "," + splitMain_Hospitalname[1] + "|" + string.Join(",", splitAdditon_Hospitalname);
                            hidHospitalData1.Value = m_Hospitallist;
                            if (splitAdditon_Hospitalname.Length > 1)
                            {
                                hostpitalnewline1.Value = (splitAdditon_Hospitalname.Length-1  ).ToString(); 
                            }
                            
                            break;
                        case 1:
                            cmdApplication2.SelectedValue = AdditionalApplication1[i].Application;
                            m_txtConcurrent2 = AdditionalApplication1[i].ConcurrentUsers;


                            string[] splitHospitalname1 = AdditionalApplication1[i].HospitalName.ToString().Split('|');


                            string[] splitMain_Hospitalname1 = splitHospitalname1[0].Split(':');
                            string[] splitAdditon_Hospitalname1 = splitHospitalname1[1].Split(';');

                            m_Hospitallist = "2:" + splitMain_Hospitalname1[0] + "," + splitMain_Hospitalname1[1] + "|" + string.Join(",", splitAdditon_Hospitalname1);
                            hidHospitalData2.Value = m_Hospitallist;
                            if (splitAdditon_Hospitalname1.Length > 1)
                            {
                                hostpitalnewline2.Value = (splitAdditon_Hospitalname1.Length - 1).ToString();
                            }

                            break;
                        case 2:
                            cmdApplication3.SelectedValue = AdditionalApplication1[i].Application;
                            m_txtConcurrent3 = AdditionalApplication1[i].ConcurrentUsers;
                            
                            splitHospitalname2 = AdditionalApplication1[i].HospitalName.ToString().Split('|');
                            splitMain_Hospitalname2 = splitHospitalname2[0].Split(':');
                            splitAdditon_Hospitalname2 = splitHospitalname2[1].Split(';');

                            m_Hospitallist = "3:" + splitMain_Hospitalname2[0] + "," + splitMain_Hospitalname2[1] + "|" + string.Join(",", splitAdditon_Hospitalname2);
                            hidHospitalData3.Value = m_Hospitallist;
                            if (splitAdditon_Hospitalname2.Length > 1)
                            {
                                hostpitalnewline3.Value = (splitAdditon_Hospitalname2.Length - 1).ToString();
                            }

                            break;
                        case 3:
                            cmdApplication4.SelectedValue = AdditionalApplication1[i].Application;
                            m_txtConcurrent4 = AdditionalApplication1[i].ConcurrentUsers;

                            splitHospitalname2 = AdditionalApplication1[i].HospitalName.ToString().Split('|');
                            splitMain_Hospitalname2 = splitHospitalname2[0].Split(':');
                            splitAdditon_Hospitalname2 = splitHospitalname2[1].Split(';');

                            m_Hospitallist = "4:" + splitMain_Hospitalname2[0] + "," + splitMain_Hospitalname2[1] + "|" + string.Join(",", splitAdditon_Hospitalname2);
                            hidHospitalData4.Value = m_Hospitallist;
                            if (splitAdditon_Hospitalname2.Length > 1)
                            {
                                hostpitalnewline4.Value = (splitAdditon_Hospitalname2.Length - 1).ToString();
                            }


                            break;
                        case 4:
                            cmdApplication5.SelectedValue = AdditionalApplication1[i].Application;
                            m_txtConcurrent5 = AdditionalApplication1[i].ConcurrentUsers;

                            splitHospitalname2 = AdditionalApplication1[i].HospitalName.ToString().Split('|');
                            splitMain_Hospitalname2 = splitHospitalname2[0].Split(':');
                            splitAdditon_Hospitalname2 = splitHospitalname2[1].Split(';');

                            m_Hospitallist = "5:" + splitMain_Hospitalname2[0] + "," + splitMain_Hospitalname2[1] + "|" + string.Join(",", splitAdditon_Hospitalname2);
                            hidHospitalData5.Value = m_Hospitallist;
                            if (splitAdditon_Hospitalname2.Length > 1)
                            {
                                hostpitalnewline5.Value = (splitAdditon_Hospitalname2.Length - 1).ToString();
                            }


                            break;
                        case 5:
                            cmdApplication6.SelectedValue = AdditionalApplication1[i].Application;
                            m_txtConcurrent6 = AdditionalApplication1[i].ConcurrentUsers;

                            splitHospitalname2 = AdditionalApplication1[i].HospitalName.ToString().Split('|');
                            splitMain_Hospitalname2 = splitHospitalname2[0].Split(':');
                            splitAdditon_Hospitalname2 = splitHospitalname2[1].Split(';');

                            m_Hospitallist = "6:" + splitMain_Hospitalname2[0] + "," + splitMain_Hospitalname2[1] + "|" + string.Join(",", splitAdditon_Hospitalname2);
                            hidHospitalData6.Value = m_Hospitallist;
                            if (splitAdditon_Hospitalname2.Length > 1)
                            {
                                hostpitalnewline6.Value = (splitAdditon_Hospitalname2.Length - 1).ToString();
                            }

                            break;

                        case 6:
                            cmdApplication7.SelectedValue = AdditionalApplication1[i].Application;
                            m_txtConcurrent7 = AdditionalApplication1[i].ConcurrentUsers;

                            splitHospitalname2 = AdditionalApplication1[i].HospitalName.ToString().Split('|');
                            splitMain_Hospitalname2 = splitHospitalname2[0].Split(':');
                            splitAdditon_Hospitalname2 = splitHospitalname2[1].Split(';');

                            m_Hospitallist = "7:" + splitMain_Hospitalname2[0] + "," + splitMain_Hospitalname2[1] + "|" + string.Join(",", splitAdditon_Hospitalname2);
                            hidHospitalData7.Value = m_Hospitallist;
                            if (splitAdditon_Hospitalname2.Length > 1)
                            {
                                hostpitalnewline7.Value = (splitAdditon_Hospitalname2.Length - 1).ToString();
                            }

                            break;

                        case 7:
                            cmdApplication8.SelectedValue = AdditionalApplication1[i].Application;
                            m_txtConcurrent8 = AdditionalApplication1[i].ConcurrentUsers;

                            splitHospitalname2 = AdditionalApplication1[i].HospitalName.ToString().Split('|');
                            splitMain_Hospitalname2 = splitHospitalname2[0].Split(':');
                            splitAdditon_Hospitalname2 = splitHospitalname2[1].Split(';');

                            m_Hospitallist = "8:" + splitMain_Hospitalname2[0] + "," + splitMain_Hospitalname2[1] + "|" + string.Join(",", splitAdditon_Hospitalname2);
                            hidHospitalData8.Value = m_Hospitallist;
                            if (splitAdditon_Hospitalname2.Length > 1)
                            {
                                hostpitalnewline8.Value = (splitAdditon_Hospitalname2.Length - 1).ToString();
                            }

                            break;
                    }

                }

                
                               

                //Mac Top Main 1
                MacAddressData1 = JsonConvert.DeserializeObject<List<MacAddressData>>(rowView["decentralised_mac_site1"].ToString());
                string currentidx = string.Empty;
                int macidx = 1;
                string machid = "";
                for (int ixa = 0; ixa <= MacAddressData1.Count - 1; ixa++)
                {
                    string xx = MacAddressData1[ixa].No;

                    if (currentidx=="")
                    {
                        currentidx = MacAddressData1[ixa].No;
                    }

                    if (xx == currentidx)
                    {
                        if (machid!="")
                        {
                            machid += ",";
                        }

                        machid += MacAddressData1[ixa].Menu + ":" + MacAddressData1[ixa].MacAddress;

                        macidx++;
                    }else
                    {
                        switch(currentidx)
                        {
                            case "1":
                                hidMacTable1.Value = machid;
                                break;
                            case "2":
                                hidMacTable2.Value = machid;
                                break;
                            case "3":
                                hidMacTable3.Value = machid;
                                break;
                            case "4":
                                hidMacTable4.Value = machid;
                                break;
                            case "5":
                                hidMacTable5.Value = machid;
                                break;
                            case "6":
                                hidMacTable6.Value = machid;
                                break;
                            case "7":
                                hidMacTable7.Value = machid;
                                break;
                            case "8":
                                hidMacTable8.Value = machid;
                                break;
                            case "9":
                                hidMacTable9.Value = machid;
                                break;
                            case "10":
                                hidMacTable10.Value = machid;
                                break;
                        }
                        

                        currentidx = MacAddressData1[ixa].No;
                        macidx = 1;
                        machid = "";

                        machid += MacAddressData1[ixa].Menu + ":" + MacAddressData1[ixa].MacAddress;

                        macidx++;

                    }
                }


                switch (currentidx)
                {
                    case "1":
                        hidMacTable1.Value = machid;
                        break;
                    case "2":
                        hidMacTable2.Value = machid;
                        break;
                    case "3":
                        hidMacTable3.Value = machid;
                        break;
                    case "4":
                        hidMacTable4.Value = machid;
                        break;
                    case "5":
                        hidMacTable5.Value = machid;
                        break;
                    case "6":
                        hidMacTable6.Value = machid;
                        break;
                    case "7":
                        hidMacTable7.Value = machid;
                        break;
                    case "8":
                        hidMacTable8.Value = machid;
                        break;
                    case "9":
                        hidMacTable9.Value = machid;
                        break;
                    case "10":
                        hidMacTable10.Value = machid;
                        break;
                }



                #region Mac redudant app 
                //Mac Top Main 1
                RedundantMacAddressData1 = JsonConvert.DeserializeObject<List<MacAddressData>>(rowView["decentralised_portal_redundant_mac_site1"].ToString());
                currentidx = string.Empty;
                macidx = 1;
                machid = "";
                for (int ixa = 0; ixa <= RedundantMacAddressData1.Count - 1; ixa++)
                {
                    string xx = RedundantMacAddressData1[ixa].No;

                    if (currentidx == "")
                    {
                        currentidx = RedundantMacAddressData1[ixa].No;
                    }

                    if (xx == currentidx)
                    {
                        if (machid != "")
                        {
                            machid += ",";
                        }

                        machid += RedundantMacAddressData1[ixa].Menu + ":" + RedundantMacAddressData1[ixa].MacAddress;

                        macidx++;
                    }
                    else
                    {
                        switch (currentidx)
                        {
                            case "1":
                                hidmacTableRedundant1.Value = machid;
                                break;
                            case "2":
                                hidmacTableRedundant2.Value = machid;
                                break;
                            case "3":
                                hidmacTableRedundant3.Value = machid;
                                break;
                            case "4":
                                hidmacTableRedundant4.Value = machid;
                                break;
                            case "5":
                                hidmacTableRedundant5.Value = machid;
                                break;
                            case "6":
                                hidMacTable6.Value = machid;
                                break;
                            case "7":
                                hidMacTable7.Value = machid;
                                break;
                            case "8":
                                hidMacTable8.Value = machid;
                                break;
                            case "9":
                                hidMacTable9.Value = machid;
                                break;
                            case "10":
                                hidMacTable10.Value = machid;
                                break;
                        }


                        currentidx = MacAddressData1[ixa].No;
                        macidx = 1;
                        machid = "";

                        machid += MacAddressData1[ixa].Menu + ":" + MacAddressData1[ixa].MacAddress;

                        macidx++;

                    }
                }


                switch (currentidx)
                {
                    case "1":
                        hidmacTableRedundant1.Value = machid;
                        break;
                    case "2":
                        hidmacTableRedundant2.Value = machid;
                        break;
                    case "3":
                        hidmacTableRedundant3.Value = machid;
                        break;
                    case "4":
                        hidmacTableRedundant4.Value = machid;
                        break;
                    case "5":
                        hidmacTableRedundant5.Value = machid;
                        break;
                    case "6":
                        hidmacTableRedundant6.Value = machid;
                        break;
                    case "7":
                        hidmacTableRedundant7.Value = machid;
                        break;
                    case "8":
                        hidmacTableRedundant8.Value = machid;
                        break;
                    case "9":
                        hidmacTableRedundant9.Value = machid;
                        break;
                    case "10":
                        hidmacTableRedundant10.Value = machid;
                        break;
                }
                #endregion



                #region Mac test app 
                //Mac Top Main 1
                TestMacAddressData1 = JsonConvert.DeserializeObject<List<MacAddressData>>(rowView["decentralised_portal_test_mac_site1"].ToString());
                currentidx = string.Empty;
                macidx = 1;
                machid = "";
                for (int ixa = 0; ixa <= TestMacAddressData1.Count - 1; ixa++)
                {
                    string xx = TestMacAddressData1[ixa].No;

                    if (currentidx == "")
                    {
                        currentidx = TestMacAddressData1[ixa].No;
                    }

                    if (xx == currentidx)
                    {
                        if (machid != "")
                        {
                            machid += ",";
                        }

                        machid += TestMacAddressData1[ixa].Menu + ":" + TestMacAddressData1[ixa].MacAddress;

                        macidx++;
                    }
                    else
                    {
                        switch (currentidx)
                        {
                            case "1":
                                hidmacTableTest1.Value = machid;
                                break;
                            case "2":
                                hidmacTableTest2.Value = machid;
                                break;
                            case "3":
                                hidmacTableTest3.Value = machid;
                                break;
                            case "4":
                                hidMacTable4.Value = machid;
                                break;
                            case "5":
                                hidMacTable5.Value = machid;
                                break;
                            case "6":
                                hidMacTable6.Value = machid;
                                break;
                            case "7":
                                hidMacTable7.Value = machid;
                                break;
                            case "8":
                                hidMacTable8.Value = machid;
                                break;
                            case "9":
                                hidMacTable9.Value = machid;
                                break;
                            case "10":
                                hidMacTable10.Value = machid;
                                break;
                        }


                        currentidx = TestMacAddressData1[ixa].No;
                        macidx = 1;
                        machid = "";

                        machid += TestMacAddressData1[ixa].Menu + ":" + TestMacAddressData1[ixa].MacAddress;

                        macidx++;

                    }
                }


                switch (currentidx)
                {
                    case "1":
                        hidmacTableTest1.Value = machid;
                        break;
                    case "2":
                        hidmacTableTest2.Value = machid;
                        break;
                    case "3":
                        hidmacTableTest3.Value = machid;
                        break;
                    case "4":
                        hidmacTableTest4.Value = machid;
                        break;
                    case "5":
                        hidmacTableTest5.Value = machid;
                        break;
                    case "6":
                        hidmacTableRedundant6.Value = machid;
                        break;
                    case "7":
                        hidmacTableRedundant7.Value = machid;
                        break;
                    case "8":
                        hidmacTableRedundant8.Value = machid;
                        break;
                    case "9":
                        hidmacTableRedundant9.Value = machid;
                        break;
                    case "10":
                        hidmacTableRedundant10.Value = machid;
                        break;
                }
                #endregion


                //hidMacTable

                //MacSoftwareOnly1_1
                //MacSoftwareOnly1_2


                //}




            }


            //site info

            //txtHospitalName1






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

          //  cmdApplication1.Items.Add(new ListItem("", ""));
            cmdApplication2.Items.Add(new ListItem("", ""));
            cmdApplication3.Items.Add(new ListItem("", ""));
            cmdApplication4.Items.Add(new ListItem("", ""));
            cmdApplication5.Items.Add(new ListItem("", ""));
            cmdApplication6.Items.Add(new ListItem("", ""));
            cmdApplication7.Items.Add(new ListItem("", ""));
            cmdApplication8.Items.Add(new ListItem("", ""));
            cmdApplication9.Items.Add(new ListItem("", ""));
            cmdApplication10.Items.Add(new ListItem("", ""));
            cmdApplication11.Items.Add(new ListItem("", ""));
            cmdApplication12.Items.Add(new ListItem("", ""));
            cmdApplication13.Items.Add(new ListItem("", ""));
            cmdApplication14.Items.Add(new ListItem("", ""));
            cmdApplication15.Items.Add(new ListItem("", ""));

           // foreach (DataRowView rowView in MyDV)
           // {
               // myID = rowView["Applications"].ToString();
               // cmdApplication1.Items.Add(new ListItem(rowView["Cat_No"].ToString() + " - " + rowView["Applications"].ToString(), rowView["Applications"].ToString() + "|" + rowView["Concurrent_Users"].ToString() + "|" + rowView["Concurrent_Default"].ToString() + "|" + rowView["Concurrent_Range"].ToString()));
                //cmdApplication2.Items.Add(new ListItem(rowView["Cat_No"].ToString() + " - " + rowView["Applications"].ToString(), rowView["Applications"].ToString() + "|" + rowView["Concurrent_Users"].ToString() + "|" + rowView["Concurrent_Default"].ToString() + "|" + rowView["Concurrent_Range"].ToString()));
               // cmdApplication3.Items.Add(new ListItem(rowView["Cat_No"].ToString() + " - " + rowView["Applications"].ToString(), rowView["Applications"].ToString() + "|" + rowView["Concurrent_Users"].ToString() + "|" + rowView["Concurrent_Default"].ToString() + "|" + rowView["Concurrent_Range"].ToString()));
                //cmdApplication4.Items.Add(new ListItem(rowView["Cat_No"].ToString() + " - " + rowView["Applications"].ToString(), rowView["Applications"].ToString() + "|" + rowView["Concurrent_Users"].ToString() + "|" + rowView["Concurrent_Default"].ToString() + "|" + rowView["Concurrent_Range"].ToString()));
                //cmdApplication5.Items.Add(new ListItem(rowView["Cat_No"].ToString() + " - " + rowView["Applications"].ToString(), rowView["Applications"].ToString() + "|" + rowView["Concurrent_Users"].ToString() + "|" + rowView["Concurrent_Default"].ToString() + "|" + rowView["Concurrent_Range"].ToString()));
                //cmdApplication6.Items.Add(new ListItem(rowView["Cat_No"].ToString() + " - " + rowView["Applications"].ToString(), rowView["Applications"].ToString() + "|" + rowView["Concurrent_Users"].ToString() + "|" + rowView["Concurrent_Default"].ToString() + "|" + rowView["Concurrent_Range"].ToString()));
                //cmdApplication7.Items.Add(new ListItem(rowView["Cat_No"].ToString() + " - " + rowView["Applications"].ToString(), rowView["Applications"].ToString() + "|" + rowView["Concurrent_Users"].ToString() + "|" + rowView["Concurrent_Default"].ToString() + "|" + rowView["Concurrent_Range"].ToString()));
                //cmdApplication8.Items.Add(new ListItem(rowView["Cat_No"].ToString() + " - " + rowView["Applications"].ToString(), rowView["Applications"].ToString() + "|" + rowView["Concurrent_Users"].ToString() + "|" + rowView["Concurrent_Default"].ToString() + "|" + rowView["Concurrent_Range"].ToString()));
                //cmdApplication9.Items.Add(new ListItem(rowView["Cat_No"].ToString() + " - " + rowView["Applications"].ToString(), rowView["Applications"].ToString() + "|" + rowView["Concurrent_Users"].ToString() + "|" + rowView["Concurrent_Default"].ToString() + "|" + rowView["Concurrent_Range"].ToString()));
                //cmdApplication10.Items.Add(new ListItem(rowView["Cat_No"].ToString() + " - " + rowView["Applications"].ToString(), rowView["Applications"].ToString() + "|" + rowView["Concurrent_Users"].ToString() + "|" + rowView["Concurrent_Default"].ToString() + "|" + rowView["Concurrent_Range"].ToString()));
                //cmdApplication11.Items.Add(new ListItem(rowView["Cat_No"].ToString() + " - " + rowView["Applications"].ToString(), rowView["Applications"].ToString() + "|" + rowView["Concurrent_Users"].ToString() + "|" + rowView["Concurrent_Default"].ToString() + "|" + rowView["Concurrent_Range"].ToString()));
                //cmdApplication12.Items.Add(new ListItem(rowView["Cat_No"].ToString() + " - " + rowView["Applications"].ToString(), rowView["Applications"].ToString() + "|" + rowView["Concurrent_Users"].ToString() + "|" + rowView["Concurrent_Default"].ToString() + "|" + rowView["Concurrent_Range"].ToString()));
                //cmdApplication13.Items.Add(new ListItem(rowView["Cat_No"].ToString() + " - " + rowView["Applications"].ToString(), rowView["Applications"].ToString() + "|" + rowView["Concurrent_Users"].ToString() + "|" + rowView["Concurrent_Default"].ToString() + "|" + rowView["Concurrent_Range"].ToString()));
                //cmdApplication14.Items.Add(new ListItem(rowView["Cat_No"].ToString() + " - " + rowView["Applications"].ToString(), rowView["Applications"].ToString() + "|" + rowView["Concurrent_Users"].ToString() + "|" + rowView["Concurrent_Default"].ToString() + "|" + rowView["Concurrent_Range"].ToString()));
                //cmdApplication15.Items.Add(new ListItem(rowView["Cat_No"].ToString() + " - " + rowView["Applications"].ToString(), rowView["Applications"].ToString() + "|" + rowView["Concurrent_Users"].ToString() + "|" + rowView["Concurrent_Default"].ToString() + "|" + rowView["Concurrent_Range"].ToString()));


//            }

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
                case "macAddresssections_macTableSO":
                    foreach (string key in Request.Form)
                    {

                        bool hasItem = LoopNumberofEntries("ApplicationSoftwareOnly"+ "macTableSO"  +  idx + "_1");

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

        string id = string.Empty;

        try {


            id = Request.QueryString["id"];

            int siteinfoidx = GetNumberofEntries("siteinfo");
            
            for (int i = 1; i <= siteinfoidx; i++)
            {
                string item1 = Request.Form["txtHospitalName" + i.ToString()].ToString();
                string item2 = Request.Form["txtHospitalStreet" + i.ToString()].ToString();
                string item5 = Request.Form["HostpitalEntryText" + i.ToString()].ToString();
                string item4 = "Remote";                
                string item3 = Request.Form["HospitalRadioConnectivity" + i.ToString()].ToString();
                

                SiteInfoData1.Add(new SiteInfoData {  No=i.ToString(), HospitalName= item1, HospitalStreet = item2,  Site= item3, Connectivity= item4, Users= item5 });
            }
            //serilaze for DB
            string centralised_siteinfo = JsonConvert.SerializeObject(SiteInfoData1, Formatting.Indented);


            string CONCURRENTENTERPRISEUSERS = Request.Form["CONCURRENTENTERPRISEUSERS"].ToString();


            string WhichDeliveryTab = Request.Form["HiddenDeliveryModel"];
            string WhichLicenceModel1 = Request.Form["HiddenTabLic1"];
            string PlanInstallEngine = Request.Form["HiddenPlanInstallEngine"];
            string EnterpriceInstallMac = Request.Form["MacSoftwareOnlyInstall1_1"];

            int addApplicationidx = GetNumberofEntries("addApplication");


            for (int i = 1; i <= addApplicationidx; i++)
            {
                string item1 = Request.Form["cmdApplication" + i.ToString()].ToString();

                if (item1 != "")
                {

                    //concurrent users
                    string item2 = "";
                    try {
                        item2 = Request.Form["txtConcurrent" + i.ToString()].ToString();
                    }
                    catch { }


                    //get hospital count                    
                    string hostitalidx= Request.Form["hostpitalnewline" + i.ToString()].ToString();

                    //hospital name
                    string item3 = "";
                    if (Request.Form["cmdHospitalName" + i.ToString()] != null)
                    {
                        item3 = Request.Form["cmdHospitalName" + i.ToString()].ToString();
                        item3 += ":" + Request.Form["txtCUsers" + i.ToString()].ToString(); 

                    }
                    else
                    {
                        item3 = "";
                    }

                    string additalItems = "";
                    for (int ix = 1; ix <= 10; ix++)
                    {
                        string Hidx =  i.ToString() + "_" + ix.ToString();

                        if (Request.Form["cmdHospitalName" + Hidx] != null)
                        {
                            //cmdHospitalName1_1  txtCUser1_1
                            if (Request.Form["cmdHospitalName" + Hidx].ToString() != "")
                            {
                                additalItems +=  Request.Form["cmdHospitalName" + Hidx].ToString();
                                additalItems += ":" + Request.Form["txtCUsers" + Hidx].ToString() + ";" ;
                            }

                        }
                    }


                    AdditionalApplication1.Add(new AdditionalApplication { No = i.ToString(), Application = item1, ConcurrentUsers = item2, HospitalName = item3 +"|" + additalItems });
                }
            }
            string AdditionalApplication = JsonConvert.SerializeObject(AdditionalApplication1, Formatting.Indented);

            ///////////////////////////////
            ///
            //Delivery Model
            //Site Start
            ////////////////////////////////

            //Intelli Portal Software / Hardware
            
            //Site Start here 
            string Site1SoftwareHardWare = Request.Form["HiddenSoftwareHardwareSite1"].ToString();
            string Site2SoftwareHardWare = Request.Form["HiddenSoftwareHardwareSite2"].ToString();
            string Site3SoftwareHardWare = Request.Form["HiddenSoftwareHardwareSite3"].ToString();
            string Site4SoftwareHardWare = Request.Form["HiddenSoftwareHardwareSite4"].ToString();
            string Site5SoftwareHardWare = Request.Form["HiddenSoftwareHardwareSite5"].ToString();
            string Site6SoftwareHardWare = Request.Form["HiddenSoftwareHardwareSite6"].ToString();
            string Site7SoftwareHardWare = Request.Form["HiddenSoftwareHardwareSite7"].ToString();
            string Site8SoftwareHardWare = Request.Form["HiddenSoftwareHardwareSite8"].ToString();
            string Site9SoftwareHardWare = Request.Form["HiddenSoftwareHardwareSite9"].ToString();
            string Site10SoftwareHardWare = Request.Form["HiddenSoftwareHardwareSite10"].ToString();


            //Redundant No / Yes
            string Site1Redundant = Request.Form["HiddenRedundantSite1"].ToString();
            string Site2Redundant = Request.Form["HiddenRedundantSite2"].ToString();
            string Site3Redundant = Request.Form["HiddenRedundantSite3"].ToString();
            string Site4Redundant = Request.Form["HiddenRedundantSite4"].ToString();
            string Site5Redundant = Request.Form["HiddenRedundantSite5"].ToString();
            string Site6Redundant = Request.Form["HiddenRedundantSite6"].ToString();
            string Site7Redundant = Request.Form["HiddenRedundantSite7"].ToString();
            string Site8Redundant = Request.Form["HiddenRedundantSite8"].ToString();
            string Site9Redundant = Request.Form["HiddenRedundantSite9"].ToString();
            string Site10Redundant = Request.Form["HiddenRedundantSite10"].ToString();



            string Site1RedundantSofHard = Request.Form["hidRedSoftwareHardwareSite1"].ToString();
            string Site2RedundantSofHard = Request.Form["hidRedSoftwareHardwareSite2"].ToString();
            string Site3RedundantSofHard = Request.Form["hidRedSoftwareHardwareSite3"].ToString();
            string Site4RedundantSofHard = Request.Form["hidRedSoftwareHardwareSite4"].ToString();
            string Site5RedundantSofHard = Request.Form["hidRedSoftwareHardwareSite5"].ToString();
            string Site6RedundantSofHard = Request.Form["hidRedSoftwareHardwareSite6"].ToString();
            string Site7RedundantSofHard = Request.Form["hidRedSoftwareHardwareSite7"].ToString();
            string Site8RedundantSofHard = Request.Form["hidRedSoftwareHardwareSite8"].ToString();
            string Site9RedundantSofHard = Request.Form["hidRedSoftwareHardwareSite9"].ToString();
            string Site10RedundantSofHard = Request.Form["hidRedSoftwareHardwareSite10"].ToString();
            


            string Site1hidRedAppEnvSite1 = Request.Form["hidRedAppEnvSite1"].ToString();
            string Site1hidRedAppEnvSite2 = Request.Form["hidRedAppEnvSite2"].ToString();
            string Site1hidRedAppEnvSite3 = Request.Form["hidRedAppEnvSite3"].ToString();
            string Site1hidRedAppEnvSite4 = Request.Form["hidRedAppEnvSite4"].ToString();
            string Site1hidRedAppEnvSite5 = Request.Form["hidRedAppEnvSite5"].ToString();
            string Site1hidRedAppEnvSite6 = Request.Form["hidRedAppEnvSite6"].ToString();
            string Site1hidRedAppEnvSite7 = Request.Form["hidRedAppEnvSite7"].ToString();
            string Site1hidRedAppEnvSite8 = Request.Form["hidRedAppEnvSite8"].ToString();
            string Site1hidRedAppEnvSite9 = Request.Form["hidRedAppEnvSite9"].ToString();
            string Site1hidRedAppEnvSite10 = Request.Form["hidRedAppEnvSite10"].ToString();
            

            string Site1hidRedExtMemNo1 = Request.Form["hidRedExtMemNo1"].ToString();
            string Site1hidRedExtMemNo2 = Request.Form["hidRedExtMemNo2"].ToString();
            string Site1hidRedExtMemNo3 = Request.Form["hidRedExtMemNo3"].ToString();
            string Site1hidRedExtMemNo4 = Request.Form["hidRedExtMemNo4"].ToString();
            string Site1hidRedExtMemNo5 = Request.Form["hidRedExtMemNo5"].ToString();
            string Site1hidRedExtMemNo6 = Request.Form["hidRedExtMemNo6"].ToString();
            string Site1hidRedExtMemNo7 = Request.Form["hidRedExtMemNo7"].ToString();
            string Site1hidRedExtMemNo8 = Request.Form["hidRedExtMemNo8"].ToString();
            string Site1hidRedExtMemNo9 = Request.Form["hidRedExtMemNo9"].ToString();
            string Site1hidRedExtMemNo10 = Request.Form["hidRedExtMemNo10"].ToString();


            string Site1Test = Request.Form["HiddenTestSite1"].ToString();
            string Site2Test = Request.Form["HiddenTestSite2"].ToString();
            string Site3Test = Request.Form["HiddenTestSite3"].ToString();
            string Site4Test = Request.Form["HiddenTestSite4"].ToString();
            string Site5Test = Request.Form["HiddenTestSite5"].ToString();
            string Site6Test = Request.Form["HiddenTestSite6"].ToString();
            string Site7Test = Request.Form["HiddenTestSite7"].ToString();
            string Site8Test = Request.Form["HiddenTestSite8"].ToString();
            string Site9Test = Request.Form["HiddenTestSite9"].ToString();
            string Site10Test = Request.Form["HiddenTestSite10"].ToString();

            string PortalISPserver1 = Request.Form["hidPortalISPserver1"].ToString();
            string PortalISPserver2 = Request.Form["hidPortalISPserver2"].ToString();
            string PortalISPserver3 = Request.Form["hidPortalISPserver3"].ToString();
            string PortalISPserver4 = Request.Form["hidPortalISPserver4"].ToString();
            string PortalISPserver5 = Request.Form["hidPortalISPserver5"].ToString();
            string PortalISPserver6 = Request.Form["hidPortalISPserver6"].ToString();
            string PortalISPserver7 = Request.Form["hidPortalISPserver7"].ToString();
            string PortalISPserver8 = Request.Form["hidPortalISPserver8"].ToString();
            string PortalISPserver9 = Request.Form["hidPortalISPserver9"].ToString();
            string PortalISPserver10 = Request.Form["hidPortalISPserver10"].ToString();

            string PortalExtMemNo1 = Request.Form["hidPortalExtMemNo1"].ToString();
            string PortalExtMemNo2 = Request.Form["hidPortalExtMemNo2"].ToString();
            string PortalExtMemNo3 = Request.Form["hidPortalExtMemNo3"].ToString();
            string PortalExtMemNo4 = Request.Form["hidPortalExtMemNo4"].ToString();
            string PortalExtMemNo5 = Request.Form["hidPortalExtMemNo5"].ToString();
            string PortalExtMemNo6 = Request.Form["hidPortalExtMemNo6"].ToString();
            string PortalExtMemNo7 = Request.Form["hidPortalExtMemNo7"].ToString();
            string PortalExtMemNo8 = Request.Form["hidPortalExtMemNo8"].ToString();
            string PortalExtMemNo9 = Request.Form["hidPortalExtMemNo9"].ToString();
            string PortalExtMemNo10 = Request.Form["hidPortalExtMemNo10"].ToString();
            

            string TesSH_site1 = Request.Form["hidTestSoftwareHardwareSite1"].ToString();
            string TesSH_site2 = Request.Form["hidTestSoftwareHardwareSite2"].ToString();
            string TesSH_site3 = Request.Form["hidTestSoftwareHardwareSite3"].ToString();
            string TesSH_site4 = Request.Form["hidTestSoftwareHardwareSite4"].ToString();
            string TesSH_site5 = Request.Form["hidTestSoftwareHardwareSite5"].ToString();
            string TesSH_site6 = Request.Form["hidTestSoftwareHardwareSite6"].ToString();
            string TesSH_site7 = Request.Form["hidTestSoftwareHardwareSite7"].ToString();
            string TesSH_site8 = Request.Form["hidTestSoftwareHardwareSite8"].ToString();
            string TesSH_site9 = Request.Form["hidTestSoftwareHardwareSite9"].ToString();
            string TesSH_site10 = Request.Form["hidTestSoftwareHardwareSite10"].ToString();
            

            string TestAppEnvSite1 = Request.Form["hidTestEnvSite1"].ToString();
            string TestAppEnvSite2 = Request.Form["hidTestEnvSite2"].ToString();
            string TestAppEnvSite3 = Request.Form["hidTestEnvSite3"].ToString();
            string TestAppEnvSite4 = Request.Form["hidTestEnvSite4"].ToString();
            string TestAppEnvSite5 = Request.Form["hidTestEnvSite5"].ToString();
            string TestAppEnvSite6 = Request.Form["hidTestEnvSite6"].ToString();
            string TestAppEnvSite7 = Request.Form["hidTestEnvSite7"].ToString();
            string TestAppEnvSite8 = Request.Form["hidTestEnvSite8"].ToString();
            string TestAppEnvSite9 = Request.Form["hidTestEnvSite9"].ToString();
            string TestAppEnvSite10 = Request.Form["hidTestEnvSite10"].ToString();
            

            string TestExtMemNo1 = Request.Form["hidTestExtMemNo1"].ToString();
            string TestExtMemNo2 = Request.Form["hidTestExtMemNo2"].ToString();
            string TestExtMemNo3 = Request.Form["hidTestExtMemNo3"].ToString();
            string TestExtMemNo4 = Request.Form["hidTestExtMemNo4"].ToString();
            string TestExtMemNo5 = Request.Form["hidTestExtMemNo5"].ToString();
            string TestExtMemNo6 = Request.Form["hidTestExtMemNo6"].ToString();
            string TestExtMemNo7 = Request.Form["hidTestExtMemNo7"].ToString();
            string TestExtMemNo8 = Request.Form["hidTestExtMemNo8"].ToString();
            string TestExtMemNo9 = Request.Form["hidTestExtMemNo9"].ToString();
            string TestExtMemNo10 = Request.Form["hidTestExtMemNo10"].ToString();

            string sMacAddressData1 = string.Empty;
            string sMacAddressData2 = string.Empty;
            string sMacAddressData3 = string.Empty;
            string sMacAddressData4 = string.Empty;
            string sMacAddressData5 = string.Empty;
            string sMacAddressData6 = string.Empty;
            string sMacAddressData7 = string.Empty;
            string sMacAddressData8 = string.Empty;
            string sMacAddressData9 = string.Empty;
            string sMacAddressData10 = string.Empty;


            string sRedundantMacAddressData1 = string.Empty;
            string sRedundantMacAddressData2 = string.Empty;
            string sRedundantMacAddressData3 = string.Empty;
            string sRedundantMacAddressData4 = string.Empty;
            string sRedundantMacAddressData5 = string.Empty;
            string sRedundantMacAddressData6 = string.Empty;
            string sRedundantMacAddressData7 = string.Empty;
            string sRedundantMacAddressData8 = string.Empty;
            string sRedundantMacAddressData9 = string.Empty;
            string sRedundantMacAddressData10 = string.Empty;

            string sTestMacAddressData1 = string.Empty;
            string sTestMacAddressData2 = string.Empty;
            string sTestMacAddressData3 = string.Empty;
            string sTestMacAddressData4 = string.Empty;
            string sTestMacAddressData5 = string.Empty;
            string sTestMacAddressData6 = string.Empty;
            string sTestMacAddressData7 = string.Empty;
            string sTestMacAddressData8 = string.Empty;
            string sTestMacAddressData9 = string.Empty;
            string sTestMacAddressData10 = string.Empty;

            


            int macidx = GetNumberofEntries("macAddresssections_macTableSO"); 

            //loop sections
            for (int i = 1; i <= macidx; i++)
            {

                int macSection = 0;
                int macSectionidx = 1;
                foreach (string key in Request.Form)
                {

                    bool hasItem = LoopNumberofEntries("ApplicationSoftwareOnly" + i + "_" + macSectionidx);

                    if (hasItem)
                    {
                        macSection++;
                    }

                    macSectionidx++;

                }

                for (int isec = 1; isec <= macSection; isec++)
                {

                    string item1 = Request.Form["ApplicationSoftwareOnly" + "macTableSO"  + i+"_" +isec].ToString();
                    string item2 = Request.Form["MacSoftwareOnly" + "macTableSO" + i + "_" + isec].ToString();

                    switch(i)
                    {
                        case 1:
                            MacAddressData1.Add(new MacAddressData { No = i.ToString(), Menu = item1, MacAddress = item2 });
                            sMacAddressData1 = JsonConvert.SerializeObject(MacAddressData1, Formatting.Indented);
                            break;
                        case 2:
                            MacAddressData2.Add(new MacAddressData { No = i.ToString(), Menu = item1, MacAddress = item2 });
                            sMacAddressData2 = JsonConvert.SerializeObject(MacAddressData2, Formatting.Indented);
                            break;
                        case 3:
                            MacAddressData3.Add(new MacAddressData { No = i.ToString(), Menu = item1, MacAddress = item2 });
                            sMacAddressData3 = JsonConvert.SerializeObject(MacAddressData3, Formatting.Indented);
                            break;
                        case 4:
                            MacAddressData4.Add(new MacAddressData { No = i.ToString(), Menu = item1, MacAddress = item2 });
                            sMacAddressData4 = JsonConvert.SerializeObject(MacAddressData4, Formatting.Indented);
                            break;
                        case 5:
                            MacAddressData5.Add(new MacAddressData { No = i.ToString(), Menu = item1, MacAddress = item2 });
                            sMacAddressData5 = JsonConvert.SerializeObject(MacAddressData5, Formatting.Indented);
                            break;
                        case 6:
                            MacAddressData6.Add(new MacAddressData { No = i.ToString(), Menu = item1, MacAddress = item2 });
                            sMacAddressData6 = JsonConvert.SerializeObject(MacAddressData6, Formatting.Indented);
                            break;
                        case 7:
                            MacAddressData7.Add(new MacAddressData { No = i.ToString(), Menu = item1, MacAddress = item2 });
                            sMacAddressData7 = JsonConvert.SerializeObject(MacAddressData7, Formatting.Indented);
                            break;
                        case 8:
                            MacAddressData8.Add(new MacAddressData { No = i.ToString(), Menu = item1, MacAddress = item2 });
                            sMacAddressData8 = JsonConvert.SerializeObject(MacAddressData8, Formatting.Indented);
                            break;
                        case 9:
                            MacAddressData9.Add(new MacAddressData { No = i.ToString(), Menu = item1, MacAddress = item2 });
                            sMacAddressData9 = JsonConvert.SerializeObject(MacAddressData9, Formatting.Indented);
                            break;
                        case 10:
                            MacAddressData10.Add(new MacAddressData { No = i.ToString(), Menu = item1, MacAddress = item2 });
                            sMacAddressData10 = JsonConvert.SerializeObject(MacAddressData10, Formatting.Indented);
                            break;

                    }
                    
                }
            }

            


            //loop redundant


            

            int RedundantmacSection = 0;
            int RedundantmacSectionidx = 1;
            foreach (string key in Request.Form)
            {

                bool hasItemRedundant = LoopNumberofEntries("ApplicationSoftwareOnlymacTableRedundant" + 1 + "_" + RedundantmacSectionidx);

                if (hasItemRedundant)
                {
                    RedundantmacSection++;
                }

                RedundantmacSectionidx++;

            }

            for (int isec = 1; isec <= RedundantmacSection; isec++)
            {

                string item1 = Request.Form["ApplicationSoftwareOnlymacTableRedundant" + isec + "_" + isec].ToString();
                string item2 = Request.Form["MacSoftwareOnlymacTableRedundant" + isec + "_" + isec].ToString();

                switch (isec)
                {
                    case 1:
                        RedundantMacAddressData1.Add(new MacAddressData { No = isec.ToString(), Menu = item1, MacAddress = item2 });
                        sRedundantMacAddressData1 = JsonConvert.SerializeObject(RedundantMacAddressData1, Formatting.Indented);
                        break;
                    case 2:
                        RedundantMacAddressData2.Add(new MacAddressData { No = isec.ToString(), Menu = item1, MacAddress = item2 });
                        sRedundantMacAddressData2 = JsonConvert.SerializeObject(RedundantMacAddressData2, Formatting.Indented);
                        break;
                    case 3:
                        RedundantMacAddressData3.Add(new MacAddressData { No = isec.ToString(), Menu = item1, MacAddress = item2 });
                        sRedundantMacAddressData3 = JsonConvert.SerializeObject(RedundantMacAddressData3, Formatting.Indented);
                        break;
                    case 4:
                        RedundantMacAddressData4.Add(new MacAddressData { No = isec.ToString(), Menu = item1, MacAddress = item2 });
                        sRedundantMacAddressData4 = JsonConvert.SerializeObject(RedundantMacAddressData4, Formatting.Indented);
                        break;
                    case 5:
                        RedundantMacAddressData5.Add(new MacAddressData { No = isec.ToString(), Menu = item1, MacAddress = item2 });
                        sRedundantMacAddressData5 = JsonConvert.SerializeObject(RedundantMacAddressData5, Formatting.Indented);
                        break;
                    case 6:
                        RedundantMacAddressData6.Add(new MacAddressData { No = isec.ToString(), Menu = item1, MacAddress = item2 });
                        sRedundantMacAddressData6 = JsonConvert.SerializeObject(RedundantMacAddressData6, Formatting.Indented);
                        break;
                    case 7:
                        RedundantMacAddressData7.Add(new MacAddressData { No = isec.ToString(), Menu = item1, MacAddress = item2 });
                        sRedundantMacAddressData7 = JsonConvert.SerializeObject(RedundantMacAddressData7, Formatting.Indented);
                        break;
                    case 8:
                        RedundantMacAddressData8.Add(new MacAddressData { No = isec.ToString(), Menu = item1, MacAddress = item2 });
                        sRedundantMacAddressData8 = JsonConvert.SerializeObject(RedundantMacAddressData8, Formatting.Indented);
                        break;
                    case 9:
                        RedundantMacAddressData9.Add(new MacAddressData { No = isec.ToString(), Menu = item1, MacAddress = item2 });
                        sRedundantMacAddressData9 = JsonConvert.SerializeObject(RedundantMacAddressData9, Formatting.Indented);
                        break;
                    case 10:
                        RedundantMacAddressData10.Add(new MacAddressData { No = isec.ToString(), Menu = item1, MacAddress = item2 });
                        sRedundantMacAddressData10 = JsonConvert.SerializeObject(RedundantMacAddressData10, Formatting.Indented);
                        break;

                }
                
            }


            //loop redundant



            //loop test

           
            int TestmacSection = 0;
            int TestmacSectionidx = 1;
            foreach (string key in Request.Form)
            {

                bool hasItemTest = LoopNumberofEntries("ApplicationSoftwareOnlymacTestTable" + 1 + "_" + TestmacSectionidx);

                if (hasItemTest)
                {
                    TestmacSection++;
                }

                TestmacSectionidx++;

            }

            for (int isec = 1; isec <= TestmacSection; isec++)
            {

                string item1 = Request.Form["ApplicationSoftwareOnlymacTestTable" + isec + "_" + isec].ToString();
                string item2 = Request.Form["MacSoftwareOnlymacTestTable" + isec + "_" + isec].ToString();

                switch (isec)
                {
                    case 1:
                        TestMacAddressData1.Add(new MacAddressData { No = isec.ToString(), Menu = item1, MacAddress = item2 });
                        sTestMacAddressData1 = JsonConvert.SerializeObject(TestMacAddressData1, Formatting.Indented);
                        break;
                    case 2:
                        TestMacAddressData2.Add(new MacAddressData { No = isec.ToString(), Menu = item1, MacAddress = item2 });
                        sTestMacAddressData2 = JsonConvert.SerializeObject(TestMacAddressData2, Formatting.Indented);
                        break;
                    case 3:
                        TestMacAddressData3.Add(new MacAddressData { No = isec.ToString(), Menu = item1, MacAddress = item2 });
                        sTestMacAddressData3 = JsonConvert.SerializeObject(TestMacAddressData3, Formatting.Indented);
                        break;
                    case 4:
                        TestMacAddressData4.Add(new MacAddressData { No = isec.ToString(), Menu = item1, MacAddress = item2 });
                        sTestMacAddressData4 = JsonConvert.SerializeObject(TestMacAddressData4, Formatting.Indented);
                        break;
                    case 5:
                        TestMacAddressData5.Add(new MacAddressData { No = isec.ToString(), Menu = item1, MacAddress = item2 });
                        sTestMacAddressData5 = JsonConvert.SerializeObject(TestMacAddressData5, Formatting.Indented);
                        break;
                    case 6:
                        TestMacAddressData6.Add(new MacAddressData { No = isec.ToString(), Menu = item1, MacAddress = item2 });
                        sTestMacAddressData6 = JsonConvert.SerializeObject(TestMacAddressData6, Formatting.Indented);
                        break;
                    case 7:
                        TestMacAddressData7.Add(new MacAddressData { No = isec.ToString(), Menu = item1, MacAddress = item2 });
                        sTestMacAddressData7 = JsonConvert.SerializeObject(TestMacAddressData7, Formatting.Indented);
                        break;
                    case 8:
                        TestMacAddressData8.Add(new MacAddressData { No = isec.ToString(), Menu = item1, MacAddress = item2 });
                        sTestMacAddressData8 = JsonConvert.SerializeObject(TestMacAddressData8, Formatting.Indented);
                        break;
                    case 9:
                        TestMacAddressData9.Add(new MacAddressData { No = isec.ToString(), Menu = item1, MacAddress = item2 });
                        sTestMacAddressData9 = JsonConvert.SerializeObject(TestMacAddressData9, Formatting.Indented);
                        break;
                    case 10:
                        TestMacAddressData10.Add(new MacAddressData { No = isec.ToString(), Menu = item1, MacAddress = item2 });
                        sTestMacAddressData10 = JsonConvert.SerializeObject(TestMacAddressData10, Formatting.Indented);
                        break;

                }

                
            }


            //loop test


            
            


    

            string SQL = "update  PhilipsLic_Project set decentralised_portal_test_SH_site1='"+ TesSH_site1 + "' , decentralised_portal_test_SH_site2='" + TesSH_site2 + "' ,decentralised_portal_test_SH_site3='" + TesSH_site3 + "',decentralised_portal_test_SH_site4='" + TesSH_site4 + "',decentralised_portal_test_SH_site5='" + TesSH_site5 + "',decentralised_portal_test_SH_site6='" + TesSH_site6 + "',decentralised_portal_test_SH_site7='" + TesSH_site7 + "',decentralised_portal_test_SH_site8='" + TesSH_site8 + "',decentralised_portal_test_SH_site9='" + TesSH_site9 + "',decentralised_portal_test_SH_site10='" + TesSH_site10 + "'  , decentralised_portal_test_appenv_site1='" + TestAppEnvSite1 + "' , decentralised_portal_test_appenv_site2='" + TestAppEnvSite2 + "' , decentralised_portal_test_appenv_site3='" + TestAppEnvSite3 + "', decentralised_portal_test_appenv_site4='" + TestAppEnvSite4 + "', decentralised_portal_test_appenv_site5='" + TestAppEnvSite5 + "', decentralised_portal_test_appenv_site6='" + TestAppEnvSite6 + "', decentralised_portal_test_appenv_site7='" + TestAppEnvSite7 + "', decentralised_portal_test_appenv_site8='" + TestAppEnvSite8 + "' , decentralised_portal_test_appenv_site10='" + TestAppEnvSite10 + "', decentralised_portal_test_extmemory_site1='" + TestExtMemNo1 + "', decentralised_portal_test_extmemory_site2='" + TestExtMemNo2 + "', decentralised_portal_test_extmemory_site3='" + TestExtMemNo3 + "', decentralised_portal_test_extmemory_site4='" + TestExtMemNo4 + "', decentralised_portal_test_extmemory_site5='" + TestExtMemNo5 + "', decentralised_portal_test_extmemory_site6='" + TestExtMemNo6 + "', decentralised_portal_test_extmemory_site7='" + TestExtMemNo7 + "', decentralised_portal_test_extmemory_site8='" + TestExtMemNo8 + "', decentralised_portal_test_extmemory_site9='" + TestExtMemNo9 + "', decentralised_portal_test_extmemory_site10='" + TestExtMemNo10 + "' ,decentralised_portal_redundant_appenv_site1='" + Site1hidRedAppEnvSite1 + "' , decentralised_portal_redundant_appenv_site2='" + Site1hidRedAppEnvSite2 + "' , decentralised_portal_redundant_appenv_site3='" + Site1hidRedAppEnvSite3 + "' , decentralised_portal_redundant_appenv_site4='" + Site1hidRedAppEnvSite4 + "' , decentralised_portal_redundant_appenv_site5='" + Site1hidRedAppEnvSite5 + "' , decentralised_portal_redundant_appenv_site6='" + Site1hidRedAppEnvSite6 + "' , decentralised_portal_redundant_appenv_site7='" + Site1hidRedAppEnvSite7 + "' , decentralised_portal_redundant_appenv_site8='" + Site1hidRedAppEnvSite8 + "' , decentralised_portal_redundant_appenv_site9='" + Site1hidRedAppEnvSite9 + "' , decentralised_portal_redundant_appenv_site10='" + Site1hidRedAppEnvSite10 + "',  decentralised_portal_redundant_extmemory_site1='" + Site1hidRedExtMemNo1 + "',  decentralised_portal_redundant_extmemory_site2='" + Site1hidRedExtMemNo2 + "' ,  decentralised_portal_redundant_extmemory_site3='" + Site1hidRedExtMemNo3 + "' ,  decentralised_portal_redundant_extmemory_site4='" + Site1hidRedExtMemNo4 + "' ,  decentralised_portal_redundant_extmemory_site5='" + Site1hidRedExtMemNo5 + "' ,  decentralised_portal_redundant_extmemory_site6='" + Site1hidRedExtMemNo6 + "' ,  decentralised_portal_redundant_extmemory_site7='" + Site1hidRedExtMemNo7 + "' ,  decentralised_portal_redundant_extmemory_site8='" + Site1hidRedExtMemNo8 + "' ,  decentralised_portal_redundant_extmemory_site9='" + Site1hidRedExtMemNo9 + "' ,  decentralised_portal_redundant_extmemory_site10='" + Site1hidRedExtMemNo10 + "' , decentralised_portal_redundant_SH_site1='" + Site1RedundantSofHard + "', decentralised_portal_redundant_SH_site2='" + Site2RedundantSofHard + "', decentralised_portal_redundant_SH_site3='" + Site3RedundantSofHard + "', decentralised_portal_redundant_SH_site4='" + Site4RedundantSofHard + "', decentralised_portal_redundant_SH_site5='" + Site5RedundantSofHard + "', decentralised_portal_redundant_SH_site6='" + Site6RedundantSofHard + "', decentralised_portal_redundant_SH_site7='" + Site7RedundantSofHard + "', decentralised_portal_redundant_SH_site8='" + Site8RedundantSofHard + "' , decentralised_portal_redundant_SH_site10='" + Site10RedundantSofHard + "', decentralised_ExtendedMem1='" + PortalExtMemNo1 + "' , decentralised_ExtendedMem2='" + PortalExtMemNo2 + "' , decentralised_ExtendedMem3='" + PortalExtMemNo3 + "' , decentralised_ExtendedMem4='" + PortalExtMemNo4 + "' , decentralised_ExtendedMem5='" + PortalExtMemNo5 + "' , decentralised_ExtendedMem6='" + PortalExtMemNo6 + "' , decentralised_ExtendedMem7='" + PortalExtMemNo7 + "' , decentralised_ExtendedMem8='" + PortalExtMemNo8 + "' , decentralised_ExtendedMem9='" + PortalExtMemNo9 + "' , decentralised_ExtendedMem10='" + PortalExtMemNo10 + "'  , decentralised_ISPServer1='" + PortalISPserver1 + "', decentralised_ISPServer2='" + PortalISPserver2 + "', decentralised_ISPServer3='" + PortalISPserver3 + "', decentralised_ISPServer4='" + PortalISPserver4 + "', decentralised_ISPServer5='" + PortalISPserver5 + "', decentralised_ISPServer6='" + PortalISPserver6 + "', decentralised_ISPServer7='" + PortalISPserver7 + "', decentralised_ISPServer8='" + PortalISPserver8 + "', decentralised_ISPServer9='" + PortalISPserver9 + "' , decentralised_ISPServer10='" + PortalISPserver10 + "',  decentralised_portal_test_mac_site1='" + sTestMacAddressData1 + "',  decentralised_portal_test_mac_site2='" + sTestMacAddressData2 + "',  decentralised_portal_test_mac_site3='" + sTestMacAddressData3 + "',  decentralised_portal_test_mac_site4='" + sTestMacAddressData4 + "',  decentralised_portal_test_mac_site5='" + sTestMacAddressData5 + "',  decentralised_portal_test_mac_site6='" + sTestMacAddressData6 + "',  decentralised_portal_test_mac_site7='" + sTestMacAddressData7 + "',  decentralised_portal_test_mac_site8='" + sTestMacAddressData8 + "',  decentralised_portal_test_mac_site9='" + sTestMacAddressData9 + "',  decentralised_portal_test_mac_site10='" + sTestMacAddressData10 + "', decentralised_portal_redundant_mac_site1='" + sRedundantMacAddressData1 + "' , decentralised_portal_redundant_mac_site2='" + sRedundantMacAddressData2 + "' , decentralised_portal_redundant_mac_site3='" + sRedundantMacAddressData3 + "' , decentralised_portal_redundant_mac_site4='" + sRedundantMacAddressData4 + "' , decentralised_portal_redundant_mac_site5='" + sRedundantMacAddressData5 + "', decentralised_portal_redundant_mac_site6='" + sRedundantMacAddressData6 + "', decentralised_portal_redundant_mac_site7='" + sRedundantMacAddressData7 + "', decentralised_portal_redundant_mac_site8='" + sRedundantMacAddressData8 + "', decentralised_portal_redundant_mac_site9='" + sRedundantMacAddressData9 + "', decentralised_portal_redundant_mac_site10='" + sRedundantMacAddressData10 + "', decentralised_portal_test_site2='" + Site2Test + "' , decentralised_portal_test_site3='" + Site3Test + "' , decentralised_portal_test_site4='" + Site4Test + "', decentralised_portal_test_site5='" + Site5Test + "', decentralised_portal_test_site6='" + Site6Test + "', decentralised_portal_test_site7='" + Site7Test + "', decentralised_portal_test_site8='" + Site8Test + "', decentralised_portal_test_site9='" + Site9Test + "', decentralised_portal_test_site10='" + Site10Test + "', decentralised_portal_redundant_site1='" + Site1Redundant + "', decentralised_portal_redundant_site2='" + Site2Redundant + "', decentralised_portal_redundant_site3='" + Site3Redundant + "', decentralised_portal_redundant_site4='" + Site4Redundant + "', decentralised_portal_redundant_site5='" + Site5Redundant + "', decentralised_portal_redundant_site6='" + Site6Redundant + "' , decentralised_portal_redundant_site7='" + Site7Redundant + "' , decentralised_portal_redundant_site8='" + Site8Redundant + "' , decentralised_portal_redundant_site9='" + Site9Redundant + "' , decentralised_portal_redundant_site10='" + Site10Redundant + "', decentralised_portal_site1='" + Site1SoftwareHardWare + "', decentralised_portal_site2='" + Site2SoftwareHardWare + "', decentralised_portal_site3='" + Site3SoftwareHardWare + "', decentralised_portal_site4='" + Site4SoftwareHardWare + "', decentralised_portal_site5='" + Site5SoftwareHardWare + "', decentralised_portal_site6='" + Site6SoftwareHardWare + "' , decentralised_portal_site7='" + Site7SoftwareHardWare + "' , decentralised_portal_site8='" + Site8SoftwareHardWare + "' , decentralised_portal_site9='" + Site9SoftwareHardWare + "' , decentralised_portal_site10='" + Site10SoftwareHardWare + "',  decentralised_enterpriceinstallmac='" + EnterpriceInstallMac + "', decentralised_planinstallengine='" + PlanInstallEngine + "', decentralised_licencemodel1='" + WhichLicenceModel1 + "', decentralised_deliverymode='" + WhichDeliveryTab + "',  decentralised_siteinfo='" + centralised_siteinfo + "' , decentralised_concurrent_ent_users='"+ CONCURRENTENTERPRISEUSERS + "', decentralised_add_application='"+ AdditionalApplication + "' , decentralised_mac_site1='" + sMacAddressData1 + "' , decentralised_mac_site2='" + sMacAddressData2 + "', decentralised_mac_site3='" + sMacAddressData3 + "', decentralised_mac_site4='" + sMacAddressData4 + "', decentralised_mac_site5='" + sMacAddressData5 + "', decentralised_mac_site6='" + sMacAddressData6 + "', decentralised_mac_site7='" + sMacAddressData7 + "', decentralised_mac_site8='" + sMacAddressData8 + "', decentralised_mac_site9='" + sMacAddressData9 + "', decentralised_mac_site10='" + sMacAddressData10 + "' where PhilipsLic_ProjectID =" + id;
            // string SQL = "update PhilipsLic_Project set centralised_add_application='"+ AdditionalApplication + "', centralised_deliverymodel='" + WhichDeliveryTab + "', centralised_deliverymodel_ISPSoftware='" + MacAddressData + "',  centralised_siteinfo='" + centralised_siteinfo + "', centralised_concurrent_ent_users='"+ CONCURRENTENTERPRISEUSERS + "' where PhilipsLic_ProjectID =" + id;
            Helper.InsertData(SQL);


          
            //Response.Redirect("/lic-server/OutputReporta.aspx?id=10");


            //SiteInfoData1.Add(new SiteInfoData { FirstName = t1.Text, LastName = t2.Text, Email = t3.Text });
            // PortalJSON = JsonConvert.SerializeObject(SiteInfoData1, Formatting.Indented);

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

            SetupPage();



        }
        catch (Exception ex)
        {

        }
    }

    protected void cmdConfig_Click(object sender, EventArgs e)
    {
        try
        {
            string id = Request.QueryString["id"];
            Response.Redirect("/lic-server/OutputReportDistributed.aspx?id=" + id);
        }
        catch (Exception ex)
        {

        }

    }



    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {

            Session["Competitors"] = "Super Admin";
            Session["User"] = "Jonny";
            Session["UserType"] = "Granted Access";
            //bool Signin = false;


            if (Request.QueryString["id"] != null)
            {
                if (Request.QueryString["id"] != "")
                {
                    m_ID = Request.QueryString["id"].ToString();
                }
                else
                {
                    Response.Redirect("/lic-server/");
                }
            }
            else
            {
                Response.Redirect("/lic-server/");
            }


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




                SetupPage();
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


}

//http://localhost:8085/lic-server/ISPConcerto?id=10
