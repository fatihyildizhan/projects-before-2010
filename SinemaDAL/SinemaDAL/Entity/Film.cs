using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace SinemaDAL.Entity
{
    public class Film
    {
        #region construstor
        public Film()
        { }
        #endregion

        #region fields
        int filmId;
        string filmAd;
        string filmAciklama;
        int kategoriId;
        int sure;
        #endregion

        #region properties
        public int FilmId
        {
            get { return filmId; }
            set { filmId = value;}
        }
        public string FilmAd
        {
            get { return filmAd; }
            set { filmAd = value; }
        }
        public string FilmAciklama
        {
            get { return filmAciklama; }
            set { filmAciklama = value; }
        }
        public int KategoriId
        {
            get { return kategoriId; }
            set { kategoriId = value; }
        }        
        public int Sure
        {
            get { return sure; }
            set { sure = value; }
        }
        #endregion
        #region methods
        public override string ToString()
        {
            return filmAd;
        }
        #endregion
    }
}
