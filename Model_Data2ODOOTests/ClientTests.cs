using Microsoft.VisualStudio.TestTools.UnitTesting;
using Model_Data2ODOO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model_Data2ODOO.Tests
{
    [TestClass()]
    public class ClientTests
    {
        [TestMethod()]
        public void GetMobileTest()
        {
            Client René = new Client("ACT2", "ACTION SAS", "70 AV. DU GENERAL DE GAULLE B.P. 63201", "35532", "NOYAL SUR VILAINE CEDEX", "06.99.25.02.70", "02.99.00.60.43", "C.Harper@gmail.com");
            Client Karen = new Client("ARB0", "BLEU D'O", "24 RUE DU BOURG PELE", "72000", "LE MANS", "06 43 24 14 14", "02 43 24 14 12", "N.Yuli@gmail.fr");

            Assert.AreEqual("06.99.25.02.70", René.GetTel(), "Le numéro doit être 06.99.25.02.70");
            Assert.AreEqual("06.99.25.02.70", René.GetMobile(), "Le numéro doit être 06.43.24.14.14");

        }
    }
}