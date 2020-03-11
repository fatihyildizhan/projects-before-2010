using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace BusinessLayer
{
    public class emlakOzellikSil
    {
        DbManager dm = new DbManager(false);

        public int emlakOzellikSilIdler(int gelenEmlakId, List<int> ozellikIdleri)
        {
            int sonuc = 0;

            try
            {
                foreach (int ozlId in ozellikIdleri)
                {
                    dm.AddInParameters("@emlakId", SqlDbType.Int, gelenEmlakId);
                    dm.AddInParameters("@ozellikId", SqlDbType.Int, ozlId);
                    sonuc += dm.ExecuteNonQuery("delete EmlakOzellik where EmlakId = @emlakId and OzellikId = @ozellikId", CommandType.Text);
                    dm.ClearParameters();
                }
            }
            catch (Exception ex)
            {

            }

            return sonuc;
        }

        public int emlakOzellikSilId(int gelenEmlakId)
        {
            int sonuc = 0;

            try
            {
                dm.AddInParameters("@emlakId", SqlDbType.Int, gelenEmlakId);
                sonuc += dm.ExecuteNonQuery("delete EmlakOzellik where EmlakId = @emlakId", CommandType.Text);
                dm.ClearParameters();
            }
            catch (Exception ex)
            {

                throw;
            }


            return sonuc;
        }
    }
}
