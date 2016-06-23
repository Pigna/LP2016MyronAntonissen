using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LP2016MyronAntonissen.Database;

namespace LP2016MyronAntonissen
{
    class Verhuurder : Account
    {
        public Verhuurder(int id, string naam, string email):base(id, naam, email)
        {

        }

        public List<Huurcontract> AlleContracten()
        {
            DBContract dbContract = new DBContract();
            return dbContract.GetAllContract();
        }
        public List<Klant> AlleKlanten()
        {
            DBContract dbContract = new DBContract();
            return dbContract.GetAllKlanten();
        }
        public Klant NieuweKlant(string naam, string email)
        {
            DBContract dbContract = new DBContract();
            Klant nieuweKlant = new Klant(naam, email);
            if (dbContract.NieuweKlant(nieuweKlant) > 0)
            {
                return nieuweKlant;
            }
            return null;
        }
        public Huurcontract NieuwContract(DateTime vanaf, DateTime tot, Klant klant, List<Boot> boten, List<Artikel> artikelen)
        {
            DBContract dbContract = new DBContract();
            Huurcontract contract = new Huurcontract(vanaf, tot, klant, this);
            contract.ArtikelLijst = artikelen;
            contract.BotenLijst = boten;
            dbContract.NieuwHuurContract(contract);
            contract.Id = dbContract.GetNewestContractid();
            dbContract.NieuwHuurBoot(contract);
            dbContract.NieuwHuurArtikel(contract);
            return contract;

        }
    }
}
