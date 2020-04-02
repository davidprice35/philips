using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.DirectoryServices;
using System.DirectoryServices.ActiveDirectory;
using System.Collections;
using System.Net.Mail;
using System.Data;



public partial class Test : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        try{



          //  var hjh = Helper.GetData("INSERT INTO `innodb`.`Test_DelME` (`desc`) VALUES ( 'sdsd');SELECT LAST_INSERT_ID(); ");

            //Helper.SendEmail("davidprice35@hotmail.com", "ISP Sales Tool", "Thank you for request access to ISP Sales Tool.<br/> Your request is being reviewed and will be answered shortly");

            // Helper.SendEmail("davidprice35@hotmail.com", "ISP Sales Tool - Access Requested ", "xx@xx.com has requested access.<br/><br/> https://www.ispsalestools.philips.com ");

            //foreach (DataRowView rowView in hjh)
            //{
            //    string dss = rowView["LAST_INSERT_ID()"].ToString();
            //    string jkjk = "";
            //}


            }
        catch (Exception ex) { }
    }


    public void GetADUserInfo(string UserName)

    {

        try
        {

            //This is a generic LDAP call, it would do a DNS lookup to find a DC in your AD site, scales better

            DirectoryEntry enTry = new DirectoryEntry("LDAP://OU=code,DC=code1,DC=emi,DC=philips,DC=com");



            DirectorySearcher mySearcher = new DirectorySearcher(enTry);

            mySearcher.Filter = "(&(objectClass=user)(anr="+ UserName + "))";

            SearchResult result = mySearcher.FindOne();


            DirectoryEntry resultEntry = new DirectoryEntry();
            resultEntry = result.GetDirectoryEntry();

            //string firstName = resultEntry.Properties["givenname"].Value.ToString();
            System.Diagnostics.Debug.WriteLine(resultEntry.Properties["department"].Value.ToString());
            System.Diagnostics.Debug.WriteLine(resultEntry.Properties["co"].Value.ToString());


            //ResultPropertyCollection myResultPropColl;

            
            
           // myResultPropColl = result.Properties;

            
            //try
            //{

            //    foreach (string myKey in myResultPropColl.PropertyNames)
            //    {
            //        Console.WriteLine(myKey + " = ");
            //        foreach (Object myCollection in myResultPropColl[myKey])
            //        {
            //            System.Diagnostics.Debug.WriteLine(myKey + ":" + myCollection);
            //        }
            //    }

            //}
            //catch (Exception f)
            //{

            //    Console.WriteLine(f.Message);

            //}

        }

        catch (Exception f)
        {

            Console.WriteLine(f.Message);

        }

    }

    public ArrayList AttributeValuesMultiString(string attributeName, string objectDn, ArrayList valuesCollection, bool recursive)
    {
        DirectoryEntry ent = new DirectoryEntry(objectDn);
        PropertyValueCollection ValueCollection = ent.Properties[attributeName];
        IEnumerator en = ValueCollection.GetEnumerator();

        while (en.MoveNext())
        {
            if (en.Current != null)
            {
                if (!valuesCollection.Contains(en.Current.ToString()))
                {
                    valuesCollection.Add(en.Current.ToString());
                    if (recursive)
                    {
                        AttributeValuesMultiString(attributeName, "LDAP://" +
                        en.Current.ToString(), valuesCollection, true);
                    }
                }
            }
        }
        ent.Close();
        ent.Dispose();
        return valuesCollection;
    }

    protected void cmdSet1_Click(object sender, EventArgs e)
    {
        try {



           // System.Diagnostics.Debug.WriteLine( Request.Headers["Federation-UserPrincipalName"].ToString());


        //    GetADUserInfo(Request.Headers["Federation-UserPrincipalName"].ToString());
        }
        catch { }
    }

    protected void cmdSet2_Click(object sender, EventArgs e)
    {
        text1.Text = Session["test1"].ToString();

    }

    protected void cmdSet3_Click(object sender, EventArgs e)
    {
        text1.Text = System.Web.HttpContext.Current.Session.Mode.ToString();
    }
}