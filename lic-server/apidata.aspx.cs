﻿using System;
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
        int IntelliSpace_licenses = 0;
        int Licence = 0;
        string Concurrent_Default = string.Empty;
        string Concurrent_Range = string.Empty;
        string SQL = string.Empty;
        DataView MyDV = null;

        try {


            //            {
            //                "text": {
            //                    "id": "file",
            //  "value": "File",  
            //}
            //            }
            bool HasZFP = false;
            bool HasDynCad = false;
            bool HasIntelliSpace = false;
            string Category = string.Empty;
            string enterpriseuser = Request.Form["enterpriseuser"].ToString();
            int concurentusers = 0; //Request.Form["concurentusers"].ToString();
            string selectedapplication = Request.Form["selectedapplication"].ToString();
            string NumberofLicenses = string.Empty;
            string SelectedAppList = string.Empty;



           // var concurrentUserList1 = new List<concurrentUserList>();

            //if (selectedapplication!="" && selectedapplication != "?~?~?~?")
            //{

                string[] applicationslist = selectedapplication.Split('~');
                foreach (string applist in applicationslist)
                {

                    //Split the concurrentuser
                    string[] CurrentUsers = applist.Split('?');

                    //concurrentUserList1.Add(new concurrentUserList(Convert.ToInt32(CurrentUsers[1]), CurrentUsers[0]));
                    
                    //Apllications
                    string[] appItems = CurrentUsers[0].Split('|');
                    SelectedAppList += "'" + appItems[0] + "'" + ",";      
                    
                    if (appItems[0]== "Zero FootPrint Viewer SW - 2 User" | appItems[0] == "Zero FootPrint Viewer SW - Add_Users")
                    {
                        if (CurrentUsers[1] == "")
                        {

                        }
                        else
                        {
                            concurentusers += Convert.ToInt32(CurrentUsers[1]);
                        }
                        
                    }


                }

                //remove last comma
                if ( SelectedAppList!="")
                {
                    SelectedAppList = SelectedAppList.Substring(0, SelectedAppList.Length - 1);
                }


            //string[] words = selectedapplication.Split('|');
            //selectedapplication = words[0];

            if (selectedapplication != "" && selectedapplication != "?~?~?~?" && selectedapplication !=  "?1~?2~?~?")
            {

                SQL = "SELECT * FROM travelma2_phil1.PhilipsLic_Applications where Applications in (" + SelectedAppList + ")";
                MyDV = Helper.GetData(SQL);
                foreach (DataRowView rowView in MyDV)
                {
                    Category = rowView["Category"].ToString();

                    switch (Category)
                    {
                        case "Zerofootprint Software":
                            // Category = "ZFP";
                            HasZFP = true;
                            break;
                        case "DynaCAD Software":
                        case "Dynacad software":
                            //Category = "Dynacad";
                            HasDynCad = true;
                            break;
                        default:
                            //Category = "IntelliSpace";
                            HasIntelliSpace = true;
                            break;

                    }

                }

            }else
            {
                HasIntelliSpace = true;
            }




            Category = "";
            if (HasIntelliSpace == true)
            {
                Category = "IntelliSpace";
            }

            

            if (HasDynCad == true)
            {
                //if (Category != "")
                //{
                //    Category += " ";
                //}
                Category = "IntelliSpace DynaCad";
            }

           
            if (HasZFP == true)
            {
                //if (Category != "")
                //{
                //    Category += " ";
                //}

                Category = "IntelliSpace ZFP";
            }

            if (HasDynCad==true & HasZFP==true)
            {
                Category = "IntelliSpace DynaCad ZFP";
            }

            if (Category== "IntelliSpace DynaCad IntelliSpace ZFP")
            {
                Category = "IntelliSpace DynaCad ZFP";
            }


            if (Category == "IntelliSpace IntelliSpace DynaCad IntelliSpace ZFP")
            {
                Category = "IntelliSpace DynaCad ZFP";
            }

            //get licence data



            if (HasZFP==true)
            {
                SQL = "SELECT * FROM travelma2_phil1.PhilipsLic_Licence where Type ='"+ Category + "' and rangefrom <= " + enterpriseuser + " and rangeto >= " + enterpriseuser + " and addtionalrangefrom <=" + concurentusers + " and addtionalrangeto >=" + concurentusers;
                MyDV = Helper.GetData(SQL);
                foreach (DataRowView rowView in MyDV)
                {
                    IntelliSpace_licenses = Convert.ToInt32(rowView["IntelliSpace_licenses"].ToString());
                    Licence = Convert.ToInt32(rowView["licenses"].ToString());

                    if (HasDynCad == true)
                    {
                        Licence += Convert.ToInt32(rowView["dyncad"].ToString());
                    }

                   // Concurrent_Default = rowView["Concurrent_Default"].ToString();
                   // Concurrent_Range = rowView["Concurrent_Range"].ToString();

                }
            }else
            {
                if (Category=="")
                {
                    Category = "IntelliSpace";
                }

                if (Category == "IntelliSpace IntelliSpace DynaCad")
                {
                    Category = "IntelliSpace DynaCad";
                }


                SQL = "SELECT * FROM travelma2_phil1.PhilipsLic_Licence where Type = '" + Category + "' and rangefrom <= " + enterpriseuser + " and rangeto >= " + enterpriseuser;
                MyDV = Helper.GetData(SQL);
                foreach (DataRowView rowView in MyDV)
                {
                    IntelliSpace_licenses = Convert.ToInt32(rowView["IntelliSpace_licenses"].ToString());
                    Licence = Convert.ToInt32(rowView["licenses"].ToString());

                    //Concurrent_Default = rowView["Concurrent_Default"].ToString();
                   // Concurrent_Range = rowView["Concurrent_Range"].ToString();

                }
            }

                                   

            Licence = Licence + IntelliSpace_licenses;

            string json = "{\"licence\":\""+ Licence.ToString() + "\" , \"application\":\"" + selectedapplication + "\" }";
            Response.Clear();
            Response.ContentType = "application/json; charset=utf-8";
            Response.Write(json);
            Response.End();


        }
        catch { }
    }
}
