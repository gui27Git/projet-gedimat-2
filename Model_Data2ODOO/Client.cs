using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model_Data2ODOO
{
    /// <summary>
    /// Classe Client
    /// </summary>
    public class Client
    {
        // attributs privés
        private string code;
        private string raisonSociale;
        private string rueAdresse;
        private string cpAdresse;
        private string villeAdresse;
        private string numTel;
        private string numFax;
        private string mail;
        private string active;

        /// <summary>
        /// Constructeur de la classe Client
        /// </summary>
        /// <param name="unCode"></param>
        /// <param name="uneRaisonSociale"></param>
        /// <param name="uneRue"></param>
        /// <param name="unCodePostal"></param>
        /// <param name="uneVille"></param>
        /// <param name="unNumTel"></param>
        /// <param name="unNumFax"></param>
        /// <param name="uneAdrMail"></param>
        /// <param name=""></param>
        public Client(string unCode, string uneRaisonSociale, string uneRue, string unCodePostal, string uneVille, string unNumTel, string unNumFax, string uneAdrMail, string unActif /*string unReglement*/)
        {
            this.code = unCode;
            this.raisonSociale = uneRaisonSociale;
            this.rueAdresse = uneRue;
            this.cpAdresse = unCodePostal;
            this.villeAdresse = uneVille;
            this.numTel = unNumTel;
            this.numFax = unNumFax;
            this.mail = uneAdrMail;
            this.active = unActif;
        }

        #region Accesseurs (Getters/Setters)

        // <summary>
        /// Retourne le code du client
        /// </summary>
        /// <returns></returns>
        public string GetCode()
        {
            return this.code;
        }
        /// <summary>
        /// retourne la raison sociale du client
        /// </summary>
        /// <returns></returns>
        public string GetRaisonSociale()
        {
            return this.raisonSociale;
        }

        /// <summary>
        /// retoune la rue du client
        /// </summary>
        /// <returns></returns>
        public string GetRue()
        {
            return this.rueAdresse;
        }

        /// <summary>
        /// retourne le code postal du client
        /// </summary>
        /// <returns></returns>
        public string GetCodePostal()
        {
            return "0"+this.cpAdresse;
        }

        /// <summary>
        /// retourne la ville du client
        /// </summary>
        /// <returns></returns>
        public string GetVille()
        {
            return this.villeAdresse;
        }

        /// <summary>
        /// retourne le telephone du client
        /// </summary>
        /// <returns></returns>
        public string GetTel()
        {
            return this.numTel;
        }

        /// <summary>
        /// retourne le fax du client
        /// </summary>
        /// <returns></returns>
        public string GetFax()
        {
            return this.numFax;
        }

        /// <summary>
        /// retourne le mail du client
        /// </summary>
        /// <returns></returns>
        public string GetMail()
        {
            return this.mail;
        }
        /// <summary>
        /// retourne l'etat du client
        /// </summary>
        /// <returns></returns>
        public Boolean GetActive()
        {
            if (this.active == "Oui")
                return true;
            else
                return false;
        }
       
        /// <summary>
        /// Reécrit le code du client
        /// </summary>
        /// <param name="unCode"></param>
        public void SetCode(string unCode)
        {
            this.code = unCode;
        }
        /// <summary>
        /// réecrit la raison sociale du client
        /// </summary>
        /// <param name="uneRaisonSociale"></param>
        public void SetRaisonSociale(string uneRaisonSociale)
        {
            this.raisonSociale = uneRaisonSociale;
        }
        /// <summary>
        /// réecrit la rue du client
        /// </summary>
        /// <param name="uneRue"></param>
        public void SetRue(string uneRue)
        {
            this.rueAdresse = uneRue;
        }
        /// <summary>
        /// réecrit le code postal du client
        /// </summary>
        /// <param name="unCodePostal"></param>
        public void SetCodePostal(string unCodePostal)
        {
            this.cpAdresse = unCodePostal;
        }
        /// <summary>
        /// réecrit la ville du client
        /// </summary>
        /// <param name="uneVille"></param>
        public void SetVille(string uneVille)
        {
            this.villeAdresse = uneVille;
        }
        /// <summary>
        /// réecrit le telephone du client
        /// </summary>
        /// <param name="unNumTel"></param>
        public void SetTel(string unNumTel)
        {
            this.numTel = unNumTel;
        }
        /// <summary>
        /// réecrit le fax du client
        /// </summary>
        /// <param name="unNumFax"></param>
        public void SetFax(string unNumFax)
        {
            this.numFax = unNumFax;
        }
        /// <summary>
        /// réecrit le mail du client
        /// </summary>
        /// <param name="unMail"></param>
        public void SetMail(string unMail)
        {
            this.mail = unMail;
        }
        /// <summary>
        /// réecrit l'etat du client
        /// </summary>
        /// <param name="unActive"></param>
        public void SetActive(string unActive)
        {
            this.active = unActive;
        }
        #endregion
    }
}
