using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Collections;

namespace BusinessLayer
{
    public class emlakOzellikEkle
    {
        DbManager dm = new DbManager(false);

        public int emlakOzellikEkleString(ArrayList ozellikIdLer, int emlakId)
        {
            int sonuc = 0;
            try
            {
                foreach (string item in ozellikIdLer)
                {
                    dm.AddInParameters("@ozellikId", SqlDbType.Int, Convert.ToInt32(item));
                    dm.AddInParameters("@emlakId", SqlDbType.Int, emlakId);
                    int sayi = dm.ExecuteNonQuery("prcEmlakOzellikEkle", CommandType.StoredProcedure);
                    if (sayi > 0)
                    {
                        sonuc += sayi;
                    }
                    dm.ClearParameters();
                }
            }
            catch (Exception ex)
            {

            }

            return sonuc;
        }
    }
}
