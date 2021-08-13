using System;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Blood_Donor_Portal
{
    public partial class Signup : System.Web.UI.Page
    {
        
       protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void signupbtn_Click(object sender, EventArgs e)
        {
            string constr = ConfigurationManager.ConnectionStrings["constr"].ConnectionString;
            SqlConnection con = new SqlConnection(constr);
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into Users values ('"+mail.Text+"','"+uname.Text+"','"+pwd.Text+"')",con);
            cmd.ExecuteNonQuery();
            RegisterStartupScript("s","<script> alert('Registered Successfully')</script>");
            Response.Redirect("login.aspx");
        }
    }
}