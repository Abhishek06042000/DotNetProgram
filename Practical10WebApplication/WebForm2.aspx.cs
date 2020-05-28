using System;


namespace Practical10WebApplication
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            string queryString = "username=" + txtUsername.Text + "&password=" + txtPassword.Text;
            Response.Redirect("WebForm1.aspx?" + queryString);
        }
    }
}