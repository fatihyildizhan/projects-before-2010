using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace BusinessLayer
{
    public class caddeGuncelle
    {
        DbManager dm = new DbManager(false);

        public int caddeGuncelleId(int caddeId, string caddeAd, int semtId)
        {
            int sonuc = 0;
            try
            {
                dm.AddInParameters("@cdId", SqlDbType.Int, caddeId);
                dm.AddInParameters("@cdAd", SqlDbType.NVarChar, caddeAd);
                dm.AddInParameters("@smtId", SqlDbType.Int, semtId);
                sonuc = dm.ExecuteNonQuery("update Cadde set CaddeAd = @cdAd, SemtId = @smtId where CaddeId = @cdId", CommandType.Text);
            }
            catch (Exception)
            {

            }

            return sonuc;
        }
    }
}
