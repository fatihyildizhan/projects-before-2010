<%@ Page Language="C#" AutoEventWireup="true" CodeFile="urunGosterFrame.aspx.cs" Inherits="urunGosterFrame" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script type="text/javascript">
        function urunDetay() {
            document.getElementById("divUrunDetayGoster").style.visibility = "visible";
            var id = document.getElementById("imgUrunDetay").title;
            document.getElementById("frameUrunDetayGoster").src = "Default2.aspx?urunumId="+id;
        }
        function KAPAT() {
            document.getElementById("divUrunDetayGoster").style.visibility = "hidden";
        }
    </script>
</head>
<body>
    <form id="form1" runat="server">
    <div style="margin-top:0px; top:0px;">
                         <asp:DataList ID="DataList1" runat="server" BackColor="#DEBA84" 
                             BorderColor="#DEBA84" BorderStyle="Solid" 
                             BorderWidth="1px" 
                             CellPadding="4" 
                             CellSpacing="5" 
                             DataKeyField="UrunId" 
                             GridLines="Both" 
                             HorizontalAlign="Center" 
                             RepeatColumns="3" 
                             RepeatDirection="Horizontal" 
                             ShowFooter="False" 
                             ShowHeader="False">
                             <FooterStyle BackColor="#F7DFB5" ForeColor="#8C4510" />
                             <ItemStyle BackColor="#FFF7E7" BorderStyle="Solid" BorderWidth="1px" 
                                 ForeColor="#8C4510" HorizontalAlign="Center" VerticalAlign="Middle" />
                             <SeparatorStyle BackColor="Olive" Font-Bold="False" Font-Italic="False" 
                                 Font-Names="AngsanaUPC" Font-Overline="False" Font-Size="Medium" 
                                 Font-Strikeout="False" Font-Underline="False" ForeColor="Fuchsia" 
                                 HorizontalAlign="Center" VerticalAlign="Middle" />
                             <SelectedItemStyle BackColor="#738A9C" Font-Bold="True" ForeColor="White" 
                                 HorizontalAlign="Center" VerticalAlign="Middle" />
                             <HeaderStyle BackColor="#A55129" Font-Bold="True" ForeColor="White" />
                             <ItemTemplate>
                                 <asp:Label ID="UrunAdLabel" runat="server" Text='<%# Eval("UrunAd") %>' />
                                 <br />
                                 <asp:Label ID="BaslikLabel" runat="server" Text='<%# Eval("Baslik") %>' />
                                 <br />
                                 <asp:Label ID="AciklamaLabel" runat="server" Text='<%# Eval("Aciklama") %>' />
                                 <br />
                                 <img id="imgUrunDetay" alt="peynir"
                                    src='<%# Eval("Resim") %>' 
                                    title='<%# Eval("UrunId") %>' 
                                    onclick="urunDetay()" 
                                    style="cursor:pointer;"  />
                             </ItemTemplate>
                         </asp:DataList>
       
    </div>
      <div id="divUrunDetayGoster" style="width:600px; height:258px; 
                                  position:absolute;
                                  background-color:inherit;
                                  
                                 visibility:hidden;
                                 top:10px;
                                 left:15%;">
         <iframe id="frameUrunDetayGoster" frameborder="0" scrolling="no" 
                             src="#" 
                             style="width:600px; height: 258px; margin-top:0px; top:0px;" align="top">
                             </iframe> 
    </div>
    </form>
</body>
</html>
