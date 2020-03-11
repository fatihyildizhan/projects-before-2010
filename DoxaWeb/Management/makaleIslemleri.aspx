<%@ Page Title="" Language="C#" MasterPageFile="~/Management/MasterPageManagementPanel.master" AutoEventWireup="true" CodeFile="makaleIslemleri.aspx.cs" Inherits="Management_makaleIslemleri" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .style7
        {
            width: 100%;
        }
        .style8
        {
            height: 52px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" runat="server" 
    contentplaceholderid="ContentPlaceHolder1">
                        <div class="navigationProfilim">
                            <a href="" title="profilim">Üye İşlemleri</a>
	                        <a href="" title="guncelle">Makale İşlemleri</a>&nbsp;&nbsp;&nbsp;&nbsp;
                            <br />
                            <br />
                            <br />
                            <br />
                            <br />
                            <table class="style7">
                                <tr>
                                    <td>
                                        Konu Adı:</td>
                                    <td>
                                        <asp:DropDownList ID="ddlKonuAd" runat="server">
                                        </asp:DropDownList>
                                        <br />
                                        <asp:TextBox ID="txtKonuId" runat="server"></asp:TextBox>
                                    </td>
                                </tr>
                                <tr>
                                    <td>
                                        Yazar Adı :</td>
                                    <td>
                                        <asp:TextBox ID="txtYazar" runat="server"></asp:TextBox>
                                    </td>
                                </tr>
                                <tr>
                                    <td>
                                        Makale Adı:</td>
                                    <td>
                                        <asp:TextBox ID="txtMakaleAd" runat="server"></asp:TextBox>
                                    </td>
                                </tr>
                                <tr>
                                    <td>
                                        Özet:</td>
                                    <td>
                                        <asp:TextBox ID="txtOzet" runat="server"></asp:TextBox>
                                    </td>
                                </tr>
                                <tr>
                                    <td>
                                        Aciklama:</td>
                                    <td>
                                        <asp:TextBox ID="txtAciklama" runat="server" TextMode="MultiLine"></asp:TextBox>
                                    </td>
                                </tr>
                                <tr>
                                    <td>
                                        Link:</td>
                                    <td>
                                        <asp:TextBox ID="txtLink" runat="server" Width="363px"></asp:TextBox>
                                    </td>
                                </tr>
                                <tr>
                                    <td class="style8">
                                        <asp:Button ID="btnMakaleEkle" runat="server" Height="50px" Text="MakaleEkle" 
                                            Width="96px" onclick="btnMakaleEkle_Click" />
                                    </td>
                                    <td class="style8">
                                        </td>
                                </tr>
                            </table>
                            <br />
                            <br />
                            <br />
                            <br />
                            <br />
                            <br />
                            <br />
                            <br />
                            <br />
                            <br />
                            <br />
                            <br />
                            <br />
                            <br />
                            <br />
                            <br />
                            <br />
                            <br />
                            <br />
                            <br />
                            <br />
                        </div>
                        
                    

</asp:Content>


