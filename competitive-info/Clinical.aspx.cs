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
using Syncfusion.JavaScript.Models;


using Syncfusion.JavaScript.Web;


public partial class competitive_info_Clinical : System.Web.UI.Page
{
    List<Orders> PhilipsDataLST = new List<Orders>();
    string m_AppCount = string.Empty;
    List<Orders> order = new List<Orders>();
    public string m_UserName = string.Empty;
    public string m_UserID = string.Empty;
    public string m_UserType = string.Empty;

    public string m_JavascriptClinical = string.Empty;

    public string AppCount()
    {
        string sCount = string.Empty;

        try
        {

            sCount = "<div>" + m_AppCount + " Applications Found</div>";

        }
        catch { }

        return sCount;
    }





    [Serializable]
    public class Orders
    {
        public Orders()
        {

        }

        private string GetMultipleData(DataRowView rowView, string DataType)
        {

            string MyItem = string.Empty;
            string DataItem = string.Empty;

            try
            {




                if (DataType == "Modality")
                {
                    //if (rowView["NM_MI"].ToString() != "")
                    //{
                    //    DataItem += rowView["NM_MI"].ToString() + ",";
                    //}

                    if (rowView["NM_MI"].ToString() != "")
                    {
                        DataItem += rowView["NM_MI"].ToString() + ",";
                    }

                    if (rowView["CT"].ToString() != "")
                    {
                        DataItem += rowView["CT"].ToString() + ",";
                    }

                    if (rowView["MR"].ToString() != "")
                    {
                        DataItem += rowView["MR"].ToString() + ",";
                    }

                    if (rowView["US"].ToString() != "")
                    {
                        DataItem += rowView["US"].ToString() + ",";
                    }

                    if (rowView["PET"].ToString() != "")
                    {
                        DataItem += rowView["PET"].ToString() + ",";
                    }

                    if (rowView["MM"].ToString() != "")
                    {
                        DataItem += rowView["MM"].ToString() + ",";
                    }

                    //if (DataItem != "")
                    //{
                    //    DataItem = "";
                    //    // DataItem = DataItem.Substring(0, DataItem.Length - 1).Trim();
                    //    sublist.Add(DataItem);

                    //}
                    //else
                    //{
                    //    DataItem = "";
                    //    sublist.Add(DataItem);
                    //}
                }
                else
                {

                    if (rowView["CARD"].ToString() != "")
                    {
                        DataItem += rowView["CARD"].ToString() + ",";
                    }

                    if (rowView["EMER"].ToString() != "")
                    {
                        DataItem += rowView["EMER"].ToString() + ",";
                    }

                    if (rowView["NEUR"].ToString() != "")
                    {
                        DataItem += rowView["NEUR"].ToString() + ",";
                    }

                    if (rowView["ORTH"].ToString() != "")
                    {
                        DataItem += rowView["ORTH"].ToString() + ",";
                    }

                    if (rowView["ONCO"].ToString() != "")
                    {
                        DataItem += rowView["ONCO"].ToString() + ",";
                    }

                    if (rowView["VASC"].ToString() != "")
                    {
                        DataItem += rowView["VASC"].ToString() + ",";
                    }


                    //if (DataItem != "")
                    //{
                    //    DataItem = "";
                    //    //DataItem = DataItem.Substring(0, DataItem.Length - 1).Trim();
                    //    sublist.Add(DataItem);

                    //}
                    //else
                    //{
                    //    DataItem = "";
                    //    sublist.Add(DataItem);
                    //}

                    //switch (Item_Name)
                    //{
                    //    case "CARD":
                    //    case "EMER":
                    //    case "NEUR":
                    //    case "ORTH":
                    //    case "ONCO":
                    //    case "VASC":
                    //        if (Item_Description != "")
                    //        {
                    //            sublist.Add(Item_Description);
                    //        }
                    //        break;

                    //}
                }









            }
            catch { }

            return DataItem;

        }

        public Orders(long OrderId, string ColumnName, DataView MyDV, string RowName)
        {
            this.OrderID = OrderId;
            this.ColumnName = ColumnName;



            this.DataRowElement = new List<string>();

            foreach (DataRowView rowView in MyDV)
            {

                switch (RowName)
                {
                    case "Modality":
                        string GetItem = GetMultipleData(rowView, "Modality");
                        if (GetItem != "")
                        {
                            GetItem = GetItem.Substring(0, GetItem.Length - 1).Trim();
                        }
                        this.DataRowElement.Add(GetItem);
                        break;
                    case "Clinical":
                        string GetItemClinical = GetMultipleData(rowView, "Clinical");
                        if (GetItemClinical != "")
                        {
                            GetItemClinical = GetItemClinical.Substring(0, GetItemClinical.Length - 1).Trim();
                        }
                        this.DataRowElement.Add(GetItemClinical);
                        break;

                    default:
                        this.DataRowElement.Add(rowView[RowName].ToString());
                        break;
                }

            }




        }
        public long OrderID { get; set; }
        public string ColumnName { get; set; }
        public List<string> DataRowElement { get; set; }

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
                Response.Redirect("/Account/Signin");
            }

