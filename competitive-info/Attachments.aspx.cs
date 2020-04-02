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

public partial class competitive_info_Attachments : System.Web.UI.Page
{
    public string m_UserName = string.Empty;
    public string m_UserID = string.Empty;
    public string m_UserType = string.Empty;

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

    public string GetFileDownload(object MyDataItem)
    {
        string myItem = string.Empty;
        
        try
        {

            if (MyDataItem.ToString() != "")
            {
                myItem = "/competitive-info/data/" + MyDataItem.ToString();                
            }


        }
        catch { }

        return myItem;

    }

    private void SetupPhilips()
    {
        try{

            string sPhilipsClinical = "SELECT  * FROM PhilipsAttachments WHERE(Name = 'Philips') AND(Type = 'Clinical') AND (Approve = 1)";
            DataView myDVPhilipsClinical = Helper.GetData(sPhilipsClinical);

            this.repPhillips_Clinical.DataSource = myDVPhilipsClinical;
            this.repPhillips_Clinical.DataBind();



            ///////////////////////////////

            string sPhilipsService = "SELECT  * FROM PhilipsAttachments WHERE(Name = 'Philips') AND(Type = 'Service') AND (Approve = 1)";
            DataView myDVPhilipsService = Helper.GetData(sPhilipsService);

            this.repPhillips_Service.DataSource = myDVPhilipsService;
            this.repPhillips_Service.DataBind();

            /////////////////////////////////////

            string sPhilipsEnterprise = "SELECT  * FROM PhilipsAttachments WHERE(Name = 'Philips') AND(Type = 'Enterprise') AND (Approve = 1)";
            DataView myDVPhilipsEnterprise = Helper.GetData(sPhilipsEnterprise);

            this.repPhillips_Enterprise.DataSource = myDVPhilipsEnterprise;
            this.repPhillips_Enterprise.DataBind();




        }
        catch{ }
    }

    private void SetupAgfa()
    {
        try
        {

            string sPhilipsClinical = "SELECT  * FROM PhilipsAttachments WHERE(Name = 'Agfa') AND(Type = 'Clinical') AND (Approve = 1)";
            DataView myDVPhilipsClinical = Helper.GetData(sPhilipsClinical);

            this.repAgfaClinical.DataSource = myDVPhilipsClinical;
            this.repAgfaClinical.DataBind();



            ///////////////////////////////

            string sPhilipsService = "SELECT  * FROM PhilipsAttachments WHERE(Name = 'Agfa') AND(Type = 'Service') AND (Approve = 1)";
            DataView myDVPhilipsService = Helper.GetData(sPhilipsService);

            this.repAgfaService.DataSource = myDVPhilipsService;
            this.repAgfaService.DataBind();

            /////////////////////////////////////

            string sPhilipsEnterprise = "SELECT  * FROM PhilipsAttachments WHERE(Name = 'Agfa') AND(Type = 'Enterprise' ) AND (Approve = 1)";
            DataView myDVPhilipsEnterprise = Helper.GetData(sPhilipsEnterprise);

            this.repAgfaEnterprise.DataSource = myDVPhilipsEnterprise;
            this.repAgfaEnterprise.DataBind();




        }
        catch { }
    }

    private void SetupTera()
    {
        try
        {

            string sClinical = "SELECT  * FROM PhilipsAttachments WHERE(Name = 'TeraRecon') AND(Type = 'Clinical') AND (Approve = 1)";
            DataView myDVClinical = Helper.GetData(sClinical);

            this.repTeraClinical.DataSource = myDVClinical;
            this.repTeraClinical.DataBind();

            
            ///////////////////////////////

            string sService = "SELECT  * FROM PhilipsAttachments WHERE(Name = 'TeraRecon') AND(Type = 'Service') AND (Approve = 1) ";
            DataView myDVService = Helper.GetData(sService);

            this.repTera_Service.DataSource = myDVService;
            this.repTera_Service.DataBind();

            /////////////////////////////////////

            string sEnterprise = "SELECT  * FROM PhilipsAttachments WHERE(Name = 'TeraRecon') AND(Type = 'Enterprise') AND (Approve = 1)";
            DataView myDVEnterprise = Helper.GetData(sEnterprise);

            this.repTera_Enterprise.DataSource = myDVEnterprise;
            this.repTera_Enterprise.DataBind();
        }
        catch { }
    }

    private void SetupSiemens()
    {
        try
        {

            string sClinical = "SELECT  * FROM PhilipsAttachments WHERE(Name = 'Siemens') AND(Type = 'Clinical') AND (Approve = 1)";
            DataView myDVClinical = Helper.GetData(sClinical);

            this.repSiemensClinical.DataSource = myDVClinical;
            this.repSiemensClinical.DataBind();


            ///////////////////////////////

            string sService = "SELECT  * FROM PhilipsAttachments WHERE(Name = 'Siemens') AND(Type = 'Service') AND (Approve = 1)";
            DataView myDVService = Helper.GetData(sService);

            this.repSiemensService.DataSource = myDVService;
            this.repSiemensService.DataBind();

            /////////////////////////////////////

            string sEnterprise = "SELECT  * FROM PhilipsAttachments WHERE(Name = 'Siemens') AND(Type = 'Enterprise') AND (Approve = 1)";
            DataView myDVEnterprise = Helper.GetData(sEnterprise);

            this.repSiemensEnterprise.DataSource = myDVEnterprise;
            this.repSiemensEnterprise.DataBind();
        }
        catch { }
    }

