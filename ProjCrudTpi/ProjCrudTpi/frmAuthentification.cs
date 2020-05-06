/**
 * Auteur : David
 * Projet : CRUD Préparation TPI
 * Date : 05.05.2020
 * Description : Programme qui permet de s'authentifier
 * Version 1.0
 * */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjCrudTpi
{
    /// <summary>
    /// Class frmAuthentification
    /// </summary>
    public partial class frmAuthentification : Form
    {
        //Construire les objets
        static MySQLConnect connexion = new MySQLConnect(); // pour crud
        static Hash hash = new Hash(); // pour hasher

        /// <summary>
        /// Constructeur
        /// </summary>
        public frmAuthentification()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Au click du bouton connexion, controle du email et mdp
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnConnexion_Click(object sender, EventArgs e)
        {
            //Innitialisation des variables
            int idConnecte = 0;
            bool estAdminConnecte = false;
            string utilisateurSaisi = tbxIdentifiant.Text;
            string motDePasseSaisi = tbxMotDePasse.Text;
            motDePasseSaisi = hash.ComputeSha256Hash(motDePasseSaisi);

            //Vérifier l'existance de l'email dans la base de donnée
            if(connexion.utilisateurExist(utilisateurSaisi))
            {
                //Vérifier le mot de passe l'email dans la base de donnée
                if (connexion.controleUtilisateurMotDePasse(utilisateurSaisi, motDePasseSaisi))
                {
                    //Récupérer des informations pour utilisation dans le menu
                    idConnecte = connexion.SelectId(utilisateurSaisi);
                    estAdminConnecte = connexion.SelectMode(utilisateurSaisi);
                    
                    //Ouvrir la form menu avec les informations de l'id et le role de l'utilisateur connecte
                    frmMenu menu = new frmMenu(idConnecte, estAdminConnecte);                   
                    this.Visible = false;
                    menu.ShowDialog();
                    this.Visible = true;

                    lblMessage.Visible = false;
                }
                else
                {
                    //Affichage message d'erreur
                    lblMessage.Visible = true;
                    lblMessage.Text = "Mot de passe incorrect !";
                }
            }
            else
            {
                //Affichage message d'erreur
                lblMessage.Visible = true;
                lblMessage.Text = "Identifiant inconnu !";
            }
        }

        /// <summary>
        /// Boutton pour ouvri une form pour réaliser une inscription
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnInscription_Click(object sender, EventArgs e)
        {
            //Ouvrir la form inscription
            frmInscription inscription = new frmInscription();
            inscription.ShowDialog();
        }
    }
}
