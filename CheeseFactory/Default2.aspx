<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default2.aspx.cs" Inherits="Default2" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">

        .style1
        {
            width: 102%;
        }
    </style>
    <script type="text/javascript">
       
        function KAPAT() {
            document.getElementById("form1").style.visibility = "hidden";
        }
    </script>
</head>
<body>
    <form id="form1" runat="server">
    <div style="width: 530px" onclick="KAPAT()">
                 <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" 
                    CellPadding="4" ForeColor="#333333" AllowPaging="True" PageSize="1" 
                     Width="528px">
                    <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
                    <Columns>
                        <asp:TemplateField HeaderText="Ürün Görünümü">
                            <ItemTemplate>
                                <table class="style1">
                                    <tr>
                                        <td>
                                            <asp:Image ID="Image2" runat="server" AlternateText='<%# Bind("KategoriAd") %>' 
                                                ImageUrl='<%# Bind("Resim") %>' />
                                        </td>
                                    </tr>
                                </table>
                                <table>
                                </table>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Ürün Bilgileri">
                            <ItemTemplate>
                                <table class="style1">
                                    <tr>
                                        <td>
                                            Adet Ağırlığı:</td>
                                        <td>
                                            <asp:Label ID="Label1" runat="server" Text='<%# Bind("AdetAgirligi") %>'></asp:Label>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>
                                            Koli İçi Adedi:</td>
                                        <td>
                                            <asp:Label ID="Label2" runat="server" Text='<%# Bind("KoliIciAdedi") %>'></asp:Label>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>
                                            Ambalaj Tipi:</td>
                                        <td>
                                            <asp:Label ID="Label3" runat="server" Text='<%# Bind("AmbalajTipi") %>'></asp:Label>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>
                                            Ambalaj Ağırlığı:</td>
                                        <td>
                                            <asp:Label ID="Label4" runat="server" Text='<%# Bind("AmbalajAgirligi") %>'></asp:Label>
                                        </td>
                                    </tr>
                                </table>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Besin Öğeleri">
                            <ItemTemplate>
                                <table class="style1">
                                    <tr>
                                        <td>
                                            Gramaj (gr):</td>
                                        <td>
                                            <asp:Label ID="Label5" runat="server" Text='<%# Bind("KacGramIcin") %>'></asp:Label>
                                            </td>
                                    </tr>
                                    <tr>
                                        <td>
                                            Enerji (kcal) :</td>
                                        <td>
                                            <asp:Label ID="Label6" runat="server" Text='<%# Bind("Enerji") %>'></asp:Label>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>
                                            Protein (gram) :</td>
                                        <td>
                                            <asp:Label ID="Label7" runat="server" Text='<%# Bind("Protein") %>'></asp:Label>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>
                                            Yağ (gram) :</td>
                                        <td>
                                            <asp:Label ID="Label8" runat="server" Text='<%# Bind("Yag") %>'></asp:Label>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>
                                            Tuz (gram) :</td>
                                        <td>
                                            <asp:Label ID="Label9" runat="server" Text='<%# Bind("Tuz") %>'></asp:Label>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>
                                            Kalsiyum (mg) :</td>
                                        <td>
                                            <asp:Label ID="Label10" runat="server" Text='<%# Bind("Kalsiyum") %>'></asp:Label>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>
                                            Kolestrol (mg)</td>
                                        <td>
                                            <asp:Label ID="Label11" runat="server" Text='<%# Bind("Kolestrol") %>'></asp:Label>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>
                                            Fosfor (mg)</td>
                                        <td>
                                            <asp:Label ID="Label12" runat="server" Text='<%# Bind("Fosfor") %>'></asp:Label>
                                        </td>
                                    </tr>
                                </table>
                            </ItemTemplate>
                        </asp:TemplateField>
                    </Columns>
                    <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                    <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
                    <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
                    <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                    <EditRowStyle BackColor="#999999" />
                    <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
                </asp:GridView>
    
    </div>
    </form>
</body>
</html>
