using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LP2016MyronAntonissen
{
    abstract class Account
    {
        public int Id { get; set; }
        public string Naam { get; set; }
        public Account(int id, string naam)
        {
            Id = id;
            Naam = naam;
        }
    }
}
