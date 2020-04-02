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
using MySql.Data.MySqlClient;
using System.Globalization;

public partial class Admin_UsageTracking : System.Web.UI.Page
{
    public string m_UserName = string.Empty;

    public int m_TotalVisits = 0;
    public int m_TotalMVMatrix = 0;
    public int m_TotalCompetitors = 0;
    public int m_TotalClinical = 0;
    public int m_TotalEnterprise = 0;
    public int m_TotalAttachments = 0;
    public int m_TotalServices = 0;

    public int m_TotalUniqueVisits = 0;
    public int m_TotalUniqueMVMatrix = 0;
    public int m_TotalUniqueCompetitors = 0;
    public int m_TotalUniqueClinical = 0;
    public int m_TotalUniqueEnterprise = 0;
    public int m_TotalUniqueAttachments = 0;
    public int m_TotalUniqueServices = 0;


    public string ShowProfileMenu()
    {
        string MyMenu = string.Empty;

        try
        {

            string MyProfile = "<a href='/Admin/UserProfile' class='view_prfl'>View profile <span><i class='fa fa-angle-right' aria-hidden='true'></i></span></a>";
            string MyTracking = "<a href='/Admin/UsageTracking' class='view_prfl'>View tracking <span><i class='fa fa-angle-right' aria-hidden='true'></i></span></a>";


            if (Session["UserType"] == null)
            {
                // Response.Redirect("/Account/Signin");
            }

            switch (Session["UserType"].ToString())
            {
                case "ADMIN":
                    MyMenu = MyProfile + MyTracking;
                    break;

                case "EDIT":

                    break;

                case "VIEW":

                    break;

                default:
                    //  Response.Redirect("/Account/Signin");
                    break;
            }





        }
        catch { }

        return MyMenu;
    }


