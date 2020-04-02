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
using Syncfusion.JavaScript.Models;


using Syncfusion.JavaScript.Web;


public partial class competitive_info_Test : System.Web.UI.Page
{

    List<Orders> order = new List<Orders>();
    List<string> str = new List<string>();

    

    protected void Page_Load(object sender, EventArgs e)
    {
        BindDataSource();
    }
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

    private void BindDataSource()
    {
        int code = 10000;

        string SQL = "SELECT * FROM PhilipsAnalysisClinicalData WHERE(Approved = 1) AND Competitor in('PHILIPS')";

        DataView MyDV = GetData(SQL);


        order.Add(new Orders(code + 1, "Application", MyDV, "Competitor"));
        order.Add(new Orders(code + 1, "Philips matching application", MyDV, "ACTUALAPP"));
        order.Add(new Orders(code + 1, "Clinical domain", MyDV, "Clinical"));
        order.Add(new Orders(code + 1, "Modality", MyDV, "Modality"));
        order.Add(new Orders(code + 1, "510K", MyDV, "510K"));
        order.Add(new Orders(code + 1, "Overview", MyDV, "Overview"));
        order.Add(new Orders(code + 1, "Application Weaknesses", MyDV, "Competitor"));
        order.Add(new Orders(code + 1, "Application strengths", MyDV, "Competitor"));
        order.Add(new Orders(code + 1, "Competitive Argumentation", MyDV, "Competitor"));
        order.Add(new Orders(code + 1, "Argumentation", MyDV, "Competitor"));






        List<Column> col = new List<Column>();


        col.Add(new Column() { Field = "OrderID", HeaderText = "OrderID", Width = 180, });
        col.Add(new Column() { Field = "ColumnName", HeaderText = "", Width = 200, });

        int idx = 0;
        foreach (DataRowView rowView in MyDV)
        {
            col.Add(new Column() { Field = "DataRowElement." + idx, HeaderText = rowView["Competitor"].ToString(), Width = 180, });
            idx++;
        }




        this.Grid1.DataSource = order;
        this.Grid1.Model.Columns = col;
        this.Grid1.DataBind();
    }

    [Serializable]
    public class Orders
    {
        public Orders()
        {

        }

        private string GetMultipleData(DataRowView rowView, string DataType)
        {
            
            string MyItem = string.Empty;
            string DataItem = string.Empty;

            try
            {
               

               

                    if (DataType == "Modality")
                    {
                        if (rowView["NM_MI"].ToString() != "")
                        {
                            DataItem += rowView["NM_MI"].ToString() + ",";
                        }

                        if (rowView["NM_MI"].ToString() != "")
                        {
                            DataItem += rowView["NM_MI"].ToString() + ",";
                        }

                        if (rowView["CT"].ToString() != "")
                        {
                            DataItem += rowView["CT"].ToString() + ",";
                        }

                        if (rowView["MR"].ToString() != "")
                        {
                            DataItem += rowView["MR"].ToString() + ",";
                        }

                        if (rowView["US"].ToString() != "")
                        {
                            DataItem += rowView["US"].ToString() + ",";
                        }

                        if (rowView["PET"].ToString() != "")
                        {
                            DataItem += rowView["PET"].ToString() + ",";
                        }

                        if (rowView["MM"].ToString() != "")
                        {
                            DataItem += rowView["MM"].ToString() + ",";
                        }

                        //if (DataItem != "")
                        //{
                        //    DataItem = "";
                        //    // DataItem = DataItem.Substring(0, DataItem.Length - 1).Trim();
                        //    sublist.Add(DataItem);

                        //}
                        //else
                        //{
                        //    DataItem = "";
                        //    sublist.Add(DataItem);
                        //}
                    }
                    else
                    {

                        if (rowView["CARD"].ToString() != "")
                        {
                            DataItem += rowView["CARD"].ToString() + ",";
                        }

                        if (rowView["EMER"].ToString() != "")
                        {
                            DataItem += rowView["EMER"].ToString() + ",";
                        }

                        if (rowView["NEUR"].ToString() != "")
                        {
                            DataItem += rowView["NEUR"].ToString() + ",";
                        }

                        if (rowView["ORTH"].ToString() != "")
                        {
                            DataItem += rowView["ORTH"].ToString() + ",";
                        }

                        if (rowView["ONCO"].ToString() != "")
                        {
                            DataItem += rowView["ONCO"].ToString() + ",";
                        }

                        if (rowView["VASC"].ToString() != "")
                        {
                            DataItem += rowView["VASC"].ToString() + ",";
                        }


                        //if (DataItem != "")
                        //{
                        //    DataItem = "";
                        //    //DataItem = DataItem.Substring(0, DataItem.Length - 1).Trim();
                        //    sublist.Add(DataItem);

                        //}
                        //else
                        //{
                        //    DataItem = "";
                        //    sublist.Add(DataItem);
                        //}

                        //switch (Item_Name)
                        //{
                        //    case "CARD":
                        //    case "EMER":
                        //    case "NEUR":
                        //    case "ORTH":
                        //    case "ONCO":
                        //    case "VASC":
                        //        if (Item_Description != "")
                        //        {
                        //            sublist.Add(Item_Description);
                        //        }
                        //        break;

                        //}
                    }


            






            }
            catch { }

            return DataItem;

        }

        public Orders(long OrderId, string ColumnName, DataView MyDV,string RowName)
        {
            this.OrderID = OrderId;            
            this.ColumnName = ColumnName;

           

            this.DataRowElement = new List<string>();

            foreach (DataRowView rowView in MyDV)
            {

                switch (RowName)
                {
                    case "Modality":
                        string GetItem = GetMultipleData(rowView, "Modality");
                        if (GetItem != "")
                        {
                            GetItem = GetItem.Substring(0, GetItem.Length - 1).Trim();
                        }
                        this.DataRowElement.Add(GetItem);
                    break;
                    case "Clinical":
                        string GetItemClinical = GetMultipleData(rowView, "Clinical");
                        if (GetItemClinical != "")
                        {
                            GetItemClinical = GetItemClinical.Substring(0, GetItemClinical.Length - 1).Trim();
                        }
                        this.DataRowElement.Add(GetItemClinical);                        
                        break;

                    default:
                        this.DataRowElement.Add(rowView[RowName].ToString());
                        break;
                }

            }




        }
        public long OrderID { get; set; }
        public string ColumnName { get; set; }        
        public List<string> DataRowElement { get; set; }
       
    }
   

}
