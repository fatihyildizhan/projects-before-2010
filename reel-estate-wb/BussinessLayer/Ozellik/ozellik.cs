using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BussinessLayer
{
    public class Ozellik
    {
        int ozellikId;

        public int OzellikId
        {
            get { return ozellikId; }
            set { ozellikId = value; }
        }
        string ozellikAdi;

        public string OzellikAdi
        {
            get { return ozellikAdi; }
            set { ozellikAdi = value; }
        }

        public override string ToString()
        {
            return OzellikAdi;
        }

    }
}
