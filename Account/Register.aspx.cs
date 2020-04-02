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

using System.DirectoryServices;

public partial class Account_Register : Page
{
    public string m_UserDepartment = string.Empty;
    public string m_UserCountry = string.Empty;

    public void GetADUserInfo(string UserEmail)
    {
        try
        {

            DirectoryEntry enTry = new DirectoryEntry("LDAP://OU=code,DC=code1,DC=emi,DC=philips,DC=com");
            DirectorySearcher mySearcher = new DirectorySearcher(enTry);
            mySearcher.Filter = "(&(objectClass=user)(anr=" + UserEmail + "))";
            SearchResult result = mySearcher.FindOne();
            DirectoryEntry resultEntry = new DirectoryEntry();
            resultEntry = result.GetDirectoryEntry();

            try
            {
                m_UserDepartment = resultEntry.Properties["department"].Value.ToString();
                m_UserCountry = resultEntry.Properties["co"].Value.ToString();
            }
            catch { }
        }
        catch (Exception f)
        {
        }

    }
    protected void cmdRequest_Click(object sender, EventArgs e)
    {
        string Code1_Email = string.Empty;

        try
        {
            Code1_Email = Request.Headers["Federation-UserPrincipalName"].ToString();

            //is user already in DB
            string SQL = "SELECT UserEmail FROM PhilipsMatrixUser WHERE(UserEmail = '" + txtEmail.Text + "') ";
            DataView MyDV = Helper.GetData(SQL);

            if (MyDV.Count == 0)
            {
                //foreach (DataRowView rowView in MyDV)
                //{

                    GetADUserInfo(Code1_Email);

                    string SQLIn = "INSERT INTO PhilipsMatrixUser(UserName, UserEmail, Department, Location, MVMatrix, Competitors, Clinical, Enterprise, Services, Attachments, UserType) VALUES('" + txtName.Text + "', '" + txtEmail.Text + "', '" + m_UserDepartment + "', '" + m_UserCountry + "', 'Viewer', 'Viewer', 'Viewer', 'Viewer', 'Viewer', 'Viewer', 'Pending')";
                    Helper.InsertData(SQLIn);


                    cmdRequest.Enabled = false;
                    lblFeedback.Text = "Thank you for your submission. <br/>We will review your request and contact you soon.";

                    if (txtEmail.Text != "")
                    {
                        Helper.SendEmail(txtEmail.Text, "ISP Sales Tool", "Thank you for request access to ISP Sales Tool.<br/> Your request is being reviewed and will be answered shortly");

                        Helper.SendEmail("ispsalestools@philips.com", "ISP Sales Tool - Access Requested ", txtEmail.Text + " has requested access.<br/><br/> https://www.ispsalestools.philips.com ");
                    }
                //}
            }else
            {
                Helper.SendEmail(txtEmail.Text, "ISP Sales Tool", "Thank you for request access to ISP Sales Tool.<br/> Your request is being reviewed and will be answered shortly");
                lblFeedback.Text = "Thank you for your submission. <br/>We will review your request and contact you soon.";
            }

        }
        catch { }
    }

    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {

            string Code1_Email = string.Empty;

            try
            {
                txtEmail.Text = Request.Headers["Federation-UserPrincipalName"].ToString();
            }
            catch { }

        }
        catch { }
    }



    
}
