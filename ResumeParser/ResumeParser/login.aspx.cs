using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ResumeParser
{
    public partial class login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            var username = txtUserName.Text;
            var password = txtPWD.Text;            
            var Rows = new List<int>();
            if (string.Equals(username, "Admin", StringComparison.OrdinalIgnoreCase) && password == "Admin")
            {
                Response.Redirect("Default.aspx");
            }
            else if(string.Equals(username, "User", StringComparison.OrdinalIgnoreCase) && password == "User")
            {
                Response.Redirect("User.aspx");
            }
            else
            {
                ClientScript.RegisterStartupScript(Page.GetType(), "validation", "<script language='javascript'>alert('Invalid Username and Password')</script>");
            }
        }
    }
}