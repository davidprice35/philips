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

public partial class _Home : Page
{
    private string m_BuildAppType = string.Empty;
    private string m_BuildVendor = string.Empty;
    private string m_BuildModality = string.Empty;
    private string m_SelectedModel = string.Empty;
    public string m_ISPVersion = string.Empty;
    public string m_FilterLabel = string.Empty;
    public string m_UserName = string.Empty;
    public string m_UserID = string.Empty;
    public FilterSearch m_filtersearchO = null;
    private string m_UserType = string.Empty;

    private DataView m_MyFullData = null;

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

                case "Super Viewer":
                case "Content Admin":
                case "Editor":
                case "EDIT":

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
    public string GetModelRequired()
    {
        string myuser = string.Empty;

        try
        {

            switch (Session["UserType"].ToString())
            {
                case "ADMIN":

                    break;

                case "EDIT":

                    break;

                case "VIEW":
                    myuser = "*";
                    break;


            }

        }
        catch { }

        return myuser;
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
                    MyMenu = MyMenuMatrix;
                    break;
                case "Content Admin":
                case "Editor":
                case "EDIT":
                    MyMenu = MyMenuMatrix + MyMenuEdit;
                    break;

                case "Viewer":
                case "VIEW":
                    MyMenu = MyMenuMatrix;
                    m_UserType = MyMenu;
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

            if (chkGreenFilter.Checked == true)
            {
                filtersearch.FilterSetUp.Add("Green");
            }

            if (chkYellowFilter.Checked == true)
            {
                filtersearch.FilterSetUp.Add("Yellow");
            }

            if (chkRedFilter.Checked == true)
            {
                filtersearch.FilterSetUp.Add("Red");
            }

            if (chkOrangeFilter.Checked == true)
            {
                filtersearch.FilterSetUp.Add("Orange");
            }

            if (chkWhiteFilter.Checked == true)
            {
                filtersearch.FilterSetUp.Add("White");
            }

            #endregion

            string sUserID = Session["UserID"].ToString();


            //Get OrderID

            DataView MyOrder = GetData("SELECT TOP (1) OrderID,FilterID FROM PhilipsMatrixFilter ORDER BY OrderID DESC");
            int MyOrderID = 0;
            int FilterID = 0;
            foreach (DataRowView rowView in MyOrder)
            {
                MyOrderID = Convert.ToInt32(rowView["OrderID"].ToString());
                //FilterID = Convert.ToInt32(rowView["FilterID"].ToString());
            }

            MyOrderID++;

            ////



            //Serialize json
            string json = JsonConvert.SerializeObject(filtersearch, Formatting.Indented);

            //save data
            Helper.InsertData("INSERT INTO PhilipsMatrixFilter(JSONFilterSetUp, FilterLabel,UserID,OrderID) VALUES('" + json + "', '" + txtFavLabel.Text.ToUpper() + "','" + sUserID + "'," + MyOrderID + ")");
            m_FilterLabel = txtFavLabel.Text.ToUpper();


            DataView MyOrderR = GetData("SELECT OrderID,FilterID FROM PhilipsMatrixFilter ORDER BY OrderID DESC");

            foreach (DataRowView rowView in MyOrderR)
            {
                FilterID = Convert.ToInt32(rowView["FilterID"].ToString());
                break;
            }



            // SetUpFavList();           
            //PanAddFav.Visible = false;
            //PanRemoveFav.Visible = true;

            Response.Redirect("/Home?FavListID=" + FilterID);






        }
        catch (Exception ex)
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
            DataTable myTable = m_MyFullData.Table.Copy();
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




                //HTMLBuilder += "<td style='border-top:1px solid #ddd;' ></td>";                
                HTMLBuilder += "<td class='isp'style='border-top:1px solid #ddd;'>" + rowView["ISP"].ToString() + "</td>";
                HTMLBuilder += "<td class='modality'style='border-top:1px solid #ddd;'>" + rowView["AppType"].ToString() + "</td>";
                HTMLBuilder += "<td class='domain' style='border-top:1px solid #ddd;'>" + rowView["Domain"].ToString() + "</td>";
                HTMLBuilder += "<td class='module' style='border-top:1px solid #ddd;'>" + rowView["Module"].ToString() + "</td>";
                HTMLBuilder += "<td class='dataSetDef' style='border-top:1px solid #ddd;'>" + rowView["Definition"].ToString() + "</td>";

                HTMLBuilder += "</tr>";

                if (Session["UserType"].ToString() != null)
                {
                    if (Session["UserType"].ToString() == "VIEW")
                    {
                        break;
                    }
                }


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
        DataView myDV = null;

        try
        {


            myDV = Helper.GetData(sql);

        }
        catch (Exception ex)
        {

            string sds = ex.Message;

        }

