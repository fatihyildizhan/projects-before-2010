using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace BusinessLayer
{
    public class ozellikTipGuncelle
    {
        DbManager dm = new DbManager(false);

        public int ozellikTipGuncelleId(int ozellikTipId, string ozellikTipAd)
        {
            int sonuc = 0;
            try
            {
                dm.AddInParameters("@oId", SqlDbType.Int, ozellikTipId);
                dm.AddInParameters("@oAd", SqlDbType.NVarChar, ozellikTipAd);
                sonuc = dm.ExecuteNonQuery("update OzellikTip set OzellikTipAd=@oAd where OzellikTipId=@oId", CommandType.Text);
            }
            catch (Exception)
            {

            }

            return sonuc;
        }
    }
}
