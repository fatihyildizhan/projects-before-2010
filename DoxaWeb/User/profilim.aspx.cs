using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class User_profilim : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            txtDogumTarih.Text = Profile.uyeINFO.DogumTarihi;
            RadioButtonList1.SelectedValue = Profile.uyeINFO.Cinsiyet;
            txtAd.Text = Profile.uyeINFO.Ad;
            txtAktivite.Text = Profile.uyeINFO.Aktivite;
            txtCepTelefonu.Text = Profile.uyeINFO.Cepno;
            txtFavoriSoz.Text = Profile.uyeINFO.FavoriSozu;
            txtIlgiAlani.Text = Profile.uyeINFO.IlgiAlani;
            txtLise.Text = Profile.uyeINFO.Lise;
            txtMemleket.Text = Profile.uyeINFO.Memleket;
            txtMeslek.Text = Profile.uyeINFO.Meslek;
            txtMsn.Text = Profile.uyeINFO.Msn;
            txtNickName.Text = Profile.uyeINFO.Nickname;
            txtRuhDurumu.Text = Profile.uyeINFO.RuhDurumu;
            txtSoyad.Text = Profile.uyeINFO.Soyad;
            txtUniBolum.Text = Profile.uyeINFO.UniBolum;
            txtUnivetsite.Text = Profile.uyeINFO.Universite;
            txtWebSitesi.Text = Profile.uyeINFO.Websitesi;
            txtYasadigiSehir.Text = Profile.uyeINFO.YasadigiSehir;
        }
       
    }
}
