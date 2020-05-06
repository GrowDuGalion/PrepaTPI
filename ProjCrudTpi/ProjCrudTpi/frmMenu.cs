/**
 * Auteur : David
 * Projet : CRUD Préparation TPI
 * Date : 05.05.2020
 * Description : Programme qui permet de faire des CRUD
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
    /// Class frmMenu
    /// </summary>
    public partial class frmMenu : Form
    {
        //Contruire les objets
        static MySQLConnect crud = new MySQLConnect(); //pour les cruds
        static Hash hash = new Hash(); //pour hasher

        //Paramètres
        private int _debutParcoursAffichage;
        private int _premierId;
        private int _dernierId;
        private bool _modeAdmin;
        private int _idConnecte;

        //Propriétés
        public int PremierId { get => _premierId; set => _premierId = value; }
        public int DebutParcoursAffichage { get => _debutParcoursAffichage; set => _debutParcoursAffichage = value; }
        public int DernierId { get => _dernierId; set => _dernierId = value; }
        public bool ModeAdmin { get => _modeAdmin; set => _modeAdmin = value; }
        public int IdConnecte { get => _idConnecte; set => _idConnecte = value; }

        //Innitialisation de constante
        const int NOMBREMAXAAFFICHERALAFOIS = 10;

        /// <summary>
        /// Constructeur
        /// </summary>
        /// <param name="idConnecteParam"></param> id de l'utilisateur connecte
        /// <param name="modeAdminParam"></param> role de l'utilisateur connecte
        public frmMenu(int idConnecteParam, bool modeAdminParam)
        {
            InitializeComponent();         
            PremierId = crud.idUtilisateurMin();
            DebutParcoursAffichage = PremierId-1;
            DernierId = crud.idUtilisateurMax();
            IdConnecte = idConnecteParam;
            ModeAdmin = modeAdminParam;
        }

        /// <summary>
        /// Au load de la Form Menu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmMenu_Load(object sender, EventArgs e)
        {
            //Appeler fonction pour afficher dans la dataGridView
            AffichageCarnet();
            //Appeler fontion pour afficher les données modifiables
            affichageInnitialisationDonneesUtilisateurConnecte();
        }

        /// <summary>
        /// Fonction pour afficher les donnees dans la dataGridView
        /// </summary>
        private void AffichageCarnet()
        {
            //Récupérer les données de la base de donnée
            List<string>[] donnees = crud.SelectAll(DebutParcoursAffichage);
            int nombreLigne = donnees[0].Count;

            //Effacer l'affichage précédente pour la nouvelle
            dgvAffichage.Rows.Clear();

            //Affichage des donnees dans la dataGridView
            for (int i = 0; i < nombreLigne; i++)
            {
                dgvAffichage.Rows.Add(donnees[0][i], donnees[1][i], donnees[2][i], donnees[3][i], donnees[4][i], donnees[5][i], donnees[6][i]);
            }

            //Appeler la fonction pour activer ou désactiver les boutons
            ControleSuppressionDesinscription();
        }

        /// <summary>
        /// Bouton pour passer aux dix précédents utilisateurs à afficher sur la dataGridView
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnPrecedent_Click(object sender, EventArgs e)
        {
            //Ne pas reculer plus loin que l'id le plus petit présent dans la base de donnée
            if(DebutParcoursAffichage - NOMBREMAXAAFFICHERALAFOIS < PremierId)
            {
                DebutParcoursAffichage = PremierId-1;
            }
            else
            {
                DebutParcoursAffichage -= NOMBREMAXAAFFICHERALAFOIS;
            }

            //Raffraîchir l'affichage
            AffichageCarnet();
        }

        /// <summary>
        /// Bouton pour passer aux dix prochains utilisateurs à afficher sur la dataGridView
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnSuivant_Click(object sender, EventArgs e)
        {
            //Ne pas avancer plus loin que l'id le plus grand présent dans la base de donnée
            if (DebutParcoursAffichage + NOMBREMAXAAFFICHERALAFOIS > DernierId)
            {
                DebutParcoursAffichage = DebutParcoursAffichage;
            }
            else
            {
                DebutParcoursAffichage += NOMBREMAXAAFFICHERALAFOIS;
            }

            //Raffraîchir l'affichage
            AffichageCarnet();
        }

        /// <summary>
        /// Changement des valeurs modifiables affichées à la sélection dans la dataGridView
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DgvAffichage_SelectionChanged(object sender, EventArgs e)
        {
            //Récupérer les données de la ligne sélectionnée
            DataGridViewRow ligne = dgvAffichage.CurrentRow;

            //Modification et suppression des autres utilisateurs réservé aux administrateurs
            if (ModeAdmin)
            {
                //Affichage dans les textbox et checkbox pour modification et suppression
                tbxId.Text = ligne.Cells[0].Value.ToString();
                tbxNom.Text = ligne.Cells[1].Value.ToString();
                tbxPrenom.Text = ligne.Cells[2].Value.ToString();
                tbxEmail.Text = ligne.Cells[3].Value.ToString();

                //Passer en bool pour changer la valeur de la checkbox
                string adminEnString = ligne.Cells[5].Value.ToString();
                if(adminEnString == "False")
                {
                    ckbxAdmin.Checked = false;
                }
                else if(adminEnString == "True")
                {
                    ckbxAdmin.Checked = true;
                }

                //Appeler la fonction pour activer ou désactiver les boutons
                ControleSuppressionDesinscription();

                lblMessage.Visible = false;
            }
           
        }

        /// <summary>
        /// Fonction affichage des données modifiables à l'innitialisation de la form
        /// </summary>
        private void affichageInnitialisationDonneesUtilisateurConnecte()
        {
            //Affichage des donnees dans les textboxes
            string[] donnees = crud.SelectUnUtilisateur(IdConnecte);
            tbxId.Text = donnees[0];
            tbxNom.Text = donnees[1];
            tbxPrenom.Text = donnees[2];
            tbxEmail.Text = donnees[3];
            if (donnees[5] == "False")
            {
                ckbxAdmin.Checked = false;
            }
            else if (donnees[5] == "True")
            {
                ckbxAdmin.Checked = true;
            }
        }

        /// <summary>
        /// Fonction pour activer le ou les boutons en fonction du rôle utilisateur ou admin
        /// </summary>
        private void ControleSuppressionDesinscription()
        {
            //La suppression est réservée à un administrateur, la désinscription est réservée à un utilisateur normale
            if (ModeAdmin)
            {
                //Récupérer les données de la ligne sélectionnée
                DataGridViewRow ligne = dgvAffichage.CurrentRow;

                //Empêcher l'administrateur de modifier son propre rôle et de se supprimmer
                if (IdConnecte == Convert.ToInt32(ligne.Cells[0].Value))
                {
                    ckbxAdmin.Enabled = false;
                    btnSupprimer.Enabled = false;
                }
                else
                {
                    ckbxAdmin.Enabled = true;
                    btnSupprimer.Enabled = true;
                }
            }    
            else
            {
                btnDesinscription.Enabled = true;
            }
        }

        /// <summary>
        /// Checkbox pour demander une modification de mot de passe
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CkbxChangerMdp_CheckedChanged(object sender, EventArgs e)
        {
            //Activer la textbox de mot de passe si checkbox coché
            if(ckbxChangerMdp.Checked)
            {
                tbxMdp.Enabled = true;
            }
            else
            {
                tbxMdp.Enabled = false;
            }

        }

        private void BtnSupprimer_Click(object sender, EventArgs e)
        {
            //Récupérer les données de la ligne sélectionnée
            DataGridViewRow ligne = dgvAffichage.CurrentRow;

            //Supprimer un utilisateur à partir de son id
            int idASup = Convert.ToInt32(ligne.Cells[0].Value);
            crud.SupprimmerUtilisateur(idASup);

            lblMessage.Visible = false;

            //Raffraîchir l'affichage
            AffichageCarnet();
        }

        /// <summary>
        /// boutton pour déclencher la suppression du compte de l'utilisateur connecté
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnDesinscription_Click(object sender, EventArgs e)
        {
            //fenetre pop up pour être sûre pour la désinscription
            DialogResult result3 = MessageBox.Show("Ètes-vous certain?", "Confirmation désinsciption", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

            if(result3 == DialogResult.Yes)
            {
                crud.SupprimmerUtilisateur(IdConnecte);
                this.Close();
            }
        }

        /// <summary>
        /// boutton pour déclencher une modification des donnees d'un utilisateur
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnModifier_Click(object sender, EventArgs e)
        {
            //Innitialisation de variables
            string[] colonneAModif;
            string[] nouvelleDonnee;
            string admin = string.Empty;
            string mdpHashe = string.Empty;
            int idSelectionne = Convert.ToInt32(dgvAffichage.CurrentRow.Cells[0].Value);

            //Recuperer la valeur de la checkbox en tinyint
            if (ckbxAdmin.Checked)
            {
                admin = 1 + "";
            }
            else
            {
                admin = 0 + "";
            }

            //Donnees de modification différentes si changement de mot de passe coché
            if (ckbxChangerMdp.Checked)
            {
                mdpHashe = hash.ComputeSha256Hash(tbxMdp.Text);

                colonneAModif = new string[5] {"nom", "prenom", "email", "mdp", "admin"};              
                nouvelleDonnee = new string[5] {tbxNom.Text, tbxPrenom.Text, tbxEmail.Text, mdpHashe, admin};
            }
            else
            {
                colonneAModif = new string[4] { "nom", "prenom", "email", "admin" };
                nouvelleDonnee = new string[4] { tbxNom.Text, tbxPrenom.Text, tbxEmail.Text, admin };
            }

            //Verifier formulaire remplis avant modification
            if(ControleFormulaireRempli())
            {
                lblMessage.Visible = false;
                crud.UpdateUnUtilisateur(idSelectionne, colonneAModif, nouvelleDonnee);

                //Raffraîchir l'affichage
                AffichageCarnet();
            }
            else
            {
                //Message d'erreur pour indiquer de remplir les textboxes
                lblMessage.Visible = true;
                lblMessage.Text = "Remplir les formulaires!";
            }           
        }

        /// <summary>
        /// Controler que tous les formulaires remplis pour modification
        /// </summary>
        /// <returns></returns>
        private bool ControleFormulaireRempli()
        {
            bool formulaireRemplie = true;

            //Regarder les textboxes de la groupbox bien remplis
            foreach (Control controlleur in gbxModifSuppr.Controls)
            {
                if (controlleur is TextBox)
                {
                    TextBox textbox = controlleur as TextBox;

                    if (textbox.Text == string.Empty)
                    {
                        formulaireRemplie = false;
                    }
                }
            }

            return formulaireRemplie;
        }
    }
}
