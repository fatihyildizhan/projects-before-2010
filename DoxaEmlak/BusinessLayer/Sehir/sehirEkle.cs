using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace BusinessLayer
{
    public class sehirEkle
    {
        DbManager dm = new DbManager(false);

        public int sehirEkleString(string gelenSehirAd, int postaKodu)
        {
            dm.AddInParameters("@gelenAd", SqlDbType.NVarChar, gelenSehirAd);
            dm.AddInParameters("@postaKodu",SqlDbType.Int,postaKodu);
            int sonuc = dm.ExecuteNonQuery("insert into Sehir values(@gelenAd,@postaKodu)", CommandType.Text);

            return sonuc;
        }
    }
}
