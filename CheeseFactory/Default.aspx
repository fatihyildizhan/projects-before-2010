<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="cc1" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    
    <script language="C#" runat="server">

      void ImageButton_Command(object sender, CommandEventArgs e) 
      {
      }
   </script>
     <script type="text/javascript">
       
         function fnc(id) 
         {
             document.getElementById("frm1").src = "Default2.aspx?urunumId=" + id;
             document.getElementById("discerceve").style.visibility = "visible";
         }
    </script>
    
    <script type="text/javascript">
    
    function AC()
    {
        document.getElementById("discerceve").style.visibility = "visible"; 
     }
    
     function KAPAT()
    {
        document.getElementById("discerceve").style.visibility="hidden"; 
    }
    </script>
    <style type="text/css">

    .style1
    {
        width: 39px;
    }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:ScriptManager ID="ScriptManager1" runat="server">
        </asp:ScriptManager>
    
        <br />
        <asp:UpdatePanel ID="UpdatePanel1" runat="server">
            <ContentTemplate>
                <asp:DataList ID="DataList1" runat="server" BackColor="#DEBA84" 
            BorderColor="#DEBA84" BorderStyle="Solid" BorderWidth="1px" CellPadding="4" 
            CellSpacing="5" DataKeyField="UrunId" DataSourceID="SqlDataSource1" GridLines="Both" 
            RepeatDirection="Horizontal" HorizontalAlign="Center" RepeatColumns="4" 
                    CaptionAlign="Bottom" ShowFooter="False" ShowHeader="False">
                    <FooterStyle BackColor="#F7DFB5" ForeColor="#8C4510" />
                    <ItemStyle BackColor="#FFF7E7" HorizontalAlign="Center" 
                VerticalAlign="Middle" ForeColor="#8C4510" BorderStyle="Solid" BorderWidth="1px" />
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
                        <asp:ImageButton 
                        ID="ImageButton1" 
                        runat="server" 
                        style="cursor:pointer"
                        ImageUrl='<%# Eval("Resim") %>' 
                        ImageAlign="AbsMiddle"
                        OnCommand="ImageButton_Command"
                        CommandName='<%# Eval("UrunId") %>' />
                    </ItemTemplate>
                </asp:DataList>
                <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
            ConnectionString="Data Source=.;Initial Catalog=Takisoglu;Persist Security Info=True;User ID=sa;Password=123" 
            ProviderName="System.Data.SqlClient" 
    SelectCommand="SELECT * FROM [Urun] WHERE ([UrunId] &lt; @UrunId)">
                    <SelectParameters>
                        <asp:Parameter DefaultValue="38" Name="UrunId" Type="Int32" />
                    </SelectParameters>
                </asp:SqlDataSource>
            </ContentTemplate>
        </asp:UpdatePanel>
        <br />
                         <asp:GridView ID="GridView1" runat="server" AllowPaging="True" 
                             AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333" 
                             GridLines="Horizontal" onpageindexchanging="GridView1_PageIndexChanging" 
                             onrowcommand="GridView1_RowCommand" PageSize="3" Width="476px" 
                             Visible="False">
                             <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
                             <Columns>
                                 <asp:TemplateField HeaderText="Ürün Görünümü">
                                     <ItemTemplate>
                                         <table>
                                             <tr>
                                                 <td class="style1">
                                                     <asp:Image ID="Image1" runat="server" ImageUrl='<%# Bind("Resim") %>' />
                                                 </td>
                                             </tr>
                                         </table>
                                     </ItemTemplate>
                                 </asp:TemplateField>
                                 <asp:TemplateField HeaderText="Ürün Bilgileri">
                                     <ItemTemplate>
                                         <table>
                                             <tr>
                                                 <td>
                                                     <asp:LinkButton ID="LinkButton1" runat="server" 
                                                         CommandArgument='<%# Bind("UrunId") %>' CommandName="urundetaygor" 
                                                         Text='<%# Bind("UrunAd") %>'></asp:LinkButton>
                                                 </td>
                                             </tr>
                                             <tr>
                                                 <td>
                                                     <asp:Label ID="Label2" runat="server" Text='<%# Bind("Baslik") %>'></asp:Label>
                                                 </td>
                                             </tr>
                                             <tr>
                                                 <td>
                                                     <asp:Label ID="Label3" runat="server" Text='<%# Bind("Aciklama") %>'></asp:Label>
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
                                
        <asp:DataPager ID="DataPager1" runat="server">
        </asp:DataPager>
                                
        <br />
    
    </div>
     <div id="discerceve" 
        style="background-color:Transparent;width:550px; height:300px; position:absolute; 
        visibility:hidden;top:10px;left:20%;">
         <input id="Button2" type="button" value="button" onclick="KAPAT()" />
         <iframe id="frm1" src="#" 
                scrolling="no"  
                frameborder="0" 
                style="width:550px; height: 300px; top:10px;left:30%;"> 
         </iframe>
    </div>
    </form>
</body>
</html>
