<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPageSayfalar.master" AutoEventWireup="true" CodeFile="programlar.aspx.cs" Inherits="programlar" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content4" runat="server" 
    contentplaceholderid="ContentPlaceHolder3">
                      <div class="right">
                        <table font-family: 'times New Roman'>
                          <tr>
                              <td class="style5">
                                  <asp:Label ID="Label1" runat="server" Text="Toplam Hit"></asp:Label>
                              </td>
                              <td>
                                  <asp:Label ID="lblToplamHit" runat="server"></asp:Label>
                              </td>
                          </tr>
                          <tr>
                              <td class="style5">
                                  <asp:Label ID="Label2" runat="server" Text="Online Üye"></asp:Label>
                              </td>
                              <td>
                                  <asp:Label ID="lblOnlineUye" runat="server"></asp:Label>
                              </td>
                          </tr>
                          <tr>
                              <td class="style5">
                                  <asp:Label ID="Label3" runat="server" Text="Online Misafir"></asp:Label>
                              </td>
                              <td>
                                  <asp:Label ID="lblOnlineMisafir" runat="server"></asp:Label>
                              </td>
                          </tr>
                          <tr>
                              <td class="style5">
                                  <asp:Label ID="Label4" runat="server" Text="Son Üye"></asp:Label>
                              </td>
                              <td>
                                  <asp:Label ID="lblSonUye" runat="server"></asp:Label>
                              </td>
                          </tr>
                          <tr>
                              <td class="style5">
                                  <asp:Label ID="lblsayiUye" runat="server" Text="Üye Sayısı"></asp:Label>
                              </td>
                              <td>
                                  <asp:Label ID="lblUyeSayisi" runat="server"></asp:Label>
                              </td>
                          </tr>
                      </table>
                    </div>
                    
</asp:Content>


<asp:Content ID="Content5" runat="server" 
    contentplaceholderid="ContentPlaceHolder4">

                         <div>programlar<br />
                             önemlidir :D<br />
    </div>
                      
</asp:Content>



