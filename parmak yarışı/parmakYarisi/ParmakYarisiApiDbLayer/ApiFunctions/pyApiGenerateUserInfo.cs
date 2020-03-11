using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ParmakYarisiApiDbLayer
{
    public class pyApiGenerateUserInfo
    {
        public UserInfo ApiGenerateUserInfo(User myUser)
        {
            UserInfo existUserInfo = new UserInfo();
            try
            {
                using (ParmakYarisiDBDataContext DB = new ParmakYarisiDBDataContext())
                {
                    var query = from selectedUserDetail in DB.UserDetails
                                where selectedUserDetail.UserID == myUser.UserID
                                select selectedUserDetail;

                    foreach (UserDetail d in query)
                    {
                        existUserInfo.UserCityInfo = d.City;
                        existUserInfo.UserLevelInfo = d.Level;
                    }
                }
            }
            catch (Exception ex)
            {
                CatchExLinqToApiOnDBLayer.myCatchException(ex, "ApiGenerateUserInfo");
                return null;
            }
            return existUserInfo;
        }
    }
}
