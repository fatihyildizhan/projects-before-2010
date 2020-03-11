using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Web.Configuration;
using System.Data;

namespace BusinessLayer
{
    public class emlakGetir
    {
        SqlConnection con = new SqlConnection(WebConfigurationManager.ConnectionStrings["LocalSqlServer"].ConnectionString.ToString());
        SqlConnection con2 = new SqlConnection(WebConfigurationManager.ConnectionStrings["LocalSqlServer"].ConnectionString.ToString());
        DbManager dm = new DbManager(false);
        public List<emlak> emlakGetirTum()
        {
            List<emlak> emlaklar = new List<emlak>();
            try
            {
                SqlCommand com = new SqlCommand("select * from Emlak", con);
                com.CommandType = CommandType.Text;

                con.Open();
                SqlDataReader dr = com.ExecuteReader();
                while (dr.Read())
                {
                    emlak e = new emlak();
                    e.EmlakId = Convert.ToInt32(dr["EmlakId"]);
                    e.Aidat = dr["Aidat"].ToString();
                    e.BanyoSayisi = dr["BanyoSayisi"].ToString();
                    e.BinadakiKatSayisi = Convert.ToInt32(dr["BinadakiKatSayisi"]);
                    e.BinaYasi = Convert.ToInt32(dr["BinaYasi"]);
                    e.BulunduguKat = Convert.ToInt32(dr["BulunduguKat"]);
                    e.Deposit = dr["Deposit"].ToString();
                    e.Durumu = dr["Durumu"].ToString();
                    e.EmlakAciklama = dr["EmlakAciklama"].ToString();
                    e.EmlakBaslik = dr["EmlakBaslik"].ToString();
                    e.EmlakEklenmeTarihi = Convert.ToDateTime(dr["EmlakEklenmeTarihi"]);
                    e.EmlakM2 = dr["EmlakM2"].ToString();
                    e.EmlakReferansNo = Convert.ToInt32(dr["EmlakReferansNo"]);
                    e.EmlakTipId = Convert.ToInt32(dr["EmlakTipId"]);
                    e.IsitmaTipId = Convert.ToInt32(dr["IsitmaTipId"]);
                    e.KrediyeUygun = Convert.ToBoolean(dr["KrediyeUygun"]);
                    e.OdaSayisi = dr["OdaSayisi"].ToString();
                    e.TapuDurumu = dr["TapuDurumu"].ToString();
                    e.BalkonSayisi = Convert.ToInt32(dr["BalkonSayisi"]);
                    e.KategoriId = Convert.ToInt32(dr["KategoriId"]);
                    emlaklar.Add(e);
                }
                dr.Close();
            }
            catch (Exception ex)
            {

            }
            finally
            {
                con.Close();
            }
            return emlaklar;
        }
        public emlak emlakGetirId(int emlakId)
        {
            emlak e = new emlak();
            try
            {
                SqlCommand com = new SqlCommand("select * from Emlak where EmlakId = @EmlakId", con);
                com.Parameters.AddWithValue("@EmlakId", emlakId);
                com.CommandType = CommandType.Text;

                con.Open();
                SqlDataReader dr = com.ExecuteReader();
                while (dr.Read())
                {
                    e.EmlakId = Convert.ToInt32(dr["EmlakId"]);
                    e.Aidat = dr["Aidat"].ToString();
                    e.BanyoSayisi = dr["BanyoSayisi"].ToString();
                    e.BinadakiKatSayisi = Convert.ToInt32(dr["BinadakiKatSayisi"]);
                    e.BinaYasi = Convert.ToInt32(dr["BinaYasi"]);
                    e.BulunduguKat = Convert.ToInt32(dr["BulunduguKat"]);
                    e.Deposit = dr["Deposit"].ToString();
                    e.Durumu = dr["Durumu"].ToString();
                    e.EmlakAciklama = dr["EmlakAciklama"].ToString();
                    e.EmlakBaslik = dr["EmlakBaslik"].ToString();
                    e.EmlakEklenmeTarihi = Convert.ToDateTime(dr["EmlakEklenmeTarihi"]);
                    e.EmlakM2 = dr["EmlakM2"].ToString();
                    e.EmlakReferansNo = Convert.ToInt32(dr["EmlakReferansNo"]);
                    e.EmlakTipId = Convert.ToInt32(dr["EmlakTipId"]);
                    e.IsitmaTipId = Convert.ToInt32(dr["IsitmaTipId"]);
                    e.KrediyeUygun = Convert.ToBoolean(dr["KrediyeUygun"]);
                    e.OdaSayisi = dr["OdaSayisi"].ToString();
                    e.TapuDurumu = dr["TapuDurumu"].ToString();
                    e.BalkonSayisi = Convert.ToInt32(dr["BalkonSayisi"]);
                    e.KategoriId = Convert.ToInt32(dr["KategoriId"]);
                }
                dr.Close();
            }
            catch (Exception ex)
            {

            }
            finally
            {
                con.Close();
            }
            return e;
        }
        public List<emlakDetay> emlakGetirIdDetay(int emlakId)
        {
            List<emlakDetay> ed = new List<emlakDetay>();
            try
            {
                SqlCommand com = new SqlCommand("prcEmlakGetirIdDetay", con);
                com.Parameters.AddWithValue("@emlakId", emlakId);
                com.CommandType = CommandType.StoredProcedure;

                con.Open();
                SqlDataReader dr = com.ExecuteReader();
                while (dr.Read())
                {
                    emlakDetay e = new emlakDetay();
                    e.EmlakId = Convert.ToInt32(dr["EmlakId"]);
                    e.Aidat = dr["Aidat"].ToString();
                    e.BanyoSayisi = dr["BanyoSayisi"].ToString();
                    e.KatSayisi = Convert.ToInt32(dr["BinadakiKatSayisi"]);
                    e.BinaYasi = Convert.ToInt32(dr["BinaYasi"]);
                    e.BulunduguKat = Convert.ToInt32(dr["BulunduguKat"]);
                    e.Deposit = dr["Deposit"].ToString();
                    e.Durumu = dr["Durumu"].ToString();
                    e.EmlakAciklama = dr["EmlakAciklama"].ToString();
                    e.EmlakBaslik = dr["EmlakBaslik"].ToString();
                    e.EmlakEklenmeTarihi = Convert.ToDateTime(dr["EmlakEklenmeTarihi"]);
                    e.EmlakM2 = dr["EmlakM2"].ToString();
                    e.EmlakReferansNo = Convert.ToInt32(dr["EmlakReferansNo"]);
                    e.EmlakTipId = Convert.ToInt32(dr["EmlakTipId"]);
                    e.EmlakTipAd = dr["EmlakTipAd"].ToString();
                    e.IsitmaTipId = Convert.ToInt32(dr["IsitmaTipId"]);
                    e.IsitmaTipAd = dr["IsitmaTipAd"].ToString();
                    e.KrediyeUygun = Convert.ToBoolean(dr["KrediyeUygun"]);
                    e.OdaSayisi = dr["OdaSayisi"].ToString();
                    e.TapuDurumu = dr["TapuDurumu"].ToString();
                    e.FiyatTL = dr["TL"].ToString() + " TL";
                    e.IlceAd = dr["IlceAd"].ToString();
                    e.SehirAd = dr["SehirAd"].ToString();
                    e.SemtAd = dr["SemtAd"].ToString();
                    e.CaddeAd = dr["CaddeAd"].ToString();
                    e.AdresTarifi = dr["AdresTarifi"].ToString();
                    e.IlkResimBuyuk = "../../resimler/emlaklar/Buyuk/" + dr["r-resimBuyuk"].ToString();
                    e.IlkResimKucuk = "../../resimler/emlaklar/Kucuk/" + dr["r-resimKucuk"].ToString();
                    e.BalkonSayisi = Convert.ToInt32(dr["BalkonSayisi"]);
                    e.KategoriId = Convert.ToInt32(dr["KategoriId"]);
                    e.KategoriAd = dr["KategoriAd"].ToString();
                    ed.Add(e);
                }
                dr.Close();
            }
            catch (Exception ex)
            {

            }
            finally
            {
                con.Close();
            }
            return ed;
        }
        public List<emlakDetay> emlakGetirTumDetay()
        {
            List<emlakDetay> ed = new List<emlakDetay>();
            try
            {
                SqlCommand com = new SqlCommand("prcEmlakGetirTumDetay", con);
                com.CommandType = CommandType.StoredProcedure;

                con.Open();
                SqlDataReader dr = com.ExecuteReader();
                while (dr.Read())
                {
                    //int idVarmi = Convert.ToInt32(dr["EmlakId"]);
                    //bool varMi = false;
                    //foreach (emlakDetay emlakim in ed)
                    //{
                    //    if (emlakim.EmlakId == idVarmi)
                    //    {
                    //        varMi = true;
                    //        break;
                    //    }
                    //}
                    //if (varMi == false)
                    //{
                    emlakDetay e = new emlakDetay();
                    e.EmlakId = Convert.ToInt32(dr["EmlakId"]);
                    e.Aidat = dr["Aidat"].ToString();
                    e.BanyoSayisi = dr["BanyoSayisi"].ToString();
                    e.KatSayisi = Convert.ToInt32(dr["BinadakiKatSayisi"]);
                    e.BinaYasi = Convert.ToInt32(dr["BinaYasi"]);
                    e.BulunduguKat = Convert.ToInt32(dr["BulunduguKat"]);
                    e.Deposit = dr["Deposit"].ToString();
                    e.Durumu = dr["Durumu"].ToString();
                    e.EmlakAciklama = dr["EmlakAciklama"].ToString();
                    e.EmlakBaslik = dr["EmlakBaslik"].ToString();
                    e.EmlakEklenmeTarihi = Convert.ToDateTime(dr["EmlakEklenmeTarihi"]);
                    e.EmlakM2 = dr["EmlakM2"].ToString();
                    e.EmlakReferansNo = Convert.ToInt32(dr["EmlakReferansNo"]);
                    e.EmlakTipId = Convert.ToInt32(dr["EmlakTipId"]);
                    e.EmlakTipAd = dr["EmlakTipAd"].ToString();
                    e.IsitmaTipId = Convert.ToInt32(dr["IsitmaTipId"]);
                    e.IsitmaTipAd = dr["IsitmaTipAd"].ToString();
                    e.KrediyeUygun = Convert.ToBoolean(dr["KrediyeUygun"]);
                    e.OdaSayisi = dr["OdaSayisi"].ToString();
                    e.TapuDurumu = dr["TapuDurumu"].ToString();
                    e.FiyatTL = dr["TL"].ToString() + " TL";
                    e.IlceAd = dr["IlceAd"].ToString();
                    e.SehirAd = dr["SehirAd"].ToString();
                    e.SemtAd = dr["SemtAd"].ToString();
                    e.CaddeAd = dr["CaddeAd"].ToString();
                    e.AdresTarifi = dr["AdresTarifi"].ToString();
                    e.BalkonSayisi = Convert.ToInt32(dr["BalkonSayisi"]);
                    e.KategoriId = Convert.ToInt32(dr["KategoriId"]);
                    e.KategoriAd = dr["KategoriAd"].ToString();
                    // e.IlkResimBuyuk = "../../resimler/emlaklar/Buyuk/" + dr["r-resimBuyuk"].ToString();
                    // e.IlkResimKucuk = "../../resimler/emlaklar/Kucuk/" + dr["r-resimKucuk"].ToString();

                    con2.Open();
                    SqlCommand comResim = new SqlCommand("select * from Resim where emlakId=@Id", con2);
                    comResim.Parameters.AddWithValue("@Id", e.EmlakId);
                    SqlDataReader drResim = comResim.ExecuteReader();
                    while (drResim.Read())
                    {
                        e.IlkResimKucuk += "<a rel=\"shadowbox\" href=\"../../resimler/emlaklar/Buyuk/" + drResim["r-resimBuyuk"].ToString() + "\"> <img alt=\"Emlak-Resim\" src=\"../../resimler/emlaklar/Kucuk/" + drResim["r-resimKucuk"].ToString() + "\"></a>";
                        //e.ResimlerKucuk.Add("../../resimler/emlaklar/Kucuk/" + drResim["r-resimKucuk"].ToString());
                        //e.ResimlerBuyuk.Add("../../resimler/emlaklar/Buyuk/" + drResim["r-resimBuyuk"].ToString());
                    }
                    drResim.Close();

                    SqlCommand comOzellik = new SqlCommand("select OzellikAd, OzellikTipAd from Ozellik o , OzellikTip ozt, EmlakOzellik eo where o.OzellikTipId = ozt.OzellikTipId and o.OzellikId = eo.OzellikId and EmlakId = @emlId order by OzellikTipAd", con2);
                    comOzellik.Parameters.AddWithValue("@emlId", e.EmlakId);
                    SqlDataReader drOzellik = comOzellik.ExecuteReader();
                    while (drOzellik.Read())
                    {
                        bool varMi = false;
                        foreach (string ozl in e.Ozellikler)
                        {
                            if (ozl.Equals(drOzellik["OzellikTipAd"].ToString()))
                            {
                                varMi = true;
                                break;
                            }
                        }
                        if (varMi == false)
                        {
                            e.Ozellikler.Add(drOzellik["OzellikTipAd"].ToString());
                            e.Ozellikler.Add(drOzellik["OzellikAd"].ToString());
                        }
                        else
                        {
                            e.Ozellikler.Add(drOzellik["OzellikAd"].ToString());
                        }
                    }
                    drOzellik.Close();

                    con2.Close();

                    ed.Add(e);
                    //}
                }
                dr.Close();
            }
            catch (Exception ex)
            {

            }
            finally
            {
                con.Close();
            }
            return ed;
        }
        public List<emlakDetay> emlakGetirIDTumDetay(int gelenEmlakId)
        {
            List<emlakDetay> ed = new List<emlakDetay>();
            try
            {
                SqlCommand com = new SqlCommand("prcEmlGtrIdTumDetay", con);
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.AddWithValue("@emlakIDsi",gelenEmlakId);

                con.Open();
                SqlDataReader dr = com.ExecuteReader();
                while (dr.Read())
                {
                    //int idVarmi = Convert.ToInt32(dr["EmlakId"]);
                    //bool varMi = false;
                    //foreach (emlakDetay emlakim in ed)
                    //{
                    //    if (emlakim.EmlakId == idVarmi)
                    //    {
                    //        varMi = true;
                    //        break;
                    //    }
                    //}
                    //if (varMi == false)
                    //{
                    emlakDetay e = new emlakDetay();
                    e.EmlakId = Convert.ToInt32(dr["EmlakId"]);
                    e.Aidat = dr["Aidat"].ToString();
                    e.BanyoSayisi = dr["BanyoSayisi"].ToString();
                    e.KatSayisi = Convert.ToInt32(dr["BinadakiKatSayisi"]);
                    e.BinaYasi = Convert.ToInt32(dr["BinaYasi"]);
                    e.BulunduguKat = Convert.ToInt32(dr["BulunduguKat"]);
                    e.Deposit = dr["Deposit"].ToString();
                    e.Durumu = dr["Durumu"].ToString();
                    e.EmlakAciklama = dr["EmlakAciklama"].ToString();
                    e.EmlakBaslik = dr["EmlakBaslik"].ToString();
                    e.EmlakEklenmeTarihi = Convert.ToDateTime(dr["EmlakEklenmeTarihi"]);
                    e.EmlakM2 = dr["EmlakM2"].ToString();
                    e.EmlakReferansNo = Convert.ToInt32(dr["EmlakReferansNo"]);
                    e.EmlakTipId = Convert.ToInt32(dr["EmlakTipId"]);
                    e.EmlakTipAd = dr["EmlakTipAd"].ToString();
                    e.IsitmaTipId = Convert.ToInt32(dr["IsitmaTipId"]);
                    e.IsitmaTipAd = dr["IsitmaTipAd"].ToString();
                    e.KrediyeUygun = Convert.ToBoolean(dr["KrediyeUygun"]);
                    e.OdaSayisi = dr["OdaSayisi"].ToString();
                    e.TapuDurumu = dr["TapuDurumu"].ToString();
                    e.FiyatTL = dr["TL"].ToString() + " TL";
                    e.IlceAd = dr["IlceAd"].ToString();
                    e.SehirAd = dr["SehirAd"].ToString();
                    e.SemtAd = dr["SemtAd"].ToString();
                    e.CaddeAd = dr["CaddeAd"].ToString();
                    e.AdresTarifi = dr["AdresTarifi"].ToString();
                    e.BalkonSayisi = Convert.ToInt32(dr["BalkonSayisi"]);
                    e.KategoriId = Convert.ToInt32(dr["KategoriId"]);
                    e.KategoriAd = dr["KategoriAd"].ToString();
                    // e.IlkResimBuyuk = "../../resimler/emlaklar/Buyuk/" + dr["r-resimBuyuk"].ToString();
                    // e.IlkResimKucuk = "../../resimler/emlaklar/Kucuk/" + dr["r-resimKucuk"].ToString();

                    con2.Open();
                    SqlCommand comResim = new SqlCommand("select * from Resim where emlakId=@Id", con2);
                    comResim.Parameters.AddWithValue("@Id", e.EmlakId);
                    SqlDataReader drResim = comResim.ExecuteReader();
                    while (drResim.Read())
                    {
                        e.IlkResimKucuk += "<a rel=\"shadowbox\" href=\"../../resimler/emlaklar/Buyuk/" + drResim["r-resimBuyuk"].ToString() + "\"> <img alt=\"Emlak-Resim\" src=\"../../resimler/emlaklar/Kucuk/" + drResim["r-resimKucuk"].ToString() + "\"></a>";
                        //e.ResimlerKucuk.Add("../../resimler/emlaklar/Kucuk/" + drResim["r-resimKucuk"].ToString());
                        //e.ResimlerBuyuk.Add("../../resimler/emlaklar/Buyuk/" + drResim["r-resimBuyuk"].ToString());
                    }
                    drResim.Close();

                    SqlCommand comOzellik = new SqlCommand("select OzellikAd, OzellikTipAd from Ozellik o , OzellikTip ozt, EmlakOzellik eo where o.OzellikTipId = ozt.OzellikTipId and o.OzellikId = eo.OzellikId and EmlakId = @emlId order by OzellikTipAd", con2);
                    comOzellik.Parameters.AddWithValue("@emlId", e.EmlakId);
                    SqlDataReader drOzellik = comOzellik.ExecuteReader();
                    while (drOzellik.Read())
                    {
                        bool varMi = false;
                        foreach (string ozl in e.Ozellikler)
                        {
                            if (ozl.Equals(drOzellik["OzellikTipAd"].ToString()))
                            {
                                varMi = true;
                                break;
                            }
                        }
                        if (varMi == false)
                        {
                            e.Ozellikler.Add(drOzellik["OzellikTipAd"].ToString());
                            e.Ozellikler.Add(drOzellik["OzellikAd"].ToString());
                        }
                        else
                        {
                            e.Ozellikler.Add(drOzellik["OzellikAd"].ToString());
                        }
                    }
                    drOzellik.Close();

                    con2.Close();

                    ed.Add(e);
                    //}
                }
                dr.Close();
            }
            catch (Exception ex)
            {

            }
            finally
            {
                con.Close();
            }
            return ed;
        }
        public int emlakIdGetirSonEklenen()
        {
            int sonuc = 0;
            try
            {
                SqlCommand com = new SqlCommand("SELECT MAX(EmlakId) FROM Emlak", con);
                com.CommandType = CommandType.Text;

                con.Open();
                sonuc = Convert.ToInt32(com.ExecuteScalar());
            }
            catch (Exception ex)
            {

            }
            finally
            {
                con.Close();
            }
            return sonuc;
        }
        public int emlakToplamSayisiGetir()
        {
            int sayi = 0;
            try
            {
                sayi = Convert.ToInt32(dm.ExecuteScalar("select count(EmlakId) from Emlak", CommandType.Text));
            }
            catch (Exception ex)
            {

            }
            return sayi;
        }
        public List<emlakOzet> emlakOzetGetir(int emlakTipId)
        {
            List<emlakOzet> emlaklar = new List<emlakOzet>();
            try
            {
                SqlCommand com = new SqlCommand("prcEmlakOzetGetir", con);
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.AddWithValue("@EmlakTipId", emlakTipId);

                con.Open();
                SqlDataReader dr = com.ExecuteReader();
                while (dr.Read())
                {

                    //int emlakId;
                    //string emlakTipAd;
                    //string emlakBaslik;
                    //int emlakReferansNo;
                    //string emlakM2;
                    //string ilkResimKucuk;
                    //string ilkResimBuyuk;
                    //int fiyatTL;
                    //string adres;
                    int idVarmi = Convert.ToInt32(dr["EmlakId"]);
                    bool varMi = false;
                    foreach (emlakOzet emlakim in emlaklar)
                    {
                        if (emlakim.EmlakId == idVarmi)
                        {
                            varMi = true;
                            break;
                        }
                    }
                    if (varMi == false)
                    {
                        emlakOzet e = new emlakOzet();
                        e.EmlakId = Convert.ToInt32(dr["EmlakId"]);
                        e.EmlakBaslik = dr["EmlakBaslik"].ToString();
                        e.EmlakM2 = dr["EmlakM2"].ToString() + " m2";
                        e.EmlakReferansNo = Convert.ToInt32(dr["EmlakReferansNo"]);
                        e.EmlakTipAd = dr["EmlakTipAd"].ToString();
                        e.FiyatTL = Convert.ToInt32(dr["TL"]);
                        e.IlkResimBuyuk = "../../resimler/emlaklar/Buyuk/" + dr["r-resimBuyuk"].ToString();
                        e.IlkResimKucuk = "../../resimler/emlaklar/Kucuk/" + dr["r-resimKucuk"].ToString();
                        e.Adres = dr["SehirAd"].ToString() + " " + dr["IlceAd"].ToString() + " " + dr["SemtAd"].ToString() + " " + dr["CaddeAd"].ToString();
                        e.KategoriAd = dr["KategoriAd"].ToString();
                        emlaklar.Add(e);
                    }
                }
                dr.Close();
            }
            catch (Exception ex)
            {

            }
            finally
            {
                con.Close();
            }
            return emlaklar;
        }
        public List<emlakOzet> emlakAraDinamikSorgu(string dinamikSorgu)
        {
            List<emlakOzet> emlaklar = new List<emlakOzet>();
            try
            {
                SqlCommand com = new SqlCommand(dinamikSorgu, con);
                com.CommandType = CommandType.Text;

                con.Open();
                SqlDataReader dr = com.ExecuteReader();
                while (dr.Read())
                {

                    //int emlakId;
                    //string emlakTipAd;
                    //string emlakBaslik;
                    //int emlakReferansNo;
                    //string emlakM2;
                    //string ilkResimKucuk;
                    //string ilkResimBuyuk;
                    //int fiyatTL;
                    //string adres;
                    int idVarmi = Convert.ToInt32(dr["EmlakId"]);
                    bool varMi = false;
                    foreach (emlakOzet emlakim in emlaklar)
                    {
                        if (emlakim.EmlakId == idVarmi)
                        {
                            varMi = true;
                            break;
                        }
                    }
                    if (varMi == false)
                    {
                        emlakOzet e = new emlakOzet();
                        e.EmlakId = Convert.ToInt32(dr["EmlakId"]);
                        e.EmlakBaslik = dr["EmlakBaslik"].ToString();
                        e.EmlakM2 = dr["EmlakM2"].ToString() + " m2";
                        e.EmlakReferansNo = Convert.ToInt32(dr["EmlakReferansNo"]);
                        e.EmlakTipAd = dr["EmlakTipAd"].ToString();
                        e.FiyatTL = Convert.ToInt32(dr["TL"]);
                        e.IlkResimBuyuk = "../../resimler/emlaklar/Buyuk/" + dr["r-resimBuyuk"].ToString();
                        e.IlkResimKucuk = "../../resimler/emlaklar/Kucuk/" + dr["r-resimKucuk"].ToString();
                        e.Adres = dr["SehirAd"].ToString() + " " + dr["IlceAd"].ToString() + " " + dr["SemtAd"].ToString() + " " + dr["CaddeAd"].ToString();
                        e.KategoriAd = dr["KategoriAd"].ToString();
                        emlaklar.Add(e);
                    }
                }
                dr.Close();
            }
            catch (Exception ex)
            {

            }
            finally
            {
                con.Close();
            }
            return emlaklar;
        }
        public List<emlakOzet> emlakAraMenu(string Sorgu)
        {
            List<emlakOzet> emlaklar = new List<emlakOzet>();
            try
            {
                string ilkSorgu = "select eml.EmlakId, et.EmlakTipAd, eml.EmlakBaslik,[r-resimKucuk],[r-resimBuyuk], SehirAd,IlceAd,SemtAd, CaddeAd, eml.EmlakReferansNo, eml.EmlakM2, TL, KategoriAd from Emlak eml, EmlakTip et, Fiyat, Kategori ,Sehir, Ilce, Semt ,Adres,Resim , Cadde where eml.EmlakTipId = et.EmlakTipId and eml.EmlakId = Fiyat.EmlakId and eml.KategoriId = Kategori.KategoriId and Adres.EmlakId = eml.EmlakId and Semt.IlceId = Ilce.IlceId and Ilce.SehirId = Sehir.SehirId and Resim.emlakId = eml.EmlakId and Adres.SehirId = Sehir.SehirId and Adres.IlceId = Ilce.IlceId and Adres.SemtId = Semt.SemtId and Adres.CaddeId = Cadde.CaddeId and eml.EmlakId in (" + Sorgu + ")";

                SqlCommand com = new SqlCommand(ilkSorgu, con);
                com.CommandType = CommandType.Text;

                con.Open();
                SqlDataReader dr = com.ExecuteReader();
                while (dr.Read())
                {

                    //int emlakId;
                    //string emlakTipAd;
                    //string emlakBaslik;
                    //int emlakReferansNo;
                    //string emlakM2;
                    //string ilkResimKucuk;
                    //string ilkResimBuyuk;
                    //int fiyatTL;
                    //string adres;
                    int idVarmi = Convert.ToInt32(dr["EmlakId"]);
                    bool varMi = false;
                    foreach (emlakOzet emlakim in emlaklar)
                    {
                        if (emlakim.EmlakId == idVarmi)
                        {
                            varMi = true;
                            break;
                        }
                    }
                    if (varMi == false)
                    {
                        emlakOzet e = new emlakOzet();
                        e.EmlakId = Convert.ToInt32(dr["EmlakId"]);
                        e.EmlakBaslik = dr["EmlakBaslik"].ToString();
                        e.EmlakM2 = dr["EmlakM2"].ToString() + " m2";
                        e.EmlakReferansNo = Convert.ToInt32(dr["EmlakReferansNo"]);
                        e.EmlakTipAd = dr["EmlakTipAd"].ToString();
                        e.FiyatTL = Convert.ToInt32(dr["TL"]);
                        e.IlkResimBuyuk = "../../resimler/emlaklar/Buyuk/" + dr["r-resimBuyuk"].ToString();
                        e.IlkResimKucuk = "../../resimler/emlaklar/Kucuk/" + dr["r-resimKucuk"].ToString();
                        e.Adres = dr["SehirAd"].ToString() + " " + dr["IlceAd"].ToString() + " " + dr["SemtAd"].ToString() + " " + dr["CaddeAd"].ToString();
                        e.KategoriAd = dr["KategoriAd"].ToString();
                        emlaklar.Add(e);
                    }
                }
                dr.Close();
            }
            catch (Exception ex)
            {

            }
            finally
            {
                con.Close();
            }
            return emlaklar;
        }
    }
}
