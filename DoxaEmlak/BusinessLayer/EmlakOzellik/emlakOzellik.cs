using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BusinessLayer
{
    public class emlakOzellik
    {
        int emlakId;

        public int EmlakId
        {
            get { return emlakId; }
            set { emlakId = value; }
        }
        int ozellikId;

        public int OzellikId
        {
            get { return ozellikId; }
            set { ozellikId = value; }
        }
        string ozellikAd;

        public string OzellikAd
        {
            get { return ozellikAd; }
            set { ozellikAd = value; }
        }
    }
}
