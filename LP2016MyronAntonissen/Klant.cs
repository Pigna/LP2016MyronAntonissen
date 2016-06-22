using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LP2016MyronAntonissen
{
    class Klant
    {
        public int Id { get; set; }
        public string Naam { get; set; }
        public string Email { get; set; }
        public List<Huurcontract> ContractenLijst { get; set; }
    }
}
