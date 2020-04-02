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


using Syncfusion.JavaScript.Web;

public partial class Admin_MVMatrix_Edit : System.Web.UI.Page
{
    public string m_UserName = string.Empty;





    private string GetMaxPhilipsID()
    {
        string MaxID = string.Empty;

        try {


            DataView MyDV = Helper.GetData("select max(PhilipsID) as maxID from PhilipsMatrix");

            foreach (DataRowView rowView in MyDV)
            {
                MaxID= rowView["maxID"].ToString();
            }

        }
        catch { }

        return MaxID;
    }
    protected void cmdCopy_Click(object sender, EventArgs e)
    {
        string sConvertData = string.Empty;
        try
        {

            if (txtNewISP.Text != "")
            {

                switch (cmdEditItem.Text)
                {
                    case "9.0":
                        sConvertData = "9";
                        break;
                    case "10.0":
                        sConvertData = "10";
                        break;
                    default:
                        sConvertData = cmdEditItem.Text.ToString();
                        break;
                }

                string SQL = "SELECT PhilipsID, AppType, Domain, Module, Definition, SubApp, ISP, Status FROM PhilipsMatrix WHERE(ISP = '" + sConvertData + "')";

                DataView mtDV = Helper.GetData(SQL);

                foreach (DataRowView rowView in mtDV)
                {
                    //Matrix
                    string PhilipsID = rowView["PhilipsID"].ToString();
                    string InsertID = string.Empty;
                    string MatrixData = "INSERT INTO PhilipsMatrix(AppType, Domain, Module, Definition, SubApp, ISP, Status) VALUES('" + rowView["AppType"].ToString() + "', '" + rowView["Domain"].ToString() + "', '" + rowView["Module"].ToString() + "', '" + rowView["Definition"].ToString() + "', '" + rowView["SubApp"].ToString() + "', '" + txtNewISP.Text + "', 1) ;SELECT LAST_INSERT_ID();";
                    DataView MyDVReturnID = Helper.GetData(MatrixData);

                    foreach (DataRowView rowViewNewID in MyDVReturnID)
                    {
                        InsertID = rowViewNewID["LAST_INSERT_ID()"].ToString();
                    }


                    string sMatrixData = "SELECT  Model, Software, Vendor, DataElement, Notes, AddtionalNotes, ISP FROM PhilipsMatrixData WHERE(PhilipsMatrixID = " + PhilipsID + ")";
                    DataView MyDVMatrixDat = Helper.GetData(sMatrixData);

                    foreach (DataRowView rMD in MyDVMatrixDat)
                    {
                        //Matrix Data
                        string InsertMatrixData = "INSERT INTO PhilipsMatrixData(PhilipsMatrixID, Model, Software, Vendor, DataElement, Notes, AddtionalNotes, ISP) VALUES(" + InsertID + ", '" + rMD["Model"].ToString() + "', '" + rMD["Software"].ToString() + "', '" + rMD["Vendor"].ToString() + "', '" + rMD["DataElement"].ToString() + "', '" + rMD["Notes"].ToString() + "', '" + rMD["AddtionalNotes"].ToString() + "', '" + txtNewISP.Text + "')";
                        Helper.InsertData(InsertMatrixData);
                    }




                }

                
                SetupPage();
                lblCopy.Text = "Data Copy Completed";
            }

        }
        catch { }
    }


    private void SetupPage()
    {
        try
        {

            string SQL = "SELECT DISTINCT ISP FROM PhilipsMatrix";
            DataView MyDV = Helper.GetData(SQL);
            cmdISP.Items.Clear();

            foreach (DataRowView rowView in MyDV)
            {
                if (rowView["ISP"].ToString() != "9" & rowView["ISP"].ToString() != "10" & rowView["ISP"].ToString() != "8" & rowView["ISP"].ToString() != "7" & rowView["ISP"].ToString() != "5" & rowView["ISP"].ToString() != "6")
                {
                    cmdISP.Items.Add(new ListItem(rowView["ISP"].ToString(), rowView["ISP"].ToString()));
                }
            }



            //////////////////////////////////////////////////
            ///
            cmdApproveList.Items.Clear();
            string SQLApprove = "SELECT DISTINCT ISP FROM PhilipsMatrix WHERE(Status = 1)";
            DataView MyDVApprove = Helper.GetData(SQLApprove);
            foreach (DataRowView rowViewA in MyDVApprove)
            {
                cmdApproveList.Items.Add(new ListItem(rowViewA["ISP"].ToString(), rowViewA["ISP"].ToString()));
            }

            lblCopy.Text = "";
        }
        catch { }
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

    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {
            //https://help.syncfusion.com/js/uploadbox/file-size

            bool Signin = false;

            if (Session["User"] != null)
            {
                if (Session["User"] != null)
                {
                    m_UserName = Session["User"].ToString();
                    //m_UserID = Session["UserID"].ToString();
                    Signin = true;
                }

            }

            if (!Page.IsPostBack)
            {

                SetupPage();

            }


        }
        catch { }
    }






    protected void cmdDelete_Click(object sender, EventArgs e)
    {
        try {

            Helper.InsertData("DELETE FROM PhilipsMatrix where ISP='"+ cmdISP.SelectedItem.Text+"'");
            Helper.InsertData("DELETE FROM PhilipsMatrixData where ISP='" + cmdISP.SelectedItem.Text + "'");
            SetupPage();

        }
        catch { }
    }

    protected void cmdApproveLink_Click(object sender, EventArgs e)
    {
        try
        {

           Helper.InsertData("UPDATE PhilipsMatrix SET Status = 0 WHERE(ISP = '"+ cmdApproveList.Text + "')");
           

        }
        catch { }
    }
}
