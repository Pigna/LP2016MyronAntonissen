using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.ManagedDataAccess.Client;

namespace LP2016MyronAntonissen.Database
{
    public class DBArtikel : DBContext
    {
        public List<Artikel> GetAllArtikel()
        {
            List<Artikel> ret = new List<Artikel>();
            if (con.State != System.Data.ConnectionState.Open)
            {
                con.Open();
            }
            OracleCommand cmd = new OracleCommand
            {
                Connection = con,
                CommandText = "SELECT ARTIKEL.ID, naam, prijs FROM ARTIKEL INNER JOIN TYPE_ARTIKEL ON TYPE_ARTIKEL.ID = ARTIKEL.ID"
            };
            OracleDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                int id = (dr.GetInt32(0));
                string naam = (dr.GetString(1));
                double prijs = (dr.GetDouble(2));

                Artikel dbPlaylistItem = new Artikel(id, naam, prijs);
                ret.Add(dbPlaylistItem);
            }
            con.Close();
            return ret;
        }
    }
}
