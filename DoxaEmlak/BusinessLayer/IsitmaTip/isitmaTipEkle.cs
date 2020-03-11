using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace BusinessLayer
{
    public class isitmaTipEkle
    {
        DbManager dm = new DbManager(false);

        public int isitmaTipEkleString(string isitmaTipAd)
        {
            dm.AddInParameters("@isitmaTipAd", SqlDbType.NVarChar, isitmaTipAd);
            int sonuc = dm.ExecuteNonQuery("insert into IsitmaTip values(@isitmaTipAd)", CommandType.Text);

            return sonuc;
        }
    }
}
