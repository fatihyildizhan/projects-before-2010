using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace BusinessLayer
{
    public class semtGuncelle
    {
        DbManager dm = new DbManager(false);

        public int semtGuncelleId(int semtId, string semtAd, int ilceId)
        {
            int sonuc = 0;
            try
            {
                dm.AddInParameters("@smtId", SqlDbType.Int, semtId);
                dm.AddInParameters("@smtAd", SqlDbType.NVarChar, semtAd);
                dm.AddInParameters("@ilceId",SqlDbType.Int,ilceId);
                sonuc = dm.ExecuteNonQuery("update Semt set SemtAd = @smtAd, IlceId = @ilceId where SemtId = @smtId", CommandType.Text);
            }
            catch (Exception)
            {

            }

            return sonuc;
        }
    }
}