    public string GetDepartmentTime()
    {
        string sHTML = string.Empty;
        string UserName = string.Empty;


        try
        {

            DateTime mydatefrom = DateTime.Parse(datepickerFrom.Text);
            DateTime mydateto = DateTime.Parse(datepickerTo.Text);

            string DateFrom = mydatefrom.ToString("yyyy-MM-dd");
            string DateTo = mydateto.ToString("yyyy-MM-dd");

            #region GetFullStats

            //string SQL = "SELECT DISTINCT Department FROM PhilipsAnalysisTracking WHERE(Department IS NOT NULL)"; 
            string SQL = "SELECT Department, PageName, COUNT(PageName) AS PCount,VisitDateTime FROM PhilipsAnalysisTracking GROUP BY Department,PageName Having Department IS NOT NULL and Department<>'' and (VisitDateTime >= '" + DateFrom + " 00:00:00') AND (VisitDateTime <= '" + DateTo + " 00:00:00')";

            DataView MyDV = Helper.GetData(SQL);
            #endregion


            SQL = "SELECT DISTINCT Department FROM PhilipsAnalysisTracking WHERE(Department IS NOT NULL)";
            //string SQL = "SELECT Department, PageName, COUNT(PageName) AS PCount FROM PhilipsAnalysisTracking GROUP BY Department,PageName Having Department IS NOT NULL";

            DataView MyDV1 = Helper.GetData(SQL);


            int idx = 0;

            foreach (DataRowView rowView in MyDV1)
            {
                //if (idx==0)
                //{
                //    //add total
                //    sHTML += "<td>" + rowView["Department"].ToString() + "</td>";
                //    sHTML += "<td>" + GetDepartmentStats(rowView["Department"].ToString(), "ALL", MyDV, true) + "</td>";
                //}else
                //{
                //    sHTML += "<td>" + GetDepartmentStats(rowView["Department"].ToString(), "MVMatrix", MyDV, false) + "</td>";
                //}
                sHTML += "<tr>";
                sHTML += "<td>" + GetDepartmentStats(rowView["Department"].ToString(), "List", MyDV, true) + "</td>";
                sHTML += "<td>" + GetDepartmentStats(rowView["Department"].ToString(), "ALL", MyDV, true) + "</td>";
                sHTML += "<td>" + GetDepartmentStats(rowView["Department"].ToString(), "MVMatrix", MyDV, true) + "</td>";
                sHTML += "<td>" + GetDepartmentStats(rowView["Department"].ToString(), "Competitors", MyDV, true) + "</td>";
                sHTML += "<td>" + GetDepartmentStats(rowView["Department"].ToString(), "Clinical", MyDV, true) + "</td>";
                sHTML += "<td>" + GetDepartmentStats(rowView["Department"].ToString(), "Enterprise", MyDV, true) + "</td>";
                sHTML += "<td>" + GetDepartmentStats(rowView["Department"].ToString(), "Services", MyDV, true) + "</td>";
                sHTML += "<td>" + GetDepartmentStats(rowView["Department"].ToString(), "Attachments", MyDV, true) + "</td>";

                sHTML += "</tr>";

                idx++;

            }







        }
        catch (Exception ex)
        {

        }

        return sHTML;
    }
    private string GetDepartmentStats(string Dep, string PageName, DataView MyDV, bool GetTotal)
    {
        int MyCount = 0;
        string MyStat = "";

        try
        {


            foreach (DataRowView rowView in MyDV)
            {

                switch (PageName)
                {

                    case "ALL":
                        if (Dep == rowView["Department"].ToString())
                        {
                            MyCount += Convert.ToInt32(rowView["PCount"].ToString());
                        }
                        break;
                    case "MVMatrix":
                        if (Dep == rowView["Department"].ToString() & PageName == rowView["PageName"].ToString())
                        {
                            MyCount += Convert.ToInt32(rowView["PCount"].ToString());
                        }
                        break;
                    case "Clinical":
                        if (Dep == rowView["Department"].ToString() & PageName == rowView["PageName"].ToString())
                        {
                            MyCount += Convert.ToInt32(rowView["PCount"].ToString());
                        }
                        break;
                    case "Competitors":
                        if (Dep == rowView["Department"].ToString() & PageName == rowView["PageName"].ToString())
                        {
                            MyCount += Convert.ToInt32(rowView["PCount"].ToString());
                        }
                        break;
                    case "Enterprise":
                        if (Dep == rowView["Department"].ToString() & PageName == rowView["PageName"].ToString())
                        {
                            MyCount += Convert.ToInt32(rowView["PCount"].ToString());
                        }
                        break;

                    case "Attachments":
                        if (Dep == rowView["Department"].ToString() & PageName == rowView["PageName"].ToString())
                        {
                            MyCount += Convert.ToInt32(rowView["PCount"].ToString());
                        }
                        break;
                    case "Services":
                        if (Dep == rowView["Department"].ToString() & PageName == rowView["PageName"].ToString())
                        {
                            MyCount += Convert.ToInt32(rowView["PCount"].ToString());
                        }
                        break;



                }

            }

            switch (PageName)
            {
                case "List":
                    MyStat = Dep;
                    break;
                //case "ALL":
                //    MyStat = MyCount.ToString();
                //    break;
                default:
                    MyStat = MyCount.ToString();
                    break;

            }




        }
        catch { }

        return MyStat;
    }
    private string GetLocationStats(string Dep, string PageName, DataView MyDV, bool GetTotal)
    {
        int MyCount = 0;
        string MyStat = "";

        try
        {


            foreach (DataRowView rowView in MyDV)
            {

                switch (PageName)
                {

                    case "ALL":
                        if (Dep == rowView["Country"].ToString())
                        {
                            MyCount += Convert.ToInt32(rowView["PCount"].ToString());
                        }
                        break;
                    case "MVMatrix":
                        if (Dep == rowView["Country"].ToString() & PageName == rowView["PageName"].ToString())
                        {
                            MyCount += Convert.ToInt32(rowView["PCount"].ToString());
                        }
                        break;
                    case "Clinical":
                        if (Dep == rowView["Country"].ToString() & PageName == rowView["PageName"].ToString())
                        {
                            MyCount += Convert.ToInt32(rowView["PCount"].ToString());
                        }
                        break;
                    case "Competitors":
                        if (Dep == rowView["Country"].ToString() & PageName == rowView["PageName"].ToString())
                        {
                            MyCount += Convert.ToInt32(rowView["PCount"].ToString());
                        }
                        break;
                    case "Enterprise":
                        if (Dep == rowView["Country"].ToString() & PageName == rowView["PageName"].ToString())
                        {
                            MyCount += Convert.ToInt32(rowView["PCount"].ToString());
                        }
                        break;

                    case "Attachments":
                        if (Dep == rowView["Country"].ToString() & PageName == rowView["PageName"].ToString())
                        {
                            MyCount += Convert.ToInt32(rowView["PCount"].ToString());
                        }
                        break;
                    case "Services":
                        if (Dep == rowView["Country"].ToString() & PageName == rowView["PageName"].ToString())
                        {
                            MyCount += Convert.ToInt32(rowView["PCount"].ToString());
                        }
                        break;



                }

            }

            switch (PageName)
            {
                case "List":
                    MyStat = Dep;
                    break;
                //case "ALL":
                //    MyStat = MyCount.ToString();
                //    break;
                default:
                    MyStat = MyCount.ToString();
                    break;

            }




        }
        catch { }

        return MyStat;
    }
    public string GetLocationTime()
    {
        string sHTML = string.Empty;
        string UserName = string.Empty;


        try
        {

            DateTime mydatefrom = DateTime.Parse(datepickerFrom.Text);
            DateTime mydateto = DateTime.Parse(datepickerTo.Text);

            string DateFrom = mydatefrom.ToString("yyyy-MM-dd");
            string DateTo = mydateto.ToString("yyyy-MM-dd");

            #region GetFullStats

            //string SQL = "SELECT DISTINCT Department FROM PhilipsAnalysisTracking WHERE(Department IS NOT NULL)"; 
            string SQL = "SELECT Country, PageName, COUNT(PageName) AS PCount FROM PhilipsAnalysisTracking WHERE (PhilipsAnalysisTracking.VisitDateTime >= '"+ DateFrom + " 00:00:00') AND (PhilipsAnalysisTracking.VisitDateTime <= '"+ DateTo + " 00:00:00')  GROUP BY Country,PageName Having Country IS NOT NULL";

            DataView MyDV = Helper.GetData(SQL);
            #endregion


            SQL = "SELECT DISTINCT Country FROM PhilipsAnalysisTracking WHERE(Country IS NOT NULL)";
            //string SQL = "SELECT Department, PageName, COUNT(PageName) AS PCount FROM PhilipsAnalysisTracking GROUP BY Department,PageName Having Department IS NOT NULL";

            DataView MyDV1 = Helper.GetData(SQL);


            int idx = 0;

            foreach (DataRowView rowView in MyDV1)
            {
                //if (idx==0)
                //{
                //    //add total
                //    sHTML += "<td>" + rowView["Department"].ToString() + "</td>";
                //    sHTML += "<td>" + GetDepartmentStats(rowView["Department"].ToString(), "ALL", MyDV, true) + "</td>";
                //}else
                //{
                //    sHTML += "<td>" + GetDepartmentStats(rowView["Department"].ToString(), "MVMatrix", MyDV, false) + "</td>";
                //}
                sHTML += "<tr>";
                sHTML += "<td>" + GetLocationStats(rowView["Country"].ToString(), "List", MyDV, true) + "</td>";
                sHTML += "<td>" + GetLocationStats(rowView["Country"].ToString(), "ALL", MyDV, true) + "</td>";
                sHTML += "<td>" + GetLocationStats(rowView["Country"].ToString(), "MVMatrix", MyDV, true) + "</td>";
                sHTML += "<td>" + GetLocationStats(rowView["Country"].ToString(), "Competitors", MyDV, true) + "</td>";
                sHTML += "<td>" + GetLocationStats(rowView["Country"].ToString(), "Clinical", MyDV, true) + "</td>";
                sHTML += "<td>" + GetLocationStats(rowView["Country"].ToString(), "Enterprise", MyDV, true) + "</td>";
                sHTML += "<td>" + GetLocationStats(rowView["Country"].ToString(), "Services", MyDV, true) + "</td>";
                sHTML += "<td>" + GetLocationStats(rowView["Country"].ToString(), "Attachments", MyDV, true) + "</td>";

                sHTML += "</tr>";

                idx++;

            }







        }
        catch (Exception ex)
        {

        }

        return sHTML;
    }
    private void GetUniqueVists()
    {
        try
        {

            
            DateTime mydatefrom = DateTime.ParseExact(datepickerFrom.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture);
            DateTime mydateto = DateTime.ParseExact(datepickerTo.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture);

            string DateFrom = mydatefrom.ToString("yyyy-MM-dd");
            string DateTo = mydateto.ToString("yyyy-MM-dd");

            string SQL = "SELECT DISTINCT PageName, UserID FROM PhilipsAnalysisTracking  WHERE  (VisitDateTime >= CONVERT(DATETIME, '" + DateFrom + " 00:00:00', 102)) AND (VisitDateTime <= CONVERT(DATETIME, '" + DateTo + " 00:00:00', 102))";
            DataView MyDV = Helper.GetData(SQL);


            // m_TotalUniqueVisits = MyDV.Count;

            foreach (DataRowView rowView in MyDV)
            {
                if (rowView["PageName"].ToString() == "MVMatrix")
                {
                    m_TotalUniqueMVMatrix++;
                    m_TotalUniqueVisits++;
                }

                if (rowView["PageName"].ToString() == "Clinical")
                {
                    m_TotalUniqueClinical++;
                    m_TotalUniqueVisits++;
                }

                if (rowView["PageName"].ToString() == "Competitors")
                {
                    m_TotalUniqueCompetitors++;
                    m_TotalUniqueVisits++;
                }

                if (rowView["PageName"].ToString() == "Services")
                {
                    m_TotalUniqueServices++;
                    m_TotalUniqueVisits++;
                }

                if (rowView["PageName"].ToString() == "Attachments")
                {
                    m_TotalUniqueAttachments++;
                    m_TotalUniqueVisits++;
                }

                if (rowView["PageName"].ToString() == "Enterprise")
                {
                    m_TotalUniqueEnterprise++;
                    m_TotalUniqueVisits++;
                }

            }

        }
        catch { }
    }

