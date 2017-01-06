<%@ Control Language="C#" AutoEventWireup="true" CodeFile="ThirdContent.ascx.cs" Inherits="ThirdContent" %>
<asp:Panel runat="server" class="thirdflex">
            <asp:Panel runat="server" class="thirdflexsub">
                <table>
                    <tr>
                        <td>
              <asp:Label runat="server" ID="heading1ID" class="thirdheader" ></asp:Label>
                             <hr class="line" />
                            </td>
                        </tr>
                            
                <tr><td>
                <asp:Image ID="imageID1" runat="server"  /></td></tr>
                    <tr><td>
                                               <asp:Label ID="text1" runat="server" class="textsec">

                   </asp:Label> 
                        </td></tr>
                     <tr><td><br /><br /><asp:Button runat="server" class="buttonreadmore" value="read more" Text="read more" OnClick="button_Click"/></td></tr>
                </table>
                    
            </asp:Panel>
             <asp:Panel runat="server" class="thirdflexsub">
                 <table>
                    <tr>
                        <td>
              <asp:Label runat="server" ID="heading2ID" class="thirdheader" ></asp:Label>
                             <hr class="line" />
                            </td>
                        </tr>
                            
                <tr><td>
                    <asp:Image ID="imageID2" runat="server"  />  </td></tr>
                    <tr><td>
                                               <asp:Label ID="text2" runat="server" class="textsec">

                   </asp:Label> 
                        </td></tr>
                      <tr><td><br /><br /><asp:Button runat="server" class="buttonreadmore" value="read more" Text="read more"/></td></tr>
                </table>
            </asp:Panel>
             <asp:Panel runat="server" class="thirdflexsub">
                 <br /><br />
                <table>
                    <tr>
                        <td>
               <asp:Label runat="server" ID="heading3ID" class="thirdheader" ></asp:Label>
                             <hr class="line" />
                            </td>
                        </tr>
                            
                <tr><td>
                    <asp:Image ID="imageID3" runat="server" /></td></tr>
                    <tr><td>
                                               <asp:Label ID="text3" runat="server"  class="textsec">

                   </asp:Label> 
                        </td></tr>
                    <tr><td><br /><br /><asp:Button runat="server" class="buttonreadmore" value="read more" Text="read more"/></td></tr>
                </table>
            </asp:Panel>

        </asp:Panel>
        <br /><br /><br /><br />

