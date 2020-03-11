<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPageSayfalar.master" AutoEventWireup="true" CodeFile="java.aspx.cs" Inherits="java" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <link href="Makale.css" rel="stylesheet" type="text/css" />
</asp:Content>
<asp:Content ID="Content6" runat="server" 
    contentplaceholderid="ContentPlaceHolder4">
                         
                      
    <div id="table">
        <table>
            <tr>
                <td>
                    <h1>
                                             Java nedir?</h1>
                </td>
                <td rowspan="2">
                                         &nbsp;<asp:Image ID="Image1" runat="server" Height="173px" 
                                             ImageUrl="~/img/java.gif" />
                </td>
            </tr>
            <tr>
                <td>
                                             Java yazılımı birçok olanağı bizlere sunar. Java sayesinde cep telefonlarında 
                                             java oyunları oynayabilir, internette birçok java destekli oyunlar bulabiliriz. 
                                             Bunun yanısıra java ile yazılmış birçok program bulmakta mümkündür.<br />Java dilinde yazılım geliştirmek için IDE ye
                                         ihtiyacınız vardır. Yaygın olarak kullanılan IDE
                                         lerden birisi Eclipse Diğeri ise NetBeans dir.<br />
                                             <br />
                                             NOT: Uygulamaları bilgisayarında java ve herhangi java destekleyen bir IDE ile 
                                             çalıştırabilirsiniz. Ayrıca sadece incelemek için notepad ile açabilirsiniz.Bir 
                                             sorun durumunda veya tavsiye için iletişim bölümünü kullanabilirsiniz.<br />
&nbsp;*** Gerekli linkleri 
                                             <asp:LinkButton ID="LinkButton2" runat="server" 
                                                 PostBackUrl="~/User/download.aspx" Width="60px">Download</asp:LinkButton>
&nbsp;bölümünden edinebilirsiniz...<br />
                </td>
            </tr>
        </table>
        <br />
        <hr />
        <asp:GridView ID="GridView1" runat="server" AllowPaging="True" 
            AutoGenerateColumns="False" 
            onrowcommand="GridView1_RowCommand" PageSize="8" Width="513px" 
            onpageindexchanging="GridView1_PageIndexChanging">
            <Columns>
                <asp:TemplateField HeaderText="Uygulamalar">
                    <ItemTemplate>
                        <table>
                            <tr>
                                <td>
                                    Makale Adı:</td>
                                <td>
                                    <asp:LinkButton ID="LinkButton1" runat="server" 
                                        CommandArgument='<%# Eval("MakaleId") %>' CommandName="detaygoster" 
                                        Text='<%# Eval("MakaleAd") %>'></asp:LinkButton>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    Özet:</td>
                                <td>
                                    <asp:Label ID="Label7" runat="server" Text='<%# Eval("Ozet") %>'></asp:Label>
                                </td>
                            </tr>
                        </table>
                    </ItemTemplate>
                    <HeaderStyle BackColor="#A0B480" />
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Eklenme Tarihi">
                    <ItemTemplate>
                        <asp:Label ID="Label8" runat="server" Text='<%# Eval("EklemeTarihi") %>'></asp:Label>
                    </ItemTemplate>
                    <HeaderStyle BackColor="#A0B480" />
                </asp:TemplateField>
            </Columns>
        </asp:GridView>
        <br />
        <br />
    </div>
                         
                      
</asp:Content>


