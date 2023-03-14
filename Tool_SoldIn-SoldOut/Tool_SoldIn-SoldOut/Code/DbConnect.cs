using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Odbc;
using System.Linq;
using System.Text;

namespace Tool_SoldIn_SoldOut.Code
{
    class DbConnect
    {
        private static OdbcConnection _instance = null;
        private DbConnect()
        {
        }

        public static OdbcConnection getInstance()
        {
            if (_instance == null)
            {
                _instance = new OdbcConnection(ConfigurationManager.ConnectionStrings["ODBC_Connection"].ConnectionString);
            }
            return _instance;
        }
    }
}
