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

    public class concurrentUserList
    {
        public concurrentUserList()
        {
            
        }

        public concurrentUserList(int intConcurrent, string strApplication)
        {
            ConcurrentData = intConcurrent;
            ApplicationData = strApplication;
        }

        public int ConcurrentData { get; private set; }
        public string ApplicationData { get; private set; }
    }


    protected void Page_Load(object sender, EventArgs e)
    {
       
        string SQL = string.Empty;
        string DataOK = "1";

        try {

           
     
            string appName = Request.Form["appName"].ToString();            
            string AppArray = Request.Form["AppArray"].ToString();
            
          
            if (appName.Contains("- Add_Users"))
            {

                string mainApp = appName.Replace("- Add_Users", "").ToString().Trim();


                string[] appSplit = AppArray.Split(',');

                // Part 3: loop over result array.
                foreach (string myapp in appSplit)
                {
                    if (myapp != "")
                    {

                        string[] appapp = myapp.Split('|');

                        if (mainApp == appapp[0])
                        {
                            DataOK = "1";
                            break;
                        }
                        else
                        {
                            DataOK = "0";
                        }
                    }
                    
                }

                
            }





            string json = "{\"data\":\""+ DataOK.ToString() + "\"}";
            Response.Clear();
            Response.ContentType = "application/json; charset=utf-8";
            Response.Write(json);
            Response.End();


        }
        catch { }
    }
}