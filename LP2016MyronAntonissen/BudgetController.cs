using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LP2016MyronAntonissen
{
    class BudgetController
    {
        public int BerekenAantalMeren(double budget, List<Boot> boten, List<Artikel> artikels, string water)
        {
            if (water != "")
            {
                if (Budgetgroterdan(budget, 2.0))
                {
                    budget = budget - 2.0;
                }
                else
                {
                    return -1;
                }
            }
            foreach (Boot boot in boten)
            {
                if (Budgetgroterdan(budget, boot.Prijs))
                {
                    budget = budget - boot.Prijs;
                }
                else
                {
                    return -1;
                }
            }
            foreach (Artikel artikel in artikels)
            {
                if (Budgetgroterdan(budget, artikel.Prijs))
                {
                    budget = budget - artikel.Prijs;
                }
                else
                {
                    return -1;
                }
            }
            int aantalmeren = 0;
            while ((budget >= 1.0 && aantalmeren < 6)||(budget >= 1.5 && aantalmeren > 5))
            {
                if (aantalmeren < 6)
                {
                    if (Budgetgroterdan(budget, 1.0))
                    {
                        budget = budget - 1.0;
                        aantalmeren++;
                    }
                }
                else
                {
                    if (Budgetgroterdan(budget, 1.50))
                    {
                        budget = budget - 1.50;
                        aantalmeren++;
                    } 
                }
            }
            return aantalmeren;
        }

        private bool Budgetgroterdan(double budget, double bedrag)
        {
            if (budget - bedrag >= 0)
            {
                return true;
            }
            return false;
        }
    }
}
