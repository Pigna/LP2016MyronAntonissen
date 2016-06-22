using System;
using System.Collections.Generic;
using System.Data.OracleClient;
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
                CommandText = "SELECT * FROM Boot"
            };
            OracleDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                int id = (dr.GetInt32(0));
                string naam = (dr.GetString(1));
                int typeid = (dr.GetInt32(2));
                int soortid = (dr.GetInt32(4));
                if (dr.GetValue(3) != System.DBNull.Value)
                {
                    int motorid = (dr.GetInt32(3));
                    Boot dbPlaylistItem = new Motor();
                    ret.Add(dbPlaylistItem);
                }
                else
                {
                    Boot dbPlaylistItem = new Spierkracht();
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
            cmd.Parameters.AddWithValue("@userid", " variable");
            OracleDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                int id = (dr.GetInt32(0));
                string naam = (dr.GetString(1));
                Boot dbPlaylistItem = new Motor();
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
            cmd.Parameters.AddWithValue("@name", boot);
            cmd.Parameters.AddWithValue("@userid", boot);

            cmd.ExecuteNonQuery();
            con.Close();
            return true;
        }
    }
}
