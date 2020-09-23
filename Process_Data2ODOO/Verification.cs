using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model_Data2ODOO;

namespace Process_Data2ODOO
{
    public class Verification
    {
        public static void Verifier(List<Client> lesClientsAVerifier, out List<Client> lesClientsValides, out Dictionary<string, List<Client>> lesAnomalies)
        {
            lesClientsValides = new List<Client>();
            lesAnomalies = new Dictionary<string, List<Client>>();
            foreach(Client c in lesClientsAVerifier)
            {
                // si la Raison Sociale n'est pas renseignée, 
                // le client est ajouté dans le dictionnaire des anomalies 
                if (Verification.ChampVide(c.GetRaisonSociale()))
                {
                    if (lesAnomalies.ContainsKey("RaisonSocialeNR"))
                        lesAnomalies["RaisonSocialeNR"].Add(c);
                    else
                        lesAnomalies.Add("RaisonSocialeNR", new List<Client> { c });
                }
                // le client est ajouté aux clients valides 
                else
                {
                    lesClientsValides.Add(c);
                }
            }
        }

        public static bool ChampVide(string leChamp)
        {
            return (leChamp.Length == 0) ? true : false;
        }

    }
}
