using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        string userName = User.Identity.Name;

        bool user = User.Identity.IsAuthenticated;

        if (user)
        {

            DataClasses2DataContext data = new DataClasses2DataContext();

            var teamObj = (from a in data.Sports
                           where a.Name == userName
                           select new
                           {
                               teamName = a.Team
                           }).ToList();

            if (teamObj != null)
            {
                string team = teamObj[0].teamName;
                Label1.Visible = true;
                Label1.Text = "You are in " + team;
                var dispalyContent = (from a in data.Sports
                                      where a.Team == team
                                      select new
                                      {
                                          Team = a.Name,
                                          YTD_Sales = a.YTDSales,
                                          Goal = a.Goal
                                      }).ToList();

                GridView1.DataSource = dispalyContent;
                GridView1.DataBind();
            }
            else
            {
                Label1.Text = "Incorrect Credentials";
            }

        }

        else
        {
            DataClasses2DataContext data = new DataClasses2DataContext();

            var teamObj = (from a in data.Sports
                           group a by a.Team into newGroup
                           select new
                           {
                               teamName = newGroup.Key,
                               YTD_Sales = newGroup.Sum(x => x.YTDSales),
                               Goal = newGroup.Sum(x => x.Goal)
                           }).ToList();

            if (teamObj != null)
            {

                GridView1.DataSource = teamObj;
                GridView1.DataBind();
            }
        
        }
    }
}