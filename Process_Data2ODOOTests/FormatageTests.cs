using Microsoft.VisualStudio.TestTools.UnitTesting;
using Process_Data2ODOO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model_Data2ODOO;

namespace Process_Data2ODOO.Tests
{
    [TestClass()]
    public class FormatageTests
    {
        [TestMethod()]
        public void FormaterTest()
        {
            Client René = new Client("ACT2", "ACTION SAS", "70 AV. DU GENERAL DE GAULLE B.P. 63201", "35532", "NOYAL SUR VILAINE CEDEX", "02.99.25.02.70", "02.99.00.60.43", "C.Harper@gmail.com");
            Client Karen = new Client("ARB0", "BLEU D'O", "24 RUE DU BOURG PELE", "72000", "LE MANS", "02 43 24 14 14", "02 43 24 14 12", "N.Yuli@gmail.fr");

            Assert.AreEqual("02.99.25.02.70", René.GetTel(), "Le numéro doit être 02.99.25.02.70");
            Assert.AreEqual("02.43.24.14.14", Karen.GetTel(), "Le numéro doit être 02.43.24.14.14");
        }
    }
}