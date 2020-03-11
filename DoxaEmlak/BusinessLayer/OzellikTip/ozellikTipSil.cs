using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace BusinessLayer
{
    public class ozellikTipSil
    {
        DbManager dm = new DbManager(false);

        public int ozellikTipSilId(int gelenId)
        {
            dm.AddInParameters("@oId", SqlDbType.Int, gelenId);
            int sonuc = dm.ExecuteNonQuery("delete from OzellikTip where OzellikTipId = @oId", CommandType.Text);

            return sonuc;
        }
    }
}
