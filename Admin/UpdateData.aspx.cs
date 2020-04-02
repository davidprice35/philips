using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Microsoft.Practices.EnterpriseLibrary.Data;
using System.Data;
using System.Data.SqlClient;
using System.Data.Common;
using Newtonsoft.Json;
using System.Web.Services;
using System.Web.Script.Serialization;
using System.IO;



public partial class Admin_UpdateData : System.Web.UI.Page
{


    [WebMethod]
    public static string UpdateAllData(string Item1, string email)
    {

        return "";

    }



    private string GetJSONData(Dictionary<string, object> JSONDic, string ItemName)
    {
        string MyData = string.Empty;

        try
        {


            MyData = JSONDic[ItemName].ToString();




        }
        catch { }

        return MyData;
    }

    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {


            var reader = new StreamReader(Request.InputStream);

            string x = reader.ReadToEnd();
            string xml = HttpUtility.UrlDecode(x);
            string UserName = string.Empty;


            if (Session["User"] != null)
            {
                UserName = Session["User"].ToString();
            }



            Dictionary<string, object> JSONDic = new Dictionary<string, object>();
            JavaScriptSerializer js = new JavaScriptSerializer();

            JSONDic = js.Deserialize<Dictionary<string, object>>(xml);

            string PhilipsID = JSONDic["PhilipsID"].ToString();
            string PhilipsDataID = JSONDic["PhilipsMatrixDataID"].ToString();

            if (JSONDic["Domain"].ToString() == "")
            {
                //Its a main element and update only first element
            }
            else
            {

                string Vendor = JSONDic["Vendor"].ToString();
                string Model = "";// JSONDic["Model"].ToString();

                string sSQLModel = "SELECT  Model FROM PhilipsMatrixData WHERE(PhilipsMatrixDataID = " + PhilipsDataID + ")";
                DataView MyDV = Helper.GetData(sSQLModel);

                foreach (DataRowView rowView in MyDV)
                {
                    Model = rowView["Model"].ToString();
                    break;
                }

                string Software = JSONDic["Software"].ToString();
                string DataElement = JSONDic["DataElement"].ToString();
                string ISP = GetJSONData(JSONDic, "ISP");
                string AppType = JSONDic["AppType"].ToString();
                string Domain = JSONDic["Domain"].ToString();
                string Module = GetJSONData(JSONDic, "Module");
                string Definition = JSONDic["Definition"].ToString();
                string AddtionalNotes = GetJSONData(JSONDic, "AddtionalNotes");
                string Notes = GetJSONData(JSONDic, "Notes");

                string SQL = "INSERT INTO PhilipsMatrixData_PendingUpdates(PhilipsID, PhilipsMatrixDataID, Vendor, Model, Software, DataElement, ISP, AppType, Domain, Module, Definition,AddtionalNotes,Notes,UserName) VALUES(";
                SQL = SQL + PhilipsID + ", " + PhilipsDataID + ", '" + Vendor + "', '" + Model + "', '" + Software + "', '" + DataElement + "', '" + ISP + "', '" + AppType + "', '" + Domain + "', '" + Module + "', '" + Definition + "','" + AddtionalNotes + "','" + Notes + "','" + UserName + "')";


                Helper.InsertData(SQL);

            }

        }
        catch (Exception ex)
        {

        }
    }
}