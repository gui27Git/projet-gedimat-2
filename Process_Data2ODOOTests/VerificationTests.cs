using Microsoft.VisualStudio.TestTools.UnitTesting;
using Process_Data2ODOO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Process_Data2ODOO.Tests
{
    [TestClass()]
    public class VerificationTests
    {
        /// <summary>
        /// test de la classe ChampVideTest
        /// </summary>
        [TestMethod()]
        public void ChampVideTest()
        {
            Assert.AreEqual(false, Verification.ChampVide("ABC EFG"));
            Assert.AreEqual(false, Verification.ChampVide(" "));
            Assert.AreEqual(true, Verification.ChampVide(""));

        }
    }
}