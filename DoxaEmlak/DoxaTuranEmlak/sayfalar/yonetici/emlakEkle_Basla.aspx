<%@ Page Title="" Language="C#" MasterPageFile="~/sayfalar/yonetici/yoneticiPaneli.master" AutoEventWireup="true" CodeFile="emlakEkle_Basla.aspx.cs" Inherits="sayfalar_yonetici_emlakEkle_Basla" %>


<%@ Register src="../yoneticiWuc/emlakEkle_Basla.ascx" tagname="emlakEkle_Basla" tagprefix="uc1" %>


<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    </asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <uc1:emlakEkle_Basla ID="emlakEkle_Basla1" runat="server" />
    </asp:Content>

