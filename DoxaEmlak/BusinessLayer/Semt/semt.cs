using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BusinessLayer
{
    public class semt
    {
        int semtId;

        public int SemtId
        {
            get { return semtId; }
            set { semtId = value; }
        }
        string semtAd;

        public string SemtAd
        {
            get { return semtAd; }
            set { semtAd = value; }
        }
        int ilceId;

        public int IlceId
        {
            get { return ilceId; }
            set { ilceId = value; }
        }
    }
}
