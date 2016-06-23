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
    public class DBBootTests
    {
        DBBoot dbBoot = new DBBoot();
        [TestMethod()]
        public void GetAllBootTest()
        {
            Assert.AreEqual(true, dbBoot.GetAllBoot().Count>0);
        }

        [TestMethod()]
        public void NewBootTest()
        {
            Boot newBoot = new Motor("Myron",1.0,20);
            Assert.AreEqual(true, dbBoot.NewBoot(newBoot));
        }
    }
}