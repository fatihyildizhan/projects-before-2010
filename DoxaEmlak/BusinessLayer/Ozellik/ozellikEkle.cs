using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace BusinessLayer
{
    public class ozellikEkle
    {
        DbManager dm = new DbManager(false);

        public int ozellikEkleString(int ozellikTipId, string ozellikAd)
        {
            dm.AddInParameters("@ozlAd", SqlDbType.NVarChar, ozellikAd);
            dm.AddInParameters("@ozlTipId", SqlDbType.Int, ozellikTipId);
            int sonuc = dm.ExecuteNonQuery("insert into Ozellik values(@ozlTipId,@ozlAd)", CommandType.Text);

            return sonuc;
        }
    }
}
