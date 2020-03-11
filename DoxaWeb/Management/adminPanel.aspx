<%@ Page Title="" Language="C#" MasterPageFile="~/Management/MasterPageManagementPanel.master" AutoEventWireup="true" CodeFile="adminPanel.aspx.cs" Inherits="Management_adminPanel" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" runat="server" 
    contentplaceholderid="ContentPlaceHolder1">
                                                
        
                             <asp:LinkButton ID="LinkButton1" runat="server" 
                                 PostBackUrl="~/Management/makaleIslemleri.aspx">Makale Ekle</asp:LinkButton>
                             <br />
                             <br />
                             <asp:LinkButton ID="LinkButton2" runat="server" 
                                 PostBackUrl="~/Management/security.aspx">Security</asp:LinkButton>
                             <br />
                             <br />
                             <asp:LinkButton ID="LinkButton3" runat="server" 
                                 PostBackUrl="~/Management/manageUsers.aspx">Manage users</asp:LinkButton>
                             <br />
    <asp:Button ID="Button1" runat="server" Text="IP GOSTER" 
    onclick="Button1_Click" /><br />
    <asp:Label ID="lbliP" runat="server" Text="Label"></asp:Label>
                             <br />                               
</asp:Content>