    private void SetupGE()
    {
        try
        {

            string sClinical = "SELECT  * FROM PhilipsAttachments WHERE(Name = 'GE') AND(Type = 'Clinical') AND (Approve = 1)";
            DataView myDVClinical = Helper.GetData(sClinical);

            this.repGEClinical.DataSource = myDVClinical;
            this.repGEClinical.DataBind();


            ///////////////////////////////

            string sService = "SELECT  * FROM PhilipsAttachments WHERE(Name = 'GE') AND(Type = 'Service') AND (Approve = 1)";
            DataView myDVService = Helper.GetData(sService);

            this.repGEService.DataSource = myDVService;
            this.repGEService.DataBind();

            /////////////////////////////////////

            string sEnterprise = "SELECT  * FROM PhilipsAttachments WHERE(Name = 'GE') AND(Type = 'Enterprise') AND (Approve = 1)";
            DataView myDVEnterprise = Helper.GetData(sEnterprise);

            this.repGEEnterprise.DataSource = myDVEnterprise;
            this.repGEEnterprise.DataBind();
        }
        catch { }
    }

    private void SetupCannon()
    {
        try
        {

            string sClinical = "SELECT  * FROM PhilipsAttachments WHERE(Name = 'Cannon') AND(Type = 'Clinical') AND (Approve = 1)";
            DataView myDVClinical = Helper.GetData(sClinical);

            this.repCannonClinical.DataSource = myDVClinical;
            this.repCannonClinical.DataBind();


            ///////////////////////////////

            string sService = "SELECT  * FROM PhilipsAttachments WHERE(Name = 'Cannon') AND(Type = 'Service') AND (Approve = 1)";
            DataView myDVService = Helper.GetData(sService);

            this.repCannonService.DataSource = myDVService;
            this.repCannonService.DataBind();

            /////////////////////////////////////

            string sEnterprise = "SELECT  * FROM PhilipsAttachments WHERE(Name = 'Cannon') AND(Type = 'Enterprise') AND (Approve = 1)";
            DataView myDVEnterprise = Helper.GetData(sEnterprise);

            this.repCannonEnterprise.DataSource = myDVEnterprise;
            this.repCannonEnterprise.DataBind();
        }
        catch { }
    }

    private void SetupOther()
    {
        try
        {

            string sPhilipsClinical = "SELECT  * FROM PhilipsAttachments WHERE(Name = 'Other') AND(Type = 'Clinical') AND (Approve = 1)";
            DataView myDVPhilipsClinical = Helper.GetData(sPhilipsClinical);

            this.repOtherClinical.DataSource = myDVPhilipsClinical;
            this.repOtherClinical.DataBind();



            ///////////////////////////////

            string sPhilipsService = "SELECT  * FROM PhilipsAttachments WHERE(Name = 'Other') AND(Type = 'Service') AND (Approve = 1)";
            DataView myDVPhilipsService = Helper.GetData(sPhilipsService);

            this.repOtherService.DataSource = myDVPhilipsService;
            this.repOtherService.DataBind();

            /////////////////////////////////////

            string sPhilipsEnterprise = "SELECT  * FROM PhilipsAttachments WHERE(Name = 'Other') AND(Type = 'Enterprise') AND (Approve = 1)";
            DataView myDVPhilipsEnterprise = Helper.GetData(sPhilipsEnterprise);

            this.repOtherEnterprise.DataSource = myDVPhilipsEnterprise;
            this.repOtherEnterprise.DataBind();




        }
        catch { }
    }

    protected void Page_Load(object sender, EventArgs e)
    {
        try {


            bool Signin = false;

            if (Session["User"] != null)
            {
                if (Session["User"] != null)
                {
                    m_UserName = Session["User"].ToString();
                    m_UserID = Session["UserID"].ToString();
                    m_UserType = Session["Attachments"].ToString();
                    Signin = true;
                }

            }


            if (Signin == true)
            {


            }
            else
            {
                Response.Redirect("/Account/Signin");
            }


            try
            {
                string EmailName = Request.Headers["Federation-UserPrincipalName"].ToString();
                Helper.InsertTracking(m_UserID, "Attachments", EmailName);
            }
            catch
            {

                Helper.InsertTracking(m_UserID, "Attachments", "");
            }
            

            SetupPhilips();

            SetupTera();

            SetupSiemens();

            SetupGE();
            SetupCannon();

            SetupAgfa();
            SetupOther();


        }
        catch { }
    }
}