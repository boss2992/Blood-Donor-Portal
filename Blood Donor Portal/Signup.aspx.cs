using System;
using System.Configuration;
using System.Data.SqlClient;
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
            SqlCommand cmd = new SqlCommand("insert into Users values ('" + mail.Text + "','" + uname.Text + "','" + pwd.Text + "')", con);
            cmd.ExecuteNonQuery();
            //msg.Text = "User Registration Successfull";
            Response.Redirect("login.aspx");

        }
    }
}