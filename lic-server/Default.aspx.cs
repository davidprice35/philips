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
using System.IO;
using System.Globalization;
//using Syncfusion.JavaScript.Web;
using System.Xml.Serialization;
//using System.Xml;
using Newtonsoft.Json;


public partial class competitive_info_Competitors : System.Web.UI.Page
{
    List<KeyProjectData> KeyProjectData1 = new List<KeyProjectData>();
    List<KeyPortalData> KeyPortalDat1 = new List<KeyPortalData>();
    List<CoreData> CoreDat1 = new List<CoreData>();


    public string m_UserName = string.Empty;
    public string m_UserID = string.Empty;
    public string m_UserType = string.Empty;
    public string m_ID = string.Empty;


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


    [Serializable]
    public class KeyProjectData
    {
        public KeyProjectData()
        {

        }
        public KeyProjectData(string FirstName , string LastName, string Email)
        {
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.Email = Email;
          
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }       
    }

    [Serializable]
    public class KeyPortalData
    {
        public KeyPortalData()
        {

        }
        public KeyPortalData(string FirstName, string LastName, string Email)
        {
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.Email = Email;

        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
    }

    [Serializable]
    public class CoreData
    {
        public CoreData()
        {

        }
        public CoreData(string FirstName, string LastName, string Email)
        {
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.Email = Email;

        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
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
                //Response.Redirect("/Account/Signin");
            }

