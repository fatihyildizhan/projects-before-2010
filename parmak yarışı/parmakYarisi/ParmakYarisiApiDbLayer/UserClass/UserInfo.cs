using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ParmakYarisiApiDbLayer
{
    public class UserInfo
    {
        /// <summary>
        /// tbl Level;
        /// </summary>
        Level userLevelInfo;

        public Level UserLevelInfo
        {
            get { return userLevelInfo; }
            set { userLevelInfo = value; }
        }

        /// <summary>
        /// tbl City;
        /// </summary>
        City userCityInfo;

        public City UserCityInfo
        {
            get { return userCityInfo; }
            set { userCityInfo = value; }
        }
      
    }
}
