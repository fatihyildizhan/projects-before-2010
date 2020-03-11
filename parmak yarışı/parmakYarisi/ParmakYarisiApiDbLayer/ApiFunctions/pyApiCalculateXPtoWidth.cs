using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ParmakYarisiApiDbLayer
{
    public class pyApiCalculateXPtoWidth
    {
        public int ApiCalculateXPtoWidth(UserDetail myUserDetail, UserInfo myUserInfo)
        {
            int width = 1;
            try
            {
                using (ParmakYarisiDBDataContext DB = new ParmakYarisiDBDataContext())
                {
                    var query = from allLevel in DB.Levels
                                where allLevel.LevelID == myUserInfo.UserLevelInfo.LevelID - 1
                                select allLevel;

                    foreach (Level l in query)
                    {

                        width = 100 * (myUserDetail.UserXP - l.LevelRequiredXP) / (myUserInfo.UserLevelInfo.LevelRequiredXP - l.LevelRequiredXP);
                        int a = 3;
                        break;
                    }
                }
            }
            catch (Exception ex)
            {
                CatchExLinqToApiOnDBLayer.myCatchException(ex, "ApiCalculateXPtoWidth");
            }
            return width;
        }
    }
}
