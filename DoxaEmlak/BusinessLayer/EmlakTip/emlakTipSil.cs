using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace BusinessLayer
{
    public class emlakTipSil
    {
        DbManager dm = new DbManager(false);

        public int emlakTipSilId(int gelenId)
        {
            int sonuc = 0;

            try
            {
                dm.AddInParameters("@emlakTipId", SqlDbType.Int, gelenId);
                sonuc = dm.ExecuteNonQuery("delete from EmlakTip where EmlakTipId = @emlakTipId", CommandType.Text);
            }
            catch (Exception ex)
            {

            }
            return sonuc;
        }
    }
}
