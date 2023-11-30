using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.Sql;
using System.Data.SqlClient;


public partial class CreateCommunity : System.Web.UI.MasterPage
{
    SqlConnection conn = new SqlConnection("Data Source=DESKTOP-N7G8JNH\\SQLEXPRESS;Initial Catalog=dbDoomSpace;Integrated Security=True");
    protected void Page_Load(object sender, EventArgs e)
    {
        conn.Open();
    }
    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        DateTime click = DateTime.Now;
        String Username = "Kunal";
        SqlCommand cmd = new SqlCommand("insert into tblCommunity(Community_Name,Community_Bio,Community_By) values('" + txtCommunityName.Text + "','" + txtCommunityAbout.Text + "','" + Username + "')", conn);
        cmd.BeginExecuteNonQuery();
    }
}
