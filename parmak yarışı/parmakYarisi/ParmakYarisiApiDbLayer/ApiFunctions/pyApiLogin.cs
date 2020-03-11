using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ParmakYarisiApiExceptionLayer;

namespace ParmakYarisiApiDbLayer
{
    public class pyApiLogin
    {
        public User pyLogin(string myEmail, string myPassword)
        {
            User existUser = new User();
            try
            {
                using (ParmakYarisiDBDataContext DB = new ParmakYarisiDBDataContext())
                {
                    var query = from selectedUser in DB.Users
                                where selectedUser.UserEmail == myEmail
                                where selectedUser.UserPassword == myPassword
                                select selectedUser;

                    foreach (User u in query)
                    {
                        return u;
                    }
                }
                return null;
            }
            catch (Exception ex)
            {
                CatchExLinqToApiOnDBLayer.myCatchException(ex, "pyLogin(string myEmail, string myPassword)");
                return null;
            }
        }
    }
}