    private void GetTotalVists()
    {
        try
        {
            //2018-08-10

            DateTime mydatefrom = DateTime.Parse(datepickerFrom.Text);
            DateTime mydateto = DateTime.Parse(datepickerTo.Text);

            string DateFrom = mydatefrom.ToString("yyyy-MM-dd");
            string DateTo = mydateto.ToString("yyyy-MM-dd");


            string SQL = "SELECT TrackingID, PageName, UserID, VisitDateTime FROM PhilipsAnalysisTracking WHERE  (VisitDateTime >= '" + DateFrom + " 00:00:00') AND (VisitDateTime <= '" + DateTo + " 00:00:00')";
            DataView MyDV = Helper.GetData(SQL);

            m_TotalVisits = MyDV.Count;


            foreach (DataRowView rowView in MyDV)
            {
                if (rowView["PageName"].ToString() == "MVMatrix")
                {
                    m_TotalMVMatrix++;
                }

                if (rowView["PageName"].ToString() == "Clinical")
                {
                    m_TotalClinical++;
                }

                if (rowView["PageName"].ToString() == "Competitors")
                {
                    m_TotalCompetitors++;
                }

                if (rowView["PageName"].ToString() == "Services")
                {
                    m_TotalServices++;
                }

                if (rowView["PageName"].ToString() == "Attachments")
                {
                    m_TotalAttachments++;
                }

                if (rowView["PageName"].ToString() == "Enterprise")
                {
                    m_TotalEnterprise++;
                }

            }

        }
        catch (Exception ex)
        {

        }
    }

