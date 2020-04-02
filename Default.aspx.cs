using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    public string m_UserName = string.Empty;

    protected void cmdLogout_Click(object sender, EventArgs e)
    {
        Response.Redirect("/Account/Signin?Type=LogOut");
    }

    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {
            
            bool Signin = false;

            if (Session["User"] != null)
            {
                if (Session["User"] != null)
                {
                    m_UserName = Session["User"].ToString();
                    Signin = true;
                }
                                
            }


            if (Signin == true)
            {
               

            }
            else
            {
                Response.Redirect("/Account/Signin");
            }

        }
        catch { }
    }

   
}