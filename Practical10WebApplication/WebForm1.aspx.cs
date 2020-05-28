using System;

namespace Practical10WebApplication
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.QueryString["username"].Equals(""))
                lblUsername.Text = "Empty QueryString";
            else
                lblUsername.Text = Request.QueryString["username"];                
        }       
    }
}