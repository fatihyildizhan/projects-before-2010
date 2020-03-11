<%@ Control Language="C#" AutoEventWireup="true" CodeFile="RSSreader.ascx.cs" Inherits="RSSreader" %>
<style type="text/css">


* {
	margin: 0;
	padding: 0;
	text-align: left;
}

    * {
	margin: 0;
	padding: 0;
	text-align: left;
}

a {color: #963;}
</style>
<asp:GridView ID="GridView2" runat="server" AllowPaging="True" 
    AutoGenerateColumns="False" CellPadding="4" 
    onpageindexchanging="GridView2_PageIndexChanging" Width="520px" CaptionAlign="Top" 
                          Font-Bold="False" Font-Names="Trebuchet MS" HorizontalAlign="Center" 
                          GridLines="Horizontal" BackColor="White" BorderColor="#336666" 
                          BorderStyle="Double" BorderWidth="3px" PageSize="3" 
    Visible="False">
    <FooterStyle BackColor="White" ForeColor="#333333" />
    <RowStyle BackColor="White" ForeColor="#333333" />
    <Columns>
        <asp:TemplateField HeaderText="RSS OKUYUCU">
            <ItemTemplate>
                <asp:LinkButton ID="LinkButton2" runat="server" 
                    PostBackUrl='<%# Bind("NTVlink") %>' Text='<%# Bind("NTVtitle") %>' 
                    Font-Bold="True" ForeColor="#77933D"></asp:LinkButton>
                    <br />
                &nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Label ID="Label3" runat="server" Text='<%# Bind("NTVdescription") %>'></asp:Label>
                <hr />
            </ItemTemplate>
            <HeaderStyle HorizontalAlign="Center" VerticalAlign="Middle" />
        </asp:TemplateField>
    </Columns>
    <PagerStyle BackColor="#336666" ForeColor="White" HorizontalAlign="Center" />
    <SelectedRowStyle BackColor="#339966" Font-Bold="True" ForeColor="White" />
    <HeaderStyle BackColor="#336666" Font-Bold="True" ForeColor="White" />
</asp:GridView>
<asp:GridView ID="GridView1" runat="server" AllowPaging="True" 
    AutoGenerateColumns="False" CellPadding="4" onpageindexchanging="GridView1_PageIndexChanging" 
    onrowdatabound="GridView1_RowDataBound" Width="520px" CaptionAlign="Top" 
                          Font-Bold="False" Font-Names="Trebuchet MS" HorizontalAlign="Center" 
                          GridLines="Horizontal" BackColor="White" BorderColor="#336666" 
                          BorderStyle="Double" BorderWidth="3px" PageSize="7">
    <FooterStyle BackColor="White" ForeColor="#333333" />
    <RowStyle BackColor="White" ForeColor="#333333" />
    <Columns>
        <asp:TemplateField HeaderText="RSS OKUYUCU">
            <ItemTemplate>
                <asp:LinkButton ID="LinkButton1" runat="server" 
                    PostBackUrl='<%# Bind("HURRIYETlink") %>' Text='<%# Bind("HURRIYETtitle") %>' 
                    Font-Bold="True" ForeColor="#77933D"></asp:LinkButton>
                    <br />
                &nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Label ID="Label2" runat="server" Text='<%# Bind("HURRIYETdescription") %>'></asp:Label>
                <hr />
                <br />
            </ItemTemplate>
            <HeaderStyle HorizontalAlign="Center" VerticalAlign="Middle" />
        </asp:TemplateField>
    </Columns>
    <PagerStyle BackColor="#336666" ForeColor="White" HorizontalAlign="Center" />
    <SelectedRowStyle BackColor="#339966" Font-Bold="True" ForeColor="White" />
    <HeaderStyle BackColor="#336666" Font-Bold="True" ForeColor="White" />
</asp:GridView>
<asp:GridView ID="GridView3" runat="server" AllowPaging="True" 
    AutoGenerateColumns="False" CellPadding="4" onpageindexchanging="GridView3_PageIndexChanging" 
    onrowdatabound="GridView3_RowDataBound" Width="520px" CaptionAlign="Top" 
                          Font-Bold="False" Font-Names="Trebuchet MS" HorizontalAlign="Center" 
                          GridLines="Horizontal" BackColor="White" BorderColor="#336666" 
                          BorderStyle="Double" BorderWidth="3px" PageSize="7" 
    Visible="False">
    <FooterStyle BackColor="White" ForeColor="#333333" />
    <RowStyle BackColor="White" ForeColor="#333333" />
    <Columns>
        <asp:TemplateField HeaderText="RSS OKUYUCU">
            <ItemTemplate>
                <asp:LinkButton ID="LinkButton3" runat="server" 
                    PostBackUrl='<%# Bind("EKOLAYlink") %>' Text='<%# Bind("EKOLAYtitle") %>' 
                    Font-Bold="True" ForeColor="#77933D"></asp:LinkButton>
                    <br />
                &nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Label ID="Label4" runat="server" Text='<%# Bind("EKOLAYdescription") %>'></asp:Label>
                <hr />
                <br />
            </ItemTemplate>
            <HeaderStyle HorizontalAlign="Center" VerticalAlign="Middle" />
        </asp:TemplateField>
    </Columns>
    <PagerStyle BackColor="#336666" ForeColor="White" HorizontalAlign="Center" />
    <SelectedRowStyle BackColor="#339966" Font-Bold="True" ForeColor="White" />
    <HeaderStyle BackColor="#336666" Font-Bold="True" ForeColor="White" />
</asp:GridView>
	                  