using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace E_Library_Management
{
    public partial class E_Library : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                if (Session["role"].Equals(""))
                {
                    lbl_hellouser.Visible = false; //hello user label will not be seen

                    lk_adminlogin.Visible = true;
                    lk_authormanagement.Visible = false;
                    lk_bookinventory.Visible = false;
                    lk_bookissuing.Visible = false;
                    lk_membermanagement.Visible = false;
                    lk_publishermanagement.Visible = false;

                }
                else if (Session["role"].Equals("user"))
                {
                    lbl_hellouser.Visible = true; //hello user label will be seen
                    lbl_hellouser.Text = "Hello " + Session["first_name"].ToString();

                    lk_adminlogin.Visible = true;
                    lk_authormanagement.Visible = false;
                    lk_bookinventory.Visible = false;
                    lk_bookissuing.Visible = false;
                    lk_membermanagement.Visible = false;
                    lk_publishermanagement.Visible = false;
                }
                else if (Session["role"].Equals("admin"))
                {
                    lbl_hellouser.Visible = true; //hello user label will be seen
                    lbl_hellouser.Text = "Hello Admin";

                    lk_adminlogin.Visible = false;
                    lk_authormanagement.Visible = true;
                    lk_bookinventory.Visible = true;
                    lk_bookissuing.Visible = true;
                    lk_membermanagement.Visible = true;
                    lk_publishermanagement.Visible = true;
                }
            }
            catch(Exception ex) 
            {
               
            }

        }

        protected void lk_adminlogin_Click(object sender, EventArgs e)
        {
            Response.Redirect("adminlogin.aspx");
        }

        protected void lk_bookissuing_Click(object sender, EventArgs e)
        {
            Response.Redirect("admin_book_issueing.aspx");
        }

        protected void LinkButton11_Click(object sender, EventArgs e)
        {
            Response.Redirect("admin_author_management.aspx");
        }

        protected void LinkButton12_Click(object sender, EventArgs e)
        {
            Response.Redirect("admin_publisher_management.aspx");
        }

        protected void lk_bookinventory_Click(object sender, EventArgs e)
        {
            Response.Redirect("admin_book_inventory.aspx");
        }

        protected void lk_membermanagement_Click(object sender, EventArgs e)
        {
            Response.Redirect("admin_user_management.aspx");
        }
    }
}