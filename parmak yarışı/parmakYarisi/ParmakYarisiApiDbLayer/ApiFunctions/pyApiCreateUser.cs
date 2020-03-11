using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ParmakYarisiApiExceptionLayer;

namespace ParmakYarisiApiDbLayer
{
    public class pyApiCreateUser
    {
        public int pyCreateUser(User myNewUser)
        {
            try
            {
                using (ParmakYarisiDBDataContext DB = new ParmakYarisiDBDataContext())
                {
                    DB.Users.InsertOnSubmit(myNewUser);
                    DB.SubmitChanges();

                    UserDetail myNewUserDetail = new UserDetail();
                    myNewUserDetail.UserID = myNewUser.UserID;
                    myNewUserDetail.UserXP = 0;
                    myNewUserDetail.UserPoint = 0;
                    myNewUserDetail.UserLevelID = 1;
                    myNewUserDetail.UserCityID = 1;
                    DB.UserDetails.InsertOnSubmit(myNewUserDetail);
                    DB.SubmitChanges();
                }
            }
            catch (Exception ex)
            {
                CatchExLinqToApiOnDBLayer.myCatchException(ex, "pyCreateUser");
                return 0;
            }
            return 1;
        }
    }
}
