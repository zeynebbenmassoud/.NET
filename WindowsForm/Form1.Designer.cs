
namespace WindowsForm
{
    partial class Form1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbRechercheNomClient = new System.Windows.Forms.TextBox();
            this.tbIDCmdRecherche = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.cbDateFin = new System.Windows.Forms.ComboBox();
            this.cbDateDebut = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.btnQuitter = new System.Windows.Forms.Button();
            this.btnSuppCommande = new System.Windows.Forms.Button();
            this.btnModifierCommande = new System.Windows.Forms.Button();
            this.btnAjouterCommande = new System.Windows.Forms.Button();
            this.dgvCommande = new System.Windows.Forms.DataGridView();
            this.RefCmd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateCmd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Client = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tbInfoClAdresse = new System.Windows.Forms.TextBox();
            this.tbInfoClTel = new System.Windows.Forms.TextBox();
            this.tbInfoClcp = new System.Windows.Forms.TextBox();
            this.tbInfoClient = new System.Windows.Forms.TextBox();
            this.tbInfoCVille = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.dgvLigneCommande = new System.Windows.Forms.DataGridView();
            this.clProduit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clQuantité = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clPrix = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCommande)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLigneCommande)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbRechercheNomClient);
            this.groupBox1.Controls.Add(this.tbIDCmdRecherche);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.groupBox5);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(22, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(169, 218);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // tbRechercheNomClient
            // 
            this.tbRechercheNomClient.Location = new System.Drawing.Point(68, 105);
            this.tbRechercheNomClient.Name = "tbRechercheNomClient";
            this.tbRechercheNomClient.Size = new System.Drawing.Size(88, 20);
            this.tbRechercheNomClient.TabIndex = 5;
            this.tbRechercheNomClient.TextChanged += new System.EventHandler(this.tbCmdRecherche_TextChanged);
            // 
            // tbIDCmdRecherche
            // 
            this.tbIDCmdRecherche.Location = new System.Drawing.Point(123, 79);
            this.tbIDCmdRecherche.Name = "tbIDCmdRecherche";
            this.tbIDCmdRecherche.Size = new System.Drawing.Size(40, 20);
            this.tbIDCmdRecherche.TabIndex = 4;
            this.tbIDCmdRecherche.TextChanged += new System.EventHandler(this.tbCmdRecherche_TextChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(16, 25);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(134, 20);
            this.textBox1.TabIndex = 3;
            this.textBox1.Text = "Recherche de commande";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.cbDateFin);
            this.groupBox5.Controls.Add(this.cbDateDebut);
            this.groupBox5.Controls.Add(this.label4);
            this.groupBox5.Controls.Add(this.label3);
            this.groupBox5.Location = new System.Drawing.Point(12, 130);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(151, 74);
            this.groupBox5.TabIndex = 2;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Date Commande";
            // 
            // cbDateFin
            // 
            this.cbDateFin.FormattingEnabled = true;
            this.cbDateFin.Location = new System.Drawing.Point(71, 47);
            this.cbDateFin.Name = "cbDateFin";
            this.cbDateFin.Size = new System.Drawing.Size(73, 21);
            this.cbDateFin.TabIndex = 6;
            this.cbDateFin.TextChanged += new System.EventHandler(this.tbCmdRecherche_TextChanged);
            // 
            // cbDateDebut
            // 
            this.cbDateDebut.FormattingEnabled = true;
            this.cbDateDebut.Location = new System.Drawing.Point(71, 19);
            this.cbDateDebut.Name = "cbDateDebut";
            this.cbDateDebut.Size = new System.Drawing.Size(73, 21);
            this.cbDateDebut.TabIndex = 5;
            this.cbDateDebut.TextChanged += new System.EventHandler(this.tbCmdRecherche_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Date Fin";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Date Début";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Client";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Référence Commande";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBox4);
            this.groupBox2.Controls.Add(this.btnQuitter);
            this.groupBox2.Controls.Add(this.btnSuppCommande);
            this.groupBox2.Controls.Add(this.btnModifierCommande);
            this.groupBox2.Controls.Add(this.btnAjouterCommande);
            this.groupBox2.Controls.Add(this.dgvCommande);
            this.groupBox2.Location = new System.Drawing.Point(216, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(536, 233);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(183, 15);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(134, 20);
            this.textBox4.TabIndex = 4;
            this.textBox4.Text = "Liste des Commandes";
            // 
            // btnQuitter
            // 
            this.btnQuitter.ForeColor = System.Drawing.Color.Red;
            this.btnQuitter.Location = new System.Drawing.Point(443, 167);
            this.btnQuitter.Name = "btnQuitter";
            this.btnQuitter.Size = new System.Drawing.Size(87, 36);
            this.btnQuitter.TabIndex = 3;
            this.btnQuitter.Text = "Quitter";
            this.btnQuitter.UseVisualStyleBackColor = true;
            this.btnQuitter.Click += new System.EventHandler(this.btnQuitter_Click);
            // 
            // btnSuppCommande
            // 
            this.btnSuppCommande.Location = new System.Drawing.Point(443, 113);
            this.btnSuppCommande.Name = "btnSuppCommande";
            this.btnSuppCommande.Size = new System.Drawing.Size(87, 36);
            this.btnSuppCommande.TabIndex = 2;
            this.btnSuppCommande.Text = "Supprimer";
            this.btnSuppCommande.UseVisualStyleBackColor = true;
            this.btnSuppCommande.Click += new System.EventHandler(this.btnSuppCommande_Click);
            // 
            // btnModifierCommande
            // 
            this.btnModifierCommande.Location = new System.Drawing.Point(443, 71);
            this.btnModifierCommande.Name = "btnModifierCommande";
            this.btnModifierCommande.Size = new System.Drawing.Size(87, 36);
            this.btnModifierCommande.TabIndex = 1;
            this.btnModifierCommande.Text = "Modifier";
            this.btnModifierCommande.UseVisualStyleBackColor = true;
            this.btnModifierCommande.Click += new System.EventHandler(this.btnModifierCommande_Click);
            // 
            // btnAjouterCommande
            // 
            this.btnAjouterCommande.Location = new System.Drawing.Point(443, 29);
            this.btnAjouterCommande.Name = "btnAjouterCommande";
            this.btnAjouterCommande.Size = new System.Drawing.Size(87, 36);
            this.btnAjouterCommande.TabIndex = 0;
            this.btnAjouterCommande.Text = "Ajouter";
            this.btnAjouterCommande.UseVisualStyleBackColor = true;
            this.btnAjouterCommande.Click += new System.EventHandler(this.btnAjouterCommande_Click);
            // 
            // dgvCommande
            // 
            this.dgvCommande.AllowUserToAddRows = false;
            this.dgvCommande.AllowUserToDeleteRows = false;
            this.dgvCommande.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCommande.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.RefCmd,
            this.DateCmd,
            this.Client});
            this.dgvCommande.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dgvCommande.Location = new System.Drawing.Point(37, 52);
            this.dgvCommande.Name = "dgvCommande";
            this.dgvCommande.ReadOnly = true;
            this.dgvCommande.Size = new System.Drawing.Size(386, 167);
            this.dgvCommande.TabIndex = 0;
            this.dgvCommande.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCommande_CellEnter);
            // 
            // RefCmd
            // 
            this.RefCmd.HeaderText = "Réference Commande";
            this.RefCmd.Name = "RefCmd";
            this.RefCmd.ReadOnly = true;
            // 
            // DateCmd
            // 
            this.DateCmd.HeaderText = "Date";
            this.DateCmd.Name = "DateCmd";
            this.DateCmd.ReadOnly = true;
            // 
            // Client
            // 
            this.Client.HeaderText = "Client";
            this.Client.Name = "Client";
            this.Client.ReadOnly = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.tbInfoClAdresse);
            this.groupBox3.Controls.Add(this.tbInfoClTel);
            this.groupBox3.Controls.Add(this.tbInfoClcp);
            this.groupBox3.Controls.Add(this.tbInfoClient);
            this.groupBox3.Controls.Add(this.tbInfoCVille);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.textBox6);
            this.groupBox3.Location = new System.Drawing.Point(22, 264);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(169, 218);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            // 
            // tbInfoClAdresse
            // 
            this.tbInfoClAdresse.Location = new System.Drawing.Point(63, 107);
            this.tbInfoClAdresse.Name = "tbInfoClAdresse";
            this.tbInfoClAdresse.Size = new System.Drawing.Size(88, 20);
            this.tbInfoClAdresse.TabIndex = 14;
            // 
            // tbInfoClTel
            // 
            this.tbInfoClTel.Location = new System.Drawing.Point(63, 191);
            this.tbInfoClTel.Name = "tbInfoClTel";
            this.tbInfoClTel.Size = new System.Drawing.Size(88, 20);
            this.tbInfoClTel.TabIndex = 13;
            // 
            // tbInfoClcp
            // 
            this.tbInfoClcp.Location = new System.Drawing.Point(63, 165);
            this.tbInfoClcp.Name = "tbInfoClcp";
            this.tbInfoClcp.Size = new System.Drawing.Size(88, 20);
            this.tbInfoClcp.TabIndex = 12;
            // 
            // tbInfoClient
            // 
            this.tbInfoClient.Location = new System.Drawing.Point(63, 70);
            this.tbInfoClient.Name = "tbInfoClient";
            this.tbInfoClient.Size = new System.Drawing.Size(88, 20);
            this.tbInfoClient.TabIndex = 11;
            // 
            // tbInfoCVille
            // 
            this.tbInfoCVille.Location = new System.Drawing.Point(63, 134);
            this.tbInfoCVille.Name = "tbInfoCVille";
            this.tbInfoCVille.Size = new System.Drawing.Size(88, 20);
            this.tbInfoCVille.TabIndex = 10;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(18, 198);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(22, 13);
            this.label9.TabIndex = 9;
            this.label9.Text = "Tel";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(18, 174);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(21, 13);
            this.label8.TabIndex = 8;
            this.label8.Text = "CP";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(18, 141);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(26, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Ville";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 110);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Adresse";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 77);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Client";
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(17, 31);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(134, 20);
            this.textBox6.TabIndex = 4;
            this.textBox6.Text = "Info Client";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.textBox5);
            this.groupBox4.Controls.Add(this.dgvLigneCommande);
            this.groupBox4.Location = new System.Drawing.Point(221, 276);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(532, 205);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(178, 19);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(134, 20);
            this.textBox5.TabIndex = 5;
            this.textBox5.Text = "Ligne Commande";
            // 
            // dgvLigneCommande
            // 
            this.dgvLigneCommande.AllowUserToAddRows = false;
            this.dgvLigneCommande.AllowUserToDeleteRows = false;
            this.dgvLigneCommande.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLigneCommande.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clProduit,
            this.clQuantité,
            this.clPrix});
            this.dgvLigneCommande.Location = new System.Drawing.Point(32, 45);
            this.dgvLigneCommande.Name = "dgvLigneCommande";
            this.dgvLigneCommande.ReadOnly = true;
            this.dgvLigneCommande.Size = new System.Drawing.Size(386, 154);
            this.dgvLigneCommande.TabIndex = 1;
            // 
            // clProduit
            // 
            this.clProduit.HeaderText = "Produit";
            this.clProduit.Name = "clProduit";
            this.clProduit.ReadOnly = true;
            // 
            // clQuantité
            // 
            this.clQuantité.HeaderText = "Quantité";
            this.clQuantité.Name = "clQuantité";
            this.clQuantité.ReadOnly = true;
            // 
            // clPrix
            // 
            this.clPrix.HeaderText = "Prix";
            this.clPrix.Name = "clPrix";
            this.clPrix.ReadOnly = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 535);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Gestion de Commande";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCommande)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLigneCommande)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbRechercheNomClient;
        private System.Windows.Forms.TextBox tbIDCmdRecherche;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.ComboBox cbDateFin;
        private System.Windows.Forms.ComboBox cbDateDebut;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvCommande;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Button btnQuitter;
        private System.Windows.Forms.Button btnSuppCommande;
        private System.Windows.Forms.Button btnModifierCommande;
        private System.Windows.Forms.Button btnAjouterCommande;
        private System.Windows.Forms.TextBox tbInfoClAdresse;
        private System.Windows.Forms.TextBox tbInfoClTel;
        private System.Windows.Forms.TextBox tbInfoClcp;
        private System.Windows.Forms.TextBox tbInfoClient;
        private System.Windows.Forms.TextBox tbInfoCVille;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.DataGridView dgvLigneCommande;
        private System.Windows.Forms.DataGridViewTextBoxColumn clProduit;
        private System.Windows.Forms.DataGridViewTextBoxColumn clQuantité;
        private System.Windows.Forms.DataGridViewTextBoxColumn clPrix;
        private System.Windows.Forms.DataGridViewTextBoxColumn RefCmd;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateCmd;
        private System.Windows.Forms.DataGridViewTextBoxColumn Client;
    }
}

