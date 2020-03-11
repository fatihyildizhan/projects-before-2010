<%@ Page Title="" Language="C#" MasterPageFile="~/sayfalar/yonetici/yoneticiPaneli.master" AutoEventWireup="true" CodeFile="emlakEkle_Fotograf.aspx.cs" Inherits="sayfalar_yonetici_emlakEkle_Fotograf" %>

<%@ Register src="../yoneticiWuc/emlakEkle_Fotograf.ascx" tagname="emlakEkle_Fotograf" tagprefix="uc1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <uc1:emlakEkle_Fotograf ID="emlakEkle_Fotograf1" runat="server" />
</asp:Content>

