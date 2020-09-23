using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;

namespace DAO_Data2ODOO
{
    public class Connexion
    {
        /// <summary>
        /// Méthode qui établit une connexion à la base de données PostgreSQL de ODOO
        /// </summary>
        /// <param name="unServeur">adresse du serveur hôte</param>
        /// <param name="unNomBDD">nom de la base de données</param>
        /// <returns>Un objet NpgsqlConnection fermé</returns>
        public static NpgsqlConnection SeConnecter(string unServeur, string unNomBDD)
        {
            NpgsqlConnection connex = null;
            string chaineConnex = "Server=" + unServeur + "; Port=5432; User Id=openpg; Password=openpgpwd; Database=" + unNomBDD + ";";
            try
            {
                connex = new NpgsqlConnection(chaineConnex);
            }
            catch (Exception e)
            {
                Console.WriteLine("Erreur lors de la connexion à la base de données." + e.Message);
            }
            return connex;
        }
    }
}
