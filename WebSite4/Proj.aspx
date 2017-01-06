<%@ Page Language="C#" MasterPageFile="~/MasterPage.master"  AutoEventWireup="true"  CodeFile="Proj.aspx.cs" Inherits="Proj" Title="FlexBox Assign3" %>

<%@ register src="UserControls/proj.ascx" tagname="controlProj" tagprefix="uc1" %>

 

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHoldersecondsec" Runat="Server">
    
     <uc1:controlProj id="control1" webtitle="WEB" runat="server" />
    </asp:Content>
