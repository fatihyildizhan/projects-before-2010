using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace BusinessLayer.Emlak
{
    public class emlakAra
    {
        public string evAraDinamikSorguOlustur(ArrayList gelenOzellikler)
        {
            StringBuilder sorgu = new StringBuilder(" select eml.EmlakId, et.EmlakTipAd, eml.EmlakBaslik, eml.EmlakReferansNo, eml.EmlakM2, TL, SehirAd, IlceAd, SemtAd, CaddeAd, [r-resimKucuk], [r-resimBuyuk], KategoriAd, eml.BalkonSayisi from Emlak eml, Kategori, EmlakTip et,  Fiyat, Sehir, Ilce, Semt, Adres, Cadde, Resim where eml.EmlakTipId = et.EmlakTipId and eml.EmlakId = Fiyat.EmlakId and Adres.EmlakId = eml.EmlakId and Semt.IlceId = Ilce.IlceId and Ilce.SehirId = Sehir.SehirId and Adres.SehirId = Sehir.SehirId and Adres.IlceId = Ilce.IlceId and Adres.SemtId = Semt.SemtId and Adres.CaddeId = Cadde.CaddeId and Resim.emlakId = eml.EmlakId ");

            try
            {
                string kriter = " and eml.EmlakId in (select EmlakId from EmlakOzellik where OzellikId = ";
                foreach (var oz in gelenOzellikler)
                {
                    sorgu.AppendLine(kriter + oz + ")");
                }
            }
            catch (Exception ex)
            {

            }

            return sorgu.ToString();
        }
    }
}
