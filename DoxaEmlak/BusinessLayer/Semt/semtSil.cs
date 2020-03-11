using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace BusinessLayer
{
    public class semtSil
    {
        DbManager dm = new DbManager(false);

        public int semtSilId(int gelenId)
        {
            dm.AddInParameters("@smtId", SqlDbType.Int, gelenId);
            int sonuc = dm.ExecuteNonQuery("delete from Semt where SemtId = @smtId", CommandType.Text);
            return sonuc;
        }
    }
}
