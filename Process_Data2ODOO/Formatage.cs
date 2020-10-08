using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model_Data2ODOO;

namespace Process_Data2ODOO
{
    public class Formatage
    {
        public static List<Client> Formater(List<Client> lesClientsAFormater)
        {
            foreach (Client c in lesClientsAFormater)
            {
                // Nettoyage champ Code  
                c.SetCode(c.GetCode().Replace("'", ""));
                c.SetCode(c.GetCode().ToUpper());

                // Nettoyage champ RaisonSociale
                c.SetRaisonSociale(c.GetRaisonSociale().Replace("!", ""));
                c.SetRaisonSociale(c.GetRaisonSociale().Trim(' '));
                c.SetRaisonSociale(c.GetRaisonSociale().ToUpper());

                // Nettoyage champ Rue
                c.SetRue(c.GetRue().Replace("'", " "));
                c.SetRue(c.GetRue().Replace(",", " "));
                c.SetRue(c.GetRue().Replace("-", " "));
                c.SetRue(c.GetRue().Trim(' '));
                c.SetRue(c.GetRue().ToUpper());

                // Nettoyage champ Ville
                c.SetVille(c.GetVille().Replace("'", " "));
                c.SetRue(c.GetRue().Replace(",", " "));
                c.SetVille(c.GetVille().Replace("-", " "));
                c.SetVille(c.GetVille().Trim(' '));
                c.SetVille(c.GetVille().ToUpper());

                // Nettoyage champ Tel
                c.SetTel(c.GetTel().Replace(" ", "."));
                c.SetTel(c.GetTel().Replace("-", "."));
                c.SetTel(c.GetTel().Trim(' '));
                // Nettoyage champ Fax
                c.SetFax(c.GetFax().Replace(" ", "."));
                c.SetFax(c.GetFax().Replace("-", "."));
                c.SetFax(c.GetFax().Trim(' '));
            }
            return lesClientsAFormater;
        }

    }
}
