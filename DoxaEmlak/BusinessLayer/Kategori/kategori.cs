using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BusinessLayer
{
    public class kategori
    {
        int kategoriId;

        public int KategoriId
        {
            get { return kategoriId; }
            set { kategoriId = value; }
        }
        string kategoriAd;

        public string KategoriAd
        {
            get { return kategoriAd; }
            set { kategoriAd = value; }
        }
    }
}
