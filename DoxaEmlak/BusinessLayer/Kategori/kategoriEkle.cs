using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace BusinessLayer
{
    public class kategoriEkle
    {
        DbManager dm = new DbManager(false);

        public int kategoriEkleString(string KategoriAd)
        {
            dm.AddInParameters("@kAd", SqlDbType.NVarChar, KategoriAd);
            int sonuc = dm.ExecuteNonQuery("insert into Kategori values(@kAd)", CommandType.Text);
            
            return sonuc;
        }
    }
}
