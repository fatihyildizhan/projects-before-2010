using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SQLGirisDAL.Entity
{
    public class SQLGiris
    {
        #region constructures
        public SQLGiris()
        { }
        #endregion

        #region fields
        string serverName;
        string databaseName;
        string userName;        
        int userPwd;
        #endregion

        #region properties
        public string ServerName
        {
            get { return serverName; }
            set { serverName = value; }
        }
        public string DatabaseName
        {
            get { return databaseName; }
            set { databaseName = value; }
        }
        public string UserName
        {
            get { return userName; }
            set { userName = value; }
        }
        public int UserPwd
        {
            get { return userPwd; }
            set { userPwd = value; }
        }
        #endregion

    }
}
