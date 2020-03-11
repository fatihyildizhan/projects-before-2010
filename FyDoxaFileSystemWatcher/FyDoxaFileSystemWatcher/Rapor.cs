using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FyDoxaFileSystemWatcher
{
    class Rapor
    {
        string islemTipi;

        public string IslemTipi
        {
            get { return islemTipi; }
            set { islemTipi = value; }
        }
        string islemTarihi;

        public string IslemTarihi
        {
            get { return islemTarihi; }
            set { islemTarihi = value; }
        }
        string islemAdi;

        public string IslemAdi
        {
            get { return islemAdi; }
            set { islemAdi = value; }
        }
        string fullPath;

        public string FullPath
        {
            get { return fullPath; }
            set { fullPath = value; }
        }
        

    }
}
