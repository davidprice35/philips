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
    public string m_NoApp = string.Empty;

    public string m_ConEnterpriseUsers = "11";

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

    public string m_connectH1 = "checked";
    public string m_connectM1 = "";
    public string m_connectL1 = "";

    public string m_connectH2 = "checked";
    public string m_connectM2 = "";
    public string m_connectL2 = "";
    
    public string m_connectH3 = "checked";
    public string m_connectM3 = "";
    public string m_connectL3 = "";


    public string m_connectH4 = "checked";
    public string m_connectM4 = "";
    public string m_connectL4 = "";

    public string m_connectH5 = "checked";
    public string m_connectM5 = "";
    public string m_connectL5 = "";

    public string m_connectH6 = "checked";
    public string m_connectM6 = "";
    public string m_connectL6 = "";

    public string m_connectH7 = "checked";
    public string m_connectM7 = "";
    public string m_connectL7 = "";

    public string m_connectH8 = "checked";
    public string m_connectM8 = "";
    public string m_connectL8 = "";

    public string m_connectH9 = "checked";
    public string m_connectM9 = "";
    public string m_connectL9 = "";

    public string m_connectH10 = "checked";
    public string m_connectM10 = "";
    public string m_connectL10 = "";


    public string m_hidMacTable = "NICB006 - Enterprise Engine SW:xxx1,FICO248 - ISP Server - Software only:xxxx2,FICO248 - ISP Server - Software only:xxxx3,FICO248 - ISP Server - Software only:";
    

    public string m_UserName = string.Empty;
    public string m_UserID = string.Empty;
    public string m_UserType = string.Empty;

    public string m_ID = string.Empty;

    
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

    
   

    private void SetupPage()
    {
        try
        {

            if (Request.QueryString["id"] != null)
            {
                if (Request.QueryString["id"] != "")
                {
                    m_ID = Request.QueryString["id"].ToString();
                }
            }


            DataView myDV = Helper.GetData("Select * from PhilipsLic_Project where PhilipsLic_ProjectID=" + Request.QueryString["id"]);            
            foreach (DataRowView rowView in myDV)
            {
                HiddenDeliveryModel.Value = rowView["centralised_deliverymodel"].ToString();
                HiddenButtonBlock1.Value = rowView["centralised_block1"].ToString();
                HiddenButtonBlock2.Value = rowView["centralised_block2"].ToString();
                hidLicenceDataPro.Value = "4";
                hidLicenceDataPro2.Value = "2";

                AdditionalApplication1 = JsonConvert.DeserializeObject<List<AdditionalApplication>>(rowView["centralised_add_application"].ToString());
                m_NoApp = Convert.ToString(AdditionalApplication1.Count - 1);
                if (m_NoApp == "-1" )
                {
                    m_NoApp = "0";
                }

                if (AdditionalApplication1.Count == 0)
                {
                    hidadditionalapps.Value ="1";
                }
                else
                {
                    hidadditionalapps.Value = AdditionalApplication1.Count.ToString();
                }

                for (int i = 0; i <= AdditionalApplication1.Count - 1; i++)
                {

                    switch (i)
                    {
                        case 0:
                            cmdApplication1.SelectedValue = AdditionalApplication1[i].Application;
                            m_txtConcurrent1 = AdditionalApplication1[i].ConcurrentUsers;
                            HiddenHospitalName1.Value = AdditionalApplication1[i].HospitalName;
                            break;
                        case 1:
                            cmdApplication2.SelectedValue = AdditionalApplication1[i].Application;
                            m_txtConcurrent2 = AdditionalApplication1[i].ConcurrentUsers;
                            HiddenHospitalName2.Value = AdditionalApplication1[i].HospitalName;
                            break;
                        case 2:
                            cmdApplication3.SelectedValue = AdditionalApplication1[i].Application;
                            m_txtConcurrent3 = AdditionalApplication1[i].ConcurrentUsers;
                            HiddenHospitalName3.Value = AdditionalApplication1[i].HospitalName;
                            break;
                        case 3:
                            cmdApplication4.SelectedValue = AdditionalApplication1[i].Application;
                            m_txtConcurrent4 = AdditionalApplication1[i].ConcurrentUsers;
                            HiddenHospitalName4.Value = AdditionalApplication1[i].HospitalName;
                            break;
                        case 4:
                            cmdApplication5.SelectedValue = AdditionalApplication1[i].Application;
                            m_txtConcurrent5 = AdditionalApplication1[i].ConcurrentUsers;
                            HiddenHospitalName5.Value = AdditionalApplication1[i].HospitalName;
                            break;
                        case 5:
                            cmdApplication6.SelectedValue = AdditionalApplication1[i].Application;
                            m_txtConcurrent6 = AdditionalApplication1[i].ConcurrentUsers;
                            HiddenHospitalName6.Value = AdditionalApplication1[i].HospitalName;
                            break;
                        case 6:
                            cmdApplication7.SelectedValue = AdditionalApplication1[i].Application;
                            m_txtConcurrent7 = AdditionalApplication1[i].ConcurrentUsers;
                            HiddenHospitalName7.Value = AdditionalApplication1[i].HospitalName;
                            break;
                        case 7:
                            cmdApplication8.SelectedValue = AdditionalApplication1[i].Application;
                            m_txtConcurrent8 = AdditionalApplication1[i].ConcurrentUsers;
                            HiddenHospitalName8.Value = AdditionalApplication1[i].HospitalName;
                            break;
                        case 8:
                            cmdApplication9.SelectedValue = AdditionalApplication1[i].Application;
                            m_txtConcurrent9 = AdditionalApplication1[i].ConcurrentUsers;
                            HiddenHospitalName9.Value = AdditionalApplication1[i].HospitalName;
                            break;
                        case 9:
                            cmdApplication10.SelectedValue = AdditionalApplication1[i].Application;
                            m_txtConcurrent10 = AdditionalApplication1[i].ConcurrentUsers;
                            HiddenHospitalName10.Value = AdditionalApplication1[i].HospitalName;
                            break;
                        case 10:
                            cmdApplication11.SelectedValue = AdditionalApplication1[i].Application;
                            m_txtConcurrent11 = AdditionalApplication1[i].ConcurrentUsers;
                            HiddenHospitalName11.Value = AdditionalApplication1[i].HospitalName;
                            break;
                        case 11:
                            cmdApplication12.SelectedValue = AdditionalApplication1[i].Application;
                            m_txtConcurrent12 = AdditionalApplication1[i].ConcurrentUsers;
                            HiddenHospitalName12.Value = AdditionalApplication1[i].HospitalName;
                            break;
                        case 12:
                            cmdApplication13.SelectedValue = AdditionalApplication1[i].Application;
                            m_txtConcurrent13 = AdditionalApplication1[i].ConcurrentUsers;
                            HiddenHospitalName13.Value = AdditionalApplication1[i].HospitalName;
                            break;
                        case 13:
                            cmdApplication14.SelectedValue = AdditionalApplication1[i].Application;
                            m_txtConcurrent14 = AdditionalApplication1[i].ConcurrentUsers;
                            HiddenHospitalName14.Value = AdditionalApplication1[i].HospitalName;
                            break;
                        case 14:
                            cmdApplication15.SelectedValue = AdditionalApplication1[i].Application;
                            m_txtConcurrent15 = AdditionalApplication1[i].ConcurrentUsers;
                            HiddenHospitalName15.Value = AdditionalApplication1[i].HospitalName;
                            break;
                        //case 16:
                        //    cmdApplication15.SelectedValue = AdditionalApplication1[i].Application;
                        //    m_txtConcurrent15 = AdditionalApplication1[i].ConcurrentUsers;
                        //    break;
                    }


                    

                }


                    //site info

                    SiteInfoData1 = JsonConvert.DeserializeObject<List<SiteInfoData>>(rowView["centralised_siteinfo"].ToString());
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
                                hidCentralSite.Value = "1";
                                break;
                            case 1:
                                txtHospitalName2.Text = SiteInfoData1[ix].HospitalName;
                                txtHospitalStreet2.Text = SiteInfoData1[ix].HospitalStreet;
                                hidCentralSite.Value = "2";
                                switch (SiteInfoData1[ix].Site)
                                {
                                    case "High":
                                        m_connectH2 = "checked";
                                        break;
                                    case "Med":
                                        m_connectM2 = "checked";
                                        break;
                                    case "Low":
                                        m_connectL2 = "checked";
                                        break;
                                }
                            break;
                            case 2:
                                txtHospitalName3.Text = SiteInfoData1[ix].HospitalName;
                                txtHospitalStreet3.Text = SiteInfoData1[ix].HospitalStreet;
                                hidCentralSite.Value = "3";
                                switch (SiteInfoData1[ix].Site)
                                {
                                    case "High":
                                        m_connectH3 = "checked";
                                        break;
                                    case "Med":
                                        m_connectM3 = "checked";
                                        break;
                                    case "Low":
                                        m_connectL3 = "checked";
                                        break;
                                }
                                break;
                            case 3:
                                txtHospitalName4.Text = SiteInfoData1[ix].HospitalName;
                                txtHospitalStreet4.Text = SiteInfoData1[ix].HospitalStreet;
                                hidCentralSite.Value = "4";
                                switch (SiteInfoData1[ix].Site)
                                {
                                    case "High":
                                        m_connectH4 = "checked";
                                        break;
                                    case "Med":
                                        m_connectM4 = "checked";
                                        break;
                                    case "Low":
                                        m_connectL4 = "checked";
                                        break;
                                }
                                break;
                            case 4:
                                txtHospitalName5.Text = SiteInfoData1[ix].HospitalName;
                                txtHospitalStreet5.Text = SiteInfoData1[ix].HospitalStreet;
                                hidCentralSite.Value = "5";
                                switch (SiteInfoData1[ix].Site)
                                {
                                    case "High":
                                        m_connectH5 = "checked";
                                        break;
                                    case "Med":
                                        m_connectM5 = "checked";
                                        break;
                                    case "Low":
                                        m_connectL5 = "checked";
                                        break;
                                }
                                break;
                            case 5:
                                txtHospitalName6.Text = SiteInfoData1[ix].HospitalName;
                                txtHospitalStreet6.Text = SiteInfoData1[ix].HospitalStreet;
                                hidCentralSite.Value = "6";
                                switch (SiteInfoData1[ix].Site)
                                {
                                    case "High":
                                        m_connectH6 = "checked";
                                        break;
                                    case "Med":
                                        m_connectM6 = "checked";
                                        break;
                                    case "Low":
                                        m_connectL6 = "checked";
                                        break;
                                }
                                break;
                            case 6:
                                txtHospitalName7.Text = SiteInfoData1[ix].HospitalName;
                                txtHospitalStreet7.Text = SiteInfoData1[ix].HospitalStreet;
                                hidCentralSite.Value = "7";
                                switch (SiteInfoData1[ix].Site)
                                {
                                    case "High":
                                        m_connectH7 = "checked";
                                        break;
                                    case "Med":
                                        m_connectM7 = "checked";
                                        break;
                                    case "Low":
                                        m_connectL7 = "checked";
                                        break;
                                }
                                break;
                            case 7:
                                txtHospitalName8.Text = SiteInfoData1[ix].HospitalName;
                                txtHospitalStreet8.Text = SiteInfoData1[ix].HospitalStreet;
                                hidCentralSite.Value = "8";
                                switch (SiteInfoData1[ix].Site)
                                {
                                    case "High":
                                        m_connectH8 = "checked";
                                        break;
                                    case "Med":
                                        m_connectM8 = "checked";
                                        break;
                                    case "Low":
                                        m_connectL8 = "checked";
                                        break;
                                }
                                break;
                            case 8:
                                txtHospitalName9.Text = SiteInfoData1[ix].HospitalName;
                                txtHospitalStreet9.Text = SiteInfoData1[ix].HospitalStreet;
                                hidCentralSite.Value = "9";
                                switch (SiteInfoData1[ix].Site)
                                {
                                    case "High":
                                        m_connectH9 = "checked";
                                        break;
                                    case "Med":
                                        m_connectM9 = "checked";
                                        break;
                                    case "Low":
                                        m_connectL9 = "checked";
                                        break;
                                }
                                break;
                            case 9:
                                txtHospitalName10.Text = SiteInfoData1[ix].HospitalName;
                                txtHospitalStreet10.Text = SiteInfoData1[ix].HospitalStreet;
                                hidCentralSite.Value = "10";
                                switch (SiteInfoData1[ix].Site)
                                {
                                    case "High":
                                        m_connectH10 = "checked";
                                        break;
                                    case "Med":
                                        m_connectM10 = "checked";
                                        break;
                                    case "Low":
                                        m_connectL10 = "checked";
                                        break;
                                }
                                break;

                    }
                    }


                    //concurrent
                    m_ConEnterpriseUsers = rowView["centralised_concurrent_ent_users"].ToString();



                //cmdApplication1.SelectedValue = "Mirada Viewer Pro - 1 User|No|1|NA";


                //SOftware only Mac
                string myMaclist = string.Empty;

                MacAddressData1 = JsonConvert.DeserializeObject<List<MacAddressData>>(rowView["centralised_deliverymodel_ISPSoftware"].ToString());
                for (int ixa = 0; ixa <= MacAddressData1.Count - 1; ixa++)
                {
                    myMaclist += MacAddressData1[ixa].Menu + ":" + MacAddressData1[ixa].No + ":" + MacAddressData1[ixa].MacAddress + ",";
                }

                hidMacTable.Value = myMaclist;
                hidMacTablePro.Value = myMaclist;

                //"NICB006 - Enterprise Engine SW:,FICO248 - ISP Server - Software only:,"
                //hidMacTable






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



            //string SQL = "SELECT * FROM travelma2_phil1.PhilipsLic_Applications where Category not in ('Enterprise Software','Enterprise  Hardware')";
            //DataView MyDV = Helper.GetData(SQL);
            string myID = "";

            cmdApplication1.Items.Add(new ListItem("", ""));
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

            //foreach (DataRowView rowView in MyDV)
            //{
            //    myID = rowView["Applications"].ToString();
            //    cmdApplication1.Items.Add(new ListItem(rowView["Cat_No"].ToString() + " - " + rowView["Applications"].ToString(), rowView["Applications"].ToString() + "|" + rowView["Concurrent_Users"].ToString() + "|" + rowView["Concurrent_Default"].ToString() + "|" + rowView["Concurrent_Range"].ToString()));
            //    cmdApplication2.Items.Add(new ListItem(rowView["Cat_No"].ToString() + " - " + rowView["Applications"].ToString(), rowView["Applications"].ToString() + "|" + rowView["Concurrent_Users"].ToString() + "|" + rowView["Concurrent_Default"].ToString() + "|" + rowView["Concurrent_Range"].ToString()));
            //    cmdApplication3.Items.Add(new ListItem(rowView["Cat_No"].ToString() + " - " + rowView["Applications"].ToString(), rowView["Applications"].ToString() + "|" + rowView["Concurrent_Users"].ToString() + "|" + rowView["Concurrent_Default"].ToString() + "|" + rowView["Concurrent_Range"].ToString()));
            //    cmdApplication4.Items.Add(new ListItem(rowView["Cat_No"].ToString() + " - " + rowView["Applications"].ToString(), rowView["Applications"].ToString() + "|" + rowView["Concurrent_Users"].ToString() + "|" + rowView["Concurrent_Default"].ToString() + "|" + rowView["Concurrent_Range"].ToString()));
            //    cmdApplication5.Items.Add(new ListItem(rowView["Cat_No"].ToString() + " - " + rowView["Applications"].ToString(), rowView["Applications"].ToString() + "|" + rowView["Concurrent_Users"].ToString() + "|" + rowView["Concurrent_Default"].ToString() + "|" + rowView["Concurrent_Range"].ToString()));
            //    cmdApplication6.Items.Add(new ListItem(rowView["Cat_No"].ToString() + " - " + rowView["Applications"].ToString(), rowView["Applications"].ToString() + "|" + rowView["Concurrent_Users"].ToString() + "|" + rowView["Concurrent_Default"].ToString() + "|" + rowView["Concurrent_Range"].ToString()));
            //    cmdApplication7.Items.Add(new ListItem(rowView["Cat_No"].ToString() + " - " + rowView["Applications"].ToString(), rowView["Applications"].ToString() + "|" + rowView["Concurrent_Users"].ToString() + "|" + rowView["Concurrent_Default"].ToString() + "|" + rowView["Concurrent_Range"].ToString()));
            //    cmdApplication8.Items.Add(new ListItem(rowView["Cat_No"].ToString() + " - " + rowView["Applications"].ToString(), rowView["Applications"].ToString() + "|" + rowView["Concurrent_Users"].ToString() + "|" + rowView["Concurrent_Default"].ToString() + "|" + rowView["Concurrent_Range"].ToString()));
            //    cmdApplication9.Items.Add(new ListItem(rowView["Cat_No"].ToString() + " - " + rowView["Applications"].ToString(), rowView["Applications"].ToString() + "|" + rowView["Concurrent_Users"].ToString() + "|" + rowView["Concurrent_Default"].ToString() + "|" + rowView["Concurrent_Range"].ToString()));
            //    cmdApplication10.Items.Add(new ListItem(rowView["Cat_No"].ToString() + " - " + rowView["Applications"].ToString(), rowView["Applications"].ToString() + "|" + rowView["Concurrent_Users"].ToString() + "|" + rowView["Concurrent_Default"].ToString() + "|" + rowView["Concurrent_Range"].ToString()));
            //    cmdApplication11.Items.Add(new ListItem(rowView["Cat_No"].ToString() + " - " + rowView["Applications"].ToString(), rowView["Applications"].ToString() + "|" + rowView["Concurrent_Users"].ToString() + "|" + rowView["Concurrent_Default"].ToString() + "|" + rowView["Concurrent_Range"].ToString()));
            //    cmdApplication12.Items.Add(new ListItem(rowView["Cat_No"].ToString() + " - " + rowView["Applications"].ToString(), rowView["Applications"].ToString() + "|" + rowView["Concurrent_Users"].ToString() + "|" + rowView["Concurrent_Default"].ToString() + "|" + rowView["Concurrent_Range"].ToString()));
            //    cmdApplication13.Items.Add(new ListItem(rowView["Cat_No"].ToString() + " - " + rowView["Applications"].ToString(), rowView["Applications"].ToString() + "|" + rowView["Concurrent_Users"].ToString() + "|" + rowView["Concurrent_Default"].ToString() + "|" + rowView["Concurrent_Range"].ToString()));
            //    cmdApplication14.Items.Add(new ListItem(rowView["Cat_No"].ToString() + " - " + rowView["Applications"].ToString(), rowView["Applications"].ToString() + "|" + rowView["Concurrent_Users"].ToString() + "|" + rowView["Concurrent_Default"].ToString() + "|" + rowView["Concurrent_Range"].ToString()));
            //    cmdApplication15.Items.Add(new ListItem(rowView["Cat_No"].ToString() + " - " + rowView["Applications"].ToString(), rowView["Applications"].ToString() + "|" + rowView["Concurrent_Users"].ToString() + "|" + rowView["Concurrent_Default"].ToString() + "|" + rowView["Concurrent_Range"].ToString()));


            //}

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
                case "macAddressPro":
                    foreach (string key in Request.Form)
                    {

                        bool hasItem = LoopNumberofEntries("ApplicationSoftwareHardWare" + idx);

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
                string item3 = Request.Form["HospitalSiteConnectivity" + i.ToString()].ToString();
                string item4 = Request.Form["HospitalSite" + i.ToString()].ToString();

                SiteInfoData1.Add(new SiteInfoData {  No=i.ToString(), HospitalName= item1, HospitalStreet = item2,  Site= item3, Connectivity= item4 });
            }
            //serilaze for DB
            string centralised_siteinfo = JsonConvert.SerializeObject(SiteInfoData1, Formatting.Indented);


            string CONCURRENTENTERPRISEUSERS = Request.Form["CONCURRENTENTERPRISEUSERS"].ToString();


            string WhichDeliveryTab = Request.Form["HiddenDeliveryModel"];


            int addApplicationidx = GetNumberofEntries("addApplication");


            for (int i = 1; i <= addApplicationidx; i++)
            {
                string item1 = Request.Form["cmdApplication" + i.ToString()].ToString();

                if (item1 != "")
                {
                    string item2 = "";
                    if (Request.Form["txtConcurrent" + i.ToString()] != null)
                    {
                        item2 = Request.Form["txtConcurrent" + i.ToString()].ToString();
                    }
                    else
                    {
                        item2 = "1";
                    }
                  
                    string item3 = "";
                    if (Request.Form["cmdHospitalName" + i.ToString()] != null)
                    {
                        item3 = Request.Form["cmdHospitalName" + i.ToString()].ToString();
                    }
                    else
                    {
                        item3 = "";
                    }

                    AdditionalApplication1.Add(new AdditionalApplication { No = i.ToString(), Application = item1, ConcurrentUsers = item2, HospitalName = item3 });
                }
            }
            string AdditionalApplication = JsonConvert.SerializeObject(AdditionalApplication1, Formatting.Indented);

            string HiddenButtonBlock1 = Request.Form["HiddenButtonBlock1"];
            string HiddenButtonBlock2 = Request.Form["HiddenButtonBlock2"];

            //pro
            string HiddenProAddStorage = Request.Form["HiddenProAddStorage"];
            string HiddenProlicence = Request.Form["HiddenProlicence"];
            string HiddenProSoftware = Request.Form["HiddenProSoftware"];

            //pre
            string HiddenPreStorage = Request.Form["HiddenPreStorage"];
            string HiddenPreStorageTotal = Request.Form["HiddenPreStorageTotal"];
            string HiddenPreServers = Request.Form["HiddenPreServers"];
            string HiddenPreLicence = Request.Form["HiddenPreLicence"];
            string HiddenPreSoftware = Request.Form["HiddenPreSoftware"];

            string MacAddressData = "";
            if (WhichDeliveryTab== "SoftwareHardWare")
            {
                //"SoftwareHardWare"
                int macidx = GetNumberofEntries("macAddressPro");
                for (int i = 1; i <= macidx; i++)
                {
                    string item1 = Request.Form["ApplicationSoftwareHardWare" + i.ToString()].ToString();
                    string item2 = Request.Form["MacSoftwareOnlyPro" + i.ToString()].ToString();

                    MacAddressData1.Add(new MacAddressData { No = i.ToString(), Menu = item1, MacAddress = item2 });
                }
                MacAddressData = JsonConvert.SerializeObject(MacAddressData1, Formatting.Indented);
                //"SoftwareHardWare"

            }
            else
            {
                //software only
                int macidx = GetNumberofEntries("macAddress");
                for (int i = 1; i <= macidx; i++)
                {
                    string item1 = Request.Form["ApplicationSoftwareOnly" + i.ToString()].ToString();
                    string item2 = Request.Form["MacSoftwareOnly" + i.ToString()].ToString();

                    MacAddressData1.Add(new MacAddressData { No = i.ToString(), Menu = item1, MacAddress = item2 });
                }
                MacAddressData = JsonConvert.SerializeObject(MacAddressData1, Formatting.Indented);
                //software only
            }


            // 







            string SQL = "update PhilipsLic_Project set centralised_pre_storage='"+ HiddenPreStorage + "', centralised_pre_storage_total='"+ HiddenPreStorageTotal + "', centralised_pre_host_servers='"+ HiddenPreServers + "', centralised_pre_licence='"+ HiddenPreLicence + "', centralised_pre_testserver='"+ HiddenPreSoftware + "',  centralised_pro_storage='" + HiddenProAddStorage + "', centralised_pro_licence='"+ HiddenProlicence + "', centralised_pro_testserver='"+ HiddenProSoftware + "', centralised_block1='" + HiddenButtonBlock1 + "', centralised_block2='" + HiddenButtonBlock2 + "', centralised_add_application='" + AdditionalApplication + "', centralised_deliverymodel='" + WhichDeliveryTab + "', centralised_deliverymodel_ISPSoftware='" + MacAddressData + "',  centralised_siteinfo='" + centralised_siteinfo + "', centralised_concurrent_ent_users='"+ CONCURRENTENTERPRISEUSERS + "' where PhilipsLic_ProjectID =" + id;
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





        }
        catch (Exception ex)
        {

        }

        SetUpApplicationCombo();
        SetupPage();
    }

    protected void cmdConfig_Click(object sender, EventArgs e)
    {
        try
        {
            string id = Request.QueryString["id"];
            Response.Redirect("/lic-server/OutputReporta.aspx?id=" + id);
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





                SetUpApplicationCombo();
                SetupPage();
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
