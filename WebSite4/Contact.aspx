<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true"  CodeFile="Contact.aspx.cs" Inherits="Contact" Title="FlexBox Assign3" %>

<%@ register src="UserControls/Contact.ascx" tagname="controlProj" tagprefix="uc1" %>

 

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHoldersecondsec" Runat="Server">
    <link href="StyleSheetAssign3.css" rel="stylesheet" />
     <uc1:controlProj id="control1" webtitle="WEB" runat="server" />
    </asp:Content>