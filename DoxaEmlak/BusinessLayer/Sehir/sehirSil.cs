using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace BusinessLayer
{
    public class sehirSil
    {
        DbManager dm = new DbManager(false);

        public int sehirSilId(int gelenId)
        {
            dm.AddInParameters("@shrId", SqlDbType.Int, gelenId);
            int sonuc = dm.ExecuteNonQuery("delete from Sehir where SehirId = @shrId", CommandType.Text);
            return sonuc;
        }
    }
}
