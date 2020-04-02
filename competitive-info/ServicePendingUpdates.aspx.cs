﻿using System;
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

using Syncfusion.JavaScript;

using MySql.Data.MySqlClient;



public partial class Admin_EditGridData : System.Web.UI.Page
{
    private string m_BuildAppType = string.Empty;
    private string m_BuildVendor = string.Empty;
    private string m_BuildModality = string.Empty;
    private string m_SelectedModel = string.Empty;

    public string m_UserName = string.Empty;
    public FilterSearch m_filtersearchO = null;

    private DataView MyFullData = null;

    public class FilterSearch
    {
        public DateTime CreatedDate { get; set; }
        public string FilterLabel { get; set; }
        public IList<string> ISP { get; set; }
        public IList<string> Modality { get; set; }
        public IList<string> Vendor { get; set; }
        public IList<string> Model { get; set; }
        public IList<string> Software { get; set; }
        public IList<string> Domain { get; set; }
        public IList<string> Module { get; set; }
        public IList<string> DataSet { get; set; }
        public IList<string> ColumnSetUp { get; set; }
        public IList<string> FilterSetUp { get; set; }
    }


    public class BusinessObject
        {
            public int PhilipsID
            {
                get;
                set;
            }

            public int PhilipsMatrixDataID
            {
                get;
                set;
            }

            public string Vendor
            {
                get;
                set;
            }

            public string Model
            {
                get;
                set;
            }

            public string Software
            {
                get;
                set;
            }

            public string DataElement
            {
                get;
                set;
            }

            public string ISP
            {
                get;
                set;
            }

            public string AppType
            {
                get;
                set;
            }

            public string Domain
            {
                get;
                set;
            }

            public string Module
            {
                get;
                set;
            }

            public string Definition
            {
                get;
                set;
            }

            public List<BusinessObject> Children
            {
                get;
                set;
            }

        }




    public string GetUser(Object MyData)
    {
        string MyFormat = string.Empty;

        try
        {

            //FormatFavDate
            // Jan 1,2018

            if (MyData.ToString() != "")
            {

                string sSQL = "SELECT TOP (200) PendingID, PhilipsID, PhilipsMatrixDataID, UserName, UpdateTime FROM PhilipsMatrixData_PendingUpdates WHERE(PhilipsMatrixDataID = "+ MyData.ToString() + ")";
                DataView MyDV = GetData(sSQL);

                foreach (DataRowView rowView in MyDV)
                {
                    string su = rowView["UserName"].ToString();
                    string sT = rowView["UpdateTime"].ToString();

                    MyFormat = su + " on " + sT;

                }


                


            }




        }
        catch { }

        return MyFormat;
    }


    public string ShowMenu()
    {
        string MyMenu = string.Empty;

        try
        {

            string MyMenuMatrix = "<li><a href='Service'>Service</a></li>";
            

            if (Session["UserType"] == null)
            {
                Response.Redirect("/Account/Signin");
            }

            switch (Session["UserType"].ToString())
            {
                case "ADMIN":
                    MyMenu = MyMenuMatrix;// + MyMenuEdit + MyMenuApprove;
                    break;

                case "EDIT":
                    MyMenu = MyMenuMatrix;// + MyMenuEdit;
                    break;

                case "VIEW":
                    MyMenu = MyMenuMatrix;
                    break;

                default:
                    Response.Redirect("/Account/Signin");
                    break;
            }





        }
        catch { }

        return MyMenu;
    }

    public string FormatTimeDate(Object MyData)
    {
        string MyFormat = string.Empty;

        try
        {

            //FormatFavDate
            // Jan 1,2018

            if (MyData.ToString() != "")
            {

                DateTime myd = DateTime.Parse(MyData.ToString());
                MyFormat = myd.ToString("MMM") + "," + " " + myd.Day + " " + myd.Year + " " + myd.Hour + ":" + myd.Minute;


            }




        }
        catch { }

        return MyFormat;
    }



        [WebMethod]
        public static string UpdateAllData()
        {

            return "This string is from Code behind";

        }


