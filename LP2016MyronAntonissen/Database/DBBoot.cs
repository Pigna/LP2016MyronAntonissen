using System;
using System.Collections.Generic;
using Oracle.ManagedDataAccess.Client;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LP2016MyronAntonissen.Database
{
    class DBBoot : DBContext
    {
        public List<Boot> GetAllBoot() //name of ur query
        {
            List<Boot> ret = new List<Boot>();
            if (con.State != System.Data.ConnectionState.Open)
            {
                con.Open();
            }
            OracleCommand cmd = new OracleCommand
            {
                Connection = con,
                CommandText = "SELECT boot.id, boot.naam, soort.naam, soort.prijs, motor.tankinhoud FROM BOOT JOIN SOORT ON boot.soortid = soort.id LEFT JOIN MOTOR ON boot.motorid = motor.id"
            };
            OracleDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                int id = (dr.GetInt32(0));
                string naam = (dr.GetString(1));
                string soortnaam = (dr.GetString(2));
                double soortprijs = (dr.GetDouble(3));
                if (soortnaam == "Motor")
                {
                    int tankinhoud = (dr.GetInt32(4));
                    Boot dbPlaylistItem = new Motor(id, naam, soortprijs, tankinhoud);
                    ret.Add(dbPlaylistItem);
                }

                else
                {
                    Boot dbPlaylistItem = new Spierkracht(id, naam, soortprijs);
                    ret.Add(dbPlaylistItem);
                }
            }
            con.Close();
            return ret;
        }
        public List<Boot> notusedyet() //name of ur query
        {
            List<Boot> ret = new List<Boot>();
            if (con.State != System.Data.ConnectionState.Open)
            {
                con.Open();
            }
            OracleCommand cmd = new OracleCommand
            {
                Connection = con,
                CommandText = "SELECT * FROM Boot"
            };
            cmd.Parameters.Add("@userid", " variable");
            OracleDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                int id = (dr.GetInt32(0));
                string naam = (dr.GetString(1));
                Boot dbPlaylistItem = null;
                ret.Add(dbPlaylistItem);
            }
            con.Close();
            return ret;
        }
        public bool NewBoot(Boot boot)
        {
            if (con.State != System.Data.ConnectionState.Open)
            {
                con.Open();
            }
            OracleCommand cmd = new OracleCommand
            {
                Connection = con,
                CommandText = "INSERT INTO Playlist (Name, Userid) VALUES (@name, @userid)"
            };
            cmd.Parameters.Add("@name", boot);
            cmd.Parameters.Add("@userid", boot);

            cmd.ExecuteNonQuery();
            con.Close();
            return true;
        }
    }
}
