using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BusinessLayer
{
    public class ilce
    {
        int ilceId;

        public int IlceId
        {
            get { return ilceId; }
            set { ilceId = value; }
        }
        string ilceAd;

        public string IlceAd
        {
            get { return ilceAd; }
            set { ilceAd = value; }
        }
        int sehirId;

        public int SehirId
        {
            get { return sehirId; }
            set { sehirId = value; }
        }
    }
}
