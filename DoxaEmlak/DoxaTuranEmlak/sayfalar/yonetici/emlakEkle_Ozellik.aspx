<%@ Page Title="" Language="C#" MasterPageFile="~/sayfalar/yonetici/yoneticiPaneli.master" AutoEventWireup="true" CodeFile="emlakEkle_Ozellik.aspx.cs" Inherits="sayfalar_yonetici_emlakEkle_Ozellik" %>

<%@ Register src="../yoneticiWuc/emlakEkle_Ozellik.ascx" tagname="emlakEkle_Ozellik" tagprefix="uc1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    
    <uc1:emlakEkle_Ozellik ID="emlakEkle_Ozellik1" runat="server" />
    
</asp:Content>

