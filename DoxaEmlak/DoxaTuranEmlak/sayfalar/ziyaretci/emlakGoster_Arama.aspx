<%@ Page Language="C#" MasterPageFile="~/sayfalar/ziyaretci/ziyaretciPaneli.master" AutoEventWireup="true" CodeFile="emlakGoster_Arama.aspx.cs" Inherits="sayfalar_ziyaretci_emlakGoster_Arama" Title="Untitled Page" %>

<%@ Register src="../ziyaretciWuc/emlakARA_Dinamik.ascx" tagname="emlakARA_Dinamik" tagprefix="uc1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <tr>
        <td>
            <uc1:emlakARA_Dinamik ID="emlakARA_Dinamik1" runat="server" />
        </td>
    </tr>
</asp:Content>

