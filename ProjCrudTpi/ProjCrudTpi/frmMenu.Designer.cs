namespace ProjCrudTpi
{
    partial class frmMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnModifier = new System.Windows.Forms.Button();
            this.dgvAffichage = new System.Windows.Forms.DataGridView();
            this.dgvtbcIdUtilisateur = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtbcNom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtbcPrenom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtbcEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtbcMdp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtbcAdmin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtbcDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSupprimer = new System.Windows.Forms.Button();
            this.btnDesinscription = new System.Windows.Forms.Button();
            this.gbxModifSuppr = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ckbxChangerMdp = new System.Windows.Forms.CheckBox();
            this.tbxMdp = new System.Windows.Forms.TextBox();
            this.lblPrenom = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblNom = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.tbxId = new System.Windows.Forms.TextBox();
            this.ckbxAdmin = new System.Windows.Forms.CheckBox();
            this.tbxEmail = new System.Windows.Forms.TextBox();
            this.tbxPrenom = new System.Windows.Forms.TextBox();
            this.tbxNom = new System.Windows.Forms.TextBox();
            this.gbxDesinscription = new System.Windows.Forms.GroupBox();
            this.btnPrecedent = new System.Windows.Forms.Button();
            this.gbxParcourir = new System.Windows.Forms.GroupBox();
            this.btnSuivant = new System.Windows.Forms.Button();
            this.lblMessage = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAffichage)).BeginInit();
            this.gbxModifSuppr.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.gbxDesinscription.SuspendLayout();
            this.gbxParcourir.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnModifier
            // 
            this.btnModifier.Location = new System.Drawing.Point(657, 25);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Size = new System.Drawing.Size(172, 55);
            this.btnModifier.TabIndex = 0;
            this.btnModifier.Text = "Modifier";
            this.btnModifier.UseVisualStyleBackColor = true;
            this.btnModifier.Click += new System.EventHandler(this.BtnModifier_Click);
            // 
            // dgvAffichage
            // 
            this.dgvAffichage.AllowUserToAddRows = false;
            this.dgvAffichage.AllowUserToDeleteRows = false;
            this.dgvAffichage.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAffichage.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvtbcIdUtilisateur,
            this.dgvtbcNom,
            this.dgvtbcPrenom,
            this.dgvtbcEmail,
            this.dgvtbcMdp,
            this.dgvtbcAdmin,
            this.dgvtbcDate});
            this.dgvAffichage.Location = new System.Drawing.Point(12, 12);
            this.dgvAffichage.Name = "dgvAffichage";
            this.dgvAffichage.ReadOnly = true;
            this.dgvAffichage.RowHeadersWidth = 62;
            this.dgvAffichage.RowTemplate.Height = 28;
            this.dgvAffichage.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAffichage.Size = new System.Drawing.Size(1015, 395);
            this.dgvAffichage.TabIndex = 1;
            this.dgvAffichage.SelectionChanged += new System.EventHandler(this.DgvAffichage_SelectionChanged);
            // 
            // dgvtbcIdUtilisateur
            // 
            this.dgvtbcIdUtilisateur.HeaderText = "IdUtilisateur";
            this.dgvtbcIdUtilisateur.MinimumWidth = 8;
            this.dgvtbcIdUtilisateur.Name = "dgvtbcIdUtilisateur";
            this.dgvtbcIdUtilisateur.ReadOnly = true;
            this.dgvtbcIdUtilisateur.Width = 80;
            // 
            // dgvtbcNom
            // 
            this.dgvtbcNom.HeaderText = "Nom";
            this.dgvtbcNom.MinimumWidth = 8;
            this.dgvtbcNom.Name = "dgvtbcNom";
            this.dgvtbcNom.ReadOnly = true;
            this.dgvtbcNom.Width = 80;
            // 
            // dgvtbcPrenom
            // 
            this.dgvtbcPrenom.HeaderText = "Prenom";
            this.dgvtbcPrenom.MinimumWidth = 8;
            this.dgvtbcPrenom.Name = "dgvtbcPrenom";
            this.dgvtbcPrenom.ReadOnly = true;
            this.dgvtbcPrenom.Width = 80;
            // 
            // dgvtbcEmail
            // 
            this.dgvtbcEmail.HeaderText = "Email";
            this.dgvtbcEmail.MinimumWidth = 8;
            this.dgvtbcEmail.Name = "dgvtbcEmail";
            this.dgvtbcEmail.ReadOnly = true;
            this.dgvtbcEmail.Width = 120;
            // 
            // dgvtbcMdp
            // 
            this.dgvtbcMdp.HeaderText = "MotDePasse";
            this.dgvtbcMdp.MinimumWidth = 8;
            this.dgvtbcMdp.Name = "dgvtbcMdp";
            this.dgvtbcMdp.ReadOnly = true;
            this.dgvtbcMdp.Width = 80;
            // 
            // dgvtbcAdmin
            // 
            this.dgvtbcAdmin.HeaderText = "Admin";
            this.dgvtbcAdmin.MaxInputLength = 2;
            this.dgvtbcAdmin.MinimumWidth = 30;
            this.dgvtbcAdmin.Name = "dgvtbcAdmin";
            this.dgvtbcAdmin.ReadOnly = true;
            this.dgvtbcAdmin.Width = 50;
            // 
            // dgvtbcDate
            // 
            this.dgvtbcDate.HeaderText = "Date";
            this.dgvtbcDate.MinimumWidth = 8;
            this.dgvtbcDate.Name = "dgvtbcDate";
            this.dgvtbcDate.ReadOnly = true;
            this.dgvtbcDate.Width = 130;
            // 
            // btnSupprimer
            // 
            this.btnSupprimer.Enabled = false;
            this.btnSupprimer.Location = new System.Drawing.Point(657, 131);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Size = new System.Drawing.Size(173, 55);
            this.btnSupprimer.TabIndex = 2;
            this.btnSupprimer.Text = "Supprimer";
            this.btnSupprimer.UseVisualStyleBackColor = true;
            this.btnSupprimer.Click += new System.EventHandler(this.BtnSupprimer_Click);
            // 
            // btnDesinscription
            // 
            this.btnDesinscription.Enabled = false;
            this.btnDesinscription.Location = new System.Drawing.Point(6, 75);
            this.btnDesinscription.Name = "btnDesinscription";
            this.btnDesinscription.Size = new System.Drawing.Size(144, 55);
            this.btnDesinscription.TabIndex = 3;
            this.btnDesinscription.Text = "Désinscription";
            this.btnDesinscription.UseVisualStyleBackColor = true;
            this.btnDesinscription.Click += new System.EventHandler(this.BtnDesinscription_Click);
            // 
            // gbxModifSuppr
            // 
            this.gbxModifSuppr.Controls.Add(this.lblMessage);
            this.gbxModifSuppr.Controls.Add(this.groupBox1);
            this.gbxModifSuppr.Controls.Add(this.lblPrenom);
            this.gbxModifSuppr.Controls.Add(this.lblEmail);
            this.gbxModifSuppr.Controls.Add(this.lblNom);
            this.gbxModifSuppr.Controls.Add(this.lblId);
            this.gbxModifSuppr.Controls.Add(this.tbxId);
            this.gbxModifSuppr.Controls.Add(this.ckbxAdmin);
            this.gbxModifSuppr.Controls.Add(this.tbxEmail);
            this.gbxModifSuppr.Controls.Add(this.tbxPrenom);
            this.gbxModifSuppr.Controls.Add(this.tbxNom);
            this.gbxModifSuppr.Controls.Add(this.btnModifier);
            this.gbxModifSuppr.Controls.Add(this.btnSupprimer);
            this.gbxModifSuppr.Location = new System.Drawing.Point(12, 501);
            this.gbxModifSuppr.Name = "gbxModifSuppr";
            this.gbxModifSuppr.Size = new System.Drawing.Size(852, 195);
            this.gbxModifSuppr.TabIndex = 4;
            this.gbxModifSuppr.TabStop = false;
            this.gbxModifSuppr.Text = "Modification - Suppression";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ckbxChangerMdp);
            this.groupBox1.Controls.Add(this.tbxMdp);
            this.groupBox1.Location = new System.Drawing.Point(396, 92);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(203, 97);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Mot de passe";
            // 
            // ckbxChangerMdp
            // 
            this.ckbxChangerMdp.AutoSize = true;
            this.ckbxChangerMdp.Location = new System.Drawing.Point(6, 25);
            this.ckbxChangerMdp.Name = "ckbxChangerMdp";
            this.ckbxChangerMdp.Size = new System.Drawing.Size(196, 24);
            this.ckbxChangerMdp.TabIndex = 13;
            this.ckbxChangerMdp.Text = "Changer Mot de passe";
            this.ckbxChangerMdp.UseVisualStyleBackColor = true;
            this.ckbxChangerMdp.CheckedChanged += new System.EventHandler(this.CkbxChangerMdp_CheckedChanged);
            // 
            // tbxMdp
            // 
            this.tbxMdp.Enabled = false;
            this.tbxMdp.Location = new System.Drawing.Point(22, 55);
            this.tbxMdp.Name = "tbxMdp";
            this.tbxMdp.Size = new System.Drawing.Size(164, 26);
            this.tbxMdp.TabIndex = 6;
            // 
            // lblPrenom
            // 
            this.lblPrenom.AutoSize = true;
            this.lblPrenom.Location = new System.Drawing.Point(467, 25);
            this.lblPrenom.Name = "lblPrenom";
            this.lblPrenom.Size = new System.Drawing.Size(64, 20);
            this.lblPrenom.TabIndex = 12;
            this.lblPrenom.Text = "Prenom";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(246, 117);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(48, 20);
            this.lblEmail.TabIndex = 11;
            this.lblEmail.Text = "Email";
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.Location = new System.Drawing.Point(246, 25);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(42, 20);
            this.lblNom.TabIndex = 10;
            this.lblNom.Text = "Nom";
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(37, 25);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(94, 20);
            this.lblId.TabIndex = 9;
            this.lblId.Text = "IdUtilisateur";
            // 
            // tbxId
            // 
            this.tbxId.Enabled = false;
            this.tbxId.Location = new System.Drawing.Point(60, 54);
            this.tbxId.Name = "tbxId";
            this.tbxId.Size = new System.Drawing.Size(44, 26);
            this.tbxId.TabIndex = 8;
            // 
            // ckbxAdmin
            // 
            this.ckbxAdmin.AutoSize = true;
            this.ckbxAdmin.Enabled = false;
            this.ckbxAdmin.Location = new System.Drawing.Point(41, 147);
            this.ckbxAdmin.Name = "ckbxAdmin";
            this.ckbxAdmin.Size = new System.Drawing.Size(80, 24);
            this.ckbxAdmin.TabIndex = 7;
            this.ckbxAdmin.Text = "Admin";
            this.ckbxAdmin.UseVisualStyleBackColor = true;
            // 
            // tbxEmail
            // 
            this.tbxEmail.Location = new System.Drawing.Point(189, 147);
            this.tbxEmail.Name = "tbxEmail";
            this.tbxEmail.Size = new System.Drawing.Size(164, 26);
            this.tbxEmail.TabIndex = 5;
            // 
            // tbxPrenom
            // 
            this.tbxPrenom.Location = new System.Drawing.Point(421, 54);
            this.tbxPrenom.Name = "tbxPrenom";
            this.tbxPrenom.Size = new System.Drawing.Size(164, 26);
            this.tbxPrenom.TabIndex = 4;
            // 
            // tbxNom
            // 
            this.tbxNom.Location = new System.Drawing.Point(189, 54);
            this.tbxNom.Name = "tbxNom";
            this.tbxNom.Size = new System.Drawing.Size(164, 26);
            this.tbxNom.TabIndex = 3;
            // 
            // gbxDesinscription
            // 
            this.gbxDesinscription.Controls.Add(this.btnDesinscription);
            this.gbxDesinscription.Location = new System.Drawing.Point(870, 501);
            this.gbxDesinscription.Name = "gbxDesinscription";
            this.gbxDesinscription.Size = new System.Drawing.Size(157, 195);
            this.gbxDesinscription.TabIndex = 5;
            this.gbxDesinscription.TabStop = false;
            this.gbxDesinscription.Text = "Désinscription";
            // 
            // btnPrecedent
            // 
            this.btnPrecedent.Location = new System.Drawing.Point(6, 25);
            this.btnPrecedent.Name = "btnPrecedent";
            this.btnPrecedent.Size = new System.Drawing.Size(472, 43);
            this.btnPrecedent.TabIndex = 8;
            this.btnPrecedent.Text = "Précédent";
            this.btnPrecedent.UseVisualStyleBackColor = true;
            this.btnPrecedent.Click += new System.EventHandler(this.BtnPrecedent_Click);
            // 
            // gbxParcourir
            // 
            this.gbxParcourir.Controls.Add(this.btnSuivant);
            this.gbxParcourir.Controls.Add(this.btnPrecedent);
            this.gbxParcourir.Location = new System.Drawing.Point(12, 413);
            this.gbxParcourir.Name = "gbxParcourir";
            this.gbxParcourir.Size = new System.Drawing.Size(1015, 82);
            this.gbxParcourir.TabIndex = 6;
            this.gbxParcourir.TabStop = false;
            this.gbxParcourir.Text = "Parcourir";
            // 
            // btnSuivant
            // 
            this.btnSuivant.Location = new System.Drawing.Point(537, 25);
            this.btnSuivant.Name = "btnSuivant";
            this.btnSuivant.Size = new System.Drawing.Size(472, 43);
            this.btnSuivant.TabIndex = 9;
            this.btnSuivant.Text = "Suivant";
            this.btnSuivant.UseVisualStyleBackColor = true;
            this.btnSuivant.Click += new System.EventHandler(this.BtnSuivant_Click);
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.ForeColor = System.Drawing.Color.Red;
            this.lblMessage.Location = new System.Drawing.Point(653, 92);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(22, 20);
            this.lblMessage.TabIndex = 15;
            this.lblMessage.Text = "M";
            this.lblMessage.Visible = false;
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1041, 708);
            this.Controls.Add(this.gbxParcourir);
            this.Controls.Add(this.gbxDesinscription);
            this.Controls.Add(this.gbxModifSuppr);
            this.Controls.Add(this.dgvAffichage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmMenu";
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.FrmMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAffichage)).EndInit();
            this.gbxModifSuppr.ResumeLayout(false);
            this.gbxModifSuppr.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gbxDesinscription.ResumeLayout(false);
            this.gbxParcourir.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnModifier;
        private System.Windows.Forms.DataGridView dgvAffichage;
        private System.Windows.Forms.Button btnSupprimer;
        private System.Windows.Forms.Button btnDesinscription;
        private System.Windows.Forms.GroupBox gbxModifSuppr;
        private System.Windows.Forms.Label lblPrenom;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.TextBox tbxId;
        private System.Windows.Forms.CheckBox ckbxAdmin;
        private System.Windows.Forms.TextBox tbxMdp;
        private System.Windows.Forms.TextBox tbxEmail;
        private System.Windows.Forms.TextBox tbxPrenom;
        private System.Windows.Forms.TextBox tbxNom;
        private System.Windows.Forms.GroupBox gbxDesinscription;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtbcIdUtilisateur;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtbcNom;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtbcPrenom;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtbcEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtbcMdp;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtbcAdmin;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtbcDate;
        private System.Windows.Forms.Button btnPrecedent;
        private System.Windows.Forms.GroupBox gbxParcourir;
        private System.Windows.Forms.Button btnSuivant;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox ckbxChangerMdp;
        private System.Windows.Forms.Label lblMessage;
    }
}