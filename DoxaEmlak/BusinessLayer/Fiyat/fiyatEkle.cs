using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace BusinessLayer
{
    public class fiyatEkle
    {
        DbManager dm = new DbManager(false);

        public int fiyatEkleString(int emlakId, int tl, int euro, int dolar, int pound)
        {
            dm.AddInParameters("@emlakId",SqlDbType.Int,emlakId);
            dm.AddInParameters("@tl",SqlDbType.Int,tl);
            dm.AddInParameters("@euro",SqlDbType.Int,euro);
            dm.AddInParameters("@dolar",SqlDbType.Int,dolar);
            dm.AddInParameters("@pound",SqlDbType.Int,pound);
            int sonuc = dm.ExecuteNonQuery("insert into Fiyat values(@emlakId,@tl,@euro,@dolar,@pound)", CommandType.Text);

            return sonuc;
        }
    }
}
