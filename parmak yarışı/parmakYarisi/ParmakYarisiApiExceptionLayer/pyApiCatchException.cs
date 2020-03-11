using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ParmakYarisiApiExceptionLayer
{
    public class pyApiCatchException
    {

        // kullanicinin internete bagli oldugu ip yi almayi dene ?
        
        /// <summary>
        /// Catch All Exception and send the methods.
        /// </summary>
        /// <param name="myEx"></param>
        public void pyCatchException(Exception myEx, string functionName)
        { 
            // eger beklenmeyen hataysa db ye yaz

            // eger saldiri hatasiysa, injection gibi admine email at.
        }

        private void pySendExceptionDB(Exception myEx)
        { 
         // Send DB
        }

        private void pySendExceptionEmail(Exception myEx)
        { 
        // Send Email to Admin
        }
    }
}