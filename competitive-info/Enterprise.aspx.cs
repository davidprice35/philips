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
        public PhilipsData(string DataID,string ColumnName, string Philips, string Tera, string Siemens, string GE,string Cannon, string Agfa,string Comment, string TrafficLight)
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

    private string GetColumnName(string DisplayColumn)
    {
        string MyColumn = string.Empty;

        try {


            switch(DisplayColumn)
            {
                case "Value Proposition":
                    MyColumn = "ValueProposition";
                    break;
                case "Vendor Neutral":
                    MyColumn = "Vendor_Neutral";
                    break;
                case "Concurrent Users":
                    MyColumn = "Concurrent_Users";
                    break;
                case "System Interoperability":
                    MyColumn = "System_Interoperability";
                    break;
                case "System Integration":
                    MyColumn = "System_Integration";
                    break;
                case "Cloud Medical Imaging":
                    MyColumn = "Cloud_Medical_Imaging";
                    break;
                case "Artificial Intelligence":
                    MyColumn = "Artificial_Intelligence";
                    break;
                case "Universal Viewer":
                    MyColumn = "Universal_Viewer";
                    break;
                case "Single_sign_on":
                    MyColumn = "Single sign on";
                    break;
                case "3D printing":
                    MyColumn = "[3D_printing]";
                    break;
                case "Cinematic Rendering":
                    MyColumn = "Cinematic_Rendering";
                    break;
                case "Workflow Tools":
                    MyColumn = "Workflow_Tools";
                    break;
                case "Solution Weaknesses":
                    MyColumn = "Solution_Weaknesses";
                    break;
                case "Solution Strengths":
                    MyColumn = "Solution_Strengths";
                    break;
                case "Competitive Argumentation":
                    MyColumn = "Competitive_Argumentation";
                    break;
            }


        }
        catch { }

        return MyColumn;
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

            switch (Session["Enterprise"].ToString())
            {
                case "Super Admin":
                case "ADMIN":
                    MyMenu = MyProfile + MyTracking;
                    break;

                case "Editor":
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

    private string GetCompareData(string ColumnName, string Comp)
    {
        PhilipsDataLST = Session["CellEditDataSource"] as List<PhilipsData>;
        string CompData = string.Empty;
        int Valueidx = 0;

        try
        {

            switch (ColumnName)
            {
                case "Solution":
                    Valueidx = 0;
                    break;
                case "Value Proposition":
                    Valueidx = 1;
                    break;
                case "Vendor Neutral":
                    Valueidx = 2;
                    break;
                case "Concurrent Users":
                    Valueidx = 3;
                    break;
                case "System Interoperability":
                    Valueidx = 4;
                    break;
                case "System Integration":
                    Valueidx = 5;
                    break;
                case "Cloud Medical Imaging":
                    Valueidx = 6;
                    break;
                case "Artificial Intelligence":
                    Valueidx = 7;
                    break;
                case "Universal Viewer":
                    Valueidx = 8;
                    break;
                case "Single sign-on":
                    Valueidx = 9;
                    break;
                case "3D printing":
                    Valueidx = 10;
                    break;
                case "Cinematic Rendering":
                    Valueidx = 11;
                    break;
                case "Workflow Tools":
                    Valueidx = 12;
                    break;
                case "Solution Weaknesses":
                    Valueidx = 13;
                    break;
                case "Solution Strengths":
                    Valueidx = 14;
                    break;
                case "Competitive Argumentation":
                    Valueidx = 15;
                    break;
                case "Additional Comments":
                    Valueidx = 16;
                    break;
            }

            switch (Comp)
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


            if (CompData != "")
            {
                CompData = CompData.Replace("\r\n", "").Replace("\n", "");
            }


        }
        catch { }


        return CompData;

    }

    private string GetComment(Dictionary<string, object> KeyVal, string DataName)
    {
        string MyData = string.Empty;

        try
        {

            if (KeyVal[DataName] != null)
            {
                MyData = KeyVal[DataName].ToString();
            }
            else
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

    protected void EditAction(string eventType, object record)
    {
        try { 

            PhilipsDataLST = Session["CellEditDataSource"] as List<PhilipsData>;
            if (PhilipsDataLST == null)
            {
                SetUpPage();
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
                                SQL = "INSERT INTO PhilipsAnalysisEnterpriseData_PendingUpdates(NewDataUpdate, OldData, UpdateColumnName, UserID, UserName, Status,Type,Comment,TrafficLightData) VALUES('" + sTrafficLightData + "', '" + sOriginalTrafficLightData + "', '" + sColumnName.Replace(" ", "_") + "_chk', '" + Session["UserID"] + "', '" + Session["User"] + "', 1,'Philips','" + sComment + "','" + sTrafficLightData + "')";
                                GetData(SQL);
                            }
                            SQL = "";
                        }

                        if (CompareData != sColumnPhilips)
                        {
                            SQL = "INSERT INTO PhilipsAnalysisEnterpriseData_PendingUpdates(NewDataUpdate, OldData, UpdateColumnName, UserID, UserName, Status,Type,Comment) VALUES('" + sColumnPhilips + "', '" + CompareData + "', '" + sColumnName + "', '" + Session["UserID"] + "', '" + Session["User"] + "', 1,'Philips','" + sComment + "')";
                                GetData(SQL);
                            SQL = "";
                        }
                    }
                    else if (keyval.Key == "Tera")
                    {
                        CompareData = GetCompareData(sColumnName, "Tera");
                        sOriginalTrafficLightData = GetTrafficData(sColumnName, "Tera");
                        sColumnTera = Convert.ToString(keyval.Value).Replace("'", "\"").Replace("\n", "");
                        sComment = GetComment(KeyVal, "TeraComments");

                        sTrafficLightData = GetTrafficLightData(KeyVal, "Tera");
                        if (sTrafficLightData != "")
                        {
                            if (sTrafficLightData.Replace("Tera:", "") != sOriginalTrafficLightData)
                            {
                                SQL = "INSERT INTO PhilipsAnalysisEnterpriseData_PendingUpdates(NewDataUpdate, OldData, UpdateColumnName, UserID, UserName, Status,Type,Comment,TrafficLightData) VALUES('" + sTrafficLightData + "', '" + sOriginalTrafficLightData + "', '" + sColumnName.Replace(" ", "_") + "_chk', '" + Session["UserID"] + "', '" + Session["User"] + "', 1,'Tera','" + sComment + "','" + sTrafficLightData + "')";
                                GetData(SQL);
                            }
                            SQL = "";
                        }



                        if (CompareData != sColumnTera)
                        {
                            SQL = "INSERT INTO PhilipsAnalysisEnterpriseData_PendingUpdates(NewDataUpdate, OldData, UpdateColumnName, UserID, UserName, Status,Type,Comment) VALUES('" + sColumnTera + "', '" + CompareData + "', '" + sColumnName + "', '" + Session["UserID"] + "', '" + Session["User"] + "', 1,'Tera','" + sComment + "')";
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
                                SQL = "INSERT INTO PhilipsAnalysisEnterpriseData_PendingUpdates(NewDataUpdate, OldData, UpdateColumnName, UserID, UserName, Status,Type,Comment,TrafficLightData) VALUES('" + sTrafficLightData + "', '" + sOriginalTrafficLightData + "', '" + sColumnName.Replace(" ", "_") + "_chk', '" + Session["UserID"] + "', '" + Session["User"] + "', 1,'Siemens','" + sComment + "','" + sTrafficLightData + "')";
                                GetData(SQL);
                            }
                            SQL = "";
                        }

                        if (CompareData != sColumnSiemens)
                        {
                            SQL = "INSERT INTO PhilipsAnalysisEnterpriseData_PendingUpdates(NewDataUpdate, OldData, UpdateColumnName, UserID, UserName, Status,Type,Comment) VALUES('" + sColumnSiemens + "', '" + CompareData + "', '" + sColumnName + "', '" + Session["UserID"] + "', '" + Session["User"] + "', 1,'Siemens','" + sComment + "')";
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
                                SQL = "INSERT INTO PhilipsAnalysisEnterpriseData_PendingUpdates(NewDataUpdate, OldData, UpdateColumnName, UserID, UserName, Status,Type,Comment,TrafficLightData) VALUES('" + sTrafficLightData + "', '" + sOriginalTrafficLightData + "', '" + sColumnName.Replace(" ", "_") + "_chk', '" + Session["UserID"] + "', '" + Session["User"] + "', 1,'GE','" + sComment + "','" + sTrafficLightData + "')";
                                GetData(SQL);
                            }
                            SQL = "";
                        }


                        if (CompareData != sColumnGE)
                        {
                            SQL = "INSERT INTO PhilipsAnalysisEnterpriseData_PendingUpdates(NewDataUpdate, OldData, UpdateColumnName, UserID, UserName, Status,Type,Comment) VALUES('" + sColumnGE + "', '" + CompareData + "', '" + sColumnName + "', '" + Session["UserID"] + "', '" + Session["User"] + "', 1,'GE','" + sComment + "')";
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
                                SQL = "INSERT INTO PhilipsAnalysisEnterpriseData_PendingUpdates(NewDataUpdate, OldData, UpdateColumnName, UserID, UserName, Status,Type,Comment,TrafficLightData) VALUES('" + sTrafficLightData + "', '" + sOriginalTrafficLightData + "', '" + sColumnName.Replace(" ", "_") + "_chk', '" + Session["UserID"] + "', '" + Session["User"] + "', 1,'Cannon','" + sComment + "','" + sTrafficLightData + "')";
                                GetData(SQL);
                            }
                            SQL = "";
                        }

                        if (CompareData != sColumnCannon)
                        {
                            SQL = "INSERT INTO PhilipsAnalysisEnterpriseData_PendingUpdates(NewDataUpdate, OldData, UpdateColumnName, UserID, UserName, Status,Type,Comment) VALUES('" + sColumnCannon + "', '" + CompareData + "', '" + sColumnName + "', '" + Session["UserID"] + "', '" + Session["User"] + "', 1,'Cannon','" + sComment + "')";
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
                                SQL = "INSERT INTO PhilipsAnalysisEnterpriseData_PendingUpdates(NewDataUpdate, OldData, UpdateColumnName, UserID, UserName, Status,Type,Comment,TrafficLightData) VALUES('" + sTrafficLightData + "', '" + sOriginalTrafficLightData + "', '" + sColumnName.Replace(" ", "_") + "_chk', '" + Session["UserID"] + "', '" + Session["User"] + "', 1,'Agfa','" + sComment + "','" + sTrafficLightData + "')";
                                GetData(SQL);
                            }
                            SQL = "";
                        }

                        if (CompareData != sColumnAgfa)
                        {
                            SQL = "INSERT INTO PhilipsAnalysisEnterpriseData_PendingUpdates(NewDataUpdate, OldData, UpdateColumnName, UserID, UserName, Status,Type,Comment) VALUES('" + sColumnAgfa + "', '" + CompareData + "', '" + sColumnName + "', '" + Session["UserID"] + "', '" + Session["User"] + "', 1,'Agfa','" + sComment + "')";
                                GetData(SQL);
                            SQL = "";
                        }
                    }

                }
            }

                
            this.Grid1.DataSource = PhilipsDataLST;
            this.Grid1.DataBind();

        }
        catch (Exception ex)
        { }



    }

    private string GetTrafficLightData(Dictionary<string, object> KeyVal, string Competitor)
    {
        string MyData = string.Empty;

        try
        {

            switch (Competitor)
            {
                case "Philips":
                    if (KeyVal["Philipscheck"].ToString() != "")
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

    

    private string GetTrafficData(string ColumnName, string Comp)
    {
        PhilipsDataLST = Session["CellEditDataSource"] as List<PhilipsData>;
        string CompData = string.Empty;
        int Valueidx = 0;

        try
        {

            switch (ColumnName)
            {
                case "Solution":
                    Valueidx = 0;
                    break;
                case "Value Proposition":
                    Valueidx = 1;
                    break;
                case "Vendor Neutral":
                    Valueidx = 2;
                    break;
                case "Concurrent Users":
                    Valueidx = 3;
                    break;
                case "System Interoperability":
                    Valueidx = 4;
                    break;
                case "System Integration":
                    Valueidx = 5;
                    break;
                case "Cloud Medical Imaging":
                    Valueidx = 6;
                    break;
                case "Artificial Intelligence":
                    Valueidx = 7;
                    break;
                case "Universal Viewer":
                    Valueidx = 8;
                    break;
                case "Single sign-on":
                    Valueidx = 9;
                    break;
                case "3D printing":
                    Valueidx = 10;
                    break;
                case "Cinematic Rendering":
                    Valueidx = 11;
                    break;
                case "Workflow Tools":
                    Valueidx = 12;
                    break;
                case "Solution Weaknesses":
                    Valueidx = 13;
                    break;
                case "Solution Strengths":
                    Valueidx = 14;
                    break;
                case "Competitive Argumentation":
                    Valueidx = 15;
                    break;
                case "Additional Comments":
                    Valueidx = 16;
                    break;
            }

            switch (Comp)
            {
                case "Philips":
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

        if (CompData == "")
        {
            CompData = "4";
        }

        return CompData;

    }

    protected void EditEvents_ServerEditRow(object sender, GridEventArgs e)
    {
        EditAction(e.EventType, e.Arguments["data"]);
    }


    private void SetUpPage()
    {

        try {

            string SQL = "select * from PhilipsAnalysisEnterpriseData";
            DataView MyDV = Helper.GetData(SQL);



            PhilipsData mySolution = new PhilipsData();
            PhilipsData myValue_Proposition = new PhilipsData();
            PhilipsData myVendor_Neutral = new PhilipsData();
            PhilipsData myConcurrent_Users = new PhilipsData();
            PhilipsData mySystem_Interoperability = new PhilipsData();
            PhilipsData mySystem_Integration = new PhilipsData();
            PhilipsData myCloud_Medical_Imaging = new PhilipsData();
            PhilipsData myArtificial_Intelligence = new PhilipsData();
            PhilipsData myUniversal_Viewer = new PhilipsData();
            PhilipsData mySingle_sign_on = new PhilipsData();
            PhilipsData myThreeD_printing = new PhilipsData();
            PhilipsData myCinematic_Rendering = new PhilipsData();
            PhilipsData myWorkflow_Tools = new PhilipsData();
            PhilipsData mySolution_Weaknesses = new PhilipsData();
            PhilipsData mySolution_Strengths = new PhilipsData();
            PhilipsData myCompetitive_Argumentation = new PhilipsData();
            PhilipsData myComment = new PhilipsData();






            foreach (DataRowView rowView in MyDV)
            {
                mySolution.ColumnName = "Solution";

                string Solution = rowView["Solution"].ToString();
                string Name = rowView["Name"].ToString();
                string Value_Proposition = rowView["ValueProposition"].ToString();
                string Vendor_Neutral = rowView["Vendor_Neutral"].ToString();
                string Concurrent_Users = rowView["Concurrent_Users"].ToString();
                string System_Interoperability = rowView["System_Interoperability"].ToString();
                string System_Integration = rowView["System_Integration"].ToString();
                string Cloud_Medical_Imaging = rowView["Cloud_Medical_Imaging"].ToString();
                string Artificial_Intelligence = rowView["Artificial_Intelligence"].ToString();
                string Universal_Viewer = rowView["Universal_Viewer"].ToString();
                string Single_sign_on = rowView["Single_sign_on"].ToString();
                string ThreeD_printing = rowView["3D_printing"].ToString();
                string Cinematic_Rendering = rowView["Cinematic_Rendering"].ToString();
                string Workflow_Tools = rowView["Workflow_Tools"].ToString();
                string Solution_Weaknesses = rowView["Solution_Weaknesses"].ToString();
                string Solution_Strengths = rowView["Solution_Strengths"].ToString();
                string Competitive_Argumentation = rowView["Competitive_Argumentation"].ToString();
                string Comment = rowView["Comment"].ToString();


                string TrafficLight_Value_Proposition = rowView["ValueProposition_chk"].ToString();
                string TrafficLight_Vendor_Neutral = rowView["Vendor_Neutral_chk"].ToString();
                string TrafficLight_Concurrent_Users = rowView["Concurrent_Users_chk"].ToString();
                string TrafficLight_System_Interoperability = rowView["System_Interoperability_chk"].ToString();
                string TrafficLight_System_Integration = rowView["System_Integration_chk"].ToString();
                string TrafficLight_Cloud_Medical_Imaging = rowView["Cloud_Medical_Imaging_chk"].ToString();
                string TrafficLight_Artificial_Intelligence = rowView["Artificial_Intelligence_chk"].ToString();
                string TrafficLight_Universal_Viewer = rowView["Universal_Viewer_chk"].ToString();
                string TrafficLight_Single_sign_on = rowView["Single_sign_on_chk"].ToString();
                string TrafficLight_ThreeD_printing = rowView["3D_printing_chk"].ToString();
                string TrafficLight_Cinematic_Rendering = rowView["Cinematic_Rendering_chk"].ToString();
                string TrafficLight_Workflow_Tools = rowView["Workflow_Tools_chk"].ToString();
                string TrafficLight_Solution_Weaknesses = rowView["Solution_Weaknesses_chk"].ToString();
                string TrafficLight_Solution_Strengths = rowView["Solution_Strengths_chk"].ToString();
                string TrafficLight_Competitive_Argumentation = rowView["Competitive_Argumentation_chk"].ToString();


                switch (Name)
                {
                    case "Philips":
                        mySolution.Philips = "<a  target='_blank' href='https://www.healthsystems.philips.com/IntellSpace_Portal_Enterprise '>IntelliSpace Portal Enterprise</ a>"; // Solution;
                        myValue_Proposition.Philips = Value_Proposition;
                        myVendor_Neutral.Philips = Vendor_Neutral;
                        myConcurrent_Users.Philips = Concurrent_Users;
                        mySystem_Interoperability.Philips = System_Interoperability;
                        mySystem_Integration.Philips = System_Integration;
                        myCloud_Medical_Imaging.Philips = Cloud_Medical_Imaging;
                        myArtificial_Intelligence.Philips = Artificial_Intelligence;
                        myUniversal_Viewer.Philips = Universal_Viewer;
                        mySingle_sign_on.Philips = Single_sign_on;
                        myThreeD_printing.Philips = ThreeD_printing;
                        myCinematic_Rendering.Philips = Cinematic_Rendering;
                        myWorkflow_Tools.Philips = Workflow_Tools;
                        mySolution_Weaknesses.Philips = Solution_Weaknesses;
                        mySolution_Strengths.Philips = Solution_Strengths;
                        myCompetitive_Argumentation.Philips = Competitive_Argumentation;
                        myComment.Philips = Comment;


                        myValue_Proposition.TrafficLight += ";Philips:" + TrafficLight_Value_Proposition;
                        myVendor_Neutral.TrafficLight += ";Philips:" + TrafficLight_Vendor_Neutral;
                        myConcurrent_Users.TrafficLight += ";Philips:" + TrafficLight_Concurrent_Users;
                        mySystem_Interoperability.TrafficLight += ";Philips:" + TrafficLight_System_Interoperability;
                        mySystem_Integration.TrafficLight += ";Philips:" + TrafficLight_System_Integration;
                        myCloud_Medical_Imaging.TrafficLight += ";Philips:" + TrafficLight_Cloud_Medical_Imaging;
                        myArtificial_Intelligence.TrafficLight += ";Philips:" + TrafficLight_Artificial_Intelligence;
                        myUniversal_Viewer.TrafficLight += ";Philips:" + TrafficLight_Universal_Viewer;
                        mySingle_sign_on.TrafficLight += ";Philips:" + TrafficLight_Single_sign_on;
                        myThreeD_printing.TrafficLight += ";Philips:" + TrafficLight_ThreeD_printing;
                        myCinematic_Rendering.TrafficLight += ";Philips:" + TrafficLight_Cinematic_Rendering;
                        myWorkflow_Tools.TrafficLight += ";Philips:" + TrafficLight_Workflow_Tools;
                        mySolution_Weaknesses.TrafficLight += ";Philips:" + TrafficLight_Solution_Weaknesses;
                        mySolution_Strengths.TrafficLight += ";Philips:" + TrafficLight_Solution_Strengths;
                        myCompetitive_Argumentation.TrafficLight += ";Philips:" + TrafficLight_Competitive_Argumentation;


                        break;
                    case "TeraRecon":
                        mySolution.Tera = "<a  target='_blank' href='https://www.terarecon.com/solutions/advanced-visualization'>iNtuition Enterprise Medical Viewer</a>"; // Solution;
                        myValue_Proposition.Tera = Value_Proposition;
                        myVendor_Neutral.Tera = Vendor_Neutral;
                        myConcurrent_Users.Tera = Concurrent_Users;
                        mySystem_Interoperability.Tera = System_Interoperability;
                        mySystem_Integration.Tera = System_Integration;
                        myCloud_Medical_Imaging.Tera = Cloud_Medical_Imaging;
                        myArtificial_Intelligence.Tera = Artificial_Intelligence;
                        myUniversal_Viewer.Tera = Universal_Viewer;
                        mySingle_sign_on.Tera = Single_sign_on;
                        myThreeD_printing.Tera = ThreeD_printing;
                        myCinematic_Rendering.Tera = Cinematic_Rendering;
                        myWorkflow_Tools.Tera = Workflow_Tools;
                        mySolution_Weaknesses.Tera = Solution_Weaknesses;
                        mySolution_Strengths.Tera = Solution_Strengths;
                        myCompetitive_Argumentation.Tera = Competitive_Argumentation;
                        myComment.Tera = Comment;

                        myValue_Proposition.TrafficLight += ";Tera:" + TrafficLight_Value_Proposition;
                        myVendor_Neutral.TrafficLight += ";Tera:" + TrafficLight_Vendor_Neutral;
                        myConcurrent_Users.TrafficLight += ";Tera:" + TrafficLight_Concurrent_Users;
                        mySystem_Interoperability.TrafficLight += ";Tera:" + TrafficLight_System_Interoperability;
                        mySystem_Integration.TrafficLight += ";Tera:" + TrafficLight_System_Integration;
                        myCloud_Medical_Imaging.TrafficLight += ";Tera:" + TrafficLight_Cloud_Medical_Imaging;
                        myArtificial_Intelligence.TrafficLight += ";Tera:" + TrafficLight_Artificial_Intelligence;
                        myUniversal_Viewer.TrafficLight += ";Tera:" + TrafficLight_Universal_Viewer;
                        mySingle_sign_on.TrafficLight += ";Tera:" + TrafficLight_Single_sign_on;
                        myThreeD_printing.TrafficLight += ";Tera:" + TrafficLight_ThreeD_printing;
                        myCinematic_Rendering.TrafficLight += ";Tera:" + TrafficLight_Cinematic_Rendering;
                        myWorkflow_Tools.TrafficLight += ";Tera:" + TrafficLight_Workflow_Tools;
                        mySolution_Weaknesses.TrafficLight += ";Tera:" + TrafficLight_Solution_Weaknesses;
                        mySolution_Strengths.TrafficLight += ";Tera:" + TrafficLight_Solution_Strengths;
                        myCompetitive_Argumentation.TrafficLight += ";Tera:" + TrafficLight_Competitive_Argumentation;
                        break;
                    case "Siemens Medical":
                        mySolution.Siemens = "<a  target='_blank' href='https://www.healthcare.siemens.com/medical-imaging-it/syngovia/business/licensing'>Syngo.via</a>"; // Solution;
                        myValue_Proposition.Siemens = Value_Proposition;
                        myVendor_Neutral.Siemens = Vendor_Neutral;
                        myConcurrent_Users.Siemens = Concurrent_Users;
                        mySystem_Interoperability.Siemens = System_Interoperability;
                        mySystem_Integration.Siemens = System_Integration;
                        myCloud_Medical_Imaging.Siemens = Cloud_Medical_Imaging;
                        myArtificial_Intelligence.Siemens = Artificial_Intelligence;
                        myUniversal_Viewer.Siemens = Universal_Viewer;
                        mySingle_sign_on.Siemens = Single_sign_on;
                        myThreeD_printing.Siemens = ThreeD_printing;
                        myCinematic_Rendering.Siemens = Cinematic_Rendering;
                        myWorkflow_Tools.Siemens = Workflow_Tools;
                        mySolution_Weaknesses.Siemens = Solution_Weaknesses;
                        mySolution_Strengths.Siemens = Solution_Strengths;
                        myCompetitive_Argumentation.Siemens = Competitive_Argumentation;
                        myComment.Siemens = Comment;

                        myValue_Proposition.TrafficLight += ";Siemens:" + TrafficLight_Value_Proposition;
                        myVendor_Neutral.TrafficLight += ";Siemens:" + TrafficLight_Vendor_Neutral;
                        myConcurrent_Users.TrafficLight += ";Siemens:" + TrafficLight_Concurrent_Users;
                        mySystem_Interoperability.TrafficLight += ";Siemens:" + TrafficLight_System_Interoperability;
                        mySystem_Integration.TrafficLight += ";Siemens:" + TrafficLight_System_Integration;
                        myCloud_Medical_Imaging.TrafficLight += ";Siemens:" + TrafficLight_Cloud_Medical_Imaging;
                        myArtificial_Intelligence.TrafficLight += ";Siemens:" + TrafficLight_Artificial_Intelligence;
                        myUniversal_Viewer.TrafficLight += ";Siemens:" + TrafficLight_Universal_Viewer;
                        mySingle_sign_on.TrafficLight += ";Siemens:" + TrafficLight_Single_sign_on;
                        myThreeD_printing.TrafficLight += ";Siemens:" + TrafficLight_ThreeD_printing;
                        myCinematic_Rendering.TrafficLight += ";Siemens:" + TrafficLight_Cinematic_Rendering;
                        myWorkflow_Tools.TrafficLight += ";Siemens:" + TrafficLight_Workflow_Tools;
                        mySolution_Weaknesses.TrafficLight += ";Siemens:" + TrafficLight_Solution_Weaknesses;
                        mySolution_Strengths.TrafficLight += ";Siemens:" + TrafficLight_Solution_Strengths;
                        myCompetitive_Argumentation.TrafficLight += ";Siemens:" + TrafficLight_Competitive_Argumentation;
                        break;
                    case "GE Healthcare":
                        mySolution.GE = "<a  target='_blank' href='http://www3.gehealthcare.com/en/products/categories/advanced_visualization'>AW Server 2</a>"; // Solution;
                        myValue_Proposition.GE = Value_Proposition;
                        myVendor_Neutral.GE = Vendor_Neutral;
                        myConcurrent_Users.GE = Concurrent_Users;
                        mySystem_Interoperability.GE = System_Interoperability;
                        mySystem_Integration.GE = System_Integration;
                        myCloud_Medical_Imaging.GE = Cloud_Medical_Imaging;
                        myArtificial_Intelligence.GE = Artificial_Intelligence;
                        myUniversal_Viewer.GE = Universal_Viewer;
                        mySingle_sign_on.GE = Single_sign_on;
                        myThreeD_printing.GE = ThreeD_printing;
                        myCinematic_Rendering.GE = Cinematic_Rendering;
                        myWorkflow_Tools.GE = Workflow_Tools;
                        mySolution_Weaknesses.GE = Solution_Weaknesses;
                        mySolution_Strengths.GE = Solution_Strengths;
                        myCompetitive_Argumentation.GE = Competitive_Argumentation;
                        myComment.GE = Comment;

                        myValue_Proposition.TrafficLight += ";GE:" + TrafficLight_Value_Proposition;
                        myVendor_Neutral.TrafficLight += ";GE:" + TrafficLight_Vendor_Neutral;
                        myConcurrent_Users.TrafficLight += ";GE:" + TrafficLight_Concurrent_Users;
                        mySystem_Interoperability.TrafficLight += ";GE:" + TrafficLight_System_Interoperability;
                        mySystem_Integration.TrafficLight += ";GE:" + TrafficLight_System_Integration;
                        myCloud_Medical_Imaging.TrafficLight += ";GE:" + TrafficLight_Cloud_Medical_Imaging;
                        myArtificial_Intelligence.TrafficLight += ";GE:" + TrafficLight_Artificial_Intelligence;
                        myUniversal_Viewer.TrafficLight += ";GE:" + TrafficLight_Universal_Viewer;
                        mySingle_sign_on.TrafficLight += ";GE:" + TrafficLight_Single_sign_on;
                        myThreeD_printing.TrafficLight += ";GE:" + TrafficLight_ThreeD_printing;
                        myCinematic_Rendering.TrafficLight += ";GE:" + TrafficLight_Cinematic_Rendering;
                        myWorkflow_Tools.TrafficLight += ";GE:" + TrafficLight_Workflow_Tools;
                        mySolution_Weaknesses.TrafficLight += ";GE:" + TrafficLight_Solution_Weaknesses;
                        mySolution_Strengths.TrafficLight += ";GE:" + TrafficLight_Solution_Strengths;
                        myCompetitive_Argumentation.TrafficLight += ";GE:" + TrafficLight_Competitive_Argumentation;
                        break;
                    case "Canon/Toshiba/Vital":
                        mySolution.Cannon = "<a  target='_blank' href='http://www.vitalimages.com/vitrea-vision/vitrea-advanced-visualization'>Vital VITREA® Enterprise Suite</ a>"; // Solution;
                        myValue_Proposition.Cannon = Value_Proposition;
                        myVendor_Neutral.Cannon = Vendor_Neutral;
                        myConcurrent_Users.Cannon = Concurrent_Users;
                        mySystem_Interoperability.Cannon = System_Interoperability;
                        mySystem_Integration.Cannon = System_Integration;
                        myCloud_Medical_Imaging.Cannon = Cloud_Medical_Imaging;
                        myArtificial_Intelligence.Cannon = Artificial_Intelligence;
                        myUniversal_Viewer.Cannon = Universal_Viewer;
                        mySingle_sign_on.Cannon = Single_sign_on;
                        myThreeD_printing.Cannon = ThreeD_printing;
                        myCinematic_Rendering.Cannon = Cinematic_Rendering;
                        myWorkflow_Tools.Cannon = Workflow_Tools;
                        mySolution_Weaknesses.Cannon = Solution_Weaknesses;
                        mySolution_Strengths.Cannon = Solution_Strengths;
                        myCompetitive_Argumentation.Cannon = Competitive_Argumentation;
                        myComment.Cannon = Comment;

                        myValue_Proposition.TrafficLight += ";Cannon:" + TrafficLight_Value_Proposition;
                        myVendor_Neutral.TrafficLight += ";Cannon:" + TrafficLight_Vendor_Neutral;
                        myConcurrent_Users.TrafficLight += ";Cannon:" + TrafficLight_Concurrent_Users;
                        mySystem_Interoperability.TrafficLight += ";Cannon:" + TrafficLight_System_Interoperability;
                        mySystem_Integration.TrafficLight += ";Cannon:" + TrafficLight_System_Integration;
                        myCloud_Medical_Imaging.TrafficLight += ";Cannon:" + TrafficLight_Cloud_Medical_Imaging;
                        myArtificial_Intelligence.TrafficLight += ";Cannon:" + TrafficLight_Artificial_Intelligence;
                        myUniversal_Viewer.TrafficLight += ";Cannon:" + TrafficLight_Universal_Viewer;
                        mySingle_sign_on.TrafficLight += ";Cannon:" + TrafficLight_Single_sign_on;
                        myThreeD_printing.TrafficLight += ";Cannon:" + TrafficLight_ThreeD_printing;
                        myCinematic_Rendering.TrafficLight += ";Cannon:" + TrafficLight_Cinematic_Rendering;
                        myWorkflow_Tools.TrafficLight += ";Cannon:" + TrafficLight_Workflow_Tools;
                        mySolution_Weaknesses.TrafficLight += ";Cannon:" + TrafficLight_Solution_Weaknesses;
                        mySolution_Strengths.TrafficLight += ";Cannon:" + TrafficLight_Solution_Strengths;
                        myCompetitive_Argumentation.TrafficLight += ";Cannon:" + TrafficLight_Competitive_Argumentation;
                        break;
                    case "Agfa Healthcare":
                        mySolution.Agfa = "<a  target='_blank' href='https://global.agfahealthcare.com/'>Agfa Healthcare</ a>";
                        myValue_Proposition.Agfa = Value_Proposition;
                        myVendor_Neutral.Agfa = Vendor_Neutral;
                        myConcurrent_Users.Agfa = Concurrent_Users;
                        mySystem_Interoperability.Agfa = System_Interoperability;
                        mySystem_Integration.Agfa = System_Integration;
                        myCloud_Medical_Imaging.Agfa = Cloud_Medical_Imaging;
                        myArtificial_Intelligence.Agfa = Artificial_Intelligence;
                        myUniversal_Viewer.Agfa = Universal_Viewer;
                        mySingle_sign_on.Agfa = Single_sign_on;
                        myThreeD_printing.Agfa = ThreeD_printing;
                        myCinematic_Rendering.Agfa = Cinematic_Rendering;
                        myWorkflow_Tools.Agfa = Workflow_Tools;
                        mySolution_Weaknesses.Agfa = Solution_Weaknesses;
                        mySolution_Strengths.Agfa = Solution_Strengths;
                        myCompetitive_Argumentation.Agfa = Competitive_Argumentation;
                        myComment.Agfa = Comment;

                        myValue_Proposition.TrafficLight += ";Agfa:" + TrafficLight_Value_Proposition;
                        myVendor_Neutral.TrafficLight += ";Agfa:" + TrafficLight_Vendor_Neutral;
                        myConcurrent_Users.TrafficLight += ";Agfa:" + TrafficLight_Concurrent_Users;
                        mySystem_Interoperability.TrafficLight += ";Agfa:" + TrafficLight_System_Interoperability;
                        mySystem_Integration.TrafficLight += ";Agfa:" + TrafficLight_System_Integration;
                        myCloud_Medical_Imaging.TrafficLight += ";Agfa:" + TrafficLight_Cloud_Medical_Imaging;
                        myArtificial_Intelligence.TrafficLight += ";Agfa:" + TrafficLight_Artificial_Intelligence;
                        myUniversal_Viewer.TrafficLight += ";Agfa:" + TrafficLight_Universal_Viewer;
                        mySingle_sign_on.TrafficLight += ";Agfa:" + TrafficLight_Single_sign_on;
                        myThreeD_printing.TrafficLight += ";Agfa:" + TrafficLight_ThreeD_printing;
                        myCinematic_Rendering.TrafficLight += ";Agfa:" + TrafficLight_Cinematic_Rendering;
                        myWorkflow_Tools.TrafficLight += ";Agfa:" + TrafficLight_Workflow_Tools;
                        mySolution_Weaknesses.TrafficLight += ";Agfa:" + TrafficLight_Solution_Weaknesses;
                        mySolution_Strengths.TrafficLight += ";Agfa:" + TrafficLight_Solution_Strengths;
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
            PhilipsDataLST.Add(new PhilipsData(DataIDs.ToString(), "Vendor Neutral", myVendor_Neutral.Philips, myVendor_Neutral.Tera, myVendor_Neutral.Siemens, myVendor_Neutral.GE, myVendor_Neutral.Cannon, myVendor_Neutral.Agfa, myVendor_Neutral.Comment, myVendor_Neutral.TrafficLight));
            DataIDs++;
            PhilipsDataLST.Add(new PhilipsData(DataIDs.ToString(), "Concurrent Users", myConcurrent_Users.Philips, myConcurrent_Users.Tera, myConcurrent_Users.Siemens, myConcurrent_Users.GE, myConcurrent_Users.Cannon, myConcurrent_Users.Agfa, myConcurrent_Users.Comment, myConcurrent_Users.TrafficLight));
            DataIDs++;
            PhilipsDataLST.Add(new PhilipsData(DataIDs.ToString(), "System Interoperability", mySystem_Interoperability.Philips, mySystem_Interoperability.Tera, mySystem_Interoperability.Siemens, mySystem_Interoperability.GE, mySystem_Interoperability.Cannon, mySystem_Interoperability.Agfa, mySystem_Interoperability.Comment, mySystem_Interoperability.TrafficLight));
            DataIDs++;
            PhilipsDataLST.Add(new PhilipsData(DataIDs.ToString(), "System Integration", mySystem_Integration.Philips, mySystem_Integration.Tera, mySystem_Integration.Siemens, mySystem_Integration.GE, mySystem_Integration.Cannon, mySystem_Integration.Agfa, mySystem_Integration.Comment, mySystem_Integration.TrafficLight));
            DataIDs++;
            PhilipsDataLST.Add(new PhilipsData(DataIDs.ToString(), "Cloud Medical Imaging", myCloud_Medical_Imaging.Philips, myCloud_Medical_Imaging.Tera, myCloud_Medical_Imaging.Siemens, myCloud_Medical_Imaging.GE, myCloud_Medical_Imaging.Cannon, myCloud_Medical_Imaging.Agfa, myCloud_Medical_Imaging.Comment, myCloud_Medical_Imaging.TrafficLight));
            DataIDs++;
            PhilipsDataLST.Add(new PhilipsData(DataIDs.ToString(), "Artificial Intelligence", myArtificial_Intelligence.Philips, myArtificial_Intelligence.Tera, myArtificial_Intelligence.Siemens, myArtificial_Intelligence.GE, myArtificial_Intelligence.Cannon, myArtificial_Intelligence.Agfa, myArtificial_Intelligence.Comment, myArtificial_Intelligence.TrafficLight));
            DataIDs++;
            PhilipsDataLST.Add(new PhilipsData(DataIDs.ToString(), "Universal Viewer", myUniversal_Viewer.Philips, myUniversal_Viewer.Tera, myUniversal_Viewer.Siemens, myUniversal_Viewer.GE, myUniversal_Viewer.Cannon, myUniversal_Viewer.Agfa, myUniversal_Viewer.Comment, myUniversal_Viewer.TrafficLight));
            DataIDs++;
            PhilipsDataLST.Add(new PhilipsData(DataIDs.ToString(), "Single sign-on", mySingle_sign_on.Philips, mySingle_sign_on.Tera, mySingle_sign_on.Siemens, mySingle_sign_on.GE, mySingle_sign_on.Cannon, mySingle_sign_on.Agfa, mySingle_sign_on.Comment, mySingle_sign_on.TrafficLight));
            DataIDs++;
            PhilipsDataLST.Add(new PhilipsData(DataIDs.ToString(), "3D printing", myThreeD_printing.Philips, myThreeD_printing.Tera, myThreeD_printing.Siemens, myThreeD_printing.GE, myThreeD_printing.Cannon, myThreeD_printing.Agfa, myThreeD_printing.Comment, myThreeD_printing.TrafficLight));
            DataIDs++;
            PhilipsDataLST.Add(new PhilipsData(DataIDs.ToString(), "Cinematic Rendering", myCinematic_Rendering.Philips, myCinematic_Rendering.Tera, myCinematic_Rendering.Siemens, myCinematic_Rendering.GE, myCinematic_Rendering.Cannon, myCinematic_Rendering.Agfa, myCinematic_Rendering.Comment, myCinematic_Rendering.TrafficLight));
            DataIDs++;
            PhilipsDataLST.Add(new PhilipsData(DataIDs.ToString(), "Workflow Tools", myWorkflow_Tools.Philips, myWorkflow_Tools.Tera, myWorkflow_Tools.Siemens, myWorkflow_Tools.GE, myWorkflow_Tools.Cannon, myWorkflow_Tools.Agfa, myWorkflow_Tools.Comment, myWorkflow_Tools.TrafficLight));
            DataIDs++;
            PhilipsDataLST.Add(new PhilipsData(DataIDs.ToString(), "Solution Weaknesses", mySolution_Weaknesses.Philips, mySolution_Weaknesses.Tera, mySolution_Weaknesses.Siemens, mySolution_Weaknesses.GE, mySolution_Weaknesses.Cannon, mySolution_Weaknesses.Agfa, mySolution_Weaknesses.Comment, mySolution_Weaknesses.TrafficLight));
            DataIDs++;
            PhilipsDataLST.Add(new PhilipsData(DataIDs.ToString(), "Solution Strengths", mySolution_Strengths.Philips, mySolution_Strengths.Tera, mySolution_Strengths.Siemens, mySolution_Strengths.GE, mySolution_Strengths.Cannon, mySolution_Strengths.Agfa, mySolution_Strengths.Comment, mySolution_Strengths.TrafficLight));
            DataIDs++;
            PhilipsDataLST.Add(new PhilipsData(DataIDs.ToString(), "Competitive Argumentation", myCompetitive_Argumentation.Philips, myCompetitive_Argumentation.Tera, myCompetitive_Argumentation.Siemens, myCompetitive_Argumentation.GE, myCompetitive_Argumentation.Cannon, myCompetitive_Argumentation.Agfa, myCompetitive_Argumentation.Comment, myCompetitive_Argumentation.TrafficLight));
            //DataIDs++;
            //PhilipsDataLST.Add(new PhilipsData(DataIDs.ToString(), "Additional Comments", myComment.Philips, myComment.Tera, myComment.Siemens, myComment.GE, myComment.Cannon, myComment.Agfa));

            this.Grid1.DataSource = PhilipsDataLST;
            this.Grid1.DataBind();

            Session["CellEditDataSource"] = PhilipsDataLST;

            //this.Grid1.ToolbarSettings.ShowToolbar = false;
           // this.Grid1.EditSettings.AllowEditing = false;

        }
        catch (Exception ex)
        {

        }

    }
    protected void cmdEdit_Click(object sender, EventArgs e)
    {
        try
        {
            SetUpPage();

            this.Grid1.ToolbarSettings.ShowToolbar = true;
            this.Grid1.EditSettings.AllowEditing = true;

                 

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
                    m_UserType = Session["Enterprise"].ToString();
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
                Helper.InsertTracking(m_UserID, "Enterprise", EmailName);
            }
            catch
            {

                Helper.InsertTracking(m_UserID, "Enterprise", "");
            }

           

            if (!IsPostBack)
            {

                SetUpPage();
                this.Grid1.ToolbarSettings.ShowToolbar = false;
                this.Grid1.EditSettings.AllowEditing = false;

            }

        }
        catch { }
    }
}