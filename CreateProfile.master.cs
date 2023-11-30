using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.Sql;
using System.Data.SqlClient;

public partial class CreateProfile : System.Web.UI.MasterPage
{
    SqlConnection conn = new SqlConnection("Data Source=DESKTOP-N7G8JNH\\SQLEXPRESS;Initial Catalog=dbCrowdTalk;Integrated Security=True");
    protected void Page_Load(object sender, EventArgs e)
    {
        conn.Open();
    }
    protected void btnSaveProfile_Click(object sender, EventArgs e)
    {
    string email = (String)Application["mailRegister"];
    string username = txtUsername.Text;
    string gender = ddlGender.SelectedValue;
    string mobileNo = txtMobileNo.Text;

    if (txtUsername.Text != "")
    {
        if (txtMobileNo.Text != "")
        {
            if (ddlGender.SelectedIndex != -1)
            {
      
                    SqlCommand cmd = new SqlCommand("UPDATE tblUsers SET Username = '"+ username +"', Contact = '" + mobileNo + "', Gender = '" + gender + "' WHERE Email = '" + email + "'", conn);
                    cmd.BeginExecuteNonQuery();
                    Application["EMail"] = username;
                    Session["EMail"] = username;
                    Server.Transfer("CrowdTalk.aspx");
            }
        }
    }

    // Display a success message or redirect to another page
    Response.Redirect("ProfileUpdated.aspx");
    }
}
