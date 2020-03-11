using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace BusinessLayer
{
    public class adresGuncelle
    {
        DbManager dm = new DbManager(false);

        public int adresGuncelleId(adres gelenA)
        {
            int sonuc = 0;
            try
            {
                dm.AddInParameters("@emlakId",SqlDbType.Int,gelenA.EmlakId);
                dm.AddInParameters("@sehirId",SqlDbType.Int,gelenA.SehirId);
                dm.AddInParameters("@ilceId",SqlDbType.Int,gelenA.IlceId);
                dm.AddInParameters("@semtId",SqlDbType.Int,gelenA.SemtId);
                dm.AddInParameters("@adresTarifi",SqlDbType.NVarChar,gelenA.AdresTarifi);
                dm.AddInParameters("@cdId",SqlDbType.Int,gelenA.CaddeId);
                sonuc = dm.ExecuteNonQuery("update Adres set SehirId = @sehirId, IlceId = @ilceId, SemtId = @semtId, AdresTarifi = @adresTarifi, CaddeId = @cdId where EmlakId = @emlakId", CommandType.Text);
            }
            catch (Exception ex)
            {

            }

            return sonuc;
        }
    }
}
