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


public partial class competitive_info_Competitors : System.Web.UI.Page
{
    List<PhilipsData> PhilipsDataLST = new List<PhilipsData>();
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


    [Serializable]
    public class PhilipsData
    {
        public PhilipsData()
        {

        }
        public PhilipsData(string DataID , string ColumnName, string Philips, string Tera, string Siemens, string GE,string Cannon, string Agfa, string Comment,string TrafficLight)
        {
            this.DataID = DataID;
            this.ColumnName = ColumnName;
            this.Philips = Philips;
            this.Tera = Tera;
            this.Siemens = Siemens;
            this.GE = GE;
            this.Cannon = Cannon;
            this.Agfa = Agfa;
            this.Comment = Comment;
            this.TrafficLight = TrafficLight;
        }

        public string DataID { get; set; }
        public string ColumnName { get; set; }
        public string Philips { get; set; }
        public string Tera { get; set; }
        public string Siemens { get; set; }
        public string GE { get; set; }
        public string Cannon { get; set; }
        public string Agfa { get; set; }
        public string Comment { get; set; }
        public string TrafficLight { get; set; }
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


            string sSwitch = ddlSwitchUser.Text;

            Session["SwitchUser"] = "SwitchUser";
            Session["Competitors"] = sSwitch;

            Session["MVMatrix"] = sSwitch;            
            Session["Clinical"] = sSwitch;
            Session["Enterprise"] = sSwitch;
            Session["Services"] = sSwitch;
            Session["Attachments"] = sSwitch;

            // SetupStartPage();


