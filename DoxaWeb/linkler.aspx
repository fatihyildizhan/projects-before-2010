<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPageSayfalar.master" AutoEventWireup="true" CodeFile="linkler.aspx.cs" Inherits="linkler" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .style6
        {
            font-style: italic;
            text-decoration: underline;
            font-size: medium;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" runat="server" 
    contentplaceholderid="ContentPlaceHolder4">
                         <div>
                             <br />
                             <span class="style6">YAPIM AŞAMASINDA...</span> Link paylaşımı yapmak isteyenler
                             <asp:LinkButton ID="LinkButton1" runat="server" PostBackUrl="~/iletisim.aspx">iletişim</asp:LinkButton>
&nbsp;bölümünden veya
                             <br />
                             <a href="mailto:info@fatihyildizhan.com">info@fatihyildizhan.com</a> e-posta 
                             adresinden iletişime geçebilirler.<br />
                             <br />
                             <asp:ImageButton ID="ImageButton2" runat="server" 
                                 ImageUrl="~/img/underConstruction.jpg" PostBackUrl="~/index.aspx" />
                             </div>
                      
</asp:Content>


