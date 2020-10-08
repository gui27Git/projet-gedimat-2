using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model_Data2ODOO;
using Npgsql;

namespace DAO_Data2ODOO
{
    public class DAO_ResPartner
    {
        private NpgsqlConnection connexion;
        /// <summary>
        /// Constructeur
        /// </summary>
        /// <param name="uneConnexion">objet NpgsqlConnection</param>
        public DAO_ResPartner(NpgsqlConnection uneConnexion)
        {
            this.connexion = uneConnexion;
        }
       
        /// <summary>
        /// Permet d'ajouter un client dans la table res_partner
        /// </summary>
        /// <param name="unSalarie">Objet Client à ajouter</param>
        public void InsertClient(Client unClient)
        {
            try
            {
                NpgsqlCommand cmdInsert = new NpgsqlCommand();
                cmdInsert.Connection = this.connexion;
              
                cmdInsert.CommandText = "INSERT INTO res_partner(display_name, name, city, street, zip, country_id, phone, email, notify_email)" +
                 "VALUES (@display_name, @name,@city,@street,@zip, @country_id, @phone, @email, @email)";
                cmdInsert.Parameters.AddWithValue("@display_name", unClient.GetRaisonSociale());
                cmdInsert.Parameters.AddWithValue("@name", unClient.GetRaisonSociale());
                cmdInsert.Parameters.AddWithValue("@street", unClient.GetRue());
                cmdInsert.Parameters.AddWithValue("@city", unClient.GetVille());
                cmdInsert.Parameters.AddWithValue("@zip", unClient.GetCodePostal());
                cmdInsert.Parameters.AddWithValue("@country_id", 75);
                cmdInsert.Parameters.AddWithValue("@phone", unClient.GetTel());
                cmdInsert.Parameters.AddWithValue("@email", unClient.GetMail());
                cmdInsert.Parameters.AddWithValue("@notify_email", unClient.GetMail());
                int res = cmdInsert.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                Console.WriteLine("Erreur lors de l'insertion du client\n" + e.Message);
            }
        }

    }
}
