<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPageSayfalar.master" AutoEventWireup="true" CodeFile="cSharp.aspx.cs" Inherits="cSharp" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <link href="Makale.css" rel="stylesheet" type="text/css" />
    <style type="text/css">
        .style6
        {
            width: 100%;
        }
    </style>
</asp:Content>


<asp:Content ID="Content5" runat="server" 
    contentplaceholderid="ContentPlaceHolder4">

                         <div id="table">
                             <h1>
                                 <b>C# Nedir?</b></h1>
                             <table class="style6">
                                 <tr>
                                     <td>
                                         &nbsp;&nbsp;&nbsp; C# Programlama Dili, Microsoft tarafından geliştirilen bir web programlara 
                                         dilidir. C#, C++,C aynı zamanda özgür yazılım dili olan java ilede benzerlik 
                                         taşır. C# Object Oriented mimarisini de kullanmamıza olanak sağladıği için bir 
                                         çok web sitesinde birçok webmaster tarafından tercih edilmektedir. Yine C# 
                                         microsoft visual studio nunda bize kazandırdıkları ile web sitesi tasarlarken 
                                         vazgeçilmez bir programlama dilidir.&nbsp; <br />
                                         <br />
                                         NOT: Uygulamaları Çalıştırabilmeniz için Bilgisayarınızda Framework 3.5 Yüklü 
                                         Olmalıdır. Aksi takdirde sorun yaşayabilirsiniz. Uygulamaları exe dosyası ve 
                                         geliştirmek isteyenler için proje dosyasıyla birlikte upload ettim. Aklınıza 
                                         takılan bir konu veya tavsiye için iletişim bölümünü kullanabilrsiniz.<br />
&nbsp;*** Framework 3.5&#39;i download kısmından edinebilirsiniz...</td>
                                     <td>
                                         <asp:Image ID="Image1" runat="server" ImageUrl="~/img/CsharpLogo.jpg" />
                                     </td>
                                 </tr>
                             </table>
&nbsp;<br />
                         <hr />
                             <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" 
                                 onrowcommand="GridView1_RowCommand" Width="521px" AllowPaging="True" 
                                 PageSize="8" onpageindexchanging="GridView1_PageIndexChanging">
                                 <PagerSettings Position="TopAndBottom" />
                                 <Columns>
                                     <asp:TemplateField HeaderText="Makaleler">
                                         <ItemTemplate>
                                             <table>
                                                 <tr>
                                                     <td>
                                                         Makale Adı:</td>
                                                     <td>
                                                         <asp:LinkButton ID="LinkButton1" runat="server" 
                                                             CommandArgument='<%# Bind("MakaleId") %>' Text='<%# Bind("MakaleAd") %>' 
                                                             CommandName="detaygoster"></asp:LinkButton>
                                                     </td>
                                                 </tr>
                                                 <tr>
                                                     <td>
                                                         Özet:</td>
                                                     <td>
                                                         <asp:Label ID="Label7" runat="server" Text='<%# Bind("Ozet") %>'></asp:Label>
                                                     </td>
                                                 </tr>
                                             </table>
                                         </ItemTemplate>
                                         <HeaderStyle BackColor="#A0BE4C" />
                                     </asp:TemplateField>
                                     <asp:TemplateField HeaderText="Eklenme Tarihi">
                                         <ItemTemplate>
                                             <asp:Label ID="Label6" runat="server" Text='<%# Bind("EklemeTarihi") %>'></asp:Label>
                                         </ItemTemplate>
                                         <HeaderStyle BackColor="#A0BE4C" />
                                     </asp:TemplateField>
                                 </Columns>
                                 <FooterStyle BackColor="#A0BE4C" />
                             </asp:GridView>
                         <br />
                         </div>
</asp:Content>








