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
using MySql.Data.MySqlClient;

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


    private List<CommonDropDown> m_oVendor = null;
    private List<CommonDropDown> m_oModel = null;
    private List<CommonDropDown> m_oSoftware = null;
    private List<CommonDropDown> m_oAppData = null;
    private List<CommonDropDown> m_oISP = null;
    private List<CommonDropDown> m_oModality = null;
    private List<CommonDropDown> m_oDomain = null;
    private List<CommonDropDown> m_oModule = null;



    public class CommonDropDown
    {
        public int id { get; set; }
        public string text { get; set; }
        public string value { get; set; }
    }

    public class AppDataList
    {
        public List<CommonDropDown> GetResources()
        {
            List<CommonDropDown> AppDataCollection = new List<CommonDropDown>();
            AppDataCollection.Add(new CommonDropDown() { id = 1, text = "0", value = "0" });
            AppDataCollection.Add(new CommonDropDown() { id = 1, text = "1", value = "1" });
            AppDataCollection.Add(new CommonDropDown() { id = 2, text = "2", value = "2" });
            AppDataCollection.Add(new CommonDropDown() { id = 3, text = "3", value = "3" });
            AppDataCollection.Add(new CommonDropDown() { id = 4, text = "4", value = "4" });
            AppDataCollection.Add(new CommonDropDown() { id = 5, text = "5", value = "5" });
            return AppDataCollection;
        }
    }

    public class ISPList
    {
        public List<CommonDropDown> GetResources()
        {

            List<CommonDropDown> ISPCollection = new List<CommonDropDown>();

            DataView MyISP = Helper.GetData("Select * from PhilipsMatrixEdit where type='isp' order by Data");

            foreach (DataRowView rowViewV in MyISP)
            {
                ISPCollection.Add(new CommonDropDown() { id = Convert.ToInt32(rowViewV["MatrixEditID"].ToString()), text = rowViewV["Data"].ToString(), value = rowViewV["Data"].ToString() });
            }

            return ISPCollection;

        }
    }

    public class VendorList
    {
        public List<CommonDropDown> GetResources()
        {
            List<CommonDropDown> ISPVendor = new List<CommonDropDown>();

            DataView MyVendor = Helper.GetData("Select * from PhilipsMatrixEdit where type='vendor' order by Data");

            foreach (DataRowView rowViewV in MyVendor)
            {
                ISPVendor.Add(new CommonDropDown() { id = Convert.ToInt32(rowViewV["MatrixEditID"].ToString()), text = rowViewV["Data"].ToString(), value = rowViewV["Data"].ToString() });
            }

            return ISPVendor;
        }
    }

    public class ModelList
    {
        public List<CommonDropDown> GetResources()
        {
            List<CommonDropDown> ISPModel = new List<CommonDropDown>();

            DataView MyVendor = Helper.GetData("Select * from PhilipsMatrixEdit where type='model' order by Data");

            foreach (DataRowView rowViewV in MyVendor)
            {
                ISPModel.Add(new CommonDropDown() { id = Convert.ToInt32(rowViewV["MatrixEditID"].ToString()), text = rowViewV["Data"].ToString(), value = rowViewV["Data"].ToString() });
            }

            return ISPModel;
        }
    }

    public class SoftwareList
    {
        public List<CommonDropDown> GetResources()
        {
            List<CommonDropDown> SoftwareModel = new List<CommonDropDown>();

            DataView MyVendor = Helper.GetData("Select * from PhilipsMatrixEdit where type='software' order by Data");

            foreach (DataRowView rowViewV in MyVendor)
            {
                SoftwareModel.Add(new CommonDropDown() { id = Convert.ToInt32(rowViewV["MatrixEditID"].ToString()), text = rowViewV["Data"].ToString(), value = rowViewV["Data"].ToString() });
            }

            return SoftwareModel;
        }
    }

    public class DomainList
    {
        public List<CommonDropDown> GetResources()
        {
            List<CommonDropDown> DomainModel = new List<CommonDropDown>();

            DataView MyVendor = Helper.GetData("Select * from PhilipsMatrixEdit where type='domain' order by Data");

            foreach (DataRowView rowViewV in MyVendor)
            {
                DomainModel.Add(new CommonDropDown() { id = Convert.ToInt32(rowViewV["MatrixEditID"].ToString()), text = rowViewV["Data"].ToString(), value = rowViewV["Data"].ToString() });
            }

            return DomainModel;
        }
    }

    public class ModuleList
    {
        public List<CommonDropDown> GetResources()
        {
            List<CommonDropDown> ModuleModel = new List<CommonDropDown>();

            DataView MyVendor = Helper.GetData("Select * from PhilipsMatrixEdit where type='module' order by Data");

            foreach (DataRowView rowViewV in MyVendor)
            {
                ModuleModel.Add(new CommonDropDown() { id = Convert.ToInt32(rowViewV["MatrixEditID"].ToString()), text = rowViewV["Data"].ToString(), value = rowViewV["Data"].ToString() });
            }

            return ModuleModel;
        }
    }

    public class ModalityList
    {
        public List<CommonDropDown> GetResources()
        {
            //List<CommonDropDown> ModalityCollection = new List<CommonDropDown>();
            //ModalityCollection.Add(new CommonDropDown() { id = 0, text = "CT", value = "CT" });
            //ModalityCollection.Add(new CommonDropDown() { id = 1, text = "MR", value = "MR" });
            //ModalityCollection.Add(new CommonDropDown() { id = 2, text = "MMV", value = "MMV" });
            //ModalityCollection.Add(new CommonDropDown() { id = 3, text = "NM-SPECT", value = "NM-SPECT" });
            //ModalityCollection.Add(new CommonDropDown() { id = 4, text = "NM-PET", value = "NM-PET" });
            //return ModalityCollection;


            List<CommonDropDown> ModalityCollection = new List<CommonDropDown>();

            DataView MyVendor = Helper.GetData("Select * from PhilipsMatrixEdit where type='appType' order by Data");

            foreach (DataRowView rowViewV in MyVendor)
            {
                ModalityCollection.Add(new CommonDropDown() { id = Convert.ToInt32(rowViewV["MatrixEditID"].ToString()), text = rowViewV["Data"].ToString(), value = rowViewV["Data"].ToString() });
            }

            return ModalityCollection;


        }
    }

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

        public string Notes
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

        public string AddtionalNotes
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

            switch (Session["MVMatrix"].ToString())
            {
                case "Super Admin":
                case "ADMIN":
                    MyMenu = MyProfile + MyTracking;
                    break;

                case "Editor":
                case "EDIT":

                    break;



                default:
                    Response.Redirect("/Account/Signin");
                    break;
            }





        }
        catch { }

        return MyMenu;
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

    public string FormatFavDate(Object MyData)
    {
        string MyFormat = string.Empty;

        try
        {

            //FormatFavDate
            // Jan 1,2018

            if (MyData.ToString() != "")
            {

                DateTime myd = DateTime.Parse(MyData.ToString());
                MyFormat = myd.ToString("MMM") + "," + " " + myd.Day + " " + myd.Year;


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


            string sUserID = Session["UserID"].ToString();


            //Get OrderID

            DataView MyOrder = Helper.GetData("SELECT OrderID FROM PhilipsMatrixFilter ORDER BY OrderID DESC");
            int MyOrderID = 0;
            foreach (DataRowView rowView in MyOrder)
            {
                MyOrderID = Convert.ToInt32(rowView["OrderID"].ToString());
            }

            MyOrderID++;
            ////



            //Serialize json
            string json = JsonConvert.SerializeObject(filtersearch, Formatting.Indented);

            //save data           
            SetUpFavList();
        }
        catch //(Exception ex)
        { }
    }

    public string BuildData(object myData)
    {
        string HTMLBuilder = string.Empty;

        try
        {


            string model = DataBinder.Eval(myData, "Model").ToString();
            string vendor = DataBinder.Eval(myData, "Vendor").ToString();
            string software = DataBinder.Eval(myData, "Software").ToString();


            DataView view = new DataView();
            DataTable myTable = MyFullData.Table.Copy();
            DataSet ds = new DataSet();
            ds.Tables.Add(myTable);

            view = ds.Tables[0].DefaultView;

            view.RowFilter = "model = '" + model + "' and vendor='" + vendor + "' and software='" + software + "'";

            int idx = 0;
            foreach (DataRowView rowView in view)
            {
                if (idx == 0)
                {

                    HTMLBuilder += "<td style='border-top:1px solid #ddd;' class='icon_div green '></td>";
                    //HTMLBuilder += "<td style='border-top:1px solid #ddd;' ></td>";
                    HTMLBuilder += "<td class='isp'style='border-top:1px solid #ddd;'></td>";
                    HTMLBuilder += "<td class='modality'style='border-top:1px solid #ddd;'></td>";
                    HTMLBuilder += "<td class='domain'style='border-top:1px solid #ddd;'></td>";
                    HTMLBuilder += "<td class='module'style='border-top:1px solid #ddd;'></td>";
                    HTMLBuilder += "<td class='dataSetDef'style='border-top:1px solid #ddd;'></td>";
                    HTMLBuilder += "<td class='notes'></td>";


                    HTMLBuilder += "</tr>";
                }


                HTMLBuilder += "<tr>";
                HTMLBuilder += "<td class='vendor'></td>";
                HTMLBuilder += "<td class='model'></td>";
                HTMLBuilder += "<td class='version'></td>";


                if (rowView["Notes"].ToString() != "")
                {
                    HTMLBuilder += "<td style='border-top:1px solid #ddd;' class='" + GetColour(rowView["DataElement"].ToString(), false) + "'><div class='dropdown'><button class='btn btn-primary dropdown-toggle' type='button' data-toggle='dropdown'><span class=''><i class='fa fa-exclamation' aria-hidden='true'></i></span></button><ul class='dropdown-menu'><li>" + rowView["Notes"].ToString() + "</li>	<div class='footer-fixed'><button type='button' aria-hidden='true' class='close' data-notify='dismiss'><img src='images/notif_close.png'></button></div></ul></div></td>";
                }
                else
                {
                    HTMLBuilder += "<td style='border-top:1px solid #ddd;' class='" + GetColour(rowView["DataElement"].ToString(), true) + "'><i class='fa fa-exclamation'></i></td>";
                }


                HTMLBuilder += "<td class='notes'style='border-top:1px solid #ddd;'>" + rowView["Notes"].ToString() + "</td>";


                //HTMLBuilder += "<td style='border-top:1px solid #ddd;' ></td>";                
                HTMLBuilder += "<td class='isp'style='border-top:1px solid #ddd;'>9.0</td>";
                HTMLBuilder += "<td class='modality'style='border-top:1px solid #ddd;'>" + rowView["AppType"].ToString() + "</td>";
                HTMLBuilder += "<td class='domain' style='border-top:1px solid #ddd;'>" + rowView["Domain"].ToString() + "</td>";
                HTMLBuilder += "<td class='module' style='border-top:1px solid #ddd;'>" + rowView["Module"].ToString() + "</td>";
                HTMLBuilder += "<td class='dataSetDef' style='border-top:1px solid #ddd;'>" + rowView["Definition"].ToString() + "</td>";


                HTMLBuilder += "</tr>";

                idx++;
            }




            HTMLBuilder += "<tr class='border-bottom-table'>";
            HTMLBuilder += "<td class='vendor'></td>";
            HTMLBuilder += "<td class='model'></td>";
            HTMLBuilder += "<td class='version'></td>";
            //HTMLBuilder += "<td></td>";
            HTMLBuilder += "<td></td>";
            HTMLBuilder += "<td class='isp'></td>";
            HTMLBuilder += "<td class='modality'></td>";
            HTMLBuilder += "<td class='domain'></td>";
            HTMLBuilder += "<td class='module'></td>";

            HTMLBuilder += "<td class='dataSetDef'></td>";
            HTMLBuilder += "</tr>";

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

        string connStr = "server=rdsipos01d.cxvevr7ci7iw.eu-west-1.rds.amazonaws.com;user=appadmin; database=innodb; password=jyMMkn9UWTrDosfNNc5zf97Iwua9NIKb9L2cp17K;Convert Zero Datetime=True";
        MySqlConnection conn = new MySqlConnection(connStr);

        try
        {
            conn.Open();


            MySqlCommand cmd = new MySqlCommand(sql, conn);

            using (MySqlDataReader rdr = cmd.ExecuteReader())
            {
                myDS = new DataSet();
                myDS.Tables.Add("Table1");

                //Load DataReader into the DataTable.
                myDS.Tables[0].Load(rdr);
                myDV = myDS.Tables[0].DefaultView;
            }

        }
        catch (Exception ex)
        {

            string sds = ex.Message;

        }

        conn.Close();
        return myDV;
    }

    private void SaveData(string sql)
    {
        string connStr = "server=rdsipos01d.cxvevr7ci7iw.eu-west-1.rds.amazonaws.com;user=appadmin; database=innodb; password=jyMMkn9UWTrDosfNNc5zf97Iwua9NIKb9L2cp17K;Convert Zero Datetime=True";
        MySqlConnection conn = new MySqlConnection(connStr);

        try
        {
            conn.Open();


            MySqlCommand cmd = new MySqlCommand(sql, conn);
            //MySqlDataReader rdr = cmd.ExecuteReader();

            using (MySqlDataReader rdr = cmd.ExecuteReader())
            {
            }

        }
        catch (Exception ex)
        {
            string sds = ex.Message;
        }

        conn.Close();

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

    private void SetUpISP()
    {
        //https://www.dotnetperls.com/sortedlist
        SortedList<int, int> sorted = new SortedList<int, int>();

        try
        {

            string SQL = "SELECT DISTINCT ISP FROM PhilipsMatrix";
            DataView MyDV = Helper.GetData(SQL);

            foreach (DataRowView rowView in MyDV)
            {
                try
                {
                    sorted.Add(Convert.ToInt32(rowView["ISP"].ToString()), Convert.ToInt32(rowView["ISP"].ToString()));
                }
                catch { }

            }

            //if (rowView["ISP"].ToString() != "")
            //{
            //    chkISPVersion.Items.Add(new ListItem(rowView["ISP"].ToString(), rowView["ISP"].ToString()));
            //}


            foreach (var pair in sorted)
            {
                chkISPVersion.Items.Add(new ListItem(pair.Value.ToString(), pair.Value.ToString()));
            }


            foreach (ListItem item in this.chkISPVersion.Items)
            {
                if (item.Value == "9")
                {
                    item.Selected = true;
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

        try
        {

            //Model       
            string sSelectedModel = string.Empty;
            string sSelectedModule = string.Empty;
            string m_ISPVersion = string.Empty;

            foreach (ListItem item in this.chkboxModel.Items)
            {
                if (item.Selected)
                {
                    if (sSelectedModel == "")
                    {
                        sSelectedModel += "'" + StripData(item.Text) + "'";
                    }
                    else
                    {
                        sSelectedModel += ",'" + StripData(item.Text) + "'";
                    }
                }
            }

            //sSelectedModule
            foreach (ListItem item in this.chkboxModule.Items)
            {
                if (item.Selected)
                {
                    if (sSelectedModule == "")
                    {
                        sSelectedModule += "'" + StripData(item.Text) + "'";
                    }
                    else
                    {
                        sSelectedModule += ",'" + StripData(item.Text) + "'";
                    }
                }
            }


            //Software       
            string sSelectedSoftware = string.Empty;
            foreach (ListItem item in this.chkboxSoftware.Items)
            {
                if (item.Selected)
                {
                    if (sSelectedSoftware == "")
                    {
                        sSelectedSoftware += "'" + StripData(item.Text) + "'";
                    }
                    else
                    {
                        sSelectedSoftware += ",'" + StripData(item.Text) + "'";
                    }
                }
            }

            //Software    

            try
            {
                //chkISPVersion.Text
                //if (chk9.Checked == true)
                //{
                m_ISPVersion += "'" + chkISPVersion.Text + "'";
                //}

                //if (chk10.Checked == true)
                //{
                //    if (m_ISPVersion != "")
                //    {
                //        m_ISPVersion += ",'10'";
                //    }
                //    else
                //    {
                //        m_ISPVersion += "'10'";
                //    }
                //}

            }
            catch
            {

                m_ISPVersion = "9";
            }


            string SQL1 = "SELECT PhilipsMatrix.PhilipsID, PhilipsMatrix.AppType, PhilipsMatrix.Domain, PhilipsMatrix.Module, PhilipsMatrix.Definition, PhilipsMatrix.SubApp, PhilipsMatrixData.ISP, PhilipsMatrixData.PhilipsMatrixDataID, PhilipsMatrixData.Model, PhilipsMatrixData.Software ";
            SQL1 += ",PhilipsMatrixData.Vendor";
            SQL1 += ", PhilipsMatrixData.DataElement,PhilipsMatrixData.Notes, PhilipsMatrixData.AddtionalNotes FROM PhilipsMatrix INNER JOIN  PhilipsMatrixData ON PhilipsMatrix.PhilipsID = PhilipsMatrixData.PhilipsMatrixID WHERE PhilipsMatrix.ISP in (" + m_ISPVersion + ") AND ";

            if (sSelectedModel != "")
            {
                SQL1 += "model in(" + sSelectedModel + ") ";
                UserAND = 1;
            }

            if (m_BuildVendor != "")
            {
                if (UserAND == 1)
                {
                    SQL1 += " AND ";
                }

                SQL1 += " Vendor in(" + m_BuildVendor + ")";
                UserAND = 1;
            }

            if (m_BuildAppType != "")
            {
                if (UserAND == 1)
                {
                    SQL1 += " AND ";
                }
                SQL1 += " (PhilipsMatrix.AppType IN(" + m_BuildAppType + "))";
                UserAND = 1;
            }

            if (sSelectedSoftware != "")
            {
                if (UserAND == 1)
                {
                    SQL1 += " AND ";
                }
                SQL1 += " software in(" + sSelectedSoftware + ")";
                UserAND = 1;
            }


            if (sSelectedModule != "")
            {
                if (UserAND == 1)
                {
                    SQL1 += " AND ";
                }

                SQL1 += " Module in(" + sSelectedModule + ")";

                UserAND = 1;
            }


            MyFullData = Helper.GetData(SQL1);

            ///////////////////////////////////////////////////////////////////////////////////////////

            UserAND = 0;
            string SQL = "SELECT DISTINCT PhilipsMatrixData.Vendor, PhilipsMatrixData.Model, PhilipsMatrixData.Software, PhilipsMatrix.AppType FROM PhilipsMatrixData INNER JOIN PhilipsMatrix ON PhilipsMatrixData.PhilipsMatrixID = PhilipsMatrix.PhilipsID WHERE PhilipsMatrix.ISP in (" + m_ISPVersion + ") AND ";

            if (sSelectedModel != "")
            {
                SQL += " model in(" + sSelectedModel + ")";
                UserAND = 1;
            }

            if (m_BuildVendor != "")
            {
                if (UserAND == 1)
                {
                    SQL += " AND ";
                }

                SQL += " Vendor in(" + m_BuildVendor + ")";
                UserAND = 1;
            }

            if (sSelectedSoftware != "")
            {

                if (UserAND == 1)
                {
                    SQL += " AND ";
                }

                SQL += " software in(" + sSelectedSoftware + ")";
                UserAND = 1;
            }

            if (m_BuildAppType != "")
            {
                if (UserAND == 1)
                {
                    SQL += " AND ";
                }

                SQL += "(PhilipsMatrix.AppType IN(" + m_BuildAppType + "))";
            }

            if (sSelectedModule != "")
            {
                if (UserAND == 1)
                {
                    SQL += " AND ";
                }

                SQL += " Module in(" + sSelectedModule + ")";

                UserAND = 1;
            }


            SQL += " ORDER BY PhilipsMatrixData.Vendor, PhilipsMatrixData.Software, PhilipsMatrixData.Model ";

            DataView MyDV = Helper.GetData(SQL);

            var ListItem = this.GetDefaultData(MyDV);


            VendorList oVendor = new VendorList();
            m_oVendor = oVendor.GetResources();


            ModelList oModel = new ModelList();
            m_oModel = oModel.GetResources();

            SoftwareList oSoftware = new SoftwareList();
            m_oSoftware = oSoftware.GetResources();

            AppDataList oAppData = new AppDataList();
            m_oAppData = oAppData.GetResources();


            ISPList oISP = new ISPList();
            m_oISP = oISP.GetResources();

            ModalityList oModality = new ModalityList();
            m_oModality = oModality.GetResources();

            DomainList oDomain = new DomainList();
            m_oDomain = oDomain.GetResources();

            ModuleList oModule = new ModuleList();
            m_oModule = oModule.GetResources();


            repData.DataSource = ListItem;
            repData.DataBind();



            //TreeGrid.DataBind();


            //Setup Add data drop down




            //var index1 = this.TreeGrid.Columns.FindIndex(col => col.Field == "DataElement");
            //this.TreeGrid.Columns.ElementAt(index1).DropDownData = data;
            //Setup Add data drop down


            //Setup Add data drop down
            //ModalityList oModality = new ModalityList();
            //var dataM = oModality.GetResources();
            //var index2 = this.TreeGrid.Columns.FindIndex(col => col.Field == "AppType");
            //this.TreeGrid.Columns.ElementAt(index2).DropDownData = dataM;
            //Setup Add data drop down



            //Setup Add data drop down
            //ISPList oISP = new ISPList();
            //var dataI = oISP.GetResources();
            //var index3 = this.TreeGrid.Columns.FindIndex(col => col.Field == "ISP");
            //this.TreeGrid.Columns.ElementAt(index3).DropDownData = dataI;
            ////Setup Add data drop down


            ////VendorList
            //VendorList oVendor = new VendorList();
            //var dataV = oVendor.GetResources();
            //var index4 = this.TreeGrid.Columns.FindIndex(col => col.Field == "Vendor");
            //this.TreeGrid.Columns.ElementAt(index4).DropDownData = dataV;

            ////ModelList
            //ModelList oModel = new ModelList();
            //var dataMo = oModel.GetResources();
            //var index5 = this.TreeGrid.Columns.FindIndex(col => col.Field == "Model");
            //this.TreeGrid.Columns.ElementAt(index5).DropDownData = dataMo;

            ////SoftwareList
            //SoftwareList oSoftware = new SoftwareList();
            //var dataSo = oSoftware.GetResources();
            //var index6 = this.TreeGrid.Columns.FindIndex(col => col.Field == "Software");
            //this.TreeGrid.Columns.ElementAt(index6).DropDownData = dataSo;

            ////DomainList
            //DomainList oDomain = new DomainList();
            //var dataDo = oDomain.GetResources();
            //var index7 = this.TreeGrid.Columns.FindIndex(col => col.Field == "Domain");
            //this.TreeGrid.Columns.ElementAt(index7).DropDownData = dataDo;

            ////ModuleList
            //ModuleList oModule = new ModuleList();
            //var dataMod = oDomain.GetResources();
            //var index8 = this.TreeGrid.Columns.FindIndex(col => col.Field == "Module");
            //this.TreeGrid.Columns.ElementAt(index8).DropDownData = dataMod;


            SetUpFavList();

        }
        catch (Exception ex)
        {
        }
    }

    private List<BusinessObject> GetDefaultData(DataView MyDV)
    {
        List<BusinessObject> BusinessObjectCollection = new List<BusinessObject>();
        BusinessObject Record1 = null;


        //var PhilipsID = this.TreeGrid.Columns.FindIndex(col => col.Field == "PhilipsID");
        //var PhilipsMatrixDataID = this.TreeGrid.Columns.FindIndex(col => col.Field == "PhilipsMatrixDataID");


        var PhilipsID = 0;
        var PhilipsMatrixDataID = 1;

        foreach (DataRowView rowView in MyDV)
        {


            Record1 = new BusinessObject()
            {
                PhilipsID = PhilipsID,
                PhilipsMatrixDataID = PhilipsMatrixDataID,
                Vendor = rowView["Vendor"].ToString(),
                Model = rowView["Model"].ToString(),
                Software = "",//rowView["Software"].ToString(),               
                AppType = "",//rowView["AppType"].ToString(),

                //DataElement = rowView["DataElement"].ToString(),
                //Domain = rowView["Domain"].ToString(),
                //Module = rowView["Module"].ToString(),
                //Definition = rowView["Definition"].ToString(),
                Children = new List<BusinessObject>(),
            };



            string model = rowView["Model"].ToString();
            string vendor = rowView["Vendor"].ToString();
            string software = rowView["Software"].ToString();


            DataView view = new DataView();
            DataTable myTable = MyFullData.Table.Copy();
            DataSet ds = new DataSet();
            ds.Tables.Add(myTable);

            view = ds.Tables[0].DefaultView;

            view.RowFilter = "model = '" + model + "' and vendor='" + vendor + "' and software='" + software + "'";

            //int idx = 0;
            foreach (DataRowView rowViewDetail in view)
            {


                BusinessObject Child1 = new BusinessObject()
                {
                    PhilipsID = Convert.ToInt32(rowViewDetail["PhilipsID"].ToString()),
                    PhilipsMatrixDataID = Convert.ToInt32(rowViewDetail["PhilipsMatrixDataID"].ToString()),
                    Vendor = rowViewDetail["Vendor"].ToString(),
                    Model = rowView["Model"].ToString(),
                    Software = rowViewDetail["Software"].ToString(),
                    DataElement = rowViewDetail["DataElement"].ToString(),
                    Notes = rowViewDetail["Notes"].ToString(),
                    AppType = rowViewDetail["AppType"].ToString(),
                    ISP = rowViewDetail["ISP"].ToString(),
                    Domain = rowViewDetail["Domain"].ToString(),
                    Module = rowViewDetail["Module"].ToString(),
                    Definition = rowViewDetail["Definition"].ToString(),

                    AddtionalNotes = rowViewDetail["AddtionalNotes"].ToString(),


                };


                Record1.Children.Add(Child1);


            }



            BusinessObjectCollection.Add(Record1);






        }


        return BusinessObjectCollection;

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

                //DataView MyList = GetData("Select * from PhilipsMatrixFilter where UserID='" + Session["UserID"].ToString() + "'");

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

                if (Request.QueryString["FavListID"] != null)
                {
                    if (Request.QueryString["FavListID"].ToString() != "")
                    {
                        if (Request.QueryString["FavListID"].ToString() != "")
                        {
                            FavListID = Request.QueryString["FavListID"].ToString();

                            SetUpFromDB = PageSetupByDB(FavListID);

                            //PanAddFav.Visible = false;
                            //PanRemoveFav.Visible = true;

                        }
                    }
                }
                else
                {
                    //PanAddFav.Visible = true;
                    //PanRemoveFav.Visible = false;
                }

                if (SetUpFromDB == false)
                {
                    chkCT.Checked = true;
                    chkSiemens.Checked = true;

                }

                SetUpISP();
                SetupModality();
                SetUpVendor();
                SetUpSoftware();
                SetUpDomain();
                SetUpModule();
                SetUpListDefinition();
                SetUpColumnSelection();
                SetUpModel(1);
                SetUpFavList();




                //if (chk9.Checked == false & chk10.Checked == false)
                //{
                //    chk9.Checked = true;
                //}

                if (SetUpFromDB == true)
                {
                    SetupGrid();
                }


            }
        }
        catch { }
    }

    protected void DoSearch()
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
    protected void cmdSubmit_Click(object sender, EventArgs e)
    {
        try
        {

            DoSearch();

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
                    Signin = true;
                }

                if (Session["UserType"] != null)
                {

                    switch (Session["MVMatrix"].ToString())
                    {
                        case "Editor":
                        case "Super Admin":
                        case "ADMIN":
                        case "EDIT":
                            break;
                        default:
                            Response.Redirect("/Account/Signin");
                            break;

                    }

                }
            }


            if (Signin == true)
            {
                panFeedBack.Visible = false;
                PageSetUp();

            }



            DoSearch();

        }
        catch { }
    }


    public string GetDataItem(object item)
    {
        try
        {



        }
        catch { }

        return "";
    }

    protected void repData_ItemDataBound(object sender, RepeaterItemEventArgs e)
    {
        try
        {

            if (e.Item.ItemType == ListItemType.Item || e.Item.ItemType == ListItemType.AlternatingItem)
            {

                //DataRowView drv = e.Item.DataItem as DataRowView;


                List<BusinessObject> BusinessObjectCollection = new List<BusinessObject>();
                BusinessObject Record1 = (BusinessObject)e.Item.DataItem;

                BusinessObjectCollection = Record1.Children;




                var repeater2 = (Repeater)e.Item.FindControl("repDataItem");

                // var ListItem = this.GetDefaultData(MyDV); ;

                repeater2.DataSource = BusinessObjectCollection;
                repeater2.DataBind();






                //for (int i = 0; i < BusinessObjectCollection.Count; i++)
                //{
                //    lblVendor.Text += "<tr>";

                //    lblVendor.Text += "<td>&nbsp;</td>";
                //    lblVendor.Text += "<td>&nbsp;</td>";
                //    lblVendor.Text += "<td><input type='text' name='tbSoftware' id='tbSoftware' value='" + BusinessObjectCollection[i].Software + "'></td>";
                //    lblVendor.Text += "<td><input type='text' name='tbDataElement' id='tbDataElement' value='" + BusinessObjectCollection[i].DataElement + "'></td>";
                //    lblVendor.Text += "<td><input type='text' name='tbNotes' id='tbNotes' value='" + BusinessObjectCollection[i].Notes + "'></td>";
                //    lblVendor.Text += "<td><input type='text' name='tbISP' id='tbISP' value='" + BusinessObjectCollection[i].ISP + "'></td>";
                //    lblVendor.Text += "<td><input type='text' name='tbAppType' id='tbAppType' value='" + BusinessObjectCollection[i].AppType + "'></td>";
                //    lblVendor.Text += "<td><input type='text' name='tbDomain' id='tbDomain' value='" + BusinessObjectCollection[i].Domain + "'></td>";
                //    lblVendor.Text += "<td><input type='text' name='tbModule' id='tbModule' value='" + BusinessObjectCollection[i].Module + "'></td>";
                //    lblVendor.Text += "<td><input type='text' name='tbDefinition' id='tbDefinition' value='" + BusinessObjectCollection[i].Definition + "'></td>";
                //    lblVendor.Text += "<td><input type='text' name='tbAddtionalNotes' id='tbAddtionalNotes' value='" + BusinessObjectCollection[i].AddtionalNotes + "'></td>";
                //    lblVendor.Text += "<td><button type='submit'>Update</button></td>";                    
                //    lblVendor.Text += "</tr>";
                //}





                // lblVendor.Text = " <td>Otto</td><td>Otto</td><td>Otto</td><td>Otto</td><td>Otto</td><td>Otto</td><td>Otto</td><td>Otto</td>";

            }



        }
        catch { }
    }


    protected void GetValue(object sender, EventArgs e)
    {
        try
        {

            string UserName = string.Empty;


            if (Session["User"] != null)
            {
                UserName = Session["User"].ToString();
            }
            else
            {
                UserName = "";
            }


            //Reference the Repeater Item using Button.
            RepeaterItem item = (sender as System.Web.UI.WebControls.Button).NamingContainer as RepeaterItem;


            string PhilipsID = (item.FindControl("tbPhilipsID") as HiddenField).Value;
            string PhilipsMatrixDataID = (item.FindControl("tbPhilipsMatrixDataID") as HiddenField).Value;

            string Vendor = (item.FindControl("tbVendor") as System.Web.UI.WebControls.DropDownList).Text;
            string Model = (item.FindControl("tbModel") as System.Web.UI.WebControls.DropDownList).Text;
            string Software = (item.FindControl("tbSoftware") as System.Web.UI.WebControls.DropDownList).Text;
            string DataElement = (item.FindControl("tbDataElement") as System.Web.UI.WebControls.DropDownList).Text;
            string ISP = (item.FindControl("tbISP") as System.Web.UI.WebControls.DropDownList).Text;
            string AppType = (item.FindControl("tbAppType") as System.Web.UI.WebControls.DropDownList).Text;
            string Domain = (item.FindControl("tbDomain") as System.Web.UI.WebControls.DropDownList).Text;
            string Module = (item.FindControl("tbModule") as System.Web.UI.WebControls.DropDownList).Text;
            string Definition = (item.FindControl("tbDataSet") as TextBox).Text;
            string AddtionalNotes = (item.FindControl("tbAddComments") as TextBox).Text;
            string Notes = (item.FindControl("tbNotes") as TextBox).Text;

            string SQL = "INSERT INTO PhilipsMatrixData_PendingUpdates(PhilipsID, PhilipsMatrixDataID, Vendor, Model, Software, DataElement, ISP, AppType, Domain, Module, Definition,AddtionalNotes,Notes,UserName) VALUES(";
            SQL = SQL + PhilipsID + ", " + PhilipsMatrixDataID + ", '" + Vendor + "', '" + Model + "', '" + Software + "', '" + DataElement + "', '" + ISP + "', '" + AppType + "', '" + Domain + "', '" + Module + "', '" + Definition + "','" + AddtionalNotes + "','" + Notes + "','" + UserName + "')";


            Helper.InsertData(SQL);








        }
        catch (Exception ex)
        {

        }

    }




    protected void repDataItem_ItemDataBound(object sender, RepeaterItemEventArgs e)
    {
        try
        {

            if (e.Item.ItemType == ListItemType.Item || e.Item.ItemType == ListItemType.AlternatingItem)
            {

                //DataRowView drv = e.Item.DataItem as DataRowView;


                List<BusinessObject> BusinessObjectCollection = new List<BusinessObject>();
                BusinessObject Record1 = (BusinessObject)e.Item.DataItem;

                // BusinessObjectCollection = Record1.Children;

                System.Web.UI.WebControls.HiddenField tbPhilipsID = e.Item.FindControl("tbPhilipsID") as System.Web.UI.WebControls.HiddenField;
                System.Web.UI.WebControls.HiddenField tbPhilipsMatrixDataID = e.Item.FindControl("tbPhilipsMatrixDataID") as System.Web.UI.WebControls.HiddenField;

                System.Web.UI.WebControls.DropDownList tbSoftware = e.Item.FindControl("tbSoftware") as System.Web.UI.WebControls.DropDownList;
                System.Web.UI.WebControls.DropDownList tbDataElement = e.Item.FindControl("tbDataElement") as System.Web.UI.WebControls.DropDownList;
                System.Web.UI.WebControls.TextBox tbNotes = e.Item.FindControl("tbNotes") as System.Web.UI.WebControls.TextBox;
                System.Web.UI.WebControls.DropDownList tbISP = e.Item.FindControl("tbISP") as System.Web.UI.WebControls.DropDownList;
                System.Web.UI.WebControls.DropDownList tbAppType = e.Item.FindControl("tbAppType") as System.Web.UI.WebControls.DropDownList;
                System.Web.UI.WebControls.DropDownList tbDomain = e.Item.FindControl("tbDomain") as System.Web.UI.WebControls.DropDownList;

                System.Web.UI.WebControls.DropDownList tbModule = e.Item.FindControl("tbModule") as System.Web.UI.WebControls.DropDownList;
                System.Web.UI.WebControls.DropDownList tbDataSet = e.Item.FindControl("tbDataSet") as System.Web.UI.WebControls.DropDownList;
                System.Web.UI.WebControls.TextBox tbAddComments = e.Item.FindControl("tbAddComments") as System.Web.UI.WebControls.TextBox;
                System.Web.UI.WebControls.Button updateButton = e.Item.FindControl("updateButton") as System.Web.UI.WebControls.Button;


                System.Web.UI.WebControls.DropDownList tbVendor = e.Item.FindControl("tbVendor") as System.Web.UI.WebControls.DropDownList;
                System.Web.UI.WebControls.DropDownList tbModel = e.Item.FindControl("tbModel") as System.Web.UI.WebControls.DropDownList;



                for (int i = 0; i < m_oVendor.Count; i++)
                {
                    tbVendor.Items.Add(new ListItem(m_oVendor[i].value));
                    if (tbnVendor.Items.Count != m_oVendor.Count)
                    {
                        tbnVendor.Items.Add(new ListItem(m_oVendor[i].value));
                    }
                }



                for (int i = 0; i < m_oModel.Count; i++)
                {
                    tbModel.Items.Add(new ListItem(m_oModel[i].value));
                    if (tbnModel.Items.Count != m_oModel.Count)
                    {
                        tbnModel.Items.Add(new ListItem(m_oModel[i].value));
                    }
                }

                for (int i = 0; i < m_oSoftware.Count; i++)
                {
                    tbSoftware.Items.Add(new ListItem(m_oSoftware[i].value));
                    if (tbnSoftware.Items.Count != m_oSoftware.Count)
                    {
                        tbnSoftware.Items.Add(new ListItem(m_oSoftware[i].value));
                    }
                }

                for (int i = 0; i < m_oAppData.Count; i++)
                {
                    tbDataElement.Items.Add(new ListItem(m_oAppData[i].value));
                    if (tbnDataElement.Items.Count != m_oAppData.Count)
                    {
                        tbnDataElement.Items.Add(new ListItem(m_oAppData[i].value));
                    }
                }

                for (int i = 0; i < m_oISP.Count; i++)
                {
                    tbISP.Items.Add(new ListItem(m_oISP[i].value));
                    if (tbnISP.Items.Count != m_oISP.Count)
                    {
                        tbnISP.Items.Add(new ListItem(m_oISP[i].value));
                    }
                }

                for (int i = 0; i < m_oModality.Count; i++)
                {
                    tbAppType.Items.Add(new ListItem(m_oModality[i].value));
                    if (tbnAppType.Items.Count != m_oModality.Count)
                    {
                        tbnAppType.Items.Add(new ListItem(m_oModality[i].value));
                    }
                }

                for (int i = 0; i < m_oDomain.Count; i++)
                {
                    tbDomain.Items.Add(new ListItem(m_oDomain[i].value));
                    if (tbDomain.Items.Count != m_oDomain.Count)
                    {
                        tbnDomain.Items.Add(new ListItem(m_oDomain[i].value));
                    }
                }

                for (int i = 0; i < m_oModule.Count; i++)
                {
                    tbModule.Items.Add(new ListItem(m_oModule[i].value));
                    if (tbnModule.Items.Count != m_oModule.Count)
                    {
                        tbnModule.Items.Add(new ListItem(m_oModule[i].value));
                    }
                }





                tbVendor.Text = Record1.Vendor;
                tbModel.Text = Record1.Model;


                tbPhilipsID.Value = Record1.PhilipsID.ToString();
                tbPhilipsMatrixDataID.Value = Record1.PhilipsMatrixDataID.ToString();

                tbSoftware.Text = Record1.Software;
                tbDataElement.Text = Record1.DataElement;
                tbNotes.Text = Record1.Notes;
                tbISP.Text = Record1.ISP;
                tbAppType.Text = Record1.AppType;
                tbDomain.Text = Record1.Domain;
                tbModule.Text = Record1.Module;
                tbDataSet.Text = Record1.Definition;
                tbAddComments.Text = Record1.AddtionalNotes;



            }



        }
        catch { }
    }

    protected void SaveButton_Click(object sender, EventArgs e)
    {
        try
        {

            string UserName = string.Empty;


            if (Session["User"] != null)
            {
                UserName = Session["User"].ToString();
            }
            else
            {
                UserName = "";
            }



            /////
            string SQLData = "INSERT INTO `innodb`.`PhilipsMatrix`(`AppType`,`Domain`,`Module`,`Definition`,`SubApp`,`ISP`,`Status`) VALUES ('" + tbnAppType.Text + "','" + tbnDomain.Text + "','" + tbnModule.Text + "','" + tbnDataSet.Text + "','','" + tbnISP.Text + "',2);SELECT LAST_INSERT_ID();";
            DataView MyMatrixData = Helper.GetData(SQLData);

            string MyInsertID = string.Empty;
            foreach (DataRowView rowView in MyMatrixData)
            {
                MyInsertID = rowView["LAST_INSERT_ID()"].ToString();

            }
            /////
            ///

            //Data
            if (MyInsertID != "")
            {
                string MyMatrixDataSQL = "INSERT INTO `innodb`.`PhilipsMatrixData`(`PhilipsMatrixID`,`Model`,`Software`,`Vendor`,`DataElement`,`Notes`,`AddtionalNotes`,`ISP`) VALUES (" + MyInsertID + ", '" + tbnModel.Text + "', '" + tbnSoftware.Text + "' , '" + tbnVendor.Text + "', '" + tbnDataElement.Text + "', '" + tbnNotes.Text + "', '" + tbnAddComments.Text + "', '" + tbnISP.Text + "');SELECT LAST_INSERT_ID();";
                DataView MyMatrixDataItem = Helper.GetData(MyMatrixDataSQL);
                string MyInsertMatrixDataID = string.Empty;
                foreach (DataRowView rowView in MyMatrixDataItem)
                {
                    MyInsertMatrixDataID = rowView["LAST_INSERT_ID()"].ToString();

                }



                string SQL = "INSERT INTO PhilipsMatrixData_PendingUpdates(PhilipsID, PhilipsMatrixDataID, Vendor, Model, Software, DataElement, ISP, AppType, Domain, Module, Definition,AddtionalNotes,Notes,UserName) VALUES(";
                SQL = SQL + MyInsertID + ", " + MyInsertMatrixDataID + ", '" + tbnVendor.Text + "', '" + tbnModel.Text + "', '" + tbnSoftware.Text + "', '" + tbnDataElement.Text + "', '" + tbnISP.Text + "', '" + tbnAppType.Text + "', '" + tbnDomain.Text + "', '" + tbnModule.Text + "', '" + tbnDataSet.Text + "','" + tbnAddComments.Text + "','" + tbnNotes.Text + "','" + UserName + "')";


                Helper.InsertData(SQL);


            }


            PanAddNew.Visible = false;
        }
        catch { }
    }

    protected void cmdAddNew_Click(object sender, EventArgs e)
    {
        try
        {

            PanAddNew.Visible = true;
        }
        catch { }
    }
}