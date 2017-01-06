using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class MasterPage : System.Web.UI.MasterPage
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Page_PreInit(object sender, EventArgs e)
    {
    }
    protected void strTheme_DataBound(object sender, EventArgs e)
    {
        strTheme.SelectedValue = Page.Theme;
    }
    protected void strTheme_SelectedIndexChanged(object sender, EventArgs e)
    {
        Session.Add("MyTheme", strTheme.SelectedValue);
        Server.Transfer(Request.FilePath);
    }
}
