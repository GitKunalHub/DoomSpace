using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.Sql;
using System.Data.SqlClient;


public partial class Post : System.Web.UI.MasterPage
{
    SqlConnection conn = new SqlConnection("Data Source=DESKTOP-N7G8JNH\\SQLEXPRESS;Initial Catalog=dbCrowdTalk;Integrated Security=True");
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btnAddComment_Click(object sender, EventArgs e)
    {
        Button btnAddComment = (Button)sender;
        int postId = Convert.ToInt32(btnAddComment.CommandArgument);

        // Rest of your code to save the comment and update the comment list
        // Find the parent DataListItem that contains the button
        DataListItem dataListItem = (DataListItem)btnAddComment.NamingContainer;

        // Find the comment input control within the DataListItem
        TextBox txtComment = (TextBox)dataListItem.FindControl("txtComment");

        // Get the comment content from the input control
        string commentContent = txtComment.Text;

        // Save the comment to the database
        SaveComment(postId, commentContent);

        // Update the comment list
        //UpdateCommentList(postId);

        // Clear the comment input control
        txtComment.Text = string.Empty;
    }
    private void SaveComment(int postId, string commentContent)
    {
        conn.Open();
        int Comment_Replies = 0;
        int Comment_Ref_ID = 0;
        String Username = (String)Application["EMail"];
        SqlCommand cmd = new SqlCommand("insert into tblComments(Post_ID,Comment_Content,Comment_Date,Comment_Replies,Comment_Ref_ID,Comment_From) values('" + postId + "','" + commentContent + "','" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "'," + Comment_Replies + ", " + Comment_Ref_ID + ",'" + Username + "');", conn);
        SqlParameter parameter = new SqlParameter("@Comment_Date", System.Data.SqlDbType.DateTime);
        parameter.Value = DateTime.Now; // Set the current date and time

        // Add the parameter to the command
        cmd.Parameters.Add(parameter);
        cmd.BeginExecuteNonQuery();
    }

    //private void UpdateCommentList(int postId)
    //{
    //    // Assuming you have a connection string defined in your web.config file
    //    SqlConnection connectionString = new SqlConnection("Data Source=DESKTOP-N7G8JNH\\SQLEXPRESS;Initial Catalog=dbCrowdTalk;Integrated Security=True");
    //    connectionString.Open();
    //    // Create a new SQL connection
    //    using (SqlConnection connection = new SqlConnection(connectionString))
    //    {
    //        // Create the SQL command to retrieve the comments for the specified post
    //        string query = "SELECT Comment_Content FROM tblComment WHERE Post_ID = @PostID";
    //        SqlCommand command = new SqlCommand(query, connection);
    //        command.Parameters.AddWithValue("@PostID", postId);

    //        // Create a new StringBuilder to store the comment list HTML
    //        StringBuilder commentListHtml = new StringBuilder();

    //        // Open the connection and execute the command
    //        connection.Open();
    //        SqlDataReader reader = command.ExecuteReader();

    //        // Loop through the retrieved comments and build the comment list HTML
    //        while (reader.Read())
    //        {
    //            string commentContent = reader["Comment_Content"].ToString();

    //            // Add the comment content to the HTML string
    //            commentListHtml.Append("<li>");
    //            commentListHtml.Append(commentContent);
    //            commentListHtml.Append("</li>");
    //        }

    //        // Close the data reader
    //        reader.Close();

    //        // Find the placeholder control for the comment list
    //        PlaceHolder commentListPlaceholder = (PlaceHolder)dataListItem.FindControl("commentListPlaceholder");

    //        // Create a new Literal control with the comment list HTML
    //        Literal commentListLiteral = new Literal();
    //        commentListLiteral.Text = commentListHtml.ToString();

    //        // Clear any existing controls in the placeholder
    //        commentListPlaceholder.Controls.Clear();

