using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data.Sql;
using System.Data;

public partial class Register : System.Web.UI.MasterPage
{
    SqlConnection conn = new SqlConnection("Data Source=DESKTOP-N7G8JNH\\SQLEXPRESS;Initial Catalog=dbCrowdTalk;Integrated Security=True");
    protected void Page_Load(object sender, EventArgs e)
    {
        conn.Open();
    }
    protected void btnLogin_Click(object sender, EventArgs e)
    {
        
        SqlCommand cmd = new SqlCommand("select * from tblUsers where EMail='" + txtEmail.Text + "' and Password='" + txtPassword.Text + "'", conn);

        try
        {
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                // Data inserted successfully
                Application["EMail"] = txtEmail.Text;
                Response.Redirect("CrowdTalk.aspx");
            }
            else
            {
                // Data insertion failed
                // Show an alert message and reload the page
                Response.Write("<script>alert(' Invalid Credentials ');</script>");
            }
        }
        catch (SqlException ex)
        {
            // Handle specific SQL exceptions here
            if (ex.Number == 2627) // Primary key violation error number
            {
                // Show an alert message and reload the page
                Response.Write("<script>alert('"+ex.Message+"');</script>");
            }
            else
            {
                // Other SQL exception, handle or log accordingly
                Response.Write("<script>alert('"+ ex.Message +"');</script>");
            }
        }
        catch (Exception ex2)
        {
            // Handle other exceptions here, log or display error as needed
            Response.Write("<script>alert('"+ ex2.Message +"');</script>");
        }
        //try
        //{
        //    DataSet ds = new DataSet();
        //    SqlDataAdapter da = new SqlDataAdapter("select * from tblUsers where EMail='" + txtEmail.Text + "' and Password='" + txtPassword.Text + "'", conn);
        //    ds = new DataSet();
        //    da.Fill(ds);
        //    Username = ds.Tables[0].Rows[0]["EMail"].ToString();
        //    Password = ds.Tables[0].Rows[0]["Password"].ToString();
        //    email = ds.Tables[0].Rows[0]["Username"].ToString();
        //    Application["EMail"] = email;
        //    Session["EMail"] = email;
        //}
        //catch (Exception)
        //{
        //    Response.Write("<script>alert('Invalid Data Record!'); window.location.href = window.location.href;</script>");
        //}
        ////Application["Login"] = "Login";
        //Server.Transfer("CrowdTalk.aspx");
    }
}
