using Microsoft.VisualStudio.TestTools.UnitTesting;
using DAO_Data2ODOO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;

namespace DAO_Data2ODOO.Tests
{
    [TestClass()]
    public class ConnexionTests
    {
        [TestMethod()]
        public void SeConnecterTest()
        {
            NpgsqlConnection connexion = Connexion.SeConnecter("localhost", "ODOO_EllaSIO");
            connexion.Open();
            Assert.AreEqual("Open", connexion.State.ToString());
        }
    }
}