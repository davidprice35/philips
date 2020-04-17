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

public partial class lic_server_apidata : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        int IntelliSpace_licenses = 0;
        int Licence = 0;

        try {


            //            {
            //                "text": {
            //                    "id": "file",
            //  "value": "File",  
            //}
            //            }
            bool HasZFP = false;
            string Category = string.Empty;
            string enterpriseuser = Request.Form["enterpriseuser"].ToString();
            string concurentusers = Request.Form["concurentusers"].ToString();
            string selectedapplication = Request.Form["selectedapplication"].ToString();
            string NumberofLicenses = string.Empty;

            if (selectedapplication!="")
            {
                string[] words = selectedapplication.Split('|');
                selectedapplication = words[0];

                string SQL = "SELECT* FROM travelma2_phil1.PhilipsLic_Applications where Applications = '"+ selectedapplication + "'";
                DataView MyDV = Helper.GetData(SQL);               
                foreach (DataRowView rowView in MyDV)
                {
                    Category = rowView["Category"].ToString();  
                    
                    switch(Category)
                    {
                        case "Zerofootprint Software":
                            Category = "ZFP";
                            HasZFP = true;
                                break;
                    }

                }
               
            }


            //get licence data
            if (HasZFP == true)
            {
               

                string SQL = "SELECT * FROM travelma2_phil1.PhilipsLic_Licence where Type ='IntelliSpace ZFP' and rangefrom <= "+ enterpriseuser + " and rangeto >= " + enterpriseuser + " and addtionalrangefrom <="+ concurentusers + " and addtionalrangeto >=" + concurentusers ;
                DataView MyDV = Helper.GetData(SQL);
                foreach (DataRowView rowView in MyDV)
                {
                    IntelliSpace_licenses = Convert.ToInt32( rowView["IntelliSpace_licenses"].ToString() );
                    Licence = Convert.ToInt32( rowView["licenses"].ToString() ) ;
                }
            }
            else
            {
                string SQL = "SELECT* FROM travelma2_phil1.PhilipsLic_Licence where Type = 'IntelliSpace ZFP' and rangefrom <= 35 and rangeto >= 35";
                DataView MyDV = Helper.GetData(SQL);
                foreach (DataRowView rowView in MyDV)
                {
                }
            }
            //
            //

            Licence = Licence + IntelliSpace_licenses;

            string json = "{\"licence\":\""+ Licence.ToString() + "\"}";
            Response.Clear();
            Response.ContentType = "application/json; charset=utf-8";
            Response.Write(json);
            Response.End();


        }
        catch { }
    }
}