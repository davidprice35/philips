<%@ WebHandler Language="C#" Class="saveFiles" %>

using System;
using System.Web;
using System.IO;
using Microsoft.Practices.EnterpriseLibrary.Data;
using System.Data;
using System.Data.Common;

public class saveFiles : IHttpHandler {

    public void ProcessRequest (HttpContext context) {
        string targetFolder = HttpContext.Current.Server.MapPath("data");
        if (!Directory.Exists(targetFolder))
        {
            Directory.CreateDirectory(targetFolder);
        }
        HttpRequest request = context.Request;
        HttpFileCollection uploadedFiles = context.Request.Files;
        if (uploadedFiles != null && uploadedFiles.Count > 0)
        {
            for (int i = 0; i < uploadedFiles.Count; i++)
            {
                string fileName = uploadedFiles[i].FileName;
                int indx = fileName.LastIndexOf("\\");
                if (indx > -1)
                {
                    fileName = fileName.Substring(indx + 1);
                }
                uploadedFiles[i].SaveAs(targetFolder + "\\" + fileName);


                //SaveFileName(fileName, targetFolder + "\\" + fileName);
                SaveFileName(fileName, fileName);


            }
        }
        else
        {

        }
    }


    private void SaveFileName(string filename , string fileLocation)
    {
        try {

            //DatabaseProviderFactory factory = new DatabaseProviderFactory();
            //Database db = factory.Create("TSOConn");

            Helper.InsertData("INSERT INTO PhilipsAttachmentList(FileDisplayName, FileLocation) VALUES  ('"+filename+"', '"+fileLocation+"')");

            //DbCommand dbCommandWrapper = db.GetSqlStringCommand("INSERT INTO PhilipsAttachmentList(FileDisplayName, FileLocation) VALUES  ('"+filename+"', '"+fileLocation+"')");
            //db.ExecuteNonQuery(dbCommandWrapper);


        }
        catch { }
    }

    public bool IsReusable {
        get {
            return false;
        }
    }

}