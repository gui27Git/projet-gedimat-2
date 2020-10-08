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
    public class NettoyageTests
    {
        /// <summary>
        /// test de la classe PresenceDeXTest
        /// </summary>
        [TestMethod()]
        public void PresenceDeXTest()
        {
            string ch1 = "Bonjour";
            Assert.AreEqual(false, Nettoyage.RepetitionDeX(ch1));
            string ch2 = "BonjourXavierX";
            Assert.AreEqual(false, Nettoyage.RepetitionDeX(ch2));
            string ch3 = "BonjourXXX";
            Assert.AreEqual(true, Nettoyage.RepetitionDeX(ch3));
            string ch4 = "XBonjourXXXXXX";
            Assert.AreEqual(true, Nettoyage.RepetitionDeX(ch4));
            string ch5 = "XXXXXXXXXXXX";
            Assert.AreEqual(true, Nettoyage.RepetitionDeX(ch5));
            
        }
    }
}