            Response.Redirect("/competitive-info/Competitors");


        }
        catch { }
    }

    private string GetCompareData(string ColumnName,string Comp)
    {
        PhilipsDataLST = Session["CellEditDataSource"] as List<PhilipsData>;
        string CompData = string.Empty;
        int Valueidx = 0;

        try {

            switch(ColumnName)
            {
                case "Value Proposition":
                    Valueidx = 1;
                    break;
                case "Market Share":
                    Valueidx = 2;
                    break;             
                case "Business Model":
                    Valueidx = 3;
                    break;
                case "Solution Weaknesses":
                    Valueidx = 4;
                    break;
                case "Solution Strengths":
                    Valueidx = 5;
                    break;
                case "Competitive Argumentation":
                    Valueidx = 6;
                    break;
                case "TrafficLight":
                    Valueidx = 6;
                    break;
            }

            switch(Comp)
            {
                case "Philips":
                    CompData = PhilipsDataLST[Valueidx].Philips;
                    break;
                case "Tera":
                    CompData = PhilipsDataLST[Valueidx].Tera;
                    break;
                case "Siemens":
                    CompData = PhilipsDataLST[Valueidx].Siemens;
                    break;
                case "GE":
                    CompData = PhilipsDataLST[Valueidx].GE;
                    break;
                case "Cannon":
                    CompData = PhilipsDataLST[Valueidx].Cannon;
                    break;
                case "Agfa":
                    CompData = PhilipsDataLST[Valueidx].Agfa;
                    break;

            }
            

            if ( CompData!="")
            {
                CompData= CompData.Replace("\r\n", "").Replace("\n", "");
            }


        }
        catch { }


        return CompData;

    }

    private string GetTrafficData(string ColumnName, string Comp)
    {
        PhilipsDataLST = Session["CellEditDataSource"] as List<PhilipsData>;
        string CompData = string.Empty;
        int Valueidx = 0;

        try
        {

            switch (ColumnName)
            {
                case "Value Proposition":
                    Valueidx = 1;
                    break;
                case "Market Share":
                    Valueidx = 2;
                    break;
                case "Business Model":
                    Valueidx = 3;
                    break;
                case "Solution Weaknesses":
                    Valueidx = 4;
                    break;
                case "Solution Strengths":
                    Valueidx = 5;
                    break;
                case "Competitive Argumentation":
                    Valueidx = 6;
                    break;
                case "TrafficLight":
                    Valueidx = 6;
                    break;
            }

            switch (Comp)
            {
                case "Philips":
                    CompData = PhilipsDataLST[Valueidx].TrafficLight;
                    if (CompData!="" & CompData!=null)
                    {
                        CompData = CompData.Substring(1);
                        string[] SplitData = CompData.Split(';');
                        CompData = "";
                        foreach (string items in SplitData)
                        {
                            string[] innerSplitData = items.Split(':');
                            foreach (string innerItem in innerSplitData)
                            {
                                if (innerItem== Comp)
                                {
                                    CompData = innerSplitData[1];
                                }
                            }
                        }
                    }else
                    {
                        CompData = "4";
                    }
                    
                    break;
                case "Tera":
                    CompData = PhilipsDataLST[Valueidx].TrafficLight;
                    if (CompData != "" & CompData != null)
                    {
                        CompData = CompData.Substring(1);
                        string[] SplitData = CompData.Split(';');
                        CompData = "";
                        foreach (string items in SplitData)
                        {
                            string[] innerSplitData = items.Split(':');
                            foreach (string innerItem in innerSplitData)
                            {
                                if (innerItem == Comp)
                                {
                                    CompData = innerSplitData[1];
                                }
                            }
                        }
                    }
                    else
                    {
                        CompData = "4";
                    }
                    break;
                case "Siemens":
                    CompData = PhilipsDataLST[Valueidx].TrafficLight;
                    if (CompData != "" & CompData != null)
                    {
                        CompData = CompData.Substring(1);
                        string[] SplitData = CompData.Split(';');
                        CompData = "";
                        foreach (string items in SplitData)
                        {
                            string[] innerSplitData = items.Split(':');
                            foreach (string innerItem in innerSplitData)
                            {
                                if (innerItem == Comp)
                                {
                                    CompData = innerSplitData[1];
                                }
                            }
                        }
                    }
                    else
                    {
                        CompData = "4";
                    }
                    break;
                case "GE":
                    CompData = PhilipsDataLST[Valueidx].TrafficLight;
                    if (CompData != "" & CompData != null)
                    {
                        CompData = CompData.Substring(1);
                        string[] SplitData = CompData.Split(';');
                        CompData = "";
                        foreach (string items in SplitData)
                        {
                            string[] innerSplitData = items.Split(':');
                            foreach (string innerItem in innerSplitData)
                            {
                                if (innerItem == Comp)
                                {
                                    CompData = innerSplitData[1];
                                }
                            }
                        }
                    }
                    else
                    {
                        CompData = "4";
                    }
                    break;
                case "Cannon":
                    CompData = PhilipsDataLST[Valueidx].TrafficLight;
                    if (CompData != "" & CompData != null)
                    {
                        CompData = CompData.Substring(1);
                        string[] SplitData = CompData.Split(';');
                        CompData = "";
                        foreach (string items in SplitData)
                        {
                            string[] innerSplitData = items.Split(':');
                            foreach (string innerItem in innerSplitData)
                            {
                                if (innerItem == Comp)
                                {
                                    CompData = innerSplitData[1];
                                }
                            }
                        }
                    }
                    else
                    {
                        CompData = "4";
                    }
                    break;
                case "Agfa":
                    CompData = PhilipsDataLST[Valueidx].TrafficLight;
                    if (CompData != "" & CompData != null)
                    {
                        CompData = CompData.Substring(1);
                        string[] SplitData = CompData.Split(';');
                        foreach (string items in SplitData)
                        {
                            string[] innerSplitData = items.Split(':');
                            CompData = "";
                            foreach (string innerItem in innerSplitData)
                            {
                                if (innerItem == Comp)
                                {
                                    CompData = innerSplitData[1];
                                }
                            }
                        }
                    }
                    else
                    {
                        CompData = "4";
                    }
                    break;

            }


            //if (CompData != "")
            //{
            //    CompData = CompData.Replace("\r\n", "").Replace("\n", "");
            //}


        }
        catch { }

        if (CompData=="")
        {
            CompData = "4";
        }

        return CompData;

    }


    private string GetComment (Dictionary<string, object> KeyVal,string DataName)
    {
        string MyData = string.Empty;

        try {

            if (KeyVal[DataName] != null)
            {
                MyData = KeyVal[DataName].ToString();
            }else
            {
                MyData = "";
            }


        }
        catch
        {
            MyData = "";
        }

        return MyData;
    }


    private string GetTrafficLightData(Dictionary<string, object> KeyVal,string Competitor)
    {
        string MyData = string.Empty;

        try
        {

            switch(Competitor)
            {
                case "Philips":
                    if (KeyVal["Philipscheck"].ToString()!= "")
                    {
                        MyData = KeyVal["Philipscheck"].ToString();
                    }                   
                    break;
                case "Tera":
                    if (KeyVal["Teracheck"].ToString() != "")
                    {
                        MyData = KeyVal["Teracheck"].ToString();
                    }
                    break;
                case "Siemens":
                    if (KeyVal["Siemenscheck"].ToString() != "")
                    {
                        MyData = KeyVal["Siemenscheck"].ToString();
                    }
                    break;
                case "GE":
                    if (KeyVal["GEcheck"].ToString() != "")
                    {
                        MyData = KeyVal["GEcheck"].ToString();
                    }
                    break;
                case "Cannon":
                    if (KeyVal["Cannoncheck"].ToString() != "")
                    {
                        MyData = KeyVal["Cannoncheck"].ToString();
                    }
                    break;
                case "Agfa":
                    if (KeyVal["Agfacheck"].ToString() != "")
                    {
                        MyData = KeyVal["Agfacheck"].ToString();
                    }
                    break;

            }
     

        }
        catch
        {
            MyData = "4";
        }

        return MyData;
    }

    //private string GetTrafficString(string DataItem,string Comp)
    //{
    //    string myData = string.Empty;

    //    try {


    //        myData = DataItem.Replace(Comp + ":", "");

    //        switch(myData)
    //        {
    //            case "1":
                    
    //                break;
    //            case "2":
    //                break;
    //            case "3":
    //                break;
    //            case "4":
    //                break;
    //        }

    //    }
    //    catch { }
        
    //    return myData;

    //}
    protected void EditAction(string eventType, object record)
    {
        PhilipsDataLST = Session["CellEditDataSource"] as List<PhilipsData>;
        if (PhilipsDataLST==null)
        {
            GetGridDBData();
        }
        string sColumnName = string.Empty;
        string sColumnPhilips = string.Empty;
        string sColumnTera = string.Empty;
        string sColumnSiemens = string.Empty;
        string sColumnGE = string.Empty;
        string sColumnCannon = string.Empty;
        string sColumnAgfa = string.Empty;
        string CompareData = string.Empty;
        string SQL = string.Empty;
        string sComment = string.Empty;
        string sTrafficLightData = string.Empty;
        string sOriginalTrafficLightData = string.Empty;

        Dictionary<string, object> KeyVal = record as Dictionary<string, object>;
        if (eventType == "endEdit")
        {
                       
            foreach (KeyValuePair<string, object> keyval in KeyVal)
            {

                if (keyval.Key == "ColumnName")
                {
                    sColumnName = Convert.ToString(keyval.Value);
                }
                else if (keyval.Key == "Philips")
                {
                    CompareData = GetCompareData(sColumnName, "Philips");
                    sOriginalTrafficLightData = GetTrafficData(sColumnName, "Philips");
                    sColumnPhilips = Convert.ToString(keyval.Value).Replace("'", "\"").Replace("\n", "");
                    sComment = GetComment(KeyVal, "PhilipsComments");

                    sTrafficLightData = GetTrafficLightData(KeyVal, "Philips");
                    if (sTrafficLightData != "")
                    {
                        if (sTrafficLightData.Replace("Philips:", "") != sOriginalTrafficLightData)
                        {
                            SQL = "INSERT INTO PhilipsAnalysisCompetitorsData_PendingUpdates(NewDataUpdate, OldData, UpdateColumnName, UserID, UserName, Status,Type,Comment,TrafficLightData) VALUES('" + sTrafficLightData + "', '"+ sOriginalTrafficLightData + "', '" + sColumnName.Replace(" ", "_") + "_chk', '" + Session["UserID"] + "', '" + Session["User"] + "', 1,'Philips','" + sComment + "','" + sTrafficLightData + "')";
                            GetData(SQL);
                        }
                        SQL = "";
                    }



                    if (CompareData!= sColumnPhilips)
                    {
                        SQL = "INSERT INTO PhilipsAnalysisCompetitorsData_PendingUpdates(NewDataUpdate, OldData, UpdateColumnName, UserID, UserName, Status,Type,Comment,TrafficLightData) VALUES('" + sColumnPhilips + "', '" + CompareData + "', '" + sColumnName + "', '" + Session["UserID"] + "', '" + Session["User"] + "', 1,'Philips','"+ sComment + "','"+ sTrafficLightData + "')";
                        GetData(SQL);
                        SQL = "";
                    }                    
                }
                else if (keyval.Key == "Tera")
                {
                    CompareData = GetCompareData(sColumnName, "Tera");
                    sOriginalTrafficLightData = GetTrafficData(sColumnName, "Tera");
                    sColumnTera = Convert.ToString(keyval.Value).Replace("'", "\"").Replace("\n","");                    
                    sComment = GetComment(KeyVal, "TeraComments");

                    sTrafficLightData = GetTrafficLightData(KeyVal, "Tera");
                    if (sTrafficLightData != "")
                    {
                        if (sTrafficLightData.Replace("Tera:", "") != sOriginalTrafficLightData)
                        {
                            SQL = "INSERT INTO PhilipsAnalysisCompetitorsData_PendingUpdates(NewDataUpdate, OldData, UpdateColumnName, UserID, UserName, Status,Type,Comment,TrafficLightData) VALUES('" + sTrafficLightData + "', '" + sOriginalTrafficLightData + "', '" + sColumnName.Replace(" ", "_") + "_chk', '" + Session["UserID"] + "', '" + Session["User"] + "', 1,'Tera','" + sComment + "','" + sTrafficLightData + "')";
                            GetData(SQL);
                        }
                        SQL = "";
                    }

                    if (CompareData != sColumnTera)
                    {
                        SQL = "INSERT INTO PhilipsAnalysisCompetitorsData_PendingUpdates(NewDataUpdate, OldData, UpdateColumnName, UserID, UserName, Status,Type,Comment) VALUES('" + sColumnTera + "', '" + CompareData + "', '" + sColumnName + "', '" + Session["UserID"] + "', '" + Session["User"] + "', 1,'Tera','" + sComment + "')";
                        GetData(SQL);
                        SQL = "";
                    }
                }                
                else if (keyval.Key == "Siemens")
                {
                    CompareData = GetCompareData(sColumnName, "Siemens");
                    sOriginalTrafficLightData = GetTrafficData(sColumnName, "Siemens");
                    sColumnSiemens = Convert.ToString(keyval.Value).Replace("'", "\"").Replace("\n", "");
                    sComment = GetComment(KeyVal, "SiemensComments");

                    sTrafficLightData = GetTrafficLightData(KeyVal, "Siemens");
                    if (sTrafficLightData != "")
                    {
                        if (sTrafficLightData.Replace("Siemens:", "") != sOriginalTrafficLightData)
                        {
                            SQL = "INSERT INTO PhilipsAnalysisCompetitorsData_PendingUpdates(NewDataUpdate, OldData, UpdateColumnName, UserID, UserName, Status,Type,Comment,TrafficLightData) VALUES('" + sTrafficLightData + "', '" + sOriginalTrafficLightData + "', '" + sColumnName.Replace(" ", "_") + "_chk', '" + Session["UserID"] + "', '" + Session["User"] + "', 1,'Siemens','" + sComment + "','" + sTrafficLightData + "')";
                            GetData(SQL);
                        }
                        SQL = "";
                    }

                    if (CompareData != sColumnSiemens)
                    {
                        SQL = "INSERT INTO PhilipsAnalysisCompetitorsData_PendingUpdates(NewDataUpdate, OldData, UpdateColumnName, UserID, UserName, Status,Type,Comment) VALUES('" + sColumnSiemens + "', '" + CompareData + "', '" + sColumnName + "', '" + Session["UserID"] + "', '" + Session["User"] + "', 1,'Siemens','" + sComment + "')";
                        GetData(SQL);
                        SQL = "";
                    }
                }               
                else if (keyval.Key == "GE")
                {
                    CompareData = GetCompareData(sColumnName, "GE");
                    sOriginalTrafficLightData = GetTrafficData(sColumnName, "GE");
                    sColumnGE = Convert.ToString(keyval.Value).Replace("'", "\"").Replace("\n", "");
                    sComment = GetComment(KeyVal, "GEComments");

                    sTrafficLightData = GetTrafficLightData(KeyVal, "GE");
                    if (sTrafficLightData != "")
                    {
                        if (sTrafficLightData.Replace("GE:", "") != sOriginalTrafficLightData)
                        {
                            SQL = "INSERT INTO PhilipsAnalysisCompetitorsData_PendingUpdates(NewDataUpdate, OldData, UpdateColumnName, UserID, UserName, Status,Type,Comment,TrafficLightData) VALUES('" + sTrafficLightData + "', '" + sOriginalTrafficLightData + "', '" + sColumnName.Replace(" ", "_") + "_chk', '" + Session["UserID"] + "', '" + Session["User"] + "', 1,'GE','" + sComment + "','" + sTrafficLightData + "')";
                            GetData(SQL);
                        }
                        SQL = "";
                    }

                    if (CompareData != sColumnGE)
                    {
                        SQL = "INSERT INTO PhilipsAnalysisCompetitorsData_PendingUpdates(NewDataUpdate, OldData, UpdateColumnName, UserID, UserName, Status,Type,Comment) VALUES('" + sColumnGE + "', '" + CompareData + "', '" + sColumnName + "', '" + Session["UserID"] + "', '" + Session["User"] + "', 1,'GE','" + sComment + "')";
                        GetData(SQL);
                        SQL = "";
                    }
                }                
                else if (keyval.Key == "Cannon")
                {
                    CompareData = GetCompareData(sColumnName, "Cannon");
                    sOriginalTrafficLightData = GetTrafficData(sColumnName, "Cannon");
                    sColumnCannon = Convert.ToString(keyval.Value).Replace("'", "\"").Replace("\n", "");                    
                    sComment = GetComment(KeyVal, "CannonComments");

                    sTrafficLightData = GetTrafficLightData(KeyVal, "Cannon");
                    if (sTrafficLightData != "")
                    {
                        if (sTrafficLightData.Replace("Cannon:", "") != sOriginalTrafficLightData)
                        {
                            SQL = "INSERT INTO PhilipsAnalysisCompetitorsData_PendingUpdates(NewDataUpdate, OldData, UpdateColumnName, UserID, UserName, Status,Type,Comment,TrafficLightData) VALUES('" + sTrafficLightData + "', '" + sOriginalTrafficLightData + "', '" + sColumnName.Replace(" ", "_") + "_chk', '" + Session["UserID"] + "', '" + Session["User"] + "', 1,'Cannon','" + sComment + "','" + sTrafficLightData + "')";
                            GetData(SQL);
                        }
                        SQL = "";
                    }

                    if (CompareData != sColumnCannon)
                    {
                        SQL = "INSERT INTO PhilipsAnalysisCompetitorsData_PendingUpdates(NewDataUpdate, OldData, UpdateColumnName, UserID, UserName, Status,Type,Comment) VALUES('" + sColumnCannon + "', '" + CompareData + "', '" + sColumnName + "', '" + Session["UserID"] + "', '" + Session["User"] + "', 1,'Cannon','" + sComment + "')";
                        GetData(SQL);
                        SQL = "";
                    }
                }                
                else if (keyval.Key == "Agfa")
                {
                    CompareData = GetCompareData(sColumnName, "Agfa");
                    sOriginalTrafficLightData = GetTrafficData(sColumnName, "Agfa");
                    sColumnAgfa = Convert.ToString(keyval.Value).Replace("'", "\"").Replace("\n", "");
                    sComment = GetComment(KeyVal, "AgfaComments");

                    sTrafficLightData = GetTrafficLightData(KeyVal, "Agfa");
                    if (sTrafficLightData != "")
                    {
                        if (sTrafficLightData.Replace("Agfa:", "") != sOriginalTrafficLightData)
                        {
                            SQL = "INSERT INTO PhilipsAnalysisCompetitorsData_PendingUpdates(NewDataUpdate, OldData, UpdateColumnName, UserID, UserName, Status,Type,Comment,TrafficLightData) VALUES('" + sTrafficLightData + "', '" + sOriginalTrafficLightData + "', '" + sColumnName.Replace(" ", "_") + "_chk', '" + Session["UserID"] + "', '" + Session["User"] + "', 1,'Agfa','" + sComment + "','" + sTrafficLightData + "')";
                            GetData(SQL);
                        }
                        SQL = "";
                    }

                    if (CompareData != sColumnAgfa)
                    {
                        SQL = "INSERT INTO PhilipsAnalysisCompetitorsData_PendingUpdates(NewDataUpdate, OldData, UpdateColumnName, UserID, UserName, Status,Type,Comment) VALUES('" + sColumnAgfa + "', '" + CompareData + "', '" + sColumnName + "', '" + Session["UserID"] + "', '" + Session["User"] + "', 1,'Agfa','" + sComment + "')";
                        GetData(SQL);
                        SQL = "";
                    }
                }
                

            }
        }



        this.Grid1.DataSource = PhilipsDataLST;
        this.Grid1.DataBind();
    }

    protected void EditEvents_ServerEditRow(object sender, GridEventArgs e)
    {
        EditAction(e.EventType, e.Arguments["data"]);
    }

    private void GetGridDBData()
    {
        try {

            string DataID = string.Empty;
            string SQL = "select * from PhilipsAnalysisCompetitorsData";
            DataView MyDV = Helper.GetData(SQL);



            PhilipsData mySolution = new PhilipsData();
            PhilipsData myValue_Proposition = new PhilipsData();
            PhilipsData myMarket_Share = new PhilipsData();

            PhilipsData myBusiness_Model = new PhilipsData();
            PhilipsData mySolution_Weaknesses = new PhilipsData();
            PhilipsData mySolution_Strengths = new PhilipsData();
            PhilipsData myCompetitive_Argumentation = new PhilipsData();

            PhilipsData myComment = new PhilipsData();

            PhilipsData myTrafficLight = new PhilipsData();

            foreach (DataRowView rowView in MyDV)
            {
                mySolution.ColumnName = "Solution";
                DataID = rowView["PhilipsAnalysisCompetitorsDataID"].ToString();
                string Solution = rowView["Solution"].ToString();
                string Name = rowView["Name"].ToString();
                string Value_Proposition = rowView["Value_Proposition"].ToString();
                string Market_Share = rowView["Market_Share"].ToString();

                string Business_Model = rowView["Business_Model"].ToString();
                string Solution_Weaknesses = rowView["Solution_Weaknesses"].ToString();
                string Solution_Strengths = rowView["Solution_Strengths"].ToString();
                string Competitive_Argumentation = rowView["Competitive_Argumentation"].ToString();
                string Comment = rowView["Comment"].ToString();

                string TrafficLight_Value_Proposition = rowView["Value_Proposition_chk"].ToString();
                string TrafficLight_Market_Share = rowView["Market_Share_chk"].ToString();
                string TrafficLight_Business_Model = rowView["Business_Model_chk"].ToString();
                string TrafficLight_Solution_Weaknesses = rowView["Solution_Weaknesses_chk"].ToString();
                string TrafficLight_Competitive_Argumentation = rowView["Competitive_Argumentation_chk"].ToString();


                switch (Name)
                {
                    case "Philips":
                        mySolution.Philips = mySolution.Philips = "<a  target='_blank' href='https://www.philips.com/healthcare/product/HC881102/intellispace-portal-10-advanced-visualization'>IntelliSpace Portal</a>"; // Solution;
                        myValue_Proposition.Philips = Value_Proposition;
                        myMarket_Share.Philips = Market_Share;

                        myBusiness_Model.Philips = Business_Model;
                        mySolution_Weaknesses.Philips = Solution_Weaknesses;
                        mySolution_Strengths.Philips = Solution_Strengths;
                        myCompetitive_Argumentation.Philips = Competitive_Argumentation;
                        myComment.Philips = Comment;

                        myValue_Proposition.TrafficLight += ";Philips:" + TrafficLight_Value_Proposition;
                        myMarket_Share.TrafficLight += ";Philips:" + TrafficLight_Market_Share;
                        myBusiness_Model.TrafficLight += ";Philips:" + TrafficLight_Business_Model;
                        mySolution_Weaknesses.TrafficLight += ";Philips:" + TrafficLight_Solution_Weaknesses;
                        myCompetitive_Argumentation.TrafficLight += ";Philips:" + TrafficLight_Competitive_Argumentation;

                        break;
                    case "TeraRecon":
                        mySolution.Tera = "<a  target='_blank' href='https://www.terarecon.com'>iNtuition</a>"; // Solution;
                        myValue_Proposition.Tera = Value_Proposition;
                        myMarket_Share.Tera = Market_Share;
                        myBusiness_Model.Tera = Business_Model;
                        mySolution_Weaknesses.Tera = Solution_Weaknesses;
                        mySolution_Strengths.Tera = Solution_Strengths;
                        myCompetitive_Argumentation.Tera = Competitive_Argumentation;
                        myComment.Tera = Comment;
                        
                        myValue_Proposition.TrafficLight += ";Tera:" + TrafficLight_Value_Proposition;
                        myMarket_Share.TrafficLight += ";Tera:" + TrafficLight_Market_Share;
                        myBusiness_Model.TrafficLight += ";Tera:" + TrafficLight_Business_Model;
                        mySolution_Weaknesses.TrafficLight += ";Tera:" + TrafficLight_Solution_Weaknesses;
                        myCompetitive_Argumentation.TrafficLight += ";Tera:" + TrafficLight_Competitive_Argumentation;

                        break;
                    case "Siemens Medical":
                        mySolution.Siemens = "<a  target='_blank' href='https://www.healthcare.siemens.com/medical-imaging-it'>Syngo.via</a>"; // Solution;
                        myValue_Proposition.Siemens = Value_Proposition;
                        myMarket_Share.Siemens = Market_Share;
                        myBusiness_Model.Siemens = Business_Model;
                        mySolution_Weaknesses.Siemens = Solution_Weaknesses;
                        mySolution_Strengths.Siemens = Solution_Strengths;
                        myCompetitive_Argumentation.Siemens = Competitive_Argumentation;
                        myComment.Siemens = Comment;
                        
                        myValue_Proposition.TrafficLight += ";Siemens:" + TrafficLight_Value_Proposition;
                        myMarket_Share.TrafficLight += ";Siemens:" + TrafficLight_Market_Share;
                        myBusiness_Model.TrafficLight += ";Siemens:" + TrafficLight_Business_Model;
                        mySolution_Weaknesses.TrafficLight += ";Siemens:" + TrafficLight_Solution_Weaknesses;
                        myCompetitive_Argumentation.TrafficLight += ";Siemens:" + TrafficLight_Competitive_Argumentation;
                        break;
                    case "GE Healthcare":
                        mySolution.GE = "<a  target='_blank' href='http://www3.gehealthcare.com/en/products/categories/advanced_visualization'>AW Server</a>"; // Solution;
                        myValue_Proposition.GE = Value_Proposition;
                        myMarket_Share.GE = Market_Share;
                        myBusiness_Model.GE = Business_Model;
                        mySolution_Weaknesses.GE = Solution_Weaknesses;
                        mySolution_Strengths.GE = Solution_Strengths;
                        myCompetitive_Argumentation.GE = Competitive_Argumentation;
                        myComment.GE = Comment;
                        

                        myValue_Proposition.TrafficLight += ";GE:" + TrafficLight_Value_Proposition;
                        myMarket_Share.TrafficLight += ";GE:" + TrafficLight_Market_Share;
                        myBusiness_Model.TrafficLight += ";GE:" + TrafficLight_Business_Model;
                        mySolution_Weaknesses.TrafficLight += ";GE:" + TrafficLight_Solution_Weaknesses;
                        myCompetitive_Argumentation.TrafficLight += ";GE:" + TrafficLight_Competitive_Argumentation;
                        break;
                    case "Canon/Toshiba/Vital":
                        mySolution.Cannon = "<a  target='_blank' href='http://www.vitalimages.com/vitrea-vision/vitrea-advanced-visualization'>Vital VITREA®</a>";
                        myValue_Proposition.Cannon = Value_Proposition;
                        myMarket_Share.Cannon = Market_Share;
                        myBusiness_Model.Cannon = Business_Model;
                        mySolution_Weaknesses.Cannon = Solution_Weaknesses;
                        mySolution_Strengths.Cannon = Solution_Strengths;
                        myCompetitive_Argumentation.Cannon = Competitive_Argumentation;
                        myComment.Cannon = Comment;
                        

                        myValue_Proposition.TrafficLight += ";Cannon:" + TrafficLight_Value_Proposition;
                        myMarket_Share.TrafficLight += ";Cannon:" + TrafficLight_Market_Share;
                        myBusiness_Model.TrafficLight += ";Cannon:" + TrafficLight_Business_Model;
                        mySolution_Weaknesses.TrafficLight += ";Cannon:" + TrafficLight_Solution_Weaknesses;
                        myCompetitive_Argumentation.TrafficLight += ";Cannon:" + TrafficLight_Competitive_Argumentation;

                        break;
                    case "Agfa Healthcare":
                        mySolution.Agfa = "<a  target='_blank' href='https://global.agfahealthcare.com/main/'>Agfa HealthCare Enterprise Imaging</a>";
                        myValue_Proposition.Agfa = Value_Proposition;
                        myMarket_Share.Agfa = Market_Share;
                        myBusiness_Model.Agfa = Business_Model;
                        mySolution_Weaknesses.Agfa = Solution_Weaknesses;
                        mySolution_Strengths.Agfa = Solution_Strengths;
                        myCompetitive_Argumentation.Agfa = Competitive_Argumentation;
                        myComment.Agfa = Comment;
                        

                        myValue_Proposition.TrafficLight += ";Agfa:" + TrafficLight_Value_Proposition;
                        myMarket_Share.TrafficLight += ";Agfa:" + TrafficLight_Market_Share;
                        myBusiness_Model.TrafficLight += ";Agfa:" + TrafficLight_Business_Model;
                        mySolution_Weaknesses.TrafficLight += ";Agfa:" + TrafficLight_Solution_Weaknesses;
                        myCompetitive_Argumentation.TrafficLight += ";Agfa:" + TrafficLight_Competitive_Argumentation;
                        break;

                }

            }

            int DataIDs = 1;

            PhilipsDataLST = new List<PhilipsData>();

            PhilipsDataLST.Add(new PhilipsData(DataIDs.ToString(), "Solution", mySolution.Philips, mySolution.Tera, mySolution.Siemens, mySolution.GE, mySolution.Cannon, mySolution.Agfa, mySolution.Comment, mySolution.TrafficLight));
            DataIDs++;
            PhilipsDataLST.Add(new PhilipsData(DataIDs.ToString(), "Value Proposition", myValue_Proposition.Philips, myValue_Proposition.Tera, myValue_Proposition.Siemens, myValue_Proposition.GE, myValue_Proposition.Cannon, myValue_Proposition.Agfa, myValue_Proposition.Comment, myValue_Proposition.TrafficLight));
            DataIDs++;
            PhilipsDataLST.Add(new PhilipsData(DataIDs.ToString(), "Market Share", myMarket_Share.Philips, myMarket_Share.Tera, myMarket_Share.Siemens, myMarket_Share.GE, myMarket_Share.Cannon, myMarket_Share.Agfa, myComment.Comment, myMarket_Share.TrafficLight));
            DataIDs++;
            PhilipsDataLST.Add(new PhilipsData(DataIDs.ToString(), "Business Model", myBusiness_Model.Philips, myBusiness_Model.Tera, myBusiness_Model.Siemens, myBusiness_Model.GE, myBusiness_Model.Cannon, myBusiness_Model.Agfa, myBusiness_Model.Comment, myBusiness_Model.TrafficLight));
            DataIDs++;
            PhilipsDataLST.Add(new PhilipsData(DataIDs.ToString().ToString(), "Solution Weaknesses", mySolution_Weaknesses.Philips, mySolution_Weaknesses.Tera, mySolution_Weaknesses.Siemens, mySolution_Weaknesses.GE, mySolution_Weaknesses.Cannon, mySolution_Weaknesses.Agfa, mySolution_Weaknesses.Comment, mySolution_Weaknesses.TrafficLight));
            DataIDs++;
            PhilipsDataLST.Add(new PhilipsData(DataIDs.ToString(), "Solution Strengths", mySolution_Strengths.Philips, mySolution_Strengths.Tera, mySolution_Strengths.Siemens, mySolution_Strengths.GE, mySolution_Strengths.Cannon, mySolution_Strengths.Agfa, mySolution_Strengths.Comment, mySolution_Strengths.TrafficLight));
            DataIDs++;
            PhilipsDataLST.Add(new PhilipsData(DataIDs.ToString(), "Competitive Argumentation", myCompetitive_Argumentation.Philips, myCompetitive_Argumentation.Tera, myCompetitive_Argumentation.Siemens, myCompetitive_Argumentation.GE, myCompetitive_Argumentation.Cannon, myCompetitive_Argumentation.Agfa, myCompetitive_Argumentation.Comment, myCompetitive_Argumentation.TrafficLight));
            //DataIDs++;
            //PhilipsDataLST.Add(new PhilipsData(DataIDs.ToString(), "Additional Comments", myComment.Philips, myComment.Tera, myComment.Siemens, myComment.GE, myComment.Cannon, myComment.Agfa));


            Session["CellEditDataSource"] = PhilipsDataLST;


        }
        catch (Exception ex)
        {

        }
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
                    m_UserID= Session["UserID"].ToString();
                    m_UserType = Session["Competitors"].ToString();
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
                Helper.InsertTracking(m_UserID, "Competitors", EmailName);
            }
            catch
            {

                Helper.InsertTracking(m_UserID, "Competitors", "");
            }




            if (Session["Competitors"].ToString() == "Super Admin")
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

            if (!IsPostBack)
            {

                if (Session["SwitchUser"] != null)
                {
                    ddlSwitchUser.SelectedValue = Session["Competitors"].ToString();
                }                           

                GetGridDBData();

                this.Grid1.DataSource = PhilipsDataLST;
                this.Grid1.DataBind();

                this.Grid1.ToolbarSettings.ShowToolbar = false;
                this.Grid1.EditSettings.AllowEditing = false;


            }

        }
        catch { }
    }

    protected void cmdEdit_Click(object sender, EventArgs e)
    {
        try {

            this.Grid1.ToolbarSettings.ShowToolbar = true;
            this.Grid1.EditSettings.AllowEditing = true;

            GetGridDBData();

            this.Grid1.DataSource = PhilipsDataLST;
            this.Grid1.DataBind();

        }
        catch { }
    }
}