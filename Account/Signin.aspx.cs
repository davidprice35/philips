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


public partial class Account_Signin : System.Web.UI.Page
{

    private DataView GetData(string sql)
    {
        DataSet myDS = null;
        DataView myDV = null;

        try
        {

            string connStr = "server=91.208.99.2;user=travelma2_phil1;port=1220; database=travelma2_phil1; password=Monst3rlinksT";
            
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

    private void ValidateCodeOne()
    {
        try
        {

            string Code1_Email = string.Empty;

            try
            {


                Code1_Email = Request.Headers["Federation-UserPrincipalName"].ToString();
            }
            catch {

                Code1_Email = txtUser.Text;

            }


//Code1_Email="partner.jonny.ucko@philips.com";


            if (Code1_Email != "")
            {
                string SQLPhilips = "SELECT * FROM PhilipsMatrixUser WHERE(UserEmail = '" + Code1_Email + "')";
                DataView MyDVPhilips = GetData(SQLPhilips);

                if (MyDVPhilips.Count > 0)
                {
                    foreach (DataRowView rowView in MyDVPhilips)
                    {
                        if (rowView["UserType"].ToString() == "Pending")
                        {
                            //Session["User"] = rowView["UserName"].ToString();
                            //Session["UserID"] = rowView["UserID"].ToString();
                            //Session["UserType"] = rowView["UserType"].ToString();
                            Response.Redirect("/", true);
                        }
                        else
                        {
                            Session["User"] = rowView["UserName"].ToString();
                            Session["UserID"] = rowView["UserID"].ToString();
                            Session["UserType"] = rowView["UserType"].ToString();

                            Session["MVMatrix"] = rowView["MVMatrix"].ToString();
                            Session["Competitors"] = rowView["Competitors"].ToString();
                            Session["Clinical"] = rowView["Clinical"].ToString();                            
                            Session["Enterprise"] = rowView["Enterprise"].ToString();
                            Session["Services"] = rowView["Services"].ToString();
                            Session["Attachments"] = rowView["Attachments"].ToString();

                            Response.Redirect("/MV-Matrix.aspx", true);
                        }

                    }
                }
                else
                {

                    Response.Redirect("/Account/Register",true);
                    //Helper.InsertData("")

                    //Session["User"] = Code1_Email;
                    //Session["UserID"] = Code1_Email;
                    //Session["UserType"] = "VIEW";
                    //Response.Redirect("/MV-Matrix.aspx", true);
                }

            }


        }
        catch { }
    }


    protected void cmdSubmitPhilips_Click(object sender, EventArgs e)
    {
        try
        {


            string SQL = "SELECT * FROM PhilipsMatrixUser WHERE(UserName = '" + txtUser.Text + "') AND(UserPass = '" + txtPassword.Text.ToLower() + "')";
            DataView MyDV = GetData(SQL);

            if (MyDV.Count > 0)
            {
                foreach (DataRowView rowView in MyDV)
                {
                    Session["User"] = rowView["UserName"].ToString();
                    Session["UserID"] = rowView["UserID"].ToString();
                    Session["UserType"] = rowView["UserType"].ToString();
                    Response.Redirect("/MV-Matrix.aspx", true);
                }
            }
            else
            {
                ValidateCodeOne();
            }

            //else 





        }
        catch { }


    }



    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {

            if (Request.QueryString != null)
            {
                if (Request.QueryString["Type"] != null)
                {
                    if (Request.QueryString["Type"].ToString() == "LogOut")
                    {
                        Session["User"] = null;
                        Session["UserType"] = null;
                        Session["UserID"] = null;

                    }
                }
                else
                {
                    ValidateCodeOne();
                }
            }
            else
            {

                ValidateCodeOne();

            }

        }
        catch { }
    }

}