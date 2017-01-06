<%@ Control Language="C#" AutoEventWireup="true" CodeFile="Blog.ascx.cs" Inherits="UserControls_Blog" %>
<link href="StyleSheetAssign3.css" rel="stylesheet" />
     <asp:Panel runat="server" class="secondflex">
            <asp:Panel runat="server" class="leftflex">
                 <asp:Panel runat="server" class="titletext">
                     
                    <asp:Label runat="server" class="secondheader">BLOG</asp:Label>&nbsp;&nbsp;&nbsp;<asp:Label ID="webtext" runat="server" class="innercircle">WEB</asp:Label>
                     
                <br /><br /><br />
                        <asp:Label runat="server" class="text">
Lorem ipsum dolor sit amet, consectetur adipiscing elit,<br />
sed do eiusmod tempor incididunt ut labore et dolore<br />
magna aliqua. Ut enim ad minim veniam,
quis nostrud <br /> exercitation ullamco laboris
nisi ut aliquip ex ea<br /> commodo consequat.
Duis aute irure dolor in<br /> reprehenderit in 
voluptate velit esse cillum dolore eu<br /> fugiat 
nulla pariatur. Excepteur sint occaecat cupidatat <br />
non proident, sunt in culpa qui officia deserunt
mollit<br /> anim id est laborum.
                   </asp:Label> 
                 
                
            </asp:Panel></asp:Panel>
            <asp:Panel runat="server" class="rightflex">
                <asp:Image  width="578px" height="430px" src="../Images/blog.jpg" runat="server"  />
                

                  </asp:Panel>

        </asp:Panel>
<br /><br /><br />
<asp:Panel runat="server">
    <img width="1000px" src="../Images/blog-big.png" />

</asp:Panel>
