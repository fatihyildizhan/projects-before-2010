using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace BusinessLayer
{
    public class ozellikGuncelle
    {
        DbManager dm = new DbManager(false);

        public int ozellikGuncelleId(int ozellikId,int ozellikTipId, string ozellikAd)
        {
            int sonuc = 0;
            try
            {
                dm.AddInParameters("@oId", SqlDbType.Int, ozellikId);
                dm.AddInParameters("@oAd", SqlDbType.NVarChar, ozellikAd);
                dm.AddInParameters("@oTipId", SqlDbType.Int, ozellikTipId);
                sonuc = dm.ExecuteNonQuery("update Ozellik set OzellikAd=@oAd,OzellikTipId=@oTipId where OzellikId=@oId", CommandType.Text);
            }
            catch (Exception)
            {

            }

            return sonuc;
        }
    }
}
