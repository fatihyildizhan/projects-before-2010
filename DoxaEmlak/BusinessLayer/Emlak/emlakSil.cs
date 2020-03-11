using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace BusinessLayer
{
    public class emlakSil
    {
        DbManager dm = new DbManager(false);

        public int emlakSilMetod(int gelenEmlakId)
        {
            int sonuc = 0;

            /*
             delete Adres where EmlakId =
             delete Fiyat where EmlakId =
             delete Resim where EmlakId = 
             delete EmlakOzellik where EmlakId =
             delete Emlak where EmlakId = 
             */

            try
            {
                dm.AddInParameters("@emlakId", SqlDbType.Int, gelenEmlakId);
                int sonucAdres = dm.ExecuteNonQuery("delete from Adres where EmlakId = @emlakId", CommandType.Text);
                dm.ClearParameters();
                if (sonucAdres > 0)
                {
                    sonuc++;
                }
                else
                {
                    dm.AddInParameters("@emlakId", SqlDbType.Int, gelenEmlakId);
                    dm.ExecuteNonQuery("delete from Adres where EmlakId = @emlakId", CommandType.Text);
                    dm.ClearParameters();
                }

                dm.AddInParameters("@emlakId", SqlDbType.Int, gelenEmlakId);
                int sonucFiyat = dm.ExecuteNonQuery("delete from Fiyat where EmlakId = @emlakId", CommandType.Text);
                dm.ClearParameters();
                if (sonucFiyat > 0)
                {
                    sonuc++;
                }
                else
                {
                    dm.AddInParameters("@emlakId", SqlDbType.Int, gelenEmlakId);
                    dm.ExecuteNonQuery("delete from Fiyat where EmlakId = @emlakId", CommandType.Text);
                    dm.ClearParameters();
                }

                dm.AddInParameters("@emlakId", SqlDbType.Int, gelenEmlakId);
                int sonucResim = dm.ExecuteNonQuery("delete from Resim where EmlakId = @emlakId", CommandType.Text);
                dm.ClearParameters();
                if (sonucResim > 0)
                {
                    sonuc++;
                }
                else
                {
                    dm.AddInParameters("@emlakId", SqlDbType.Int, gelenEmlakId);
                    dm.ExecuteNonQuery("delete from Resim where EmlakId = @emlakId", CommandType.Text);
                    dm.ClearParameters();
                }

                dm.AddInParameters("@emlakId", SqlDbType.Int, gelenEmlakId);
                int sonucEmlakOzellik = dm.ExecuteNonQuery("delete from EmlakOzellik where EmlakId = @emlakId", CommandType.Text);
                dm.ClearParameters();
                if (sonucEmlakOzellik > 0)
                {
                    sonuc++;
                }
                else
                {
                    dm.AddInParameters("@emlakId", SqlDbType.Int, gelenEmlakId);
                    dm.ExecuteNonQuery("delete from EmlakOzellik where EmlakId = @emlakId", CommandType.Text);
                    dm.ClearParameters();
                }

                dm.AddInParameters("@emlakId", SqlDbType.Int, gelenEmlakId);
                int sonucEmlak = dm.ExecuteNonQuery("delete from Emlak where EmlakId = @emlakId", CommandType.Text);
                dm.ClearParameters();
                if (sonucEmlak > 0)
                {
                    sonuc++;
                }
                else
                {
                    dm.AddInParameters("@emlakId", SqlDbType.Int, gelenEmlakId);
                    dm.ExecuteNonQuery("delete from Emlak where EmlakId = @emlakId", CommandType.Text);
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
