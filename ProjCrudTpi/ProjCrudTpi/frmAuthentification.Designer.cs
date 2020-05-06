namespace ProjCrudTpi
{
    partial class frmAuthentification
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.gbxConnexion = new System.Windows.Forms.GroupBox();
            this.lblMessage = new System.Windows.Forms.Label();
            this.btnInscription = new System.Windows.Forms.Button();
            this.btnConnexion = new System.Windows.Forms.Button();
            this.tbxMotDePasse = new System.Windows.Forms.TextBox();
            this.tbxIdentifiant = new System.Windows.Forms.TextBox();
            this.lblMotDePAsse = new System.Windows.Forms.Label();
            this.lblIdentifiant = new System.Windows.Forms.Label();
            this.gbxConnexion.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxConnexion
            // 
            this.gbxConnexion.Controls.Add(this.lblMessage);
            this.gbxConnexion.Controls.Add(this.btnInscription);
            this.gbxConnexion.Controls.Add(this.btnConnexion);
            this.gbxConnexion.Controls.Add(this.tbxMotDePasse);
            this.gbxConnexion.Controls.Add(this.tbxIdentifiant);
            this.gbxConnexion.Controls.Add(this.lblMotDePAsse);
            this.gbxConnexion.Controls.Add(this.lblIdentifiant);
            this.gbxConnexion.Location = new System.Drawing.Point(12, 12);
            this.gbxConnexion.Name = "gbxConnexion";
            this.gbxConnexion.Size = new System.Drawing.Size(315, 346);
            this.gbxConnexion.TabIndex = 0;
            this.gbxConnexion.TabStop = false;
            this.gbxConnexion.Text = "Connexion";
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.ForeColor = System.Drawing.Color.Red;
            this.lblMessage.Location = new System.Drawing.Point(15, 252);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(74, 20);
            this.lblMessage.TabIndex = 6;
            this.lblMessage.Text = "message";
            this.lblMessage.Visible = false;
            // 
            // btnInscription
            // 
            this.btnInscription.Location = new System.Drawing.Point(19, 287);
            this.btnInscription.Name = "btnInscription";
            this.btnInscription.Size = new System.Drawing.Size(290, 36);
            this.btnInscription.TabIndex = 5;
            this.btnInscription.Text = "Inscription";
            this.btnInscription.UseVisualStyleBackColor = true;
            this.btnInscription.Click += new System.EventHandler(this.BtnInscription_Click);
            // 
            // btnConnexion
            // 
            this.btnConnexion.Location = new System.Drawing.Point(19, 213);
            this.btnConnexion.Name = "btnConnexion";
            this.btnConnexion.Size = new System.Drawing.Size(290, 36);
            this.btnConnexion.TabIndex = 4;
            this.btnConnexion.Text = "Connexion";
            this.btnConnexion.UseVisualStyleBackColor = true;
            this.btnConnexion.Click += new System.EventHandler(this.BtnConnexion_Click);
            // 
            // tbxMotDePasse
            // 
            this.tbxMotDePasse.Location = new System.Drawing.Point(19, 151);
            this.tbxMotDePasse.Name = "tbxMotDePasse";
            this.tbxMotDePasse.PasswordChar = '*';
            this.tbxMotDePasse.Size = new System.Drawing.Size(290, 26);
            this.tbxMotDePasse.TabIndex = 3;
            // 
            // tbxIdentifiant
            // 
            this.tbxIdentifiant.Location = new System.Drawing.Point(19, 72);
            this.tbxIdentifiant.Name = "tbxIdentifiant";
            this.tbxIdentifiant.Size = new System.Drawing.Size(290, 26);
            this.tbxIdentifiant.TabIndex = 2;
            // 
            // lblMotDePAsse
            // 
            this.lblMotDePAsse.AutoSize = true;
            this.lblMotDePAsse.Location = new System.Drawing.Point(15, 119);
            this.lblMotDePAsse.Name = "lblMotDePAsse";
            this.lblMotDePAsse.Size = new System.Drawing.Size(105, 20);
            this.lblMotDePAsse.TabIndex = 1;
            this.lblMotDePAsse.Text = "Mot de passe";
            // 
            // lblIdentifiant
            // 
            this.lblIdentifiant.AutoSize = true;
            this.lblIdentifiant.Location = new System.Drawing.Point(15, 34);
            this.lblIdentifiant.Name = "lblIdentifiant";
            this.lblIdentifiant.Size = new System.Drawing.Size(131, 20);
            this.lblIdentifiant.TabIndex = 0;
            this.lblIdentifiant.Text = "Identifiant (email)";
            // 
            // frmAuthentification
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(339, 370);
            this.Controls.Add(this.gbxConnexion);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmAuthentification";
            this.Text = "Authentification";
            this.gbxConnexion.ResumeLayout(false);
            this.gbxConnexion.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxConnexion;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.Button btnInscription;
        private System.Windows.Forms.Button btnConnexion;
        private System.Windows.Forms.TextBox tbxMotDePasse;
        private System.Windows.Forms.TextBox tbxIdentifiant;
        private System.Windows.Forms.Label lblMotDePAsse;
        private System.Windows.Forms.Label lblIdentifiant;
    }
}

