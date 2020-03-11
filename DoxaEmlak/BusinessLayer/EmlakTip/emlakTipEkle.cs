using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace BusinessLayer
{
    public class emlakTipEkle
    {
        DbManager dm = new DbManager(false);

        public int emlakTipEkleString(string gelenEmlakTip)
        {
            int sonuc = 0;
            try
            {

                dm.AddInParameters("@emlakTipAd", SqlDbType.NVarChar, gelenEmlakTip);
                sonuc = dm.ExecuteNonQuery("insert into EmlakTip values(@emlakTipAd)", CommandType.Text);
            }
            catch (Exception ex)
            {

            }

            return sonuc;
        }
    }
}