    //protected void lnkFavSave_Click(object sender, EventArgs e)
    //{
    //    string BuildFilterJSON = string.Empty;
    //    FilterSearch filtersearch = null;
    //    try
    //    {



    //        #region Setup Json File
    //        filtersearch = new FilterSearch
    //        {
    //            CreatedDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, DateTime.Now.Hour, DateTime.Now.Minute, DateTime.Now.Second, DateTimeKind.Utc),
    //            ISP = new List<string> { },
    //            Modality = new List<string> { },
    //            Vendor = new List<string> { },
    //            Model = new List<string> { },
    //            Software = new List<string> { },
    //            Domain = new List<string> { },
    //            Module = new List<string> { },
    //            DataSet = new List<string> { },
    //            ColumnSetUp = new List<string> { },
    //            FilterSetUp = new List<string> { }
    //        };
    //        #endregion

    //        //Modality//
    //        SetupModality();
    //        string[] Modalitys = m_BuildAppType.Split(',');
    //        foreach (string sModality in Modalitys)
    //        {
    //            filtersearch.Modality.Add(sModality.Replace("'", "").ToString());
    //        }
    //        //Modality//

    //        //Vendor//
    //        SetUpVendor();
    //        string[] Vendors = m_BuildVendor.Split(',');
    //        foreach (string sVendor in Vendors)
    //        {
    //            filtersearch.Vendor.Add(sVendor.Replace("'", "").ToString());
    //        }
    //        //Vendor//

    //        //Model//
    //        foreach (ListItem item in this.chkboxModel.Items)
    //        {
    //            if (item.Selected)
    //            {
    //                filtersearch.Model.Add(item.Value);
    //            }
    //        }
    //        //Model//

    //        //Software//
    //        foreach (ListItem item in this.chkboxSoftware.Items)
    //        {
    //            if (item.Selected)
    //            {
    //                filtersearch.Software.Add(item.Value);
    //            }
    //        }
    //        //Software//

    //        //Domain//
    //        foreach (ListItem item in this.chkboxDomain.Items)
    //        {
    //            if (item.Selected)
    //            {
    //                filtersearch.Domain.Add(item.Value);
    //            }
    //        }
    //        //Domain//

    //        //Module//
    //        foreach (ListItem item in this.chkboxModule.Items)
    //        {
    //            if (item.Selected)
    //            {
    //                filtersearch.Module.Add(item.Value);
    //            }
    //        }
    //        //Module//


    //        foreach (ListItem item in this.chkboxDefinition.Items)
    //        {
    //            if (item.Selected)
    //            {
    //                filtersearch.DataSet.Add(item.Value);
    //            }
    //        }


    //        #region Column Setup

    //        if (chkISP.Checked == true)
    //        {
    //            filtersearch.ColumnSetUp.Add("ISP");
    //        }

    //        if (chkColVendor.Checked == true)
    //        {
    //            filtersearch.ColumnSetUp.Add("Vendor");
    //        }

    //        if (chkColDomain.Checked == true)
    //        {
    //            filtersearch.ColumnSetUp.Add("Domain");
    //        }

    //        if (chkColModality.Checked == true)
    //        {
    //            filtersearch.ColumnSetUp.Add("Modality");
    //        }

    //        if (chkColModel.Checked == true)
    //        {
    //            filtersearch.ColumnSetUp.Add("Model");
    //        }

    //        if (chkColModule.Checked == true)
    //        {
    //            filtersearch.ColumnSetUp.Add("Module");
    //        }

    //        if (chkColSoftware.Checked == true)
    //        {
    //            filtersearch.ColumnSetUp.Add("Software");
    //        }

    //        if (chkColDefinition.Checked == true)
    //        {
    //            filtersearch.ColumnSetUp.Add("Definition");
    //        }
    //        #endregion

    //        #region FilterSetUp



    //        #endregion

    //        string sUserID = Session["UserID"].ToString();


    //        //Get OrderID

    //        DataView MyOrder = GetData("SELECT TOP (1) OrderID FROM PhilipsMatrixFilter ORDER BY OrderID DESC");
    //        int MyOrderID = 0;
    //        foreach (DataRowView rowView in MyOrder)
    //        {
    //            MyOrderID = Convert.ToInt32(rowView["OrderID"].ToString());
    //        }

