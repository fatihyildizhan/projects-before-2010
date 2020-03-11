<%@ Page Title="" Language="C#" MasterPageFile="~/sayfalar/yonetici/yoneticiPaneli.master" AutoEventWireup="true" CodeFile="emlakEkle_Fiyat.aspx.cs" Inherits="sayfalar_yonetici_emlakEkle_Fiyat" %>

<%@ Register src="../yoneticiWuc/emlakEkle_Fiyat.ascx" tagname="emlakEkle_Fiyat" tagprefix="uc1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <uc1:emlakEkle_Fiyat ID="emlakEkle_Fiyat1" runat="server" />
</asp:Content>

