using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Login : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        
            DataClasses2DataContext data = new DataClasses2DataContext();

            var teamObj = (from a in data.Sports
                           group a by a.Team into newGroup
                           select new
                           {
                               teamName = newGroup.Key,
                               YTD_Sales = newGroup.Sum(x=> x.YTDSales),
                               Goal = newGroup.Sum(x=> x.Goal)
                           }).ToList();

            if (teamObj != null)
            {

                GridView1.DataSource = teamObj;
                GridView1.DataBind();
            }
    }
}