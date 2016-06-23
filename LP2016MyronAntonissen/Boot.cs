using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LP2016MyronAntonissen
{
    public abstract class Boot
    {
        public int Id { get; set; }
        public string Naam { get; set; }
        public double Prijs { get; set; }
        public List<Water> Wateren { get; set; }

        public Boot(string naam, double prijs)
        {
            Naam = naam;
            Prijs = prijs;
        }
        public Boot(int id, string naam, double prijs)
        {
            Id = id;
            Naam = naam;
            Prijs = prijs;
        }

        public override string ToString()
        {
            return Naam + " €" + Prijs;
        }
    }
}
