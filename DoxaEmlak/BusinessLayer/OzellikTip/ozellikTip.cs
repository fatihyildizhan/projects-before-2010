using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BusinessLayer
{
    public class ozellikTip
    {
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
    }
}
