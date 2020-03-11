<%@ Page Language="C#" AutoEventWireup="true" CodeFile="kalitePolitikamiz.aspx.cs" Inherits="kalitePolitikamiz" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script type="text/javascript">

        function resimAc() 
         {
             document.getElementById("imgPopup").src = "images/stfkB.jpg";
             document.getElementById("discerceve").style.visibility = "visible";
         }
         function KAPAT() 
         {
             document.getElementById("discerceve").style.visibility = "hidden";
         }
    </script>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <span>KALİTE POLİTİKAMIZ ve BELGELERİMİZ</span><br />
        <br />
        <span>Kalite Yönetim Sistemi</span><br />
        <span>Türkiye&#39;nin önde gelen süt ve süt ürünleri üreticisi olarak, 
        müşterilerimizin ve tedarikçilerimizin bize olan güveni ile dürüstlük ilkemizden 
        taviz vermeden, YÖRSAN adını gururla ve onurla geleceğe taşıyoruz.<br />
        <br />
        Müşterilerimizin ve tedarikçilerimizin bize olan güveninin vermiş olduğu güçle 
        dürüstlük ilkemizden taviz vermeden YÖRSAN adının gururla onurla geleceğe 
        taşınması, Kalite yönetimi politikamızın temelini oluşturmaktadır.
        <br />
        <br />
        Bu doğrultuda yapılan çalışmalar;<br />
        <br />
        • Gelenekten geleceğe yeni damak zevklerinin oluşturulması,<br />
        • Sürekli ekip çalışması ve kaynak iyileştirmesi,<br />
        • Müşteriye hep daha iyisini sunmak,<br />
        • Tüketicinin süt ürünlerin Yörsan adıyla istemesini sağlamak,<br />
        • Faaliyetlerimizi müşteri gözüyle değerlendirmek,<br />
        <img alt="" src="images/stfk.jpg" onclick="resimAc()" />
        <img alt="" src="images/stfk.jpg" onclick="resimAc()"/>
        <img alt="" src="images/stfk.jpg" onclick="resimAc()"/>
        <img alt="" src="images/stfk.jpg" onclick="resimAc()"/>
        <img alt="" src="images/stfk.jpg" onclick="resimAc()"/>
        <br />
        <img alt="" src="images/stfk.jpg" />
        <img alt="" src="images/stfk.jpg" />
        <img alt="" src="images/stfk.jpg" />
        <img alt="" src="images/stfk.jpg" />
        <img alt="" src="images/stfk.jpg" />
        </span></div>
            
    
     <div id="discerceve" style="background-color:Transparent;
                                 width:550px; 
                                 height:300px; 
                                 position:absolute; 
                                 visibility:hidden;
                                 top:10px;
                                 left:20%;">
         
         <img id="imgPopup" alt="Kapatmak için tıklayınız!" src=""  onclick="KAPAT()"/>
    </div>
    </form>
</body>
</html>
