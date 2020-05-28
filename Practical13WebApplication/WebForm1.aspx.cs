using System;

namespace Practical13WebApplication
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            Session["uname"] = txtUsername.Text;
            Response.Redirect("WebForm2.aspx");
        }
    }
}