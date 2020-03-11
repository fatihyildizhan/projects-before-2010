using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ParmakYarisiApiDbLayer
{
    public static class pyApiCalculateXPtoLevel
    {
        public static UserDetail ApiCalculateXPtoLevel(UserDetail myUserDetail, UserInfo myUserInfo)
        {
            UserDetail newMyUserDetail = null;

            // Kullanicinin son XP'si level atlamak icin yeterliyse burasi calisir.
            // Aksi halde bir islem yapilmaz. Eski levelName geri doner.
            try
            {
                if (myUserDetail.UserXP > myUserInfo.UserLevelInfo.LevelRequiredXP)
                {
                    using (ParmakYarisiDBDataContext DB = new ParmakYarisiDBDataContext())
                    {
                        var query = from allLevel in DB.Levels
                                    where allLevel.LevelID == myUserInfo.UserLevelInfo.LevelID + 1
                                    select allLevel;

                        foreach (Level l in query)
                        {
                            UserDetail newUserDetail = (from u in DB.UserDetails
                                                        where u.UserID == myUserDetail.UserID
                                                        select u).Single();
                            newUserDetail.UserLevelID = l.LevelID;
                            DB.SubmitChanges();

                            newMyUserDetail = newUserDetail;
                            break;
                        }
                    }
                }
                else
                {
                    return myUserDetail;
                }
            }
            catch (Exception ex)
            {
                CatchExLinqToApiOnDBLayer.myCatchException(ex, "ApiCalculateXPtoLevel");
            }
            return newMyUserDetail;
        }
    }
}
