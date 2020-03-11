<%@ Control Language="C#" AutoEventWireup="true" CodeFile="emlakEkle_Basla.ascx.cs" Inherits="sayfalar_yoneticiWuc_emlakEkle_Basla" %>
<style type="text/css">
    .style1
    {
        width: 75%;
    }
</style>
<table class="style1">
    <tr>
        <td colspan="2" style="text-align: center">
            <asp:Label ID="lblEmlakBaslik" runat="server" Text="Emlak Ekle"></asp:Label>
        </td>
    </tr>
    <tr>
        <td style="text-align: left">
            Kategori:</td>
        <td style="text-align: left">
            <asp:DropDownList ID="ddEmlakKategori" runat="server" Height="20px" 
                Width="144px">
            </asp:DropDownList>
        </td>
    </tr>
    <tr>
        <td style="text-align: left">
            Emlak Tipi:</td>
        <td>
            <asp:DropDownList ID="ddEmlakTipi" runat="server" Height="20px" Width="144px">
            </asp:DropDownList>
        </td>
    </tr>
    <tr>
        <td>
            Emlak Baslığı:</td>
        <td>
            <asp:TextBox ID="txtEmlakBaslik" runat="server" Width="291px"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" 
                ControlToValidate="txtEmlakBaslik" ErrorMessage="*" ValidationGroup="ekle"></asp:RequiredFieldValidator>
        </td>
    </tr>
    <tr>
        <td>
            Emlak Referans No:</td>
        <td>
            <asp:TextBox ID="txtEmlakReferansNo" runat="server" Width="127px">0</asp:TextBox>
            <asp:RegularExpressionValidator ID="RegularExpressionValidator10" 
                runat="server" ControlToValidate="txtEmlakReferansNo" ErrorMessage="!" 
                ValidationExpression="[0-9]*" ValidationGroup="ekle"></asp:RegularExpressionValidator>
        </td>
    </tr>
    <tr>
        <td>
            Emlak m2:</td>
        <td>
            <asp:TextBox ID="txtEmlakM2" runat="server" Width="127px">0</asp:TextBox>
            <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" 
                ControlToValidate="txtEmlakM2" ErrorMessage="!" ValidationExpression="[0-9]*" 
                ValidationGroup="ekle"></asp:RegularExpressionValidator>
        </td>
    </tr>
    <tr>
        <td>
            Oda Sayısı:</td>
        <td>
            <asp:TextBox ID="txtOdaSayisi" runat="server" Width="127px">0</asp:TextBox>
            <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" 
                ControlToValidate="txtOdaSayisi" ErrorMessage="!" ValidationExpression="[0-9]*" 
                ValidationGroup="ekle"></asp:RegularExpressionValidator>
        </td>
    </tr>
    <tr>
        <td>
            Banyo Sayısı:</td>
        <td>
            <asp:TextBox ID="txtBanyoSayisi" runat="server" Width="127px">0</asp:TextBox>
            <asp:RegularExpressionValidator ID="RegularExpressionValidator3" runat="server" 
                ControlToValidate="txtBanyoSayisi" ErrorMessage="!" 
                ValidationExpression="[0-9]*" ValidationGroup="ekle"></asp:RegularExpressionValidator>
        </td>
    </tr>
    <tr>
        <td>
            Balkon Sayısı:</td>
        <td>
            <asp:TextBox ID="txtBalkonSayisi" runat="server" Width="127px">0</asp:TextBox>
            <asp:RegularExpressionValidator ID="RegularExpressionValidator4" runat="server" 
                ControlToValidate="txtBalkonSayisi" ErrorMessage="!" 
                ValidationExpression="[0-9]*" ValidationGroup="ekle"></asp:RegularExpressionValidator>
        </td>
    </tr>
    <tr>
        <td>
            Bina Yaşı:</td>
        <td>
            <asp:TextBox ID="txtBinaYasi" runat="server" Width="127px">0</asp:TextBox>
            <asp:RegularExpressionValidator ID="RegularExpressionValidator5" runat="server" 
                ControlToValidate="txtBinaYasi" ErrorMessage="!" ValidationExpression="[0-9]*" 
                ValidationGroup="ekle"></asp:RegularExpressionValidator>
        </td>
    </tr>
    <tr>
        <td>
            Binadaki Kat Sayısı:</td>
        <td>
            <asp:TextBox ID="txtBinadakiKatSayisi" runat="server" Width="127px">0</asp:TextBox>
            <asp:RegularExpressionValidator ID="RegularExpressionValidator6" runat="server" 
                ControlToValidate="txtBinadakiKatSayisi" ErrorMessage="!" 
                ValidationExpression="[0-9]*" ValidationGroup="ekle"></asp:RegularExpressionValidator>
        </td>
    </tr>
    <tr>
        <td>
            Bulunduğu Kat:</td>
        <td>
            <asp:TextBox ID="txtBulunduguKat" runat="server" Width="127px">0</asp:TextBox>
            <asp:RegularExpressionValidator ID="RegularExpressionValidator7" runat="server" 
                ControlToValidate="txtBulunduguKat" ErrorMessage="!" 
                ValidationExpression="[0-9]*" ValidationGroup="ekle"></asp:RegularExpressionValidator>
        </td>
    </tr>
    <tr>
        <td>
            Isıtma Tipi:</td>
        <td>
            <asp:DropDownList ID="ddIsitmaTipi" runat="server" Height="20px" Width="144px">
            </asp:DropDownList>
        </td>
    </tr>
    <tr>
        <td>
            Krediye Uygun Mu?</td>
        <td>
            <asp:CheckBox ID="cbKrediyeUygunMu" runat="server" />
        </td>
    </tr>
    <tr>
        <td>
            Durumu:</td>
        <td>
            <asp:TextBox ID="txtDurumu" runat="server" Width="291px"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td>
            Tapu Durumu:</td>
        <td>
            <asp:TextBox ID="txtTapuDurumu" runat="server" Width="291px"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td>
            Emlak Açıklaması:</td>
        <td>
            <asp:TextBox ID="txtEmlakAciklamasi" runat="server" Height="115px" 
                TextMode="MultiLine" Width="290px"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td>
            Aidat:</td>
        <td>
            <asp:TextBox ID="txtAidat" runat="server" Width="127px">0</asp:TextBox>
            <asp:RegularExpressionValidator ID="RegularExpressionValidator8" runat="server" 
                ControlToValidate="txtAidat" ErrorMessage="!" ValidationExpression="[0-9]*" 
                ValidationGroup="ekle"></asp:RegularExpressionValidator>
        </td>
    </tr>
    <tr>
        <td>
            Deposit:</td>
        <td>
            <asp:TextBox ID="txtDeposit" runat="server" Width="127px">0</asp:TextBox>
            <asp:RegularExpressionValidator ID="RegularExpressionValidator9" runat="server" 
                ControlToValidate="txtDeposit" ErrorMessage="!" ValidationExpression="[0-9]*" 
                ValidationGroup="ekle"></asp:RegularExpressionValidator>
        </td>
    </tr>
    <tr>
        <td>
            <asp:Button ID="btnEmlakEkleBasla" runat="server" 
                onclick="btnEmlakEkleBasla_Click" Text="Emlak Ekle Adım 1" Width="132px" 
                ValidationGroup="ekle" />
        </td>
        <td>
            <asp:Label ID="lblSonuc" runat="server"></asp:Label>
        </td>
    </tr>
    <tr>
        <td>
            <asp:LinkButton ID="lbSonrakiAdim" runat="server" onclick="lbSonrakiAdim_Click">Sonraki Adım</asp:LinkButton>
        </td>
        <td>
            &nbsp;</td>
    </tr>
    <tr>
        <td>
            &nbsp;</td>
        <td>
            &nbsp;</td>
    </tr>
</table>
