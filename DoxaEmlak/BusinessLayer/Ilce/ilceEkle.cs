using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace BusinessLayer
{
    public class ilceEkle
    {
        DbManager dm = new DbManager(false);

        public int ilceEkleString(string gelenIlceAd, int sehirId)
        {
            dm.AddInParameters("@gelenIlceAd", SqlDbType.NVarChar, gelenIlceAd);
            dm.AddInParameters("@shrId", SqlDbType.Int, sehirId);
            int sonuc = dm.ExecuteNonQuery("insert into Ilce values(@gelenIlceAd,@shrId)", CommandType.Text);

            return sonuc;
        }
    }
}
