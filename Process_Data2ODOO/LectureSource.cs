using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model_Data2ODOO; // pour utiliser la classe Client

namespace Process_Data2ODOO
{
    public class LectureSource
    {
        public static List<Client> ChargerListClient(string cheminFichier)
        {
            string ligne;
            string[] donneesClient = new string[10];
            List<Client> lesClients = new List<Client>();
            System.IO.StreamReader file = new System.IO.StreamReader(@"" + cheminFichier + "");
            while ((ligne = file.ReadLine()) != null)
            {
                donneesClient = ligne.Split(';');
                string code = donneesClient[0];
                string raisonSociale = donneesClient[1];
                string rue = donneesClient[2];
                string cp = donneesClient[3];
                string ville = donneesClient[4];
                string tel = donneesClient[5];
                string fax = donneesClient[6];
                string mail = donneesClient[7];
                Client c = new Client(code, raisonSociale, rue, cp, ville, tel, fax, mail);
                lesClients.Add(c);
            }
            file.Close();
            return lesClients;
        }
    }
}
