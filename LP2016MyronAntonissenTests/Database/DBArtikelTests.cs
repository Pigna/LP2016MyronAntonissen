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
    public class DBArtikelTests
    {
        DBArtikel dbArtikel = new DBArtikel();
        [TestMethod()]
        public void GetAllArtikelTest()
        {
            Assert.AreEqual(true, dbArtikel.GetAllArtikel().Count>0);
        }
    }
}