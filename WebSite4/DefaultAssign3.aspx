<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true"  CodeFile="DefaultAssign3.aspx.cs" Inherits="DefaultAssign3" Title="FlexBox Assign3" %>
<%@ register src="UserControls/SecondContent.ascx" tagname="control2" tagprefix="uc1" %>
<%@ register src="UserControls/ThirdContent.ascx" tagname="control3" tagprefix="uc1" %>
 

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHoldersecondsec" Runat="Server">
     <uc1:control2 id="control2" webtitle="WEB" runat="server" />
    </asp:Content>


<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolderthirdsec" runat="server">
     <uc1:control3 id="Control3" runat="server" heading3="WORK" heading2="INSPIRATION" heading1="DESIGNING" 
         image1="../Images/designing.png" image2="../Images/inspiration.jpg" image3="../Images/work.jpg" 
         text="Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum"
         readmore="/readmore.aspx"
         />
 
</asp:Content>

