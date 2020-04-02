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

                string sSQL = "SELECT PendingID, PhilipsID, PhilipsMatrixDataID, UserName, UpdateTime FROM PhilipsMatrixData_PendingUpdates WHERE(PhilipsMatrixDataID = " + MyData.ToString() + ")";
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

            string MyMenuMatrix = "<li><a href='/'>MV Matrix</a></li>";
            string MyMenuEdit = "<li><a href='/admin/EditGridData'>MV Edit</a></li>";
            string MyMenuApprove = "<li><a href='/admin/PendingUpdates'>MV Approve</a></li>";

            string MyMenuEditData = "<li><a href='/admin/MVMatrix-Edit.aspx'>MV Manage Data</a></li>";
            string MyMenuCopyData = "<li><a href='/admin/MVMatrix-CopyData'>MV Copy Data</a></li>";

            if (Session["UserType"] == null)
            {
                Response.Redirect("/Account/Signin");
            }

            switch (Session["MVMatrix"].ToString())
            {
                case "Super Admin":
                case "ADMIN":
                    MyMenu = MyMenuMatrix + MyMenuEdit + MyMenuApprove + MyMenuEditData + MyMenuCopyData;

                    break;
                case "Super Viewer":
                    MyMenu = MyMenuMatrix + MyMenuEdit + MyMenuApprove;
                    break;
                case "Content Admin":
                case "Editor":
                case "EDIT":
                    MyMenu = MyMenuMatrix + MyMenuEdit;
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


    protected void lnkFavSave_Click(object sender, EventArgs e)
    {
        string BuildFilterJSON = string.Empty;
        FilterSearch filtersearch = null;
        try
        {



            #region Setup Json File
            filtersearch = new FilterSearch
            {
                CreatedDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, DateTime.Now.Hour, DateTime.Now.Minute, DateTime.Now.Second, DateTimeKind.Utc),
                ISP = new List<string> { },
                Modality = new List<string> { },
                Vendor = new List<string> { },
                Model = new List<string> { },
                Software = new List<string> { },
                Domain = new List<string> { },
                Module = new List<string> { },
                DataSet = new List<string> { },
                ColumnSetUp = new List<string> { },
                FilterSetUp = new List<string> { }
            };
            #endregion

            //Modality//
            SetupModality();
            string[] Modalitys = m_BuildAppType.Split(',');
            foreach (string sModality in Modalitys)
            {
                filtersearch.Modality.Add(sModality.Replace("'", "").ToString());
            }
            //Modality//

            //Vendor//
            SetUpVendor();
            string[] Vendors = m_BuildVendor.Split(',');
            foreach (string sVendor in Vendors)
            {
                filtersearch.Vendor.Add(sVendor.Replace("'", "").ToString());
            }
            //Vendor//

            //Model//
            foreach (ListItem item in this.chkboxModel.Items)
            {
                if (item.Selected)
                {
                    filtersearch.Model.Add(item.Value);
                }
            }
            //Model//

            //Software//
            foreach (ListItem item in this.chkboxSoftware.Items)
            {
                if (item.Selected)
                {
                    filtersearch.Software.Add(item.Value);
                }
            }
            //Software//

            //Domain//
            foreach (ListItem item in this.chkboxDomain.Items)
            {
                if (item.Selected)
                {
                    filtersearch.Domain.Add(item.Value);
                }
            }
            //Domain//

            //Module//
            foreach (ListItem item in this.chkboxModule.Items)
            {
                if (item.Selected)
                {
                    filtersearch.Module.Add(item.Value);
                }
            }
            //Module//


            foreach (ListItem item in this.chkboxDefinition.Items)
            {
                if (item.Selected)
                {
                    filtersearch.DataSet.Add(item.Value);
                }
            }


            #region Column Setup

            if (chkISP.Checked == true)
            {
                filtersearch.ColumnSetUp.Add("ISP");
            }

            if (chkColVendor.Checked == true)
            {
                filtersearch.ColumnSetUp.Add("Vendor");
            }

            if (chkColDomain.Checked == true)
            {
                filtersearch.ColumnSetUp.Add("Domain");
            }

            if (chkColModality.Checked == true)
            {
                filtersearch.ColumnSetUp.Add("Modality");
            }

            if (chkColModel.Checked == true)
            {
                filtersearch.ColumnSetUp.Add("Model");
            }

            if (chkColModule.Checked == true)
            {
                filtersearch.ColumnSetUp.Add("Module");
            }

            if (chkColSoftware.Checked == true)
            {
                filtersearch.ColumnSetUp.Add("Software");
            }

            if (chkColDefinition.Checked == true)
            {
                filtersearch.ColumnSetUp.Add("Definition");
            }
            #endregion

            #region FilterSetUp



            #endregion

            string sUserID = Session["UserID"].ToString();


            //Get OrderID

            DataView MyOrder = Helper.GetData("SELECT OrderID FROM PhilipsMatrixFilter ORDER BY OrderID DESC");
            int MyOrderID = 0;
            foreach (DataRowView rowView in MyOrder)
            {
                MyOrderID = Convert.ToInt32(rowView["OrderID"].ToString());
                break;
            }

            MyOrderID++;
            ////



            //Serialize json
            string json = JsonConvert.SerializeObject(filtersearch, Formatting.Indented);

            //save data
            //Helper.InsertData("INSERT INTO PhilipsMatrixFilter(JSONFilterSetUp, FilterLabel,UserID,OrderID) VALUES('" + json + "', '" + txtFavLabel.Text + "','" + sUserID + "'," + MyOrderID + ")");


            SetUpFavList();


            //FilterSearch filtersearchO = JsonConvert.DeserializeObject<FilterSearch>(json);




        }
        catch //(Exception ex)
        { }
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

                if (model == "")
                {
                    //  model = rowView["Model"].ToString();
                }

            }


            //New Item

            HTMLBuilder += "<tr>";
            HTMLBuilder += "<td style='border-top:1px solid #ddd;' class='icon_div green g text-orange'>New</td>";
            HTMLBuilder += "<td class='text-orange'>" + vendor + "</td>";
            HTMLBuilder += "<td class=''>" + model + "</td>";
            HTMLBuilder += "<td class=''>" + software + "</td>";
            HTMLBuilder += "<td class=''>" + DataElement + "</td>";
            HTMLBuilder += "<td style='border-top:1px solid #ddd;'></td>";
            HTMLBuilder += "<td class=''style='border-top:1px solid #ddd;'>" + AppType + "</td>";
            HTMLBuilder += "<td class='text-orange'style='border-top:1px solid #ddd;'>" + Domain + "</td>";
            HTMLBuilder += "<td class=''style='border-top:1px solid #ddd;'>" + Module + "</td>";

            HTMLBuilder += "<td class=''style='border-top:1px solid #ddd;'>" + Definition + "</td>";
            HTMLBuilder += "</tr>";

            HTMLBuilder += "</table>";
            HTMLBuilder += "<div class='table-bottom-content'>";
            HTMLBuilder += "<p><strong>Edited by</strong> Author " + UserName + " on " + UserUpdateTime + " </p>";
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





    private void SetupModality()
    {
        try
        {


            if (chkCT.Checked == true)
            {
                if (m_BuildAppType != "")
                {
                    m_BuildAppType += ",'CT'";

                }
                else
                {
                    m_BuildAppType += "'CT'";
                }
            }

            if (chkMR.Checked == true)
            {
                if (m_BuildAppType != "")
                {
                    m_BuildAppType += ",'MR'";

                }
                else
                {
                    m_BuildAppType += "'MR'";
                }
            }

            if (chkMMV.Checked == true)
            {
                if (m_BuildAppType != "")
                {
                    m_BuildAppType += ",'MMV-US'";

                }
                else
                {
                    m_BuildAppType += "'MMV-US'";
                }
            }

            if (chkNMSpect.Checked == true)
            {
                if (m_BuildAppType != "")
                {
                    m_BuildAppType += ",'NM-SPECT'";

                }
                else
                {
                    m_BuildAppType += "'NM-SPECT'";
                }
            }

            if (chkNMPet.Checked == true)
            {
                if (m_BuildAppType != "")
                {
                    m_BuildAppType += ",'NM-PET'";

                }
                else
                {
                    m_BuildAppType += "'NM-PET'";
                }
            }



        }
        catch { }
    }

    private void SetUpVendor()
    {
        try
        {
            m_BuildVendor = "";


            if (chkGE.Checked == true)
            {
                if (m_BuildVendor != "")
                {

                    m_BuildVendor += ",'GE'";

                }
                else
                {
                    m_BuildVendor += "'GE'";
                }
            }

            if (chkSiemens.Checked == true)
            {
                if (m_BuildVendor != "")
                {
                    m_BuildVendor += ",'Siemens'";

                }
                else
                {
                    m_BuildVendor += "'Siemens'";
                }
            }

            if (chkToshiba.Checked == true)
            {
                if (m_BuildVendor != "")
                {
                    m_BuildVendor += ",'Toshiba'";
                }
                else
                {
                    m_BuildVendor += ",'Toshiba'";
                }
            }


        }
        catch { }
    }

    private void SetUpModel(int IsOnLoad)
    {
        try
        {

            //model
            //string sSelectedModel = string.Empty;
            //foreach (ListItem li in ListBoxModel.Items)
            //{
            //    if (li.Selected)
            //    {
            //        m_SelectedModel += li.Text + " , ";
            //    }
            //}

            foreach (ListItem item in this.chkboxModel.Items)
            {
                if (item.Selected)
                {
                    m_SelectedModel += item.Value + " , ";
                }
            }






            if (IsOnLoad == 1)
            {
                string SQL = "SELECT DISTINCT PhilipsMatrixData.Model,Vendor,AppType FROM PhilipsMatrix INNER JOIN PhilipsMatrixData ON PhilipsMatrix.PhilipsID = PhilipsMatrixData.PhilipsMatrixID order by Vendor,apptype";//  where apptype in(" + m_BuildAppType + ") ";
                //SQL += "and Vendor in(" + m_BuildVendor + ")";


                DataView MyDV = Helper.GetData(SQL);

                chkboxModel.Items.Clear();


                //int Idx = 0;
                //Idx = 1;
                foreach (DataRowView rowView in MyDV)
                {
                    if (rowView["Model"].ToString() != "")
                    {
                        chkboxModel.Items.Add(new ListItem(rowView["AppType"].ToString() + ": " + rowView["Model"].ToString(), rowView["Vendor"].ToString() + "|" + rowView["AppType"].ToString() + "|" + rowView["Model"].ToString()));
                    }
                }


                if (m_filtersearchO != null)
                {
                    for (int Modelidx = 0; Modelidx < m_filtersearchO.Model.Count; Modelidx++)
                    {

                        foreach (ListItem item in this.chkboxModel.Items)
                        {
                            if (m_filtersearchO.Model[Modelidx].ToString() == item.Value.Trim())
                            {
                                item.Selected = true;
                            }
                        }

                    }
                }

            }

        }


        catch { }
    }

    private void SetUpSoftware()
    {
        try
        {

            string SQL = "SELECT DISTINCT PhilipsMatrixData.Software,vendor,AppType FROM PhilipsMatrix INNER JOIN PhilipsMatrixData ON PhilipsMatrix.PhilipsID = PhilipsMatrixData.PhilipsMatrixID order by Vendor,apptype";
            DataView MyDV = Helper.GetData(SQL);

            foreach (DataRowView rowView in MyDV)
            {
                if (rowView["Software"].ToString() != "")
                {
                    chkboxSoftware.Items.Add(new ListItem(rowView["Vendor"].ToString() + ": " + rowView["Software"].ToString(), rowView["AppType"].ToString() + "|" + rowView["Vendor"].ToString() + "|" + rowView["Software"].ToString()));
                }
            }


            if (m_filtersearchO != null)
            {
                for (int Softwareidx = 0; Softwareidx < m_filtersearchO.Software.Count; Softwareidx++)
                {
                    foreach (ListItem item in this.chkboxSoftware.Items)
                    {
                        if (m_filtersearchO.Software[Softwareidx].ToString() == item.Value)
                        {
                            item.Selected = true;
                        }
                    }
                }
            }




        }
        catch { }
    }

    private void SetUpListDefinition()
    {
        try
        {

            string SQL = "SELECT DISTINCT Definition,AppType FROM PhilipsMatrix INNER JOIN PhilipsMatrixData ON PhilipsMatrix.PhilipsID = PhilipsMatrixData.PhilipsMatrixID WHERE(NOT(PhilipsMatrix.Definition = '')) ORDER BY PhilipsMatrix.AppType, PhilipsMatrix.Definition"; // where Vendor in(" + m_BuildVendor + ")";
            DataView MyDV = Helper.GetData(SQL);

            foreach (DataRowView rowView in MyDV)
            {
                if (rowView["Definition"].ToString() != "")
                {
                    chkboxDefinition.Items.Add(new ListItem(rowView["Definition"].ToString(), rowView["AppType"].ToString() + "|" + rowView["Definition"].ToString()));
                    //ListDefinition.Items.Add(new ListItem(rowView["Definition"].ToString(), rowView["AppType"].ToString() + "|" + rowView["Definition"].ToString()));
                }
            }

            if (m_filtersearchO != null)
            {
                for (int Definitionidx = 0; Definitionidx < m_filtersearchO.DataSet.Count; Definitionidx++)
                {
                    foreach (ListItem item in this.chkboxDefinition.Items)
                    {
                        if (m_filtersearchO.DataSet[Definitionidx].ToString() == item.Value.Trim())
                        {
                            item.Selected = true;
                        }
                    }
                }
            }



        }
        catch { }
    }

    private void SetUpDomain()
    {
        try
        {

            string SQL = "SELECT DISTINCT domain,AppType FROM PhilipsMatrix INNER JOIN PhilipsMatrixData ON PhilipsMatrix.PhilipsID = PhilipsMatrixData.PhilipsMatrixID order by AppType"; // where Vendor in(" + m_BuildVendor + ")";
            DataView MyDV = Helper.GetData(SQL);

            foreach (DataRowView rowView in MyDV)
            {
                if (rowView["Domain"].ToString() != "")
                {
                    chkboxDomain.Items.Add(new ListItem(rowView["AppType"].ToString() + ": " + rowView["Domain"].ToString(), rowView["AppType"].ToString() + "|" + rowView["Domain"].ToString()));
                }
            }


            if (m_filtersearchO != null)
            {
                for (int Domainidx = 0; Domainidx < m_filtersearchO.Domain.Count; Domainidx++)
                {
                    foreach (ListItem item in this.chkboxDomain.Items)
                    {
                        if (m_filtersearchO.Domain[Domainidx].ToString() == item.Value.Trim())
                        {
                            item.Selected = true;
                        }
                    }
                }
            }



        }
        catch { }
    }

    private void SetUpModule()
    {
        try
        {


            string SQL = "SELECT DISTINCT Module,AppType,Domain FROM PhilipsMatrix INNER JOIN PhilipsMatrixData ON PhilipsMatrix.PhilipsID = PhilipsMatrixData.PhilipsMatrixID "; //where Vendor in(" + BuildAppType + ")";
            DataView MyDV = Helper.GetData(SQL);

            foreach (DataRowView rowView in MyDV)
            {
                if (rowView["Module"].ToString() != "")
                {
                    chkboxModule.Items.Add(new ListItem(rowView["Module"].ToString(), rowView["AppType"].ToString() + "|" + rowView["Module"].ToString() + "|" + rowView["Domain"].ToString()));
                    //ListModule.Items.Add(new ListItem(rowView["Module"].ToString(), rowView["AppType"].ToString() + "|" + rowView["Module"].ToString()));
                }
            }


            if (m_filtersearchO != null)
            {
                for (int Moduleidx = 0; Moduleidx < m_filtersearchO.Module.Count; Moduleidx++)
                {
                    foreach (ListItem item in this.chkboxModule.Items)
                    {
                        if (m_filtersearchO.Module[Moduleidx].ToString() == item.Value.Trim())
                        {
                            item.Selected = true;
                        }
                    }
                }
            }



        }
        catch { }
    }

    private void SetUpColumnSelection()
    {
        try
        {
            chkISP.Checked = true;
            chkColVendor.Checked = true;
            chkColDomain.Checked = true;
            chkColModality.Checked = true;
            chkColModel.Checked = true;
            chkColModule.Checked = true;
            chkColSoftware.Checked = true;
            chkColVendor.Checked = true;
            chkColDefinition.Checked = true;




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
            #region PreSQL

            string sPreSQL = "SELECT  MAX(PendingID) AS PendingID, PhilipsID, PhilipsMatrixDataID FROM PhilipsMatrixData_PendingUpdates GROUP BY PhilipsID, PhilipsMatrixDataID";
            DataView MyDVPre = Helper.GetData(sPreSQL);


            foreach (DataRowView rowPre in MyDVPre)
            {
                sID += rowPre["PendingID"].ToString() + ",";
            }

            if (sID != "")
            {
                sID = sID.Substring(0, sID.Length - 1);

            }

            #endregion



            string SQL = "select * from PhilipsMatrixData_PendingUpdates WHERE PendingID in (" + sID + ") AND (NOT (Status IN (1, 2))) ORDER BY PendingID DESC";
            DataView MyDV = Helper.GetData(SQL);

            repDataGrid.DataSource = MyDV;
            repDataGrid.DataBind();

            int MyCount = 0; // MyDV.Count;

            foreach (RepeaterItem item in repDataGrid.Items)
            {

                System.Web.UI.WebControls.HiddenField HF_MatrixID = (System.Web.UI.WebControls.HiddenField)item.FindControl("HF_PhilipsMatrixDataID");

                System.Web.UI.WebControls.CheckBox HF_CheckBox = (System.Web.UI.WebControls.CheckBox)item.FindControl("chkIsSelected");


                //Get ID from Repeater
                //HF_MatrixID.Value
                if (HF_CheckBox.Checked == true)
                {
                    MyCount++;
                }


            }

            if (MyCount > 0)
            {
                cmdDeleteItems.Text = "Delete " + MyCount + " items";
                cmdApproveItems.Text = "Approve " + MyCount + " items";
            }
            else
            {
                cmdDeleteItems.Text = "Delete 0 item";
                cmdApproveItems.Text = "Approve 0 item";
            }


            SetUpFavList();

        }
        catch (Exception ex)
        {
        }
    }


    private string CheckaModalitySelected()
    {

        string myItem = string.Empty;
        bool IsChecked = false;

        try
        {

            if (chkCT.Checked == true)
            {
                IsChecked = true;
            }

            if (chkMR.Checked == true)
            {
                IsChecked = true;
            }

            if (chkMMV.Checked == true)
            {
                IsChecked = true;
            }

            if (chkNMSpect.Checked == true)
            {
                IsChecked = true;
            }

            if (chkNMPet.Checked == true)
            {
                IsChecked = true;
            }

            if (IsChecked == false)
            {
                myItem = "Modality";
            }

        }
        catch { }

        return myItem;
    }

    private string CheckaVendorSelected()
    {

        string myItem = string.Empty;
        bool IsChecked = false;

        try
        {

            if (chkSiemens.Checked == true)
            {
                IsChecked = true;
            }

            if (chkGE.Checked == true)
            {
                IsChecked = true;
            }

            if (chkToshiba.Checked == true)
            {
                IsChecked = true;
            }

            if (chkOthers.Checked == true)
            {
                IsChecked = true;
            }

            if (chkSamsung.Checked == true)
            {
                IsChecked = true;
            }

            if (IsChecked == false)
            {
                myItem = "Vendor";
            }

        }
        catch { }

        return myItem;
    }

    private void SetUpFavList()
    {
        try
        {

            if (Session["UserID"] != null)
            {

                //DataView MyList = Helper.GetData("Select * from PhilipsMatrixFilter where UserID='" + Session["UserID"].ToString() + "'");

                //repFavList.DataSource = MyList;
                //repFavList.DataBind();


                //foreach (DataRowView rowView in MyList)
                //{

                //}


            }

        }
        catch { }
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
                        switch (m_filtersearchO.Modality[Modalityidx].ToString())
                        {
                            case "CT":
                                chkCT.Checked = true;
                                break;
                            case "MR":
                                chkMR.Checked = true;
                                break;
                            case "MMV":
                                chkMMV.Checked = true;
                                break;
                            case "NM-SPECT":
                                chkNMSpect.Checked = true;
                                break;
                            case "NM-PET":
                                chkNMPet.Checked = true;
                                break;
                        }
                    }
                    #endregion

                    #region Vendor
                    for (int Vendoridx = 0; Vendoridx < m_filtersearchO.Vendor.Count; Vendoridx++)
                    {
                        switch (m_filtersearchO.Vendor[Vendoridx].ToString())
                        {
                            case "Siemens":
                                chkSiemens.Checked = true;
                                break;
                            case "GE":
                                chkGE.Checked = true;
                                break;
                            case "Toshiba":
                                chkToshiba.Checked = true;
                                break;
                            case "Others":
                                chkOthers.Checked = true;
                                break;
                            case "Samsung":
                                chkSamsung.Checked = true;
                                break;
                        }
                    }
                    #endregion




                    #region FilterSetUp

                    #endregion

                    #region ColumnSetUp
                    for (int ColumnSetUpidx = 0; ColumnSetUpidx < m_filtersearchO.ColumnSetUp.Count; ColumnSetUpidx++)
                    {
                        switch (m_filtersearchO.FilterSetUp[ColumnSetUpidx].ToString())
                        {
                            case "ISP":
                                chkISP.Checked = true;
                                break;
                            case "Vendor":
                                chkColVendor.Checked = true;
                                break;
                            case "Domain":
                                chkColDomain.Checked = true;
                                break;
                            case "Modality":
                                chkColModality.Checked = true;
                                break;
                            case "Model":
                                chkColModel.Checked = true;
                                break;
                            case "Module":
                                chkColModule.Checked = true;
                                break;
                            case "Software":
                                chkColSoftware.Checked = true;
                                break;
                            case "Definition":
                                chkColDefinition.Checked = true;
                                break;
                        }
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
                    chkCT.Checked = true;
                    chkSiemens.Checked = true;

                }

                SetupModality();
                SetUpVendor();
                SetUpSoftware();
                SetUpDomain();
                SetUpModule();
                SetUpListDefinition();
                SetUpColumnSelection();
                SetUpModel(1);
                SetUpFavList();

                SetupGrid();

            }
        }
        catch { }
    }

    protected void cmdSubmit_Click(object sender, EventArgs e)
    {
        try
        {

            string vendor = CheckaVendorSelected();
            string Modality = CheckaModalitySelected();


            if (vendor == "" & Modality == "")
            {
                panFeedBack.Visible = false;
                SetupModality();
                SetUpVendor();
                //SetUpModel(0);
                SetupGrid();
            }
            else
            {
                panFeedBack.Visible = true;
                if (vendor != "" & Modality != "")
                {
                    lblFeedBack.Text = "Please check " + vendor + " and " + Modality + " they are required items.";
                }
                else
                {
                    if (vendor != "")
                    {
                        lblFeedBack.Text = "Please check " + vendor + " it is a required items.";
                    }

                    if (Modality != "")
                    {
                        lblFeedBack.Text = "Please check " + Modality + " it is a required items.";
                    }
                }

            }

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


                        panFeedBack.Visible = false;
                        Response.Redirect("/");

                    }
                }
            }


        }
        catch { }
    }

    protected void cmdDeleteItems_Click(object sender, EventArgs e)
    {
        try
        {

            foreach (RepeaterItem item in repDataGrid.Items)
            {

                System.Web.UI.WebControls.HiddenField HF_MatrixID = (System.Web.UI.WebControls.HiddenField)item.FindControl("HF_PhilipsMatrixDataID");

                System.Web.UI.WebControls.CheckBox HF_CheckBox = (System.Web.UI.WebControls.CheckBox)item.FindControl("chkIsSelected");
                System.Web.UI.WebControls.HiddenField HF_PhilipsPendingID = (System.Web.UI.WebControls.HiddenField)item.FindControl("HF_PhilipsPendingID");

                //status 1 = deleted

                if (HF_CheckBox.Checked == true)
                {
                    System.Web.UI.WebControls.TextBox txtComment = (System.Web.UI.WebControls.TextBox)item.FindControl("txtComment");

                    string SQLPending = "update PhilipsMatrixData_PendingUpdates set Status='1' where  PendingID=" + HF_PhilipsPendingID.Value;
                    Helper.InsertData(SQLPending);

                    string SQLUpdate = "UPDATE PhilipsMatrixData SET  AddtionalNotes = '" + txtComment.Text + "' WHERE(PhilipsMatrixID = " + HF_MatrixID.Value.ToString() + ")";
                    Helper.InsertData(SQLUpdate);

                }

                //Get ID from Repeater
                //HF_MatrixID.Value



            }

            SetupGrid();


        }
        catch { }
    }






    private void ApproveData(string PendingID)
    {
        try
        {

            if (PendingID != "")
            {
                string sSQL = "select * FROM PhilipsMatrixData_PendingUpdates where PendingID=" + PendingID;
                DataView mDV = Helper.GetData(sSQL);

                foreach (DataRowView rowView in mDV)
                {

                    string PhilipsMatrixID = rowView["PhilipsMatrixDataID"].ToString();
                    string PhilipsID = rowView["PhilipsID"].ToString();
                    string Model = rowView["Model"].ToString();
                    string Software = rowView["Software"].ToString();
                    string Vendor = rowView["Vendor"].ToString();
                    string DataElement = rowView["DataElement"].ToString();
                    string Notes = rowView["Notes"].ToString();
                    string AddtionalNotes = rowView["AddtionalNotes"].ToString();
                    string ISP = rowView["ISP"].ToString();

                    string AppType = rowView["AppType"].ToString();
                    string Domain = rowView["Domain"].ToString();
                    string Module = rowView["Module"].ToString();
                    string Definition = rowView["Definition"].ToString();
                    string SubApp = rowView["SubApp"].ToString();



                    string sUpdateM = "UPDATE PhilipsMatrixData SET Model = '" + Model + "', Software = '" + Software + "', Vendor = '" + Vendor + "', DataElement = '" + DataElement + "', Notes = '" + Notes + "', AddtionalNotes = '" + AddtionalNotes + "', ISP = '" + ISP + "' WHERE(PhilipsMatrixDataID = " + PhilipsMatrixID + ")";
                    Helper.InsertData(sUpdateM);

                    string sUpdate = "UPDATE  PhilipsMatrix SET AppType = '" + AppType + "', Domain = '" + Domain + "', Module = '" + Module + "', Definition = '" + Definition + "', SubApp = '" + SubApp + "' WHERE(PhilipsID = " + PhilipsID + ")";
                    Helper.InsertData(sUpdate);


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

                System.Web.UI.WebControls.HiddenField HF_MatrixID = (System.Web.UI.WebControls.HiddenField)item.FindControl("HF_PhilipsMatrixDataID");
                System.Web.UI.WebControls.HiddenField HF_PhilipsPendingID = (System.Web.UI.WebControls.HiddenField)item.FindControl("HF_PhilipsPendingID");

                System.Web.UI.WebControls.CheckBox HF_CheckBox = (System.Web.UI.WebControls.CheckBox)item.FindControl("chkIsSelected");

                //status 2 = approved

                if (HF_CheckBox.Checked == true)
                {
                    System.Web.UI.WebControls.TextBox txtComment = (System.Web.UI.WebControls.TextBox)item.FindControl("txtComment");

                    string SQLPending = "update PhilipsMatrixData_PendingUpdates set Status='2' where  PendingID=" + HF_PhilipsPendingID.Value;
                    Helper.InsertData(SQLPending);

                    ApproveData(HF_PhilipsPendingID.Value);

                    //string SQLUpdate = "UPDATE TOP (200) PhilipsMatrixData SET AddtionalNotes = '" + txtComment.Text + "' WHERE(PhilipsMatrixDataID = " + HF_MatrixID.Value.ToString() + ")";
                    //Helper.InsertData(SQLUpdate);

                }

                //Get ID from Repeater
                //HF_MatrixID.Value



            }

            SetupGrid();

        }
        catch { }

    }

    protected void repDataGrid_ItemDataBound(object sender, RepeaterItemEventArgs e)
    {
        try
        {

            if (e.Item.ItemType == ListItemType.Item || e.Item.ItemType == ListItemType.AlternatingItem)
            {

                DataRowView drv = e.Item.DataItem as DataRowView;

                string sID = drv.Row["PhilipsMatrixDataID"].ToString();
                string sPendingID = drv.Row["PendingID"].ToString();
                string AddtionalNotes = string.Empty;

                //Get Current
                string sSQLData = "SELECT * FROM PhilipsMatrix INNER JOIN PhilipsMatrixData ON PhilipsMatrix.PhilipsID = PhilipsMatrixData.PhilipsMatrixID WHERE(PhilipsMatrixData.PhilipsMatrixDataID = " + sID + ")";
                DataView myDV = Helper.GetData(sSQLData);


                //Current Section             
                System.Web.UI.WebControls.Label lblVendor = e.Item.FindControl("lblVendor") as System.Web.UI.WebControls.Label;
                System.Web.UI.WebControls.Label lblModel = e.Item.FindControl("lblModel") as System.Web.UI.WebControls.Label;
                System.Web.UI.WebControls.Label lblSoftware = e.Item.FindControl("lblSoftware") as System.Web.UI.WebControls.Label;
                System.Web.UI.WebControls.Label lblDataElement = e.Item.FindControl("lblDataElement") as System.Web.UI.WebControls.Label;
                System.Web.UI.WebControls.Label lblNotes = e.Item.FindControl("lblNotes") as System.Web.UI.WebControls.Label;
                System.Web.UI.WebControls.Label lblAppType = e.Item.FindControl("lblAppType") as System.Web.UI.WebControls.Label;
                System.Web.UI.WebControls.Label lblISP = e.Item.FindControl("lblISP") as System.Web.UI.WebControls.Label;
                System.Web.UI.WebControls.Label lblDomain = e.Item.FindControl("lblDomain") as System.Web.UI.WebControls.Label;
                System.Web.UI.WebControls.Label lblModule = e.Item.FindControl("lblModule") as System.Web.UI.WebControls.Label;
                System.Web.UI.WebControls.Label lblDefinition = e.Item.FindControl("lblDefinition") as System.Web.UI.WebControls.Label;

                foreach (DataRowView rowNewS in myDV)
                {
                    lblVendor.Text = rowNewS["Vendor"].ToString();
                    lblModel.Text = rowNewS["Model"].ToString();
                    lblSoftware.Text = rowNewS["Software"].ToString();
                    lblDataElement.Text = rowNewS["DataElement"].ToString();
                    lblNotes.Text = rowNewS["Notes"].ToString();
                    lblAppType.Text = rowNewS["AppType"].ToString();
                    lblISP.Text = rowNewS["ISP"].ToString();
                    lblDomain.Text = rowNewS["Domain"].ToString();
                    lblModule.Text = rowNewS["Module"].ToString();
                    lblDefinition.Text = rowNewS["Definition"].ToString();
                    AddtionalNotes = rowNewS["AddtionalNotes"].ToString();
                }

                //Current Section


                //New Section                
                System.Web.UI.WebControls.HiddenField HF_PhilipsMatrixDataID = e.Item.FindControl("HF_PhilipsMatrixDataID") as System.Web.UI.WebControls.HiddenField;
                System.Web.UI.WebControls.HiddenField HF_PhilipsPendingID = e.Item.FindControl("HF_PhilipsPendingID") as System.Web.UI.WebControls.HiddenField;
                System.Web.UI.WebControls.TextBox txtVendor = e.Item.FindControl("txtVendor") as System.Web.UI.WebControls.TextBox;
                System.Web.UI.WebControls.TextBox txtModel = e.Item.FindControl("txtModel") as System.Web.UI.WebControls.TextBox;
                System.Web.UI.WebControls.TextBox txtSW = e.Item.FindControl("txtSW") as System.Web.UI.WebControls.TextBox;
                System.Web.UI.WebControls.TextBox txtDataElement = e.Item.FindControl("txtDataElement") as System.Web.UI.WebControls.TextBox;
                System.Web.UI.WebControls.TextBox txtModality = e.Item.FindControl("txtModality") as System.Web.UI.WebControls.TextBox;
                System.Web.UI.WebControls.TextBox txtISP = e.Item.FindControl("txtISP") as System.Web.UI.WebControls.TextBox;
                System.Web.UI.WebControls.TextBox txtDomain = e.Item.FindControl("txtDomain") as System.Web.UI.WebControls.TextBox;
                System.Web.UI.WebControls.TextBox txtModule = e.Item.FindControl("txtModule") as System.Web.UI.WebControls.TextBox;
                System.Web.UI.WebControls.TextBox txtDefinition = e.Item.FindControl("txtDefinition") as System.Web.UI.WebControls.TextBox;
                System.Web.UI.WebControls.TextBox txtComment = e.Item.FindControl("txtComment") as System.Web.UI.WebControls.TextBox;
                System.Web.UI.WebControls.TextBox txtNotes = e.Item.FindControl("txtNotes") as System.Web.UI.WebControls.TextBox;

                txtComment.Text = drv.Row["AddtionalNotes"].ToString();
                txtModule.Text = drv.Row["Module"].ToString();
                txtDefinition.Text = drv.Row["Definition"].ToString();
                txtDomain.Text = drv.Row["Domain"].ToString();
                txtModality.Text = drv.Row["AppType"].ToString();
                txtVendor.Text = drv.Row["Vendor"].ToString();
                txtISP.Text = drv.Row["ISP"].ToString();
                txtSW.Text = drv.Row["Software"].ToString();
                txtDataElement.Text = drv.Row["DataElement"].ToString();
                txtModel.Text = drv.Row["Model"].ToString();
                txtNotes.Text = drv.Row["Notes"].ToString();
                //New Section 


                if (txtNotes.Text != lblNotes.Text)
                {
                    txtNotes.ControlStyle.Font.Bold = true;
                }

                if (txtComment.Text != AddtionalNotes)
                {
                    txtComment.ControlStyle.Font.Bold = true;
                }

                if (txtISP.Text != lblISP.Text)
                {
                    txtISP.ControlStyle.Font.Bold = true;
                }

                if (txtModule.Text != lblModule.Text)
                {
                    txtModule.ControlStyle.Font.Bold = true;
                }

                if (txtDefinition.Text != lblDefinition.Text)
                {
                    txtDefinition.ControlStyle.Font.Bold = true;
                }

                if (txtDomain.Text != lblDomain.Text)
                {
                    txtDomain.ControlStyle.Font.Bold = true;
                }

                if (txtModality.Text != lblAppType.Text)
                {
                    txtModality.ControlStyle.Font.Bold = true;
                }

                if (txtVendor.Text != lblVendor.Text)
                {
                    txtVendor.ControlStyle.Font.Bold = true;
                }

                if (txtSW.Text != lblSoftware.Text)
                {
                    txtSW.ControlStyle.Font.Bold = true;
                }

                if (txtDataElement.Text != lblDataElement.Text)
                {
                    txtDataElement.ControlStyle.Font.Bold = true;
                }


                HF_PhilipsMatrixDataID.Value = sID;
                HF_PhilipsPendingID.Value = sPendingID;

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
                    if (Session["MVMatrix"].ToString() != "Super Admin")
                    {
                        Response.Redirect("/Account/Signin");
                    }
                }

            }


            if (Signin == true)
            {
                panFeedBack.Visible = false;
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