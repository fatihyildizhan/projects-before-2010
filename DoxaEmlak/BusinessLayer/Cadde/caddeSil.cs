using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace BusinessLayer
{
    public class caddeSil
    {
        DbManager dm = new DbManager(false);

        public int caddeSilId(int gelenId)
        {
            dm.AddInParameters("@cdId", SqlDbType.Int, gelenId);
            int sonuc = dm.ExecuteNonQuery("delete from Cadde where CaddeId = @cdId", CommandType.Text);
            return sonuc;
        }
    }
}
