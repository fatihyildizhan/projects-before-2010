using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace BussinessLayer
{
    public class emlakEkle
    {
        static DbManager dm = new DbManager(false);

        public static bool emlakEkleEmlak(Emlak e)
        {
            dm.AddInParameters("@emlakTuru", SqlDbType.NVarChar, e.EmlakTuru);
            dm.AddInParameters("@emlakTipId", SqlDbType.Int, e.EmlakTipId);
            dm.AddInParameters("@emlakBoyut", SqlDbType.NVarChar, e.EmlakBoyut);
            int sonuc = dm.ExecuteNonQuery("insert into Emlak values(@emlakTuru, @emlakTipId, @emlakBoyut)", CommandType.Text);

            bool eklendiMi = true;
            if (sonuc <= 0)
            {
                eklendiMi = false;
            }
            return eklendiMi;
        }
    }
}
