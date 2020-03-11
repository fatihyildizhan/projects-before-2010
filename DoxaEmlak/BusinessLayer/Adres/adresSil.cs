using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace BusinessLayer
{
    public class adresSil
    {
        DbManager dm = new DbManager(false);

        public int adresSilId(int gelenId)
        {
            dm.AddInParameters("@emlakId", SqlDbType.Int, gelenId);
            int sonuc = dm.ExecuteNonQuery("delete from Adres where EmlakId = @emlakId", CommandType.Text);
            return sonuc;
        }
    }
}
