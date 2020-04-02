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

public partial class competitive_info_AttachmentsEdit : System.Web.UI.Page
{

    public string m_UserName = string.Empty;

    private DataView GetData(string sql)
    {
        DataSet myDS = null;
        DataView myDV = null;

        try
        {


            //string connStr = "server=91.208.99.2;user=elephoco_video; database =elephoco_video; port =1197;password=PY-x9WrT";
            //MySqlConnection conn = new MySqlConnection(connStr);
            //try
            //{

            //    conn.Open();


            //    MySqlCommand cmd = new MySqlCommand(sql, conn);
            //    //MySqlDataReader rdr = cmd.ExecuteReader();

            //    using (MySqlDataReader rdr = cmd.ExecuteReader())
            //    {
            //        myDS = new DataSet();
            //        myDS.Tables.Add("Table1");

            //        //Load DataReader into the DataTable.
            //        myDS.Tables[0].Load(rdr);
            //        myDV = myDS.Tables[0].DefaultView;
            //    }

            //        //rdr.Close();



            //    //while (rdr.Read())
            //    //{
            //    //    //Console.WriteLine(rdr[0] + " -- " + rdr[1]);
            //    //    //<option value="UNITED KINGDOM">UNITED KINGDOM</option>
            //    //    Console.WriteLine("<option value='" + rdr[1] + "'>" + rdr[1] + "</option>");

            //    //}


            //}
            //catch (Exception ex)
            //{

            //}
            //conn.Close();




            DatabaseProviderFactory factory = new DatabaseProviderFactory();
            Database db = factory.Create("TSOConn");

            DbCommand dbCommandWrapper = db.GetSqlStringCommand(sql);
            myDS = db.ExecuteDataSet(dbCommandWrapper);
            myDV = myDS.Tables[0].DefaultView;


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


    protected void repDataGrid_ItemDataBound(object sender, RepeaterItemEventArgs e)
    {
        try
        {







        }
        catch (Exception ex)
        {

        }
    }

    private void SaveData(string sql)
    {

        try
        {
            DatabaseProviderFactory factory = new DatabaseProviderFactory();
            Database db = factory.Create("TSOConn");

            DbCommand dbCommandWrapper = db.GetSqlStringCommand(sql);
            db.ExecuteNonQuery(dbCommandWrapper);

        }
        catch (Exception ex)
        {
            string sds = ex.Message;
        }

    }



    protected void cmdAdd_Click(object sender, EventArgs e)
    {


        try
        {

            //cboName1.Text = "";
            //cboType1.Text = "";
            //cboFileDisplayName1.Text = "";

            //PanelNewRow.Visible = true;


        }
        catch (Exception ex)
        {

        }
    }

    protected void cmdCancel_Click(object sender, EventArgs e)
    {
        try
        {
            Response.Redirect("AttachmentsEdit.aspx");
        }
        catch { }
    }

    protected void cmdUpdate_Click(object sender, EventArgs e)
    {
        try
        {

            string sID = string.Empty;

            if (Request.QueryString != null)
            {
                if (Request.QueryString["ID"] != "")
                {
                    sID = Request.QueryString["ID"].ToString();
                }
            }


            ///get data to compare                
            string SQL = "select * from PhilipsAttachments where PhilipsAttachmentsID=" + sID;
            DataView MyDVOriginal = GetData(SQL);

            string Name = string.Empty;
            string Type = string.Empty;
            string FileDisplayName = string.Empty;

            foreach (DataRowView rowView in MyDVOriginal)
            {
                Name = rowView["Name"].ToString();
                Type = rowView["Type"].ToString();
                FileDisplayName = rowView["FileDisplayName"].ToString();
            }
            //////

            if (FileDisplayName != txtFileName.Text)
            {
                string SUpdateFileDisplayName = "INSERT  TOP (200) INTO PhilipsAttachmentsPendingUpdates( AttachmentsID, UpdateColumnName, NewDataUpdate, OldData,  UserID, UserName, Status, Type) VALUES(" + sID + ", 'FileDisplayName','" + txtFileName.Text + "', '" + FileDisplayName + "',  '" + Session["UserID"] + "', '" + Session["User"] + "', 1, 'Update')";
                Helper.InsertData(SUpdateFileDisplayName);

                SetupPage();
                Response.Redirect("AttachmentsEdit.aspx");
            }
            
                     
           


        }
        catch { }
    }
    protected void cmdSave_Click(object sender, EventArgs e)
    {
        try
        {

            string sID = string.Empty;

            if (Request.QueryString != null)
            {
                if (Request.QueryString["ID"] != "")
                {
                    sID = Request.QueryString["ID"].ToString();
                }
            }

            string SQL = "SELECT TOP 1 * FROM PhilipsAttachmentList order by PhilipsAttachmentListID desc";
            DataView myDV = GetData(SQL);
            string DisplayName = string.Empty;
            string FileLocation = string.Empty;

            foreach (DataRowView rowView in myDV)
            {
                DisplayName = rowView["FileDisplayName"].ToString();
                FileLocation = rowView["FileLocation"].ToString();
            }



            if (sID == "new")
            {

                string UpdateSQL = "INSERT  TOP (200) INTO PhilipsAttachments(Name, Type, FileDisplayName, FileLocation, Approve) VALUES('"+cboName1.Text+"', '"+ cboType1.Text+"', '" + DisplayName + "', '" + FileLocation + "', 1)";
                GetData(UpdateSQL);



                string GetTop = "SeLECT TOP(1) *  FROM  PhilipsAttachments ORDER BY PhilipsAttachmentsID DESC";
                DataView myTopDV = GetData(GetTop);
                foreach (DataRowView rowView in myTopDV)
                {
                    string PhilipsAttachmentsID = rowView["PhilipsAttachmentsID"].ToString();
                    Response.Redirect("AttachmentsEditFile?ID="+ PhilipsAttachmentsID, true);
                }
                
                    
            }
            else
            {


                string sUpdate = "UPDATE TOP (200) PhilipsAttachments SET FileDisplayName = '" + DisplayName + "', FileLocation = '" + FileLocation + "', Approve=9 WHERE(PhilipsAttachmentsID = " + sID + ")";
                GetData(sUpdate);

                ///get data to compare                
                string OldSQL = "select * from PhilipsAttachments where PhilipsAttachmentsID=" + sID;
                DataView MyDVOriginal = GetData(OldSQL);


                string OldFileDisplayName = string.Empty;

                foreach (DataRowView rowView in MyDVOriginal)
                {
                    OldFileDisplayName = rowView["FileDisplayName"].ToString();
                }
                //////


                if (OldFileDisplayName != txtFileName.Text)
                {
                    string SUpdateFileDisplayName = "INSERT  TOP (200) INTO PhilipsAttachmentsPendingUpdates( AttachmentsID, UpdateColumnName, NewDataUpdate, OldData, Comment, UserID, UserName, Status, Type) VALUES(" + sID + ", 'FileDisplayName','" + txtFileName.Text + "', '" + OldFileDisplayName + "', '" + Session["UserID"] + "', '" + Session["User"] + "', 1, 'Update')";
                    Helper.InsertData(SUpdateFileDisplayName);
                };

                SetupPage();                                                                                                  
            }

            

           

        }
        catch { }
    }


    private void SetupComboBox()
    {
        try {

            //string SQL = "select * from PhilipsAttachments ORDER BY PhilipsAttachmentsID DESC";
            //DataView MyDV = GetData(SQL);

            cboName1.Items.Clear();
            cboName1.Items.Add(new ListItem("Philips", "Philips"));
            cboName1.Items.Add(new ListItem("TeraRecon", "TeraRecon"));
            cboName1.Items.Add(new ListItem("Siemens Medical", "Siemens"));
            cboName1.Items.Add(new ListItem("GE", "GE"));
            cboName1.Items.Add(new ListItem("Cannon", "Cannon"));
            cboName1.Items.Add(new ListItem("Agfa", "Agfa"));

            cboType1.Items.Clear();
            cboType1.Items.Add(new ListItem("Clinical", "Clinical"));
            cboType1.Items.Add(new ListItem("Enterprise", "Enterprise"));
            cboType1.Items.Add(new ListItem("Service", "Service"));



        }
        catch { }
    }

    private void SetupPage()
    {
        bool Isnew = false;
        try
        {


            string sID = string.Empty;

            if (Request.QueryString != null)
            {
                if (Request.QueryString["ID"] != "")
                {
                    sID = Request.QueryString["ID"].ToString();
                }
            }


            if (sID=="new")
            {
                panAddNew.Visible = true;
                panEdit.Visible = false;
                Isnew = true;
                cmdSave.Text = "Add";
            }
            else
            {
                Isnew = false;
                panAddNew.Visible = false;
                panEdit.Visible = true;
                cmdSave.Text = "Save";
            }


            if (Isnew == false)
            {
                string sSQLData = "SELECT * FROM PhilipsAttachments where PhilipsAttachmentsID=" + sID;
                DataView myDV = GetData(sSQLData);

                foreach (DataRowView rowView in myDV)
                {
                    txtName.Text = rowView["Name"].ToString();
                    txtType.Text = rowView["Type"].ToString();
                    txtFileName.Text = rowView["FileDisplayName"].ToString();

                }
            }


            SetupComboBox();



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


    
}