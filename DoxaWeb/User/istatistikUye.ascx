<%@ Control Language="C#" AutoEventWireup="true" CodeFile="istatistikUye.ascx.cs" Inherits="istatistik" %>
<style type="text/css">

* {
	margin: 0;
	padding: 0;
	text-align: left;
}
    .style5
    {
        width: 147px;
    }
    </style>
                      <div>
                        <table font-family: 'Times New Roman'>
                          <tr>
                              <td class="style5">
                                  Toplam Hit :</td>
                              <td>
                                  <asp:Label ID="lblToplamHit" runat="server"></asp:Label>
                              </td>
                          </tr>
                          <tr>
                              <td class="style5">
                                                                    Online Üye :</td>
                              <td>
                                  <asp:Label ID="lblOnlineUye" runat="server"></asp:Label>
                              </td>
                          </tr>
                          <tr>
                              <td class="style5">
                                  Online Misafir :</td>
                              <td>
                                  <asp:Label ID="lblOnlineMisafir" runat="server"></asp:Label>
                              </td>
                          </tr>
                          <tr>
                              <td class="style5">
                                  Son Üye :</td>
                              <td>
                                  <asp:Label ID="lblSonUye" runat="server"></asp:Label>
                              </td>
                          </tr>
                          <tr>
                              <td class="style5">
                                                                    Üye Sayısı :</td>
                              <td>
                                  <asp:Label ID="lblUyeSayisi" runat="server"></asp:Label>
                              </td>
                          </tr>
                          <tr>
                              <td class="style5">
                                  Konu Sayısı :</td>
                              <td>
                                  <asp:Label ID="lblKonuSayisi" runat="server"></asp:Label>
                              </td>
                          </tr>
                          <tr>
                              <td class="style5">
                                                                    RSS Yayınlanan:</td>
                              <td>
                                  <asp:Label ID="lblrssSayisi" runat="server" Text="2"></asp:Label>
                              </td>
                          </tr>
                          <tr>
                              <td class="style5">
                                                                    RSS Okunan:</td>
                              <td>
                                  <asp:Label ID="lblHaberRSS" runat="server" Text="38"></asp:Label>
                              </td>
                          </tr>
                      </table>
                    </div>
                    
