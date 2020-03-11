using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BusinessLayer
{
    public class adres
    {
        #region fields
        int emlakId;
        int sehirId;
        int ilceId;
        int semtId;
        int caddeId;

        
        string adresTarifi;
        string sehirAd;
        string ilceAd;
        string semtAd;
        string caddeAd;

        
        #endregion

        #region properties
        public int EmlakId
        {
            get { return emlakId; }
            set { emlakId = value; }
        }
        
        public int SehirId
        {
            get { return sehirId; }
            set { sehirId = value; }
        }
 
        public int IlceId
        {
            get { return ilceId; }
            set { ilceId = value; }
        }
        
        public int SemtId
        {
            get { return semtId; }
            set { semtId = value; }
        }
        public int CaddeId
        {
            get { return caddeId; }
            set { caddeId = value; }
        }
        public string AdresTarifi
        {
            get { return adresTarifi; }
            set { adresTarifi = value; }
        }    

        public string SehirAd
        {
            get { return sehirAd; }
            set { sehirAd = value; }
        }
        
        public string IlceAd
        {
            get { return ilceAd; }
            set { ilceAd = value; }
        }
        
        public string SemtAd
        {
            get { return semtAd; }
            set { semtAd = value; }
        }
        public string CaddeAd
        {
            get { return caddeAd; }
            set { caddeAd = value; }
        }
        #endregion

    }
}
