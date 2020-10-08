using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model_Data2ODOO;
using System.Text.RegularExpressions;

namespace Process_Data2ODOO
{
    public class Nettoyage
    {
        /// <summary>
        /// retourne la liste de client contenant XXX a effacer 
        /// </summary>
        /// <param name="lesClientsANettoyer"></param>
        /// <returns>liste client a effacer</returns>
        public static List<Client> Nettoyer(List<Client> lesClientsANettoyer)
        {
            List<Client> lesClients = new List<Client>();
            foreach (Client c in lesClientsANettoyer)
            {
                // on élimine les clients avec des champs contenant plusieurs X
                if (!RepetitionDeX(c.GetRaisonSociale()))
                    lesClients.Add(c);
            }
            return lesClients;
        }

        /// <summary>
        /// retourne true si la chaine possede unce chaine de  XXX ou +
        /// </summary>
        /// <param name="laChaine"></param>
        /// <returns></returns>
        public static bool RepetitionDeX(string laChaine)
        {
            Regex myRegex = new Regex(@"X{3,50}"); // caractère X apparaissant 3 fois ou plus
            return myRegex.IsMatch(laChaine);
        }
    }
}
