using System;
using System.Collections.Generic;
using System.Security.Claims;
using System.Security.Principal;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.HtmlControls;
using System.Data;
using System;
using System.Data.SqlClient;

public partial class SiteMaster : MasterPage
{

    protected void Page_Load(object sender, EventArgs e)
    {
        String Username = (String)Application["EMail"];
        Label2.Text = "Welcome " + Username + " ";

        
    }
}