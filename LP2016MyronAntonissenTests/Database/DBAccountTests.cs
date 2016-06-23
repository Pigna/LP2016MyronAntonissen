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
    public class DBAccountTests
    {
        DBAccount dbAccount = new DBAccount();
        [TestMethod()]
        public void LoginCheckTest()
        {
            Assert.AreEqual(4,dbAccount.LoginCheck("asd","asd"));
        }

        [TestMethod()]
        public void GetAccountByIdTest()
        {
            Assert.AreEqual(1, dbAccount.GetAccountById(1).Id);
        }
    }
}