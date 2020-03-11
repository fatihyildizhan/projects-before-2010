using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace BusinessLayer
{
    public class caddeEkle
    {
        DbManager dm = new DbManager(false);

        public int caddeEkleString(string gelenCaddeAd, int semtId)
        {
            dm.AddInParameters("@gelenCaddeAd", SqlDbType.NVarChar, gelenCaddeAd);
            dm.AddInParameters("@smtId", SqlDbType.Int, semtId);
            int sonuc = dm.ExecuteNonQuery("insert into Cadde values(@gelenCaddeAd,@smtId)", CommandType.Text);

            return sonuc;
        }
    }
}
