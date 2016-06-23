using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LP2016MyronAntonissen
{
    public class Huurcontract
    {
        public int Id { get; set; }
        public DateTime Vanaf { get; set; }
        public DateTime Tot { get; set; }
        public Verhuurder Verhuurder { get; set; }
        public List<Boot> BotenLijst { get; set; }
        public List<Artikel> ArtikelLijst { get; set; }
        public Klant Klant { get; set; }

        public Huurcontract(DateTime vanaf, DateTime tot, Klant klant , Verhuurder verhuurder)
        {
            Vanaf = vanaf;
            Tot = tot;
            Klant = klant;
            Verhuurder = verhuurder;
        }
        public void ExportContract()
        {
            using (StreamWriter file = new StreamWriter(@"C:\Users\Public\Documents\Huurcontract{DateTime.Now()}.txt"))
            {
                file.WriteLine("Klant: " + Klant);
                file.WriteLine("Verhuurder: " + Verhuurder);
                file.WriteLine("Vanaf: " + Vanaf + " - " + "Tot: " + Tot);
                file.WriteLine("Boten: ");
                foreach (Boot boot in BotenLijst)
                {
                    file.WriteLine(boot.ToString());
                }
                file.WriteLine("Artikelen: ");
                foreach (Artikel artikel in ArtikelLijst)
                {
                    file.WriteLine(artikel.ToString());
                }
            }
        }
    }
}
