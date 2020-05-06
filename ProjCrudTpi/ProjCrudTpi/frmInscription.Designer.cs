namespace ProjCrudTpi
{
    partial class frmInscription
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
            this.gbxInscription = new System.Windows.Forms.GroupBox();
            this.btnConfirmer = new System.Windows.Forms.Button();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.lblMessage = new System.Windows.Forms.Label();
            this.lblNom = new System.Windows.Forms.Label();
            this.lblPrenom = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblMdp = new System.Windows.Forms.Label();
            this.tbxNom = new System.Windows.Forms.TextBox();
            this.tbxPrenom = new System.Windows.Forms.TextBox();
            this.tbxEmail = new System.Windows.Forms.TextBox();
            this.tbxMdp = new System.Windows.Forms.TextBox();
            this.lblConfimerMdp = new System.Windows.Forms.Label();
            this.tbxConfirmerMdp = new System.Windows.Forms.TextBox();
            this.gbxInscription.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxInscription
            // 
            this.gbxInscription.Controls.Add(this.tbxConfirmerMdp);
            this.gbxInscription.Controls.Add(this.lblConfimerMdp);
            this.gbxInscription.Controls.Add(this.tbxMdp);
            this.gbxInscription.Controls.Add(this.tbxEmail);
            this.gbxInscription.Controls.Add(this.tbxPrenom);
            this.gbxInscription.Controls.Add(this.tbxNom);
            this.gbxInscription.Controls.Add(this.lblMdp);
            this.gbxInscription.Controls.Add(this.lblEmail);
            this.gbxInscription.Controls.Add(this.lblPrenom);
            this.gbxInscription.Controls.Add(this.lblNom);
            this.gbxInscription.Controls.Add(this.lblMessage);
            this.gbxInscription.Controls.Add(this.btnAnnuler);
            this.gbxInscription.Controls.Add(this.btnConfirmer);
            this.gbxInscription.Location = new System.Drawing.Point(12, 12);
            this.gbxInscription.Name = "gbxInscription";
            this.gbxInscription.Size = new System.Drawing.Size(336, 703);
            this.gbxInscription.TabIndex = 0;
            this.gbxInscription.TabStop = false;
            this.gbxInscription.Text = "Inscription";
            // 
            // btnConfirmer
            // 
            this.btnConfirmer.Location = new System.Drawing.Point(6, 539);
            this.btnConfirmer.Name = "btnConfirmer";
            this.btnConfirmer.Size = new System.Drawing.Size(317, 43);
            this.btnConfirmer.TabIndex = 0;
            this.btnConfirmer.Text = "Confirmer";
            this.btnConfirmer.UseVisualStyleBackColor = true;
            this.btnConfirmer.Click += new System.EventHandler(this.BtnConfirmer_Click);
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.Location = new System.Drawing.Point(6, 633);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(317, 46);
            this.btnAnnuler.TabIndex = 1;
            this.btnAnnuler.Text = "Quitter";
            this.btnAnnuler.UseVisualStyleBackColor = true;
            this.btnAnnuler.Click += new System.EventHandler(this.BtnAnnuler_Click);
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Location = new System.Drawing.Point(6, 598);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(74, 20);
            this.lblMessage.TabIndex = 2;
            this.lblMessage.Text = "Message";
            this.lblMessage.Visible = false;
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.Location = new System.Drawing.Point(6, 42);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(42, 20);
            this.lblNom.TabIndex = 3;
            this.lblNom.Text = "Nom";
            // 
            // lblPrenom
            // 
            this.lblPrenom.AutoSize = true;
            this.lblPrenom.Location = new System.Drawing.Point(6, 131);
            this.lblPrenom.Name = "lblPrenom";
            this.lblPrenom.Size = new System.Drawing.Size(64, 20);
            this.lblPrenom.TabIndex = 4;
            this.lblPrenom.Text = "Prenom";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(6, 222);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(48, 20);
            this.lblEmail.TabIndex = 5;
            this.lblEmail.Text = "Email";
            // 
            // lblMdp
            // 
            this.lblMdp.AutoSize = true;
            this.lblMdp.Location = new System.Drawing.Point(6, 321);
            this.lblMdp.Name = "lblMdp";
            this.lblMdp.Size = new System.Drawing.Size(105, 20);
            this.lblMdp.TabIndex = 6;
            this.lblMdp.Text = "Mot de passe";
            // 
            // tbxNom
            // 
            this.tbxNom.Location = new System.Drawing.Point(10, 82);
            this.tbxNom.Name = "tbxNom";
            this.tbxNom.Size = new System.Drawing.Size(317, 26);
            this.tbxNom.TabIndex = 7;
            // 
            // tbxPrenom
            // 
            this.tbxPrenom.Location = new System.Drawing.Point(10, 172);
            this.tbxPrenom.Name = "tbxPrenom";
            this.tbxPrenom.Size = new System.Drawing.Size(317, 26);
            this.tbxPrenom.TabIndex = 8;
            // 
            // tbxEmail
            // 
            this.tbxEmail.Location = new System.Drawing.Point(10, 268);
            this.tbxEmail.Name = "tbxEmail";
            this.tbxEmail.Size = new System.Drawing.Size(317, 26);
            this.tbxEmail.TabIndex = 9;
            // 
            // tbxMdp
            // 
            this.tbxMdp.Location = new System.Drawing.Point(10, 370);
            this.tbxMdp.Name = "tbxMdp";
            this.tbxMdp.Size = new System.Drawing.Size(317, 26);
            this.tbxMdp.TabIndex = 10;
            // 
            // lblConfimerMdp
            // 
            this.lblConfimerMdp.AutoSize = true;
            this.lblConfimerMdp.Location = new System.Drawing.Point(6, 426);
            this.lblConfimerMdp.Name = "lblConfimerMdp";
            this.lblConfimerMdp.Size = new System.Drawing.Size(194, 20);
            this.lblConfimerMdp.TabIndex = 11;
            this.lblConfimerMdp.Text = "Confirmer le mot de passe";
            // 
            // tbxConfirmerMdp
            // 
            this.tbxConfirmerMdp.Location = new System.Drawing.Point(10, 470);
            this.tbxConfirmerMdp.Name = "tbxConfirmerMdp";
            this.tbxConfirmerMdp.Size = new System.Drawing.Size(317, 26);
            this.tbxConfirmerMdp.TabIndex = 12;
            // 
            // frmInscription
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(359, 727);
            this.Controls.Add(this.gbxInscription);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmInscription";
            this.Text = "Inscription";
            this.gbxInscription.ResumeLayout(false);
            this.gbxInscription.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxInscription;
        private System.Windows.Forms.TextBox tbxMdp;
        private System.Windows.Forms.TextBox tbxEmail;
        private System.Windows.Forms.TextBox tbxPrenom;
        private System.Windows.Forms.TextBox tbxNom;
        private System.Windows.Forms.Label lblMdp;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblPrenom;
        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.Button btnAnnuler;
        private System.Windows.Forms.Button btnConfirmer;
        private System.Windows.Forms.TextBox tbxConfirmerMdp;
        private System.Windows.Forms.Label lblConfimerMdp;
    }
}