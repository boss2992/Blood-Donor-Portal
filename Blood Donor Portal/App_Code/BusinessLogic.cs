using System;
using System.Configuration;
using System.Data.SqlClient;

namespace Blood_Donor_Portal_BL
{
    public class LoginAndSignup
    {
        public LoginAndSignup() { }

        public bool ExistingUser(string mail)
        {
            bool Already_A_Member;
            string srch_qry = "Select Mail from Users where Mail='" + mail.Trim() + "'";
            string constr = ConfigurationManager.ConnectionStrings["constr"].ConnectionString;
            SqlConnection con = new SqlConnection(constr);
            SqlCommand cmd = new SqlCommand(srch_qry, con);
            try
            {
                con.Open();
                SqlDataReader sdr = cmd.ExecuteReader();
                if (sdr.HasRows)
                {
                    Already_A_Member = true;
                }
                else
                {
                    Already_A_Member = false;
                }
                return Already_A_Member;
            }
            catch (Exception e)
            {
                throw e;
            }

            finally
            {
                con.Close();
                cmd.Dispose();
                con.Dispose();
            }

        }
        public void NewUserRegistraion(string mail, string uname, string pwd)
        {
            string ins_qry = "insert into Users values ('" + mail.Trim() + "','" + uname.Trim() + "','" + pwd.Trim() + "')";
            string constr = ConfigurationManager.ConnectionStrings["constr"].ConnectionString;
            SqlConnection con = new SqlConnection(constr);
            SqlCommand cmd = new SqlCommand(ins_qry, con);
            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                throw e;
            }

            finally
            {
                con.Close();
                cmd.Dispose();
                con.Dispose();
            }
        }

        public bool ValidateLogin(string uid, string pass)
        {
            bool LegitUser = false;
            string constr = ConfigurationManager.ConnectionStrings["constr"].ConnectionString;
            SqlConnection con = new SqlConnection(constr);
            string val_qry = "select * from Users where Username='" + uid.Trim() + "' and Password ='" + pass.Trim() + "'";
            SqlCommand cmd = new SqlCommand(val_qry, con);
            try
            {
                con.Open();
                SqlDataReader sdr = cmd.ExecuteReader();
                if (sdr.HasRows)
                {
                    LegitUser = true;
                }
                else
                {
                    LegitUser = false;
                }
                return LegitUser;
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                con.Close();
                cmd.Dispose();
                con.Dispose();
            }

        }
        
        public bool ValidateAdmin(string uid,string pass)
        {
            bool LegitAdmin = false;
            string constr = ConfigurationManager.ConnectionStrings["constr"].ConnectionString;
            SqlConnection con = new SqlConnection(constr);
            string val_qry = "select * from Admins where Name='" + uid.Trim() + "' and Password ='" + pass.Trim() + "'";
            SqlCommand cmd = new SqlCommand(val_qry, con);
            try
            {
                con.Open();
                SqlDataReader sdr = cmd.ExecuteReader();
                if (sdr.HasRows)
                {
                    LegitAdmin = true;
                }
                else
                {
                    LegitAdmin = false;
                }
                return LegitAdmin;
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                con.Close();
                cmd.Dispose();
                con.Dispose();
            }
        }
    }
}