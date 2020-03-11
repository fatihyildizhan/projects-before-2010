<%@ Page Title="" Language="C#" MasterPageFile="~/sayfalar/yonetici/yoneticiPaneli.master"
    AutoEventWireup="true" CodeFile="emlakEkle_Adres.aspx.cs" Inherits="sayfalar_yonetici_emlakEkle_Adres" %>

<%@ Register src="../yoneticiWuc/emlakEkle_Adres.ascx" tagname="emlakEkle_Adres" tagprefix="uc1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <uc1:emlakEkle_Adres ID="emlakEkle_Adres1" runat="server" />
</asp:Content>
