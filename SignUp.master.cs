using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data.Sql;
using System.Data;
using System.Net;
using System.Net.Mail;
using System.IO;

public partial class Login : System.Web.UI.MasterPage
{

    SqlConnection conn = new SqlConnection("Data Source=DESKTOP-N7G8JNH\\SQLEXPRESS;Initial Catalog=dbCrowdTalk;Integrated Security=True");

    protected void Page_Load(object sender, EventArgs e)
    {
        conn.Open();
    }

    protected void btnRegister_Click1(object sender, EventArgs e)
    {
        SqlCommand cmd = new SqlCommand("insert into tblUsers(EMail,Password) values('"+ txtEmail.Text +"','"+ txtPassword.Text +"')",conn);

        try
        {
            int rowsAffected = cmd.ExecuteNonQuery();
            conn.Close();

            if (rowsAffected > 0)
            {
                // Data inserted successfully
                Application["mailRegister"] = txtEmail.Text;
                Response.Redirect("CreateProfile.aspx");
            }
            else
            {
                // Data insertion failed
                // Show an alert message and reload the page
                Response.Write("<script>alert('Data already exists.'); window.location.href = window.location.href;</script>");
            }
        }
        catch (SqlException ex)
        {
            // Handle specific SQL exceptions here
            if (ex.Number == 2627) // Primary key violation error number
            {
                // Show an alert message and reload the page
                Response.Write("<script>alert('Data already exists.'); window.location.href = window.location.href;</script>");
            }
            else
            {
                // Other SQL exception, handle or log accordingly
                Response.Write("<script>alert('An error occurred during registration.'); window.location.href = window.location.href;</script>");
            }
        }
        catch (Exception ex)
        {
            // Handle other exceptions here, log or display error as needed
            Response.Write("<script>alert('An error occurred during registration.'); window.location.href = window.location.href;</script>");
        }


        //int rowsAffected = cmd.ExecuteNonQuery();

        //if (rowsAffected > 0)
        //{
        //    // Data inserted successfully
        //    Application["mailRegister"] = txtEmail.Text;
        //    Response.Redirect("CreateProfile.aspx");
        //    conn.Close();
        //}
        //else
        //{
        //    // Data insertion failed
        //    Response.Redirect("SignUp.aspx?message=Data%20already%20exists");
        //    conn.Close();
        //}
    }
}
