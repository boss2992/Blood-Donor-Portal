using System;
using System.Configuration;
using System.Data.SqlClient;

namespace Blood_Donor_Portal_BL
{
    public class LoginAndSignup 
    {
        public LoginAndSignup() { }

        public bool ExistingUser(string srch_qry,string mail)
        {
            bool Already_A_Member;
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
            }
            catch(Exception e) 
            {
                throw e;           
            }

            finally
            {
                con.Close();
                cmd.Dispose();
                con.Dispose();
            }
            return Already_A_Member;

        }
        public void NewUserRegistraion(string ins_qry)
        {
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
            string val_qry = "select * from Users where Username='" + uid + "' and Password ='" + pass + "'";
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
            return LegitUser;

        }
    }
}