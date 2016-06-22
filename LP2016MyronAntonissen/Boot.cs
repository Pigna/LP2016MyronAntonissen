using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LP2016MyronAntonissen
{
    abstract class Boot
    {
        public int Id { get; set; }
        public double Prijs { get; set; }
        public List<Water> Wateren { get; set; }
    }
}
