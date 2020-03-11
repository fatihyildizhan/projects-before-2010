using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace BusinessLayer
{
    public class isitmaTipSil
    {
        DbManager dm = new DbManager(false);

        public int isitmaTipSilId(int gelenId)
        {
            dm.AddInParameters("@isTipId", SqlDbType.Int, gelenId);
            int sonuc = dm.ExecuteNonQuery("delete from IsitmaTip where IsitmaTipId = @isTipId", CommandType.Text);
            return sonuc;
        }
    }
}
