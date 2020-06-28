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
                case "NM NeuroQ PET - Add_Users":
                    myMainApp = "NM NeuroQ PET - 1 User";
                    break;
                case "NM EQual  - Add_Users":
                    myMainApp = "NM EQual - 1 User";
                    break;
                case "ECTB SmartReport Option V4.x - Add_Users":
                    myMainApp = "ECTB SmartReport Option V4.x  - 1 User";
                    break;
                case "ECTB Heart Fusion V4.x - Add_Users":
                    myMainApp = "ECTB Heart Fusion V4.x  - 1 User";
                    break;
                case "ECTB SPECT v4.x - Add_Users":
                    myMainApp = "ECTB SPECT V4.x  - 1 User";
                    break;
                case "ECTB PET v4.x - Add_Users":
                    myMainApp = "ECTB PET V4.x  - 1 User";
                    break;
                case "NM JETPack App License - Add_Users":
                    myMainApp = "Processing App Suite";
                    break;
               
                case "NeuroQ SPECT Opt - Add_Users":
                case "NM Amyloid Analysis - Add_Users":
                case "NM Equal  - Add_Users":
                case "NeuroQ DaTscan opt ISP  - Add_Users":
                case "ECTB NM v4.x - Add_Users":

                
                case "ECTB Heart Fusion v4.x - Add_Users":
               
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
        int HasSet = 0;

        try {


            int maincnt = 0;
            string appName = Request.Form["appName"].ToString();      //working item added to list      
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



                        switch(appName)
                        {
                            case "DynaCAD Enterprise - Add_Users":
                                if (appName == appapp[0].Trim())
                                {

                                }
                                else
                                {
                                    if (appapp[0].Trim() == "DynaCAD Prostate - 1 User" | appapp[0].Trim() == "DynaCAD Breast - 1 User" | appapp[0].Trim() == "DynaCAD Combo Package - 1 User")
                                    {
                                        DataOK = "1";   //item is in list we are good  

                                        //does appName appear 2 in list
                                        int idxcnt = 0;
                                        foreach (string myapp2 in appSplit)
                                        {
                                            string[] MainListItem = myapp2.Split('|');
                                            if (appName == MainListItem[0].Trim())
                                            {
                                                if (idxcnt > 0)
                                                {
                                                    DataOK = "3";
                                                    HasSet = 1;
                                                    break;
                                                }
                                                idxcnt++;
                                            }

                                        }


                                        break;

                                    }
                                    else
                                    {
                                        DataOK = "0";
                                        HasSet = 1;
                                    }
                                }
                                break;
                            case "Zero FootPrint Viewer SW - Add_Users":
                                if (appName == appapp[0].Trim())
                                {

                                }
                                else
                                {
                                    if (appapp[0].Trim() == "Zero FootPrint Viewer SW - 2 User")
                                    {
                                        DataOK = "1";   //item is in list we are good  

                                        //does appName appear 2 in list
                                        int idxcnt = 0;
                                        foreach (string myapp2 in appSplit)
                                        {
                                            string[] MainListItem = myapp2.Split('|');
                                            if (appName == MainListItem[0].Trim())
                                            {
                                                if (idxcnt > 0)
                                                {
                                                    DataOK = "3";
                                                    HasSet = 1;
                                                    break;
                                                }
                                                idxcnt++;
                                            }

                                        }
                                    }
                                    else
                                    {
                                        DataOK = "0";
                                        HasSet = 1;
                                    }
                                }
                                break;
                            default:
                                if (mainApp.Trim() == appapp[0].Trim())
                                {
                                    DataOK = "1";   //item is in list we are good    
                                    HasSet = 1;
                                    //does appName appear 2 in list
                                    int idxcnt = 0;
                                    foreach (string myapp2 in appSplit)
                                    {
                                        string[] MainListItem = myapp2.Split('|');
                                        if (appName == MainListItem[0].Trim())
                                        {
                                            if (idxcnt > 0)
                                            {
                                                DataOK = "3";
                                                HasSet = 1;
                                                break;
                                            }
                                            idxcnt++;
                                        }

                                    }



                                    break;
                                }
                                else
                                {
                                    if (HasSet == 0)
                                    {
                                        DataOK = "0";
                                        HasSet = 1;
                                    }

                                }
                                break;
                        }
                        // loop array is main item in list
                        


                        //is item dupped up
                        if (appName == appapp[0].Trim())
                        {
                            if (DataOK != "0")
                            {
                                if (maincnt > 0)
                                {
                                    DataOK = "3";
                                    HasSet = 1;
                                    break;
                                }

                                maincnt++;
                            }
                        }


                        if (DataOK=="1" & HasSet == 1)
                        {
                            break;
                        }


                    }
                    
                }

                
            }else
            {
                int idx = 0;
                int idxApp = 0;
                //string mainApp = GetMainApp(appName);

                string[] appSplit = AppArray.Split(',');

                // Part 3: loop over result array.
                foreach (string myapp in appSplit)
                {
                    if (myapp != "")
                    {

                        string[] appapp = myapp.Split('|');
                                                
                        //is item dupped up
                        if (appName == appapp[0].Trim())
                        {
                            

                            if (idxApp > 0)
                            {
                                HasSet = 1;
                                DataOK = "3";

                            }

                            idxApp++;
                        }

                    }
                    idx++;
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