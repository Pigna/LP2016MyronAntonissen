using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.ManagedDataAccess.Client;

namespace LP2016MyronAntonissen.Database
{
    public class DBAccount : DBContext
    {
        public int LoginCheck(string username, string password)
        {
            using (OracleCommand command = new OracleCommand("login", con))
            {
                try
                {
                    con.Open();
                    command.CommandType = CommandType.StoredProcedure;
                    command.BindByName = true;
                    command.Parameters.Add("t_username", OracleDbType.Varchar2, username, ParameterDirection.Input);
                    command.Parameters.Add("t_password", OracleDbType.Varchar2, password, ParameterDirection.Input);
                    command.Parameters.Add("return", OracleDbType.Int32, ParameterDirection.ReturnValue);
                    command.ExecuteNonQuery();
                    string rt = command.Parameters["return"].Value.ToString();
                    int ret;
                    if (int.TryParse(rt, out ret))
                    {
                        return ret;
                    }
                    return 0;

                }
                catch
                {
                    return 0;
                }
            }
        }

        public Account GetAccountById(int id)
        {
            Account ret = null;
            if (con.State != System.Data.ConnectionState.Open)
            {
                con.Open();
            }
            OracleCommand cmd = new OracleCommand
            {
                Connection = con,
                CommandText = "SELECT id, naam, email, functie FROM MEDEWERKER WHERE ID = :id"
            };
            cmd.Parameters.Add(":id", id);
            OracleDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                int medid = (dr.GetInt32(0));
                string naam = (dr.GetString(1));
                string email = (dr.GetString(2));
                int functie = (dr.GetInt32(3));
                if (functie == 1)
                {
                    ret = new Beheerder(medid, naam, email);
                }
                else
                {
                    ret = new Verhuurder(id, naam, email);
                }
            }
            con.Close();
            return ret;
        }
    }
}
