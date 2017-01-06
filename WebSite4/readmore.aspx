<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true"  CodeFile="readmore.aspx.cs" Inherits="readmore" Title="FlexBox Assign3" %>

<%@ register src="UserControls/readmore.ascx" tagname="controlProj" tagprefix="uc1" %>

 

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHoldersecondsec" Runat="Server">
    <link href="StyleSheetAssign3.css" rel="stylesheet" />
     <uc1:controlProj id="control1" runat="server" 
         text="Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum"
         />
    </asp:Content>