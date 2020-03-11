<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPageSayfalar.master" AutoEventWireup="true" CodeFile="rssGuncelleme.aspx.cs" Inherits="rss_rssGuncelleme" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content5" runat="server" 
    contentplaceholderid="ContentPlaceHolder3">
    <div class="right">
                        
                    </div>
                    

</asp:Content>
<asp:Content ID="Content6" runat="server" 
    contentplaceholderid="ContentPlaceHolder4">
    <div>
                             <asp:Button ID="btnJavaRSSGuncelle" runat="server" Font-Bold="True" 
                                 Font-Italic="True" Font-Size="Medium" Height="58px" 
                                 onclick="btnJavaRSSGuncelle_Click" Text="JAVA RSS GÜNCELLE" Width="203px" />
                             <asp:Button ID="btnCSharpRSSGuncelle" runat="server" Font-Bold="True" 
                                 Font-Italic="True" Font-Size="Medium" Height="58px" 
                                 onclick="btnCSharpRSSGuncelle_Click" Text="C# RSS GÜNCELLE" Width="203px" />
</div>
                      

</asp:Content>


