using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class haberler : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        
    }
  
    protected void lbAnasayfa_Click(object sender, EventArgs e)
    {
        Session["kanal"] = "HURRIYET";
        Session["header"] = " * ANASAYFA";
        Response.Redirect("haberler.aspx?rss=http://rss.hurriyet.com.tr/rss.aspx?sectionId=1");
    }
    protected void lbGundem_Click(object sender, EventArgs e)
    {
        Session["kanal"] = "HURRIYET";
        Session["header"] = " * GÜNDEM";
        Response.Redirect("haberler.aspx?rss=http://rss.hurriyet.com.tr/rss.aspx?sectionId=2");
    }
    protected void lbDunya_Click(object sender, EventArgs e)
    {
        Session["kanal"] = "HURRIYET";
        Session["header"] = " * DÜNYA";
        Response.Redirect("haberler.aspx?rss=http://rss.hurriyet.com.tr/rss.aspx?sectionId=3");
    }
    protected void lbEkonomi_Click(object sender, EventArgs e)
    {
        Session["kanal"] = "HURRIYET";
        Session["header"] = " * EKONOMİ";
        Response.Redirect("haberler.aspx?rss=http://rss.hurriyet.com.tr/rss.aspx?sectionId=4");
    }
    protected void lbSpor_Click(object sender, EventArgs e)
    {
        Session["kanal"] = "HURRIYET";
        Session["header"] = " * SPOR";
        Response.Redirect("haberler.aspx?rss=http://rss.hurriyet.com.tr/rss.aspx?sectionId=14");
    }
    protected void lbTeknoloji_Click(object sender, EventArgs e)
    {
        Session["kanal"] = "HURRIYET";
        Session["header"] = " * TEKNOLOJİ";
        Response.Redirect("haberler.aspx?rss=http://rss.hurriyet.com.tr/rss.aspx?sectionId=2158");
    }
    protected void lbSaglik_Click(object sender, EventArgs e)
    {
        Session["kanal"] = "HURRIYET";
        Session["header"] = " * SAĞLIK";
        Response.Redirect("haberler.aspx?rss=http://rss.hurriyet.com.tr/rss.aspx?sectionId=2208");
    }
    protected void lbKulturSanat_Click(object sender, EventArgs e)
    {
        Session["kanal"] = "HURRIYET";
        Session["header"] = " * KÜLTÜR SANAT";
        Response.Redirect("haberler.aspx?rss=http://rss.hurriyet.com.tr/rss.aspx?sectionId=13");
    }
    protected void lbMagazin_Click(object sender, EventArgs e)
    {
        Session["kanal"] = "HURRIYET";
        Session["header"] = " * MAGAZİN";
        Response.Redirect("haberler.aspx?rss=http://rss.hurriyet.com.tr/rss.aspx?sectionId=2035");
    }
    protected void lbAstroloji_Click(object sender, EventArgs e)
    {
        Session["kanal"] = "HURRIYET";
        Session["header"] = " * ASTROLOJİ";
        Response.Redirect("haberler.aspx?rss=http://rss.hurriyet.com.tr/rss.aspx?sectionId=2180");
    }
    protected void lbYazarlar_Click(object sender, EventArgs e)
    {
        Session["kanal"] = "HURRIYET";
        Session["header"] = " * YAZARLAR";
        Response.Redirect("haberler.aspx?rss=http://rss.hurriyet.com.tr/rss.aspx?sectionId=9");
    }
    protected void lbEYasam_Click(object sender, EventArgs e)
    {
        Session["kanal"] = "HURRIYET";
        Session["header"] = " * E-YAŞAM";
        Response.Redirect("haberler.aspx?rss=http://rss.hurriyet.com.tr/rss.aspx?sectionId=444");
    }
    protected void lbOtoYasam_Click(object sender, EventArgs e)
    {
        Session["kanal"] = "HURRIYET";
        Session["header"] = " * OTO-YAŞAM";
        Response.Redirect("haberler.aspx?rss=http://rss.hurriyet.com.tr/rss.aspx?sectionId=427");
    }
    protected void lbSeyahat_Click(object sender, EventArgs e)
    {
        Session["kanal"] = "HURRIYET";
        Session["header"] = " * SEYAHAT";
        Response.Redirect("haberler.aspx?rss=http://rss.hurriyet.com.tr/rss.aspx?sectionId=428");
    }
    protected void lbPazar_Click(object sender, EventArgs e)
    {
        Session["kanal"] = "HURRIYET";
        Session["header"] = " * PAZAR EKİ";
        Response.Redirect("haberler.aspx?rss=http://rss.hurriyet.com.tr/rss.aspx?sectionId=227");
    }
    protected void lbCumartesi_Click(object sender, EventArgs e)
    {
        Session["kanal"] = "HURRIYET";
        Session["header"] = " * CUMARTESİ EKİ";
        Response.Redirect("haberler.aspx?rss=http://rss.hurriyet.com.tr/rss.aspx?sectionId=434");
    }
    protected void lbCuma_Click(object sender, EventArgs e)
    {
        Session["kanal"] = "HURRIYET";
        Session["header"] = " * CUMA EKİ";
        Response.Redirect("haberler.aspx?rss=http://rss.hurriyet.com.tr/rss.aspx?sectionId=433");
    }
    protected void lbKelebek_Click(object sender, EventArgs e)
    {
        Session["kanal"] = "HURRIYET";
        Session["header"] = " * KELEBEK EKİ";
        Response.Redirect("haberler.aspx?rss=http://rss.hurriyet.com.tr/rss.aspx?sectionId=2035");
    }
    protected void lbDunyaNTV_Click(object sender, EventArgs e)
    {
        Session["kanal"] = "NTV";
        Session["header"] = " * DÜNYA";
        Response.Redirect("haberler.aspx?rss=http://www.ntvmsnbc.com/id/24927412/device/rss/rss.xml");
    }
  

    protected void lbEkonomiNTV_Click(object sender, EventArgs e)
    {
        Session["kanal"] = "NTV";
        Session["header"] = " * EKONOMİ";
        Response.Redirect("haberler.aspx?rss=http://www.ntvmsnbc.com/id/24927361/device/rss/rss.xml");
    }
    protected void lbHavaVeYol_Click(object sender, EventArgs e)
    {
        Session["kanal"] = "NTV";
        Session["header"] = " * HAVA VE YOL";
        Response.Redirect("haberler.aspx?rss=http://www.ntvmsnbc.com/id/24927997/device/rss/rss.xml");
    }
    protected void lbKulturVeSanat_Click(object sender, EventArgs e)
    {
        Session["kanal"] = "NTV";
        Session["header"] = " * KÜLTÜR VE SANAT";
        Response.Redirect("haberler.aspx?rss=http://www.ntvmsnbc.com/id/24927482/device/rss/rss.xml");
    }
    protected void lbModa_Click(object sender, EventArgs e)
    {
        Session["kanal"] = "NTV";
        Session["header"] = " * MODA";
        Response.Redirect("haberler.aspx?rss=http://www.ntvmsnbc.com/id/24928000/device/rss/rss.xml");
    }
    protected void lbSaglikNTV_Click(object sender, EventArgs e)
    {
        Session["kanal"] = "NTV";
        Session["header"] = " * SAĞLIK";
        Response.Redirect("haberler.aspx?rss=http://www.ntvmsnbc.com/id/24928008/device/rss/rss.xml");
    }
    protected void lbSporNTV_Click(object sender, EventArgs e)
    {
        Session["kanal"] = "NTV";
        Session["header"] = " * SPOR";
        Response.Redirect("haberler.aspx?rss=http://www.ntvmsnbc.com/id/24928011/device/rss/rss.xml");
    }
    protected void lbTeknolojiNTV_Click(object sender, EventArgs e)
    {
        Session["kanal"] = "NTV";
        Session["header"] = " * TEKNOLOJİ";
        Response.Redirect("haberler.aspx?rss=http://www.ntvmsnbc.com/id/24927532/device/rss/rss.xml");
    }
    protected void lbTurkiye_Click(object sender, EventArgs e)
    {
        Session["kanal"] = "NTV";
        Session["header"] = " * TÜRKİYE";
        Response.Redirect("haberler.aspx?rss=http://www.ntvmsnbc.com/id/24927681/device/rss/rss.xml");
    }
    protected void lbYasam_Click(object sender, EventArgs e)
    {
        Session["kanal"] = "NTV";
        Session["header"] = " * YAŞAM";
        Response.Redirect("haberler.aspx?rss=http://www.ntvmsnbc.com/id/24928015/device/rss/rss.xml");
    }
    protected void lbYesilHaber_Click(object sender, EventArgs e)
    {
        Session["kanal"] = "NTV";
        Session["header"] = " * YEŞİL HABER";
        Response.Redirect("haberler.aspx?rss=http://www.ntvmsnbc.com/id/24928019/device/rss/rss.xml");
    }
    protected void lbHaber_Click(object sender, EventArgs e)
    {
        Session["kanal"] = "EKOLAY";
        Session["header"] = " * HABER";
        Response.Redirect("haberler.aspx?rss=http://rss.ekolay.net/pages/haber.aspx");
    }
    protected void lbSporEKOLAY_Click(object sender, EventArgs e)
    {
        Session["kanal"] = "EKOLAY";
        Session["header"] = " * SPOR";
        Response.Redirect("haberler.aspx?rss=http://rss.ekolay.net/pages/spor.aspx");
    }
    protected void lbSinema_Click(object sender, EventArgs e)
    {
        Session["kanal"] = "EKOLAY";
        Session["header"] = " * SİNEMA";
        Response.Redirect("haberler.aspx?rss=http://rss.ekolay.net/pages/sinema.aspx");
    }
    protected void lbKadın_Click(object sender, EventArgs e)
    {
        Session["kanal"] = "EKOLAY";
        Session["header"] = " * KADIN";
        Response.Redirect("haberler.aspx?rss=http://rss.ekolay.net/pages/kadin.aspx");
    }
    protected void lbMuzik_Click(object sender, EventArgs e)
    {
        Session["kanal"] = "EKOLAY";
        Session["header"] = " * MÜZİK";
        Response.Redirect("haberler.aspx?rss=http://rss.ekolay.net/pages/muzik.aspx");
    }
    protected void lbSehir_Click(object sender, EventArgs e)
    {
        Session["kanal"] = "EKOLAY";
        Session["header"] = " * ŞEHİR";
        Response.Redirect("haberler.aspx?rss=http://rss.ekolay.net/pages/sehir.aspx");
    }
    protected void lbEglence_Click(object sender, EventArgs e)
    {
        Session["kanal"] = "EKOLAY";
        Session["header"] = " * EĞLENCE";
        Response.Redirect("haberler.aspx?rss=http://rss.ekolay.net/pages/eglence.aspx");
    }
    protected void lbAstrolojiEKOLAY_Click(object sender, EventArgs e)
    {
        Session["kanal"] = "EKOLAY";
        Session["header"] = " * ASTROLOJİ";
        Response.Redirect("haberler.aspx?rss=http://rss.ekolay.net/pages/astroloji.aspx");
    }
    protected void lbSaglikEKOLAY_Click(object sender, EventArgs e)
    {
        Session["kanal"] = "EKOLAY";
        Session["header"] = " * SAĞLIK";
        Response.Redirect("haberler.aspx?rss=http://rss.ekolay.net/pages/saglik.aspx");
    }
}
