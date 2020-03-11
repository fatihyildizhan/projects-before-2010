using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MiniOtobus
{
    class Sehir
    {
        public int SehirId { get; set; }
        public string SehirAd { get; set; }


        public override string ToString()
        {
            return SehirAd;
        }
    }
}
