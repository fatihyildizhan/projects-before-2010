using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace BussinessLayer
{
    public class emlakTipEkle
    {
        DbManager dm = new DbManager(false);

        public bool emlakTipEkleString(string gelenEmlakTip)
        {
            bool eklendiMi = false;
            dm.AddInParameters("@emlakTip", SqlDbType.NVarChar, gelenEmlakTip);
            int sonuc = dm.ExecuteNonQuery("insert into EmlakTip values(@emlakTip)", CommandType.Text);
            if (sonuc > 0)
            {
                eklendiMi = true;
            }
            return eklendiMi;
        }
    }
}
