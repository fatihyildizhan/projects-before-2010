using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace BussinessLayer
{
    public class emlakTipSil
    {
        DbManager dm = new DbManager(false);

        public bool emlakTipSilId(int gelenId)
        {
            bool silindiMi = false;

            dm.AddInParameters("@emlakTipId", SqlDbType.Int, gelenId);
            int sonuc = dm.ExecuteNonQuery("delete from EmlakTip where EmlakTipId = @emlakTipId", CommandType.Text);
            if (sonuc > 0)
            {
                silindiMi = true;
            }
            return silindiMi;
        }
    }
}