    //        MyOrderID++;
    //        ////



    //        //Serialize json
    //        string json = JsonConvert.SerializeObject(filtersearch, Formatting.Indented);

    //        //save data
    //        //SaveData("INSERT  INTO PhilipsMatrixFilter(JSONFilterSetUp, FilterLabel,UserID,OrderID) VALUES('" + json + "', '" + txtFavLabel.Text + "','" + sUserID + "'," + MyOrderID + ")");


    //        SetUpFavList();


    //        //FilterSearch filtersearchO = JsonConvert.DeserializeObject<FilterSearch>(json);




    //    }
    //    catch //(Exception ex)
    //    { }
    //}

    private string GetTrafficString(string DataItem)
    {
        string myData = string.Empty;
        string myDataItem = string.Empty;

        try
        {

            if (DataItem.Contains(":"))
            {
                string[] innerSplitData = DataItem.Split(':');
                try
                {

                    myDataItem = innerSplitData[1].ToString();
                }
                catch { }
            }
            else
            {
                myDataItem = DataItem;
            }

            switch (myDataItem)
            {
                case "1":
                    myData = "Better";
                    break;
                case "2":
                    myData = "Worse";
                    break;
                case "3":
                    myData = "50/50";
                    break;
                case "4":
                    myData = "None";
                    break;
            }

        }
        catch { }

        return myData;

    }

