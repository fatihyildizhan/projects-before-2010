using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ParmakYarisiApiDbLayer
{
    public static class pyApiUpdateXP
    {
        public static UserDetail pyUpdateXP(Guid myUserID, int myXP)
        {
            UserDetail myNewUserDetail = null;
            try
            {
                using (ParmakYarisiDBDataContext DB = new ParmakYarisiDBDataContext())
                {
                    UserDetail myUserDetail = (from u in DB.UserDetails
                                               where u.UserID == myUserID
                                               select u).Single();
                    myUserDetail.UserXP += myXP;
                    DB.SubmitChanges();

                    myNewUserDetail = myUserDetail;
                }
            }
            catch (Exception ex)
            {
                CatchExLinqToApiOnDBLayer.myCatchException(ex, "pyUpdateXP");
            }

            return myNewUserDetail;
        }
    }
}
