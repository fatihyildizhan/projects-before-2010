<%@ Page Title="" Language="C#" MasterPageFile="~/Management/MasterPageManagementPanel.master" AutoEventWireup="true" CodeFile="manageUsers.aspx.cs" Inherits="Management_manageUsers" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .style7
        {
            width: 100%;
        }
        .style8
        {
            width: 44px;
            height: 22px;
        }
        
        .style9
        {
            width: 123px;
        }
        
        .style10
        {
            height: 22px;
        }
        
    </style>
</asp:Content>
<asp:Content ID="Content2" runat="server" contentplaceholderid="ContentPlaceHolder1">
<div>
    <asp:Image ID="Image1" runat="server" Height="273px" 
        ImageUrl="~/img/delete_pc.jpg" Visible="False" Width="295px" />
<br />
    <table  class="style9">
        <tr>
            <td>
                <asp:Label ID="lblAktifAd" runat="server" Text="Aktiflik    Kullanýcý Adý"></asp:Label>
            </td>
        </tr>
    </table><asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" 
        CellPadding="4" ForeColor="#333333" GridLines="None" Width="451px">
        <RowStyle BackColor="#E3EAEB" />
        <Columns>
            <asp:TemplateField>
                <ItemTemplate>
                    <table class="style7">
                        <tr>
                            <td class="style8">
                                <asp:CheckBox ID="cb" runat="server" Checked='<%# Bind("IsApproved") %>' />
                            </td>
                            <td class="style10">
                                <asp:Label ID="lblKullaniciAd" runat="server" Text='<%# Bind("UserName") %>'></asp:Label>
                            </td>
                            <td class="style10">
                                <asp:LinkButton ID="lbKullaniciYonet" runat="server" 
                                    CommandArgument='<%# Bind("UserName") %>' 
                                    oncommand="lbKullaniciYonet_Command">Kullanýcý Yönet</asp:LinkButton>
                            </td>
                            <td class="style10">
                                <asp:LinkButton ID="lbKullaniciSil" runat="server" 
                                    CommandArgument='<%# Bind("UserName") %>' oncommand="lbKullaniciSil_Command">Kullanýcý Sil</asp:LinkButton>
                            </td>
                        </tr>
                    </table>
                </ItemTemplate>
            </asp:TemplateField>
        </Columns>
        <FooterStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
        <PagerStyle BackColor="#666666" ForeColor="White" HorizontalAlign="Center" />
        <SelectedRowStyle BackColor="#C5BBAF" Font-Bold="True" ForeColor="#333333" />
        <HeaderStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
        <EditRowStyle BackColor="#7C6F57" />
        <AlternatingRowStyle BackColor="White" />
    </asp:GridView>
    <asp:LinkButton ID="lbKullaniciSilOnay" runat="server" 
         Visible="False" onclick="lbKullaniciSilOnay_Click">Kullanýcýyý Sil</asp:LinkButton>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:LinkButton ID="lbIptal" runat="server" Visible="False" 
        onclick="lbIptal_Click">Ýptal</asp:LinkButton>
    <br />
    <br />
</div>
</asp:Content>


