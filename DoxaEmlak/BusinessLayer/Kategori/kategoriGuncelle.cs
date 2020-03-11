using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace BusinessLayer
{
    public class kategoriGuncelle
    {
        DbManager dm = new DbManager(false);

        public int kategoriGuncelleId(int kategoriId, string KategoriAd)
        {
            int sonuc = 0;
            try
            {
                dm.AddInParameters("@kategoriId", SqlDbType.Int, kategoriId);
                dm.AddInParameters("@kategoriAd", SqlDbType.NVarChar, KategoriAd);
                sonuc = dm.ExecuteNonQuery("update Kategori set KategoriAd=@KategoriAd where KategoriId=@KategoriId", CommandType.Text);
            }
            catch (Exception)
            {

            }

            return sonuc;
        }
    }
}
