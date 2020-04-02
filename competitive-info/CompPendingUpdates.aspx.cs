using System;
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

                string sSQL = "SELECT PendingID, PhilipsID, PhilipsMatrixDataID, UserName, UpdateTime FROM PhilipsMatrixData_PendingUpdates WHERE(PhilipsMatrixDataID = "+ MyData.ToString() + ")";
                DataView MyDV = Helper.GetData(sSQL);

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

            string MyMenuMatrix = "<li><a href='Competitors'>Competitors</a></li>";
            

            if (Session["Competitors"] == null)
            {
                Response.Redirect("/Account/Signin");
            }

            switch (Session["Competitors"].ToString())
            {
                case "Super Admin":
                case "ADMIN":
                    MyMenu = MyMenuMatrix;// + MyMenuEdit + MyMenuApprove;
                    break;

                case "Editor":
                case "EDIT":
                    MyMenu = MyMenuMatrix;// + MyMenuEdit;
                    break;

                case "Viewer":
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
            DataView DVPendingDetails = Helper.GetData(PendingDetails);

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
            DataView DVCurrent = Helper.GetData(SQL);

            foreach (DataRowView rowView in DVCurrent)
            {


               
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
            
            string SQL = "select * from PhilipsAnalysisCompetitorsData_PendingUpdates WHERE Status IN (1,4) ORDER BY PhilipsAnalysisCompetitorsPendingUpdatesID DESC";            
            DataView MyDV = Helper.GetData(SQL);          

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

    
 
   

    private bool PageSetupByDB(string FavListID)
    {
        bool SetUpFromDB = false;

        try
        {


            if (FavListID != "")
            {
                DataView MyFilter = Helper.GetData("select * from PhilipsMatrixFilter where FilterID=" + FavListID);
                string sJSONFilterSetUp = string.Empty;

                foreach (DataRowView rowViewFilter in MyFilter)
                {
                    SetUpFromDB = true;
                    sJSONFilterSetUp = rowViewFilter["JSONFilterSetUp"].ToString();
                    break;
                }

                if (sJSONFilterSetUp != "")
                {
                    m_filtersearchO = JsonConvert.DeserializeObject<FilterSearch>(sJSONFilterSetUp);

                    #region Modality
                    for (int Modalityidx = 0; Modalityidx < m_filtersearchO.Modality.Count; Modalityidx++)
                    {
                        
                    }
                    #endregion

                    #region Vendor
                    for (int Vendoridx = 0; Vendoridx < m_filtersearchO.Vendor.Count; Vendoridx++)
                    {
                       
                    }
                    #endregion











                }


            }

        }
        catch { }

        return SetUpFromDB;
    }

    private void PageSetUp()
    {
        string FavListID = string.Empty;
        bool SetUpFromDB = false;

        try
        {


            if (!IsPostBack)
            {

               
                if (SetUpFromDB == false)
                {
                    
                   
                }

                  

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

    protected void lnkFavRemoveYes_Click(object sender, EventArgs e)
    {
        string FavListID = string.Empty;

        try
        {


            if (Request.QueryString["FavListID"] != null)
            {
                if (Request.QueryString["FavListID"].ToString() != "")
                {
                    if (Request.QueryString["FavListID"].ToString() != "")
                    {
                        FavListID = Request.QueryString["FavListID"].ToString();

                        Helper.InsertData("DELETE FROM PhilipsMatrixFilter WHERE(FilterID = " + FavListID + ")");


                        //panFeedBack.Visible = false;
                        Response.Redirect("/");

                    }
                }
            }


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
                    string SQLPending = "update PhilipsAnalysisCompetitorsData_PendingUpdates set Status='3' where  PhilipsAnalysisCompetitorsPendingUpdatesID=" + HF_PhilipsPendingID.Value;
                    Helper.InsertData(SQLPending);                    
                }
                
            }

            SetupGrid();


        }
        catch { }
    }

   




    private void ApproveData(string PendingID, RepeaterItem item)
    {
        try {

            if (PendingID != "")
            {
                string sSQL = "select * FROM PhilipsAnalysisCompetitorsData_PendingUpdates where PhilipsAnalysisCompetitorsPendingUpdatesID=" + PendingID;
                DataView mDV = Helper.GetData(sSQL);

                foreach (DataRowView rowView in mDV)
                {
                                        
                    string NewDataUpdate = rowView["NewDataUpdate"].ToString();
                    string OldData = rowView["OldData"].ToString();
                    string UpdateColumnName = rowView["UpdateColumnName"].ToString().Replace(" ", "_"); 
                    string Type = rowView["Type"].ToString();

                    switch(Type)
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
                        string SQL1 = "UPDATE  PhilipsAnalysisCompetitorsData SET " + UpdateColumnName + " = '" + DecodeTrafficString(txtNew.Text) + "',  Comment = '" + txtNotes.Text + "' WHERE(Name = '" + Type + "')";
                        Helper.InsertData(SQL1);
                    }
                    else
                    {
                        string SQL1 = "UPDATE PhilipsAnalysisCompetitorsData SET " + UpdateColumnName + " = '" + txtNew.Text + "',  Comment = '" + txtNotes.Text + "' WHERE(Name = '" + Type + "')";
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
                string sSQL = "select * FROM PhilipsAnalysisCompetitorsData_PendingUpdates where PhilipsAnalysisCompetitorsPendingUpdatesID=" + PendingID;
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

                    string SQL1 = "UPDATE PhilipsAnalysisCompetitorsData_PendingUpdates  SET NewDataUpdate = '" + txtNew.Text + "', OldData = '" + txtCurrent.Text + "', Comment = '"+ txtNotes.Text + "', Status = 4, UpdateTime = '"+ MyTime + "',UserID = '" + Session["UserID"] + "', UserName = '" + Session["User"] + "' WHERE  (PhilipsAnalysisCompetitorsPendingUpdatesID = "+ PendingID + ")";
                                                
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

                    string SQLPending = "UPDATE PhilipsAnalysisCompetitorsData_PendingUpdates SET Status = 2 WHERE(PhilipsAnalysisCompetitorsPendingUpdatesID = " + HF_PhilipsPendingID.Value + ")";
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
                UpdateData(HF_PhilipsPendingID.Value, item);                
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
            }else
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

                


                HF_HF_PhilipsPendingID.Value= drv.Row["PhilipsAnalysisCompetitorsPendingUpdatesID"].ToString();

                if (drv.Row["UpdateColumnName"].ToString().Contains("_chk"))
                {
                    //traffic lights


                    txtNew.Text = GetTrafficString(drv.Row["NewDataUpdate"].ToString());
                    txtCurrent.Text=GetTrafficString(drv.Row["OldData"].ToString());

                    lblcolumnName.Text = drv.Row["UpdateColumnName"].ToString().Replace("_chk","") + ", " + drv.Row["Type"].ToString();
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
               
                if (Session["Competitors"] != null)
                {
                    if (Session["Competitors"].ToString() != "Super Admin")
                    {
                        Response.Redirect("/Account/Signin");
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