    //        // Add the comment list literal control to the placeholder
    //        commentListPlaceholder.Controls.Add(commentListLiteral);
    //    }
    //}
    protected void Button1_Click(object sender, EventArgs e)
    {
        {
            int postId = Convert.ToInt32(Request.QueryString["postid"]);

            int Comment_Replies = 0;
            int Comment_Ref_ID = 0;
            String Username = (String)Application["EMail"];

            SqlConnection conn = new SqlConnection("Data Source=DESKTOP-N7G8JNH\\SQLEXPRESS;Initial Catalog=dbCrowdTalk;Integrated Security=True");
            conn.Open();
            SqlCommand cmd = new SqlCommand("insert into tblComments(Post_ID,Comment_Content,Comment_Date,Comment_Replies,Comment_Ref_ID,Comment_From) values(" + postId + ",'" + TextBox1.Text + "','" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "'," + Comment_Replies + ", " + Comment_Ref_ID + ",'" + Username + "');", conn);
            SqlParameter parameter = new SqlParameter("@Comment_Date", System.Data.SqlDbType.DateTime);
            parameter.Value = DateTime.Now; // Set the current date and time

            // Add the parameter to the command
            cmd.Parameters.Add(parameter);
            cmd.BeginExecuteNonQuery();
        }
    }
    protected void btn1_Click(object sender, EventArgs e)
    {
        TextBox textBox2 = (TextBox)DataList2.Controls[0].FindControl("TextBox1");

        // Accessing Button2 in DataList2
        Button button2 = (Button)DataList2.Controls[0].FindControl("Button1");

        // Accessing Label2 in DataList2
        Label label2 = (Label)DataList2.Controls[0].FindControl("Label1");

        int postId = Convert.ToInt32(Request.QueryString["postid"]);

        int Comment_Replies = 0;
        int Comment_Ref_ID = 0;
        String Username = (String)Application["EMail"];

        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-N7G8JNH\\SQLEXPRESS;Initial Catalog=dbCrowdTalk;Integrated Security=True");
        conn.Open();
        SqlCommand cmd = new SqlCommand("insert into tblComments(Post_ID,Comment_Content,Comment_Date,Comment_Replies,Comment_Ref_ID,Comment_From) values(" + postId + ",'" + textBox2.Text + "','" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "'," + Comment_Replies + ", " + Comment_Ref_ID + ",'" + Username + "');", conn);
        SqlParameter parameter = new SqlParameter("@Comment_Date", System.Data.SqlDbType.DateTime);
        parameter.Value = DateTime.Now; // Set the current date and time

        // Add the parameter to the command
        cmd.Parameters.Add(parameter);
        cmd.BeginExecuteNonQuery();
    }
    protected void btn2_Click(object sender, EventArgs e)
    {
        TextBox textBox3 = (TextBox)DataList3.Controls[0].FindControl("TextBox1");

        // Accessing Button3 in DataList3
        Button button3 = (Button)DataList3.Controls[0].FindControl("Button1");

        // Accessing Label3 in DataList3
        Label label3 = (Label)DataList3.Controls[0].FindControl("Label1");

        int postId = Convert.ToInt32(Request.QueryString["postid"]);

        int Comment_Replies = 1;
        int Comment_Ref_ID = 0;
        String Username = (String)Application["EMail"];

        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-N7G8JNH\\SQLEXPRESS;Initial Catalog=dbCrowdTalk;Integrated Security=True");
        conn.Open();
        SqlCommand cmd = new SqlCommand("insert into tblComments(Post_ID,Comment_Content,Comment_Date,Comment_Replies,Comment_Ref_ID,Comment_From) values(" + postId + ",'" + textBox3.Text + "','" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "'," + Comment_Replies + ", " + Comment_Ref_ID + ",'" + Username + "');", conn);
        SqlParameter parameter = new SqlParameter("@Comment_Date", System.Data.SqlDbType.DateTime);
        parameter.Value = DateTime.Now; // Set the current date and time

        // Add the parameter to the command
        cmd.Parameters.Add(parameter);
        cmd.BeginExecuteNonQuery();
    }
    protected void btn3_Click(object sender, EventArgs e)
    {
        TextBox textBox4 = (TextBox)DataList4.Controls[0].FindControl("TextBox1");

        // Accessing Button4 in DataList4
        Button button4 = (Button)DataList4.Controls[0].FindControl("Button1");

        // Accessing Label4 in DataList4
        Label label4 = (Label)DataList4.Controls[0].FindControl("Label1");

        int postId = Convert.ToInt32(Request.QueryString["postid"]);

        int Comment_Replies = 2;
        int Comment_Ref_ID = 0;
        String Username = (String)Application["EMail"];

        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-N7G8JNH\\SQLEXPRESS;Initial Catalog=dbCrowdTalk;Integrated Security=True");
        conn.Open();
        SqlCommand cmd = new SqlCommand("insert into tblComments(Post_ID,Comment_Content,Comment_Date,Comment_Replies,Comment_Ref_ID,Comment_From) values(" + postId + ",'" + textBox4.Text + "','" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "'," + Comment_Replies + ", " + Comment_Ref_ID + ",'" + Username + "');", conn);
        SqlParameter parameter = new SqlParameter("@Comment_Date", System.Data.SqlDbType.DateTime);
        parameter.Value = DateTime.Now; // Set the current date and time

        // Add the parameter to the command
        cmd.Parameters.Add(parameter);
        cmd.BeginExecuteNonQuery();

    }
}

