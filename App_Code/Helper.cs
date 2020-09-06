using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.Practices.EnterpriseLibrary.Data;
using System.Data;
using System.Data.SqlClient;
using System.Data.Common;
using System.Configuration;
using MySql.Data.MySqlClient;
//using System.DirectoryServices;
//using System.Net.Mail;

public class Helper
{
    public Helper()
    {
    }

    public static string m_UserDepartment = string.Empty;
    public static string m_UserCountry = string.Empty;


    public static DataView GetData(string sql)
    {
        DataSet myDS = null;
        DataView myDV = null;

        try
        {
            //DatabaseProviderFactory factory = new DatabaseProviderFactory();
            //Database db = factory.Create("TSOConn");

            //DbCommand dbCommandWrapper = db.GetSqlStringCommand(sql);
            //myDS = db.ExecuteDataSet(dbCommandWrapper);
            //myDV = myDS.Tables[0].DefaultView;

            string connStr = "server=91.208.99.2;user=travelma2_phil1;port=1220; database=travelma2_phil1; password=Monst3rlinksT";
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
                

            }
            catch (Exception ex)
            {

            }
            conn.Close();


        }
        catch (Exception ex)
        {

            string sds = ex.Message;

        }

        return myDV;
    }

    public static void InsertData(string sql)
    {
        try
        {
            string connStr = "server=91.208.99.2;user=travelma2_phil1;port=1220; database=travelma2_phil1; password=Monst3rlinksT";
            MySqlConnection conn = new MySqlConnection(connStr);
            
            conn.Open();                
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            cmd.ExecuteNonQuery();
            conn.Close();                        

        }
        catch (Exception ex)
        {


            string Error= "INSERT INTO CatchErrors (SQL) VALUES ('"+ sql.Replace("'","@") + "')";
            InsertDataErrors(Error);

            string sds = ex.Message;

        }

    }

       public static string GetUserGuide()
      {
            string myData = string.Empty;
    DataSet myDS = null;
    DataView myDV = null;

            try
            {
                myDV= GetData("SELECT FileLocation FROM PhilipsAttachments WHERE(Name = 'User Guide')");
            //myDV = db.ExecuteDataSet(dbCommandWrapper);
            //myDV = myDS.Tables[0].DefaultView;

            foreach (DataRowView rowView in myDV)
            {
                myData = "/competitive-info/data/" + rowView["FileLocation"].ToString();
            }

            }
            catch (Exception ex)
            {

                string sds = ex.Message;

            }

            return myData;

        }

    public static void InsertDataErrors(string sql)
    {
        try
        {
            string connStr = "server=rdsipos01d.cxvevr7ci7iw.eu-west-1.rds.amazonaws.com;user=appadmin; database=innodb; password=jyMMkn9UWTrDosfNNc5zf97Iwua9NIKb9L2cp17K";
            MySqlConnection conn = new MySqlConnection(connStr);

            conn.Open();
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            cmd.ExecuteNonQuery();
            conn.Close();

        }
        catch (Exception ex)
        {


            string sds = ex.Message;

        }

    }

    //    public static void GetADUserInfo(string UserEmail)
    //    {
    //        try
    //        {

    //            DirectoryEntry enTry = new DirectoryEntry("LDAP://OU=code,DC=code1,DC=emi,DC=philips,DC=com");                       
    //            DirectorySearcher mySearcher = new DirectorySearcher(enTry);
    //            mySearcher.Filter = "(&(objectClass=user)(anr=" + UserEmail + "))";
    //            SearchResult result = mySearcher.FindOne();
    //            DirectoryEntry resultEntry = new DirectoryEntry();
    //            resultEntry = result.GetDirectoryEntry();

    //            try
    //            {
    //                m_UserDepartment = resultEntry.Properties["department"].Value.ToString();
    //                m_UserCountry = resultEntry.Properties["co"].Value.ToString();
    //            }
    //            catch { }            
    //        }
    //        catch (Exception f)
    //        {            
    //        }

    //    }

        public static void InsertTracking(string userID, string PageName, string UserEmail)
        {
    //        try {

    //            //Get active Directory user
    //            GetADUserInfo(UserEmail);

    //            string SQL = string.Empty;
    //            SQL = "INSERT INTO PhilipsAnalysisTracking(PageName, UserID,UserEmail,Department,Country) VALUES('" + PageName + "', "+ userID + ",'"+ UserEmail + "','"+m_UserDepartment+"','"+m_UserCountry+"')";
    //            InsertData(SQL);

    //        }
    //        catch { }        
        }

    //    public static void SendEmail(string ToEmail, string Subject, string MailBody)
    //    {
    //        try {


    //            MailMessage mail = new MailMessage("ispsalestools@philips.com", ToEmail );
    //            SmtpClient client = new SmtpClient();

    //            // Attachment oAttachment = new Attachment("C:\\Sites\\Philips2\\images\\logo.png");

    //            #region emailbody            
    //            string EmailBodyText = @"
    //<!DOCTYPE HTML PUBLIC '-//W3C//DTD HTML 4.01//EN' 'http://www.w3.org/TR/html4/strict.dtd'>
    //<!doctype html>
    //<html xmlns:fb='http://www.facebook.com/2008/fbml' xmlns:og='http://opengraph.org/schema/'> <head>

    //<meta property='og:title' content=''>
    //<meta property='fb:page_id' content='43929265776'>
    //<meta name='viewport' content='width=device-width, initial-scale=1, maximum-scale=1'>
    //<meta name='referrer' content='origin'>        
    //        <!-- NAME: 1 COLUMN -->
    //        <!--[if gte mso 15]>
    //        <xml>
    //            <o:OfficeDocumentSettings>
    //            <o:AllowPNG/>
    //            <o:PixelsPerInch>96</o:PixelsPerInch>
    //            </o:OfficeDocumentSettings>
    //        </xml>
    //        <![endif]-->
    //        <meta charset='UTF-8'>
    //        <meta http-equiv='X-UA-Compatible' content='IE=edge'>
    //        <meta name='viewport' content='width=device-width, initial-scale=1'>
    //        <title></title>

    //    <style type='text/css'>
    //		p{
    //			margin:10px 0;
    //			padding:0;
    //		}
    //		table{
    //			border-collapse:collapse;
    //		}
    //		h1,h2,h3,h4,h5,h6{
    //			display:block;
    //			margin:0;
    //			padding:0;
    //		}
    //		img,a img{
    //			border:0;
    //			height:auto;
    //			outline:none;
    //			text-decoration:none;
    //		}
    //		body,#bodyTable,#bodyCell{
    //			height:100%;
    //			margin:0;
    //			padding:0;
    //			width:100%;
    //		}
    //		.mcnPreviewText{
    //			display:none !important;
    //		}
    //		#outlook a{
    //			padding:0;
    //		}
    //		img{
    //			-ms-interpolation-mode:bicubic;
    //		}
    //		table{
    //			mso-table-lspace:0pt;
    //			mso-table-rspace:0pt;
    //		}
    //		.ReadMsgBody{
    //			width:100%;
    //		}
    //		.ExternalClass{
    //			width:100%;
    //		}
    //		p,a,li,td,blockquote{
    //			mso-line-height-rule:exactly;
    //		}
    //		a[href^=tel],a[href^=sms]{
    //			color:inherit;
    //			cursor:default;
    //			text-decoration:none;
    //		}
    //		p,a,li,td,body,table,blockquote{
    //			-ms-text-size-adjust:100%;
    //			-webkit-text-size-adjust:100%;
    //		}
    //		.ExternalClass,.ExternalClass p,.ExternalClass td,.ExternalClass div,.ExternalClass span,.ExternalClass font{
    //			line-height:100%;
    //		}
    //		a[x-apple-data-detectors]{
    //			color:inherit !important;
    //			text-decoration:none !important;
    //			font-size:inherit !important;
    //			font-family:inherit !important;
    //			font-weight:inherit !important;
    //			line-height:inherit !important;
    //		}
    //		#bodyCell{
    //			padding:10px;
    //		}
    //		.templateContainer{
    //			max-width:600px !important;
    //		}
    //		a.mcnButton{
    //			display:block;
    //		}
    //		.mcnImage,.mcnRetinaImage{
    //			vertical-align:bottom;
    //		}
    //		.mcnTextContent{
    //			word-break:break-word;
    //		}
    //		.mcnTextContent img{
    //			height:auto !important;
    //		}
    //		.mcnDividerBlock{
    //			table-layout:fixed !important;
    //		}
    //		body,#bodyTable{
    //			background-color:#FAFAFA;
    //		}
    //		#bodyCell{
    //			border-top:0;
    //		}
    //		.templateContainer{
    //			border:0;
    //		}
    //		h1{
    //			color:#202020;
    //			font-family:Helvetica;
    //			font-size:26px;
    //			font-style:normal;
    //			font-weight:bold;
    //			line-height:125%;
    //			letter-spacing:normal;
    //			text-align:left;
    //		}
    //		h2{
    //			color:#202020;
    //			font-family:Helvetica;
    //			font-size:22px;
    //			font-style:normal;
    //			font-weight:bold;
    //			line-height:125%;
    //			letter-spacing:normal;
    //			text-align:left;
    //		}
    //		h3{
    //			color:#202020;
    //			font-family:Helvetica;
    //			font-size:20px;
    //			font-style:normal;
    //			font-weight:bold;
    //			line-height:125%;
    //			letter-spacing:normal;
    //			text-align:left;
    //		}
    //		h4{
    //			color:#202020;
    //			font-family:Helvetica;
    //			font-size:18px;
    //			font-style:normal;
    //			font-weight:bold;
    //			line-height:125%;
    //			letter-spacing:normal;
    //			text-align:left;
    //		}
    //		#templatePreheader{
    //			background-color:#FAFAFA;
    //			background-image:none;
    //			background-repeat:no-repeat;
    //			background-position:center;
    //			background-size:cover;
    //			border-top:0;
    //			border-bottom:0;
    //			padding-top:9px;
    //			padding-bottom:9px;
    //		}
    //		#templatePreheader .mcnTextContent,#templatePreheader .mcnTextContent p{
    //			color:#656565;
    //			font-family:Helvetica;
    //			font-size:12px;
    //			line-height:150%;
    //			text-align:left;
    //		}
    //		#templatePreheader .mcnTextContent a,#templatePreheader .mcnTextContent p a{
    //			color:#656565;
    //			font-weight:normal;
    //			text-decoration:underline;
    //		}
    //		#templateHeader{
    //			background-color:#FFFFFF;
    //			background-image:none;
    //			background-repeat:no-repeat;
    //			background-position:center;
    //			background-size:cover;
    //			border-top:0;
    //			border-bottom:0;
    //			padding-top:9px;
    //			padding-bottom:0;
    //		}
    //		#templateHeader .mcnTextContent,#templateHeader .mcnTextContent p{
    //			color:#202020;
    //			font-family:Helvetica;
    //			font-size:16px;
    //			line-height:150%;
    //			text-align:left;
    //		}
    //		#templateHeader .mcnTextContent a,#templateHeader .mcnTextContent p a{
    //			color:#2BAADF;
    //			font-weight:normal;
    //			text-decoration:underline;
    //		}
    //		#templateBody{
    //			background-color:#FFFFFF;
    //			background-image:none;
    //			background-repeat:no-repeat;
    //			background-position:center;
    //			background-size:cover;
    //			border-top:0;
    //			border-bottom:2px solid #EAEAEA;
    //			padding-top:0;
    //			padding-bottom:9px;
    //		}
    //		#templateBody .mcnTextContent,#templateBody .mcnTextContent p{
    //			color:#202020;
    //			font-family:Helvetica;
    //			font-size:16px;
    //			line-height:150%;
    //			text-align:left;
    //		}
    //		#templateBody .mcnTextContent a,#templateBody .mcnTextContent p a{
    //			color:#2BAADF;
    //			font-weight:normal;
    //			text-decoration:underline;
    //		}
    //		#templateFooter{
    //			background-color:#FAFAFA;
    //			background-image:none;
    //			background-repeat:no-repeat;
    //			background-position:center;
    //			background-size:cover;
    //			border-top:0;
    //			border-bottom:0;
    //			padding-top:9px;
    //			padding-bottom:9px;
    //		}
    //		#templateFooter .mcnTextContent,#templateFooter .mcnTextContent p{
    //			color:#656565;
    //			font-family:Helvetica;
    //			font-size:12px;
    //			line-height:150%;
    //			text-align:center;
    //		}
    //		#templateFooter .mcnTextContent a,#templateFooter .mcnTextContent p a{
    //			color:#656565;
    //			font-weight:normal;
    //			text-decoration:underline;
    //		}
    //	@media only screen and (min-width:768px){
    //		.templateContainer{
    //			width:600px !important;
    //		}

    //}	@media only screen and (max-width: 480px){
    //		body,table,td,p,a,li,blockquote{
    //			-webkit-text-size-adjust:none !important;
    //		}

    //}	@media only screen and (max-width: 480px){
    //		body{
    //			width:100% !important;
    //			min-width:100% !important;
    //		}

    //}	@media only screen and (max-width: 480px){
    //		#bodyCell{
    //			padding-top:10px !important;
    //		}

    //}	@media only screen and (max-width: 480px){
    //		.mcnRetinaImage{
    //			max-width:100% !important;
    //		}

    //}	@media only screen and (max-width: 480px){
    //		.mcnImage{
    //			width:100% !important;
    //		}

    //}	@media only screen and (max-width: 480px){
    //		.mcnCartContainer,.mcnCaptionTopContent,.mcnRecContentContainer,.mcnCaptionBottomContent,.mcnTextContentContainer,.mcnBoxedTextContentContainer,.mcnImageGroupContentContainer,.mcnCaptionLeftTextContentContainer,.mcnCaptionRightTextContentContainer,.mcnCaptionLeftImageContentContainer,.mcnCaptionRightImageContentContainer,.mcnImageCardLeftTextContentContainer,.mcnImageCardRightTextContentContainer,.mcnImageCardLeftImageContentContainer,.mcnImageCardRightImageContentContainer{
    //			max-width:100% !important;
    //			width:100% !important;
    //		}

    //}	@media only screen and (max-width: 480px){
    //		.mcnBoxedTextContentContainer{
    //			min-width:100% !important;
    //		}

    //}	@media only screen and (max-width: 480px){
    //		.mcnImageGroupContent{
    //			padding:9px !important;
    //		}

    //}	@media only screen and (max-width: 480px){
    //		.mcnCaptionLeftContentOuter .mcnTextContent,.mcnCaptionRightContentOuter .mcnTextContent{
    //			padding-top:9px !important;
    //		}

    //}	@media only screen and (max-width: 480px){
    //		.mcnImageCardTopImageContent,.mcnCaptionBottomContent:last-child .mcnCaptionBottomImageContent,.mcnCaptionBlockInner .mcnCaptionTopContent:last-child .mcnTextContent{
    //			padding-top:18px !important;
    //		}

    //}	@media only screen and (max-width: 480px){
    //		.mcnImageCardBottomImageContent{
    //			padding-bottom:9px !important;
    //		}

    //}	@media only screen and (max-width: 480px){
    //		.mcnImageGroupBlockInner{
    //			padding-top:0 !important;
    //			padding-bottom:0 !important;
    //		}

    //}	@media only screen and (max-width: 480px){
    //		.mcnImageGroupBlockOuter{
    //			padding-top:9px !important;
    //			padding-bottom:9px !important;
    //		}

    //}	@media only screen and (max-width: 480px){
    //		.mcnTextContent,.mcnBoxedTextContentColumn{
    //			padding-right:18px !important;
    //			padding-left:18px !important;
    //		}

    //}	@media only screen and (max-width: 480px){
    //		.mcnImageCardLeftImageContent,.mcnImageCardRightImageContent{
    //			padding-right:18px !important;
    //			padding-bottom:0 !important;
    //			padding-left:18px !important;
    //		}

    //}	@media only screen and (max-width: 480px){
    //		.mcpreview-image-uploader{
    //			display:none !important;
    //			width:100% !important;
    //		}

    //}	@media only screen and (max-width: 480px){
    //		h1{
    //			font-size:22px !important;
    //			line-height:125% !important;
    //		}

    //}	@media only screen and (max-width: 480px){
    //		h2{
    //			font-size:20px !important;
    //			line-height:125% !important;
    //		}

    //}	@media only screen and (max-width: 480px){
    //		h3{
    //			font-size:18px !important;
    //			line-height:125% !important;
    //		}

    //}	@media only screen and (max-width: 480px){
    //		h4{
    //			font-size:16px !important;
    //			line-height:150% !important;
    //		}

    //}	@media only screen and (max-width: 480px){
    //		.mcnBoxedTextContentContainer .mcnTextContent,.mcnBoxedTextContentContainer .mcnTextContent p{
    //			font-size:14px !important;
    //			line-height:150% !important;
    //		}

    //}	@media only screen and (max-width: 480px){
    //		#templatePreheader{
    //			display:block !important;
    //		}

    //}	@media only screen and (max-width: 480px){
    //		#templatePreheader .mcnTextContent,#templatePreheader .mcnTextContent p{
    //			font-size:14px !important;
    //			line-height:150% !important;
    //		}

    //}	@media only screen and (max-width: 480px){
    //		#templateHeader .mcnTextContent,#templateHeader .mcnTextContent p{
    //			font-size:16px !important;
    //			line-height:150% !important;
    //		}

    //}	@media only screen and (max-width: 480px){
    //		#templateBody .mcnTextContent,#templateBody .mcnTextContent p{
    //			font-size:16px !important;
    //			line-height:150% !important;
    //		}

    //}	@media only screen and (max-width: 480px){
    //		#templateFooter .mcnTextContent,#templateFooter .mcnTextContent p{
    //			font-size:14px !important;
    //			line-height:150% !important;
    //		}

    //}</style> 
    //</head> 
    //<body id='archivebody'> 
    //        <body style='height: 100%;margin: 0;padding: 0;width: 100%;-ms-text-size-adjust: 100%;-webkit-text-size-adjust: 100%;background-color: #FAFAFA;'>
    //        <!---->
    //        <center>
    //            <table align='center' border='0' cellpadding='0' cellspacing='0' height='100%' width='100%' id='bodyTable' style='border-collapse: collapse;mso-table-lspace: 0pt;mso-table-rspace: 0pt;-ms-text-size-adjust: 100%;-webkit-text-size-adjust: 100%;height: 100%;margin: 0;padding: 0;width: 100%;background-color: #FAFAFA;'>
    //                <tr>
    //                    <td align='center' valign='top' id='bodyCell' style='mso-line-height-rule: exactly;-ms-text-size-adjust: 100%;-webkit-text-size-adjust: 100%;height: 100%;margin: 0;padding: 10px;width: 100%;border-top: 0;'>
    //                        <!-- BEGIN TEMPLATE // -->
    //                        <!--[if (gte mso 9)|(IE)]>
    //                        <table align='center' border='0' cellspacing='0' cellpadding='0' width='600' style='width:600px;'>
    //                        <tr>
    //                        <td align='center' valign='top' width='600' style='width:600px;'>
    //                        <![endif]-->
    //                        <table border='0' cellpadding='0' cellspacing='0' width='100%' class='templateContainer' style='border-collapse: collapse;mso-table-lspace: 0pt;mso-table-rspace: 0pt;-ms-text-size-adjust: 100%;-webkit-text-size-adjust: 100%;border: 0;max-width: 600px !important;'>
    //                            <tr>
    //                                <td valign='top' id='templatePreheader' style='background:#FAFAFA none no-repeat center/cover;mso-line-height-rule: exactly;-ms-text-size-adjust: 100%;-webkit-text-size-adjust: 100%;background-color: #FAFAFA;background-image: none;background-repeat: no-repeat;background-position: center;background-size: cover;border-top: 0;border-bottom: 0;padding-top: 9px;padding-bottom: 9px;'><table border='0' cellpadding='0' cellspacing='0' width='100%' class='mcnTextBlock' style='min-width: 100%;border-collapse: collapse;mso-table-lspace: 0pt;mso-table-rspace: 0pt;-ms-text-size-adjust: 100%;-webkit-text-size-adjust: 100%;'>
    //    <tbody class='mcnTextBlockOuter'>
    //        <tr>
    //            <td valign='top' class='mcnTextBlockInner' style='padding-top: 9px;mso-line-height-rule: exactly;-ms-text-size-adjust: 100%;-webkit-text-size-adjust: 100%;'>
    //              	<!--[if mso]>
    //				<table align='left' border='0' cellspacing='0' cellpadding='0' width='100%' style='width:100%;'>
    //				<tr>
    //				<![endif]-->

    //				<!--[if mso]>
    //				<td valign='top' width='600' style='width:600px;'>
    //				<![endif]-->

    //				<!--[if mso]>
    //				</td>
    //				<![endif]-->

    //				<!--[if mso]>
    //				</tr>
    //				</table>
    //				<![endif]-->
    //            </td>
    //        </tr>
    //    </tbody>
    //</table></td>
    //                            </tr>
    //                            <tr>
    //                                <td valign='top' id='templateHeader' style='background:#FFFFFF none no-repeat center/cover;mso-line-height-rule: exactly;-ms-text-size-adjust: 100%;-webkit-text-size-adjust: 100%;background-color: #FFFFFF;background-image: none;background-repeat: no-repeat;background-position: center;background-size: cover;border-top: 0;border-bottom: 0;padding-top: 9px;padding-bottom: 0;'><table border='0' cellpadding='0' cellspacing='0' width='100%' class='mcnImageBlock' style='min-width: 100%;border-collapse: collapse;mso-table-lspace: 0pt;mso-table-rspace: 0pt;-ms-text-size-adjust: 100%;-webkit-text-size-adjust: 100%;'>
    //    <tbody class='mcnImageBlockOuter'>
    //            <tr>
    //                <td valign='top' style='padding: 9px;mso-line-height-rule: exactly;-ms-text-size-adjust: 100%;-webkit-text-size-adjust: 100%;' class='mcnImageBlockInner'>
    //                    <table align='left' width='100%' border='0' cellpadding='0' cellspacing='0' class='mcnImageContentContainer' style='min-width: 100%;border-collapse: collapse;mso-table-lspace: 0pt;mso-table-rspace: 0pt;-ms-text-size-adjust: 100%;-webkit-text-size-adjust: 100%;'>
    //                        <tbody><tr>
    //                            <td class='mcnImageContent' valign='top' style='padding-right: 9px;padding-left: 9px;padding-top: 0;padding-bottom: 0;text-align: center;mso-line-height-rule: exactly;-ms-text-size-adjust: 100%;-webkit-text-size-adjust: 100%;'>


    //                                        <img align='center' alt='' src='cid:logo@host' width='181' style='max-width: 181px;padding-bottom: 0;display: inline !important;vertical-align: bottom;border: 0;height: auto;outline: none;text-decoration: none;-ms-interpolation-mode: bicubic;' class='mcnImage'>


    //                            </td>
    //                        </tr>
    //                    </tbody></table>
    //                </td>
    //            </tr>
    //    </tbody>
    //</table></td>
    //                            </tr>
    //                            <tr>
    //                                <td valign='top' id='templateBody' style='background:#FFFFFF none no-repeat center/cover;mso-line-height-rule: exactly;-ms-text-size-adjust: 100%;-webkit-text-size-adjust: 100%;background-color: #FFFFFF;background-image: none;background-repeat: no-repeat;background-position: center;background-size: cover;border-top: 0;border-bottom: 2px solid #EAEAEA;padding-top: 0;padding-bottom: 9px;'><table border='0' cellpadding='0' cellspacing='0' width='100%' class='mcnTextBlock' style='min-width: 100%;border-collapse: collapse;mso-table-lspace: 0pt;mso-table-rspace: 0pt;-ms-text-size-adjust: 100%;-webkit-text-size-adjust: 100%;'>
    //    <tbody class='mcnTextBlockOuter'>
    //        <tr>
    //            <td valign='top' class='mcnTextBlockInner' style='padding-top: 9px;mso-line-height-rule: exactly;-ms-text-size-adjust: 100%;-webkit-text-size-adjust: 100%;'>
    //              	<!--[if mso]>
    //				<table align='left' border='0' cellspacing='0' cellpadding='0' width='100%' style='width:100%;'>
    //				<tr>
    //				<![endif]-->

    //				<!--[if mso]>
    //				<td valign='top' width='600' style='width:600px;'>
    //				<![endif]-->
    //                <table align='left' border='0' cellpadding='0' cellspacing='0' style='max-width: 100%;min-width: 100%;border-collapse: collapse;mso-table-lspace: 0pt;mso-table-rspace: 0pt;-ms-text-size-adjust: 100%;-webkit-text-size-adjust: 100%;' width='100%' class='mcnTextContentContainer'>
    //                    <tbody><tr>

    //                        <td valign='top' class='mcnTextContent' style='padding-top: 0;padding-right: 18px;padding-bottom: 9px;padding-left: 18px;mso-line-height-rule: exactly;-ms-text-size-adjust: 100%;-webkit-text-size-adjust: 100%;word-break: break-word;color: #202020;font-family: Helvetica;font-size: 16px;line-height: 150%;text-align: left;'>                        
    //                            @@TextBody@@
    //                        </td>
    //                    </tr>
    //                </tbody></table>
    //				<!--[if mso]>
    //				</td>
    //				<![endif]-->

    //				<!--[if mso]>
    //				</tr>
    //				</table>
    //				<![endif]-->
    //            </td>
    //        </tr>
    //    </tbody>
    //</table></td>
    //                            </tr>
    //                            <tr>
    //                                <td valign='top' id='templateFooter' style='background:#FAFAFA none no-repeat center/cover;mso-line-height-rule: exactly;-ms-text-size-adjust: 100%;-webkit-text-size-adjust: 100%;background-color: #FAFAFA;background-image: none;background-repeat: no-repeat;background-position: center;background-size: cover;border-top: 0;border-bottom: 0;padding-top: 9px;padding-bottom: 9px;'><table border='0' cellpadding='0' cellspacing='0' width='100%' class='mcnDividerBlock' style='min-width: 100%;border-collapse: collapse;mso-table-lspace: 0pt;mso-table-rspace: 0pt;-ms-text-size-adjust: 100%;-webkit-text-size-adjust: 100%;table-layout: fixed !important;'>
    //    <tbody class='mcnDividerBlockOuter'>
    //        <tr>
    //            <td class='mcnDividerBlockInner' style='min-width: 100%;padding: 10px 18px 25px;mso-line-height-rule: exactly;-ms-text-size-adjust: 100%;-webkit-text-size-adjust: 100%;'>
    //                <table class='mcnDividerContent' border='0' cellpadding='0' cellspacing='0' width='100%' style='min-width: 100%;border-top: 2px solid #EEEEEE;border-collapse: collapse;mso-table-lspace: 0pt;mso-table-rspace: 0pt;-ms-text-size-adjust: 100%;-webkit-text-size-adjust: 100%;'>
    //                    <tbody><tr>
    //                        <td style='mso-line-height-rule: exactly;-ms-text-size-adjust: 100%;-webkit-text-size-adjust: 100%;'>
    //                            <span></span>
    //                        </td>
    //                    </tr>
    //                </tbody></table>
    //<!--            
    //                <td class='mcnDividerBlockInner' style='padding: 18px;'>
    //                <hr class='mcnDividerContent' style='border-bottom-color:none; border-left-color:none; border-right-color:none; border-bottom-width:0; border-left-width:0; border-right-width:0; margin-top:0; margin-right:0; margin-bottom:0; margin-left:0;' />
    //-->
    //            </td>
    //        </tr>
    //    </tbody>
    //</table><table border='0' cellpadding='0' cellspacing='0' width='100%' class='mcnTextBlock' style='min-width: 100%;border-collapse: collapse;mso-table-lspace: 0pt;mso-table-rspace: 0pt;-ms-text-size-adjust: 100%;-webkit-text-size-adjust: 100%;'>
    //    <tbody class='mcnTextBlockOuter'>
    //        <tr>
    //            <td valign='top' class='mcnTextBlockInner' style='padding-top: 9px;mso-line-height-rule: exactly;-ms-text-size-adjust: 100%;-webkit-text-size-adjust: 100%;'>
    //              	<!--[if mso]>
    //				<table align='left' border='0' cellspacing='0' cellpadding='0' width='100%' style='width:100%;'>
    //				<tr>
    //				<![endif]-->

    //				<!--[if mso]>
    //				<td valign='top' width='600' style='width:600px;'>
    //				<![endif]-->
    //                <table align='left' border='0' cellpadding='0' cellspacing='0' style='max-width: 100%;min-width: 100%;border-collapse: collapse;mso-table-lspace: 0pt;mso-table-rspace: 0pt;-ms-text-size-adjust: 100%;-webkit-text-size-adjust: 100%;' width='100%' class='mcnTextContentContainer'>
    //                    <tbody><tr>

    //                        <td valign='top' class='mcnTextContent' style='padding-top: 0;padding-right: 18px;padding-bottom: 9px;padding-left: 18px;mso-line-height-rule: exactly;-ms-text-size-adjust: 100%;-webkit-text-size-adjust: 100%;word-break: break-word;color: #656565;font-family: Helvetica;font-size: 12px;line-height: 150%;text-align: center;'>

    //                            <em>Copyright © 2018 *|LIST:COMPANY|*, All rights reserved.</em>
    //<br>

    //    <br>
    //    <br>
    //	Want to change how you receive these emails?<br>
    //    You can <a href='*|DEFAULT:UPDATE_PROFILE|*' style='mso-line-height-rule: exactly;-ms-text-size-adjust: 100%;-webkit-text-size-adjust: 100%;color: #656565;font-weight: normal;text-decoration: underline;'>update your preferences</a> or <a href='*|DEFAULT:UNSUB|*' style='mso-line-height-rule: exactly;-ms-text-size-adjust: 100%;-webkit-text-size-adjust: 100%;color: #656565;font-weight: normal;text-decoration: underline;'>unsubscribe from this list</a>.
    //    <br>
    //    <br>


    //                        </td>
    //                    </tr>
    //                </tbody></table>
    //				<!--[if mso]>
    //				</td>
    //				<![endif]-->

    //				<!--[if mso]>
    //				</tr>
    //				</table>
    //				<![endif]-->
    //            </td>
    //        </tr>
    //    </tbody>
    //</table></td>
    //                            </tr>
    //                        </table>
    //                        <!--[if (gte mso 9)|(IE)]>
    //                        </td>
    //                        </tr>
    //                        </table>
    //                        <![endif]-->
    //                        <!-- // END TEMPLATE -->
    //                    </td>
    //                </tr>
    //            </table>
    //        </center>
    //    </body>    <script type='text/javascript'>
    //            $(document).ready(function() {
    //                document.getElementById('copyToClipboard').addEventListener('click', function () {
    //                    var input = document.getElementById('clipboardSource');
    //                    input.select();
    //                    var successful = document.execCommand('copy');
    //                    if (successful) {
    //                        alert('Copied '' + input.value + '' to your clipboard.');
    //                    } else {
    //                        throw new Error('Failed to copy text (verify caller was in the context of an event handler)');
    //                    }
    //                });

    //                $('li.more > a').click(function(){
    //                    var toToggle = $($(this).attr('data-to-toggle'));
    //                    if(toToggle.is(':visible')){
    //                        toToggle.slideUp('fast');
    //                        $(this).removeClass('is-active');
    //                        if ($('#awesomebar').find('.is-active').length < 1){
    //                            $('#awesomebar').removeClass('sub-active');
    //                        }
    //                    } else {
    //                        toToggle.slideDown('fast');
    //                        $(this).addClass('is-active');
    //                        $('#awesomebar').addClass('sub-active');
    //                    }
    //                    return false;
    //                });

    //            });
    //        </script></body> </html>
    //";
    //            #endregion


    //            EmailBodyText = EmailBodyText.Replace("@@TextBody@@", MailBody);

    //            client.Port = 25;
    //            client.DeliveryMethod = SmtpDeliveryMethod.Network;
    //            client.UseDefaultCredentials = false;
    //            client.Host = "smtprelay-eur1.philips.com";
    //            mail.Subject = Subject;
    //            mail.Body = MailBody;
    //            mail.IsBodyHtml = true;
    //            client.Send(mail);

    //        }
    //        catch { }
    //    }




}