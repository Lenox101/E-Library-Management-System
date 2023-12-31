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
    public partial class admin_publisher_management : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            GridView1.DataBind();
        }

        protected void Button1_Click(object sender, EventArgs e) //Go Button
        {
            getPublisherById();
        }

        protected void Button2_Click(object sender, EventArgs e)//Add Button
        {
            if (checkPublisherExists())
            {
                Response.Write("<script> alert('Publisher already exists with an identical ID'); </script>");

            }
            else
            {
                addPublisher();

            }
        }

        protected void Button3_Click(object sender, EventArgs e)// Update Button
        {
            if (checkPublisherExists())
            {
                updatePublisher();
                Response.Write("<script> alert('Publisher Updated'); </script>");

            }
            else
            {

                Response.Write("<script> alert('Publisher does not exist'); </script>");
            }
        }

        protected void Button4_Click(object sender, EventArgs e)// Delete Button
        {
            if (checkPublisherExists())
            {
                deletePublisher();
                Response.Write("<script> alert('Publisher Deleted'); </script>");

            }
            else
            {

                Response.Write("<script> alert('Publisher does not exist'); </script>");
            }
        }

        void getPublisherById()
        {
            try
            {
                String strcon = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Randy\\source\\repos\\E-Library_Management\\E-Library_Management\\App_Data\\elibraryDB.mdf;Integrated Security=True";
                SqlConnection con = new SqlConnection(strcon);
                con.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "SELECT * FROM publisher_master_tbl WHERE publisher_id ='" + txtpublisherid.Text.Trim() + "';";
                //we pass the command to a Sql data adapter first then record it to a datatable
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt); //just like ToString()

                if (dt.Rows.Count >= 1)
                {
                    txtpublishername.Text = dt.Rows[0][1].ToString();
                }
                else
                {
                    Response.Write("<script>alert('Invalid Publisher Id')</script>");
                }
            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('" + ex.Message + "');</script>");

            }
        }

        bool checkPublisherExists()
        {

            try
            {
                String strcon = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Randy\\source\\repos\\E-Library_Management\\E-Library_Management\\App_Data\\elibraryDB.mdf;Integrated Security=True";
                SqlConnection con = new SqlConnection(strcon);
                con.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "SELECT * FROM publisher_master_tbl WHERE publisher_id ='" + txtpublisherid.Text.Trim() + "';";
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
        void addPublisher()
        {
            try
            {
                String strcon = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Randy\\source\\repos\\E-Library_Management\\E-Library_Management\\App_Data\\elibraryDB.mdf;Integrated Security=True";
                SqlConnection con = new SqlConnection(strcon);
                con.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "INSERT INTO publisher_master_tbl(publisher_id,publisher_name) VALUES('" + txtpublisherid.Text.Trim() + "','" + txtpublishername.Text.Trim() + "')";

                cmd.ExecuteNonQuery();
                con.Close();
                Response.Write("<script>alert('Publisher added Successfully');</script>");
                clearForm();
                GridView1.DataBind();
            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('" + ex.Message + "')</script>");
            }
        }
        void deletePublisher()
        {
            try
            {
                String strcon = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Randy\\source\\repos\\E-Library_Management\\E-Library_Management\\App_Data\\elibraryDB.mdf;Integrated Security=True";
                SqlConnection con = new SqlConnection(strcon);
                con.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "DELETE FROM publisher_master_tbl WHERE publisher_id = '" + txtpublisherid.Text.Trim() + "' ";

                cmd.ExecuteNonQuery();
                con.Close();
                Response.Write("<script>alert('Publisher Deleted Successfully');</script>");
                clearForm();
                GridView1.DataBind();
            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('" + ex.Message + "')</script>");
            }
        }
        void updatePublisher()
        {
            try
            {
                String strcon = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Randy\\source\\repos\\E-Library_Management\\E-Library_Management\\App_Data\\elibraryDB.mdf;Integrated Security=True";
                SqlConnection con = new SqlConnection(strcon);
                con.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "UPDATE publisher_master_tbl SET publisher_name='"+txtpublishername.Text.Trim()+"' WHERE publisher_id='"+txtpublisherid.Text.Trim()+"'";

                cmd.ExecuteNonQuery();
                con.Close();
                Response.Write("<script>alert('Publisher updated Successfully');</script>");
                clearForm();
                GridView1.DataBind();
            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('" + ex.Message + "')</script>");
            }
        }

        void clearForm()
        {
            txtpublisherid.Text = "";
            txtpublishername.Text = "";
            
        }
    }   
}