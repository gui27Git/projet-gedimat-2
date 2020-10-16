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
                else if (Verification.ChampVide(c.GetRue()))
                {
                    if (lesAnomalies.ContainsKey("RueNR"))
                        lesAnomalies["RueNR"].Add(c);
                    else
                        lesAnomalies.Add("RueNR", new List<Client> { c });
                }
                else if (Verification.ChampVide(c.GetCodePostal()))
                {
                    if (lesAnomalies.ContainsKey("CpNR"))
                        lesAnomalies["CpNR"].Add(c);
                    else
                        lesAnomalies.Add("CpNR", new List<Client> { c });
                }
                else if (Verification.ChampVide(c.GetVille()))
                {
                    if (lesAnomalies.ContainsKey("VilleNR"))
                        lesAnomalies["VilleNR"].Add(c);
                    else
                        lesAnomalies.Add("VilleNR", new List<Client> { c });
                }
                else if (Verification.ChampVide(c.GetTel()))
                {
                    if (lesAnomalies.ContainsKey("TelNR"))
                        lesAnomalies["TelNR"].Add(c);
                    else
                        lesAnomalies.Add("TelNR", new List<Client> { c });
                }
                else if (Verification.ChampNonValide(c.GetTel()))
                {
                    if (lesAnomalies.ContainsKey("TelNV"))
                        lesAnomalies["TelNV"].Add(c);
                    else
                        lesAnomalies.Add("TelNV", new List<Client> { c });
                }
                else if (Verification.ChampVide(c.GetMail()))
                {
                    if (lesAnomalies.ContainsKey("MailNR"))
                        lesAnomalies["MailNR"].Add(c);
                    else
                        lesAnomalies.Add("MailNR", new List<Client> { c });
                }
                else if (Verification.ChampNonValide(c.GetMail()))
                {
                    if (lesAnomalies.ContainsKey("MailNV"))
                        lesAnomalies["MailNV"].Add(c);
                    else
                        lesAnomalies.Add("MailNV", new List<Client> { c });
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

        public static bool ChampNonValide(string leChamp)
        {
            bool t = false;
            if (leChamp.Contains("@") && leChamp.Contains("."))
            {
                t = true;
            }
            else if (leChamp.Length == 14)
            {
                t = true;
            }
            return t;
        }

    }
}
