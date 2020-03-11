using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ParmakYarisiApiExceptionLayer;

namespace parmakYarisi
{
    public static class CatchExLinqToApi
    {
        static pyApiCatchException myCatchApi = new pyApiCatchException();

        public static void myCatchException(Exception myEx, string myFunctionName)
        {
            myCatchApi.pyCatchException(myEx, myFunctionName);
        }
    }
}
