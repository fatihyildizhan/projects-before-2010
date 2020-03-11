using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BussinessLayer
{
    public class Emlak
    {
        int emlakId;

        public int EmlakId
        {
            get { return emlakId; }
            set { emlakId = value; }
        }
        string emlakTuru;

        public string EmlakTuru
        {
            get { return emlakTuru; }
            set { emlakTuru = value; }
        }
        int emlakTipId;

        public int EmlakTipId
        {
            get { return emlakTipId; }
            set { emlakTipId = value; }
        }
        string emlakBoyut;

        public string EmlakBoyut
        {
            get { return emlakBoyut; }
            set { emlakBoyut = value; }
        }
    }
}
