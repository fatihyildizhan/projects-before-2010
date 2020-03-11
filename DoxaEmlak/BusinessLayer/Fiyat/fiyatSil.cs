using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace BusinessLayer
{
    public class fiyatSil
    {
        DbManager dm = new DbManager(false);

        public int fiyatSilEmlakId(int gelenId)
        {
            dm.AddInParameters("@emlakId", SqlDbType.Int, gelenId);
            int sonuc = dm.ExecuteNonQuery("delete from Fiyat where EmlakId = @emlakId", CommandType.Text);
            return sonuc;
        }
    }
}
