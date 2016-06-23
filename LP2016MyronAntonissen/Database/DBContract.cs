using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.ManagedDataAccess.Client;

namespace LP2016MyronAntonissen.Database
{
    public class DBContract : DBContext
    {
        public List<Huurcontract> GetAllContract() //name of ur query
        {
            List<Huurcontract> ret = new List<Huurcontract>();
            if (con.State != System.Data.ConnectionState.Open)
            {
                con.Open();
            }
            OracleCommand cmd = new OracleCommand
            {
                Connection = con,
                CommandText = "SELECT h.id, h.vanaf, h.tot, k.id, k.naam, k.email, m.id, m.naam, m.email FROM HUURCONTRACT h LEFT JOIN KLANT k ON h.klantid = k.id LEFT JOIN MEDEWERKER m ON h.medewerkerid = m.id"
            };
            OracleDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                int id = (dr.GetInt32(0));
                DateTime vanaf = (dr.GetDateTime(1));
                DateTime tot = (dr.GetDateTime(2));
                int kid = (dr.GetInt32(3));
                string knaam = (dr.GetString(4));
                string kmail = (dr.GetString(5));
                int mid = (dr.GetInt32(6));
                string mnaam = (dr.GetString(7));
                string mmail = (dr.GetString(8));
                Klant klant = new Klant(kid, knaam, kmail);
                Account medewerker = new Verhuurder(mid, mnaam, mmail);
                Huurcontract contract = new Huurcontract(vanaf, tot, klant, (Verhuurder)medewerker);
                ret.Add(contract);
            }
            con.Close();
            return ret;
        }
        public List<Klant> GetAllKlanten() //name of ur query
        {
            List<Klant> ret = new List<Klant>();
            if (con.State != System.Data.ConnectionState.Open)
            {
                con.Open();
            }
            OracleCommand cmd = new OracleCommand
            {
                Connection = con,
                CommandText = "SELECT id, naam, email FROM KLANT"
            };
            OracleDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                int id = (dr.GetInt32(0));
                string naam = (dr.GetString(1));
                string mail = (dr.GetString(2));
                Klant klant = new Klant(id, naam, mail);
                ret.Add(klant);
            }
            con.Close();
            return ret;
        }
        public Klant GetKlantByID(int id) //name of ur query
        {
            Klant ret = null;
            if (con.State != System.Data.ConnectionState.Open)
            {
                con.Open();
            }
            OracleCommand cmd = new OracleCommand
            {
                Connection = con,
                CommandText = "SELECT id, naam, email FROM KLANT WHERE KLANT.id = :id"
            };
            cmd.Parameters.Add("@id", id);
            OracleDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                int klantid = (dr.GetInt32(0));
                string naam = (dr.GetString(1));
                string email = (dr.GetString(2));
                ret = new Klant(klantid, naam, email);
            }
            con.Close();
            return ret;
        }
        public int NieuweKlant(Klant klant)
        {
            using (OracleCommand command = new OracleCommand("addklant", con))
            {
                try
                {
                    con.Open();
                    command.CommandType = CommandType.StoredProcedure;
                    command.BindByName = true;
                    command.Parameters.Add("t_name", OracleDbType.Varchar2, klant.Naam, ParameterDirection.Input);
                    command.Parameters.Add("t_email", OracleDbType.Varchar2, klant.Email, ParameterDirection.Input);
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

        public void NieuwHuurContract(Huurcontract contract)
        {
            if (con.State != System.Data.ConnectionState.Open)
            {
                con.Open();
            }
            OracleCommand cmd = new OracleCommand
            {
                Connection = con,
                CommandText = "INSERT INTO HUURCONTRACT(klantid, medewerkerid, vanaf, tot) VALUES (:klantid, :verhuurderid, :vanaf, :tot)"
            };
            cmd.Parameters.Add(":klantid", contract.Klant.Id);
            cmd.Parameters.Add(":verhuurderid", contract.Verhuurder.Id);
            cmd.Parameters.Add(":vanaf", contract.Vanaf);
            cmd.Parameters.Add(":tot", contract.Tot);
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public void NieuwHuurBoot(Huurcontract contract)
        {
            if (con.State != System.Data.ConnectionState.Open)
            {
                con.Open();
            }
            foreach (Boot boot in contract.BotenLijst)
            {
                OracleCommand cmd = new OracleCommand
                {
                    Connection = con,
                    CommandText = "INSERT INTO BOOT_HUURCONTRACT (bootid, huurcontractid) VALUES (:boot, :contract)"
                };
                cmd.Parameters.Add(":boot", boot.Id);
                cmd.Parameters.Add(":contract", contract.Id);
                cmd.ExecuteNonQuery();
            }
            con.Close();
        }
        public void NieuwHuurArtikel(Huurcontract contract)
        {
            if (con.State != System.Data.ConnectionState.Open)
            {
                con.Open();
            }
            foreach (Artikel artikel in contract.ArtikelLijst)
            {
                OracleCommand cmd = new OracleCommand
                {
                    Connection = con,
                    CommandText = "INSERT INTO ARTIKEL_HUURCONTRACT (artikelid, huurcontractid) VALUES (:artikel, :contract)"
                };
                cmd.Parameters.Add(":artikel", artikel.Id);
                cmd.Parameters.Add(":contract", contract.Id);
                cmd.ExecuteNonQuery();
            }
            con.Close();
        }
        public int GetNewestContractid() //name of ur query
        {
            int ret = 0;
            if (con.State != System.Data.ConnectionState.Open)
            {
                con.Open();
            }
            OracleCommand cmd = new OracleCommand
            {
                Connection = con,
                CommandText = "SELECT MAX(id) FROM HUURCONTRACT"
            };
            OracleDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                int id = (dr.GetInt32(0));
                ret = id;
            }
            con.Close();
            return ret;
        }
    }
}
