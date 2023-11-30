<%@ WebHandler Language="C#" Class="UpvoteHandler" %>

using System;
using System.Web;
using System.Data.SqlClient;
using System.Data;
// UpvoteHandler.aspx.cs or UpvoteHandler.ashx.cs
public class UpvoteHandler : IHttpHandler
{
    public void ProcessRequest(HttpContext context)
    {
        string postId = context.Request["postId"];
        var username = HttpContext.Current.Application["EMail"];
        // Update the database record for the specified postId
        // ...
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-N7G8JNH\\SQLEXPRESS;Initial Catalog=dbCrowdTalk;Integrated Security=True");
        conn.Open();
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter("select * from tblPosts_Upvoted where Post_ID='" + postId + "' and Upvoted_By='" + username + "'", conn);
            ds = new DataSet();
            da.Fill(ds);

            if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                // Execute your query here
                // ...
                SqlCommand cmd = new SqlCommand("update tblContent set Upvotes = Upvotes - 1 where Post_Ref_ID = '" + postId + "'", conn);
                cmd.BeginExecuteNonQuery();
                SqlConnection conn2 = new SqlConnection("Data Source=DESKTOP-N7G8JNH\\SQLEXPRESS;Initial Catalog=dbCrowdTalk;Integrated Security=True");
                conn2.Open();

                SqlCommand cmd2 = new SqlCommand("delete from tblPosts_Upvoted where Post_ID = '" + postId + "' and Upvoted_By = '" + username + "'", conn2);
                cmd2.BeginExecuteNonQuery();          }
                
            else
            {

                SqlCommand cmd = new SqlCommand("update tblContent set Upvotes = Upvotes + 1 where Post_Ref_ID = '" + postId + "'", conn);
                cmd.BeginExecuteNonQuery();
                SqlConnection conn2 = new SqlConnection("Data Source=DESKTOP-N7G8JNH\\SQLEXPRESS;Initial Catalog=dbCrowdTalk;Integrated Security=True");
                conn2.Open();
                SqlCommand cmd2 = new SqlCommand("insert into tblPosts_Upvoted values('" + postId + "','" + username + "')", conn2);
                cmd2.BeginExecuteNonQuery();  
            }
        
    }

       public bool IsReusable {
        get {
            return false;
        }
    }
}