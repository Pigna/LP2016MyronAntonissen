using Microsoft.VisualStudio.TestTools.UnitTesting;
using LP2016MyronAntonissen.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LP2016MyronAntonissen.Database.Tests
{
    [TestClass()]
    public class DBContractTests
    {
        DBContract dbContract = new DBContract();
        [TestMethod()]
        public void GetAllContractTest()
        {
            Assert.AreEqual(true, dbContract.GetAllContract().Count>0);
        }

        [TestMethod()]
        public void GetAllKlantenTest()
        {
            Assert.AreEqual(true, dbContract.GetAllKlanten().Count > 0);
        }

        [TestMethod()]
        public void GetKlantByIDTest()
        {
            Assert.AreEqual(1, dbContract.GetKlantByID(1).Id);
        }

        [TestMethod()]
        public void NieuweKlantTest()
        {
            Klant newKlant = new Klant("Naam","Email");
            Assert.AreEqual(true,dbContract.NieuweKlant(newKlant)>0);
        }

        [TestMethod()]
        public void NieuwHuurContractTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void NieuwHuurBootTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void NieuwHuurArtikelTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void GetNewestContractidTest()
        {
            Assert.AreEqual(true, dbContract.GetNewestContractid()>0);
        }
    }
}