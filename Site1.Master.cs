﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ElibraryManagement
{
    public partial class Site1 : System.Web.UI.MasterPage
    {

        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                if (Session["role"] == null) //no one
                {
                    LinkButton1.Visible = true; //login
                    LinkButton2.Visible = true; //sign up
                    LinkButton3.Visible = false; //logout
                    LinkButton7.Visible = false; //hello user
                    LinkButton6.Visible = true; //admin login

                    LinkButton8.Visible = false; //book inventory
                    LinkButton9.Visible = false; //book issuing
                    LinkButton10.Visible = false; //member management
                    LinkButton11.Visible = false; //author management
                    LinkButton12.Visible = false; //publisher management
                }
                else if (Session["role"].Equals("user"))
                {
                    LinkButton1.Visible = false; //login
                    LinkButton2.Visible = false; //sign up
                    LinkButton3.Visible = true; //logout
                    LinkButton7.Visible = true; //hello user
                    LinkButton7.Text = "Hello " + Session["username"].ToString(); //hello user
                    LinkButton6.Visible = false; //admin login

                    LinkButton8.Visible = false; //book inventory
                    LinkButton9.Visible = false; //book issuing
                    LinkButton10.Visible = false; //member management
                    LinkButton11.Visible = false; //author management
                    LinkButton12.Visible = false; //publisher management
                }
                else if (Session["role"].Equals("admin"))
                {
                    LinkButton1.Visible = false; //login
                    LinkButton2.Visible = false; //sign up
                    LinkButton4.Visible = false; //sign up
                    LinkButton3.Visible = true; //logout
                    LinkButton7.Visible = true; //hello user
                    LinkButton7.Text = "Hello " + Session["username"].ToString(); //hello user
                    LinkButton6.Visible = false; //admin login

                    LinkButton8.Visible = true; //book inventory
                    LinkButton9.Visible = true; //book issuing
                    LinkButton10.Visible = true; //member management
                    LinkButton11.Visible = true; //author management
                    LinkButton12.Visible = true; //publisher management
                }
            }
            catch(Exception ex)
            {

            }
        }
       

        protected void LinkButton6_Click(object sender, EventArgs e)
        {
            Response.Redirect("adminlogin.aspx");
        }

        protected void LinkButton11_Click(object sender, EventArgs e)
        {
            Response.Redirect("adminauthormanagement.aspx");
        }

        protected void LinkButton12_Click(object sender, EventArgs e)
        {
            Response.Redirect("adminpublishermanagement.aspx");
        }

        protected void LinkButton8_Click(object sender, EventArgs e)
        {
            Response.Redirect("adminbookinventory.aspx");
        }

        protected void LinkButton9_Click(object sender, EventArgs e)
        {
            Response.Redirect("adminbookissuing.aspx");
        }

        protected void LinkButton10_Click(object sender, EventArgs e)
        {
            Response.Redirect("adminmembermanagement.aspx");
        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            Response.Redirect("userlogin.aspx");
        }

        protected void LinkButton2_Click(object sender, EventArgs e)
        {
            Response.Redirect("usersignup.aspx");
        }

        protected void LinkButton7_Click(object sender, EventArgs e)
        {
            Response.Redirect("userviewprofile.aspx");
        }

        protected void LinkButton3_Click(object sender, EventArgs e)
        {
            Session["username"] = "";
            Session["fullname"] = "";
            Session["role"] = "";
            Session["status"] = "";


            LinkButton1.Visible = true; //login
            LinkButton2.Visible = true; //sign up
            LinkButton3.Visible = false; //logout
            LinkButton7.Visible = false; //hello user
            LinkButton6.Visible = true; //admin login

            LinkButton8.Visible = false; //book inventory
            LinkButton9.Visible = false; //book issuing
            LinkButton10.Visible = false; //member management
            LinkButton11.Visible = false; //author management
            LinkButton12.Visible = false; //publisher management

            Response.Redirect("homepage.aspx");
        }

        protected void LinkButton4_Click(object sender, EventArgs e)
        {
            Response.Redirect("viewbooks.aspx");
        }
    }
}