using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace BusinessLayer
{
    public class emlakTipGuncelle
    {
        DbManager dm = new DbManager(false);

        public int emlakTipGuncelleId(int emlakTipId, string emlakTipAd)
        {
            int sonuc=0;
            try
            {
                dm.AddInParameters("@emlakTipId", SqlDbType.Int, emlakTipId);
                dm.AddInParameters("@emlakTipAd", SqlDbType.NVarChar, emlakTipAd);
                 sonuc = dm.ExecuteNonQuery("update EmlakTip set EmlakTipAd=@emlakTipAd where EmlakTipId=@emlakTipId", CommandType.Text);
            }
            catch (Exception)
            {

            }

            return sonuc;
        }
    }
}
