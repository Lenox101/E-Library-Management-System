using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace E_Library_Management
{
    
    public partial class userlogin : System.Web.UI.Page
    {
        String strcon = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Randy\\source\\repos\\E-Library_Management\\E-Library_Management\\App_Data\\elibraryDB.mdf;Integrated Security=True";
        protected void Page_Load(object sender, EventArgs e)
        {

        }


        protected void Button2_Click1(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(strcon);
                con.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "SELECT * FROM user_signup_tbl WHERE username='" + txtusername1.Text.Trim() + "' AND password='" + txtpassword1.Text.Trim() + "' ";

                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        Response.Write("<script>alert('" + dr.GetValue(0).ToString() + " is your admission number. Login Successful');</script>");
                        Session["reg_no"] = dr.GetValue(0).ToString();
                        Session["first_name"] = dr.GetValue(1).ToString();
                        Session["role"] = "user";
                    }
                    

                    Response.Redirect("homepage.aspx");
                }
                else
                {
                    Response.Write("<script>alert('Invalid Credentials')</script>");
                }


            }
            catch (Exception ex)
            {
                Response.Write(ex.Message);  
            }
        }
    }
}