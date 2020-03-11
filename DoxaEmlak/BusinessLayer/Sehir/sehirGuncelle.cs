using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace BusinessLayer
{
    public class sehirGuncelle
    {
        DbManager dm = new DbManager(false);

        public int sehirGuncelleId(int sehirId, string sehirAd, int postaKodu)
        {
            int sonuc = 0;
            try
            {
                dm.AddInParameters("@shrId",SqlDbType.Int,sehirId);
                dm.AddInParameters("@shrAd",SqlDbType.NVarChar,sehirAd);
                dm.AddInParameters("@postaKodu",SqlDbType.Int,postaKodu);
                sonuc = dm.ExecuteNonQuery("update Sehir set SehirAd = @shrAd, PostaKodu = @postaKodu where SehirId = @shrId", CommandType.Text);
            }
            catch (Exception)
            {

            }

            return sonuc;
        }
    }
}
