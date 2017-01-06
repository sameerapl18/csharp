<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Assign3_AIAD.WebForm1" %>


<%@ Register Assembly="System.Web.DataVisualization, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35"
    Namespace="System.Web.UI.DataVisualization.Charting" TagPrefix="asp" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Pie Chart in Asp.Net Using C#.Net and VB.Net</title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
    <div class="container">
       
         <asp:UpdatePanel ID="UpdatePanel1" runat="server">

             <ContentTemplate>
       
             <table class="table-responsive" >
                 <tr>
                     <td>
   Mortgage Amount $ </td><td><asp:TextBox cssClass="br-square-input number" ID="mortgageAmnt" runat="server"></asp:TextBox></td>
           </tr>
                 <tr>
                     <td>
     Mortgage terms in years
                         </td>
                     <td>
            <asp:TextBox runat="server" id="numOfYears" type="number"  />
                         </td>
                     </tr>
   <tr><td> Interest Rate per year %</td><td><asp:TextBox ID="simInterest" runat="server"></asp:TextBox></td></tr>

   <tr><td> Mortgage Start Date</td><td><asp:TextBox runat="server" type="date" id="startDateWF" /></td></tr>

                </table>
            <asp:Button CssClass="btn-info" ID="Button1" runat="server" Text="Calculate" OnClick="Button1_Click" />

            
            <asp:Label ID="paymentDone" runat="server"></asp:Label>
           
                 <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" SelectCommand="SELECT * FROM [PieChartValues]"></asp:SqlDataSource>
    
       
            <asp:GridView ID="GridView1" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None">
                <AlternatingRowStyle BackColor="White" />
                <EditRowStyle BackColor="#2461BF" />
                <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
                <RowStyle BackColor="#EFF3FB" />
                <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
                <SortedAscendingCellStyle BackColor="#F5F7FB" />
                <SortedAscendingHeaderStyle BackColor="#6D95E1" />
                <SortedDescendingCellStyle BackColor="#E9EBEF" />
                <SortedDescendingHeaderStyle BackColor="#4870BE" />
            </asp:GridView>

    
                 </ContentTemplate>
               </asp:UpdatePanel>
        
    </div>
    </form>
           
       
    <script type="text/javascript" src="Scripts/jquery-1.9.1.min.js"></script>
    <script type="text/javascript" src="Scripts/bootstrap.min.js"></script>
    <script type="text/javascript"  src="Scripts/bootstrap.js"></script>
</body>
    </html>