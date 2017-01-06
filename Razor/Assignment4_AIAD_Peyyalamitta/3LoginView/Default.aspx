<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link rel="stylesheet" href="http://maxcdn.bootstrapcdn.com/bootstrap/3.3.6/css/bootstrap.min.css">
  <script src="https://ajax.googleapis.com/ajax/libs/jquery/1.12.0/jquery.min.js"></script>
  <script src="http://maxcdn.bootstrapcdn.com/bootstrap/3.3.6/js/bootstrap.min.js"></script>

    <style>
       .table{           
           border-collapse: separate !important;
       }
    </style>
</head>
<body>

    <form id="form1" runat="server">
        <div class="container" style="padding-top:2em;">
  <div class="panel panel-primary" style="padding:2em;">
    
 
        <!--
        <asp:HyperLink ID="HyperLink1" NavigateUrl="~/Login.aspx" runat="server">Login</asp:HyperLink>
        -->
        <asp:LoginStatus CssClass="btn btn-primary" ID="LoginStatus1" runat="server" />
        <br />
        <br />
      

        <asp:LoginView ID="LoginView1" runat="server">
            <AnonymousTemplate>
                <h3>Welcome guest. </h3>
            </AnonymousTemplate>
            <LoggedInTemplate>
                <h3>Welcome, <asp:LoginName ID="LoginName1" runat="server" />.</h3>
                
            </LoggedInTemplate>
        </asp:LoginView>
      <asp:Label ID="Label1" runat="server" Visible="false"></asp:Label>
      <br /><br />
        <asp:GridView ID="GridView1" CssClass="table" runat="server"></asp:GridView>

    </div>
      </div>
            </div>
    </form>
</body>
</html>
