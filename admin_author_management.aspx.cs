using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace E_Library_Management
{
    public partial class admin_author_management : System.Web.UI.Page
    {
        
        protected void Page_Load(object sender, EventArgs e)
        {
            GridView1.DataBind();
        }
        // add button
        protected void Button2_Click(object sender, EventArgs e)
        {
            if(checkAuthorExists())
            {
                Response.Write("<script> alert('Author already exists with an identical ID'); </script>");

            }
            else
            {
                addAuthor();

            }

        }
        // update button
        protected void Button3_Click(object sender, EventArgs e)
        {
            if (checkAuthorExists())
            {
                updateAuthor();
                Response.Write("<script> alert('Author Updated'); </script>");

            }
            else
            {
                
                Response.Write("<script> alert('Author does not exist'); </script>");
            }
        }

        void updateAuthor()
        {
            try
            {
                String strcon = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Randy\\source\\repos\\E-Library_Management\\E-Library_Management\\App_Data\\elibraryDB.mdf;Integrated Security=True";
                SqlConnection con = new SqlConnection(strcon);
                con.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "UPDATE author_master_tbl SET author_name = '"+txtauthorname.Text.Trim()+"' WHERE author_id = '"+txtauthorid.Text.Trim()+"'";

                cmd.ExecuteNonQuery();
                con.Close();
                Response.Write("<script>alert('Author updated Successfully');</script>");
                clearForm();
                GridView1.DataBind();
            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('" + ex.Message + "')</script>");
            }
        }
        //delete button
        protected void Button4_Click(object sender, EventArgs e)
        {
            if (checkAuthorExists())
            {
                deleteAuthor();
                Response.Write("<script> alert('Author Deleted'); </script>");

            }
            else
            {

                Response.Write("<script> alert('Author does not exist'); </script>");
            }
        }

        void deleteAuthor()
        {
            try
            {
                String strcon = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Randy\\source\\repos\\E-Library_Management\\E-Library_Management\\App_Data\\elibraryDB.mdf;Integrated Security=True";
                SqlConnection con = new SqlConnection(strcon);
                con.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "DELETE FROM author_master_tbl WHERE author_id = '" + txtauthorid.Text.Trim() + "' ";

                cmd.ExecuteNonQuery();
                con.Close();
                Response.Write("<script>alert('Author Deleted Successfully');</script>");
                clearForm();
                GridView1.DataBind();
            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('" + ex.Message + "')</script>");
            }
        }



        // find button
        protected void Button1_Click(object sender, EventArgs e)
        {
            getAuthorById();
        }

        void getAuthorById()
        {
            try
            {
                String strcon = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Randy\\source\\repos\\E-Library_Management\\E-Library_Management\\App_Data\\elibraryDB.mdf;Integrated Security=True";
                SqlConnection con = new SqlConnection(strcon);
                con.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "SELECT * FROM author_master_tbl WHERE author_id ='" + txtauthorid.Text.Trim() + "';";
                //we pass the command to a Sql data adapter first then record it to a datatable
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt); //just like ToString()

                if (dt.Rows.Count >= 1)
                {
                    txtauthorname.Text = dt.Rows[0][1].ToString();
                }
                else
                {
                    Response.Write("<script>alert('Invalid Author Id')</script>");
                }
            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('" + ex.Message + "');</script>");
                
            }
        }

        bool checkAuthorExists()
        {

            try
            {
                String strcon = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Randy\\source\\repos\\E-Library_Management\\E-Library_Management\\App_Data\\elibraryDB.mdf;Integrated Security=True";
                SqlConnection con = new SqlConnection(strcon);
                con.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "SELECT * FROM author_master_tbl WHERE author_id ='" +txtauthorid.Text.Trim() + "';";
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
        void addAuthor()
        {
            try {
                String strcon = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Randy\\source\\repos\\E-Library_Management\\E-Library_Management\\App_Data\\elibraryDB.mdf;Integrated Security=True";
                SqlConnection con = new SqlConnection(strcon);
                con.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "INSERT INTO author_master_tbl(author_id,author_name) VALUES('" + txtauthorid.Text.Trim() + "','" + txtauthorname.Text.Trim() + "')";
                
                cmd.ExecuteNonQuery();
                con.Close();
                Response.Write("<script>alert('Author added Successfully');</script>");
                clearForm();
                GridView1.DataBind();
            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('"+ex.Message+"')</script>");
            }
        }

        void clearForm()
        {
            txtauthorid.Text = "";
            txtauthorname.Text = "";
        }
    }
}