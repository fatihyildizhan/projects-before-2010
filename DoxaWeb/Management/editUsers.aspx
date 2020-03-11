<%@ Page Title="" Language="C#" MasterPageFile="~/Management/MasterPageManagementPanel.master" AutoEventWireup="true" CodeFile="editUsers.aspx.cs" Inherits="Management_editUsers" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .style7
        {
            width: 41%;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" runat="server" contentplaceholderid="ContentPlaceHolder1">
<div>
                                                <table class="style7">
                                                    <tr>
                                                        <td>
                                                            Kullanıcı Adı:</td>
                                                        <td>
                                                            <asp:TextBox ID="txtKullaniciAd" runat="server" ReadOnly="True" Width="140px"></asp:TextBox>
                                                        </td>
                                                    </tr>
                                                    <tr>
                                                        <td>
                                                            E-Posta:</td>
                                                        <td>
                                                        <asp:TextBox ID="txtEposta" runat="server" Width="140px" 
                                                            Text='<%# Bind("Email") %>'></asp:TextBox>
                                                        </td>
                                                    </tr>
                                                    <tr>
                                                        <td>
                                                            Açıklama:</td>
                                                        <td>
                                                            <asp:TextBox ID="txtAciklama" runat="server" Width="140px"></asp:TextBox>
                                                        </td>
                                                    </tr>
                                                    <tr>
                                                        <td>
                                                            Aktiflik:</td>
                                                        <td>
                                                            <asp:CheckBox ID="chkAktiflik" runat="server" />
                                                        </td>
                                                    </tr>
                                                    <tr>
                                                        <td>
                                                            Rol:</td>
                                                        <td>
                                                            <asp:DropDownList ID="ddlRoller" runat="server">
                                                            </asp:DropDownList>
                                                        </td>
                                                    </tr>
                                                    <tr>
                                                        <td>
                                                        <asp:Button ID="btnGuncelle" runat="server" Text="Güncelle" Width="77px" 
                                                            onclick="btnGuncelle_Click" />
                                                        </td>
                                                        <td>
                                                            &nbsp;</td>
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
</div>
</asp:Content>




