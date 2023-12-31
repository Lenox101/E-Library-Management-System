using System;
using System.Collections.Generic;
using System.Configuration; //importing the Configuration Library to use the ConfigurationManager Class
using System.Data.SqlClient; //to be able to use the SqlConnection class
using System.Linq;
using System.Data;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace E_Library_Management
{
    public partial class Sign_Up : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void Button1_Click1(object sender, EventArgs e)
        {
            if (checkMemberExist())
            {
                Response.Write("<script>alert('A user with this username already exists');</script>");
            }
            else
            {
                signupnewuser();
            }
        }

        bool checkMemberExist()
        {
           
                //connection string
                String strcon = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Randy\\source\\repos\\E-Library_Management\\E-Library_Management\\App_Data\\elibraryDB.mdf;Integrated Security=True";
                SqlConnection con = new SqlConnection(strcon);
                con.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "select * from user_signup_tbl where username='"+txtusername.Text.Trim()+"';";
                //we pass the command to a Sql data adapter first then record it to a datatable
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt); //just like ToString()

                if(dt.Rows.Count >=1)
                {
                    return true;
                }
                else
                {
                    return false;
                }

        }

       void signupnewuser()
        {
            try
            {
                //connection string
                String strcon = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Randy\\source\\repos\\E-Library_Management\\E-Library_Management\\App_Data\\elibraryDB.mdf;Integrated Security=True";
                SqlConnection con = new SqlConnection(strcon);
                con.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "INSERT INTO user_signup_tbl(first_name,second_name,dob,contact,email,yos,gender,postal_address,username,password) VALUES('" + txtfirst_name.Text + "','" + txtsecond_name.Text + "','" + txtdob.Text + "','" + Convert.ToInt32(txtcontact.Text) + "','" + txtemail.Text + "','" + Convert.ToInt32(txtyos.Text) + "','" + txtgender.SelectedItem.Value + "','" + Convert.ToInt32(txtpostal_address.Text) + "','" + txtusername.Text + "','" + txtpassword.Text + "')";
                cmd.ExecuteNonQuery();
                con.Close();

                Response.Write("<script>alert('You have successfully Registered!!');</script>");
                Response.Redirect("userlogin.aspx");
                //clear text boxes
                txtfirst_name.Text = "";
                txtsecond_name.Text = "";
                txtdob.Text = "";
                txtcontact.Text = "";
                txtemail.Text = "";
                txtyos.Text = "";
                txtgender.Text = "";
                txtpostal_address.Text = "";
                txtusername.Text = "";
                txtpassword.Text = "";
                txtconfirm_password.Text = "";
            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('" + ex.Message + "');</script>");
            }
        }
    }
}