            switch (Session["Competitors"].ToString())
            {
                case "Super Admin":
                case "ADMIN":
                    MyMenu = MyProfile + MyTracking;
                    break;

                case "Editor":
                case "EDIT":

                    break;

                case "Super Viewer":
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

    protected void ddlSwitchUser_SelectedIndexChanged(object sender, EventArgs e)
    {
        try
        {


            //string sSwitch = ddlSwitchUser.Text;

            //Session["SwitchUser"] = "SwitchUser";
            //Session["Competitors"] = sSwitch;

            //Session["MVMatrix"] = sSwitch;            
            //Session["Clinical"] = sSwitch;
            //Session["Enterprise"] = sSwitch;
            //Session["Services"] = sSwitch;
            //Session["Attachments"] = sSwitch;

            // SetupStartPage();


            Response.Redirect("/competitive-info/Competitors");


        }
        catch { }
    }

   

   
    
    protected void cmdEdit_Click(object sender, EventArgs e)
    {
        try {

            //this.Grid1.ToolbarSettings.ShowToolbar = true;
            //this.Grid1.EditSettings.AllowEditing = true;

            //GetGridDBData();

            //this.Grid1.DataSource = PhilipsDataLST;
            //this.Grid1.DataBind();

        }
        catch { }
    }


    protected void cmdSave_Click(object sender, EventArgs e)
    {
        try {

            string xx = "sdsd";

            int KeyAccountCount = 0;
            int PortalSalesCount = 0;
            int ProjectCoreCount = 0;
            string KeyAccountJSON = string.Empty;
            string PortalJSON = string.Empty;
            string CoreJSON = string.Empty;


            if (Request.QueryString["id"] != null)
            {
                if (Request.QueryString["id"] != "")
                {
                    m_ID = Request.QueryString["id"].ToString();
                }
            }


            if (Session["KeyAccountCount"] != null)
            {
                KeyAccountCount = Convert.ToInt32(Session["KeyAccountCount"].ToString());

                for (int i = 1; i <= KeyAccountCount; i++)
                {
                    TextBox t1 = (TextBox)(this.FindControl("txtPortalKeyAccountFirstName" + i.ToString()));
                    TextBox t2 = (TextBox)(this.FindControl("txtPortalKeyAccountLastName" + i.ToString()));
                    TextBox t3 = (TextBox)(this.FindControl("txtPortalKeyAccountEmail" + i.ToString()));

                    KeyProjectData1.Add(new KeyProjectData { FirstName = t1.Text , LastName = t2.Text, Email=t3.Text });
                }


                //Serialize 
                KeyAccountJSON = JsonConvert.SerializeObject(KeyProjectData1, Formatting.Indented);

                //Deserialize 
                //KeyProjectData1 = JsonConvert.DeserializeObject<List<KeyProjectData>>(json);                                                          
            }

            if (Session["PortalSalesCount"] != null)
            {
                PortalSalesCount = Convert.ToInt32(Session["PortalSalesCount"].ToString());

                for (int i = 1; i <= PortalSalesCount; i++)
                {
                    TextBox t1 = (TextBox)(this.FindControl("txtPortalSalesFirstName" + i.ToString()));
                    TextBox t2 = (TextBox)(this.FindControl("txtPortalSalesLastName" + i.ToString()));
                    TextBox t3 = (TextBox)(this.FindControl("txtPortalSalesEmail" + i.ToString()));

                    KeyPortalDat1.Add(new KeyPortalData { FirstName = t1.Text, LastName = t2.Text, Email = t3.Text });
                }

                //Serialize 
                PortalJSON = JsonConvert.SerializeObject(KeyPortalDat1, Formatting.Indented);
            }

            if (Session["ProjectCoreCount"] != null)
            {
                ProjectCoreCount = Convert.ToInt32(Session["ProjectCoreCount"].ToString());

                for (int i = 1; i <= ProjectCoreCount; i++)
                {
                    TextBox t1 = (TextBox)(this.FindControl("txtProjectCoreFirstName" + i.ToString()));
                    TextBox t2 = (TextBox)(this.FindControl("txtProjectCoreLastName" + i.ToString()));
                    TextBox t3 = (TextBox)(this.FindControl("txtProjectCoreEmail" + i.ToString()));

                    CoreDat1.Add(new CoreData { FirstName = t1.Text, LastName = t2.Text, Email = t3.Text });
                }

                //Serialize 
                CoreJSON = JsonConvert.SerializeObject(CoreDat1, Formatting.Indented);
            }

            string SQL = string.Empty;
            
            if (m_ID!="")
            {
                SQL = "UPDATE PhilipsLic_Project  set project_name='"+ txtProjectName.Text + "' , customer_key_account='"+ KeyAccountJSON + "' , customer_portalsales='" + PortalJSON + "',  customer_project_core='" + CoreJSON + "'   where PhilipsLic_ProjectID=" + m_ID;
                Helper.InsertData(SQL);
                Response.Redirect("/lic-server/ISPConcerto.aspx?id=" + m_ID, true);
            }
            else
            {
                SQL = "INSERT INTO PhilipsLic_Project(project_name,customer_name,customer_address,customer_country,customer_po,customer_comments,customer_key_account,customer_portalsales,customer_project_core) VALUES('" + txtProjectName.Text + "','" + txtCustomerName.Text + "','" + txtCustomerAddress.Text + "','" + txtCountry.SelectedValue.ToString() + "','" + txtPONumber.Text + "','" + txtCommentBox.Text + "','" + KeyAccountJSON + "','" + PortalJSON + "','" + CoreJSON + "')";
                Helper.InsertData(SQL);

                SQL = "SELECT PhilipsLic_ProjectID FROM travelma2_phil1.PhilipsLic_Project order by PhilipsLic_ProjectID desc limit 1";
                DataView MyDV = Helper.GetData(SQL);
               
                foreach (DataRowView rowView in MyDV)
                {
                    m_ID = rowView["PhilipsLic_ProjectID"].ToString();
                }

            }

         

            


            Response.Redirect("/lic-server/ISPConcerto.aspx?id=" + m_ID, true);

        }
        catch { }
    }

    protected void cmdCancel_Click(object sender, EventArgs e)
    {

    }


    protected void lnkKeyAccount_Click(object sender, EventArgs e)
    {
        
        try
        {


            if (Session["KeyAccountCount"] == null)
            {
                Session["KeyAccountCount"] = 2;
            }
            else
            {
                int idx = Convert.ToInt32(Session["KeyAccountCount"].ToString());
                idx++;
                Session["KeyAccountCount"] = idx;
            }


            if (Session["KeyAccountCount"].ToString() != "11")
            {

                switch (Session["KeyAccountCount"].ToString())
                {
                    case "2":
                        txtPortalKeyAccountFirstName2.Visible = true;
                        txtPortalKeyAccountLastName2.Visible = true;
                        txtPortalKeyAccountEmail2.Visible = true;
                        lnktxtPortalKeyAccountDelete2.Visible = true;
                        break;
                    case "3":
                        txtPortalKeyAccountFirstName2.Visible = true;
                        txtPortalKeyAccountLastName2.Visible = true;
                        txtPortalKeyAccountEmail2.Visible = true;                        
                        txtPortalKeyAccountFirstName3.Visible = true;
                        txtPortalKeyAccountLastName3.Visible = true;
                        txtPortalKeyAccountEmail3.Visible = true;
                        lnktxtPortalKeyAccountDelete3.Visible = true;

                        break;

                    case "4":
                        txtPortalKeyAccountFirstName2.Visible = true;
                        txtPortalKeyAccountLastName2.Visible = true;
                        txtPortalKeyAccountEmail2.Visible = true;

                        txtPortalKeyAccountFirstName3.Visible = true;
                        txtPortalKeyAccountLastName3.Visible = true;
                        txtPortalKeyAccountEmail3.Visible = true;

                        txtPortalKeyAccountFirstName4.Visible = true;
                        txtPortalKeyAccountLastName4.Visible = true;
                        txtPortalKeyAccountEmail4.Visible = true;
                        lnktxtPortalKeyAccountDelete4.Visible = true;


                        break;

                    case "5":
                        txtPortalKeyAccountFirstName2.Visible = true;
                        txtPortalKeyAccountLastName2.Visible = true;
                        txtPortalKeyAccountEmail2.Visible = true;
                        lnktxtPortalKeyAccountDelete2.Visible = true;

                        txtPortalKeyAccountFirstName3.Visible = true;
                        txtPortalKeyAccountLastName3.Visible = true;
                        txtPortalKeyAccountEmail3.Visible = true;
                        lnktxtPortalKeyAccountDelete3.Visible = true;

                        txtPortalKeyAccountFirstName4.Visible = true;
                        txtPortalKeyAccountLastName4.Visible = true;
                        txtPortalKeyAccountEmail4.Visible = true;
                        lnktxtPortalKeyAccountDelete4.Visible = true;

                        txtPortalKeyAccountFirstName5.Visible = true;
                        txtPortalKeyAccountLastName5.Visible = true;
                        txtPortalKeyAccountEmail5.Visible = true;
                        lnktxtPortalKeyAccountDelete5.Visible = true;

                        break;

                    case "6":
                        txtPortalKeyAccountFirstName2.Visible = true;
                        txtPortalKeyAccountLastName2.Visible = true;
                        txtPortalKeyAccountEmail2.Visible = true;
                        lnktxtPortalKeyAccountDelete2.Visible = true;

                        txtPortalKeyAccountFirstName3.Visible = true;
                        txtPortalKeyAccountLastName3.Visible = true;
                        txtPortalKeyAccountEmail3.Visible = true;
                        lnktxtPortalKeyAccountDelete3.Visible = true;

                        txtPortalKeyAccountFirstName4.Visible = true;
                        txtPortalKeyAccountLastName4.Visible = true;
                        txtPortalKeyAccountEmail4.Visible = true;
                        lnktxtPortalKeyAccountDelete4.Visible = true;

                        txtPortalKeyAccountFirstName5.Visible = true;
                        txtPortalKeyAccountLastName5.Visible = true;
                        txtPortalKeyAccountEmail5.Visible = true;
                        lnktxtPortalKeyAccountDelete5.Visible = true;

                        txtPortalKeyAccountFirstName6.Visible = true;
                        txtPortalKeyAccountLastName6.Visible = true;
                        txtPortalKeyAccountEmail6.Visible = true;
                        lnktxtPortalKeyAccountDelete6.Visible = true;
                        break;

                    case "7":
                        txtPortalKeyAccountFirstName2.Visible = true;
                        txtPortalKeyAccountLastName2.Visible = true;
                        txtPortalKeyAccountEmail2.Visible = true;
                        lnktxtPortalKeyAccountDelete2.Visible = true;

                        txtPortalKeyAccountFirstName3.Visible = true;
                        txtPortalKeyAccountLastName3.Visible = true;
                        txtPortalKeyAccountEmail3.Visible = true;
                        lnktxtPortalKeyAccountDelete3.Visible = true;

                        txtPortalKeyAccountFirstName4.Visible = true;
                        txtPortalKeyAccountLastName4.Visible = true;
                        txtPortalKeyAccountEmail4.Visible = true;
                        lnktxtPortalKeyAccountDelete4.Visible = true;

                        txtPortalKeyAccountFirstName5.Visible = true;
                        txtPortalKeyAccountLastName5.Visible = true;
                        txtPortalKeyAccountEmail5.Visible = true;
                        lnktxtPortalKeyAccountDelete5.Visible = true;

                        txtPortalKeyAccountFirstName6.Visible = true;
                        txtPortalKeyAccountLastName6.Visible = true;
                        txtPortalKeyAccountEmail6.Visible = true;
                        lnktxtPortalKeyAccountDelete6.Visible = true;

                        txtPortalKeyAccountFirstName7.Visible = true;
                        txtPortalKeyAccountLastName7.Visible = true;
                        txtPortalKeyAccountEmail7.Visible = true;
                        lnktxtPortalKeyAccountDelete7.Visible = true;
                        break;

                    case "8":
                        txtPortalKeyAccountFirstName2.Visible = true;
                        txtPortalKeyAccountLastName2.Visible = true;
                        txtPortalKeyAccountEmail2.Visible = true;
                        lnktxtPortalKeyAccountDelete2.Visible = true;

                        txtPortalKeyAccountFirstName3.Visible = true;
                        txtPortalKeyAccountLastName3.Visible = true;
                        txtPortalKeyAccountEmail3.Visible = true;
                        lnktxtPortalKeyAccountDelete3.Visible = true;

                        txtPortalKeyAccountFirstName4.Visible = true;
                        txtPortalKeyAccountLastName4.Visible = true;
                        txtPortalKeyAccountEmail4.Visible = true;
                        lnktxtPortalKeyAccountDelete4.Visible = true;

                        txtPortalKeyAccountFirstName5.Visible = true;
                        txtPortalKeyAccountLastName5.Visible = true;
                        txtPortalKeyAccountEmail5.Visible = true;
                        lnktxtPortalKeyAccountDelete5.Visible = true;

                        txtPortalKeyAccountFirstName6.Visible = true;
                        txtPortalKeyAccountLastName6.Visible = true;
                        txtPortalKeyAccountEmail6.Visible = true;
                        lnktxtPortalKeyAccountDelete6.Visible = true;

                        txtPortalKeyAccountFirstName7.Visible = true;
                        txtPortalKeyAccountLastName7.Visible = true;
                        txtPortalKeyAccountEmail7.Visible = true;
                        lnktxtPortalKeyAccountDelete7.Visible = true;

                        txtPortalKeyAccountFirstName8.Visible = true;
                        txtPortalKeyAccountLastName8.Visible = true;
                        txtPortalKeyAccountEmail8.Visible = true;
                        lnktxtPortalKeyAccountDelete8.Visible = true;
                        break;

                    case "9":
                        txtPortalKeyAccountFirstName2.Visible = true;
                        txtPortalKeyAccountLastName2.Visible = true;
                        txtPortalKeyAccountEmail2.Visible = true;
                        lnktxtPortalKeyAccountDelete2.Visible = true;

                        txtPortalKeyAccountFirstName3.Visible = true;
                        txtPortalKeyAccountLastName3.Visible = true;
                        txtPortalKeyAccountEmail3.Visible = true;
                        lnktxtPortalKeyAccountDelete3.Visible = true;

                        txtPortalKeyAccountFirstName4.Visible = true;
                        txtPortalKeyAccountLastName4.Visible = true;
                        txtPortalKeyAccountEmail4.Visible = true;
                        lnktxtPortalKeyAccountDelete4.Visible = true;

                        txtPortalKeyAccountFirstName5.Visible = true;
                        txtPortalKeyAccountLastName5.Visible = true;
                        txtPortalKeyAccountEmail5.Visible = true;
                        lnktxtPortalKeyAccountDelete5.Visible = true;

                        txtPortalKeyAccountFirstName6.Visible = true;
                        txtPortalKeyAccountLastName6.Visible = true;
                        txtPortalKeyAccountEmail6.Visible = true;
                        lnktxtPortalKeyAccountDelete6.Visible = true;

                        txtPortalKeyAccountFirstName7.Visible = true;
                        txtPortalKeyAccountLastName7.Visible = true;
                        txtPortalKeyAccountEmail7.Visible = true;
                        lnktxtPortalKeyAccountDelete7.Visible = true;

                        txtPortalKeyAccountFirstName8.Visible = true;
                        txtPortalKeyAccountLastName8.Visible = true;
                        txtPortalKeyAccountEmail8.Visible = true;
                        lnktxtPortalKeyAccountDelete8.Visible = true;

                        txtPortalKeyAccountFirstName9.Visible = true;
                        txtPortalKeyAccountLastName9.Visible = true;
                        txtPortalKeyAccountEmail9.Visible = true;
                        lnktxtPortalKeyAccountDelete9.Visible = true;
                        break;

                    case "10":
                        txtPortalKeyAccountFirstName2.Visible = true;
                        txtPortalKeyAccountLastName2.Visible = true;
                        txtPortalKeyAccountEmail2.Visible = true;
                        lnktxtPortalKeyAccountDelete2.Visible = true;

                        txtPortalKeyAccountFirstName3.Visible = true;
                        txtPortalKeyAccountLastName3.Visible = true;
                        txtPortalKeyAccountEmail3.Visible = true;
                        lnktxtPortalKeyAccountDelete3.Visible = true;

                        txtPortalKeyAccountFirstName4.Visible = true;
                        txtPortalKeyAccountLastName4.Visible = true;
                        txtPortalKeyAccountEmail4.Visible = true;
                        lnktxtPortalKeyAccountDelete4.Visible = true;

                        txtPortalKeyAccountFirstName5.Visible = true;
                        txtPortalKeyAccountLastName5.Visible = true;
                        txtPortalKeyAccountEmail5.Visible = true;
                        lnktxtPortalKeyAccountDelete5.Visible = true;

                        txtPortalKeyAccountFirstName6.Visible = true;
                        txtPortalKeyAccountLastName6.Visible = true;
                        txtPortalKeyAccountEmail6.Visible = true;
                        lnktxtPortalKeyAccountDelete6.Visible = true;

                        txtPortalKeyAccountFirstName7.Visible = true;
                        txtPortalKeyAccountLastName7.Visible = true;
                        txtPortalKeyAccountEmail7.Visible = true;
                        lnktxtPortalKeyAccountDelete7.Visible = true;

                        txtPortalKeyAccountFirstName8.Visible = true;
                        txtPortalKeyAccountLastName8.Visible = true;
                        txtPortalKeyAccountEmail8.Visible = true;
                        lnktxtPortalKeyAccountDelete8.Visible = true;

                        txtPortalKeyAccountFirstName9.Visible = true;
                        txtPortalKeyAccountLastName9.Visible = true;
                        txtPortalKeyAccountEmail9.Visible = true;
                        lnktxtPortalKeyAccountDelete9.Visible = true;

                        txtPortalKeyAccountFirstName10.Visible = true;
                        txtPortalKeyAccountLastName10.Visible = true;
                        txtPortalKeyAccountEmail10.Visible = true;
                        lnktxtPortalKeyAccountDelete10.Visible = true;

                        break;

                }

            }



          
        }
        catch { }
    }

    protected void lnkPortalSales_Click(object sender, EventArgs e)
    {
        //int numOfRows = 0;
        //int numOfColumns = 0;

        //int rowsCount = 1;
        //int colsCount = 1;

        try
        {


            if (Session["PortalSalesCount"] == null)
            {
                Session["PortalSalesCount"] = 2;
            }
            else
            {
                int idx = Convert.ToInt32(Session["PortalSalesCount"].ToString());
                idx++;
                Session["PortalSalesCount"] = idx;
            }


            if (Session["PortalSalesCount"].ToString() != "11")
            {

                switch (Session["PortalSalesCount"].ToString())
                {
                    case "2":
                        txtPortalSalesFirstName2.Visible = true;                        
                        txtPortalSalesLastName2.Visible = true;
                        txtPortalSalesEmail2.Visible = true;
                        lnkPortalSalesDelete2.Visible = true;
                        break;
                    case "3":
                        txtPortalSalesFirstName2.Visible = true;
                        txtPortalSalesLastName2.Visible = true;
                        txtPortalSalesEmail2.Visible = true;

                        txtPortalSalesFirstName3.Visible = true;
                        txtPortalSalesLastName3.Visible = true;
                        txtPortalSalesEmail3.Visible = true;

                        lnkPortalSalesDelete3.Visible = true;
                        break;

                    case "4":
                        txtPortalSalesFirstName2.Visible = true;
                        txtPortalSalesLastName2.Visible = true;
                        txtPortalSalesEmail2.Visible = true;

                        txtPortalSalesFirstName3.Visible = true;
                        txtPortalSalesLastName3.Visible = true;
                        txtPortalSalesEmail3.Visible = true;

                        txtPortalSalesFirstName4.Visible = true;
                        txtPortalSalesLastName4.Visible = true;
                        txtPortalSalesEmail4.Visible = true;

                        lnkPortalSalesDelete4.Visible = true;

                        break;

                    case "5":
                        txtPortalSalesFirstName2.Visible = true;
                        txtPortalSalesLastName2.Visible = true;
                        txtPortalSalesEmail2.Visible = true;

                        txtPortalSalesFirstName3.Visible = true;
                        txtPortalSalesLastName3.Visible = true;
                        txtPortalSalesEmail3.Visible = true;

                        txtPortalSalesFirstName4.Visible = true;
                        txtPortalSalesLastName4.Visible = true;
                        txtPortalSalesEmail4.Visible = true;

                        txtPortalSalesFirstName5.Visible = true;
                        txtPortalSalesLastName5.Visible = true;
                        txtPortalSalesEmail5.Visible = true;

                        lnkPortalSalesDelete5.Visible = true;
                        break;

                    case "6":
                        txtPortalSalesFirstName2.Visible = true;
                        txtPortalSalesLastName2.Visible = true;
                        txtPortalSalesEmail2.Visible = true;

                        txtPortalSalesFirstName3.Visible = true;
                        txtPortalSalesLastName3.Visible = true;
                        txtPortalSalesEmail3.Visible = true;

                        txtPortalSalesFirstName4.Visible = true;
                        txtPortalSalesLastName4.Visible = true;
                        txtPortalSalesEmail4.Visible = true;

                        txtPortalSalesFirstName5.Visible = true;
                        txtPortalSalesLastName5.Visible = true;
                        txtPortalSalesEmail5.Visible = true;

                        txtPortalSalesFirstName6.Visible = true;
                        txtPortalSalesLastName6.Visible = true;
                        txtPortalSalesEmail6.Visible = true;

                        lnkPortalSalesDelete6.Visible = true;
                        break;

                    case "7":
                        txtPortalSalesFirstName2.Visible = true;
                        txtPortalSalesLastName2.Visible = true;
                        txtPortalSalesEmail2.Visible = true;

                        txtPortalSalesFirstName3.Visible = true;
                        txtPortalSalesLastName3.Visible = true;
                        txtPortalSalesEmail3.Visible = true;

                        txtPortalSalesFirstName4.Visible = true;
                        txtPortalSalesLastName4.Visible = true;
                        txtPortalSalesEmail4.Visible = true;

                        txtPortalSalesFirstName5.Visible = true;
                        txtPortalSalesLastName5.Visible = true;
                        txtPortalSalesEmail5.Visible = true;

                        txtPortalSalesFirstName6.Visible = true;
                        txtPortalSalesLastName6.Visible = true;
                        txtPortalSalesEmail6.Visible = true;

                        txtPortalSalesFirstName7.Visible = true;
                        txtPortalSalesLastName7.Visible = true;
                        txtPortalSalesEmail7.Visible = true;

                        lnkPortalSalesDelete7.Visible = true;
                        break;

                    case "8":
                        txtPortalSalesFirstName2.Visible = true;
                        txtPortalSalesLastName2.Visible = true;
                        txtPortalSalesEmail2.Visible = true;

                        txtPortalSalesFirstName3.Visible = true;
                        txtPortalSalesLastName3.Visible = true;
                        txtPortalSalesEmail3.Visible = true;

                        txtPortalSalesFirstName4.Visible = true;
                        txtPortalSalesLastName4.Visible = true;
                        txtPortalSalesEmail4.Visible = true;

                        txtPortalSalesFirstName5.Visible = true;
                        txtPortalSalesLastName5.Visible = true;
                        txtPortalSalesEmail5.Visible = true;

                        txtPortalSalesFirstName6.Visible = true;
                        txtPortalSalesLastName6.Visible = true;
                        txtPortalSalesEmail6.Visible = true;

                        txtPortalSalesFirstName7.Visible = true;
                        txtPortalSalesLastName7.Visible = true;
                        txtPortalSalesEmail7.Visible = true;

                        txtPortalSalesFirstName8.Visible = true;
                        txtPortalSalesLastName8.Visible = true;
                        txtPortalSalesEmail8.Visible = true;

                        lnkPortalSalesDelete8.Visible = true;
                        break;

                    case "9":
                        txtPortalSalesFirstName2.Visible = true;
                        txtPortalSalesLastName2.Visible = true;
                        txtPortalSalesEmail2.Visible = true;

                        txtPortalSalesFirstName3.Visible = true;
                        txtPortalSalesLastName3.Visible = true;
                        txtPortalSalesEmail3.Visible = true;

                        txtPortalSalesFirstName4.Visible = true;
                        txtPortalSalesLastName4.Visible = true;
                        txtPortalSalesEmail4.Visible = true;

                        txtPortalSalesFirstName5.Visible = true;
                        txtPortalSalesLastName5.Visible = true;
                        txtPortalSalesEmail5.Visible = true;

                        txtPortalSalesFirstName6.Visible = true;
                        txtPortalSalesLastName6.Visible = true;
                        txtPortalSalesEmail6.Visible = true;

                        txtPortalSalesFirstName7.Visible = true;
                        txtPortalSalesLastName7.Visible = true;
                        txtPortalSalesEmail7.Visible = true;

                        txtPortalSalesFirstName8.Visible = true;
                        txtPortalSalesLastName8.Visible = true;
                        txtPortalSalesEmail8.Visible = true;

                        txtPortalSalesFirstName9.Visible = true;
                        txtPortalSalesLastName9.Visible = true;
                        txtPortalSalesEmail9.Visible = true;

                        lnkPortalSalesDelete9.Visible = true;

                        break;

                    case "10":
                        txtPortalSalesFirstName2.Visible = true;
                        txtPortalSalesLastName2.Visible = true;
                        txtPortalSalesEmail2.Visible = true;

                        txtPortalSalesFirstName3.Visible = true;
                        txtPortalSalesLastName3.Visible = true;
                        txtPortalSalesEmail3.Visible = true;

                        txtPortalSalesFirstName4.Visible = true;
                        txtPortalSalesLastName4.Visible = true;
                        txtPortalSalesEmail4.Visible = true;

                        txtPortalSalesFirstName5.Visible = true;
                        txtPortalSalesLastName5.Visible = true;
                        txtPortalSalesEmail5.Visible = true;

                        txtPortalSalesFirstName6.Visible = true;
                        txtPortalSalesLastName6.Visible = true;
                        txtPortalSalesEmail6.Visible = true;

                        txtPortalSalesFirstName7.Visible = true;
                        txtPortalSalesLastName7.Visible = true;
                        txtPortalSalesEmail7.Visible = true;

                        txtPortalSalesFirstName8.Visible = true;
                        txtPortalSalesLastName8.Visible = true;
                        txtPortalSalesEmail8.Visible = true;

                        txtPortalSalesFirstName9.Visible = true;
                        txtPortalSalesLastName9.Visible = true;
                        txtPortalSalesEmail9.Visible = true;

                        txtPortalSalesFirstName10.Visible = true;
                        txtPortalSalesLastName10.Visible = true;
                        txtPortalSalesEmail10.Visible = true;

                        lnkPortalSalesDelete10.Visible = true;
                        break;

                }

            }



            //TextBox tb1 = new TextBox();
            //tb1.ID = "1";
            //tb1.CssClass = "form-control";
            //Panel1.Controls.Add(tb1);

            ////TextBox tb4 = new TextBox();
            ////tb4.ID = "4";
            ////tb4.CssClass = "form-control";
            ////Panel1.Controls.Add(tb4);


            //TextBox tb2 = new TextBox();
            //tb2.ID = "2";
            //tb2.CssClass = "form-control";
            //Panel2.Controls.Add(tb2);
            //Panel2.Controls.Add(tb2);


            //TextBox tb3 = new TextBox();
            //tb3.ID = "3";
            //tb3.CssClass = "form-control";
            //Panel3.Controls.Add(tb3);
            //Panel3.Controls.Add(tb3);






        }
        catch { }
    }

    protected void lnkProjectCore_Click(object sender, EventArgs e)
    {
        try
        {


            if (Session["ProjectCoreCount"] == null)
            {
                Session["ProjectCoreCount"] = 2;
            }
            else
            {
                int idx = Convert.ToInt32(Session["ProjectCoreCount"].ToString());
                idx++;
                Session["ProjectCoreCount"] = idx;
            }


            if (Session["ProjectCoreCount"].ToString() != "11")
            {

                switch (Session["ProjectCoreCount"].ToString())
                {
                    case "1":
                        txtProjectCoreFirstName2.Visible = true;
                        txtProjectCoreLastName2.Visible = true;
                        txtProjectCoreEmail2.Visible = true;
                        lnkProjectCore2.Visible = true;
                        break;
                    case "2":
                        txtProjectCoreFirstName2.Visible = true;
                        txtProjectCoreLastName2.Visible = true;
                        txtProjectCoreEmail2.Visible = true;
                        lnkProjectCore2.Visible = true;
                        break;
                    case "3":
                        txtProjectCoreFirstName2.Visible = true;
                        txtProjectCoreLastName2.Visible = true;
                        txtProjectCoreEmail2.Visible = true;
                        txtProjectCoreFirstName3.Visible = true;
                        txtProjectCoreLastName3.Visible = true;
                        txtProjectCoreEmail3.Visible = true;
                        lnkProjectCore3.Visible = true;
                        
                        break;

                    case "4":
                        txtProjectCoreFirstName2.Visible = true;
                        txtProjectCoreLastName2.Visible = true;
                        txtProjectCoreEmail2.Visible = true;
                        lnkProjectCore2.Visible = true;

                        txtProjectCoreFirstName3.Visible = true;
                        txtProjectCoreLastName3.Visible = true;
                        txtProjectCoreEmail3.Visible = true;
                        lnkProjectCore3.Visible = true;

                        txtProjectCoreFirstName4.Visible = true;
                        txtProjectCoreLastName4.Visible = true;
                        txtProjectCoreEmail4.Visible = true;
                        lnkProjectCore4.Visible = true;

                        break;

                    case "5":
                        txtProjectCoreFirstName2.Visible = true;
                        txtProjectCoreLastName2.Visible = true;
                        txtProjectCoreEmail2.Visible = true;
                        lnkProjectCore2.Visible = true;

                        txtProjectCoreFirstName3.Visible = true;
                        txtProjectCoreLastName3.Visible = true;
                        txtProjectCoreEmail3.Visible = true;
                        lnkProjectCore3.Visible = true;

                        txtProjectCoreFirstName4.Visible = true;
                        txtProjectCoreLastName4.Visible = true;
                        txtProjectCoreEmail4.Visible = true;
                        lnkProjectCore4.Visible = true;

                        txtProjectCoreFirstName5.Visible = true;
                        txtProjectCoreLastName5.Visible = true;
                        txtProjectCoreEmail5.Visible = true;
                        lnkProjectCore5.Visible = true;
                        lnkProjectCore5.Visible = true;
                        break;

                    case "6":
                        txtProjectCoreFirstName2.Visible = true;
                        txtProjectCoreLastName2.Visible = true;
                        txtProjectCoreEmail2.Visible = true;
                        lnkProjectCore2.Visible = true;

                        txtProjectCoreFirstName3.Visible = true;
                        txtProjectCoreLastName3.Visible = true;
                        txtProjectCoreEmail3.Visible = true;
                        lnkProjectCore3.Visible = true;

                        txtProjectCoreFirstName4.Visible = true;
                        txtProjectCoreLastName4.Visible = true;
                        txtProjectCoreEmail4.Visible = true;
                        lnkProjectCore4.Visible = true;

                        txtProjectCoreFirstName5.Visible = true;
                        txtProjectCoreLastName5.Visible = true;
                        txtProjectCoreEmail5.Visible = true;
                        lnkProjectCore5.Visible = true;

                        txtProjectCoreFirstName6.Visible = true;
                        txtProjectCoreLastName6.Visible = true;
                        txtProjectCoreEmail6.Visible = true;
                        lnkProjectCore6.Visible = true;
                        
                        break;

                    case "7":
                        txtProjectCoreFirstName2.Visible = true;
                        txtProjectCoreLastName2.Visible = true;
                        txtProjectCoreEmail2.Visible = true;
                        lnkProjectCore2.Visible = true;

                        txtProjectCoreFirstName3.Visible = true;
                        txtProjectCoreLastName3.Visible = true;
                        txtProjectCoreEmail3.Visible = true;
                        lnkProjectCore3.Visible = true;

                        txtProjectCoreFirstName4.Visible = true;
                        txtProjectCoreLastName4.Visible = true;
                        txtProjectCoreEmail4.Visible = true;
                        lnkProjectCore4.Visible = true;

                        txtProjectCoreFirstName5.Visible = true;
                        txtProjectCoreLastName5.Visible = true;
                        txtProjectCoreEmail5.Visible = true;
                        lnkProjectCore5.Visible = true;

                        txtProjectCoreFirstName6.Visible = true;
                        txtProjectCoreLastName6.Visible = true;
                        txtProjectCoreEmail6.Visible = true;
                        lnkProjectCore6.Visible = true;

                        txtProjectCoreFirstName7.Visible = true;
                        txtProjectCoreLastName7.Visible = true;
                        txtProjectCoreEmail7.Visible = true;
                        lnkProjectCore7.Visible = true;
                        break;

                    case "8":
                        txtProjectCoreFirstName2.Visible = true;
                        txtProjectCoreLastName2.Visible = true;
                        txtProjectCoreEmail2.Visible = true;
                        lnkProjectCore2.Visible = true;

                        txtProjectCoreFirstName3.Visible = true;
                        txtProjectCoreLastName3.Visible = true;
                        txtProjectCoreEmail3.Visible = true;
                        lnkProjectCore3.Visible = true;

                        txtProjectCoreFirstName4.Visible = true;
                        txtProjectCoreLastName4.Visible = true;
                        txtProjectCoreEmail4.Visible = true;
                        lnkProjectCore4.Visible = true;

                        txtProjectCoreFirstName5.Visible = true;
                        txtProjectCoreLastName5.Visible = true;
                        txtProjectCoreEmail5.Visible = true;
                        lnkProjectCore5.Visible = true;

                        txtProjectCoreFirstName6.Visible = true;
                        txtProjectCoreLastName6.Visible = true;
                        txtProjectCoreEmail6.Visible = true;
                        lnkProjectCore6.Visible = true;

                        txtProjectCoreFirstName7.Visible = true;
                        txtProjectCoreLastName7.Visible = true;
                        txtProjectCoreEmail7.Visible = true;
                        lnkProjectCore7.Visible = true;

                        txtProjectCoreFirstName8.Visible = true;
                        txtProjectCoreLastName8.Visible = true;
                        txtProjectCoreEmail8.Visible = true;
                        lnkProjectCore8.Visible = true;
                        break;

                    case "9":
                        txtProjectCoreFirstName2.Visible = true;
                        txtProjectCoreLastName2.Visible = true;
                        txtProjectCoreEmail2.Visible = true;
                        lnkProjectCore2.Visible = true;

                        txtProjectCoreFirstName3.Visible = true;
                        txtProjectCoreLastName3.Visible = true;
                        txtProjectCoreEmail3.Visible = true;
                        lnkProjectCore3.Visible = true;

                        txtProjectCoreFirstName4.Visible = true;
                        txtProjectCoreLastName4.Visible = true;
                        txtProjectCoreEmail4.Visible = true;
                        lnkProjectCore4.Visible = true;

                        txtProjectCoreFirstName5.Visible = true;
                        txtProjectCoreLastName5.Visible = true;
                        txtProjectCoreEmail5.Visible = true;
                        lnkProjectCore5.Visible = true;

                        txtProjectCoreFirstName6.Visible = true;
                        txtProjectCoreLastName6.Visible = true;
                        txtProjectCoreEmail6.Visible = true;
                        lnkProjectCore6.Visible = true;

                        txtProjectCoreFirstName7.Visible = true;
                        txtProjectCoreLastName7.Visible = true;
                        txtProjectCoreEmail7.Visible = true;
                        lnkProjectCore7.Visible = true;

                        txtProjectCoreFirstName8.Visible = true;
                        txtProjectCoreLastName8.Visible = true;
                        txtProjectCoreEmail8.Visible = true;
                        lnkProjectCore8.Visible = true;

                        txtProjectCoreFirstName9.Visible = true;
                        txtProjectCoreLastName9.Visible = true;
                        txtProjectCoreEmail9.Visible = true;
                        lnkProjectCore9.Visible = true;
                        lnkProjectCore9.Visible = true;
                        break;

                    case "10":
                        txtProjectCoreFirstName2.Visible = true;
                        txtProjectCoreLastName2.Visible = true;
                        txtProjectCoreEmail2.Visible = true;
                        lnkProjectCore2.Visible = true;

                        txtProjectCoreFirstName3.Visible = true;
                        txtProjectCoreLastName3.Visible = true;
                        txtProjectCoreEmail3.Visible = true;
                        lnkProjectCore3.Visible = true;

                        txtProjectCoreFirstName4.Visible = true;
                        txtProjectCoreLastName4.Visible = true;
                        txtProjectCoreEmail4.Visible = true;
                        lnkProjectCore4.Visible = true;

                        txtProjectCoreFirstName5.Visible = true;
                        txtProjectCoreLastName5.Visible = true;
                        txtProjectCoreEmail5.Visible = true;
                        lnkProjectCore5.Visible = true;

                        txtProjectCoreFirstName6.Visible = true;
                        txtProjectCoreLastName6.Visible = true;
                        txtProjectCoreEmail6.Visible = true;
                        lnkProjectCore6.Visible = true;

                        txtProjectCoreFirstName7.Visible = true;
                        txtProjectCoreLastName7.Visible = true;
                        txtProjectCoreEmail7.Visible = true;
                        lnkProjectCore7.Visible = true;


                        txtProjectCoreFirstName8.Visible = true;
                        txtProjectCoreLastName8.Visible = true;
                        txtProjectCoreEmail8.Visible = true;
                        lnkProjectCore8.Visible = true;

                        txtProjectCoreFirstName9.Visible = true;
                        txtProjectCoreLastName9.Visible = true;
                        txtProjectCoreEmail9.Visible = true;
                        lnkProjectCore9.Visible = true;

                        txtProjectCoreFirstName10.Visible = true;
                        txtProjectCoreLastName10.Visible = true;
                        txtProjectCoreEmail10.Visible = true;
                        lnkProjectCore10.Visible = true;
                        break;

                }

            }




        }
        catch { }
    }



    protected void lnktxtPortalKeyAccountDelete1_Click(object sender, EventArgs e)
    {
        try
        {

            LinkButton button = sender as LinkButton;
            if (button != null)
            {
                string mybuttonID = button.ID;
                mybuttonID = mybuttonID.Replace("lnktxtPortalKeyAccountDelete", "");

                if (Session["KeyAccountCount"] == null)
                {
                    Session["KeyAccountCount"] = 2;
                }
                else
                {
                    int idx = Convert.ToInt32(Session["KeyAccountCount"].ToString());
                    idx--;
                    if (idx <= 0)
                    {
                        idx = 1;
                    }
                    Session["KeyAccountCount"] = idx;
                }

                


                if (Session["KeyAccountCount"].ToString() != "11")
                {

                    switch (mybuttonID)
                    {
                        case "1":
                            txtPortalKeyAccountFirstName2.Visible = false;
                            txtPortalKeyAccountLastName2.Visible = false;
                            txtPortalKeyAccountEmail2.Visible = false;
                            lnktxtPortalKeyAccountDelete2.Visible = false;
                            break;
                        case "2":
                            txtPortalKeyAccountFirstName2.Text = "";
                            txtPortalKeyAccountLastName2.Text = "";
                            txtPortalKeyAccountEmail2.Text = "";

                            txtPortalKeyAccountFirstName2.Visible = false;
                            txtPortalKeyAccountLastName2.Visible = false;
                            txtPortalKeyAccountEmail2.Visible = false;
                            lnktxtPortalKeyAccountDelete2.Visible = false;
                            break;
                        case "3":

                            txtPortalKeyAccountFirstName3.Text = "";
                            txtPortalKeyAccountLastName3.Text = "";
                            txtPortalKeyAccountEmail3.Text = "";

                            txtPortalKeyAccountFirstName3.Visible = false;
                            txtPortalKeyAccountLastName3.Visible = false;
                            txtPortalKeyAccountEmail3.Visible = false;
                            lnktxtPortalKeyAccountDelete3.Visible = false;

                            break;

                        case "4":

                            txtPortalKeyAccountFirstName4.Text = "";
                            txtPortalKeyAccountLastName4.Text = "";
                            txtPortalKeyAccountEmail4.Text = "";

                            txtPortalKeyAccountFirstName4.Visible = false;
                            txtPortalKeyAccountLastName4.Visible = false;
                            txtPortalKeyAccountEmail4.Visible = false;
                            lnktxtPortalKeyAccountDelete4.Visible = false;


                            break;

                        case "5":
                            txtPortalKeyAccountFirstName5.Text = "";
                            txtPortalKeyAccountLastName5.Text = "";
                            txtPortalKeyAccountEmail5.Text = "";

                            txtPortalKeyAccountFirstName5.Visible = false;
                            txtPortalKeyAccountLastName5.Visible = false;
                            txtPortalKeyAccountEmail5.Visible = false;

                            break;

                        case "6":

                            txtPortalKeyAccountFirstName6.Text = "";
                            txtPortalKeyAccountLastName6.Text = "";
                            txtPortalKeyAccountEmail6.Text = "";
                            txtPortalKeyAccountFirstName6.Visible = false;
                            txtPortalKeyAccountLastName6.Visible = false;
                            txtPortalKeyAccountEmail6.Visible = false;

                            break;

                        case "7":

                            txtPortalKeyAccountFirstName7.Text = "";
                            txtPortalKeyAccountLastName7.Text = "";
                            txtPortalKeyAccountEmail7.Text = "";
                            txtPortalKeyAccountFirstName7.Visible = false;
                            txtPortalKeyAccountLastName7.Visible = false;
                            txtPortalKeyAccountEmail7.Visible = false;

                            break;

                        case "8":

                            txtPortalKeyAccountFirstName8.Text = "";
                            txtPortalKeyAccountLastName8.Text = "";
                            txtPortalKeyAccountEmail8.Text = "";
                            txtPortalKeyAccountFirstName8.Visible = false;
                            txtPortalKeyAccountLastName8.Visible = false;
                            txtPortalKeyAccountEmail8.Visible = false;

                            break;

                        case "9":

                            txtPortalKeyAccountFirstName9.Text = "";
                            txtPortalKeyAccountLastName9.Text = "";
                            txtPortalKeyAccountEmail9.Text = "";
                            txtPortalKeyAccountFirstName9.Visible = false;
                            txtPortalKeyAccountLastName9.Visible = false;
                            txtPortalKeyAccountEmail9.Visible = false;

                            break;

                        case "10":

                            txtPortalKeyAccountFirstName10.Text = "";
                            txtPortalKeyAccountLastName10.Text = "";
                            txtPortalKeyAccountEmail10.Text = "";

                            txtPortalKeyAccountFirstName10.Visible = false;
                            txtPortalKeyAccountLastName10.Visible = false;
                            txtPortalKeyAccountEmail10.Visible = false;

                            break;

                    }

                }


            }

        }
        catch { }
    }

    protected void lnkPortalSalesDelete1_Click(object sender, EventArgs e)
    {
        try
        {

            LinkButton button = sender as LinkButton;
            if (button != null)
            {
                string mybuttonID = button.ID;
                mybuttonID = mybuttonID.Replace("lnkPortalSalesDelete", "");

                if (Session["PortalSalesCount"] == null)
                {
                    Session["PortalSalesCount"] = 2;
                }
                else
                {
                    int idx = Convert.ToInt32(Session["PortalSalesCount"].ToString());
                    idx--;
                    Session["PortalSalesCount"] = idx;
                }


                if (Session["PortalSalesCount"].ToString() != "11")
                {

                    switch (mybuttonID)
                    {
                        case "1":
                            txtPortalSalesFirstName2.Visible = false;
                            txtPortalSalesLastName2.Visible = false;
                            txtPortalSalesEmail2.Visible = false;
                            lnkPortalSalesDelete2.Visible = false;
                            break;
                        case "2":
                            txtPortalSalesFirstName2.Visible = false;
                            txtPortalSalesLastName2.Visible = false;
                            txtPortalSalesEmail2.Visible = false;
                            lnkPortalSalesDelete2.Visible = false;
                            break;
                        case "3":
                            

                            txtPortalSalesFirstName3.Visible = false;
                            txtPortalSalesLastName3.Visible = false;
                            txtPortalSalesEmail3.Visible = false;

                            lnkPortalSalesDelete3.Visible = false;
                            break;

                        case "4":
                            

                            txtPortalSalesFirstName4.Visible = false;
                            txtPortalSalesLastName4.Visible = false;
                            txtPortalSalesEmail4.Visible = false;

                            lnkPortalSalesDelete4.Visible = false;

                            break;

                        case "5":
                           

                            txtPortalSalesFirstName5.Visible = false;
                            txtPortalSalesLastName5.Visible = false;
                            txtPortalSalesEmail5.Visible = false;

                            lnkPortalSalesDelete5.Visible = false;
                            break;

                        case "6":
                           

                            txtPortalSalesFirstName6.Visible = false;
                            txtPortalSalesLastName6.Visible = false;
                            txtPortalSalesEmail6.Visible = false;

                            lnkPortalSalesDelete6.Visible = false;
                            break;

                        case "7":
                            

                            txtPortalSalesFirstName7.Visible = false;
                            txtPortalSalesLastName7.Visible = false;
                            txtPortalSalesEmail7.Visible = false;

                            lnkPortalSalesDelete7.Visible = false;
                            break;

                        case "8":
                          

                            txtPortalSalesFirstName8.Visible = false;
                            txtPortalSalesLastName8.Visible = false;
                            txtPortalSalesEmail8.Visible = false;

                            lnkPortalSalesDelete8.Visible = false;
                            break;

                        case "9":
                            

                            txtPortalSalesFirstName9.Visible = false;
                            txtPortalSalesLastName9.Visible = false;
                            txtPortalSalesEmail9.Visible = false;

                            lnkPortalSalesDelete9.Visible = false;

                            break;

                        case "10":
                            

                            txtPortalSalesFirstName10.Visible = false;
                            txtPortalSalesLastName10.Visible = false;
                            txtPortalSalesEmail10.Visible = false;

                            lnkPortalSalesDelete10.Visible = false;
                            break;

                    }

                }
            }

        }
        catch { }
    }

    protected void lnkProjectCore1_Click(object sender, EventArgs e)
    {
        try
        {

            LinkButton button = sender as LinkButton;
            if (button != null)
            {
                string mybuttonID = button.ID;
                mybuttonID = mybuttonID.Replace("lnkProjectCore", "");

                if (Session["ProjectCoreCount"] == null)
                {
                    Session["ProjectCoreCount"] = 2;
                }
                else
                {
                    int idx = Convert.ToInt32(Session["ProjectCoreCount"].ToString());
                    idx--;
                    Session["ProjectCoreCount"] = idx;
                }


                if (Session["ProjectCoreCount"].ToString() != "11")
                {

                    switch (mybuttonID)
                    {
                        case "2":
                            txtProjectCoreFirstName2.Visible = false;
                            txtProjectCoreLastName2.Visible = false;
                            txtProjectCoreEmail2.Visible = false;
                            lnkProjectCore2.Visible = false;
                            break;
                        case "3":
                            
                            txtProjectCoreFirstName3.Visible = false;
                            txtProjectCoreLastName3.Visible = false;
                            txtProjectCoreEmail3.Visible = false;
                            lnkProjectCore3.Visible = false;
                            break;

                        case "4":
                            

                            txtProjectCoreFirstName4.Visible = false;
                            txtProjectCoreLastName4.Visible = false;
                            txtProjectCoreEmail4.Visible = false;

                            lnkProjectCore4.Visible = false;

                            break;

                        case "5":
                            
                            txtProjectCoreFirstName5.Visible = false;
                            txtProjectCoreLastName5.Visible = false;
                            txtProjectCoreEmail5.Visible = false;
                            lnkProjectCore5.Visible = false;
                            break;

                        case "6":
                            
                            txtProjectCoreFirstName6.Visible = false;
                            txtProjectCoreLastName6.Visible = false;
                            txtProjectCoreEmail6.Visible = false;
                            lnkProjectCore6.Visible = false;
                            break;

                        case "7":
                            
                            txtProjectCoreFirstName7.Visible = false;
                            txtProjectCoreLastName7.Visible = false;
                            txtProjectCoreEmail7.Visible = false;
                            lnkProjectCore7.Visible = false;
                            break;

                        case "8":
                            
                            txtProjectCoreFirstName8.Visible = false;
                            txtProjectCoreLastName8.Visible = false;
                            txtProjectCoreEmail8.Visible = false;
                            lnkProjectCore8.Visible = false;
                            break;

                        case "9":
                           
                            txtProjectCoreFirstName9.Visible = false;
                            txtProjectCoreLastName9.Visible = false;
                            txtProjectCoreEmail9.Visible = false;
                            lnkProjectCore9.Visible = false;
                            break;

                        case "10":
                           
                            txtProjectCoreFirstName10.Visible = false;
                            txtProjectCoreLastName10.Visible = false;
                            txtProjectCoreEmail10.Visible = false;
                            lnkProjectCore10.Visible = false;
                            break;

                    }

                }
            }
        }
        catch { }
    }

    private void SetupPage()
    {
        try
        {

            if (Request.QueryString["id"] != null)
            {
                if (Request.QueryString["id"] != "")
                {
                    m_ID = Request.QueryString["id"].ToString();
                }
            }


            DataView myDV = Helper.GetData("Select * from PhilipsLic_Project where PhilipsLic_ProjectID=" + Request.QueryString["id"]);
            foreach (DataRowView rowView in myDV)
            {


                txtProjectName.Text = rowView["project_name"].ToString();
                txtCustomerName.Text = rowView["customer_name"].ToString();
                txtCustomerAddress.Text = rowView["customer_address"].ToString();
                txtCountry.SelectedValue = rowView["customer_country"].ToString();
                txtPONumber.Text = rowView["customer_po"].ToString();
                txtCommentBox.Text = rowView["customer_comments"].ToString();


                KeyProjectData1 = JsonConvert.DeserializeObject<List<KeyProjectData>>(rowView["customer_key_account"].ToString());
                for (int ixa = 0; ixa <= KeyProjectData1.Count - 1; ixa++)
                {
                    switch (ixa)
                    {
                        case 0:
                            txtPortalKeyAccountFirstName1.Text = KeyProjectData1[ixa].FirstName;
                            txtPortalKeyAccountLastName1.Text = KeyProjectData1[ixa].LastName;
                            txtPortalKeyAccountEmail1.Text = KeyProjectData1[ixa].Email;

                            break;
                        case 1:
                            txtPortalKeyAccountFirstName2.Text = KeyProjectData1[ixa].FirstName;
                            txtPortalKeyAccountLastName2.Text = KeyProjectData1[ixa].LastName;
                            txtPortalKeyAccountEmail2.Text = KeyProjectData1[ixa].Email; ;
                            txtPortalKeyAccountEmail2.Visible = true;
                            txtPortalKeyAccountLastName2.Visible = true;
                            txtPortalKeyAccountFirstName2.Visible = true;
                            lnktxtPortalKeyAccountDelete2.Visible = true;

                            Session["KeyAccountCount"] = 2; 

                            break;
                        case 2:
                            txtPortalKeyAccountFirstName3.Text = KeyProjectData1[ixa].FirstName;
                            txtPortalKeyAccountLastName3.Text = KeyProjectData1[ixa].LastName;
                            txtPortalKeyAccountEmail3.Text = KeyProjectData1[ixa].Email;
                            txtPortalKeyAccountEmail3.Visible = true;
                            txtPortalKeyAccountLastName3.Visible = true;
                            txtPortalKeyAccountFirstName3.Visible = true;
                            lnktxtPortalKeyAccountDelete3.Visible = true;
                            Session["KeyAccountCount"] = 3;
                            break;
                        case 3:
                            txtPortalKeyAccountFirstName4.Text = KeyProjectData1[ixa].FirstName;
                            txtPortalKeyAccountLastName4.Text = KeyProjectData1[ixa].LastName;
                            txtPortalKeyAccountEmail4.Text = KeyProjectData1[ixa].Email;
                            txtPortalKeyAccountEmail4.Visible = true;
                            txtPortalKeyAccountLastName4.Visible = true;
                            txtPortalKeyAccountFirstName4.Visible = true;
                            lnktxtPortalKeyAccountDelete4.Visible = true;

                            Session["KeyAccountCount"] = 4;
                            break;
                        case 4:
                            txtPortalKeyAccountFirstName5.Text = KeyProjectData1[ixa].FirstName;
                            txtPortalKeyAccountLastName5.Text = KeyProjectData1[ixa].LastName;
                            txtPortalKeyAccountEmail5.Text = KeyProjectData1[ixa].Email;
                            txtPortalKeyAccountEmail5.Visible = true;
                            txtPortalKeyAccountLastName5.Visible = true;
                            txtPortalKeyAccountFirstName5.Visible = true;
                            lnktxtPortalKeyAccountDelete5.Visible = true;

                            Session["KeyAccountCount"] = 5;
                            break;
                        case 5:
                            txtPortalKeyAccountFirstName6.Text = KeyProjectData1[ixa].FirstName;
                            txtPortalKeyAccountLastName6.Text = KeyProjectData1[ixa].LastName;
                            txtPortalKeyAccountEmail6.Text = KeyProjectData1[ixa].Email;
                            txtPortalKeyAccountEmail6.Visible = true;
                            txtPortalKeyAccountLastName6.Visible = true;
                            txtPortalKeyAccountFirstName6.Visible = true;
                            lnktxtPortalKeyAccountDelete6.Visible = true;
                            Session["KeyAccountCount"] = 6;
                            break;
                        case 6:
                            txtPortalKeyAccountFirstName7.Text = KeyProjectData1[ixa].FirstName;
                            txtPortalKeyAccountLastName7.Text = KeyProjectData1[ixa].LastName;
                            txtPortalKeyAccountEmail7.Text = KeyProjectData1[ixa].Email;

                            txtPortalKeyAccountEmail7.Visible = true;
                            txtPortalKeyAccountLastName7.Visible = true;
                            txtPortalKeyAccountFirstName7.Visible = true;
                            lnktxtPortalKeyAccountDelete7.Visible = true;

                            Session["KeyAccountCount"] = 7;
                            break;
                        case 7:
                            txtPortalKeyAccountFirstName8.Text = KeyProjectData1[ixa].FirstName;
                            txtPortalKeyAccountLastName8.Text = KeyProjectData1[ixa].LastName;
                            txtPortalKeyAccountEmail8.Text = KeyProjectData1[ixa].Email;

                            txtPortalKeyAccountEmail8.Visible = true;
                            txtPortalKeyAccountLastName8.Visible = true;
                            txtPortalKeyAccountFirstName8.Visible = true;
                            lnktxtPortalKeyAccountDelete8.Visible = true;

                            Session["KeyAccountCount"] = 8;
                            break;
                        case 8:
                            txtPortalKeyAccountFirstName9.Text = KeyProjectData1[ixa].FirstName;
                            txtPortalKeyAccountLastName9.Text = KeyProjectData1[ixa].LastName;
                            txtPortalKeyAccountEmail9.Text = KeyProjectData1[ixa].Email;

                            txtPortalKeyAccountEmail9.Visible = true;
                            txtPortalKeyAccountLastName9.Visible = true;
                            txtPortalKeyAccountFirstName9.Visible = true;
                            lnktxtPortalKeyAccountDelete9.Visible = true;

                            Session["KeyAccountCount"] = 9;

                            break;
                        case 9:
                            txtPortalKeyAccountFirstName10.Text = KeyProjectData1[ixa].FirstName;
                            txtPortalKeyAccountLastName10.Text = KeyProjectData1[ixa].LastName;
                            txtPortalKeyAccountEmail10.Text = KeyProjectData1[ixa].Email;

                            txtPortalKeyAccountEmail10.Visible = true;
                            txtPortalKeyAccountLastName10.Visible = true;
                            txtPortalKeyAccountFirstName10.Visible = true;
                            lnktxtPortalKeyAccountDelete10.Visible = true;

                            Session["KeyAccountCount"] = 10;
                            break;
                    }
                }


                KeyProjectData1 = JsonConvert.DeserializeObject<List<KeyProjectData>>(rowView["customer_portalsales"].ToString());
                for (int ixa = 0; ixa <= KeyProjectData1.Count - 1; ixa++)
                {
                    switch (ixa)
                    {
                        case 0:
                            txtPortalSalesFirstName1.Text = KeyProjectData1[ixa].FirstName;
                            txtPortalSalesLastName1.Text = KeyProjectData1[ixa].LastName;
                            txtPortalSalesEmail1.Text = KeyProjectData1[ixa].Email;
                            break;
                        case 1:
                            txtPortalSalesFirstName2.Text = KeyProjectData1[ixa].FirstName;
                            txtPortalSalesLastName2.Text = KeyProjectData1[ixa].LastName;
                            txtPortalSalesEmail2.Text = KeyProjectData1[ixa].Email;

                            txtPortalSalesFirstName2.Visible = true;
                            txtPortalSalesLastName2.Visible = true;
                            txtPortalSalesEmail2.Visible = true;
                            lnkPortalSalesDelete2.Visible = true;
                            Session["PortalSalesCount"] = 2;

                            break;
                        case 2:
                            txtPortalSalesFirstName3.Text = KeyProjectData1[ixa].FirstName;
                            txtPortalSalesLastName3.Text = KeyProjectData1[ixa].LastName;
                            txtPortalSalesEmail3.Text = KeyProjectData1[ixa].Email;

                            txtPortalSalesFirstName3.Visible = true;
                            txtPortalSalesLastName3.Visible = true;
                            txtPortalSalesEmail3.Visible = true;
                            lnkPortalSalesDelete3.Visible = true;
                            Session["PortalSalesCount"] = 3;
                            break;
                        case 3:
                            txtPortalSalesFirstName4.Text = KeyProjectData1[ixa].FirstName;
                            txtPortalSalesLastName4.Text = KeyProjectData1[ixa].LastName;
                            txtPortalSalesEmail4.Text = KeyProjectData1[ixa].Email;

                            txtPortalSalesFirstName4.Visible = true;
                            txtPortalSalesLastName4.Visible = true;
                            txtPortalSalesEmail4.Visible = true;
                            lnkPortalSalesDelete4.Visible = true;
                            Session["PortalSalesCount"] = 4;

                            break;
                        case 4:
                            txtPortalSalesFirstName5.Text = KeyProjectData1[ixa].FirstName;
                            txtPortalSalesLastName5.Text = KeyProjectData1[ixa].LastName;
                            txtPortalSalesEmail5.Text = KeyProjectData1[ixa].Email;

                            txtPortalSalesFirstName5.Visible = true;
                            txtPortalSalesLastName5.Visible = true;
                            txtPortalSalesEmail5.Visible = true;
                            lnkPortalSalesDelete5.Visible = true;
                            Session["PortalSalesCount"] =5 ;


                            break;
                        case 5:
                            txtPortalSalesFirstName6.Text = KeyProjectData1[ixa].FirstName;
                            txtPortalSalesLastName6.Text = KeyProjectData1[ixa].LastName;
                            txtPortalSalesEmail6.Text = KeyProjectData1[ixa].Email;

                            txtPortalSalesFirstName6.Visible = true;
                            txtPortalSalesLastName6.Visible = true;
                            txtPortalSalesEmail6.Visible = true;
                            lnkPortalSalesDelete6.Visible = true;
                            Session["PortalSalesCount"] = 6;


                            break;
                        case 6:
                            txtPortalSalesFirstName7.Text = KeyProjectData1[ixa].FirstName;
                            txtPortalSalesLastName7.Text = KeyProjectData1[ixa].LastName;
                            txtPortalSalesEmail7.Text = KeyProjectData1[ixa].Email;
                            txtPortalSalesFirstName7.Visible = true;
                            txtPortalSalesLastName7.Visible = true;
                            txtPortalSalesEmail7.Visible = true;
                            lnkPortalSalesDelete7.Visible = true;
                            Session["PortalSalesCount"] = 7;

                            break;
                        case 7:
                            txtPortalSalesFirstName8.Text = KeyProjectData1[ixa].FirstName;
                            txtPortalSalesLastName8.Text = KeyProjectData1[ixa].LastName;
                            txtPortalSalesEmail8.Text = KeyProjectData1[ixa].Email;

                            txtPortalSalesFirstName8.Visible = true;
                            txtPortalSalesLastName8.Visible = true;
                            txtPortalSalesEmail8.Visible = true;
                            lnkPortalSalesDelete8.Visible = true;
                            Session["PortalSalesCount"] = 8;

                            break;
                        case 8:
                            txtPortalSalesFirstName9.Text = KeyProjectData1[ixa].FirstName;
                            txtPortalSalesLastName9.Text = KeyProjectData1[ixa].LastName;
                            txtPortalSalesEmail9.Text = KeyProjectData1[ixa].Email;

                            txtPortalSalesFirstName9.Visible = true;
                            txtPortalSalesLastName9.Visible = true;
                            txtPortalSalesEmail9.Visible = true;
                            lnkPortalSalesDelete9.Visible = true;
                            Session["PortalSalesCount"] = 9;
                            break;
                        case 9:
                            txtPortalSalesFirstName10.Text = KeyProjectData1[ixa].FirstName;
                            txtPortalSalesLastName10.Text = KeyProjectData1[ixa].LastName;
                            txtPortalSalesEmail10.Text = KeyProjectData1[ixa].Email;

                            txtPortalSalesFirstName9.Visible = true;
                            txtPortalSalesLastName9.Visible = true;
                            txtPortalSalesEmail9.Visible = true;
                            lnkPortalSalesDelete10.Visible = true;
                            Session["PortalSalesCount"] = 9;


                            break;
                    }
                }


                KeyProjectData1 = JsonConvert.DeserializeObject<List<KeyProjectData>>(rowView["customer_project_core"].ToString());
                for (int ixa = 0; ixa <= KeyProjectData1.Count - 1; ixa++)
                {
                    switch (ixa)
                    {
                        case 0:
                            txtProjectCoreFirstName1.Text = KeyProjectData1[ixa].FirstName;
                            txtProjectCoreLastName1.Text = KeyProjectData1[ixa].LastName;
                            txtProjectCoreEmail1.Text = KeyProjectData1[ixa].Email;
                            break;
                        case 1:
                            txtProjectCoreFirstName2.Text = KeyProjectData1[ixa].FirstName;
                           txtProjectCoreLastName2.Text = KeyProjectData1[ixa].LastName;
                             txtProjectCoreEmail2.Text = KeyProjectData1[ixa].Email; 

                            txtProjectCoreFirstName2.Visible = true;
                            txtProjectCoreLastName2.Visible = true;
                            txtProjectCoreEmail2.Visible = true;
                            lnkProjectCore2.Visible = true;

                            Session["ProjectCoreCount"] = 2;

                            break;
                        case 2:
                            txtProjectCoreFirstName3.Text = KeyProjectData1[ixa].FirstName;
                           txtProjectCoreLastName3.Text = KeyProjectData1[ixa].LastName;
                             txtProjectCoreEmail3.Text = KeyProjectData1[ixa].Email;

                            txtProjectCoreFirstName3.Visible = true;
                            txtProjectCoreLastName3.Visible = true;
                            txtProjectCoreEmail3.Visible = true;
                            lnkProjectCore3.Visible = true;
                            Session["ProjectCoreCount"] = 3;
                            break;
                        case 3:
                            txtProjectCoreFirstName4.Text = KeyProjectData1[ixa].FirstName;
                           txtProjectCoreLastName4.Text = KeyProjectData1[ixa].LastName;
                             txtProjectCoreEmail4.Text = KeyProjectData1[ixa].Email;

                            txtProjectCoreFirstName4.Visible = true;
                            txtProjectCoreLastName4.Visible = true;
                            txtProjectCoreEmail4.Visible = true;
                            lnkProjectCore4.Visible = true;
                            Session["ProjectCoreCount"] = 4;

                            break;
                        case 4:
                            txtProjectCoreFirstName5.Text = KeyProjectData1[ixa].FirstName;
                           txtProjectCoreLastName5.Text = KeyProjectData1[ixa].LastName;
                             txtProjectCoreEmail5.Text = KeyProjectData1[ixa].Email;

                            txtProjectCoreFirstName5.Visible = true;
                            txtProjectCoreLastName5.Visible = true;
                            txtProjectCoreEmail5.Visible = true;
                            lnkProjectCore5.Visible = true;
                            Session["ProjectCoreCount"] = 5;
                            break;
                        case 5:
                            txtProjectCoreFirstName6.Text = KeyProjectData1[ixa].FirstName;
                           txtProjectCoreLastName6.Text = KeyProjectData1[ixa].LastName;
                             txtProjectCoreEmail6.Text = KeyProjectData1[ixa].Email;

                            txtProjectCoreFirstName6.Visible = true;
                            txtProjectCoreLastName6.Visible = true;
                            txtProjectCoreEmail6.Visible = true;
                            lnkProjectCore6.Visible = true;
                            Session["ProjectCoreCount"] = 6;

                            break;
                        case 6:
                            txtProjectCoreFirstName7.Text = KeyProjectData1[ixa].FirstName;
                           txtProjectCoreLastName7.Text = KeyProjectData1[ixa].LastName;
                             txtProjectCoreEmail7.Text = KeyProjectData1[ixa].Email;

                            txtProjectCoreFirstName7.Visible = true;
                            txtProjectCoreLastName7.Visible = true;
                            txtProjectCoreEmail7.Visible = true;
                            lnkProjectCore7.Visible = true;
                            Session["ProjectCoreCount"] = 7;


                            break;
                        case 7:
                            txtProjectCoreFirstName8.Text = KeyProjectData1[ixa].FirstName;
                           txtProjectCoreLastName8.Text = KeyProjectData1[ixa].LastName;
                             txtProjectCoreEmail8.Text = KeyProjectData1[ixa].Email;

                            txtProjectCoreFirstName8.Visible = true;
                            txtProjectCoreLastName8.Visible = true;
                            txtProjectCoreEmail8.Visible = true;
                            lnkProjectCore8.Visible = true;
                            Session["ProjectCoreCount"] = 8;


                            break;
                        case 8:
                            txtProjectCoreFirstName9.Text = KeyProjectData1[ixa].FirstName;
                           txtProjectCoreLastName9.Text = KeyProjectData1[ixa].LastName;
                             txtProjectCoreEmail9.Text = KeyProjectData1[ixa].Email;
                            txtProjectCoreFirstName8.Visible = true;
                            txtProjectCoreLastName8.Visible = true;
                            txtProjectCoreEmail8.Visible = true;
                            lnkProjectCore9.Visible = true;
                            Session["ProjectCoreCount"] = 8;

                            break;
                        case 9:
                            txtProjectCoreFirstName10.Text = KeyProjectData1[ixa].FirstName;
                           txtProjectCoreLastName10.Text = KeyProjectData1[ixa].LastName;
                             txtProjectCoreEmail10.Text = KeyProjectData1[ixa].Email;

                            txtProjectCoreFirstName10.Visible = true;
                            txtProjectCoreLastName10.Visible = true;
                            txtProjectCoreEmail10.Visible = true;
                            lnkProjectCore10.Visible = true;
                            Session["ProjectCoreCount"] = 10;

                            break;
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

            Session["Competitors"] = "Super Admin";
            Session["User"] = "Jonny";
            Session["UserType"] = "Granted Access";


            if ( Request.QueryString["id"] != null )
            {
                if (Request.QueryString["id"] != "")
                {
                    m_ID = Request.QueryString["id"].ToString();
                }
            }

            //bool Signin = false;

            //if (Session["User"] != null)
            //{
            //    if (Session["User"] != null)
            //    {
            //        m_UserName = Session["User"].ToString();
            //        m_UserID= Session["UserID"].ToString();
            //        m_UserType = Session["Competitors"].ToString();
            //        Signin = true;
            //    }

            //}


            //if (Signin == true)
            //{


            //}
            //else
            //{
            //    Response.Redirect("/Account/Signin");
            //}


            try
            {
                //string EmailName = Request.Headers["Federation-UserPrincipalName"].ToString();
                //Helper.InsertTracking(m_UserID, "Competitors", EmailName);
            }
            catch
            {

                //Helper.InsertTracking(m_UserID, "Competitors", "");
            }




            //if (Session["Competitors"].ToString() == "Super Admin")
            //{
            //   // PanSwitchUser.Visible = true;
            //}
            //else
            //{
            //    if (Session["SwitchUser"] != null)
            //    {
            //    }
            //    else
            //    {
            //      //  PanSwitchUser.Visible = false;
            //    }
            //}

            if (!IsPostBack)
            {

                Session["KeyAccountCount"] = 1;
                Session["PortalSalesCount"] = 1;
                Session["ProjectCoreCount"] = 1;

                SetupPage();


                //if (Session["SwitchUser"] != null)
                //{
                //    ddlSwitchUser.SelectedValue = Session["Competitors"].ToString();
                //}                           

                //GetGridDBData();

                //this.Grid1.DataSource = PhilipsDataLST;
                //this.Grid1.DataBind();

                //this.Grid1.ToolbarSettings.ShowToolbar = false;
                //this.Grid1.EditSettings.AllowEditing = false;


            }

        }
        catch { }
    }

}