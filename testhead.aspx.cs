using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class testhead : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        try {

            //string headers = String.Empty;

            //foreach (var key in Request.Headers.AllKeys)
            //{
            //    headers += key + "=" + Request.Headers[key] + Environment.NewLine;

            //}


            TextBox1.Text = Request.Headers["Federation-UserPrincipalName"];


    //        [20]: "Federation-UserPrincipalName"
    //[21]: "Federation-SamAccountName"
    //[22]: "Federation-Mail"
    //[23]: "Federation-DisplayName"

        } catch { }
    }
}