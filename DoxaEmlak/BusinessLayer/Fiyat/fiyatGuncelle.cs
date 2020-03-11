using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace BusinessLayer
{
    public class fiyatGuncelle
    {
        DbManager dm = new DbManager(false);

        public int fiyatGuncelleEmlakId(int emlakId, int tl, int euro, int dolar, int pound)
        {
            int sonuc = 0;
            try
            {
                dm.AddInParameters("@emlakId",SqlDbType.Int,emlakId);
                dm.AddInParameters("@tl",SqlDbType.Int,tl);
                dm.AddInParameters("@euro",SqlDbType.Int,euro);
                dm.AddInParameters("@dolar",SqlDbType.Int,dolar);
                dm.AddInParameters("@pound",SqlDbType.Int,pound);
                sonuc = dm.ExecuteNonQuery("update Fiyat set TL = @tl, Euro=@euro, Dolar=@dolar, Pound=@pound where EmlakId = @emlakId", CommandType.Text);
            }
            catch (Exception ex)
            {

            }

            return sonuc;
        }
    }
}