    public string BuildData(object myData)
    {
        string HTMLBuilder = string.Empty;

        try
        {
            string UserName = string.Empty;
            string UserUpdateTime = string.Empty;

            string PhilipsID = DataBinder.Eval(myData, "PhilipsID").ToString();
            string PhilipsMatrixDataID = DataBinder.Eval(myData, "PhilipsMatrixDataID").ToString();

            string PendingDetails = "select * from PhilipsMatrixData_PendingUpdates where PhilipsMatrixDataID=" + PhilipsMatrixDataID;
            DataView DVPendingDetails = GetData(PendingDetails);

            foreach (DataRowView rowView in DVPendingDetails)
            {
                UserName = rowView["UserName"].ToString();
                UserUpdateTime = rowView["UpdateTime"].ToString();
            }



            string model = DataBinder.Eval(myData, "Model").ToString();
            string vendor = DataBinder.Eval(myData, "Vendor").ToString();
            string software = DataBinder.Eval(myData, "Software").ToString();
            string DataElement = DataBinder.Eval(myData, "DataElement").ToString();
            string ISP = DataBinder.Eval(myData, "ISP").ToString();
            string AppType = DataBinder.Eval(myData, "AppType").ToString();
            string Domain = DataBinder.Eval(myData, "Domain").ToString();
            string Module = DataBinder.Eval(myData, "Module").ToString();
            string Definition = DataBinder.Eval(myData, "Definition").ToString();

            string SQL = "SELECT PhilipsMatrix.PhilipsID, PhilipsMatrix.AppType, PhilipsMatrix.Domain, PhilipsMatrix.Module, PhilipsMatrix.Definition, PhilipsMatrix.SubApp, PhilipsMatrixData.PhilipsMatrixDataID, PhilipsMatrixData.Model, PhilipsMatrixData.Software , PhilipsMatrixData.Vendor, PhilipsMatrixData.DataElement,Notes FROM PhilipsMatrix INNER JOIN  PhilipsMatrixData ON PhilipsMatrix.PhilipsID = PhilipsMatrixData.PhilipsMatrixID WHERE PhilipsMatrixDataID =" + PhilipsMatrixDataID;

            

            //current Item
            DataView DVCurrent = GetData(SQL);

            foreach (DataRowView rowView in DVCurrent)
            {


                //HTMLBuilder += "<tr>";
                //HTMLBuilder += "<td style='border-top:1px solid #ddd;' class='icon_div green g text-green'>Current</td>";
                //HTMLBuilder += "<td class=''>"+ rowView["Vendor"].ToString() + "</td>";
                //HTMLBuilder += "<td class=''>" + rowView["Model"].ToString() + "</td>";
                //HTMLBuilder += "<td class=''>" + rowView["Software"].ToString() + "</td>";
                ////HTMLBuilder += "<td class=''>Single</td>";
                ////HTMLBuilder += "<td style='border-top:1px solid #ddd;' class='icon_div green g'><i class='fa fa-exclamation-circle'></i></td>";
                //HTMLBuilder += "<td class=''style='border-top:1px solid #ddd;'>" + rowView["DataElement"].ToString() + "</td>";
                //HTMLBuilder += "<td style='border-top:1px solid #ddd;' ></td>";
                //HTMLBuilder += "<td class=''style='border-top:1px solid #ddd;'>" + rowView["AppType"].ToString() + "</td>";
                //HTMLBuilder += "<td class=''style='border-top:1px solid #ddd;'>" + rowView["Domain"].ToString() + "</td>";
                //HTMLBuilder += "<td class=''style='border-top:1px solid #ddd;'>" + rowView["Module"].ToString() + "</td>";
                ////HTMLBuilder += "<td class=''style='border-top:1px solid #ddd;'>Neurology</td>";
                //HTMLBuilder += "<td class=''style='border-top:1px solid #ddd;'>" + rowView["Definition"].ToString() + "</td>";
                //HTMLBuilder += "</tr>";

                if (model=="")
                {
                  //  model = rowView["Model"].ToString();
                }

            }


            //New Item

            HTMLBuilder += "<tr>";
            HTMLBuilder += "<td style='border-top:1px solid #ddd;' class='icon_div green g text-orange'>New</td>";
            HTMLBuilder += "<td class='text-orange'>"+ vendor+"</td>";
            HTMLBuilder += "<td class=''>"+ model + "</td>";
            HTMLBuilder += "<td class=''>"+software+"</td>";           
            HTMLBuilder += "<td class=''>" + DataElement + "</td>";
            HTMLBuilder += "<td style='border-top:1px solid #ddd;'></td>";
            HTMLBuilder += "<td class=''style='border-top:1px solid #ddd;'>"+AppType+"</td>";
            HTMLBuilder += "<td class='text-orange'style='border-top:1px solid #ddd;'>"+Domain+"</td>";
            HTMLBuilder += "<td class=''style='border-top:1px solid #ddd;'>"+Module+"</td>";
           
            HTMLBuilder += "<td class=''style='border-top:1px solid #ddd;'>"+ Definition + "</td>";
            HTMLBuilder += "</tr>";

            HTMLBuilder += "</table>";
            HTMLBuilder += "<div class='table-bottom-content'>";
            HTMLBuilder += "<p><strong>Edited by</strong> Author "+ UserName + " on "+ UserUpdateTime + " </p>";
            HTMLBuilder += "<p><strong>Additional comments:</strong> </p>";

            HTMLBuilder += "</div>";

        }
        catch (Exception ex)
        {
            string ddd = ex.Message.ToString();
        }

        return HTMLBuilder;
    }

    public string GetColour(object mydata, bool Noi)
    {
        string mycolour = string.Empty;

        //icon_div green g
        //icon_div green orange
        //icon_div green yellow
        //icon_div green red

        switch (mydata.ToString())
        {
            case "2":
            case "3":
            case "4":
                if (Noi == true)
                {
                    mycolour = "icon_div noiyellow yellow";
                }
                else
                {
                    mycolour = "icon_div green yellow";
                }
                break;


            case "-1":
                if (Noi == true)
                {
                    mycolour = "icon_div noired red";
                }
                else
                {
                    mycolour = "icon_div green red";
                }
                break;

            case "8":
            case "7":
            case "6":
            case "5":
                if (Noi == true)
                {
                    mycolour = "icon_div noigreen g";
                }
                else
                {
                    mycolour = "icon_div green g";
                }
                break;
            case "1":
                if (Noi == true)
                {
                    mycolour = "icon_div noiorange orange";
                }
                else
                {
                    mycolour = "icon_div green orange";
                }
                break;
            default:
                if (Noi == true)
                {
                    mycolour = "icon_div noiwhite white";
                }
                else
                {
                    mycolour = "icon_div green white";
                }
                break;
        }


        return mycolour;
    }

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

