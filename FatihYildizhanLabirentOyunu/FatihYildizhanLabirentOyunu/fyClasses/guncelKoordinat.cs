using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;

namespace FatihYildizhanLabirentOyunu
{
    public class guncelKoordinat
    {
        private Point koordinat;

        public Point Koordinat
        {
            get { return koordinat; }
            set { koordinat = value; }
        }

        public guncelKoordinat(double x, double y)
        {
            koordinat = new Point(x,y);
        }

        public string gckIsimDondur()
        {
            return koordinat.X + ";" + koordinat.Y;
        }
       
    }
}
