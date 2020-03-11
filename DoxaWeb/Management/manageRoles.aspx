<%@ Page Title="" Language="C#" MasterPageFile="~/Management/MasterPageManagementPanel.master" AutoEventWireup="true" CodeFile="manageRoles.aspx.cs" Inherits="Management_manageRoles" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .style7
        {
            width: 40%;
        }
        
        
    </style>
</asp:Content>
<asp:Content ID="Content2" runat="server" contentplaceholderid="ContentPlaceHolder1">
<div>

    <table class="style7">
        <tr>
            <td>
                <asp:TextBox ID="txtRolAd" runat="server"></asp:TextBox>
            </td>
            <td>
                <asp:Button ID="btnRolEkle" runat="server" Text="Rol Ekle" 
                    onclick="btnRolEkle_Click" Width="107px" />
            </td>
        </tr>
    </table>
    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" 
        CellPadding="4" ForeColor="#333333" GridLines="None" 
        onrowcommand="GridView1_RowCommand" Width="365px">
        <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
        <Columns>
            <asp:BoundField DataField="Bind(&quot;RoleName&quot;)" HeaderText="Rol Adı" 
                ReadOnly="True" SortExpression="Bind(&quot;RoleName&quot;)" />
            <asp:TemplateField HeaderText="Rolleri Yönet">
                <ItemTemplate>
                    <asp:HyperLink ID="HyperLink1" runat="server" Text="Yönet"></asp:HyperLink>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:HyperLinkField Text="Sil" />
        </Columns>
        <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
        <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
        <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
        <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
        <EditRowStyle BackColor="#999999" />
        <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
    </asp:GridView>
</div>

</asp:Content>


