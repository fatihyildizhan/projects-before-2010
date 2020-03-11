<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="emlakTipYonetWuc.ascx.cs" Inherits="BussinessLayer.sayfalar.yoneticiWuc.emlakTipYonetWuc" %>
<style type="text/css">
    .style1
    {
        width: 59%;
    }
    .style2
    {
    }
    .style3
    {
        width: 100%;
    }
</style>
<table class="style1">
    <tr>
        <td class="style2">
            Emlak Tipi :</td>
        <td>
            <asp:TextBox ID="txtEmlakTip" runat="server"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td class="style2">
            <asp:Button ID="btnEmlakTipEkle" runat="server" Height="28px" 
                onclick="btnEmlakTipEkle_Click" Text="Ekle" Width="78px" />
        </td>
        <td>
            <asp:Label ID="lblSonuc" runat="server"></asp:Label>
        </td>
    </tr>
    <tr>
        <td class="style2" colspan="2">
            &nbsp;</td>
    </tr>
    <tr>
        <td colspan="2" style="text-align: center">
            <asp:GridView ID="gridEmlakTip" runat="server" AutoGenerateColumns="False" 
                BackColor="White" BorderColor="#DEDFDE" BorderStyle="None" BorderWidth="1px" 
                CellPadding="4" ForeColor="Black" GridLines="Vertical" 
                onrowcommand="GridView1_RowCommand" Width="340px">
                <RowStyle BackColor="#F7F7DE" />
                <Columns>
                    <asp:TemplateField HeaderText="Emlak Tipi">
                        <ItemTemplate>
                            <asp:Label ID="lblEmlakTip" runat="server" Text='<%# bind("EmlakTipIsim") %>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Güncelle">
                        <ItemTemplate>
                            <asp:LinkButton ID="lbEmlakTipGuncelle" runat="server" 
                                CommandArgument='<%# bind("EmlakTipId") %>' CommandName="guncelle" 
                                Font-Underline="False" ForeColor="#009933">Güncelle</asp:LinkButton>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Sil">
                        <ItemTemplate>
                            <asp:LinkButton ID="lbEmlakTipSil" runat="server" 
                                CommandArgument='<%# bind("EmlakTipId") %>' CommandName="sil" 
                                Font-Underline="False" ForeColor="Red">Sil</asp:LinkButton>
                        </ItemTemplate>
                    </asp:TemplateField>
                </Columns>
                <FooterStyle BackColor="#CCCC99" />
                <PagerStyle BackColor="#F7F7DE" ForeColor="Black" HorizontalAlign="Right" />
                <SelectedRowStyle BackColor="#CE5D5A" Font-Bold="True" ForeColor="White" />
                <HeaderStyle BackColor="#6B696B" Font-Bold="True" ForeColor="White" />
                <AlternatingRowStyle BackColor="White" />
            </asp:GridView>
        </td>
    </tr>
    <tr>
        <td colspan="2" style="text-align: center">
            <asp:Panel ID="pnlSil" runat="server" Visible="False">
                <asp:Label ID="Label1" runat="server" 
                    Text="Silmek istediğinizden emin misiniz?"></asp:Label>
                <br />
                <asp:LinkButton ID="lbEvet" runat="server" ForeColor="#009933" 
                    onclick="lbEvet_Click">Evet</asp:LinkButton>
                &nbsp;
                <asp:LinkButton ID="lbIptal" runat="server" ForeColor="Red" 
                    onclick="lbIptal_Click">İptal</asp:LinkButton>
            </asp:Panel>
        </td>
    </tr>
    <tr>
        <td colspan="2" style="text-align: center">
            <asp:Panel ID="pnlGuncelle" runat="server">
                <table class="style3">
                    <tr>
                        <td>
                            Emlak Tipi:</td>
                        <td>
                            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Button ID="Button1" runat="server" Text="Button" />
                        </td>
                        <td>
                            <asp:Button ID="Button3" runat="server" Text="Button" />
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Button ID="Button2" runat="server" Text="Button" />
                        </td>
                        <td>
                            &nbsp;</td>
                    </tr>
                </table>
            </asp:Panel>
        </td>
    </tr>
</table>
