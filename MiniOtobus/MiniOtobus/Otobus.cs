using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MiniOtobus
{
    class Otobus
    {
        public int OtobusId { get; set; }
        public string Marka { get; set; }
        public string Plaka { get; set; }
        public int Kapasite { get; set; }


        public override string ToString()
        {
            return Plaka;
        }
    }
}
