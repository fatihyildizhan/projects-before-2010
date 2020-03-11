using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace BusinessLayer
{
    public class ozellikSil
    {
        DbManager dm = new DbManager(false);

        public int ozellikSilId(int gelenId)
        {
            dm.AddInParameters("@oId", SqlDbType.Int, gelenId);
            int sonuc = dm.ExecuteNonQuery("delete from Ozellik where OzellikId = @oId", CommandType.Text);

            return sonuc;
        }
    }
}
