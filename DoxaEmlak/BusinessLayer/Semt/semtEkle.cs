using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace BusinessLayer
{
    public class semtEkle
    {
        DbManager dm = new DbManager(false);

        public int semtEkleString(string gelenSemtAd, int ilceId)
        {
            dm.AddInParameters("@gelenSemtAd", SqlDbType.NVarChar, gelenSemtAd);
            dm.AddInParameters("@ilceId", SqlDbType.Int, ilceId);
            int sonuc = dm.ExecuteNonQuery("insert into Semt values(@gelenSemtAd,@ilceId)", CommandType.Text);
            
            return sonuc;
        }
    }
}
