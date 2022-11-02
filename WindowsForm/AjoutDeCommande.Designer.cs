
namespace WindowsForm
{
    partial class AjoutDeCommande
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtTelAjoutCmd = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.dateTimePickerAjoutCmd = new System.Windows.Forms.DateTimePicker();
            this.txtCPAjoutCmd = new System.Windows.Forms.TextBox();
            this.txtVilleAjoutCmd = new System.Windows.Forms.TextBox();
            this.txtRueAjoutCmd = new System.Windows.Forms.TextBox();
            this.txtClientAjoutCmd = new System.Windows.Forms.TextBox();
            this.txtRefAjoutCmd = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.btnSupprimerCmd = new System.Windows.Forms.Button();
            this.btnModifierCmd = new System.Windows.Forms.Button();
            this.btnAjouterCmd = new System.Windows.Forms.Button();
            this.AjoutCommandeDataGridVie1 = new System.Windows.Forms.DataGridView();
            this.Produit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantité = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prix = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnAnnulerCmd = new System.Windows.Forms.Button();
            this.btnValiderCmd = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AjoutCommandeDataGridVie1)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtTelAjoutCmd);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.dateTimePickerAjoutCmd);
            this.groupBox1.Controls.Add(this.txtCPAjoutCmd);
            this.groupBox1.Controls.Add(this.txtVilleAjoutCmd);
            this.groupBox1.Controls.Add(this.txtRueAjoutCmd);
            this.groupBox1.Controls.Add(this.txtClientAjoutCmd);
            this.groupBox1.Controls.Add(this.txtRefAjoutCmd);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(7, 19);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(774, 215);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // txtTelAjoutCmd
            // 
            this.txtTelAjoutCmd.Location = new System.Drawing.Point(508, 137);
            this.txtTelAjoutCmd.Name = "txtTelAjoutCmd";
            this.txtTelAjoutCmd.Size = new System.Drawing.Size(191, 20);
            this.txtTelAjoutCmd.TabIndex = 14;
            this.txtTelAjoutCmd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtClientAjoutCmd_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(429, 139);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "N° Téléphone";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(286, 139);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Code Postal";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.Red;
            this.label10.Location = new System.Drawing.Point(16, 178);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(427, 13);
            this.label10.TabIndex = 11;
            this.label10.Text = "Pour Choisir un client, Mettre le curseur sur le champ client, ensuite appyuer su" +
    "r ENTREE";
            // 
            // dateTimePickerAjoutCmd
            // 
            this.dateTimePickerAjoutCmd.Location = new System.Drawing.Point(266, 26);
            this.dateTimePickerAjoutCmd.Name = "dateTimePickerAjoutCmd";
            this.dateTimePickerAjoutCmd.Size = new System.Drawing.Size(193, 20);
            this.dateTimePickerAjoutCmd.TabIndex = 10;
            // 
            // txtCPAjoutCmd
            // 
            this.txtCPAjoutCmd.Location = new System.Drawing.Point(356, 136);
            this.txtCPAjoutCmd.Name = "txtCPAjoutCmd";
            this.txtCPAjoutCmd.Size = new System.Drawing.Size(67, 20);
            this.txtCPAjoutCmd.TabIndex = 9;
            this.txtCPAjoutCmd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtClientAjoutCmd_KeyPress);
            // 
            // txtVilleAjoutCmd
            // 
            this.txtVilleAjoutCmd.Location = new System.Drawing.Point(78, 135);
            this.txtVilleAjoutCmd.Name = "txtVilleAjoutCmd";
            this.txtVilleAjoutCmd.Size = new System.Drawing.Size(197, 20);
            this.txtVilleAjoutCmd.TabIndex = 8;
            this.txtVilleAjoutCmd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtClientAjoutCmd_KeyPress);
            // 
            // txtRueAjoutCmd
            // 
            this.txtRueAjoutCmd.Location = new System.Drawing.Point(78, 99);
            this.txtRueAjoutCmd.Name = "txtRueAjoutCmd";
            this.txtRueAjoutCmd.Size = new System.Drawing.Size(621, 20);
            this.txtRueAjoutCmd.TabIndex = 7;
            this.txtRueAjoutCmd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtClientAjoutCmd_KeyPress);
            // 
            // txtClientAjoutCmd
            // 
            this.txtClientAjoutCmd.Location = new System.Drawing.Point(78, 67);
            this.txtClientAjoutCmd.Name = "txtClientAjoutCmd";
            this.txtClientAjoutCmd.Size = new System.Drawing.Size(621, 20);
            this.txtClientAjoutCmd.TabIndex = 6;
            this.txtClientAjoutCmd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtClientAjoutCmd_KeyPress);
            // 
            // txtRefAjoutCmd
            // 
            this.txtRefAjoutCmd.Location = new System.Drawing.Point(134, 26);
            this.txtRefAjoutCmd.Name = "txtRefAjoutCmd";
            this.txtRefAjoutCmd.Size = new System.Drawing.Size(83, 20);
            this.txtRefAjoutCmd.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(38, 140);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(26, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Ville";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(38, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Rue";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Client";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(230, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Date";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Référence Commande";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBox7);
            this.groupBox2.Controls.Add(this.btnSupprimerCmd);
            this.groupBox2.Controls.Add(this.btnModifierCmd);
            this.groupBox2.Controls.Add(this.btnAjouterCmd);
            this.groupBox2.Controls.Add(this.AjoutCommandeDataGridVie1);
            this.groupBox2.Location = new System.Drawing.Point(7, 240);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(774, 226);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(278, 12);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(191, 20);
            this.textBox7.TabIndex = 15;
            this.textBox7.Text = "Lignes Commande";
            // 
            // btnSupprimerCmd
            // 
            this.btnSupprimerCmd.Location = new System.Drawing.Point(695, 116);
            this.btnSupprimerCmd.Name = "btnSupprimerCmd";
            this.btnSupprimerCmd.Size = new System.Drawing.Size(73, 33);
            this.btnSupprimerCmd.TabIndex = 10;
            this.btnSupprimerCmd.Text = "Supprimer";
            this.btnSupprimerCmd.UseVisualStyleBackColor = true;
            this.btnSupprimerCmd.Click += new System.EventHandler(this.btnSupprimerCmd_Click);
            // 
            // btnModifierCmd
            // 
            this.btnModifierCmd.Location = new System.Drawing.Point(695, 77);
            this.btnModifierCmd.Name = "btnModifierCmd";
            this.btnModifierCmd.Size = new System.Drawing.Size(73, 33);
            this.btnModifierCmd.TabIndex = 9;
            this.btnModifierCmd.Text = "Modifier";
            this.btnModifierCmd.UseVisualStyleBackColor = true;
            this.btnModifierCmd.Click += new System.EventHandler(this.btnModifierCmd_Click);
            // 
            // btnAjouterCmd
            // 
            this.btnAjouterCmd.Location = new System.Drawing.Point(695, 38);
            this.btnAjouterCmd.Name = "btnAjouterCmd";
            this.btnAjouterCmd.Size = new System.Drawing.Size(73, 33);
            this.btnAjouterCmd.TabIndex = 8;
            this.btnAjouterCmd.Text = "Ajouter";
            this.btnAjouterCmd.UseVisualStyleBackColor = true;
            this.btnAjouterCmd.Click += new System.EventHandler(this.btnAjouterCmd_Click);
            // 
            // AjoutCommandeDataGridVie1
            // 
            this.AjoutCommandeDataGridVie1.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.AjoutCommandeDataGridVie1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AjoutCommandeDataGridVie1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Produit,
            this.Quantité,
            this.Prix});
            this.AjoutCommandeDataGridVie1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.AjoutCommandeDataGridVie1.Location = new System.Drawing.Point(65, 38);
            this.AjoutCommandeDataGridVie1.Name = "AjoutCommandeDataGridVie1";
            this.AjoutCommandeDataGridVie1.Size = new System.Drawing.Size(610, 182);
            this.AjoutCommandeDataGridVie1.TabIndex = 7;
            // 
            // Produit
            // 
            this.Produit.HeaderText = "Produit";
            this.Produit.Name = "Produit";
            this.Produit.ReadOnly = true;
            // 
            // Quantité
            // 
            this.Quantité.HeaderText = "Quantité";
            this.Quantité.Name = "Quantité";
            this.Quantité.ReadOnly = true;
            // 
            // Prix
            // 
            this.Prix.HeaderText = "Prix";
            this.Prix.Name = "Prix";
            this.Prix.ReadOnly = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnAnnulerCmd);
            this.groupBox3.Controls.Add(this.btnValiderCmd);
            this.groupBox3.Location = new System.Drawing.Point(8, 472);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(772, 53);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            // 
            // btnAnnulerCmd
            // 
            this.btnAnnulerCmd.Location = new System.Drawing.Point(694, 16);
            this.btnAnnulerCmd.Name = "btnAnnulerCmd";
            this.btnAnnulerCmd.Size = new System.Drawing.Size(56, 33);
            this.btnAnnulerCmd.TabIndex = 10;
            this.btnAnnulerCmd.Text = "Annuler";
            this.btnAnnulerCmd.UseVisualStyleBackColor = true;
            this.btnAnnulerCmd.Click += new System.EventHandler(this.btnAnnulerCmd_Click);
            // 
            // btnValiderCmd
            // 
            this.btnValiderCmd.Location = new System.Drawing.Point(618, 16);
            this.btnValiderCmd.Name = "btnValiderCmd";
            this.btnValiderCmd.Size = new System.Drawing.Size(56, 33);
            this.btnValiderCmd.TabIndex = 9;
            this.btnValiderCmd.Text = "Valider";
            this.btnValiderCmd.UseVisualStyleBackColor = true;
            this.btnValiderCmd.Click += new System.EventHandler(this.btnValiderCmd_Click);
            // 
            // AjoutDeCommande
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(800, 530);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.HelpButton = true;
            this.MaximizeBox = false;
            this.Name = "AjoutDeCommande";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Ajout de Commande";
            this.Load += new System.EventHandler(this.AjoutDeCommande_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AjoutCommandeDataGridVie1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView AjoutCommandeDataGridVie1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Button btnSupprimerCmd;
        private System.Windows.Forms.Button btnModifierCmd;
        private System.Windows.Forms.Button btnAjouterCmd;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnAnnulerCmd;
        private System.Windows.Forms.Button btnValiderCmd;
        private System.Windows.Forms.DataGridViewTextBoxColumn Produit;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantité;
        private System.Windows.Forms.DataGridViewTextBoxColumn Prix;
        public System.Windows.Forms.TextBox txtCPAjoutCmd;
        public System.Windows.Forms.TextBox txtVilleAjoutCmd;
        public System.Windows.Forms.TextBox txtRueAjoutCmd;
        public System.Windows.Forms.TextBox txtClientAjoutCmd;
        public System.Windows.Forms.TextBox txtTelAjoutCmd;
        public System.Windows.Forms.DateTimePicker dateTimePickerAjoutCmd;
        public System.Windows.Forms.TextBox txtRefAjoutCmd;
    }
}