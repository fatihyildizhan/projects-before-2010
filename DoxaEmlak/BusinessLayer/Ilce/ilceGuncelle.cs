using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace BusinessLayer
{
    public class ilceGuncelle
    {
        DbManager dm = new DbManager(false);

        public int ilceGuncelleId(int ilceId, string ilceAd, int sehirId)
        {
            int sonuc = 0;
            try
            {
                dm.AddInParameters("@ilceId",SqlDbType.Int,ilceId);
                dm.AddInParameters("@ilceAd",SqlDbType.NVarChar,ilceAd);
                dm.AddInParameters("@sehirId",SqlDbType.Int,sehirId);
                sonuc = dm.ExecuteNonQuery("update Ilce set IlceAd = @ilceAd, SehirId = @sehirId where IlceId = @ilceId", CommandType.Text);
            }
            catch (Exception ex)
            {

            }

            return sonuc;
        }
    }
}
