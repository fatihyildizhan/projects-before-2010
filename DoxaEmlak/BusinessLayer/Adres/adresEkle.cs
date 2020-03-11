using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace BusinessLayer
{
    public class adresEkle
    {
        DbManager dm = new DbManager(false);

        public int adresEkleString(adres a)
        {
            dm.AddInParameters("@emlakId",SqlDbType.Int,a.EmlakId);
            dm.AddInParameters("@shrId",SqlDbType.Int,a.SehirId);
            dm.AddInParameters("@ilceId",SqlDbType.Int,a.IlceId);
            dm.AddInParameters("@smtId",SqlDbType.Int,a.SemtId);
            dm.AddInParameters("@adresTarifi",SqlDbType.NVarChar,a.AdresTarifi);
            dm.AddInParameters("@cdId",SqlDbType.Int,a.CaddeId);
            int sonuc = dm.ExecuteNonQuery("insert into Adres values(@emlakId,@shrId,@ilceId,@smtId,@adresTarifi,@cdId)", CommandType.Text);

            return sonuc;
        }
    }
}
