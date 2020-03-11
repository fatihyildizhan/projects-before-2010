using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace BusinessLayer
{
    public class emlakGuncelle
    {
        DbManager dm = new DbManager(false);

        public int emlakGuncelleMetod(emlak gelenE)
        {
            int sonuc = 0;
            try
            {
                dm.AddInParameters("@emlakId",SqlDbType.Int,gelenE.EmlakId);
                dm.AddInParameters("@emlakTipId", SqlDbType.Int, gelenE.EmlakTipId);
                dm.AddInParameters("@emlakBaslik", SqlDbType.NVarChar, gelenE.EmlakBaslik);
                dm.AddInParameters("@emlakReferansNo", SqlDbType.Int, gelenE.EmlakReferansNo);
                dm.AddInParameters("@emlakM2", SqlDbType.NVarChar, gelenE.EmlakM2);
                dm.AddInParameters("@odaSayisi", SqlDbType.NVarChar, gelenE.OdaSayisi);
                dm.AddInParameters("@banyoSayisi", SqlDbType.NVarChar, gelenE.BanyoSayisi);
                dm.AddInParameters("@binaYasi", SqlDbType.Int, gelenE.BinaYasi);
                dm.AddInParameters("@binadakiKatSayisi", SqlDbType.Int, gelenE.BinadakiKatSayisi);
                dm.AddInParameters("@bulunduguKat", SqlDbType.Int, gelenE.BulunduguKat);
                dm.AddInParameters("@isitmaTipId", SqlDbType.Int, gelenE.IsitmaTipId);
                dm.AddInParameters("@krediyeUygun", SqlDbType.Bit, gelenE.KrediyeUygun);
                dm.AddInParameters("@durumu", SqlDbType.NVarChar, gelenE.Durumu);
                dm.AddInParameters("@tapuDurumu", SqlDbType.NVarChar, gelenE.TapuDurumu);
                dm.AddInParameters("@emlakAciklama", SqlDbType.NVarChar, gelenE.EmlakAciklama);
                dm.AddInParameters("@aidat", SqlDbType.NVarChar, gelenE.Aidat);
                dm.AddInParameters("@deposit", SqlDbType.NVarChar, gelenE.Deposit);
                dm.AddInParameters("@kategoriId", SqlDbType.Int, gelenE.KategoriId);
                dm.AddInParameters("@balkonSayisi", SqlDbType.Int, gelenE.BalkonSayisi);
                sonuc = dm.ExecuteNonQuery("prcEmlakGuncelle", CommandType.StoredProcedure);
            }
            catch (Exception)
            {

            }

            return sonuc;
        }
    }
}
