/**
 * Auteur : David
 * Projet : CRUD Préparation TPI
 * Date : 05.05.2020
 * Description : Programme qui permet de faire une inscription
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
    /// Class frmInscription
    /// </summary>
    public partial class frmInscription : Form
    {
        //Construire les objets
        static MySQLConnect crud = new MySQLConnect(); //pour crud
        static Hash hash = new Hash(); //pour hasher
        static EmailControl controlEmail = new EmailControl(); //pour vérifier email

        /// <summary>
        /// Constructeur
        /// </summary>
        public frmInscription()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Boutton pour confirmer une inscription
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnConfirmer_Click(object sender, EventArgs e)
        {
            //Récupérer les données des saisies
            string nom = tbxNom.Text;
            string prenom = tbxPrenom.Text;
            string email = tbxEmail.Text;
            string mdp = tbxMdp.Text;
            string confirmMdp = tbxConfirmerMdp.Text;            

            //Contrôler que les textboxes soient bien remplis
            if(ControleFormulaireRempli())
            {
                if(controlEmail.IsValidEmail(email))
                {
                    //Vérifier que l'email n'est pas encore utilisé
                    if (!crud.utilisateurExist(email))
                    {
                        //Vérifier la confirmation de mot de passe
                        if (mdp == confirmMdp)
                        {
                            //Désactiver les texboxes et bouton
                            btnConfirmer.Enabled = false;
                            tbxConfirmerMdp.Enabled = false;
                            tbxMdp.Enabled = false;
                            tbxPrenom.Enabled = false;
                            tbxNom.Enabled = false;
                            tbxEmail.Enabled = false;

                            //Hasher le mot de passe
                            mdp = hash.ComputeSha256Hash(mdp);

                            //Ajouter un nouvel utilisateur à la base de donnée
                            crud.ajouterUtilisateur(nom, prenom, email, mdp);

                            lblMessage.Visible = true;
                            lblMessage.Text = "Inscription effectuée !";
                        }
                        else
                        {
                            //Affichage de message d'erreur
                            lblMessage.Visible = true;
                            lblMessage.Text = "Confirmation du mot de passe erronnée !";
                        }
                    }
                    else
                    {
                        //Affichage de message d'erreur
                        lblMessage.Visible = true;
                        lblMessage.Text = "Email déjà inscrit !";
                    }
                }  
                else
                {
                    //Affichage de message d'erreur
                    lblMessage.Visible = true;
                    lblMessage.Text = "Email non valide !";
                }
            }
            else
            {
                //Affichage de message d'erreur
                lblMessage.Visible = true;
                lblMessage.Text = "Formulaire pas rempli entièrement !";
            }
        }

        /// <summary>
        /// Boutton pour fermer la form d'inscription
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnAnnuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Fonction pour contrôler si tous les formulaires sont bien remplis
        /// </summary>
        /// <returns></returns>
        private bool ControleFormulaireRempli()
        {
            bool formulaireRemplie = true;

            //Parourir les controls de la forme
            foreach (Control controlleur in this.Controls)
            {
                //Ragader les controles qui sont des textboxs
                if(controlleur is TextBox)
                {
                    TextBox textbox = controlleur as TextBox;

                    //Indiquer si pas tous les textboxes sont remplis
                    if(textbox.Text == string.Empty)
                    {
                        formulaireRemplie = false;
                    }
                }
            }

            return formulaireRemplie;
        }
    }
}
