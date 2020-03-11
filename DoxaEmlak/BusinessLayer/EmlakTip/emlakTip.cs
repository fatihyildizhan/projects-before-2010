using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BusinessLayer
{
    public class emlakTip
    {
        int emlakTipId;

        public int EmlakTipId
        {
            get { return emlakTipId; }
            set { emlakTipId = value; }
        }
        string emlakTipAd;

        public string EmlakTipAd
        {
            get { return emlakTipAd; }
            set { emlakTipAd = value; }
        }
    }
}
