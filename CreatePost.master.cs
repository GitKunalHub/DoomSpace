using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.Sql;
using System.Data.SqlClient;
using Cloudinary;
using System;
using System.IO;
using System.Net;
using System.Threading.Tasks;

// ...

// Save the image to Cloudinary and get the URL


public partial class CreatePost : System.Web.UI.MasterPage
{
    SqlConnection conn = new SqlConnection("Data Source=DESKTOP-N7G8JNH\\SQLEXPRESS;Initial Catalog=dbCrowdTalk;Integrated Security=True");
    protected void Page_Load(object sender, EventArgs e)
    {
        conn.Open();
    }
    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        String Username = (String)Application["EMail"];
        String dtNow = DateTime.Now.ToString();
        String Content_Title = txtTitle.Text;
        String Content_Description = txtContent.Text;
        String Community_Name = "IMCC";
        int Upvotes = 0;

        if (FileUpload2.HasFile == true)
        {
            if (txtContent.Text != "")
            {
                if (txtTitle.Text != "")
                {
                    FileUpload2.SaveAs("G:\\DoomSpace\\images\\" + FileUpload2.FileName);
                    String img = "images\\" + FileUpload2.FileName;
                    SqlCommand cmd = new SqlCommand("insert into tblContent(Posted_on,Content_Title,Content_Description,Content_ImgSrc,Community_Name,Username,Upvotes) values('" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "','" + Content_Title + "','" + Content_Description + "','" + img + "','" + Community_Name + "','" + Username + "','" + Upvotes + "')", conn);
                    SqlParameter parameter = new SqlParameter("@PostedOn", System.Data.SqlDbType.DateTime);
                    parameter.Value = DateTime.Now; // Set the current date and time

                    // Add the parameter to the command
                    cmd.Parameters.Add(parameter);
                    cmd.BeginExecuteNonQuery();
                    Response.Redirect("CrowdTalk.aspx");
                }
            }
        }
        else
        {
            Response.Write("Please select a file");
        }
        conn.Close();
    }
}
