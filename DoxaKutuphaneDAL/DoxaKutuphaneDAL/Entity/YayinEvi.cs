using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DoxaKutuphaneDAL.Entity
{
    public  class YayinEvi
    {
        #region fields
        int yayinEviId;
        string yayinEviAd;
        string yayinEviAdres;
        #endregion

        #region properties
        public int YayinEviId
        {
            get { return yayinEviId; }
            set { yayinEviId = value; }
        }
        public string YayinEviAd
        {
            get { return yayinEviAd; }
            set { yayinEviAd = value; }
        }
        public string YayinEviAdres
        {
            get { return yayinEviAdres; }
            set { yayinEviAdres = value; }
        }
        #endregion

        #region methods
        public override string ToString()
        {
            return yayinEviAd;
        }
        #endregion
    }
}
