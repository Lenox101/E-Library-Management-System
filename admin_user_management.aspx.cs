using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace E_Library_Management
{
    public partial class adminProfile : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            GridView1.DataBind();

        }
        // Find btn
        protected void LinkButton4_Click(object sender, EventArgs e)
        {
            getUserById();
        }

        //Delete btn
        protected void Button2_Click(object sender, EventArgs e)
        {
           deleteUser();
          
        }
        //approve btn
        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            updateUserStatus("Approved");
        }
        //pause btn
        protected void LinkButton2_Click(object sender, EventArgs e)
        {
            updateUserStatus("Pending");
        }
        //disapprouve btn
        protected void LinkButton3_Click(object sender, EventArgs e)
        {
            updateUserStatus("Disapproved");
        }


        void updateUserStatus(string status)
        {
            if(checkUserExists())
            {
                try
                {
                    String strcon = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Randy\\source\\repos\\E-Library_Management\\E-Library_Management\\App_Data\\elibraryDB.mdf;Integrated Security=True";
                    SqlConnection con = new SqlConnection(strcon);
                    con.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = con;
                    cmd.CommandText = "UPDATE user_signup_tbl SET [account_status] ='" + status + "' WHERE [reg_no]='" + Convert.ToInt32(txtregno.Text.Trim()) + "'; ";
                    cmd.ExecuteNonQuery();
                    cmd.Clone();
                    GridView1.DataBind();
                    Response.Write("<script>alert('Account Updated successfully')</script>");

                }
                catch (Exception ex)
                {
                    Response.Write("<script>alert('" + ex.Message + "');</script>");
                }
            }
            else
            {
                Response.Write("<script>alert('User Doesn't exist');</script>");
            }
        }

        void getUserById()
        {
            try
            {
                String strcon = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Randy\\source\\repos\\E-Library_Management\\E-Library_Management\\App_Data\\elibraryDB.mdf;Integrated Security=True";
                SqlConnection con = new SqlConnection(strcon);
                con.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "SELECT * FROM user_signup_tbl WHERE [reg_no] ='" + txtregno.Text.Trim() + "';";
                //we pass the command to a Sql data adapter first then record it to a datatable
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        txtusername.Text = dr.GetValue(9).ToString();
                        txtaccountstatus.Text = dr.GetValue(11).ToString();
                        txtdob.Text = dr.GetValue(3).ToString();
                        txtcontact.Text = dr.GetValue(4).ToString();
                        txtemailaddress.Text = dr.GetValue(5).ToString();
                        txtyos.Text = dr.GetValue(6).ToString();
                        txtfulladdress.Text = dr.GetValue(8).ToString();
                    }
                }
                else
                {
                    Response.Write("<script>alert('No user with Registration number')</script>");
                }
            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('" + ex.Message + "');</script>");

            }
        }

        void deleteUser()
        {
            if (checkUserExists())
            {
                try
                {
                    String strcon = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Randy\\source\\repos\\E-Library_Management\\E-Library_Management\\App_Data\\elibraryDB.mdf;Integrated Security=True";
                    SqlConnection con = new SqlConnection(strcon);
                    con.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = con;
                    cmd.CommandText = "DELETE FROM user_signup_tbl WHERE reg_no = '" + Convert.ToInt32(txtregno.Text.Trim()) + "' ";
                    cmd.ExecuteNonQuery();
                    con.Close();
                    Response.Write("<script>alert('User Deleted Successfully');</script>");
                    clearTextboxes();
                    GridView1.DataBind();
                }
                catch (Exception ex)
                {
                    Response.Write("<script>alert('" + ex.Message + "')</script>");
                }
               
            }
            else
            {
                Response.Write("<script>alert('User Doesn't Exist');</script>");
            }
        }

        bool checkUserExists()
        {
            try
            {
                String strcon = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Randy\\source\\repos\\E-Library_Management\\E-Library_Management\\App_Data\\elibraryDB.mdf;Integrated Security=True";
                SqlConnection con = new SqlConnection(strcon);
                con.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "SELECT * FROM user_signup_tbl WHERE reg_no ='" + Convert.ToInt32(txtregno.Text.Trim()) + "';";
                //we pass the command to a Sql data adapter first then record it to a datatable
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt); //just like ToString()

                if (dt.Rows.Count >= 1)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('" + ex.Message + "');</script>");
                return false;
            }
            
        }

        void clearTextboxes()
        {
            txtusername.Text = "";
            txtaccountstatus.Text = "";
            txtdob.Text = "";
            txtcontact.Text = "";
            txtemailaddress.Text = "";
            txtyos.Text = "";
            txtfulladdress.Text = "";
        }
     

    }
}