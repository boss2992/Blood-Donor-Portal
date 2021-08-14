using System;
using System.Configuration;
using System.Data.SqlClient;

namespace Blood_Donor_Portal
{
    public partial class login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void loginbtn_Click(object sender, EventArgs e)
        {
            string constr = ConfigurationManager.ConnectionStrings["constr"].ConnectionString;
            SqlConnection con = new SqlConnection(constr);
            try
            {
                string uid = uname.Text;
                string pass = pwd.Text;
                con.Open();
                string qry = "select * from Users where Username='" + uid + "' and Password ='" + pass + "'";
                SqlCommand cmd = new SqlCommand(qry, con);
                SqlDataReader sdr = cmd.ExecuteReader();
                if (sdr.Read())
                {
                    Response.Redirect("Home.html");
                }
                else
                {
                    RegisterStartupScript("s", "<script> alert('Invalid login credentials check your username and password once again')</script>");
                    uname.Text = "";
                    pwd.Text = "";
                }
                con.Close();
            }
            catch (Exception ex)
            {
                Response.Write(ex.Message);
            }
        }
    }
}