using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BusinessLayer
{
    public class fiyat
    {
        int emlakId;

        public int EmlakId
        {
            get { return emlakId; }
            set { emlakId = value; }
        }
        int tl;

        public int Tl
        {
            get { return tl; }
            set { tl = value; }
        }
        int euro;

        public int Euro
        {
            get { return euro; }
            set { euro = value; }
        }
        int dolar;

        public int Dolar
        {
            get { return dolar; }
            set { dolar = value; }
        }
        int pound;

        public int Pound
        {
            get { return pound; }
            set { pound = value; }
        }
    }
}
