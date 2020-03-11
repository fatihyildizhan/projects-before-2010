using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace BusinessLayer
{
    public class ilceSil
    {
        DbManager dm = new DbManager(false);

        public int ilceSilId(int gelenId)
        {
            int sonuc = 0;
            try
            {
                dm.AddInParameters("@ilceId", SqlDbType.Int, gelenId);
                sonuc = dm.ExecuteNonQuery("delete from Ilce where IlceId = @ilceId", CommandType.Text);
            }
            catch (Exception ex)
            {

            }
            return sonuc;
        }
    }
}
