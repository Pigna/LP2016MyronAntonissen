using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LP2016MyronAntonissen
{
    class Motor : Boot
    {
        public int Tankinhoud { get; set; }

        public int ActieRadius
        {
            get { return (Tankinhoud*15)/2; }
        }

    }
}
