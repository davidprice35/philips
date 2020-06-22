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


    private string GetMainApp ( string app)
    {

        string myMainApp = string.Empty;


        try {


            switch(app)
            {

                
                case "NM JETPack App License - Add_Users":
                    myMainApp = "Processing App Suite";
                    break;
                case "NM NeuroQ - 1 User - Add_Users":
                case "NeuroQ SPECT Opt - Add_Users":
                    myMainApp = "NM NeuroQ PET - 1 User";
                    break;
                case "NM Amyloid Analysis - Add_Users":
                case "NM Equal  - Add_Users":
                case "NeuroQ DaTscan opt ISP  - Add_Users":
                case "ECTB NM v4.x - Add_Users":
                case "ECTB SPECT v4.x - Add_Users":
                case "ECTB PET v4.x - Add_Users":
                case "ECTB Heart Fusion v4.x - Add_Users":
                case "ECTB SmartReport Option V4.x - Add_Users":
                case "ECTB CFR MBF V4.x - Add_Users":
                case "NM AutoQuant 2015.x - Add_Users":
                case "SPECT AutoQuant 2015.x - Add_Users":
                case "NM/CTA Cedars Fusion 2015.x - Add_Users":
                case "Cedars MFSC 2015.x - Add_Users":
                case "NM AutoQUANT 2017 - Add_Users":
                case "SPECT AutoQUANT 2017 - Add_Users":
                case "NM/CTA Cedars Fusion 2017 - Add_Users":
                case "Cedars MFSC 2017 - Add_Users":
                case "ZFP Viewer Enterprise - Add_Users":
                case "DynaCAD Enterprise - Add_Users":
                    myMainApp = app.Replace("- Add_Users", "").ToString().Trim();
                    break;

            }


            if (myMainApp=="")
            {
                myMainApp = app.Replace("- Add_Users", "").ToString().Trim();
            }


        }
        catch { }
        

        return myMainApp;

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

                // string mainApp = appName.Replace("- Add_Users", "").ToString().Trim();

                string mainApp = GetMainApp(appName);

                string[] appSplit = AppArray.Split(',');

                // Part 3: loop over result array.
                foreach (string myapp in appSplit)
                {
                    if (myapp != "")
                    {

                        string[] appapp = myapp.Split('|');
                        string[] appapp2 = appapp[0].Split('-');

                        if (mainApp.Trim() == appapp2[0].Trim())
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