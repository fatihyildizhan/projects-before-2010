using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ParmakYarisiApiDbLayer
{
    public class pyApiFindUserDetail
    {
        public UserDetail ApiFindUserDetail(User myUser)
        {
            UserDetail existUserDetail = new UserDetail();
            try
            {
                using (ParmakYarisiDBDataContext DB = new ParmakYarisiDBDataContext())
                {
                    var query = from selectedUserDetail in DB.UserDetails
                                where selectedUserDetail.UserID == myUser.UserID
                                select selectedUserDetail;

                    foreach (UserDetail d in query)
                    {
                        existUserDetail = d;
                    }
                }
            }
            catch (Exception ex)
            {
                CatchExLinqToApiOnDBLayer.myCatchException(ex, "ApiFindUserDetail");
                return null;
            }
            return existUserDetail;
        }
    }
}
