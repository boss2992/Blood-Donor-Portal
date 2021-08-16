using Blood_Donor_Portal_BL;
using System;

namespace Blood_Donor_Portal
{
    public partial class Signup : System.Web.UI.Page
    {
        LoginAndSignup obj = new LoginAndSignup();

        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void signupbtn_Click(object sender, EventArgs e)
        {
            string email = mail.Text;
            string srch_qry = "Select Mail from Users where Mail='" + mail.Text + "'";
            bool Alreay_A_Member = obj.ExistingUser(srch_qry,email);

            if (Alreay_A_Member)
            {
                RegisterStartupScript("s", "<script> alert('This Mail ID has been already Registered, you can login directly')</script>");
                mail.Text = "";
                uname.Text = "";
                pwd.Text = "";
                cpwd.Text = "";
            }
            else
            {
                string ins_qry = "insert into Users values ('" + mail.Text + "','" + uname.Text + "','" + pwd.Text + "')";
                obj.NewUserRegistraion(ins_qry);
                Response.Redirect("login.aspx");
            }
        }
    }
}