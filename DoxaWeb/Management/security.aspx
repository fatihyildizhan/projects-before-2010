<%@ Page Title="" Language="C#" MasterPageFile="~/Management/MasterPageManagementPanel.master" AutoEventWireup="true" CodeFile="security.aspx.cs" Inherits="Management_security" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .style7
        {
            width: 61%;
        }
        .style8
        {
            height: 15px;
            width: 181px;
        }
        .style9
        {
            height: 15px;
            width: 53px;
        }
        .style10
        {
            height: 15px;
            width: 92px;
        }
        .style11
        {
            width: 97px;
        }
        .style14
        {
            height: 15px;
            width: 66px;
        }
        .style15
        {
            height: 15px;
            width: 49px;
        }
        .style16
        {
            width: 181px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" runat="server" 

    contentplaceholderid="ContentPlaceHolder1">
                        <div>
                            <table class="style7">
                                <tr>
                                    <td colspan="2">
                                        KULLANICI AYARLARI</td>
                                    <td class="style11" colspan="2">
                                        ROL AYARLARI</td>
                                    <td class="style16">
                                        İZİN AYARLARI</td>
                                </tr>
                                <tr>
                                    <td class="style10">
                                        Toplam Kullanıcı:</td>
                                    <td class="style9">
                                        <asp:Label ID="lblTkS" runat="server"></asp:Label>
                                    </td>
                                    <td class="style14">
                                        Toplam Rol:</td>
                                    <td class="style15">
                                        <asp:Label ID="lblTrS" runat="server"></asp:Label>
                                    </td>
                                    <td class="style8">
                                        &nbsp;</td>
                                </tr>
                                <tr>
                                    <td colspan="2">
                                        <asp:Button ID="btnKullaniciOlustur" runat="server" Text="Bekleyen" 
                                            Width="85px" PostBackUrl="https://www.fatihyildizhan.com/createNewAccount.aspx" 
                                            onclick="btnKullaniciOlustur_Click" />
                                    </td>
                                    <td class="style11" colspan="2">
                                        <asp:Button ID="btnRolAcKapat" runat="server" Text="Aktif/Pasif" 
                                            onclick="btnRolAcKapat_Click" />
                                    </td>
                                    <td class="style16">
                                        <asp:Button ID="btnIzinEkle" runat="server" Text="İzin Ekle" />
                                    </td>
                                </tr>
                                <tr>
                                    <td colspan="2">
                                        <asp:Button ID="btnKullaniciYonet" runat="server" Text="K. Yönet" 
                                            Width="85px" />
                                    </td>
                                    <td class="style11" colspan="2">
                                        <asp:Button ID="btnRolYonet" runat="server" Text="Rol Yönet" 
                                            PostBackUrl="https://www.fatihyildizhan.com/Management/manageRoles.aspx" />
                                    </td>
                                    <td class="style16">
                                        <asp:Button ID="btnIzinYonet" runat="server" Text="İzin Yönet" />
                                    </td>
                                </tr>
                            </table>
                            <br />
                            <br />
                            <br />
                            <br />
                            <br />
                        </div>
                        
</asp:Content>



