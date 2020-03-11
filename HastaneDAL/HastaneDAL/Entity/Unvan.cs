using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HastaneDAL.Entity
{
    public class Unvan
    {
        int unvanId;
        string unvanAd;

        public int UnvanId
        {
            get { return unvanId; }
            set { unvanId = value; }
        }
       

        public string UnvanAd
        {
            get { return unvanAd; }
            set { unvanAd = value; }
        }

    }
}
