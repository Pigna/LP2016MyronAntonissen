using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LP2016MyronAntonissen
{
    public class Klant
    {
        public int Id { get; set; }
        public string Naam { get; set; }
        public string Email { get; set; }
        public List<Huurcontract> ContractenLijst { get; set; }
        public Klant(int id, string naam, string email)
        {
            Id = id;
            Naam = naam;
            Email = email;
        }
        public Klant(string naam, string email)
        {
            Naam = naam;
            Email = email;
        }

        public void GetContractenLijst()
        {
            
        }

        public override string ToString()
        {
            return Naam + " " + Email;
        }
    }
}
