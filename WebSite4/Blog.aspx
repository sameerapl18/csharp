<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true"  CodeFile="Blog.aspx.cs" Inherits="Blog" Title="FlexBox Assign3" %>

<%@ register src="UserControls/Blog.ascx" tagname="controlProj" tagprefix="uc1" %>

 

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHoldersecondsec" Runat="Server">
    <link href="StyleSheetAssign3.css" rel="stylesheet" />
     <uc1:controlProj id="control1" webtitle="WEB" runat="server" />
    </asp:Content>