using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
namespace DoxaMarina
{
    class Yat
    {
        public static ArrayList yatListesi = new ArrayList();
        public static int IdSayac = 1;
        #region constructers
        public Yat()
        { 
            this.yatId = IdSayac = 1; IdSayac++;
        }
        public Yat(string pYatAd, int pYatBoy, int pKabinSayisi,int pIskeleId)
        {
            this.yatId = IdSayac = 1;
            this.yatAdı = pYatAd;
            this.yatBoyu = pYatBoy;
            this.kabinSayisi = pKabinSayisi;
            this.IskeleId = pIskeleId;
            IdSayac++;
        }
        #endregion

        #region fields
        private int yatId;
        private string yatAdı;
        private int yatBoyu;
        private int kabinSayisi;
        private int iskeleId;
        #endregion
        
        #region properties
        public  int YatId
        {
            get { return yatId; }
        }
        
        public string YatAdı
        {
            get { return yatAdı; }
            set { yatAdı = value; }
        }
        
        public int YatBoyu
        {
            get { return yatBoyu; }
            set { yatBoyu = value; }
        }
        
        public int KabinSayisi
        {
            get { return kabinSayisi; }
            set { kabinSayisi = value; }
        }
        
        public int IskeleId
        {
            get { return iskeleId; }
            set { iskeleId = value; }
        }
        #endregion

        #region methods
        public static bool IskeleIdKontrol(int iskeleId)
        {
            bool kontrol = true;
            foreach (Yat item in yatListesi)
            {
                if (item.IskeleId == iskeleId)
                {
                    kontrol = false;
                    break;
                }
            }
            return kontrol;
        }
        public override string ToString()
        {
            return kabinSayisi.ToString();
        }
        #endregion
    }
}