            switch (Session["Clinical"].ToString())
            {
                case "Super Admin":
                case "ADMIN":
                    MyMenu = MyProfile + MyTracking;
                    break;

                case "Super Viewer":
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


    private string GetDataForMulti(string ItemTocheck, string ID, DataView MyDV)
    {
        string sItemList = string.Empty;


        try
        {

            switch (ItemTocheck)
            {

                case "Modality":

                    foreach (DataRowView rowView in MyDV)
                    {
                        if (rowView["ClinicalID"].ToString() == ID)
                        {

                            if (rowView["NM_MI"].ToString() != "")
                            {
                                sItemList += rowView["NM_MI"].ToString() + ",";
                            }

                            if (rowView["CT"].ToString() != "")
                            {
                                sItemList += rowView["CT"].ToString() + ",";
                            }

                            if (rowView["MR"].ToString() != "")
                            {
                                sItemList += rowView["MR"].ToString() + ",";
                            }

                            if (rowView["US"].ToString() != "")
                            {
                                sItemList += rowView["US"].ToString() + ",";
                            }

                            if (rowView["PET"].ToString() != "")
                            {
                                sItemList += rowView["PET"].ToString() + ",";
                            }

                            if (rowView["MM"].ToString() != "")
                            {
                                sItemList += rowView["MM"].ToString() + ",";
                            }

                        }
                    }

                    break;
                case "Clinical_Domain":

                    foreach (DataRowView rowView in MyDV)
                    {
                        if (rowView["ClinicalID"].ToString() == ID)
                        {
                            if (rowView["CARD"].ToString() != "")
                            {
                                sItemList += rowView["CARD"].ToString() + ",";
                            }

                            if (rowView["EMER"].ToString() != "")
                            {
                                sItemList += rowView["EMER"].ToString() + ",";
                            }

                            if (rowView["NEUR"].ToString() != "")
                            {
                                sItemList += rowView["NEUR"].ToString() + ",";
                            }

                            if (rowView["ORTH"].ToString() != "")
                            {
                                sItemList += rowView["ORTH"].ToString() + ",";
                            }

                            if (rowView["ONCO"].ToString() != "")
                            {
                                sItemList += rowView["ONCO"].ToString() + ",";
                            }

                            if (rowView["VASC"].ToString() != "")
                            {
                                sItemList += rowView["VASC"].ToString() + ",";
                            }



                        }
                    }

                    break;
            }

            //clean list
            if (sItemList != "")
            {
                sItemList = sItemList.Substring(0, sItemList.Length - 1).Trim();
            }
        }
        catch { }

        return sItemList;
    }

    protected void EditAction(string eventType, object record)
    {
        try
        {

            PhilipsDataLST = Session["CellEditDataSource"] as List<Orders>;
            Dictionary<string, object> DataItem3 = new Dictionary<string, object>();
            string ID = string.Empty;
            string ColumnName = string.Empty;

            if (PhilipsDataLST == null)
            {
                DataSetUp();
                PhilipsDataLST = Session["CellEditDataSource"] as List<Orders>;
            }


            DataTable MYTable = Session["DataStore"] as DataTable;
            DataView myDVData = MYTable.DefaultView;


            Dictionary<string, object> KeyVal = record as Dictionary<string, object>;
            if (eventType == "endEdit")
            {

                foreach (KeyValuePair<string, object> keyval in KeyVal)
                {

                    if (keyval.Key == "ColumnName")
                    {
                        ColumnName = Convert.ToString(keyval.Value).Replace(" ", "_");
                        switch (ColumnName)
                        {

                            case "Intend_to_Use":
                                ColumnName = "Overview";
                                break;
                            case "Features_and_Capabilities":
                                ColumnName = "FEATURE";
                                break;
                            case "Philips_Matching_Application":
                                ColumnName = "PHILIPSMatchingAPP";
                                break;
                            case "Application":
                                ColumnName = "ActualAPP";
                                break;
                        }
                    }

                    if (keyval.Key == "DataRowElement")
                    {
                        //loop though and find out which on was changed

                        DataItem3 = keyval.Value as Dictionary<string, object>;
                        //GetOrderofColumn(ColumnName);
                        try
                        {
                            foreach (KeyValuePair<string, object> keyItem in DataItem3)
                            {

                                if (keyItem.Value != null)
                                {
                                    string ItemData = keyItem.Value.ToString();
                                    string OldData = "";
                                    string myID = "";

                                    if (ColumnName == "Clinical_Domain" | ColumnName == "Modality")
                                    {
                                        myID = myDVData.Table.Rows[Convert.ToInt32(keyItem.Key.ToString())].ItemArray[Convert.ToInt32(0)].ToString();
                                        OldData = GetDataForMulti(ColumnName, myID, myDVData);
                                    }
                                    else
                                    {
                                        OldData = myDVData.Table.Rows[Convert.ToInt32(keyItem.Key.ToString())][ColumnName].ToString().Replace("\n", "").Replace("\r", "");
                                    }

                                    if (ItemData.Replace("\n", "").Replace("\r", "") != OldData)
                                    {
                                        //Data mismatch
                                        myID = myDVData.Table.Rows[Convert.ToInt32(keyItem.Key.ToString())].ItemArray[Convert.ToInt32(0)].ToString();


                                        string UpdateSQL = "INSERT INTO PhilipsAnalysisClinicalData_PendingUpdates(ClinicalID,NewDataUpdate, OldData, UpdateColumnName, UserID, UserName, Status,Type) VALUES(" + myID + ",'" + ItemData.Replace("'", "&#39;") + "', '" + OldData.Replace("'", "&#39;") + "', '" + ColumnName + "', '" + Session["UserID"] + "', '" + Session["User"] + "', 1,'')";
                                        Helper.InsertData(UpdateSQL);

                                    }
                                }
                            }
                        }
                        catch (Exception ex)
                        {
                            string hg = "";
                            hg = "";
                        }



                    }
                }
            }


            try
            {


                m_AppCount = PhilipsDataLST[0].DataRowElement.Count.ToString();

            }
            catch { }


            this.Grid1.DataSource = PhilipsDataLST;
            this.Grid1.DataBind();

        }
        catch { }
    }

    protected void EditEvents_ServerEditRow(object sender, GridEventArgs e)
    {
        EditAction(e.EventType, e.Arguments["data"]);
    }


    private List<string> GetClinicalData(DataView MyDV, string SelectDataName)
    {
        List<string> sublist = new List<string>();


        try
        {


            foreach (DataRowView rowView in MyDV)
            {

                switch (SelectDataName)
                {
                    case "PHILIPSMatchingAPP":
                        sublist.Add(rowView["PHILIPSMatchingAPP"].ToString());
                        break;
                    case "ID":
                        sublist.Add(rowView["ClinicalID"].ToString());
                        break;
                    case "Competitor":
                        sublist.Add(rowView["Competitor"].ToString());
                        break;
                    case "ACTUALAPP":
                        sublist.Add(rowView["ACTUALAPP"].ToString());
                        break;
                    case "510K":
                        sublist.Add(rowView["510K"].ToString());
                        break;
                    case "QUICK SUMMARY":
                        sublist.Add(rowView["QUICKSUMMARY"].ToString());
                        break;
                    case "DESCRIPTION":
                        sublist.Add(rowView["DESCRIPTION"].ToString());
                        break;
                    case "FEATURE":
                        sublist.Add(rowView["FEATURE"].ToString());
                        break;
                    case "PROS":
                        sublist.Add(rowView["PROS"].ToString());
                        break;

                    case "PHILIPSRESPONSE":
                        sublist.Add(rowView["PHILIPSRESPONSE"].ToString());
                        break;

                    case "WHATTHEYSAYABOUTUS":
                        sublist.Add(rowView["WHATTHEYSAYABOUTUS"].ToString());
                        break;

                    case "PRESSRELEASES":
                        sublist.Add(rowView["WHATTHEYSAYABOUTUS"].ToString());
                        break;




                    default:
                        string kol = "";
                        break;
                }



            }


        }
        catch { }

        return sublist;

    }

    private List<string> GetMultipleData(DataView MyDV, string DataType)
    {
        List<string> sublist = new List<string>();


        try
        {
            string DataItem = string.Empty;

            foreach (DataRowView rowView in MyDV)
            {

                if (DataType == "Modality")
                {
                    if (rowView["NM_MI"].ToString() != "")
                    {
                        DataItem += rowView["NM_MI"].ToString() + ",";
                    }

                    if (rowView["NM_MI"].ToString() != "")
                    {
                        DataItem += rowView["NM_MI"].ToString() + ",";
                    }

                    if (rowView["CT"].ToString() != "")
                    {
                        DataItem += rowView["CT"].ToString() + ",";
                    }

                    if (rowView["MR"].ToString() != "")
                    {
                        DataItem += rowView["MR"].ToString() + ",";
                    }

                    if (rowView["US"].ToString() != "")
                    {
                        DataItem += rowView["US"].ToString() + ",";
                    }

                    if (rowView["PET"].ToString() != "")
                    {
                        DataItem += rowView["PET"].ToString() + ",";
                    }

                    if (rowView["MM"].ToString() != "")
                    {
                        DataItem += rowView["MM"].ToString() + ",";
                    }

                    if (DataItem != "")
                    {
                        DataItem = "";
                        // DataItem = DataItem.Substring(0, DataItem.Length - 1).Trim();
                        sublist.Add(DataItem);

                    }
                    else
                    {
                        DataItem = "";
                        sublist.Add(DataItem);
                    }
                }
                else
                {

                    if (rowView["CARD"].ToString() != "")
                    {
                        DataItem += rowView["CARD"].ToString() + ",";
                    }

                    if (rowView["EMER"].ToString() != "")
                    {
                        DataItem += rowView["EMER"].ToString() + ",";
                    }

                    if (rowView["NEUR"].ToString() != "")
                    {
                        DataItem += rowView["NEUR"].ToString() + ",";
                    }

                    if (rowView["ORTH"].ToString() != "")
                    {
                        DataItem += rowView["ORTH"].ToString() + ",";
                    }

                    if (rowView["ONCO"].ToString() != "")
                    {
                        DataItem += rowView["ONCO"].ToString() + ",";
                    }

                    if (rowView["VASC"].ToString() != "")
                    {
                        DataItem += rowView["VASC"].ToString() + ",";
                    }


                    if (DataItem != "")
                    {
                        DataItem = "";
                        //DataItem = DataItem.Substring(0, DataItem.Length - 1).Trim();
                        sublist.Add(DataItem);

                    }
                    else
                    {
                        DataItem = "";
                        sublist.Add(DataItem);
                    }

                    //switch (Item_Name)
                    //{
                    //    case "CARD":
                    //    case "EMER":
                    //    case "NEUR":
                    //    case "ORTH":
                    //    case "ONCO":
                    //    case "VASC":
                    //        if (Item_Description != "")
                    //        {
                    //            sublist.Add(Item_Description);
                    //        }
                    //        break;

                    //}
                }


            }






        }
        catch { }

        return sublist;

    }


    private DataView GetDataAndFilter()
    {
        DataView MyDV = null;
        Dictionary<int, int> listToDelete = new Dictionary<int, int>();
        string Type = "";
        string sItemsSelected = "";
        string sAppNameSelected = "";

        string sItemsCompSelected = "";

        string sItemClinical = string.Empty;
        string sItemModality = string.Empty;
        string sComp = string.Empty;
        string Comp_Split = string.Empty;
        int SearchType = 0;

        try
        {


            //Type of search
            if (chkwithCompMatch.Checked == true)
            {
                SearchType = 1;
            }

            if (chkwithNOCompMatch.Checked == true)
            {
                SearchType = 2;
            }

            if (chkwithNOCompMatch.Checked & chkwithCompMatch.Checked)
            {
                SearchType = 3;
            }

            //Competitor
            #region Competitor
            foreach (ListItem li in chkboxComp.Items)
            {
                if (li.Selected)
                {
                    sComp = li.Text;
                    if (sComp == "GE Healthcare")
                    {
                        sComp = "GE";
                    }

                    if (sComp == "Siemens Medical")
                    {
                        sComp = "Siemens";
                    }

                    if (sComp != "Philips")
                    {
                        Comp_Split += sComp + ",";
                    }
                    sItemsCompSelected += "'" + sComp + "',";
                }
            }


            if (sItemsCompSelected != "")
            {
                sItemsCompSelected = sItemsCompSelected.Substring(0, sItemsCompSelected.Length - 1);
            }

            //if (SearchType == 1)
            //{
            if (!sItemsCompSelected.Contains("Philips"))
            {
                if (sItemsCompSelected != "")
                {
                    sItemsCompSelected += ",'Philips'";
                }
            }
            //}


            if (Comp_Split != "")
            {
                Comp_Split = Comp_Split.Substring(0, Comp_Split.Length - 1);
            }

            #endregion
            //Competitor



            //Clinical
            #region Clinical
            foreach (ListItem li in chkClinical.Items)
            {
                if (li.Selected)
                {
                    // sItemClinical += "'" + li.Text + "',";

                    if (sItemClinical != "")
                    {
                        sItemClinical = sItemClinical + " AND";
                    }

                    switch (li.Text)
                    {
                        case "CARD":
                            sItemClinical += " (CARD = 'CARD')";
                            break;
                        case "EMER":
                            sItemClinical += " (EMER = 'EMER')";
                            break;
                        case "NEURO":
                            sItemClinical += " (NEUR = 'NEURO')";
                            break;
                        case "ORTH":
                            sItemClinical += " (ORTH = 'ORTH')";
                            break;
                        case "ONCO":
                            sItemClinical += " (ONCO = 'ONCO')";
                            break;

                    }

                }
            }

            #endregion
            //Clinical


            //Modality
            #region Modality
            foreach (ListItem li in chkModality.Items)
            {
                if (li.Selected)
                {
                    // sItemClinical += "'" + li.Text + "',";

                    if (sItemModality != "")
                    {
                        sItemModality = sItemModality + " OR ";
                    }

                    switch (li.Text)
                    {
                        case "CT":
                            sItemModality += " (CT = 'CT')";
                            break;
                        case "MR":
                            sItemModality += " (MR = 'MR')";
                            break;
                        case "MM":
                            sItemModality += " (MM = 'MM')";
                            break;
                        case "NM/MI":
                            sItemModality += " (NM_MI = 'NM_MI')";
                            break;
                        case "PET":
                            sItemModality += " (PET = 'PET')";
                            break;
                        case "US":
                            sItemModality += " (US = 'US')";
                            break;

                    }

                }
            }

            #endregion
            //Modality



            //AppName
            #region AppName       
            string sMyActualApp = string.Empty;
            if (Request.Form != null)
            {
                if (Request.Form.Count > 0)
                {
                    string MyAppName = Request.Form["selected_elements"];
                    if (MyAppName != "")
                    {
                        MyAppName = DecodeClinical(MyAppName);

                        string[] Items = MyAppName.Split(',');
                        //string[] Elements = MyAppName.Split(',');

                        foreach (string EachItem in Items)
                        {
                            string[] Elements = EachItem.Split(':');
                            sMyActualApp += "'" + Elements[Elements.Length - 1] + "'" + ",";
                        }

                        if (sMyActualApp != "")
                        {
                            sMyActualApp = sMyActualApp.Substring(0, sMyActualApp.Length - 1);
                        }

                        string sqlapp = "SELECT ClinicalID, ACTUALAPP ,Competitor FROM PhilipsAnalysisClinicalData where ACTUALAPP in (" + sMyActualApp + ")";
                        DataView MyDVApp = Helper.GetData(sqlapp);

                        if (MyDVApp.Count > 0)
                        {
                            foreach (DataRowView rowView in MyDVApp)
                            {
                                sAppNameSelected += "'" + rowView["ACTUALAPP"].ToString() + "',";
                            }

                            if (sAppNameSelected != "")
                            {
                                sAppNameSelected = sAppNameSelected.Substring(0, sAppNameSelected.Length - 1);
                            }
                        }
                    }

                }


            }


            //if (cmdAppName.Value!="")
            //{
            //    sAppNameSelected = "'" + cmdAppName.Value + "'";
            //}            
            #endregion
            //AppName

            string SQL = string.Empty;
            if (sItemsCompSelected == "")
            {
                SQL = "SELECT * FROM PhilipsAnalysisClinicalData WHERE(Approved = 1) ";
            }
            else
            {
                SQL = "SELECT * FROM PhilipsAnalysisClinicalData WHERE(Approved = 1) AND Competitor in(" + sItemsCompSelected + ")";
            }


            if (sAppNameSelected != "")
            {
                switch(SearchType)
                {
                    case 0:
                        SQL += " AND ACTUALAPP in (" + sAppNameSelected + ")";
                        break;
                    default:
                        SQL += " AND PHILIPSMatchingAPP in (" + sAppNameSelected + ")";
                        break;
                }
                
            }

            if (sItemClinical != "")
            {
                SQL += " AND" + sItemClinical;
            }

            if (sItemModality != "")
            {
                if (SQL.Substring(SQL.Length - 3) == "AND")
                {
                    SQL += " " + sItemModality;
                }
                else
                {
                    SQL += " AND " + sItemModality;
                }

            }



            switch (SearchType)
            {
                case 3:
                case 1:
                    SQL += " AND (NOT (PHILIPSMatchingAPP = '')) ORDER BY PHILIPSMatchingAPP, CompetitorSortOrder";
                    break;
                case 2:
                    SQL += " ORDER BY CompetitorSortOrder";



                    break;
            }

            MyDV = Helper.GetData(SQL);


            if (SearchType == 1)
            {
                if (Comp_Split != "")
                {
                    string[] compList = Comp_Split.Split(',');
                    MyDV = PerformSearchType1(MyDV, compList);
                }
            }



            if (SearchType == 2)
            {
                if (Comp_Split != "")
                {
                    //string[] compList = Comp_Split.Split(',');
                    //MyDV = PerformSearchType2(MyDV, compList);

                    //MyDV.RowFilter = "Competitor in(" + sItemsCompSelected + ")";

                    MyDV = PerformSearchType2NoComp(MyDV);
                    MyDV.RowFilter = "Competitor in(" + sItemsCompSelected.Replace("'Philips',", "").Replace(",'Philips'", "") + ")";

                }
                else
                {
                    MyDV = PerformSearchType2NoComp(MyDV);

                    if (sItemsCompSelected == "'Philips'")
                    {
                        MyDV.RowFilter = "Competitor NOT in(" + sItemsCompSelected.Replace("'Philips',", "").Replace(",'Philips'", "") + ")";
                    }
                }
            }


            if (SearchType == 3)
            {
                if (Comp_Split != "")
                {
                    string[] compList = Comp_Split.Split(',');
                    DataView DVType1 = PerformSearchType1(MyDV, compList);
                    DataView DVType2 = PerformSearchType2(MyDV, compList);

                    DVType1.Table.Merge(DVType2.Table);

                    MyDV = DVType1;
                }
            }


        }
        catch { }

        Session["DataStore"] = MyDV.ToTable();

        return MyDV;
    }


    private string DecodeClinical(string myClinical)
    {
        string myItem = string.Empty;

        try
        {
            //"<li value='" + myValue.Replace(":", "1").Replace("/", "2") + "3" + rowView["ACTUALAPP"].ToString().Replace("*", "4").Replace("(", "5").Replace(")", "6").Replace(".", "7").Replace("&", "8").Replace("/", "9").Replace(";", "_") + "'> 

            if (myClinical != "")
            {
                myItem = myClinical.Replace("----", "/").Replace("---", ":").Replace("-", ":").Replace("+", "*").Replace("5", "(").Replace("6", ")").Replace("7", ".").Replace("8", "&").Replace("_", ";");
            }

        }
        catch { }

        return myItem;
    }
    private DataView PerformSearchType2(DataView MyDVMain, string[] compList)
    {

        DataView MyDV = null;

        try
        {

            MyDV = MyDVMain.Table.Copy().DefaultView;

            Dictionary<string, string> PhilipsCollection2 = new Dictionary<string, string>();

            //Get all the philips apps
            foreach (DataRowView rowView in MyDV)
            {
                try
                {
                    PhilipsCollection2.Add(rowView["Competitor"].ToString() + "@" + rowView["PHILIPSMatchingAPP"].ToString(), rowView["PHILIPSMatchingAPP"].ToString());
                }
                catch
                {

                }
            }



            // string[] compList = Comp_Split.Split(',');
            List<int> ClinicalIDList = new List<int>();

            foreach (DataRowView rowView2 in MyDV)
            {
                string ClinicalID = rowView2["ClinicalID"].ToString();
                string comp = rowView2["Competitor"].ToString();
                string app = rowView2["PHILIPSMatchingAPP"].ToString();
                bool HasData = false;



                foreach (string itemComp in compList)
                {
                    if (PhilipsCollection2.ContainsKey(itemComp + "@" + app))
                    {
                        if (PhilipsCollection2.ContainsKey("Philips" + "@" + app))
                        {
                            HasData = true;
                        }
                    }
                    else
                    {

                    }

                }




                if (HasData == true)
                {
                    ClinicalIDList.Add(Convert.ToInt32(ClinicalID));
                }

            }


            //Cleanup
            string xsd = "";

            foreach (int RemoveItems in ClinicalIDList)
            {
                foreach (DataRowView rowView3 in MyDV)
                {
                    string ClinicalID = rowView3["ClinicalID"].ToString();
                    if (RemoveItems.ToString() == ClinicalID)
                    {
                        rowView3.Delete();
                    }

                }


            }
        }
        catch { }

        return MyDV;
    }

    private DataView PerformSearchType2NoComp(DataView MyDVMain)
    {

        DataView MyDV = null;

        try
        {

            MyDV = MyDVMain.Table.Copy().DefaultView;

            Dictionary<string, string> PhilipsCollection2 = new Dictionary<string, string>();
            Dictionary<string, string> MatchingApps = new Dictionary<string, string>();

            //Get all the philips apps
            foreach (DataRowView rowView in MyDV)
            {
                try
                {
                    if (rowView["Competitor"].ToString() == "Philips")
                    {
                        PhilipsCollection2.Add(rowView["PHILIPSMatchingAPP"].ToString(), rowView["PHILIPSMatchingAPP"].ToString());
                    }
                }
                catch
                {

                }
            }

            List<int> ClinicalIDList = new List<int>();

            foreach (DataRowView rowView2 in MyDV)
            {
                string ClinicalID = rowView2["ClinicalID"].ToString();
                string comp = rowView2["Competitor"].ToString();
                string app = rowView2["PHILIPSMatchingAPP"].ToString();
                bool RemoveData = false;

                if (rowView2["Competitor"].ToString() != "Philips")
                {
                    if (PhilipsCollection2.ContainsValue(rowView2["PHILIPSMatchingAPP"].ToString()))
                    {
                        RemoveData = true;
                        try
                        {
                            MatchingApps.Add(rowView2["PHILIPSMatchingAPP"].ToString(), rowView2["PHILIPSMatchingAPP"].ToString());
                        }
                        catch { }
                    }
                    else
                    {
                        if (rowView2["PHILIPSMatchingAPP"].ToString().Contains(":"))
                        {
                            string[] oItems = rowView2["PHILIPSMatchingAPP"].ToString().Split(new[] { ":*" }, StringSplitOptions.None);

                            foreach (string splitItem in oItems)
                            {
                                if (PhilipsCollection2.ContainsValue(splitItem))
                                {
                                    RemoveData = true;
                                    try
                                    {
                                        MatchingApps.Add(rowView2["PHILIPSMatchingAPP"].ToString(), rowView2["PHILIPSMatchingAPP"].ToString());
                                    }
                                    catch { }
                                }

                            }

                        }

                    }
                }
                else
                {
                    //RemoveData = true;
                }


                if (RemoveData == true)
                {
                    ClinicalIDList.Add(Convert.ToInt32(ClinicalID));
                }

            }


            //Cleanup
            string xsd = "";

            foreach (int RemoveItems in ClinicalIDList)
            {
                foreach (DataRowView rowView3 in MyDV)
                {
                    string ClinicalID = rowView3["ClinicalID"].ToString();
                    if (RemoveItems.ToString() == ClinicalID)
                    {
                        rowView3.Delete();
                    }

                }


            }

            //Now remove the philips that are matching
            //foreach (int RemoveItemPs in MatchingApps)
            foreach (DataRowView rowView4 in MyDV)
            {
                string PHMatching = rowView4["PHILIPSMatchingAPP"].ToString();
                if (MatchingApps.ContainsValue(PHMatching))
                {
                    rowView4.Delete();
                }

            }



        }
        catch (Exception ex)
        {

        }

        return MyDV;
    }

    private DataView PerformSearchType1(DataView MyDVMain, string[] compList)
    {

        DataView MyDV = null;

        try
        {


            MyDV = MyDVMain.Table.Copy().DefaultView;

            Dictionary<string, string> PhilipsCollection1 = new Dictionary<string, string>();
            //List<string> PhilipsCollection2 = new List<string>();

            //Get all the philips apps
            foreach (DataRowView rowView in MyDV)
            {
                try
                {
                    PhilipsCollection1.Add(rowView["Competitor"].ToString() + "@" + rowView["PHILIPSMatchingAPP"].ToString(), rowView["PHILIPSMatchingAPP"].ToString());
                }
                catch
                {

                }

            }


            List<int> ClinicalIDList = new List<int>();

            foreach (DataRowView rowView2 in MyDV)
            {
                string ClinicalID = rowView2["ClinicalID"].ToString();
                string comp = rowView2["Competitor"].ToString();
                string app = rowView2["PHILIPSMatchingAPP"].ToString();
                bool HasData = false;



                foreach (string itemComp in compList)
                {
                    if (PhilipsCollection1.ContainsKey(itemComp + "@" + app))
                    {
                        if (PhilipsCollection1.ContainsKey("Philips" + "@" + app))
                        {
                            HasData = true;
                        }
                    }
                    else
                    {

                    }

                }




                if (HasData == false)
                {
                    ClinicalIDList.Add(Convert.ToInt32(ClinicalID));
                }

            }


            //Cleanup
            string xsd = "";

            foreach (int RemoveItems in ClinicalIDList)
            {
                foreach (DataRowView rowView3 in MyDV)
                {
                    string ClinicalID = rowView3["ClinicalID"].ToString();
                    if (RemoveItems.ToString() == ClinicalID)
                    {
                        rowView3.Delete();
                    }

                }
            }

            /////
            //Remove all items not selected
            foreach (DataRowView rowView4 in MyDV)
            {
                if (!compList.Contains(rowView4["Competitor"].ToString()))
                {
                    if (rowView4["Competitor"].ToString() != "Philips")
                    {
                        rowView4.Delete();
                    }
                }
            }
            ///

        }
        catch { }

        return MyDV;
    }

    public string GetClinicalData()
    {
        string myData = string.Empty;
        string myCompetitor = string.Empty;
        try
        {

            string SQLApp = "SELECT ClinicalID, ACTUALAPP ,Competitor,CT,MR,MM,PET,US,NM_MI FROM PhilipsAnalysisClinicalData where Approved =1";
            DataView MyDVApp = Helper.GetData(SQLApp);


            //this.cmdAppName.DataSource = MyDVApp;

            foreach (DataRowView rowView in MyDVApp)
            {
                if (rowView["Competitor"].ToString() != "")
                {
                    //<li value="eur">Europe</li>

                    string myValue = "";
                    myValue = rowView["ClinicalID"].ToString();
                    myCompetitor = rowView["Competitor"].ToString();

                    if (rowView["Competitor"].ToString() != "")
                    {
                        myValue = ":" + rowView["Competitor"].ToString();
                    }

                    if (rowView["CT"].ToString() != "")
                    {
                        myValue = myValue + ":CT";
                    }

                    if (rowView["MR"].ToString() != "")
                    {
                        myValue = myValue + ":MR";
                    }

                    if (rowView["MM"].ToString() != "")
                    {
                        myValue = myValue + ":MM";
                    }

                    if (rowView["NM_MI"].ToString() != "")
                    {
                        myValue = myValue + ":NM_MI";
                    }
                    if (rowView["PET"].ToString() != "")
                    {
                        myValue = myValue + ":PET";
                    }


                    if (rowView["US"].ToString() != "")
                    {
                        myValue = myValue + ":US";
                    }

                    if (rowView["ACTUALAPP"].ToString()== "Syngo.CT – PE CAD")
                    {
                        string xx = "";
                    }

                    myData += "<li value='" + myValue.Replace(":", "---").Replace("/", "----") + "-" + rowView["ACTUALAPP"].ToString().Replace("*", "+").Replace("(", "5").Replace(")", "6").Replace(".", "7").Replace("&", "8").Replace("/", "9").Replace(";", "_") + "'> " + rowView["ACTUALAPP"].ToString() + "</li>";
                    //;

                    //        //chkboxAppName.Items.Add(new ListItem(rowView["ACTUALAPP"].ToString() + "|" + rowView["Competitor"].ToString()));
                }
            }
            //

        }
        catch { }

        return myData;
    }

    private void BindDataSource()
    {
        int code = 10000;



        DataView MyDV = GetDataAndFilter();

        code++;
        order.Add(new Orders(code, "Competitor", MyDV, "Competitor"));
        code++;
        order.Add(new Orders(code, "Application", MyDV, "ACTUALAPP"));
        code++;
        order.Add(new Orders(code, "Philips Matching Application", MyDV, "PHILIPSMatchingAPP"));
        code++;
        order.Add(new Orders(code, "Clinical Domain", MyDV, "Clinical"));
        code++;
        order.Add(new Orders(code, "Modality", MyDV, "Modality"));
        code++;
        order.Add(new Orders(code, "510K", MyDV, "510K"));
        code++;
        order.Add(new Orders(code, "Intend to Use", MyDV, "Overview"));
        code++;

        order.Add(new Orders(code, "Features and Capabilities", MyDV, "FEATURE"));
        code++;



        order.Add(new Orders(code, "Application Weaknesses", MyDV, "Application_Weaknesses"));
        code++;
        order.Add(new Orders(code, "Application Strengths", MyDV, "Application_Strengths"));
        code++;
        order.Add(new Orders(code, "Competitive Argumentation", MyDV, "Competitive_Argumentation"));
        code++;



        List<Column> col = new List<Column>();


        col.Add(new Column() { Field = "OrderID", IsPrimaryKey = true, Visible = false, HeaderText = "OrderID", Width = 180, });
        col.Add(new Column() { Field = "ColumnName", HeaderText = "", Width = 200, });

        int idx = 0;
        foreach (DataRowView rowView in MyDV)
        {
            col.Add(new Column() { Field = "DataRowElement." + idx, HeaderText = "", Width = 180, });
            idx++;
        }

        try
        {
            int icount = col.Count;
            icount = icount - 2;
            m_AppCount = icount.ToString();
        }
        catch { }

        Session["CellEditDataSource"] = order;

        this.Grid1.DataSource = order;
        this.Grid1.Model.Columns = col;
        this.Grid1.DataBind();
    }

    private void SetupBoxes()
    {


        try
        {


            string SQL = "SELECT distinct Competitor FROM PhilipsAnalysisClinicalData where Approved =1 order by Competitor";
            DataView MyDV = Helper.GetData(SQL);

            //
            DataTable EditTable = new DataTable("Competitor");
            EditTable = MyDV.ToTable();

            DataColumn workCol = EditTable.Columns.Add("Order", typeof(Int32));
            workCol.DefaultValue = 0;

            foreach (DataRow row in EditTable.Rows)
            {
                row["Order"] = 9;

                switch (row["Competitor"].ToString().ToUpper())
                {
                    case "PHILIPS":
                        row["Order"] = 1;
                        break;
                    case "GE":
                        row["Order"] = 2;
                        break;
                    case "SIEMENS":
                        row["Order"] = 3;
                        break;
                    case "VITAL -TOSHIBA":
                        row["Order"] = 4;
                        break;
                    case "TERARECON":
                        row["Order"] = 5;
                        break;
                }

            }

            MyDV = new DataView(EditTable);

            MyDV.Sort = "Order ASC";


            foreach (DataRowView rowView in MyDV)
            {
                if (rowView["Competitor"].ToString() != "")
                {
                    switch (rowView["Competitor"].ToString())
                    {
                        case "GE":
                            chkboxComp.Items.Add(new ListItem("GE Healthcare"));
                            break;
                        case "Siemens":
                            chkboxComp.Items.Add(new ListItem("Siemens Medical"));
                            break;
                        default:
                            chkboxComp.Items.Add(new ListItem(rowView["Competitor"].ToString()));
                            break;
                    }


                }
            }


            //add style colour

            foreach (ListItem li in chkboxComp.Items)
            {

                switch (li.Text.ToString().ToUpper())
                {
                    case "PHILIPS":
                        li.Attributes.Add("style", "color:#0b5ed7;");
                        break;
                    case "TERARECON":
                        li.Attributes.Add("style", "color:#000;");
                        break;
                    case "SIEMENS MEDICAL":
                        li.Attributes.Add("style", "color:#f7931e;");
                        break;
                    case "GE HEALTHCARE":
                        li.Attributes.Add("style", "color:##0560ab;");
                        break;
                    case "CANNON":
                        li.Attributes.Add("style", "color:#c1272d;");
                        break;
                    case "AGFA":
                        li.Attributes.Add("style", "color:#6e6e6e;");
                        break;
                }


            }



            chkModality.Items.Add(new ListItem("CT"));
            chkModality.Items.Add(new ListItem("MR"));
            chkModality.Items.Add(new ListItem("MM"));
            chkModality.Items.Add(new ListItem("NM/MI"));
            chkModality.Items.Add(new ListItem("PET"));
            chkModality.Items.Add(new ListItem("US"));

            chkClinical.Items.Add(new ListItem("CARD"));
            chkClinical.Items.Add(new ListItem("EMER"));
            chkClinical.Items.Add(new ListItem("NEURO"));
            chkClinical.Items.Add(new ListItem("ORTH"));
            chkClinical.Items.Add(new ListItem("ONCO"));
            chkClinical.Items.Add(new ListItem("VASC"));

            chkwithCompMatch.Checked = true;
            chkwithNOCompMatch.Checked = false;

            //foreach (ListItem li in chkClinical.Items)
            //{
            //    li.Selected = true;
            //}

            //foreach (ListItem li in chkModality.Items)
            //{
            //    li.Selected = true;
            //}




        }
        catch { }
    }


    private void DataSetUp()
    {
        try
        {

        }
        catch { }
    }
    private void ShowData()
    {
        try
        {

            BindDataSource();

            this.Grid1.ToolbarSettings.ShowToolbar = false;
            this.Grid1.EditSettings.AllowEditing = false;
        }
        catch { }
    }

    protected void cmdSubmit_Click(object sender, EventArgs e)
    {
        try
        {

            ShowData();


            string MyAppName = Request.Form["selected_elements"];
            if (MyAppName != "")
            {

                string[] Items = MyAppName.Split(',');


                foreach (string EachItem in Items)
                {
                    //string[] Elements = EachItem.Split(':');
                    //sMyActualApp += "'" + Elements[3] + "'" + ",";
                    m_JavascriptClinical += "$('#list').multiList('select','" + EachItem.Trim() + "'); ";

                }
            }


        }
        catch { }
    }


    private void ExportData()
    {
        try
        {


            string SQLApp = "SELECT * FROM [PhilipsAnalysisClinicalData]";
            DataView MyDVApp = Helper.GetData(SQLApp);



            foreach (DataRowView rowView in MyDVApp)
            {



            }


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
                    m_UserID = Session["UserID"].ToString();
                    m_UserType = Session["Clinical"].ToString();
                    Signin = true;

                }

            }

            try
            {
                string EmailName = Request.Headers["Federation-UserPrincipalName"].ToString();
                Helper.InsertTracking(m_UserID, "Clinical", EmailName);
            }
            catch
            {

                Helper.InsertTracking(m_UserID, "Clinical", "");
            }


            if (Signin == true)
            {


            }
            else
            {
                Response.Redirect("/Account/Signin");
            }



            if (!IsPostBack)
            {
                SetupBoxes();
                chkboxComp.SelectedValue = "Philips";

                ShowData();
            }

        }
        catch { }
    }


}