    public string GetVistitorTime()
    {
        string sHTML = string.Empty;
        string UserName = string.Empty;

        int TotalVisitor = 0;
        int TotalVisitorMVMatrix = 0;
        int TotalVisitorCompetitors = 0;
        int TotalVisitorClinical = 0;
        int TotalVisitorEnterprise = 0;
        int TotalVisitorAttachments = 0;
        int TotalVisitorServices = 0;

        try
        {

            DateTime mydatefrom = DateTime.Parse(datepickerFrom.Text);
            DateTime mydateto = DateTime.Parse(datepickerTo.Text);

            string DateFrom = mydatefrom.ToString("yyyy-MM-dd");
            string DateTo = mydateto.ToString("yyyy-MM-dd");


           // DateTime mydatefrom = DateTime.ParseExact(datepickerFrom.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture);
           // DateTime mydateto = DateTime.ParseExact(datepickerTo.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture);

            //string DateFrom = mydatefrom.ToString("yyyy-MM-dd");
            //string DateTo = mydateto.ToString("yyyy-MM-dd");

            string SQL = "SELECT DISTINCT PhilipsMatrixUser.UserID, PhilipsMatrixUser.UserName FROM PhilipsMatrixUser INNER JOIN PhilipsAnalysisTracking ON PhilipsMatrixUser.UserID = PhilipsAnalysisTracking.UserID ORDER BY PhilipsMatrixUser.UserName";
            DataView MyDV = Helper.GetData(SQL);


            foreach (DataRowView rowView in MyDV)
            {
                //rowView["UserID"].ToString();

                string SQLA = "SELECT  PhilipsMatrixUser.UserName, PhilipsAnalysisTracking.PageName, COUNT(PhilipsAnalysisTracking.PageName) AS Expr1 FROM PhilipsMatrixUser INNER JOIN PhilipsAnalysisTracking ON PhilipsMatrixUser.UserID = PhilipsAnalysisTracking.UserID WHERE (PhilipsMatrixUser.UserID =  " + rowView["UserID"].ToString() + " ) and (PhilipsAnalysisTracking.VisitDateTime >= '" + DateFrom + " 00:00:00') AND (PhilipsAnalysisTracking.VisitDateTime <= '" + DateTo + " 00:00:00') GROUP BY PhilipsMatrixUser.UserName, PhilipsAnalysisTracking.PageName ORDER BY PhilipsMatrixUser.UserName";
                DataView MyDVA = Helper.GetData(SQLA);

                if (MyDVA.Count > 0)
                {
                    foreach (DataRowView rowViewA in MyDVA)
                    {

                        UserName = rowViewA["UserName"].ToString();

                        switch (rowViewA["PageName"].ToString())
                        {
                            case "Clinical":
                                TotalVisitorClinical = Convert.ToInt32(rowViewA["Expr1"].ToString());
                                break;
                            case "Competitors":
                                TotalVisitorCompetitors = Convert.ToInt32(rowViewA["Expr1"].ToString());
                                break;
                            case "Enterprise":
                                TotalVisitorEnterprise = Convert.ToInt32(rowViewA["Expr1"].ToString());
                                break;
                            case "MVMatrix":
                                TotalVisitorMVMatrix = Convert.ToInt32(rowViewA["Expr1"].ToString());
                                break;
                            case "Attachments":
                                TotalVisitorAttachments = Convert.ToInt32(rowViewA["Expr1"].ToString());
                                break;
                            case "Services":
                                TotalVisitorServices = Convert.ToInt32(rowViewA["Expr1"].ToString());
                                break;
                        }

                    }


                    sHTML += "<tr>";

                    sHTML += "<td>" + UserName + "</td>";
                    sHTML += "<td>" + (TotalVisitorClinical + TotalVisitorCompetitors + TotalVisitorEnterprise + TotalVisitorMVMatrix + TotalVisitorAttachments + TotalVisitorServices) + "</td>";
                    sHTML += "<td>" + TotalVisitorMVMatrix + "</td>";
                    sHTML += "<td>" + TotalVisitorCompetitors + "</td>";
                    sHTML += "<td>" + TotalVisitorClinical + "</td>";
                    sHTML += "<td>" + TotalVisitorEnterprise + "</td>";
                    sHTML += "<td>" + TotalVisitorServices + "</td>";
                    sHTML += "<td>" + TotalVisitorAttachments + "</td>";

                    sHTML += "</tr>";

                }

            }

        }
        catch(Exception ex)
        {

        }

        return sHTML;
    }

    private void SetupPage()
    {
        try
        {




        }
        catch { }
    }


    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {

            if (!Page.IsPostBack)
            {
                datepickerFrom.Text = DateTime.Now.ToShortDateString();
                datepickerTo.Text = DateTime.Now.AddDays(7).ToShortDateString();
            }

            GetTotalVists();
            GetUniqueVists();
            GetVistitorTime();
        }
        catch { }
    }

    protected void cmdSearch_Click(object sender, EventArgs e)
    {
        try
        {

            GetTotalVists();
            GetUniqueVists();
            GetVistitorTime();

        }
        catch { }
    }
}