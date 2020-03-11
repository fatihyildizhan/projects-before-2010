using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace BusinessLayer
{
    public class ozellikTipEkle
    {
        DbManager dm = new DbManager(false);

        public int ozellikTipEkleString(string ozellikTipAd)
        {
            dm.AddInParameters("@ozlTipAd", SqlDbType.NVarChar, ozellikTipAd);
            int sonuc = dm.ExecuteNonQuery("insert into OzellikTip values(@ozlTipAd)", CommandType.Text);

            return sonuc;
        }
    }
}
