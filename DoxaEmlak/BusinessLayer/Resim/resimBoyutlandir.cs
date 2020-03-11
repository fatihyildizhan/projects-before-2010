using System;
using System.Data;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;

/// <summary>
/// Summary description for resimBoyutlandir
/// </summary>
/// 
namespace BusinessLayer
{
 
public  class resimBoyutlandir
{
    /// <summary>
    /// Başlangıç değerleri bu construstor içinden düzenlenir.
    /// Küçük ve büyük resimlerin hangi uzantılara kaydedileceği burada belirlenir.
    /// Resimin yeni boyutu belirlenir.
    /// </summary>
    public resimBoyutlandir()
    {
        // Resimin yeni boyutu
        this.Size = new Size(100, 100);

        // Büyük resimlerin kaydedileceği klasör yolu
        this.ResimYoluBuyuk = "../../resimler/emlaklar/Buyuk/";

        // Küçük resimlerin kaydedileceği klasör yolu
        this.ResimYoluKucuk = "../../resimler/emlaklar/Kucuk/";
    }
    //../../resimler/emlaklar/Kucuk/k_b_0f2432a7-ac5d-441a-808e-e21cf1102933.jpg

    /// <summary>
    /// Bu constructur resimin upload edildiği FileUpload türünden bir parametre alır.
    /// </summary>
    /// <param name="gelenFu"></param>
    public resimBoyutlandir(FileUpload gelenFu)
    {
        this.Fu = gelenFu;
    }

    #region fields

        FileUpload fu;
        Size size = new Size(100,100);
        string resimYoluBuyuk = "~/resimler/emlaklar/Buyuk/";
        string resimYoluKucuk = "~/resimler/emlaklar/Kucuk/";

    #endregion

    #region properties
        public FileUpload Fu
        {
            get { return fu; }
            set { fu = value; }
        }
        public Size Size
        {
            get { return size; }
            set { size = value; }
        }
        public string ResimYoluBuyuk
        {
            get { return resimYoluBuyuk; }
            set { resimYoluBuyuk = value; }
        }

        public string ResimYoluKucuk
        {
            get { return resimYoluKucuk; }
            set { resimYoluKucuk = value; }
        }
     #endregion
        
    
    public  string[] resminBoyutunuKucult()
    {
        // Büyük ve küçük resimlerin isimlerinin tutulacağı String dizi
        string[] resimler = new string[2];

        try
        {
            // resimin yeni isminin tutulacağı değişken
            string resimYeniAd = "";

            // Resimin adı uzantısına kadar silinir
            // Guid ile rastgele isimlendirilir, başına b_ 'büyük' eklenir
            // HttpContext MapPath ile klasör yolu bulunup büyük dosya kaydedilir.
            resimYeniAd = "b_" + Guid.NewGuid().ToString() + "" + Fu.PostedFile.FileName.Remove(0, Fu.PostedFile.FileName.LastIndexOf("."));
            Fu.PostedFile.SaveAs(HttpContext.Current.Server.MapPath(ResimYoluBuyuk) + resimYeniAd);

            resimler[0] = resimYeniAd; // büyük resim

            // Yeni ismiyle kaydedilmiş resim 'Image' a dönüştürülür.
            System.Drawing.Image imgPhotoBuyuk = System.Drawing.Image.FromFile(HttpContext.Current.Server.MapPath(ResimYoluBuyuk + resimYeniAd));
            System.Drawing.Image imgPhoto = null;

            // Resimin boyutlandırılması için 'resizeImage' methodu çağırılır.
            // işlem sonunda resimin küçük halide kaydedilir.
            imgPhoto = resizeImage(imgPhotoBuyuk, Size);
            imgPhoto.Save(HttpContext.Current.Server.MapPath(ResimYoluKucuk + "k_" + resimYeniAd), ImageFormat.Jpeg);

            resimler[1] = "k_" + resimYeniAd; // küçük resim
            
            imgPhoto.Dispose();
        }
        catch (Exception ex)
        {

        }
        // resimlerin yeni adlarının tutulduğu dizi döndürülür.
        return resimler;
    }  
    public  System.Drawing.Image resizeImage(System.Drawing.Image imgToResize, Size size)
    {
        int sourceWidth = imgToResize.Width;
        int sourceHeight = imgToResize.Height;

        float nPercent = 0;
        float nPercentW = 0;
        float nPercentH = 0;

        nPercentW = ((float)size.Width / (float)sourceWidth);
        nPercentH = ((float)size.Height / (float)sourceHeight);

        if (nPercentH < nPercentW)
            nPercent = nPercentH;
        else
            nPercent = nPercentW;

        int destWidth = (int)(sourceWidth * nPercent);
        int destHeight = (int)(sourceHeight * nPercent);

        Bitmap b = new Bitmap(destWidth, destHeight);
        Graphics g = Graphics.FromImage((System.Drawing.Image)b);
        g.InterpolationMode = InterpolationMode.HighQualityBicubic;

        g.DrawImage(imgToResize, 0, 0, destWidth, destHeight);
        g.Dispose();

        return (System.Drawing.Image)b;
    }
    public string ResimGosterJs(string gelenResimYoluBuyuk, string gelenResimYoluKucuk, string gelenResimBaslik)
    {
        // <a rel="shadowbox[YonetimKadrosu];options={slideshowDelay:5}" href="../Resimler/yoga.jpg" class="optional" title="sdf">14</a>
        //style="text-decoration: none; color: #008000;"

        //string resimYolu = "../Resimler/yoga.jpg";
        //string resimTitle = "sdfffff";
        //string resimEkrandaGorunecekYazi = "Büyüt";

        // Label1.Text = resim;
        // Label2.Text = @"<a rel=""shadowbox[YonetimKadrosu];options={slideshowDelay:5}"" href=""../Resimler/yoga.jpg"" class=""optional"" title=""sdf"">14</a>";

        //string resim = bolum1 + tirnak + gelenResimYolu + tirnak + " " + "class=" + tirnak + "optional" + tirnak + " " + "title=" + tirnak + gelenResimBaslik + tirnak + ">" + gelenEkrandaGorunecekYazi + "</a>";

        //<a rel="shadowbox;options={handleOversize:'none'}" href="../Resimler/Buyuk/b_00478369-59c3-4d3a-81d2-5bcfa7c6f6a4.jpg" 
        // title="Great"><img src="../Resimler/asagi.png" alt="dgd" /></a>

        //<a rel="shadowbox;options={handleOversize:'none'}" href="../Resimler/Buyuk/b_a46e014e-fa8a-40a8-a92d-cafdd3e837f7.jpg"title=              "dfgfgesmanur" <img src="../Resimler/Kucuk/k_b_a46e014e-fa8a-40a8-a92d-cafdd3e837f7.jpg" alt="esmanur" /></a>

        string bolum1 = @"<a rel=""shadowbox"" href=";
        char tirnak = '"';
        string resim = bolum1 + tirnak + gelenResimYoluBuyuk + tirnak + " title=" + tirnak + gelenResimBaslik + tirnak + "> <img src=" + tirnak + gelenResimYoluKucuk + tirnak + " alt=" + tirnak + gelenResimBaslik + tirnak + " class=" + tirnak + "border" + tirnak + " /></a>";

        return resim;
    }  
}   
}
