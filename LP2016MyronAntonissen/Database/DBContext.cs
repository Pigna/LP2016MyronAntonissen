using System;
using System.Collections.Generic;
using Oracle.ManagedDataAccess.Client;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LP2016MyronAntonissen.Database
{
    class DBContext
    {
        //fields
        protected OracleConnection con = new OracleConnection();

        /// <summary>
        /// doQuery
        /// </summary>
        /// <returns></returns>
        protected DBContext()
        {
            con.ConnectionString = "Data Source=localhost;Persist Security Info=True;User ID=system;Password=system";
        }
    }
}
