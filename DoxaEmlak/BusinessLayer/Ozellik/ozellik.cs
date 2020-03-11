using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BusinessLayer
{
    public class ozellik
    {
        int ozellikId;

        public int OzellikId
        {
            get { return ozellikId; }
            set { ozellikId = value; }
        }
        int ozellikTipId;

        public int OzellikTipId
        {
            get { return ozellikTipId; }
            set { ozellikTipId = value; }
        }
        string ozellikTipAd;

        public string OzellikTipAd
        {
            get { return ozellikTipAd; }
            set { ozellikTipAd = value; }
        }

        string ozellikAd;

        public string OzellikAd
        {
            get { return ozellikAd; }
            set { ozellikAd = value; }
        }
    }
}
