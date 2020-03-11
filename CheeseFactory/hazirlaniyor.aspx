<%@ Page Language="C#" AutoEventWireup="true" CodeFile="hazirlaniyor.aspx.cs" Inherits="hazirlaniyor" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    
    <style type="text/css">
        .image
    {
    	 height:490px;
    	 position:absolute;
    	 width:430px;
    	 padding-left:340px;
    	 padding-top:30px;
            top: 15px;
            left: 10px;
        
        }
      .zemin
      {
      	background-image:url(images/zemin.gif);
      	width:400px;
      	height:600px;
      	 padding-left:300px;
      	
      	}
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div class="zemin">
    
        <asp:Image ID="Image1" runat="server" CssClass="image" ImageUrl="~/images/1[2].jpg" />
        <br />
        <pre style="padding-top:500px; padding-left:440px; font-size:x-large;">YAPIM AŞAMASINDA</pre> 
    </div>
    </form>
</body>
</html>
