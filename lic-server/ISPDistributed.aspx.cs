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

                hidPortalISPserver1.Value = rowView["decentralised_ISPServer"].ToString();
                hidPortalExtMemNo1.Value = rowView["decentralised_ExtendedMem"].ToString();

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

                //hidHospitalData
                

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
                                hostpitalnewline1.Value = (splitAdditon_Hospitalname.Length  ).ToString(); 
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
                                hostpitalnewline2.Value = (splitAdditon_Hospitalname1.Length).ToString();
                            }

                            break;
                        case 2:
                            cmdApplication3.SelectedValue = AdditionalApplication1[i].Application;
                            m_txtConcurrent3 = AdditionalApplication1[i].ConcurrentUsers;
                            break;
                        case 3:
                            cmdApplication4.SelectedValue = AdditionalApplication1[i].Application;
                            m_txtConcurrent4 = AdditionalApplication1[i].ConcurrentUsers;
                            break;
                        case 4:
                            cmdApplication5.SelectedValue = AdditionalApplication1[i].Application;
                            m_txtConcurrent5 = AdditionalApplication1[i].ConcurrentUsers;
                            break;
                        case 5:
                            cmdApplication6.SelectedValue = AdditionalApplication1[i].Application;
                            m_txtConcurrent6 = AdditionalApplication1[i].ConcurrentUsers;
                            break;
                    }

                }

                
                               

                //Mac Top Main 1
                MacAddressData1 = JsonConvert.DeserializeObject<List<MacAddressData>>(rowView["decentralised_deliverymodel_ISPSoftware"].ToString());
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

            foreach (DataRowView rowView in MyDV)
            {
                myID = rowView["Applications"].ToString();
               // cmdApplication1.Items.Add(new ListItem(rowView["Cat_No"].ToString() + " - " + rowView["Applications"].ToString(), rowView["Applications"].ToString() + "|" + rowView["Concurrent_Users"].ToString() + "|" + rowView["Concurrent_Default"].ToString() + "|" + rowView["Concurrent_Range"].ToString()));
                cmdApplication2.Items.Add(new ListItem(rowView["Cat_No"].ToString() + " - " + rowView["Applications"].ToString(), rowView["Applications"].ToString() + "|" + rowView["Concurrent_Users"].ToString() + "|" + rowView["Concurrent_Default"].ToString() + "|" + rowView["Concurrent_Range"].ToString()));
                cmdApplication3.Items.Add(new ListItem(rowView["Cat_No"].ToString() + " - " + rowView["Applications"].ToString(), rowView["Applications"].ToString() + "|" + rowView["Concurrent_Users"].ToString() + "|" + rowView["Concurrent_Default"].ToString() + "|" + rowView["Concurrent_Range"].ToString()));
                cmdApplication4.Items.Add(new ListItem(rowView["Cat_No"].ToString() + " - " + rowView["Applications"].ToString(), rowView["Applications"].ToString() + "|" + rowView["Concurrent_Users"].ToString() + "|" + rowView["Concurrent_Default"].ToString() + "|" + rowView["Concurrent_Range"].ToString()));
                cmdApplication5.Items.Add(new ListItem(rowView["Cat_No"].ToString() + " - " + rowView["Applications"].ToString(), rowView["Applications"].ToString() + "|" + rowView["Concurrent_Users"].ToString() + "|" + rowView["Concurrent_Default"].ToString() + "|" + rowView["Concurrent_Range"].ToString()));
                cmdApplication6.Items.Add(new ListItem(rowView["Cat_No"].ToString() + " - " + rowView["Applications"].ToString(), rowView["Applications"].ToString() + "|" + rowView["Concurrent_Users"].ToString() + "|" + rowView["Concurrent_Default"].ToString() + "|" + rowView["Concurrent_Range"].ToString()));
                cmdApplication7.Items.Add(new ListItem(rowView["Cat_No"].ToString() + " - " + rowView["Applications"].ToString(), rowView["Applications"].ToString() + "|" + rowView["Concurrent_Users"].ToString() + "|" + rowView["Concurrent_Default"].ToString() + "|" + rowView["Concurrent_Range"].ToString()));
                cmdApplication8.Items.Add(new ListItem(rowView["Cat_No"].ToString() + " - " + rowView["Applications"].ToString(), rowView["Applications"].ToString() + "|" + rowView["Concurrent_Users"].ToString() + "|" + rowView["Concurrent_Default"].ToString() + "|" + rowView["Concurrent_Range"].ToString()));
                cmdApplication9.Items.Add(new ListItem(rowView["Cat_No"].ToString() + " - " + rowView["Applications"].ToString(), rowView["Applications"].ToString() + "|" + rowView["Concurrent_Users"].ToString() + "|" + rowView["Concurrent_Default"].ToString() + "|" + rowView["Concurrent_Range"].ToString()));
                cmdApplication10.Items.Add(new ListItem(rowView["Cat_No"].ToString() + " - " + rowView["Applications"].ToString(), rowView["Applications"].ToString() + "|" + rowView["Concurrent_Users"].ToString() + "|" + rowView["Concurrent_Default"].ToString() + "|" + rowView["Concurrent_Range"].ToString()));
                cmdApplication11.Items.Add(new ListItem(rowView["Cat_No"].ToString() + " - " + rowView["Applications"].ToString(), rowView["Applications"].ToString() + "|" + rowView["Concurrent_Users"].ToString() + "|" + rowView["Concurrent_Default"].ToString() + "|" + rowView["Concurrent_Range"].ToString()));
                cmdApplication12.Items.Add(new ListItem(rowView["Cat_No"].ToString() + " - " + rowView["Applications"].ToString(), rowView["Applications"].ToString() + "|" + rowView["Concurrent_Users"].ToString() + "|" + rowView["Concurrent_Default"].ToString() + "|" + rowView["Concurrent_Range"].ToString()));
                cmdApplication13.Items.Add(new ListItem(rowView["Cat_No"].ToString() + " - " + rowView["Applications"].ToString(), rowView["Applications"].ToString() + "|" + rowView["Concurrent_Users"].ToString() + "|" + rowView["Concurrent_Default"].ToString() + "|" + rowView["Concurrent_Range"].ToString()));
                cmdApplication14.Items.Add(new ListItem(rowView["Cat_No"].ToString() + " - " + rowView["Applications"].ToString(), rowView["Applications"].ToString() + "|" + rowView["Concurrent_Users"].ToString() + "|" + rowView["Concurrent_Default"].ToString() + "|" + rowView["Concurrent_Range"].ToString()));
                cmdApplication15.Items.Add(new ListItem(rowView["Cat_No"].ToString() + " - " + rowView["Applications"].ToString(), rowView["Applications"].ToString() + "|" + rowView["Concurrent_Users"].ToString() + "|" + rowView["Concurrent_Default"].ToString() + "|" + rowView["Concurrent_Range"].ToString()));


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
            
            string Site1SoftwareHardWare = Request.Form["HiddenSoftwareHardwareSite1"].ToString();

            //Redundant No / Yes
            string Site1Redundant = Request.Form["HiddenRedundantSite1"].ToString();
            string Site1RedundantSofHard = Request.Form["hidRedSoftwareHardwareSite1"].ToString();

            string Site1hidRedAppEnvSite1 = Request.Form["hidRedAppEnvSite1"].ToString();
            string Site1hidRedExtMemNo1 = Request.Form["hidRedExtMemNo1"].ToString();


            string Site1Test = Request.Form["HiddenTestSite1"].ToString();

            string PortalISPserver1 = Request.Form["hidPortalISPserver1"].ToString();
            string PortalExtMemNo1 = Request.Form["hidPortalExtMemNo1"].ToString();


            string TesSH_site1 = Request.Form["hidTestSoftwareHardwareSite1"].ToString();
            string TestAppEnvSite1 = Request.Form["hidTestEnvSite1"].ToString();
            string TestExtMemNo1 = Request.Form["hidTestExtMemNo1"].ToString();



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

                    MacAddressData1.Add(new MacAddressData { No = i.ToString(), Menu = item1, MacAddress = item2 });
                }
            }

            string MacAddressData = JsonConvert.SerializeObject(MacAddressData1, Formatting.Indented);


            //loop redundant


            

            int RedundantmacSection = 0;
            int RedundantmacSectionidx = 1;
            foreach (string key in Request.Form)
            {

                bool hasItemRedundant = LoopNumberofEntries("ApplicationSoftwareOnlymacTableSO" + 1 + "_" + RedundantmacSectionidx);

                if (hasItemRedundant)
                {
                    RedundantmacSection++;
                }

                RedundantmacSectionidx++;

            }

            for (int isec = 1; isec <= RedundantmacSection; isec++)
            {

                string item1 = Request.Form["ApplicationSoftwareOnlymacTableSO" + isec + "_" + isec].ToString();
                string item2 = Request.Form["MacSoftwareOnlymacTableSO" + isec + "_" + isec].ToString();

                RedundantMacAddressData1.Add(new MacAddressData { No = isec.ToString(), Menu = item1, MacAddress = item2 });
            }


            //loop redundant



            //loop test

           
            int TestmacSection = 0;
            int TestmacSectionidx = 1;
            foreach (string key in Request.Form)
            {

                bool hasItemTest = LoopNumberofEntries("ApplicationSoftwareOnlymacTableRedundant" + 1 + "_" + TestmacSectionidx);

                if (hasItemTest)
                {
                    TestmacSection++;
                }

                TestmacSectionidx++;

            }

            for (int isec = 1; isec <= TestmacSection; isec++)
            {

                string item1 = Request.Form["ApplicationSoftwareOnlymacTableRedundant" + isec + "_" + isec].ToString();
                string item2 = Request.Form["MacSoftwareOnlymacTableRedundant" + isec + "_" + isec].ToString();

                TestMacAddressData1.Add(new MacAddressData { No = isec.ToString(), Menu = item1, MacAddress = item2 });
            }


            //loop test


            string TestMacAddressData = JsonConvert.SerializeObject(TestMacAddressData1, Formatting.Indented);
            string RedundantMacAddressData = JsonConvert.SerializeObject(RedundantMacAddressData1, Formatting.Indented);


    

            string SQL = "update  PhilipsLic_Project set decentralised_portal_test_SH_site1='"+ TesSH_site1 + "', decentralised_portal_test_appenv_site1='" + TestAppEnvSite1 + "', decentralised_portal_test_extmemory_site1='" + TestExtMemNo1 + "', decentralised_portal_redundant_appenv_site1='" + Site1hidRedAppEnvSite1 + "', decentralised_portal_redundant_extmemory_site1='" + Site1hidRedExtMemNo1 + "', decentralised_portal_redundant_SH_site1='" + Site1RedundantSofHard + "', decentralised_ExtendedMem='" + PortalExtMemNo1 + "', decentralised_ISPServer='"+ PortalISPserver1 + "',  decentralised_portal_test_mac_site1='" + TestMacAddressData + "', decentralised_portal_redundant_mac_site1='" + RedundantMacAddressData + "', decentralised_portal_test_site1='" + Site1Test + "', decentralised_portal_redundant_site1='" + Site1Redundant + "', decentralised_portal_site1='" + Site1SoftwareHardWare + "', decentralised_enterpriceinstallmac='" + EnterpriceInstallMac + "', decentralised_planinstallengine='" + PlanInstallEngine + "', decentralised_licencemodel1='" + WhichLicenceModel1 + "', decentralised_deliverymode='" + WhichDeliveryTab + "',  decentralised_siteinfo='" + centralised_siteinfo + "' , decentralised_concurrent_ent_users='"+ CONCURRENTENTERPRISEUSERS + "', decentralised_add_application='"+ AdditionalApplication + "' , decentralised_mac_site1='" + MacAddressData + "' where PhilipsLic_ProjectID =" + id;
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
