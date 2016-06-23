using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LP2016MyronAntonissen
{
    public class Water
    {
        public int Id { get; set; }
        public string Naam { get; set; }
        public Water(int id, string naam)
        {
            Id = id;
            Naam = naam;
        }
    }
}
