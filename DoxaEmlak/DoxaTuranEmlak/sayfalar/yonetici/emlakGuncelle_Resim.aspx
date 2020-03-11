<%@ Page Language="C#" MasterPageFile="~/sayfalar/yonetici/yoneticiPaneli.master" AutoEventWireup="true" CodeFile="emlakGuncelle_Resim.aspx.cs" Inherits="sayfalar_yonetici_emlakGuncelle_Resim" Title="Untitled Page" %>

<%@ Register src="../yoneticiWuc/emlakGuncelle_Resim.ascx" tagname="emlakGuncelle_Resim" tagprefix="uc1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <uc1:emlakGuncelle_Resim ID="emlakGuncelle_Resim1" runat="server" />
</asp:Content>

