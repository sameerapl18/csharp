using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class ThirdContent : System.Web.UI.UserControl
{
    public String heading1;
    public String heading2;
    public String heading3;
    public String image1;
    public String image2;
    public String image3;
    public String text;
    public String readmore;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack) {
            heading1ID.Text = heading1;
            heading2ID.Text = heading2;
            heading3ID.Text = heading3;

            imageID1.ImageUrl = image1;
            imageID2.ImageUrl = image2;
            imageID3.ImageUrl = image3;

            text1.Text = text;
            text2.Text = text;
            text3.Text = text;

        }

    }

    protected void button_Click(object sender, EventArgs e)
    {
        Response.Redirect(readmore);

    }
}