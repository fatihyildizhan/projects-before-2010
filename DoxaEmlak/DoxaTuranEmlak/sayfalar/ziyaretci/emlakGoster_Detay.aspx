<%@ Page Language="C#" MasterPageFile="~/sayfalar/ziyaretci/ziyaretciPaneli.master" AutoEventWireup="true" CodeFile="emlakGoster_Detay.aspx.cs" Inherits="sayfalar_ziyaretci_emlakGoster_Detay" Title="Untitled Page" %>

<%@ Register src="../ziyaretciWuc/emlakGoster_Detay.ascx" tagname="emlakGoster_Detay" tagprefix="uc1" %>

<%@ Register src="../ziyaretciWuc/emlakGoster_Detay_Admin.ascx" tagname="emlakGoster_Detay_Admin" tagprefix="uc2" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">


    .style3
    {
        text-align: left;
    }
        .style2
    {
        height: 20px;
    }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <tr>
        <td style="text-align: left; vertical-align:top;">
        </td>
    </tr>
</asp:Content>

<asp:Content ID="Content4" runat="server" 
    contentplaceholderid="ContentPlaceHolder4">

                
    <uc2:emlakGoster_Detay_Admin ID="emlakGoster_Detay_Admin1" 
        runat="server" />

                
</asp:Content>


