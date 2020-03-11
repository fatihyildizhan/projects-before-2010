using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BussinessLayer.EmlakTip
{
    public class emlakTip
    {
        int emlakTipId;

        public int EmlakTipId
        {
            get { return emlakTipId; }
            set { emlakTipId = value; }
        }
        string emlakTipIsim;

        public string EmlakTipIsim
        {
            get { return emlakTipIsim; }
            set { emlakTipIsim = value; }
        }
    }
}
