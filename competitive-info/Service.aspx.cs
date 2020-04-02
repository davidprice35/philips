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
                case "Business Model":
                    Valueidx = 2;
                    break;
                case "Support Services":
                    Valueidx = 3;
                    break;
                case "Remote Support":
                    Valueidx = 4;
                    break;
                case "Business Hour":
                    Valueidx = 5;
                    break;
                case "24/7 Customer Support":
                    Valueidx = 6;
                    break;
                case "Onsite Assistance":
                    Valueidx = 7;
                    break;
                case "Software Services":
                    Valueidx = 8;
                    break;
                case "SW updates and upgrades":
                    Valueidx = 9;
                    break;
                case "Remote Installations":
                    Valueidx = 10;
                    break;
                case "Onsite Installations":
                    Valueidx = 11;
                    break;
                case "Proactive monitoring":
                    Valueidx = 12;
                    break;
                case "Uptime":
                    Valueidx = 13;
                    break;
                case "Virus protection":
                    Valueidx = 14;
                    break;
                case "Usage analytics":
                    Valueidx = 15;
                    break;
                case "Education Services":
                    Valueidx = 16;
                    break;
                case "Clinical and IT training":
                    Valueidx = 17;
                    break;
                case "Education tools":
                    Valueidx = 18;
                    break;
                case "Business Services":
                    Valueidx = 19;
                    break;
                case "Release notes":
                    Valueidx = 20;
                    break;
                case "Release planning":
                    Valueidx = 21;
                    break;
                case "Reporting and Analytics":
                    Valueidx = 22;
                    break;
                case "Customer support portal":
                    Valueidx = 23;
                    break;
                case "Lifecycle Consulting services":
                    Valueidx = 24;
                    break;
                case "Hardware Services":
                    Valueidx = 25;
                    break;
                case "Maintenance and Support":
                    Valueidx = 26;
                    break;
                case "Hardware Refresh":
                    Valueidx = 27;
                    break;
                case "Solution Weaknesses":
                    Valueidx = 28;
                    break;
                case "Solution Strengths":
                    Valueidx = 29;
                    break;
                case "Competitive argumentation":
                    Valueidx = 30;
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
                if (CompData != null)
                {
                    CompData = CompData.Replace("\r\n", "").Replace("\n", "");
                }
            }

            if (CompData == null)
            {
                CompData = "";
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
                case "Business Model":
                    Valueidx = 2;
                    break;
                case "Support Services":
                    Valueidx = 3;
                    break;
                case "Remote Support":
                    Valueidx = 4;
                    break;
                case "Business Hour":
                    Valueidx = 5;
                    break;
                case "24/7 Customer Support":
                    Valueidx = 6;
                    break;
                case "Onsite Assistance":
                    Valueidx = 7;
                    break;
                case "Software Services":
                    Valueidx = 8;
                    break;
                case "SW updates and upgrades":
                    Valueidx = 9;
                    break;
                case "Remote Installations":
                    Valueidx = 10;
                    break;
                case "Onsite Installations":
                    Valueidx = 11;
                    break;
                case "Proactive monitoring":
                    Valueidx = 12;
                    break;
                case "Uptime":
                    Valueidx = 13;
                    break;
                case "Virus protection":
                    Valueidx = 14;
                    break;
                case "Usage analytics":
                    Valueidx = 15;
                    break;
                case "Education Services":
                    Valueidx = 16;
                    break;
                case "Clinical and IT training":
                    Valueidx = 17;
                    break;
                case "Education tools":
                    Valueidx = 18;
                    break;
                case "Business Services":
                    Valueidx = 19;
                    break;
                case "Release notes":
                    Valueidx = 20;
                    break;
                case "Release planning":
                    Valueidx = 21;
                    break;
                case "Reporting and Analytics":
                    Valueidx = 22;
                    break;
                case "Customer support portal":
                    Valueidx = 23;
                    break;
                case "Lifecycle Consulting services":
                    Valueidx = 24;
                    break;
                case "Hardware Services":
                    Valueidx = 25;
                    break;
                case "Maintenance and Support":
                    Valueidx = 26;
                    break;
                case "Hardware Refresh":
                    Valueidx = 27;
                    break;
                case "Solution Weaknesses":
                    Valueidx = 28;
                    break;
                case "Solution Strengths":
                    Valueidx = 29;
                    break;
                case "Competitive argumentation":
                    Valueidx = 30;
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
                                SQL = "INSERT INTO PhilipsAnalysisServiceData_PendingUpdates(NewDataUpdate, OldData, UpdateColumnName, UserID, UserName, Status,Type,Comment,TrafficLightData) VALUES('" + sTrafficLightData + "', '" + sOriginalTrafficLightData + "', '" + sColumnName.Replace(" ", "_") + "_chk', '" + Session["UserID"] + "', '" + Session["User"] + "', 1,'Philips','" + sComment + "','" + sTrafficLightData + "')";
                                GetData(SQL);
                            }
                            SQL = "";
                        }

                        if (CompareData != sColumnPhilips)
                        {
                            SQL = "INSERT INTO PhilipsAnalysisServiceData_PendingUpdates(NewDataUpdate, OldData, UpdateColumnName, UserID, UserName, Status,Type,Comment) VALUES('" + sColumnPhilips + "', '" + CompareData + "', '" + sColumnName + "', '" + Session["UserID"] + "', '" + Session["User"] + "', 1,'Philips','" + sComment + "')";
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
                                SQL = "INSERT INTO PhilipsAnalysisServiceData_PendingUpdates(NewDataUpdate, OldData, UpdateColumnName, UserID, UserName, Status,Type,Comment,TrafficLightData) VALUES('" + sTrafficLightData + "', '" + sOriginalTrafficLightData + "', '" + sColumnName.Replace(" ", "_") + "_chk', '" + Session["UserID"] + "', '" + Session["User"] + "', 1,'Tera','" + sComment + "','" + sTrafficLightData + "')";
                                GetData(SQL);
                            }
                            SQL = "";
                        }

                        if (CompareData != sColumnTera)
                        {
                            SQL = "INSERT INTO PhilipsAnalysisServiceData_PendingUpdates(NewDataUpdate, OldData, UpdateColumnName, UserID, UserName, Status,Type,Comment) VALUES('" + sColumnTera + "', '" + CompareData + "', '" + sColumnName + "', '" + Session["UserID"] + "', '" + Session["User"] + "', 1,'Tera','" + sComment + "')";
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
                                SQL = "INSERT INTO PhilipsAnalysisServiceData_PendingUpdates(NewDataUpdate, OldData, UpdateColumnName, UserID, UserName, Status,Type,Comment,TrafficLightData) VALUES('" + sTrafficLightData + "', '" + sOriginalTrafficLightData + "', '" + sColumnName.Replace(" ", "_") + "_chk', '" + Session["UserID"] + "', '" + Session["User"] + "', 1,'Siemens','" + sComment + "','" + sTrafficLightData + "')";
                                GetData(SQL);
                            }
                            SQL = "";
                        }

                        if (CompareData != sColumnSiemens)
                        {
                            SQL = "INSERT INTO PhilipsAnalysisServiceData_PendingUpdates(NewDataUpdate, OldData, UpdateColumnName, UserID, UserName, Status,Type,Comment) VALUES('" + sColumnSiemens + "', '" + CompareData + "', '" + sColumnName + "', '" + Session["UserID"] + "', '" + Session["User"] + "', 1,'Siemens','" + sComment + "')";
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
                                SQL = "INSERT INTO PhilipsAnalysisServiceData_PendingUpdates(NewDataUpdate, OldData, UpdateColumnName, UserID, UserName, Status,Type,Comment,TrafficLightData) VALUES('" + sTrafficLightData + "', '" + sOriginalTrafficLightData + "', '" + sColumnName.Replace(" ", "_") + "_chk', '" + Session["UserID"] + "', '" + Session["User"] + "', 1,'GE','" + sComment + "','" + sTrafficLightData + "')";
                                GetData(SQL);
                            }
                            SQL = "";
                        }

                        if (CompareData != sColumnGE)
                        {
                            SQL = "INSERT INTO PhilipsAnalysisServiceData_PendingUpdates(NewDataUpdate, OldData, UpdateColumnName, UserID, UserName, Status,Type,Comment) VALUES('" + sColumnGE + "', '" + CompareData + "', '" + sColumnName + "', '" + Session["UserID"] + "', '" + Session["User"] + "', 1,'GE','" + sComment + "')";
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
                                SQL = "INSERT INTO PhilipsAnalysisServiceData_PendingUpdates(NewDataUpdate, OldData, UpdateColumnName, UserID, UserName, Status,Type,Comment,TrafficLightData) VALUES('" + sTrafficLightData + "', '" + sOriginalTrafficLightData + "', '" + sColumnName.Replace(" ", "_") + "_chk', '" + Session["UserID"] + "', '" + Session["User"] + "', 1,'Cannon','" + sComment + "','" + sTrafficLightData + "')";
                                GetData(SQL);
                            }
                            SQL = "";
                        }

                        if (CompareData != sColumnCannon)
                        {
                            SQL = "INSERT INTO PhilipsAnalysisServiceData_PendingUpdates(NewDataUpdate, OldData, UpdateColumnName, UserID, UserName, Status,Type,Comment) VALUES('" + sColumnCannon + "', '" + CompareData + "', '" + sColumnName + "', '" + Session["UserID"] + "', '" + Session["User"] + "', 1,'Cannon','" + sComment + "')";
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
                                SQL = "INSERT INTO PhilipsAnalysisServiceData_PendingUpdates(NewDataUpdate, OldData, UpdateColumnName, UserID, UserName, Status,Type,Comment,TrafficLightData) VALUES('" + sTrafficLightData + "', '" + sOriginalTrafficLightData + "', '" + sColumnName.Replace(" ", "_") + "_chk', '" + Session["UserID"] + "', '" + Session["User"] + "', 1,'Agfa','" + sComment + "','" + sTrafficLightData + "')";
                                GetData(SQL);
                            }
                            SQL = "";
                        }

                        if (CompareData != sColumnAgfa)
                        {
                            SQL = "INSERT INTO PhilipsAnalysisServiceData_PendingUpdates(NewDataUpdate, OldData, UpdateColumnName, UserID, UserName, Status,Type,Comment) VALUES('" + sColumnAgfa + "', '" + CompareData + "', '" + sColumnName + "', '" + Session["UserID"] + "', '" + Session["User"] + "', 1,'Agfa','" + sComment + "')";
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

    protected void EditEvents_ServerEditRow(object sender, GridEventArgs e)
    {
        EditAction(e.EventType, e.Arguments["data"]);
    }


    private void SetUpPage()
    {

        try
        {

            string SQL = "select * from PhilipsAnalysisServiceData";
            DataView MyDV = GetData(SQL);

            PhilipsData mySolution = new PhilipsData();
            PhilipsData myValue_Proposition = new PhilipsData();
            PhilipsData myBusiness_Model = new PhilipsData();
            PhilipsData mySupport_Services = new PhilipsData();
            PhilipsData myRemote_support = new PhilipsData();
            PhilipsData myBusiness_hour = new PhilipsData();
            PhilipsData mytwentyfour_customer = new PhilipsData();
            PhilipsData myOnsite_assistance = new PhilipsData();
            PhilipsData mySoftware_Services = new PhilipsData();
            PhilipsData mySW_updates = new PhilipsData();
            PhilipsData myRemote_installations = new PhilipsData();
            PhilipsData myOnsite = new PhilipsData();
            PhilipsData myProactive = new PhilipsData();
            PhilipsData myUptime = new PhilipsData();
            PhilipsData myEducation_services = new PhilipsData();
            PhilipsData myRelease_notes = new PhilipsData();
            PhilipsData myRelease_planning = new PhilipsData();
            PhilipsData myReporting = new PhilipsData();
            PhilipsData myCustomer_support = new PhilipsData();
            PhilipsData myLifecycle = new PhilipsData();
            PhilipsData myHardware_Services = new PhilipsData();
            PhilipsData myHardware = new PhilipsData();
            PhilipsData myHardwareRefresh = new PhilipsData();
            PhilipsData myMaintenance = new PhilipsData();
            PhilipsData mySolution_Weaknesses = new PhilipsData();
            PhilipsData mySolution_Strengths = new PhilipsData();
            PhilipsData myCompetitive_argumentation = new PhilipsData();
            PhilipsData myComment = new PhilipsData();

            PhilipsData myVirus = new PhilipsData();
            PhilipsData myUsage = new PhilipsData();
            PhilipsData myClinicalTraning = new PhilipsData();
            PhilipsData myEducationtools = new PhilipsData();
            
            
            PhilipsData myBusinessServices = new PhilipsData();
             
            
         

            foreach (DataRowView rowView in MyDV)
            {
                mySolution.ColumnName = "Solution";

                string Solution = rowView["Solution"].ToString();
                string Value_Proposition = rowView["Value_Proposition"].ToString();
                string Business_Model = rowView["Business_Model"].ToString();
                string Support_Services = rowView["Support_Services"].ToString();
                string Remote_support = rowView["Remote_support"].ToString();
                string Business_hour = rowView["Business_hour"].ToString();
                string twentyfour_customer = rowView["twentyfour_customer"].ToString();
                string Onsite_assistance = rowView["Onsite_assistance"].ToString();
                string Software_Services = rowView["Software_Services"].ToString();
                string SW_updates = rowView["SW_updates"].ToString();
                string Remote_installations = rowView["Remote_installations"].ToString();
                string Onsite = rowView["Onsite"].ToString();
                string Proactive = rowView["Proactive"].ToString();
                string Uptime = rowView["Uptime"].ToString();
                string Education_services = rowView["Education_services"].ToString();
                string Release_notes = rowView["Release_notes"].ToString();
                string Release_planning = rowView["Release_planning"].ToString();
                string Reporting = rowView["Reporting"].ToString();
                string Customer_support = rowView["Customer_support"].ToString();
                string Lifecycle = rowView["Lifecycle"].ToString();
                string Hardware_Services = rowView["Hardware_Services"].ToString();
                string Maintenance = rowView["Maintenance"].ToString();
                string Hardware = rowView["Hardware"].ToString();
                string Solution_Weaknesses = rowView["Solution_Weaknesses"].ToString();
                string Solution_Strengths = rowView["Solution_Strengths"].ToString();
                string Competitive_argumentation = rowView["Competitive_argumentation"].ToString();
                string Name = rowView["Name"].ToString();
                string Comment = rowView["Comment"].ToString();
                string Virus = rowView["Virus_protection"].ToString();
                string Usage = rowView["Usage_analytics"].ToString();
                string Clinical_and_IT_training = rowView["Clinical_IT_training"].ToString();
                string Education_tools = rowView["Education_tools"].ToString();

                

                string TrafficLight_Value_Proposition = rowView["Value_Proposition_chk"].ToString();
                string TrafficLight_Business_Model = rowView["Business_Model_chk"].ToString();
                string TrafficLight_Support_Services = rowView["Support_Services_chk"].ToString();
                string TrafficLight_Remote_support = rowView["Remote_support_chk"].ToString();
                string TrafficLight_Business_hour = rowView["Business_hour_chk"].ToString();
                string TrafficLight_twentyfour_customer = rowView["twentyfour_customer_chk"].ToString();
                string TrafficLight_Onsite_assistance = rowView["Onsite_assistance_chk"].ToString();
                string TrafficLight_Software_Services = rowView["Software_Services_chk"].ToString();
                string TrafficLight_SW_updates = rowView["SW_updates_chk"].ToString();
                string TrafficLight_Remote_installations = rowView["Remote_installations_chk"].ToString();
                string TrafficLight_Onsite = rowView["Onsite_Installations_chk"].ToString();
                string TrafficLight_Proactive = rowView["Proactive_chk"].ToString();
                string TrafficLight_Uptime = rowView["Uptime_chk"].ToString();
                string TrafficLight_Education_services = rowView["Education_services_chk"].ToString();
                string TrafficLight_Release_notes = rowView["Release_notes_chk"].ToString();
                string TrafficLight_Release_planning = rowView["Release_planning_chk"].ToString();
                string TrafficLight_Reporting = rowView["Reporting_chk"].ToString();
                string TrafficLight_Customer_support = rowView["Customer_support_chk"].ToString();
                string TrafficLight_Lifecycle = rowView["Lifecycle_chk"].ToString();
                string TrafficLight_Hardware_Services = rowView["Hardware_Services_chk"].ToString();
                string TrafficLight_Maintenance = rowView["Maintenance_chk"].ToString();
                string TrafficLight_Hardware = rowView["Hardware_chk"].ToString();
                string TrafficLight_Solution_Weaknesses = rowView["Solution_Weaknesses_chk"].ToString();
                string TrafficLight_Solution_Strengths = rowView["Solution_Strengths_chk"].ToString();
                string TrafficLight_Competitive_argumentation = rowView["Competitive_argumentation_chk"].ToString();                                
                string TrafficLight_Virus = rowView["Virus_protection_chk"].ToString();
                string TrafficLight_Usage = rowView["Usage_analytics_chk"].ToString();
                string TrafficLight_Clinical_and_IT = rowView["Clinical_IT_training_chk"].ToString();
                string TrafficLight_Education_tools = rowView["Education_tools_chk"].ToString();
                

                switch (Name)
                {
                    case "Philips":
                        mySolution.Philips = "<a  target='_blank' href='https://www.philips.co.nz/healthcare/services/maintenance-services/rightfit-equipment-maintenance?nocache111'>RightFit</a>"; // Solution;
                        myValue_Proposition.Philips = Value_Proposition;
                        myBusiness_Model.Philips = Business_Model;
                        mySupport_Services.Philips = Support_Services;
                        myRemote_support.Philips = Remote_support;
                        myBusiness_hour.Philips = Business_hour;
                        mytwentyfour_customer.Philips = twentyfour_customer;
                        myOnsite_assistance.Philips = Onsite_assistance;
                        mySoftware_Services.Philips = Software_Services;
                        mySW_updates.Philips = SW_updates;
                        myRemote_installations.Philips = Remote_installations;
                        myOnsite.Philips = Onsite;
                        myProactive.Philips = Proactive;
                        myUptime.Philips = Uptime;
                        myVirus.Philips = Virus;
                        myUsage.Philips = Usage;
                        myEducation_services.Philips = Education_services;
                        myRelease_notes.Philips = Release_notes;
                        myRelease_planning.Philips = Release_planning;
                        myReporting.Philips = Reporting;
                        myCustomer_support.Philips = Customer_support;
                        myLifecycle.Philips = Lifecycle;
                        myHardware_Services.Philips = Hardware_Services;
                        myMaintenance.Philips = Maintenance;
                        myHardware.Philips = Hardware;                        
                        mySolution_Weaknesses.Philips = Solution_Weaknesses;
                        mySolution_Strengths.Philips = Solution_Strengths;
                        myCompetitive_argumentation.Philips = Competitive_argumentation;
                        myComment.Philips = Comment;
                        myClinicalTraning.Philips = Clinical_and_IT_training;
                        myEducationtools.Philips = Education_tools;


                        myValue_Proposition.TrafficLight += ";Philips:" + TrafficLight_Value_Proposition;
                        myBusiness_Model.TrafficLight += ";Philips:" + TrafficLight_Business_Model;
                        mySupport_Services.TrafficLight += ";Philips:" + TrafficLight_Support_Services;
                        myRemote_support.TrafficLight += ";Philips:" + TrafficLight_Remote_support;
                        myBusiness_hour.TrafficLight += ";Philips:" + TrafficLight_Business_hour;
                        mytwentyfour_customer.TrafficLight += ";Philips:" + TrafficLight_twentyfour_customer;
                        myOnsite_assistance.TrafficLight += ";Philips:" + TrafficLight_Onsite_assistance;
                        mySoftware_Services.TrafficLight += ";Philips:" + TrafficLight_Software_Services;
                        mySW_updates.TrafficLight += ";Philips:" + TrafficLight_SW_updates;
                        myRemote_installations.TrafficLight += ";Philips:" + TrafficLight_Remote_installations;
                        myOnsite.TrafficLight += ";Philips:" + TrafficLight_Onsite;
                        myProactive.TrafficLight += ";Philips:" + TrafficLight_Proactive;
                        myUptime.TrafficLight += ";Philips:" + TrafficLight_Uptime;
                        myVirus.TrafficLight += ";Philips:" + TrafficLight_Virus;
                        myUsage.TrafficLight += ";Philips:" + TrafficLight_Usage;
                        myEducation_services.TrafficLight += ";Philips:" + TrafficLight_Education_services;
                        myRelease_notes.TrafficLight += ";Philips:" + TrafficLight_Release_notes;
                        myRelease_planning.TrafficLight += ";Philips:" + TrafficLight_Release_planning;
                        myReporting.TrafficLight += ";Philips:" + TrafficLight_Reporting;
                        myCustomer_support.TrafficLight += ";Philips:" + TrafficLight_Customer_support;
                        myLifecycle.TrafficLight += ";Philips:" + TrafficLight_Lifecycle;
                        myHardware_Services.TrafficLight += ";Philips:" + TrafficLight_Hardware_Services;
                        myMaintenance.TrafficLight += ";Philips:" + TrafficLight_Maintenance;
                        myHardware.TrafficLight += ";Philips:" + TrafficLight_Hardware;
                        mySolution_Weaknesses.TrafficLight += ";Philips:" + TrafficLight_Solution_Weaknesses;
                        mySolution_Strengths.TrafficLight += ";Philips:" + TrafficLight_Solution_Strengths;
                        myCompetitive_argumentation.TrafficLight += ";Philips:" + TrafficLight_Competitive_argumentation;
                        myClinicalTraning.TrafficLight += ";Philips:" + TrafficLight_Clinical_and_IT;
                        myEducationtools.TrafficLight += ";Philips:" + TrafficLight_Education_tools;
                        


                        break;
                    case "TeraRecon":
                        mySolution.Tera = "<a  target='_blank' href='https://www.terarecon.com/services/medical-imaging-software-maintenance'>TeraRecon Customer Services</a>"; // Solution;
                        myValue_Proposition.Tera = Value_Proposition;
                        myBusiness_Model.Tera = Business_Model;
                        mySupport_Services.Tera = Support_Services;
                        myRemote_support.Tera = Remote_support;
                        myBusiness_hour.Tera = Business_hour;
                        mytwentyfour_customer.Tera = twentyfour_customer;
                        myOnsite_assistance.Tera = Onsite_assistance;
                        mySoftware_Services.Tera = Software_Services;
                        mySW_updates.Tera = SW_updates;
                        myRemote_installations.Tera = Remote_installations;
                        myOnsite.Tera = Onsite;
                        myProactive.Tera = Proactive;
                        myUptime.Tera = Uptime;
                        myEducation_services.Tera = Education_services;
                        myVirus.Tera = Virus;
                        myUsage.Tera = Usage;
                        myRelease_notes.Tera = Release_notes;
                        myRelease_planning.Tera = Release_planning;
                        myReporting.Tera = Reporting;
                        myCustomer_support.Tera = Customer_support;
                        myLifecycle.Tera = Lifecycle;
                        myHardware_Services.Tera = Hardware_Services;
                        myMaintenance.Tera = Maintenance;
                        myHardware.Tera = Hardware;
                        mySolution_Weaknesses.Tera = Solution_Weaknesses;
                        mySolution_Strengths.Tera = Solution_Strengths;
                        myCompetitive_argumentation.Tera = Competitive_argumentation;
                        myComment.Tera = Comment;
                        myClinicalTraning.Tera = Clinical_and_IT_training;

                        myEducationtools.Tera = Education_tools;
                        myEducationtools.TrafficLight += ";Tera:" + TrafficLight_Education_tools;

                        myClinicalTraning.TrafficLight += ";Tera:" + TrafficLight_Clinical_and_IT;
                        myValue_Proposition.TrafficLight += ";Tera:" + TrafficLight_Value_Proposition;
                        myBusiness_Model.TrafficLight += ";Tera:" + TrafficLight_Business_Model;
                        mySupport_Services.TrafficLight += ";Tera:" + TrafficLight_Support_Services;
                        myRemote_support.TrafficLight += ";Tera:" + TrafficLight_Remote_support;
                        myBusiness_hour.TrafficLight += ";Tera:" + TrafficLight_Business_hour;
                        mytwentyfour_customer.TrafficLight += ";Tera:" + TrafficLight_twentyfour_customer;
                        myOnsite_assistance.TrafficLight += ";Tera:" + TrafficLight_Onsite_assistance;
                        mySoftware_Services.TrafficLight += ";Tera:" + TrafficLight_Software_Services;
                        mySW_updates.TrafficLight += ";Tera:" + TrafficLight_SW_updates;
                        myRemote_installations.TrafficLight += ";Tera:" + TrafficLight_Remote_installations;
                        myOnsite.TrafficLight += ";Tera:" + TrafficLight_Onsite;
                        myProactive.TrafficLight += ";Tera:" + TrafficLight_Proactive;
                        myUptime.TrafficLight += ";Tera:" + TrafficLight_Uptime;
                        myVirus.TrafficLight += ";Tera:" + TrafficLight_Virus;
                        myUsage.TrafficLight += ";Tera:" + TrafficLight_Usage;
                        myEducation_services.TrafficLight += ";Tera:" + TrafficLight_Education_services;
                        myRelease_notes.TrafficLight += ";Tera:" + TrafficLight_Release_notes;
                        myRelease_planning.TrafficLight += ";Tera:" + TrafficLight_Release_planning;
                        myReporting.TrafficLight += ";Tera:" + TrafficLight_Reporting;
                        myCustomer_support.TrafficLight += ";Tera:" + TrafficLight_Customer_support;
                        myLifecycle.TrafficLight += ";Tera:" + TrafficLight_Lifecycle;
                        myHardware_Services.TrafficLight += ";Tera:" + TrafficLight_Hardware_Services;
                        myMaintenance.TrafficLight += ";Tera:" + TrafficLight_Maintenance;
                        myHardware.TrafficLight += ";Tera:" + TrafficLight_Hardware;
                        mySolution_Weaknesses.TrafficLight += ";Tera:" + TrafficLight_Solution_Weaknesses;
                        mySolution_Strengths.TrafficLight += ";Tera:" + TrafficLight_Solution_Strengths;
                        myCompetitive_argumentation.TrafficLight += ";Tera:" + TrafficLight_Competitive_argumentation;

                        break;
                    case "Siemens Medical":
                        mySolution.Siemens = "<a  target='_blank' href='https://www.healthcare.siemens.com/services/customer-services/asset-evolution-services/siemens-it-care-plan'>Siemens IT Care Plan</a>"; // Solution;
                        myValue_Proposition.Siemens = Value_Proposition;
                        myBusiness_Model.Siemens = Business_Model;
                        mySupport_Services.Siemens = Support_Services;
                        myRemote_support.Siemens = Remote_support;
                        myBusiness_hour.Siemens = Business_hour;
                        mytwentyfour_customer.Siemens = twentyfour_customer;
                        myOnsite_assistance.Siemens = Onsite_assistance;
                        myVirus.Siemens = Virus;
                        myUsage.Siemens = Usage;
                        mySoftware_Services.Siemens = Software_Services;
                        mySW_updates.Siemens = SW_updates;
                        myRemote_installations.Siemens = Remote_installations;
                        myOnsite.Siemens = Onsite;
                        myProactive.Siemens = Proactive;
                        myUptime.Siemens = Uptime;
                        myEducation_services.Siemens = Education_services;
                        myRelease_notes.Siemens = Release_notes;
                        myRelease_planning.Siemens = Release_planning;
                        myReporting.Siemens = Reporting;
                        myCustomer_support.Siemens = Customer_support;
                        myLifecycle.Siemens = Lifecycle;
                        myHardware_Services.Siemens = Hardware_Services;
                        myMaintenance.Siemens = Maintenance;
                        myHardware.Siemens = Hardware;
                        mySolution_Weaknesses.Siemens = Solution_Weaknesses;
                        mySolution_Strengths.Siemens = Solution_Strengths;
                        myCompetitive_argumentation.Siemens = Competitive_argumentation;
                        myComment.Siemens = Comment;

                        myEducationtools.Siemens = Education_tools;
                        myEducationtools.TrafficLight += ";Siemens:" + TrafficLight_Education_tools;

                        myClinicalTraning.Siemens = Clinical_and_IT_training;
                        myClinicalTraning.TrafficLight += ";Siemens:" + TrafficLight_Clinical_and_IT;

                        myValue_Proposition.TrafficLight += ";Siemens:" + TrafficLight_Value_Proposition;
                        myBusiness_Model.TrafficLight += ";Siemens:" + TrafficLight_Business_Model;
                        mySupport_Services.TrafficLight += ";Siemens:" + TrafficLight_Support_Services;
                        myRemote_support.TrafficLight += ";Siemens:" + TrafficLight_Remote_support;
                        myBusiness_hour.TrafficLight += ";Siemens:" + TrafficLight_Business_hour;
                        mytwentyfour_customer.TrafficLight += ";Siemens:" + TrafficLight_twentyfour_customer;
                        myOnsite_assistance.TrafficLight += ";Siemens:" + TrafficLight_Onsite_assistance;
                        mySoftware_Services.TrafficLight += ";Siemens:" + TrafficLight_Software_Services;
                        mySW_updates.TrafficLight += ";Siemens:" + TrafficLight_SW_updates;
                        myRemote_installations.TrafficLight += ";Siemens:" + TrafficLight_Remote_installations;
                        myOnsite.TrafficLight += ";Siemens:" + TrafficLight_Onsite;
                        myProactive.TrafficLight += ";Siemens:" + TrafficLight_Proactive;
                        myUptime.TrafficLight += ";Siemens:" + TrafficLight_Uptime;
                        myVirus.TrafficLight += ";Siemens:" + TrafficLight_Virus;
                        myUsage.TrafficLight += ";Siemens:" + TrafficLight_Usage;
                        myEducation_services.TrafficLight += ";Siemens:" + TrafficLight_Education_services;
                        myRelease_notes.TrafficLight += ";Siemens:" + TrafficLight_Release_notes;
                        myRelease_planning.TrafficLight += ";Siemens:" + TrafficLight_Release_planning;
                        myReporting.TrafficLight += ";Siemens:" + TrafficLight_Reporting;
                        myCustomer_support.TrafficLight += ";Siemens:" + TrafficLight_Customer_support;
                        myLifecycle.TrafficLight += ";Siemens:" + TrafficLight_Lifecycle;
                        myHardware_Services.TrafficLight += ";Siemens:" + TrafficLight_Hardware_Services;
                        myMaintenance.TrafficLight += ";Siemens:" + TrafficLight_Maintenance;
                        myHardware.TrafficLight += ";Siemens:" + TrafficLight_Hardware;
                        mySolution_Weaknesses.TrafficLight += ";Siemens:" + TrafficLight_Solution_Weaknesses;
                        mySolution_Strengths.TrafficLight += ";Siemens:" + TrafficLight_Solution_Strengths;
                        myCompetitive_argumentation.TrafficLight += ";Siemens:" + TrafficLight_Competitive_argumentation;
                        break;
                    case "GE Healthcare":
                       //ySolution.GE = "<a  target='_blank' href='http://www3.gehealthcare.com/en/products/categories/advanced_visualization'>AW Server 2</a>"; // Solution;
                        mySolution.GE = "<a  target='_blank' href='http://www3.gehealthcare.com/en/services/healthcare_it_services'>GE Centricity Services</a>"; // Solution;
                        myValue_Proposition.GE = Value_Proposition;
                        myBusiness_Model.GE = Business_Model;
                        mySupport_Services.GE = Support_Services;
                        myRemote_support.GE = Remote_support;
                        myBusiness_hour.GE = Business_hour;
                        mytwentyfour_customer.GE = twentyfour_customer;
                        myOnsite_assistance.GE = Onsite_assistance;
                        mySoftware_Services.GE = Software_Services;
                        mySW_updates.GE = SW_updates;
                        myRemote_installations.GE = Remote_installations;
                        myOnsite.GE = Onsite;
                        myProactive.GE = Proactive;
                        myUptime.GE = Uptime;
                        myEducation_services.GE = Education_services;
                        myRelease_notes.GE = Release_notes;
                        myRelease_planning.GE = Release_planning;
                        myReporting.GE = Reporting;
                        myVirus.GE = Virus;
                        myUsage.GE = Usage;
                        myCustomer_support.GE = Customer_support;
                        myLifecycle.GE = Lifecycle;
                        myHardware_Services.GE = Hardware_Services;
                        myMaintenance.GE = Maintenance;
                        myHardware.GE = Hardware;
                        mySolution_Weaknesses.GE = Solution_Weaknesses;
                        mySolution_Strengths.GE = Solution_Strengths;
                        myCompetitive_argumentation.GE = Competitive_argumentation;
                        myComment.GE = Comment;


                        myEducationtools.GE = Education_tools;
                        myEducationtools.TrafficLight += ";GE:" + TrafficLight_Education_tools;

                        myClinicalTraning.GE = Clinical_and_IT_training;
                        myClinicalTraning.TrafficLight += ";GE:" + TrafficLight_Clinical_and_IT;

                        myValue_Proposition.TrafficLight += ";GE:" + TrafficLight_Value_Proposition;
                        myBusiness_Model.TrafficLight += ";GE:" + TrafficLight_Business_Model;
                        mySupport_Services.TrafficLight += ";GE:" + TrafficLight_Support_Services;
                        myRemote_support.TrafficLight += ";GE:" + TrafficLight_Remote_support;
                        myBusiness_hour.TrafficLight += ";GE:" + TrafficLight_Business_hour;
                        mytwentyfour_customer.TrafficLight += ";GE:" + TrafficLight_twentyfour_customer;
                        myOnsite_assistance.TrafficLight += ";GE:" + TrafficLight_Onsite_assistance;
                        mySoftware_Services.TrafficLight += ";GE:" + TrafficLight_Software_Services;
                        mySW_updates.TrafficLight += ";GE:" + TrafficLight_SW_updates;
                        myRemote_installations.TrafficLight += ";GE:" + TrafficLight_Remote_installations;
                        myOnsite.TrafficLight += ";GE:" + TrafficLight_Onsite;
                        myProactive.TrafficLight += ";GE:" + TrafficLight_Proactive;
                        myUptime.TrafficLight += ";GE:" + TrafficLight_Uptime;
                        myVirus.TrafficLight += ";GE:" + TrafficLight_Virus;
                        myUsage.TrafficLight += ";GE:" + TrafficLight_Usage;
                        myEducation_services.TrafficLight += ";GE:" + TrafficLight_Education_services;
                        myRelease_notes.TrafficLight += ";GE:" + TrafficLight_Release_notes;
                        myRelease_planning.TrafficLight += ";GE:" + TrafficLight_Release_planning;
                        myReporting.TrafficLight += ";GE:" + TrafficLight_Reporting;
                        myCustomer_support.TrafficLight += ";GE:" + TrafficLight_Customer_support;
                        myLifecycle.TrafficLight += ";GE:" + TrafficLight_Lifecycle;
                        myHardware_Services.TrafficLight += ";GE:" + TrafficLight_Hardware_Services;
                        myMaintenance.TrafficLight += ";GE:" + TrafficLight_Maintenance;
                        myHardware.TrafficLight += ";GE:" + TrafficLight_Hardware;
                        mySolution_Weaknesses.TrafficLight += ";GE:" + TrafficLight_Solution_Weaknesses;
                        mySolution_Strengths.TrafficLight += ";GE:" + TrafficLight_Solution_Strengths;
                        myCompetitive_argumentation.TrafficLight += ";GE:" + TrafficLight_Competitive_argumentation;

                        break;
                    case "Canon/Toshiba/Vital":
                        mySolution.Cannon = "<a  target='_blank' href='http://www.vitalimages.com/customer-success-support-program/#1475109874167-f704f6b3-923a'>Vital Service & Support</a>"; // Solution;
                        myValue_Proposition.Cannon = Value_Proposition;
                        myBusiness_Model.Cannon = Business_Model;
                        mySupport_Services.Cannon = Support_Services;
                        myRemote_support.Cannon = Remote_support;
                        myBusiness_hour.Cannon = Business_hour;
                        mytwentyfour_customer.Cannon = twentyfour_customer;
                        myOnsite_assistance.Cannon = Onsite_assistance;
                        mySoftware_Services.Cannon = Software_Services;
                        mySW_updates.Cannon = SW_updates;
                        myRemote_installations.Cannon = Remote_installations;
                        myOnsite.Cannon = Onsite;
                        myProactive.Cannon = Proactive;
                        myUptime.Cannon = Uptime;
                        myEducation_services.Cannon = Education_services;
                        myRelease_notes.Cannon = Release_notes;
                        myRelease_planning.Cannon = Release_planning;
                        myReporting.Cannon = Reporting;
                        myVirus.Cannon = Virus;
                        myUsage.Cannon = Usage;
                        myCustomer_support.Cannon = Customer_support;
                        myLifecycle.Cannon = Lifecycle;
                        myHardware_Services.Cannon = Hardware_Services;
                        myMaintenance.Cannon = Maintenance;
                        myHardware.Cannon = Hardware;
                        mySolution_Weaknesses.Cannon = Solution_Weaknesses;
                        mySolution_Strengths.Cannon = Solution_Strengths;
                        myCompetitive_argumentation.Cannon = Competitive_argumentation;
                        myComment.Cannon = Comment;

                        myEducationtools.Cannon = Education_tools;
                        myEducationtools.TrafficLight += ";Cannon:" + TrafficLight_Education_tools;

                        myClinicalTraning.Cannon = Clinical_and_IT_training;
                        myClinicalTraning.TrafficLight += ";Cannon:" + TrafficLight_Clinical_and_IT;

                        myValue_Proposition.TrafficLight += ";Cannon:" + TrafficLight_Value_Proposition;
                        myBusiness_Model.TrafficLight += ";Cannon:" + TrafficLight_Business_Model;
                        mySupport_Services.TrafficLight += ";Cannon:" + TrafficLight_Support_Services;
                        myRemote_support.TrafficLight += ";Cannon:" + TrafficLight_Remote_support;
                        myBusiness_hour.TrafficLight += ";Cannon:" + TrafficLight_Business_hour;
                        mytwentyfour_customer.TrafficLight += ";Cannon:" + TrafficLight_twentyfour_customer;
                        myOnsite_assistance.TrafficLight += ";Cannon:" + TrafficLight_Onsite_assistance;
                        mySoftware_Services.TrafficLight += ";Cannon:" + TrafficLight_Software_Services;
                        mySW_updates.TrafficLight += ";Cannon:" + TrafficLight_SW_updates;
                        myRemote_installations.TrafficLight += ";Cannon:" + TrafficLight_Remote_installations;
                        myOnsite.TrafficLight += ";Cannon:" + TrafficLight_Onsite;
                        myProactive.TrafficLight += ";Cannon:" + TrafficLight_Proactive;
                        myUptime.TrafficLight += ";Cannon:" + TrafficLight_Uptime;
                        myVirus.TrafficLight += ";Cannon:" + TrafficLight_Virus;
                        myUsage.TrafficLight += ";Cannon:" + TrafficLight_Usage;
                        myEducation_services.TrafficLight += ";Cannon:" + TrafficLight_Education_services;
                        myRelease_notes.TrafficLight += ";Cannon:" + TrafficLight_Release_notes;
                        myRelease_planning.TrafficLight += ";Cannon:" + TrafficLight_Release_planning;
                        myReporting.TrafficLight += ";Cannon:" + TrafficLight_Reporting;
                        myCustomer_support.TrafficLight += ";Cannon:" + TrafficLight_Customer_support;
                        myLifecycle.TrafficLight += ";Cannon:" + TrafficLight_Lifecycle;
                        myHardware_Services.TrafficLight += ";Cannon:" + TrafficLight_Hardware_Services;
                        myMaintenance.TrafficLight += ";Cannon:" + TrafficLight_Maintenance;
                        myHardware.TrafficLight += ";Cannon:" + TrafficLight_Hardware;
                        mySolution_Weaknesses.TrafficLight += ";Cannon:" + TrafficLight_Solution_Weaknesses;
                        mySolution_Strengths.TrafficLight += ";Cannon:" + TrafficLight_Solution_Strengths;
                        myCompetitive_argumentation.TrafficLight += ";Cannon:" + TrafficLight_Competitive_argumentation;
                        break;
                    case "Agfa Healthcare":
                        mySolution.Agfa = "<a  target='_blank' href='https://global.agfahealthcare.com/main/enterprise-imaging/services-new/'>Agfa enterprise services </a>"; // Solution;
                        myValue_Proposition.Agfa = Value_Proposition;
                        myBusiness_Model.Agfa = Business_Model;
                        mySupport_Services.Agfa = Support_Services;
                        myRemote_support.Agfa = Remote_support;
                        myBusiness_hour.Agfa = Business_hour;
                        mytwentyfour_customer.Agfa = twentyfour_customer;
                        myOnsite_assistance.Agfa = Onsite_assistance;
                        mySoftware_Services.Agfa = Software_Services;
                        mySW_updates.Agfa = SW_updates;
                        myRemote_installations.Agfa = Remote_installations;
                        myOnsite.Agfa = Onsite;
                        myProactive.Agfa = Proactive;
                        myUptime.Agfa = Uptime;
                        myEducation_services.Agfa = Education_services;
                        myRelease_notes.Agfa = Release_notes;
                        myRelease_planning.Agfa = Release_planning;
                        myReporting.Agfa = Reporting;
                        myVirus.Agfa = Virus;
                        myUsage.Agfa = Usage;
                        myCustomer_support.Agfa = Customer_support;
                        myLifecycle.Agfa = Lifecycle;
                        myHardware_Services.Agfa = Hardware_Services;
                        myMaintenance.Agfa = Maintenance;
                        myHardware.Agfa = Hardware;
                        mySolution_Weaknesses.Agfa = Solution_Weaknesses;
                        mySolution_Strengths.Agfa = Solution_Strengths;
                        myCompetitive_argumentation.Agfa = Competitive_argumentation;
                        myComment.Agfa = Comment;

                        myEducationtools.Agfa = Education_tools;
                        myEducationtools.TrafficLight += ";Agfa:" + TrafficLight_Education_tools;

                        myClinicalTraning.Agfa = Clinical_and_IT_training;
                        myClinicalTraning.TrafficLight += ";Agfa:" + TrafficLight_Clinical_and_IT;

                        myValue_Proposition.TrafficLight += ";Agfa:" + TrafficLight_Value_Proposition;
                        myBusiness_Model.TrafficLight += ";Agfa:" + TrafficLight_Business_Model;
                        mySupport_Services.TrafficLight += ";Agfa:" + TrafficLight_Support_Services;
                        myRemote_support.TrafficLight += ";Agfa:" + TrafficLight_Remote_support;
                        myBusiness_hour.TrafficLight += ";Agfa:" + TrafficLight_Business_hour;
                        mytwentyfour_customer.TrafficLight += ";Agfa:" + TrafficLight_twentyfour_customer;
                        myOnsite_assistance.TrafficLight += ";Agfa:" + TrafficLight_Onsite_assistance;
                        mySoftware_Services.TrafficLight += ";Agfa:" + TrafficLight_Software_Services;
                        mySW_updates.TrafficLight += ";Agfa:" + TrafficLight_SW_updates;
                        myRemote_installations.TrafficLight += ";Agfa:" + TrafficLight_Remote_installations;
                        myOnsite.TrafficLight += ";Agfa:" + TrafficLight_Onsite;
                        myProactive.TrafficLight += ";Agfa:" + TrafficLight_Proactive;
                        myUptime.TrafficLight += ";Agfa:" + TrafficLight_Uptime;
                        myVirus.TrafficLight += ";Agfa:" + TrafficLight_Virus;
                        myUsage.TrafficLight += ";Agfa:" + TrafficLight_Usage;
                        myEducation_services.TrafficLight += ";Agfa:" + TrafficLight_Education_services;
                        myRelease_notes.TrafficLight += ";Agfa:" + TrafficLight_Release_notes;
                        myRelease_planning.TrafficLight += ";Agfa:" + TrafficLight_Release_planning;
                        myReporting.TrafficLight += ";Agfa:" + TrafficLight_Reporting;
                        myCustomer_support.TrafficLight += ";Agfa:" + TrafficLight_Customer_support;
                        myLifecycle.TrafficLight += ";Agfa:" + TrafficLight_Lifecycle;
                        myHardware_Services.TrafficLight += ";Agfa:" + TrafficLight_Hardware_Services;
                        myMaintenance.TrafficLight += ";Agfa:" + TrafficLight_Maintenance;
                        myHardware.TrafficLight += ";Agfa:" + TrafficLight_Hardware;
                        mySolution_Weaknesses.TrafficLight += ";Agfa:" + TrafficLight_Solution_Weaknesses;
                        mySolution_Strengths.TrafficLight += ";Agfa:" + TrafficLight_Solution_Strengths;
                        myCompetitive_argumentation.TrafficLight += ";Agfa:" + TrafficLight_Competitive_argumentation;
                        break;

                }

            }

            int DataIDs = 1;

            PhilipsDataLST = new List<PhilipsData>();

            PhilipsDataLST.Add(new PhilipsData(DataIDs.ToString(), "Solution", mySolution.Philips, mySolution.Tera, mySolution.Siemens, mySolution.GE, mySolution.Cannon, mySolution.Agfa, mySolution.Comment, mySolution.TrafficLight));
            DataIDs++;
            PhilipsDataLST.Add(new PhilipsData(DataIDs.ToString(), "Value Proposition", myValue_Proposition.Philips, myValue_Proposition.Tera, myValue_Proposition.Siemens, myValue_Proposition.GE, myValue_Proposition.Cannon, myValue_Proposition.Agfa, myValue_Proposition.Comment, myValue_Proposition.TrafficLight));
            DataIDs++;
            PhilipsDataLST.Add(new PhilipsData(DataIDs.ToString(), "Business Model", myBusiness_Model.Philips, myBusiness_Model.Tera, myBusiness_Model.Siemens, myBusiness_Model.GE, myBusiness_Model.Cannon, myBusiness_Model.Agfa, myBusiness_Model.Comment, myBusiness_Model.TrafficLight));
            DataIDs++;
            PhilipsDataLST.Add(new PhilipsData(DataIDs.ToString(), "Support Services", mySupport_Services.Philips, mySupport_Services.Tera, mySupport_Services.Siemens, mySupport_Services.GE, mySupport_Services.Cannon, mySupport_Services.Agfa, mySupport_Services.Comment, mySupport_Services.TrafficLight));
            DataIDs++;
            PhilipsDataLST.Add(new PhilipsData(DataIDs.ToString(), "Remote Support", myRemote_support.Philips, myRemote_support.Tera, myRemote_support.Siemens, myRemote_support.GE, myRemote_support.Cannon, myRemote_support.Agfa, myRemote_support.Comment, myRemote_support.TrafficLight));
            DataIDs++;
            PhilipsDataLST.Add(new PhilipsData(DataIDs.ToString(), "Business Hour", myBusiness_hour.Philips, myBusiness_hour.Tera, myBusiness_hour.Siemens, myBusiness_hour.GE, myBusiness_hour.Cannon, myBusiness_hour.Agfa, myBusiness_hour.Comment, myBusiness_hour.TrafficLight));
            DataIDs++;                 
            PhilipsDataLST.Add(new PhilipsData(DataIDs.ToString(), "24/7 Customer Support", mytwentyfour_customer.Philips, mytwentyfour_customer.Tera, mytwentyfour_customer.Siemens, mytwentyfour_customer.GE, mytwentyfour_customer.Cannon, mytwentyfour_customer.Agfa, mytwentyfour_customer.Comment, mytwentyfour_customer.TrafficLight));
            DataIDs++;
            PhilipsDataLST.Add(new PhilipsData(DataIDs.ToString(), "Onsite Assistance", myOnsite_assistance.Philips, myOnsite_assistance.Tera, myOnsite_assistance.Siemens, myOnsite_assistance.GE, myOnsite_assistance.Cannon, myOnsite_assistance.Agfa, myOnsite_assistance.Comment, myOnsite_assistance.TrafficLight));
            DataIDs++;
            PhilipsDataLST.Add(new PhilipsData(DataIDs.ToString(), "Software Services", mySoftware_Services.Philips, mySoftware_Services.Tera, mySoftware_Services.Siemens, mySoftware_Services.GE, mySoftware_Services.Cannon, mySoftware_Services.Agfa, mySoftware_Services.Comment, mySoftware_Services.TrafficLight));
            DataIDs++;
            PhilipsDataLST.Add(new PhilipsData(DataIDs.ToString(), "SW updates and upgrades", mySW_updates.Philips, mySW_updates.Tera, mySW_updates.Siemens, mySW_updates.GE, mySW_updates.Cannon, mySW_updates.Agfa, mySW_updates.Comment, mySW_updates.TrafficLight));
            DataIDs++;
            PhilipsDataLST.Add(new PhilipsData(DataIDs.ToString(), "Remote Installations", myRemote_installations.Philips, myRemote_installations.Tera, myRemote_installations.Siemens, myRemote_installations.GE, myRemote_installations.Cannon, myRemote_installations.Agfa, myRemote_installations.Comment, myRemote_installations.TrafficLight));
            DataIDs++;
            PhilipsDataLST.Add(new PhilipsData(DataIDs.ToString(), "Onsite Installations", myOnsite.Philips, myOnsite.Tera, myOnsite.Siemens, myOnsite.GE, myOnsite.Cannon, myOnsite.Agfa, myOnsite.Comment, myOnsite.TrafficLight));
            DataIDs++;
            PhilipsDataLST.Add(new PhilipsData(DataIDs.ToString(), "Proactive monitoring", myProactive.Philips, myProactive.Tera, myProactive.Siemens, myProactive.GE, myProactive.Cannon, myProactive.Agfa, myProactive.Comment, myProactive.TrafficLight));
            DataIDs++;
            PhilipsDataLST.Add(new PhilipsData(DataIDs.ToString(), "Uptime", myUptime.Philips, myUptime.Tera, myUptime.Siemens, myUptime.GE, myUptime.Cannon, myUptime.Agfa, myUptime.Comment, myUptime.TrafficLight));
            DataIDs++;
            PhilipsDataLST.Add(new PhilipsData(DataIDs.ToString(), "Virus protection", myVirus.Philips, myVirus.Tera, myVirus.Siemens, myVirus.GE, myVirus.Cannon, myVirus.Agfa, myVirus.Comment, myVirus.TrafficLight));
            DataIDs++;
            PhilipsDataLST.Add(new PhilipsData(DataIDs.ToString(), "Usage analytics", myUsage.Philips, myUsage.Tera, myUsage.Siemens, myUsage.GE, myUsage.Cannon, myUsage.Agfa, myUsage.Comment, myUsage.TrafficLight));


            DataIDs++;
            PhilipsDataLST.Add(new PhilipsData(DataIDs.ToString(), "Education Services", myEducation_services.Philips, myEducation_services.Tera, myEducation_services.Siemens, myEducation_services.GE, myEducation_services.Cannon, myEducation_services.Agfa, myEducation_services.Comment, myEducation_services.TrafficLight));

            DataIDs++;
            PhilipsDataLST.Add(new PhilipsData(DataIDs.ToString(), "Clinical and IT training", myClinicalTraning.Philips, myClinicalTraning.Tera, myClinicalTraning.Siemens, myClinicalTraning.GE, myClinicalTraning.Cannon, myClinicalTraning.Agfa, myClinicalTraning.Comment, myClinicalTraning.TrafficLight));

            DataIDs++;
            PhilipsDataLST.Add(new PhilipsData(DataIDs.ToString(), "Education tools", myEducationtools.Philips, myEducationtools.Tera, myEducationtools.Siemens, myEducationtools.GE, myEducationtools.Cannon, myEducationtools.Agfa, myEducationtools.Comment, myEducationtools.TrafficLight));
            DataIDs++;
            PhilipsDataLST.Add(new PhilipsData(DataIDs.ToString(), "Business Services", myBusinessServices.Philips, myBusinessServices.Tera, myBusinessServices.Siemens, myBusinessServices.GE, myBusinessServices.Cannon, myBusinessServices.Agfa, myBusinessServices.Comment, myBusinessServices.TrafficLight));
            DataIDs++;
            PhilipsDataLST.Add(new PhilipsData(DataIDs.ToString(), "Release notes", myRelease_notes.Philips, myRelease_notes.Tera, myRelease_notes.Siemens, myRelease_notes.GE, myRelease_notes.Cannon, myRelease_notes.Agfa, myRelease_notes.Comment, myRelease_notes.TrafficLight));
            DataIDs++;
            PhilipsDataLST.Add(new PhilipsData(DataIDs.ToString(), "Release planning", myRelease_planning.Philips, myRelease_planning.Tera, myRelease_planning.Siemens, myRelease_planning.GE, myRelease_planning.Cannon, myRelease_planning.Agfa, myRelease_planning.Comment, myRelease_planning.TrafficLight));
            DataIDs++;
            PhilipsDataLST.Add(new PhilipsData(DataIDs.ToString(), "Reporting and Analytics", myReporting.Philips, myReporting.Tera, myReporting.Siemens, myReporting.GE, myReporting.Cannon, myReporting.Agfa, myReporting.Comment, myReporting.TrafficLight));
            DataIDs++;
            PhilipsDataLST.Add(new PhilipsData(DataIDs.ToString(), "Customer support portal", myCustomer_support.Philips, myCustomer_support.Tera, myCustomer_support.Siemens, myCustomer_support.GE, myCustomer_support.Cannon, myCustomer_support.Agfa, myCustomer_support.Comment, myCustomer_support.TrafficLight));
            DataIDs++;
            PhilipsDataLST.Add(new PhilipsData(DataIDs.ToString(), "Lifecycle Consulting services", myLifecycle.Philips, myLifecycle.Tera, myLifecycle.Siemens, myLifecycle.GE, myLifecycle.Cannon, myLifecycle.Agfa, myLifecycle.Comment, myLifecycle.TrafficLight));
            DataIDs++;
            PhilipsDataLST.Add(new PhilipsData(DataIDs.ToString(), "Hardware Services", myHardware_Services.Philips, myHardware_Services.Tera, myHardware_Services.Siemens, myHardware_Services.GE, myHardware_Services.Cannon, myHardware_Services.Agfa, myHardware_Services.Comment, myHardware_Services.TrafficLight));
            DataIDs++;
            PhilipsDataLST.Add(new PhilipsData(DataIDs.ToString(), "Maintenance and Support", myMaintenance.Philips, myMaintenance.Tera, myMaintenance.Siemens, myMaintenance.GE, myMaintenance.Cannon, myMaintenance.Agfa, myMaintenance.Comment, myMaintenance.TrafficLight));
            DataIDs++;
            PhilipsDataLST.Add(new PhilipsData(DataIDs.ToString(), "Hardware Refresh", myHardware.Philips, myHardware.Tera, myHardware.Siemens, myHardware.GE, myHardware.Cannon, myHardware.Agfa, myHardware.Comment, myHardware.TrafficLight));
            DataIDs++;
            PhilipsDataLST.Add(new PhilipsData(DataIDs.ToString(), "Solution Weaknesses", mySolution_Weaknesses.Philips, mySolution_Weaknesses.Tera, mySolution_Weaknesses.Siemens, mySolution_Weaknesses.GE, mySolution_Weaknesses.Cannon, mySolution_Weaknesses.Agfa, mySolution_Weaknesses.Comment, mySolution_Weaknesses.TrafficLight));
            DataIDs++;
            PhilipsDataLST.Add(new PhilipsData(DataIDs.ToString(), "Solution Strengths", mySolution_Strengths.Philips, mySolution_Strengths.Tera, mySolution_Strengths.Siemens, mySolution_Strengths.GE, mySolution_Strengths.Cannon, mySolution_Strengths.Agfa, mySolution_Strengths.Comment, mySolution_Strengths.TrafficLight));
            DataIDs++;
            PhilipsDataLST.Add(new PhilipsData(DataIDs.ToString(), "Competitive argumentation", myCompetitive_argumentation.Philips, myCompetitive_argumentation.Tera, myCompetitive_argumentation.Siemens, myCompetitive_argumentation.GE, myCompetitive_argumentation.Cannon, myCompetitive_argumentation.Agfa, myCompetitive_argumentation.Comment, myCompetitive_argumentation.TrafficLight));



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
    protected void cmdServices_Click(object sender, EventArgs e)
    {
        try
        {
            this.Grid1.ToolbarSettings.ShowToolbar = false;
            this.Grid1.EditSettings.AllowEditing = false;
            SetUpPage();
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
                    m_UserType = Session["Services"].ToString();
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
                Helper.InsertTracking(m_UserID, "Services", EmailName);
            }
            catch
            {

                Helper.InsertTracking(m_UserID, "Services", "");
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