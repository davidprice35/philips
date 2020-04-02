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
                string sID = string.Empty;

                if (Request.QueryString != null)
                {
                    if (Request.QueryString["ID"] != "")
                    {
                        sID = Request.QueryString["ID"].ToString();
                    }
                }

            }


        }
        catch { }
    }




    protected void cmdCancel_Click(object sender, EventArgs e)
    {
        try
        {
            Response.Redirect("AttachmentsEdit.aspx");
        }
        catch { }
    }

    protected void cmdDelete_Click(object sender, EventArgs e)
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

            if (sID != "")
            {
                string sUpdate = "DELETE TOP (200) FROM PhilipsAttachments WHERE(PhilipsAttachmentsID = " + sID + ")";
                GetData(sUpdate);
            }

            Response.Redirect("AttachmentsEdit.aspx");
        }
        catch { }
    }
}