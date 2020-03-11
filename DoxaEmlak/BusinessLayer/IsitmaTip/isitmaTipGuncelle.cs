using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace BusinessLayer
{
    public class isitmaTipGuncelle
    {
        DbManager dm = new DbManager(false);

        public int isitmaTipGuncelleId(int isTipId, string isTipAd)
        {
            int sonuc = 0;
            try
            {
                dm.AddInParameters("@isTipId", SqlDbType.Int, isTipId);
                dm.AddInParameters("@isTipAd",SqlDbType.NVarChar,isTipAd);
                sonuc = dm.ExecuteNonQuery("update IsitmaTip set IsitmaTipAd = @isTipAd where IsitmaTipId = @isTipId", CommandType.Text);
            }
            catch (Exception)
            {

            }

            return sonuc;
        }
    }
}
