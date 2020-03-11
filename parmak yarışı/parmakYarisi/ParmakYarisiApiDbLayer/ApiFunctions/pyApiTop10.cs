using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ParmakYarisiApiExceptionLayer;

namespace ParmakYarisiApiDbLayer
{
    public class pyApiTop10
    {
        public String[,] pyGetTopTen()
        {
            try
            {
                String[,] topTen = new String[10, 2];
                int count = 0;
                using (ParmakYarisiDBDataContext DB = new ParmakYarisiDBDataContext())
                {
                    var query = from ud in DB.UserDetails
                                join u in DB.Users on ud.UserID equals u.UserID
                                orderby ud.UserXP descending
                                select new
                                {
                                    u.UserNickname,
                                    ud.UserXP
                                };

                    foreach (var u in query)
                    {
                        topTen[count, 0] = u.UserNickname;
                        topTen[count, 1] = u.UserXP.ToString();
                        count++;
                    }
                    return topTen;
                }
            }
            catch (Exception ex)
            {
                CatchExLinqToApiOnDBLayer.myCatchException(ex, "pyGetTopTen()");
                return null;
            }
        }
    }
}
