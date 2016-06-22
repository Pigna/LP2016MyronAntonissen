using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LP2016MyronAntonissen
{
    class Huurcontract
    {
        public int Id { get; set; }
        public DateTime Vanaf { get; set; }
        public DateTime Tot { get; set; }
        public Verhuurder Verhuurder { get; set; }
        public List<Boot> BotenLijst { get; set; }
        public List<Artikel> ArtikelLijst { get; set; }
    }
}
