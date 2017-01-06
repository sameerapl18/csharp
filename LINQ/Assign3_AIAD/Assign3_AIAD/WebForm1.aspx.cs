using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.DataVisualization;
using System.Web.UI.DataVisualization.Charting;

using System.Web.UI.WebControls;
using System.Globalization;

namespace Assign3_AIAD
{
    public partial class WebForm1 : System.Web.UI.Page

    {

        List<MortgageTable> paymentsObjects = new List<MortgageTable>();
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            double monthlyPayment;

            double mortgageAmount = Convert.ToDouble(mortgageAmnt.Text);
            int noOfYears = Convert.ToInt32(numOfYears.Text);
            double interest = (Convert.ToDouble(simInterest.Text)) / 100;
            //DateTime startDate = DateTime.ParseExact(startDateWF.Text, "YYYY-MM-DD", System.Globalization.CultureInfo.InvariantCulture);
             DateTime startDate = Convert.ToDateTime(startDateWF.Text);

            double monIntRate = interest / 12;
            int noOfPayments = noOfYears * 12;
           // monIntRate = monIntRate * 10;

            monthlyPayment = (monIntRate * mortgageAmount * (Math.Pow(1 + monIntRate, noOfPayments))) / ((Math.Pow((1 + monIntRate), noOfPayments)) - 1);

            monthlyPayment = monthlyPayment;
            int count;

            if (noOfPayments > 15)
            {
                count = 15;
            }
            else
            {
                count = noOfPayments;
            }
            startDate.AddMonths(1).ToString("d");
            double totalInterest = 0;

            double pieChartInterest = 0;
            double pieChartPrinciple = 0;
            for (int i = 0; i <count; i++)
            {
                MortgageTable mortObj = new MortgageTable();
                double monthlyInterest = mortgageAmount * monIntRate;
                double principal = monthlyPayment - monthlyInterest;
                mortgageAmount = mortgageAmount - principal;
                //mortgageAmount = mortgageAmount * 10;
                // obj1.Payment = i;
                if (i == 1)
                {
                    pieChartInterest = monthlyInterest;
                    pieChartPrinciple = principal;
                }
                mortObj.Payment = Math.Round(monthlyPayment, 2);
                mortObj.principal = Math.Round(principal,2);
                mortObj.interest = Math.Round(monthlyInterest,2);
                totalInterest = totalInterest + monthlyInterest;
                mortObj.totalInterest = Math.Round(totalInterest,2);
                mortObj.balance = (Math.Round(mortgageAmount,2));
                mortObj.date = startDate.AddMonths(i).Month.ToString() + "/" + startDate.Date.Day.ToString() + "/" + startDate.Date.Year.ToString();
                startDate.AddMonths(i);
                paymentsObjects.Add(mortObj);
                


            }

            GridView1.DataSource = paymentsObjects;


            GridView1.DataBind();
            paymentDone.Text = "Monthly Payment ==> Interest = " + Math.Round(pieChartInterest,2) + " ; Principle = " + Math.Round(pieChartPrinciple,2);

          //  Chart1.DataBind();


        }
    }
}