    private void SaveData(string sql)
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

    }

  

    private void SetUpColumnSelection()
    {
        try
        {
           




        }
        catch { }
    }


    private string StripData(string Content)
    {
        string MyData = string.Empty;

        try
        {


            string[] SplitItems = Content.Split(':');
            int idx = 0;
            foreach (string item in SplitItems)
            {

                if (idx > 0)
                {
                    MyData += item.TrimStart();
                }

                idx++;
            }

        }
        catch
        {

        }

        return MyData;
    }

    private void SetupGrid()
    {
        int UserAND = 0;
        string myMatrixID = string.Empty;
        string sID = string.Empty;

        try
        {
            
            string SQL = "select * from PhilipsAnalysisServiceData_PendingUpdates WHERE Status IN (1,4) ORDER BY PhilipsAnalysisServicePendingUpdatesID DESC";            
            DataView MyDV = GetData(SQL);          

            repDataGrid.DataSource = MyDV;
            repDataGrid.DataBind();

            int MyCount = 0; // MyDV.Count;
            
            foreach (RepeaterItem item in repDataGrid.Items)
            {

                System.Web.UI.WebControls.HiddenField HF_PhilipsAnalysisCompetitorsPendingUpdatesID = (System.Web.UI.WebControls.HiddenField)item.FindControl("HF_PhilipsAnalysisCompetitorsPendingUpdatesID");

                System.Web.UI.WebControls.CheckBox HF_CheckBox = (System.Web.UI.WebControls.CheckBox)item.FindControl("chkIsSelected");

               

                //Get ID from Repeater
                //HF_MatrixID.Value
                if (HF_CheckBox.Checked==true)
                {
                    MyCount++;
                }


            }

            if (MyCount > 0)
            {
                cmdShowDelete.Text = "Delete "+ MyCount + " items";
                cmdApproveItems.Text = "Approve " + MyCount + " items";
                //cmdSaveItems.Text = "Save " + MyCount + " items";
            }
            else
            {
                cmdShowDelete.Text = "Delete 0 item";
                cmdApproveItems.Text = "Approve 0 item";
               // cmdSaveItems.Text = "Save 0 item";
            }


            

        }
        catch (Exception ex)
        {
        }
    }

    
 
   
      

    private void PageSetUp()
    {
        string FavListID = string.Empty;        

        try
        {

            if (!IsPostBack)
            {                                              
                SetupGrid();
            }
        }
        catch { }
    }

    protected void cmdSubmit_Click(object sender, EventArgs e)
    {
        try
        {

           

        }
        catch { }
    }

  

    protected void cmdDeleteItems_Click(object sender, EventArgs e)
    {
        try {

            foreach (RepeaterItem item in repDataGrid.Items)
            {

                System.Web.UI.WebControls.HiddenField HF_PhilipsPendingID = (System.Web.UI.WebControls.HiddenField)item.FindControl("HF_PhilipsPendingID");

                System.Web.UI.WebControls.CheckBox HF_CheckBox = (System.Web.UI.WebControls.CheckBox)item.FindControl("chkIsSelected");

                if (HF_CheckBox.Checked == true)
                {

                    string SQLPending = "update PhilipsAnalysisServiceData_PendingUpdates set Status='3' where  PhilipsAnalysisServicePendingUpdatesID=" + HF_PhilipsPendingID.Value;
                    Helper.InsertData(SQLPending);                                   
                }                

            }

            SetupGrid();


        }
        catch { }
    }




    private string DecodeTrafficString(string DataItem)
    {
        string myData = string.Empty;
        string myDataItem = string.Empty;

        try
        {

            switch (DataItem)
            {
                case "Better":
                    myData = "1";
                    break;
                case "Worse":
                    myData = "2";
                    break;
                case "50/50":
                    myData = "3";
                    break;
                case "None":
                    myData = "4";
                    break;
            }

        }
        catch { }

        return myData;

    }

    private void ApproveData(string PendingID, RepeaterItem item)
    {
        try {

            if (PendingID != "")
            {
                string sSQL = "select * FROM PhilipsAnalysisServiceData_PendingUpdates where PhilipsAnalysisServicePendingUpdatesID=" + PendingID;
                DataView mDV = Helper.GetData(sSQL);

                foreach (DataRowView rowView in mDV)
                {
                                        
                    string NewDataUpdate = rowView["NewDataUpdate"].ToString();
                    string OldData = rowView["OldData"].ToString();
                    string UpdateColumnName = rowView["UpdateColumnName"].ToString().Replace(" ", "_");
                    string Type = rowView["Type"].ToString();

                    switch (UpdateColumnName)
                    {


                        case "Customer_support_portal":
                            UpdateColumnName = "Customer_support";
                            break;
                        case "Customer_support_portal_chk":
                            UpdateColumnName = "Customer_support_chk";
                            break;

                        case "Reporting_and_Analytics":
                            UpdateColumnName = "Reporting";
                            break;
                        case "Reporting_and_Analytics_chk":
                            UpdateColumnName = "Reporting_chk";
                            break;

                        case "SW_updates_and_upgrades":
                            UpdateColumnName = "SW_updates";
                            break;
                        case "SW_updates_and_upgrades_chk":
                            UpdateColumnName = "SW_updates_chk";
                            break;

                        case "Maintenance_and_Support":
                            UpdateColumnName = "Maintenance";
                            break;
                        case "Maintenance_and_Support_chk":
                            UpdateColumnName = "Maintenance_chk";
                            break;

                        case "Clinical_and_IT_training":
                            UpdateColumnName = "Clinical_IT_training";
                            break;
                        case "Clinical_and_IT_training_chk":
                            UpdateColumnName = "Clinical_IT_training_chk";
                            break;
                        
                        case "Lifecycle_Consulting_services_chk":
                            UpdateColumnName = "Lifecycle_chk";
                            break;
                        case "Hardware_Refresh_chk":
                            UpdateColumnName = "Hardware_chk";
                            break;
                        case "24/7_Customer_Support_chk":
                            UpdateColumnName = "twentyfour_customer_chk";
                            break;
                       
                        case "24/7_Customer_Support":
                            UpdateColumnName = "twentyfour_customer";
                            break;
                        case "Lifecycle_Consulting_services":
                            UpdateColumnName = "Lifecycle";
                            break;
                        case "Hardware_Refresh":
                            UpdateColumnName = "Hardware";
                            break;
                        case "Onsite_Installations":
                            UpdateColumnName = "Onsite";
                            break;
                        case "Proactive_monitoring":
                            UpdateColumnName = "Proactive";
                            break;

                    }

                    switch (Type)
                    {
                        case "Cannon":
                            Type = "Canon/Toshiba/Vital";
                            break;
                        case "Agfa":
                            Type = "Agfa Healthcare";
                            break;
                        case "GE":
                            Type = "GE Healthcare";
                            break;
                        case "Siemens":
                            Type = "Siemens Medical";
                            break;
                        case "Tera":
                            Type = "TeraRecon";
                            break;
                    }
                    

                    System.Web.UI.WebControls.TextBox txtNew = (System.Web.UI.WebControls.TextBox)item.FindControl("txtNew");
                    System.Web.UI.WebControls.TextBox txtCurrent = (System.Web.UI.WebControls.TextBox)item.FindControl("txtCurrent");
                    System.Web.UI.WebControls.TextBox txtNotes = (System.Web.UI.WebControls.TextBox)item.FindControl("txtNotes");         
                    if (txtNotes.Text==null)
                    {
                        txtNotes.Text = "";
                    }


                    if (UpdateColumnName.Contains("_chk"))
                    {
                        string SQL1 = "UPDATE PhilipsAnalysisServiceData SET " + UpdateColumnName + " = '" + DecodeTrafficString(txtNew.Text) + "',  Comment = '" + txtNotes.Text + "' WHERE (Name = '" + Type + "')";
                        Helper.InsertData(SQL1);
                    }
                    else
                    {
                        string SQL1 = "UPDATE PhilipsAnalysisServiceData SET " + UpdateColumnName + " = '" + txtNew.Text + "',  Comment = '" + txtNotes.Text + "' WHERE (Name = '" + Type + "')";
                        Helper.InsertData(SQL1);
                    }
                                   

                }



            }




        }
        catch { }
    }

    private void UpdateData(string PendingID, RepeaterItem item)
    {
        try
        {

            if (PendingID != "")
            {
                string sSQL = "select * FROM PhilipsAnalysisServiceData_PendingUpdates where PhilipsAnalysisServicePendingUpdatesID=" + PendingID;
                DataView mDV = Helper.GetData(sSQL);

                foreach (DataRowView rowView in mDV)
                {

                    string NewDataUpdate = rowView["NewDataUpdate"].ToString();
                    string OldData = rowView["OldData"].ToString();
                    string UpdateColumnName = rowView["UpdateColumnName"].ToString().Replace(" ", "_"); ;
                    string Type = rowView["Type"].ToString();

                    switch (Type)
                    {
                        case "Cannon":
                            Type = "Canon/Toshiba/Vital";
                            break;
                        case "Agfa":
                            Type = "Agfa Healthcare";
                            break;
                        case "GE":
                            Type = "GE Healthcare";
                            break;
                        case "Siemens":
                            Type = "Siemens Medical";
                            break;
                        case "Tera":
                            Type = "TeraRecon";
                            break;
                    }


                    System.Web.UI.WebControls.TextBox txtNew = (System.Web.UI.WebControls.TextBox)item.FindControl("txtNew");
                    System.Web.UI.WebControls.TextBox txtCurrent = (System.Web.UI.WebControls.TextBox)item.FindControl("txtCurrent");
                    System.Web.UI.WebControls.TextBox txtNotes = (System.Web.UI.WebControls.TextBox)item.FindControl("txtNotes");
                    if (txtNotes.Text == null)
                    {
                        txtNotes.Text = "";
                    }

                    
                    string MyTime = DateTime.Now.Year + "-" + DateTime.Now.Month + "-" + DateTime.Now.Day + " " + DateTime.Now.ToString("HH:mm:ss");

                    string SQL1 = "UPDATE  PhilipsAnalysisServiceData_PendingUpdates  SET NewDataUpdate = '" + txtNew.Text + "', OldData = '" + txtCurrent.Text + "', Comment = '"+ txtNotes.Text + "', Status = 4, UpdateTime = '"+ MyTime + "',UserID = '" + Session["UserID"] + "', UserName = '" + Session["User"] + "' WHERE  (PhilipsAnalysisServicePendingUpdatesID = " + PendingID + ")";

                    Helper.InsertData(SQL1);

                    //

                }



            }




        }
        catch { }
    }

    protected void cmdApproveItems_Click(object sender, EventArgs e)
    {
        try
        {
            foreach (RepeaterItem item in repDataGrid.Items)
            {                
                System.Web.UI.WebControls.HiddenField HF_PhilipsPendingID = (System.Web.UI.WebControls.HiddenField)item.FindControl("HF_PhilipsPendingID");

                System.Web.UI.WebControls.CheckBox HF_CheckBox = (System.Web.UI.WebControls.CheckBox)item.FindControl("chkIsSelected");
             
                if (HF_CheckBox.Checked==true)
                {
                    System.Web.UI.WebControls.TextBox txtComment = (System.Web.UI.WebControls.TextBox)item.FindControl("txtComment");

                    string SQLPending = "UPDATE PhilipsAnalysisServiceData_PendingUpdates SET Status = 2 WHERE(PhilipsAnalysisServicePendingUpdatesID = " + HF_PhilipsPendingID.Value + ")";
                    Helper.InsertData(SQLPending);

                    ApproveData(HF_PhilipsPendingID.Value, item);
                }                

            }

            SetupGrid();

        }
        catch { }

    }

    protected void cmdSaveItems_Click(object sender, EventArgs e)
    {
        try
        {
            foreach (RepeaterItem item in repDataGrid.Items)
            {
                System.Web.UI.WebControls.HiddenField HF_PhilipsPendingID = (System.Web.UI.WebControls.HiddenField)item.FindControl("HF_PhilipsPendingID");

                //System.Web.UI.WebControls.CheckBox HF_CheckBox = (System.Web.UI.WebControls.CheckBox)item.FindControl("chkIsSelected");

                //if (HF_CheckBox.Checked == true)
                //{
                   // System.Web.UI.WebControls.TextBox txtComment = (System.Web.UI.WebControls.TextBox)item.FindControl("txtComment");

                    //string SQLPending = "UPDATE PhilipsAnalysisCompetitorsData_PendingUpdates SET Status = 4 WHERE(PhilipsAnalysisServicePendingUpdatesID = " + HF_PhilipsPendingID.Value + ")";
                    //SaveData(SQLPending);

                    UpdateData(HF_PhilipsPendingID.Value, item);
                //}

            }

            SetupGrid();

        }
        catch { }
    }

    protected void repDataGrid_ItemDataBound(object sender, RepeaterItemEventArgs e)
    {

        string MyPhilips = string.Empty;
        string MyTera = string.Empty;
        string MySiemens = string.Empty;
        string MyGE = string.Empty;
        string MyCannon = string.Empty;
        string MyAgfa = string.Empty;


        try
        {

            if (e.Item.ItemType == ListItemType.Item || e.Item.ItemType == ListItemType.AlternatingItem)
            {

                DataRowView drv = e.Item.DataItem as DataRowView;                                                               

                System.Web.UI.WebControls.Label lblcolumnName = e.Item.FindControl("lblcolumnName") as System.Web.UI.WebControls.Label;               
                System.Web.UI.WebControls.HiddenField HF_HF_PhilipsPendingID = e.Item.FindControl("HF_PhilipsPendingID") as System.Web.UI.WebControls.HiddenField;
                System.Web.UI.WebControls.TextBox txtNew = e.Item.FindControl("txtNew") as System.Web.UI.WebControls.TextBox;
                System.Web.UI.WebControls.TextBox txtCurrent = e.Item.FindControl("txtCurrent") as System.Web.UI.WebControls.TextBox;
                System.Web.UI.WebControls.TextBox txtNotes = e.Item.FindControl("txtNotes") as System.Web.UI.WebControls.TextBox;

                


                HF_HF_PhilipsPendingID.Value= drv.Row["PhilipsAnalysisServicePendingUpdatesID"].ToString();


                if (drv.Row["UpdateColumnName"].ToString().Contains("_chk"))
                {
                    //traffic lights                    
                    txtNew.Text = GetTrafficString(drv.Row["NewDataUpdate"].ToString());
                    txtCurrent.Text = GetTrafficString(drv.Row["OldData"].ToString());

                    lblcolumnName.Text = drv.Row["UpdateColumnName"].ToString().Replace("_chk", "") + ", " + drv.Row["Type"].ToString();
                    txtNotes.Text = drv.Row["Comment"].ToString();
                }
                else
                {
                    txtNew.Text = drv.Row["NewDataUpdate"].ToString();
                    txtCurrent.Text = drv.Row["OldData"].ToString();
                    lblcolumnName.Text = drv.Row["UpdateColumnName"].ToString() + ", " + drv.Row["Type"].ToString();
                    txtNotes.Text = drv.Row["Comment"].ToString();

                    if (drv.Row["NewDataUpdate"].ToString() != drv.Row["OldData"].ToString())
                    {
                        txtNew.ControlStyle.Font.Bold = true;
                    }

                }                

            }


        }
        catch (Exception ex)
        {

        }
    }


    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {
                       
            bool Signin = false;

            if (Session["User"] != null)
            {
               
                m_UserName = Session["User"].ToString();
                Signin = true;
               
                if (Session["UserType"] != null)
                {
                    if (Session["Services"].ToString() != "Super Admin")
                    {
                        Response.Redirect("/",true);
                    }
                }
                
            }


            if (Signin == true)
            {
                //panFeedBack.Visible = false;
                PageSetUp();

            }
            else
            {
                Response.Redirect("/Account/Signin");
            }

        }
        catch { }
    }

    
}