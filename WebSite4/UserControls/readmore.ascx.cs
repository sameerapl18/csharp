﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class UserControls_readmore : System.Web.UI.UserControl
{
    public String text;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack) {
            textreadmore.Text = text;
            Label1.Text = text;
            Label2.Text = text;
            Label3.Text = text;
        }
    }
}