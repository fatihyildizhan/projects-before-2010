using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace BusinessLayer
{
    public class kategoriSil
    {
        DbManager dm = new DbManager(false);

        public int kategoriSilId(int gelenId)
        {
            dm.AddInParameters("@kategoriId", SqlDbType.Int, gelenId);
            int sonuc = dm.ExecuteNonQuery("delete from Kategori where KategoriId = @kategoriId", CommandType.Text);
            
            return sonuc;
        }
    }
}