        return myDV;
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
                    m_BuildAppType += ",'US'";

                }
                else
                {
                    m_BuildAppType += "'US'";
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


            if (Session["UserType"] == null)
            {
                Response.Redirect("/Account/Signin");
            }

            switch (Session["MVMatrix"].ToString())
            {

                case "Super Viewer":
                case "Super Admin":
                case "ADMIN":
                    break;
                case "Content Admin":
                case "Editor":
                    break;
                case "Viewer":
                    chkCT.InputAttributes.Add("onchange", "javascript:ModalityCheck(this, 'chkCT');");
                    chkMR.InputAttributes.Add("onchange", "javascript:ModalityCheck(this, 'chkMR');");
                    chkMMV.InputAttributes.Add("onchange", "javascript:ModalityCheck(this, 'chkMMV');");
                    chkNMSpect.InputAttributes.Add("onchange", "javascript:ModalityCheck(this, 'chkNMSpect');");
                    chkNMPet.InputAttributes.Add("onchange", "javascript:ModalityCheck(this, 'chkNMPet');");
                    break;
                default:
                    Response.Redirect("/Account/Signin");
                    break;
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

            //
            if (chkOthers.Checked == true)
            {
                if (m_BuildVendor != "")
                {
                    m_BuildVendor += ",'Others'";
                }
                else
                {
                    m_BuildVendor += ",'Others'";
                }
            }

            if (chkSamsung.Checked == true)
            {
                if (m_BuildVendor != "")
                {
                    m_BuildVendor += ",'Samsung'";
                }
                else
                {
                    m_BuildVendor += ",'Samsung'";
                }
            }

            if (chkSegami.Checked == true)
            {
                if (m_BuildVendor != "")
                {
                    m_BuildVendor += ",'Segami'";
                }
                else
                {
                    m_BuildVendor += ",'Segami'";
                }
            }

            if (chkMediso.Checked == true)
            {
                if (m_BuildVendor != "")
                {
                    m_BuildVendor += ",'Mediso'";
                }
                else
                {
                    m_BuildVendor += ",'Mediso'";
                }
            }

            if (chkElscint.Checked == true)
            {
                if (m_BuildVendor != "")
                {
                    m_BuildVendor += ",'Elscint'";
                }
                else
                {
                    m_BuildVendor += ",'Elscint'";
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

            if (Session["UserType"] == null)
            {
                Response.Redirect("/Account/Signin");
            }

            switch (Session["MVMatrix"].ToString())
            {
                case "Super Viewer":

                case "Super Admin":
                case "ADMIN":
                    break;
                case "Content Admin":
                case "Editor":
                    break;
                case "Viewer":
                case "VIEW":
                    chkISP9.InputAttributes.Add("onchange", "javascript:ISPCheck(this, 'chkISP9');");
                    chkISP10.InputAttributes.Add("onchange", "javascript:ISPCheck(this, 'chkISP10');");
                    chkSiemens.InputAttributes.Add("onchange", "javascript:VendorCheck(this, 'chkSiemens');");
                    chkGE.InputAttributes.Add("onchange", "javascript:VendorCheck(this, 'chkGE');");
                    chkToshiba.InputAttributes.Add("onchange", "javascript:VendorCheck(this, 'chkToshiba');");
                    chkOthers.InputAttributes.Add("onchange", "javascript:VendorCheck(this, 'chkOthers');");
                    chkSamsung.InputAttributes.Add("onchange", "javascript:VendorCheck(this, 'chkSamsung');");
                    chkMediso.InputAttributes.Add("onchange", "javascript:VendorCheck(this, 'chkMediso');");
                    chkElscint.InputAttributes.Add("onchange", "javascript:VendorCheck(this, 'chkElscint');");
                    chkSegami.InputAttributes.Add("onchange", "javascript:VendorCheck(this, 'chkSegami');");
                    break;
                default:
                    Response.Redirect("/Account/Signin");
                    break;
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


                DataView MyDV = GetData(SQL);

                chkboxModel.Items.Clear();


                int Idx = 0;
                foreach (DataRowView rowView in MyDV)
                {
                    if (rowView["Model"].ToString() != "")
                    {
                        chkboxModel.Items.Add(new ListItem(rowView["AppType"].ToString() + ": " + rowView["Model"].ToString(), rowView["Vendor"].ToString() + "|" + rowView["AppType"].ToString() + "|" + rowView["Model"].ToString()));
                    }
                }



                if (Session["UserType"] == null)
                {
                    Response.Redirect("/Account/Signin");
                }

                switch (Session["MVMatrix"].ToString())
                {
                    case "Super Viewer":

                    case "Super Admin":
                    case "ADMIN":
                        break;
                    case "Content Admin":
                    case "EDIT":
                    case "Editor":
                        break;
                    case "Viewer":
                    case "VIEW":
                        foreach (ListItem item in this.chkboxModel.Items)
                        {
                            item.Attributes.Add("onchange", "javascript:ModelCheck(this);");
                        }

                        break;
                    default:
                        Response.Redirect("/Account/Signin");
                        break;
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
            DataView MyDV = GetData(SQL);

            foreach (DataRowView rowView in MyDV)
            {
                if (rowView["Software"].ToString() != "")
                {
                    chkboxSoftware.Items.Add(new ListItem(rowView["Vendor"].ToString() + ": " + rowView["Software"].ToString(), rowView["AppType"].ToString() + "|" + rowView["Vendor"].ToString() + "|" + rowView["Software"].ToString()));
                }
            }

            if (Session["UserType"] == null)
            {
                Response.Redirect("/Account/Signin");
            }

            switch (Session["MVMatrix"].ToString())
            {
                case "Super Viewer":
                case "Content Admin":
                case "Super Admin":
                case "ADMIN":
                    break;
                case "Editor":
                case "EDIT":
                    break;
                case "Viewer":
                case "VIEW":
                    foreach (ListItem item in this.chkboxSoftware.Items)
                    {
                        item.Attributes.Add("onchange", "javascript:SoftwareCheck(this);");
                    }
                    break;
                default:
                    Response.Redirect("/Account/Signin");
                    break;
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
            DataView MyDV = GetData(SQL);

            foreach (DataRowView rowView in MyDV)
            {
                if (rowView["Definition"].ToString() != "")
                {
                    chkboxDefinition.Items.Add(new ListItem(rowView["Definition"].ToString(), rowView["AppType"].ToString() + "|" + rowView["Definition"].ToString()));
                    //ListDefinition.Items.Add(new ListItem(rowView["Definition"].ToString(), rowView["AppType"].ToString() + "|" + rowView["Definition"].ToString()));
                }
            }


            if (Session["UserType"] == null)
            {
                Response.Redirect("/Account/Signin");
            }

            switch (Session["MVMatrix"].ToString())
            {
                case "Super Viewer":
                case "Content Admin":
                case "Super Admin":
                case "ADMIN":
                    break;
                case "Editor":
                    break;
                case "Viewer":
                case "VIEW":
                    foreach (ListItem item in this.chkboxDefinition.Items)
                    {
                        item.Attributes.Add("onchange", "javascript:DefinitionCheck(this);");
                    }
                    break;
                default:
                    Response.Redirect("/Account/Signin");
                    break;
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
            DataView MyDV = GetData(SQL);

            foreach (DataRowView rowView in MyDV)
            {
                if (rowView["Domain"].ToString() != "")
                {
                    chkboxDomain.Items.Add(new ListItem(rowView["AppType"].ToString() + ": " + rowView["Domain"].ToString(), rowView["AppType"].ToString() + "|" + rowView["Domain"].ToString()));
                }
            }

            if (Session["UserType"] == null)
            {
                Response.Redirect("/Account/Signin");
            }

            switch (Session["MVMatrix"].ToString())
            {
                case "Super Viewer":
                case "Content Admin":
                case "Super Admin":
                case "ADMIN":
                    break;
                case "Editor":
                    break;
                case "Viewer":
                    break;
                default:
                    Response.Redirect("/Account/Signin");
                    break;
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
            DataView MyDV = GetData(SQL);

            foreach (DataRowView rowView in MyDV)
            {
                if (rowView["Module"].ToString() != "")
                {
                    chkboxModule.Items.Add(new ListItem(rowView["Module"].ToString(), rowView["AppType"].ToString() + "|" + rowView["Module"].ToString() + "|" + rowView["Domain"].ToString()));
                    //ListModule.Items.Add(new ListItem(rowView["Module"].ToString(), rowView["AppType"].ToString() + "|" + rowView["Module"].ToString()));
                }
            }


            if (Session["UserType"] == null)
            {
                Response.Redirect("/Account/Signin");
            }

            switch (Session["MVMatrix"].ToString())
            {
                case "Super Viewer":
                case "Content Admin":
                case "Super Admin":
                case "ADMIN":
                    break;
                case "Editor":
                    break;
                case "Viewer":
                    break;
                default:
                    Response.Redirect("/Account/Signin");
                    break;
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
            chkColDefinition.Checked = false;




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


            if (hidViewer.Value == "Viewer")
            {
                chkboxModel.Items[0].Selected = false;
                if (chkboxSoftware.SelectedValue == "NM-SPECT|DDD Diagnostic|DCMdllB_V18")
                {
                    chkboxSoftware.SelectedItem.Selected = false;
                }
            }

            //Model       
            string sSelectedModel = string.Empty;
            string sSelectedModule = string.Empty;


            try
            {

                if (chkISP5.Checked == true)
                {
                    if (m_ISPVersion != "")
                    {
                        m_ISPVersion += ",'5'";
                    }
                    else
                    {
                        m_ISPVersion += "'5'";
                    }
                }
                if (chkISP6.Checked == true)
                {
                    if (m_ISPVersion != "")
                    {
                        m_ISPVersion += ",'6'";
                    }
                    else
                    {
                        m_ISPVersion += "'6'";
                    }
                }
                if (chkISP7.Checked == true)
                {
                    if (m_ISPVersion != "")
                    {
                        m_ISPVersion += ",'7'";
                    }
                    else
                    {
                        m_ISPVersion += "'7'";
                    }
                }
                if (chkISP8.Checked == true)
                {
                    if (m_ISPVersion != "")
                    {
                        m_ISPVersion += ",'8'";
                    }
                    else
                    {
                        m_ISPVersion += "'8'";
                    }
                }

                if (chkISP9.Checked == true)
                {
                    if (m_ISPVersion != "")
                    {
                        m_ISPVersion += ",'9'";
                    }
                    else
                    {
                        m_ISPVersion += "'9'";
                    }
                }

                if (chkISP10.Checked == true)
                {
                    if (m_ISPVersion != "")
                    {
                        m_ISPVersion += ",'10'";
                    }
                    else
                    {
                        m_ISPVersion += "'10'";
                    }
                }

                if (chkISP11.Checked == true)
                {
                    if (m_ISPVersion != "")
                    {
                        m_ISPVersion += ",'11'";
                    }
                    else
                    {
                        m_ISPVersion += "'11'";
                    }
                }

            }
            catch
            {

                m_ISPVersion = "9";
            }


            int idx = 0;
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
                        sSelectedModule += "'" + item.Text + "'";
                    }
                    else
                    {
                        sSelectedModule += ",'" + item.Text + "'";
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

            string SQL1 = "SELECT PhilipsMatrix.PhilipsID, PhilipsMatrix.AppType, PhilipsMatrix.Domain, PhilipsMatrix.Module, PhilipsMatrix.Definition, PhilipsMatrix.SubApp, PhilipsMatrixData.PhilipsMatrixDataID, PhilipsMatrixData.Model,PhilipsMatrixData.ISP, PhilipsMatrixData.Software ";
            SQL1 += ",PhilipsMatrixData.Vendor";
            SQL1 += ", PhilipsMatrixData.DataElement,Notes FROM PhilipsMatrix INNER JOIN  PhilipsMatrixData ON PhilipsMatrix.PhilipsID = PhilipsMatrixData.PhilipsMatrixID WHERE Status=0 AND PhilipsMatrix.ISP in (" + m_ISPVersion + ") AND ";

            if (sSelectedModel != "")
            {
                SQL1 += "model in(" + sSelectedModel + ") ";
                UserAND = 1;
            }

            if (m_BuildVendor != "")
            {

                if (m_BuildVendor.Substring(0, 1) == ",")
                {
                    m_BuildVendor = m_BuildVendor.Substring(1);
                }


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


            m_MyFullData = Helper.GetData(SQL1);

            ///////////////////////////////////////////////////////////////////////////////////////////

            UserAND = 0;
            string SQL = "SELECT DISTINCT PhilipsMatrixData.Vendor, PhilipsMatrixData.Model, PhilipsMatrixData.Software, PhilipsMatrix.AppType FROM PhilipsMatrixData INNER JOIN PhilipsMatrix ON PhilipsMatrixData.PhilipsMatrixID = PhilipsMatrix.PhilipsID WHERE status=0 and PhilipsMatrix.ISP in (" + m_ISPVersion + ") AND ";

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

            TreeGrid.DataSource = this.GetDefaultData(MyDV);
            TreeGrid.Model.Columns = GetColumns();
            TreeGrid.DataBind();



            SetUpFavList();

        }
        catch (Exception ex)
        {
        }
    }


    private List<TreeGridColumn> GetColumns()
    {
        List<TreeGridColumn> list = new List<TreeGridColumn>();

        try
        {

            for (int i = 1; i < 18; i++)
            {
                TreeGridColumn obj = new TreeGridColumn();

                switch (i)
                {
                    case 1:
                        obj.Field = "PhilipsID";
                        obj.HeaderText = "PhilipsID";
                        obj.Width = Convert.ToInt16(0);
                        obj.AllowEditing = Convert.ToBoolean(false);
                        obj.AllowFiltering = Convert.ToBoolean(false);
                        obj.AllowFreezing = Convert.ToBoolean(false);
                        list.Add(obj);
                        break;
                    case 2:
                        obj.Field = "PhilipsMatrixDataID";
                        obj.HeaderText = "PhilipsMatrixDataID";
                        obj.Width = Convert.ToInt16(0);
                        obj.AllowEditing = Convert.ToBoolean(false);
                        obj.AllowFiltering = Convert.ToBoolean(false);
                        obj.AllowFreezing = Convert.ToBoolean(false);
                        list.Add(obj);
                        break;
                    case 3:
                        obj.Field = "Vendor";
                        obj.HeaderText = "Vendor";
                        obj.AllowFreezing = Convert.ToBoolean(true);
                        obj.ShowInColumnChooser = Convert.ToBoolean(true);
                        list.Add(obj);
                        break;
                    case 4:
                        obj.Field = "Model";
                        obj.HeaderText = "Model";
                        obj.Width = Convert.ToInt16(220);
                        obj.AllowFreezing = Convert.ToBoolean(true);
                        obj.ShowInColumnChooser = Convert.ToBoolean(true);
                        list.Add(obj);
                        break;
                    case 5:
                        obj.Field = "Software";
                        obj.HeaderText = "Software";
                        obj.AllowFreezing = Convert.ToBoolean(true);
                        obj.ShowInColumnChooser = Convert.ToBoolean(true);
                        list.Add(obj);
                        break;
                    case 6:
                        obj.Field = "DataElement";
                        obj.HeaderText = "DataElement";
                        obj.Visible = false;
                        obj.Width = Convert.ToInt16(50);
                        list.Add(obj);
                        break;
                    case 7:
                        obj.Field = "DataElement";
                        obj.HeaderText = "&#10004;";
                        obj.Width = Convert.ToInt16(50);
                        //obj.TemplateID = "colorBox";
                        //obj.IsTemplateColumn = Convert.ToBoolean(true);
                        obj.Visible = false;
                        list.Add(obj);
                        break;
                    case 8:
                        obj.Field = "ISP5";
                        obj.HeaderText = "ISP 5";
                        obj.Width = Convert.ToInt16(65);
                        obj.TemplateID = "colorBox";
                        obj.IsTemplateColumn = Convert.ToBoolean(true);
                        obj.TextAlign = Syncfusion.JavaScript.TextAlign.Center;
                        if (chkISP5.Checked == false)
                        {
                            obj.Visible = false;
                        }
                        list.Add(obj);
                        break;
                    case 9:
                        obj.Field = "ISP6";
                        obj.HeaderText = "ISP 6";
                        obj.Width = Convert.ToInt16(65);
                        obj.TemplateID = "colorBox";
                        obj.IsTemplateColumn = Convert.ToBoolean(true);
                        obj.TextAlign = Syncfusion.JavaScript.TextAlign.Center;
                        if (chkISP6.Checked == false)
                        {
                            obj.Visible = false;
                        }
                        list.Add(obj);
                        break;
                    case 10:
                        obj.Field = "ISP7";
                        obj.HeaderText = "ISP 7";
                        obj.Width = Convert.ToInt16(65);
                        obj.TemplateID = "colorBox";
                        obj.IsTemplateColumn = Convert.ToBoolean(true);
                        obj.TextAlign = Syncfusion.JavaScript.TextAlign.Center;
                        if (chkISP7.Checked == false)
                        {
                            obj.Visible = false;
                        }
                        list.Add(obj);
                        break;
                    case 11:
                        obj.Field = "ISP8";
                        obj.HeaderText = "ISP 8";
                        obj.Width = Convert.ToInt16(65);
                        obj.TemplateID = "colorBox";
                        obj.IsTemplateColumn = Convert.ToBoolean(true);
                        obj.TextAlign = Syncfusion.JavaScript.TextAlign.Center;
                        if (chkISP8.Checked == false)
                        {
                            obj.Visible = false;
                        }
                        list.Add(obj);
                        break;
                    case 12:
                        obj.Field = "ISP9";
                        obj.HeaderText = "ISP 9";
                        obj.Width = Convert.ToInt16(65);
                        obj.TemplateID = "colorBox";
                        obj.IsTemplateColumn = Convert.ToBoolean(true);
                        obj.TextAlign = Syncfusion.JavaScript.TextAlign.Center;
                        if (chkISP9.Checked == false)
                        {
                            obj.Visible = false;
                        }
                        list.Add(obj);
                        break;
                    case 13:
                        obj.Field = "ISP10";
                        obj.HeaderText = "ISP 10";
                        obj.Width = Convert.ToInt16(65);
                        obj.TemplateID = "colorBox";
                        obj.IsTemplateColumn = Convert.ToBoolean(true);
                        obj.TextAlign = Syncfusion.JavaScript.TextAlign.Center;

                        if (chkISP10.Checked == false)
                        {
                            obj.Visible = false;
                        }
                        list.Add(obj);
                        break;
                    case 14:
                        obj.Field = "ISP11";
                        obj.HeaderText = "ISP 11";
                        obj.Width = Convert.ToInt16(65);
                        obj.TemplateID = "colorBox";
                        obj.IsTemplateColumn = Convert.ToBoolean(true);
                        obj.TextAlign = Syncfusion.JavaScript.TextAlign.Center;

                        if (chkISP11.Checked == false)
                        {
                            obj.Visible = false;
                        }
                        list.Add(obj);
                        break;
                    case 15:
                        obj.Field = "AppType";
                        obj.HeaderText = "Modality";
                        obj.Width = Convert.ToInt16(75);
                        list.Add(obj);
                        break;
                    case 16:
                        obj.Field = "Domain";
                        obj.HeaderText = "Domain";
                        obj.Width = Convert.ToInt16(100);
                        list.Add(obj);
                        break;
                    case 17:
                        obj.Field = "Module";
                        obj.HeaderText = "Module";
                        obj.Width = Convert.ToInt16(260);
                        list.Add(obj);
                        break;
                    case 18:
                        obj.Field = "Definition";
                        obj.HeaderText = "Definition";
                        obj.Width = Convert.ToInt16(330);
                        list.Add(obj);
                        break;

                }



            }






        }
        catch { }




        //    using (var reader = command.ExecuteReader())
        //    {
        //        var indexOfCol1 = reader.GetOrdinal("Field");
        //        var indexOfCol2 = reader.GetOrdinal("HeaderText");
        //        var indexOfCol3 = reader.GetOrdinal("Width");
        //        var indexOfCol4 = reader.GetOrdinal("AllowEditing");
        //        var indexOfCol5 = reader.GetOrdinal("AllowFiltering");
        //        var indexOfCol6 = reader.GetOrdinal("AllowFreezing");
        //        var indexOfCol7 = reader.GetOrdinal("TemplateID");
        //        var indexOfCol8 = reader.GetOrdinal("IsTemplateColumn");
        //        while (reader.Read())
        //        {
        //            TreeGridColumn obj = new TreeGridColumn();
        //            obj.Field = reader.GetValue(indexOfCol1).ToString();
        //            obj.HeaderText = reader.GetValue(indexOfCol2).ToString();
        //            if (reader.GetValue(indexOfCol3).ToString() != "")
        //                obj.Width = Convert.ToInt16(reader.GetValue(indexOfCol3));
        //            if (reader.GetValue(indexOfCol4).ToString() != "")
        //                obj.AllowEditing = Convert.ToBoolean(reader.GetValue(indexOfCol4));
        //            if (reader.GetValue(indexOfCol5).ToString() != "")
        //                obj.AllowFiltering = Convert.ToBoolean(reader.GetValue(indexOfCol5));
        //            if (reader.GetValue(indexOfCol6).ToString() != "")
        //                obj.AllowFreezing = Convert.ToBoolean(reader.GetValue(indexOfCol6));
        //            obj.TemplateID = reader.GetValue(indexOfCol7).ToString();
        //            if (reader.GetValue(indexOfCol8).ToString() != "")
        //                obj.IsTemplateColumn = Convert.ToBoolean(reader.GetValue(indexOfCol8));
        //            list.Add(obj);
        //        }
        //        reader.Close();
        //    }
        //}


        // }
        return list;
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

        public string ISP5
        {
            get;
            set;
        }
        public string ISP6
        {
            get;
            set;
        }
        public string ISP7
        {
            get;
            set;
        }
        public string ISP8
        {
            get;
            set;
        }
        public string ISP9
        {
            get;
            set;
        }

        public string ISP10
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
    private List<BusinessObject> GetDefaultData(DataView MyDV)
    {

        List<int> ID_NOT_TO_USE = new List<int>();

        List<BusinessObject> BusinessObjectCollection = new List<BusinessObject>();
        BusinessObject Record1 = null;


        var PhilipsID = this.TreeGrid.Columns.FindIndex(col => col.Field == "PhilipsID");
        var PhilipsMatrixDataID = this.TreeGrid.Columns.FindIndex(col => col.Field == "PhilipsMatrixDataID");




        foreach (DataRowView rowView in MyDV)
        {


            Record1 = new BusinessObject()
            {
                PhilipsID = PhilipsID,
                PhilipsMatrixDataID = PhilipsMatrixDataID,
                Vendor = rowView["Vendor"].ToString(),
                Model = rowView["Model"].ToString(),
                Software = "",
                AppType = "",
                Children = new List<BusinessObject>(),
            };



            string model = rowView["Model"].ToString();
            string vendor = rowView["Vendor"].ToString();
            string software = rowView["Software"].ToString();


            DataView view = new DataView();
            DataTable myTable = m_MyFullData.Table.Copy();
            DataSet ds = new DataSet();
            ds.Tables.Add(myTable);

            view = ds.Tables[0].DefaultView;

            view.RowFilter = "model = '" + model + "' and vendor='" + vendor + "' and software='" + software + "'";

            //int idx = 0;
            foreach (DataRowView rowViewDetail in view)
            {

                string sDomain = rowViewDetail["Domain"].ToString();
                string sModule = rowViewDetail["Module"].ToString();
                string sModel = rowViewDetail["Model"].ToString();
                string sISP = rowViewDetail["ISP"].ToString();
                string sDisplayISP = sISP;



                //loop though for other ISP
                foreach (DataRowView dvRowOther in view)
                {


                    //AND (PhilipsMatrix.Domain = 'Standard') AND (PhilipsMatrix.Module = 'CT Viewer') AND(PhilipsMatrixData.Model = 'Siemens Definition/Definition AS+')
                    if (dvRowOther["Domain"].ToString() == sDomain & dvRowOther["Module"].ToString() == sModule &
                        dvRowOther["Model"].ToString() == sModel & dvRowOther["ISP"].ToString() != sISP)
                    {
                        ID_NOT_TO_USE.Add(Convert.ToInt32(dvRowOther["PhilipsMatrixDataID"]));
                        sDisplayISP += "," + dvRowOther["ISP"].ToString();
                    }

                }



                if (!ID_NOT_TO_USE.Contains(Convert.ToInt32(rowViewDetail["PhilipsMatrixDataID"])))
                {


                    BusinessObject Child1 = new BusinessObject()
                    {
                        PhilipsID = Convert.ToInt32(rowViewDetail["PhilipsID"].ToString()),
                        PhilipsMatrixDataID = Convert.ToInt32(rowViewDetail["PhilipsMatrixDataID"].ToString()),
                        //Vendor = rowViewDetail["Vendor"].ToString(),
                        Software = rowViewDetail["Software"].ToString(),
                        DataElement = rowViewDetail["DataElement"].ToString(),
                        AppType = rowViewDetail["AppType"].ToString(),
                        ISP5 = rowViewDetail["DataElement"].ToString(),
                        ISP6 = rowViewDetail["DataElement"].ToString(),
                        ISP7 = rowViewDetail["DataElement"].ToString(),
                        ISP8 = rowViewDetail["DataElement"].ToString(),
                        ISP9 = rowViewDetail["DataElement"].ToString(),
                        ISP10 = rowViewDetail["DataElement"].ToString(),
                        Domain = rowViewDetail["Domain"].ToString(),
                        Module = rowViewDetail["Module"].ToString(),
                        Definition = rowViewDetail["Definition"].ToString(),
                    };



                    Record1.Children.Add(Child1);

                }


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

            if (chkSegami.Checked == true)
            {
                IsChecked = true;
            }

            if (chkMediso.Checked == true)
            {
                IsChecked = true;
            }

            if (chkElscint.Checked == true)
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

                DataView MyList = GetData("Select * from PhilipsMatrixFilter where UserID='" + Session["UserID"].ToString() + "'");

                repFavList.DataSource = MyList;
                repFavList.DataBind();


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
                DataView MyFilter = GetData("select * from PhilipsMatrixFilter where FilterID=" + FavListID);
                string sJSONFilterSetUp = string.Empty;

                foreach (DataRowView rowViewFilter in MyFilter)
                {
                    m_FilterLabel = rowViewFilter["FilterLabel"].ToString();
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
                    for (int FilterSetUpidx = 0; FilterSetUpidx < m_filtersearchO.FilterSetUp.Count; FilterSetUpidx++)
                    {
                        switch (m_filtersearchO.FilterSetUp[FilterSetUpidx].ToString())
                        {
                            case "Green":
                                chkGreenFilter.Checked = true;
                                break;
                            case "Yellow":
                                chkYellowFilter.Checked = true;
                                break;
                            case "Red":
                                chkRedFilter.Checked = true;
                                break;
                            case "Orange":
                                chkOrangeFilter.Checked = true;
                                break;
                            case "White":
                                chkWhiteFilter.Checked = true;
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

                            PanAddFav.Visible = false;
                            PanRemoveFav.Visible = true;

                            TreeGrid.Visible = true;
                            mainPanel.Visible = false;

                        }
                    }
                }
                else
                {
                    PanAddFav.Visible = true;
                    PanRemoveFav.Visible = false;
                }

                if (SetUpFromDB == false)
                {
                    chkCT.Checked = true;
                    chkSiemens.Checked = true;

                    chkGreenFilter.Checked = true;
                    chkYellowFilter.Checked = true;
                    chkRedFilter.Checked = true;
                    chkWhiteFilter.Checked = true;
                    chkOrangeFilter.Checked = true;
                }


                chkISP9.Checked = true;
                SetupModality();
                SetUpVendor();
                SetUpSoftware();
                SetUpDomain();
                SetUpModule();
                SetUpListDefinition();
                SetUpColumnSelection();
                SetUpModel(1);
                SetUpFavList();


                if (SetUpFromDB == true)
                {
                    SetupGrid();
                }


            }
        }
        catch { }
    }

    protected void cmdSubmit_Click(object sender, EventArgs e)
    {
        try
        {

            chkWhiteFilter.Checked = true;
            chkRedFilter.Checked = true;
            chkYellowFilter.Checked = true;
            chkGreenFilter.Checked = true;
            chkOrangeFilter.Checked = true;

            TreeGrid.Visible = true;
            mainPanel.Visible = false;


            string vendor = CheckaVendorSelected();
            string Modality = CheckaModalitySelected();


            if (vendor == "" & Modality == "")
            {

                PanAddFav.Visible = true;
                PanRemoveFav.Visible = false;

                panFeedBack.Visible = false;
                SetupModality();
                SetUpVendor();


                if (Session["UserType"] == null)
                {
                    Response.Redirect("/Account/Signin");
                }
                
                switch (Session["MVMatrix"].ToString())
                {
                    case "Super Viewer":
                    case "Content Admin":
                    case "Super Admin":
                    case "ADMIN":
                        break;
                    case "Editor":
                        break;
                    case "Viewer":
                        foreach (ListItem item in this.chkboxModel.Items)
                        {
                            item.Attributes.Add("onchange", "javascript:ModelCheck(this);");
                        }

                        foreach (ListItem item in this.chkboxSoftware.Items)
                        {
                            item.Attributes.Add("onchange", "javascript:SoftwareCheck(this);");
                        }

                        foreach (ListItem item in this.chkboxModule.Items)
                        {
                            item.Attributes.Add("onchange", "javascript:ModuleCheck(this);");
                        }

                        foreach (ListItem item in this.chkboxDefinition.Items)
                        {
                            item.Attributes.Add("onchange", "javascript:DefinitionCheck(this);");
                        }

                        //foreach (ListItem item in this.chkboxDomain.Items)
                        //{
                        //    item.Attributes.Add("onchange", "javascript:DomainCheck(this);");
                        //}

                        break;
                    default:
                        Response.Redirect("/Account/Signin");
                        break;
                }



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


            if (Session["User"] != null)
            {
                if (Session["User"].ToString() != "")
                {
                    m_UserName = Session["User"].ToString();
                    m_UserID = Session["UserID"].ToString();                    
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
                        Response.Redirect("/MV-Matrix.aspx");

                    }
                }
            }


        }
        catch { }
    }

    protected void ddlSwitchUser_SelectedIndexChanged(object sender, EventArgs e)
    {
        try
        {


            string sSwitch = ddlSwitchUser.Text;

            Session["SwitchUser"] = "SwitchUser";
            Session["MVMatrix"] = sSwitch;



            Session["Competitors"] = sSwitch;
            Session["Clinical"] = sSwitch;
            Session["Enterprise"] = sSwitch;
            Session["Services"] = sSwitch;
            Session["Attachments"] = sSwitch;



            Response.Redirect("/MV-Matrix");


        }
        catch { }
    }

    protected void cmdLogout_Click(object sender, EventArgs e)
    {
        Response.Redirect("/Account/Signin?Type=LogOut");
    }

    private void SetupStartPage()
    {
        try
        {


            bool Signin = false;

            if (Session["User"] != null)
            {
                if (Session["User"] != null)
                {
                    if (Session["User"].ToString() != "")
                    {
                        m_UserName = Session["User"].ToString();
                        m_UserID = Session["UserID"].ToString();
                        Signin = true;
                    }
                }

                try
                {
                    if (Session["UserType"] != null)
                    {
                        hidViewer.Value = Session["MVMatrix"].ToString();
                    }
                }
                catch { }



                switch (hidViewer.Value)
                {
                    //case "Super Admin":
                    //    //PanSwitchUser.Visible = true;
                    //    PanISP.Visible = false;
                    //    PanISPNormal.Visible = true;
                    //    break;

                    case "Super Viewer":

                        PanelDataDef2.Visible = false;
                        PanelDataDef1.Visible = false;

                        RadioCss.Visible = false;
                        RadioJS.Visible = false;

                        PanISP.Visible = true;
                        PanISPNormal.Visible = false;
                        break;

                    case "Viewer":
                    case "VIEW":
                        PanISP.Visible = false;
                        PanISPNormal.Visible = true;

                        PanelDataDef2.Visible = false;
                        PanelDataDef1.Visible = false;

                        RadioCss.Visible = true;
                        RadioJS.Visible = true;

                        btnchkModality.Visible = false;
                        btnchkVendor.Visible = false;
                        chkboxModelToggle.Visible = false;
                        chkboxSoftwareToggle.Visible = false;

                        break;
                    default:
                        PanISP.Visible = false;
                        PanISPNormal.Visible = true;

                        PanelDataDef2.Visible = true;
                        PanelDataDef1.Visible = true;

                        RadioCss.Visible = false;
                        RadioJS.Visible = false;
                        break;

                }


                //if (Session["User"] != null & Session["User"].ToString() == "DB")
                //{
                //    m_UserName = Session["User"].ToString();
                //    Signin = true;
                //}
            }


            if (Signin == true)
            {
                try
                {
                    string EmailName = Request.Headers["Federation-UserPrincipalName"].ToString();
                    Helper.InsertTracking(m_UserID, "MVMatrix", EmailName);
                }
                catch
                {

                    Helper.InsertTracking(m_UserID, "MVMatrix", "");
                }


                TreeGrid.Visible = false;
                mainPanel.Visible = true;

                panFeedBack.Visible = false;
                PageSetUp();

                if (Session["MVMatrix"].ToString() == "Super Admin")
                {
                    PanSwitchUser.Visible = true;
                }
                else
                {
                    if (Session["SwitchUser"] != null)
                    {
                    }
                    else
                    {
                        PanSwitchUser.Visible = false;
                    }
                }


                if (Session["SwitchUser"] != null)
                {
                    ddlSwitchUser.SelectedValue = Session["MVMatrix"].ToString();
                }

            }
            else
            {
                Response.Redirect("/Account/Signin");
            }


        }
        catch { }
    }

    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {
            if (!IsPostBack)
            {

                SetupStartPage();

            }

            //cmdSubmit


        }
        catch { }
    }







}
