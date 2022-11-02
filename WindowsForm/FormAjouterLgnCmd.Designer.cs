
namespace WindowsForm
{
    partial class FormAjouterLgnCmd
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnAnnulertxtAjouNvCl = new System.Windows.Forms.Button();
            this.btnValiderAjouNvCl = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtQte = new System.Windows.Forms.TextBox();
            this.txtRefCmd = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPrix = new System.Windows.Forms.TextBox();
            this.txtType = new System.Windows.Forms.TextBox();
            this.txtDesig = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtProduit = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtvalidation = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnAnnulertxtAjouNvCl);
            this.groupBox2.Controls.Add(this.btnValiderAjouNvCl);
            this.groupBox2.Location = new System.Drawing.Point(15, 167);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(506, 49);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            // 
            // btnAnnulertxtAjouNvCl
            // 
            this.btnAnnulertxtAjouNvCl.Location = new System.Drawing.Point(425, 13);
            this.btnAnnulertxtAjouNvCl.Name = "btnAnnulertxtAjouNvCl";
            this.btnAnnulertxtAjouNvCl.Size = new System.Drawing.Size(75, 30);
            this.btnAnnulertxtAjouNvCl.TabIndex = 1;
            this.btnAnnulertxtAjouNvCl.Text = "Annuler";
            this.btnAnnulertxtAjouNvCl.UseVisualStyleBackColor = true;
            this.btnAnnulertxtAjouNvCl.Click += new System.EventHandler(this.btnAnnulertxtAjouNvCl_Click);
            // 
            // btnValiderAjouNvCl
            // 
            this.btnValiderAjouNvCl.Location = new System.Drawing.Point(344, 13);
            this.btnValiderAjouNvCl.Name = "btnValiderAjouNvCl";
            this.btnValiderAjouNvCl.Size = new System.Drawing.Size(75, 30);
            this.btnValiderAjouNvCl.TabIndex = 0;
            this.btnValiderAjouNvCl.Text = "Valider";
            this.btnValiderAjouNvCl.UseVisualStyleBackColor = true;
            this.btnValiderAjouNvCl.Click += new System.EventHandler(this.btnValiderAjouNvCl_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtQte);
            this.groupBox1.Controls.Add(this.txtRefCmd);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtPrix);
            this.groupBox1.Controls.Add(this.txtType);
            this.groupBox1.Controls.Add(this.txtDesig);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtProduit);
            this.groupBox1.Location = new System.Drawing.Point(12, 32);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(509, 129);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // txtQte
            // 
            this.txtQte.Location = new System.Drawing.Point(253, 99);
            this.txtQte.Name = "txtQte";
            this.txtQte.Size = new System.Drawing.Size(87, 20);
            this.txtQte.TabIndex = 13;
            // 
            // txtRefCmd
            // 
            this.txtRefCmd.Location = new System.Drawing.Point(72, 99);
            this.txtRefCmd.Name = "txtRefCmd";
            this.txtRefCmd.Size = new System.Drawing.Size(96, 20);
            this.txtRefCmd.TabIndex = 12;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 93);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 26);
            this.label8.TabIndex = 11;
            this.label8.Text = "Référence \r\nCommande";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(468, 102);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(28, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "D.T.";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(196, 106);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Quantité";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(212, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Type";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Produit";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(359, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Prix";
            // 
            // txtPrix
            // 
            this.txtPrix.Location = new System.Drawing.Point(394, 99);
            this.txtPrix.Name = "txtPrix";
            this.txtPrix.Size = new System.Drawing.Size(68, 20);
            this.txtPrix.TabIndex = 5;
            // 
            // txtType
            // 
            this.txtType.Location = new System.Drawing.Point(253, 19);
            this.txtType.Name = "txtType";
            this.txtType.Size = new System.Drawing.Size(130, 20);
            this.txtType.TabIndex = 3;
            this.txtType.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAjouNvLgCmdProduit_KeyPress);
            // 
            // txtDesig
            // 
            this.txtDesig.Location = new System.Drawing.Point(65, 60);
            this.txtDesig.Name = "txtDesig";
            this.txtDesig.Size = new System.Drawing.Size(431, 20);
            this.txtDesig.TabIndex = 2;
            this.txtDesig.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAjouNvLgCmdProduit_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Désignation";
            // 
            // txtProduit
            // 
            this.txtProduit.Location = new System.Drawing.Point(65, 19);
            this.txtProduit.Name = "txtProduit";
            this.txtProduit.Size = new System.Drawing.Size(130, 20);
            this.txtProduit.TabIndex = 0;
            this.txtProduit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAjouNvLgCmdProduit_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(12, 219);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(467, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "Pour choisir un produit, il faut mettre le curseur sur le champ produit, ensuite " +
    "appyuer sur ENTREE";
            // 
            // txtvalidation
            // 
            this.txtvalidation.AutoSize = true;
            this.txtvalidation.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.txtvalidation.Location = new System.Drawing.Point(18, 16);
            this.txtvalidation.Name = "txtvalidation";
            this.txtvalidation.Size = new System.Drawing.Size(0, 13);
            this.txtvalidation.TabIndex = 14;
            // 
            // FormAjouterLgnCmd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 242);
            this.Controls.Add(this.txtvalidation);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "FormAjouterLgnCmd";
            this.Text = "Ajouter une nouvelle Ligne de commande";
            this.Load += new System.EventHandler(this.FormAjouterLgnCmd_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnAnnulertxtAjouNvCl;
        private System.Windows.Forms.Button btnValiderAjouNvCl;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.TextBox txtType;
        public System.Windows.Forms.TextBox txtDesig;
        public System.Windows.Forms.TextBox txtProduit;
        private System.Windows.Forms.Label label8;
        public System.Windows.Forms.TextBox txtRefCmd;
        private System.Windows.Forms.Label txtvalidation;
        public System.Windows.Forms.TextBox txtPrix;
        public System.Windows.Forms.TextBox txtQte;
    }
}