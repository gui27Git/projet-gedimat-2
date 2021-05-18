using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;
using Process_Data2ODOO;
using Model_Data2ODOO;
using DAO_Data2ODOO;
using Npgsql;

namespace GUI_Data2ODOO
{
    public partial class FrmData2ODOO : Form
    {
        public FrmData2ODOO()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Fermeture du formulaire
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Réduction du formulaire
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_min_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        /// <summary>
        /// Bouton Parcourir
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_parcourir_Click(object sender, EventArgs e)
        {
            erreur_txt_source.Visible = false;
            txt_source.ForeColor = Color.LightGray;
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.DefaultExt = ".CSV";
            ofd.Filter = "CSV Files|*.CSV";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                txt_source.Text = ofd.FileName;
                if (txt_source.Text != "Source")
                {
                    txt_source.ForeColor = Color.LightGray;
                }
            }
        }

        /// <summary>
        /// Quand on entre dans la zone txt_source
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txt_source_Enter(object sender, EventArgs e)
        {
            if (txt_source.Text == "Source")
            {
                txt_source.Text = "";
                txt_source.ForeColor = Color.LightGray;
            }
        }
        /// <summary>
        /// Quand on quitte la zone txt_source
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txt_source_Leave(object sender, EventArgs e)
        {
            if (txt_source.Text == "")
            {
                txt_source.Text = "Source";
                txt_source.ForeColor = Color.DimGray;
            }
        }
        /// <summary>
        /// Quand on entre dans la zone txt_serveur
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txt_serveur_Enter(object sender, EventArgs e)
        {
            if (txt_serveur.Text == "Adresse du serveur")
            {
                txt_serveur.Text = "";
                txt_serveur.ForeColor = Color.LightGray;
            }
        }
        /// <summary>
        /// Quand on quitte la zone txt_serveur
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txt_serveur_Leave(object sender, EventArgs e)
        {
            if (txt_serveur.Text == "")
            {
                txt_serveur.Text = "Adresse du serveur";
                txt_serveur.ForeColor = Color.DimGray;
            }
        }

        /// <summary>
        /// Quand on entre dans la zone txt_nomBDD
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txt_nomBDD_Enter(object sender, EventArgs e)
        {
            if (txt_nomBDD.Text == "Nom de la base")
            {
                txt_nomBDD.Text = "";
                txt_nomBDD.ForeColor = Color.LightGray;
            }
        }
        /// <summary>
        /// Quand on quitte la zone txt_nomBDD
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txt_nomBDD_Leave(object sender, EventArgs e)
        {
            if (txt_nomBDD.Text == "")
            {
                txt_nomBDD.Text = "Nom de la base";
                txt_nomBDD.ForeColor = Color.DimGray;
            }
        }

        private void btn_transferer_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Etes-vous sur de vouloir transferer les données dans la base de données ?","transfere vers la base de donnée", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                try
                {
                    //Etape 1 - Lecture du fichier source
                    List<Client> lesClients = LectureSource.ChargerListClient(txt_source.Text);

                    // Etape 2 - Formatage des données
                    List<Client> lesCientsFormates = Formatage.Formater(lesClients);

                    // Etape 3 - Nettoyage des données
                    List<Client> lesClientsNettoyes = Nettoyage.Nettoyer(lesCientsFormates);

                    // Etape 4 - Verification des données et traitement des anomalies
                    List<Client> lesClientsValides;
                    Dictionary<string, List<Client>> lesAnomalies;
                    Verification.Verifier(lesClientsNettoyes, out lesClientsValides, out lesAnomalies);

                    // Etape 5 - Insertion des données valides dans la table Res_Partner de ODOO
                    if (lesClientsValides != null)
                    {
                        try
                        {
                            string adresseServeur = txt_serveur.Text;
                            string nomBDD = txt_nomBDD.Text;
                            NpgsqlConnection connexion = DAO_Data2ODOO.Connexion.SeConnecter(adresseServeur, nomBDD);
                            connexion.Open();
                            DAO_ResPartner resPartner = new DAO_ResPartner(connexion);
                            foreach (Client c in lesClientsValides)
                                resPartner.InsertClient(c);
                            connexion.Close();

                            // Etape 6 - Affichage du rapport de reprise des données
                            int nbClientsInseres = lesClientsValides.Count;
                            int nbClientsSansRS = lesAnomalies["RaisonSocialeNR"].Count;
                            int nbAnomalies = nbClientsSansRS;
                            string msg = lesClients.Count+" client \n"+lesCientsFormates.Count+" clients formatté \n"+lesClientsNettoyes.Count+" client nettoyé \n"+nbClientsSansRS+" client sans raison sociale \n"+  nbClientsInseres.ToString() + " clients valides insérés";
                            msg += "\n" + nbAnomalies.ToString() + " anomalies";
                            MessageBox.Show(msg, "RAPPORT DATA2ODOO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.ToString(), "Erreur", MessageBoxButtons.OK);
                            this.Close();
                        }
                    }
                }
                catch (Exception)
                {
                    if (txt_source.Text == "Source")
                    {
                        txt_source.ForeColor = Color.Red;
                        erreur_txt_source.Visible = true;
                    }
                    else
                    {
                        txt_source.ForeColor = Color.LightGray;
                        erreur_txt_source.Visible = false;
                    }
                    if (txt_serveur.Text == "Adresse du serveur")
                    {
                        txt_serveur.ForeColor = Color.Red;
                        erreur_txt_serveur.Visible = true;
                    }
                    else
                    {
                        txt_serveur.ForeColor = Color.LightGray;
                        erreur_txt_source.Visible = false;
                    }
                    if (txt_nomBDD.Text == "Nom de la base")
                    {
                        txt_nomBDD.ForeColor = Color.Red;
                        erreur_txt_nomDD.Visible = true;
                    }
                    else
                    {
                        txt_nomBDD.ForeColor = Color.LightGray;
                        erreur_txt_nomDD.Visible = false;
                    }

                }
            }
        }
    }
}
