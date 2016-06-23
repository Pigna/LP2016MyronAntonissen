using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LP2016MyronAntonissen
{
    public class Spierkracht : Boot
    {
        public Spierkracht(int id, string naam, double prijs) : base(naam, prijs)
        {

        }
        public Spierkracht(string naam, double prijs) : base(naam, prijs)
        {
            
        }
    }
}
