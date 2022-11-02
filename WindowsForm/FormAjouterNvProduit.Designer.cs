
namespace WindowsForm
{
    partial class FormAjouterNvProduit
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
            this.cbAjProdTypeProd = new System.Windows.Forms.ComboBox();
            this.txtAjProdDes = new System.Windows.Forms.TextBox();
            this.txtAjProdCode = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnValiderNvProduit = new System.Windows.Forms.Button();
            this.btnAnnulerNvProduit = new System.Windows.Forms.Button();
            this.labelNvProduit = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbAjProdTypeProd);
            this.groupBox1.Controls.Add(this.txtAjProdDes);
            this.groupBox1.Controls.Add(this.txtAjProdCode);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(11, 26);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(384, 132);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // cbAjProdTypeProd
            // 
            this.cbAjProdTypeProd.FormattingEnabled = true;
            this.cbAjProdTypeProd.Location = new System.Drawing.Point(85, 85);
            this.cbAjProdTypeProd.Name = "cbAjProdTypeProd";
            this.cbAjProdTypeProd.Size = new System.Drawing.Size(256, 21);
            this.cbAjProdTypeProd.TabIndex = 5;
            // 
            // txtAjProdDes
            // 
            this.txtAjProdDes.Location = new System.Drawing.Point(85, 54);
            this.txtAjProdDes.Name = "txtAjProdDes";
            this.txtAjProdDes.Size = new System.Drawing.Size(256, 20);
            this.txtAjProdDes.TabIndex = 4;
            // 
            // txtAjProdCode
            // 
            this.txtAjProdCode.Location = new System.Drawing.Point(85, 21);
            this.txtAjProdCode.Name = "txtAjProdCode";
            this.txtAjProdCode.Size = new System.Drawing.Size(47, 20);
            this.txtAjProdCode.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Type de Produit";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Désignation";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Code Produit";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnValiderNvProduit);
            this.groupBox2.Controls.Add(this.btnAnnulerNvProduit);
            this.groupBox2.Location = new System.Drawing.Point(11, 164);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(384, 55);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // btnValiderNvProduit
            // 
            this.btnValiderNvProduit.Location = new System.Drawing.Point(222, 19);
            this.btnValiderNvProduit.Name = "btnValiderNvProduit";
            this.btnValiderNvProduit.Size = new System.Drawing.Size(75, 23);
            this.btnValiderNvProduit.TabIndex = 1;
            this.btnValiderNvProduit.Text = "Valider";
            this.btnValiderNvProduit.UseVisualStyleBackColor = true;
            this.btnValiderNvProduit.Click += new System.EventHandler(this.btnValiderNvProduit_Click);
            // 
            // btnAnnulerNvProduit
            // 
            this.btnAnnulerNvProduit.Location = new System.Drawing.Point(303, 19);
            this.btnAnnulerNvProduit.Name = "btnAnnulerNvProduit";
            this.btnAnnulerNvProduit.Size = new System.Drawing.Size(75, 23);
            this.btnAnnulerNvProduit.TabIndex = 0;
            this.btnAnnulerNvProduit.Text = "Annuler";
            this.btnAnnulerNvProduit.UseVisualStyleBackColor = true;
            this.btnAnnulerNvProduit.Click += new System.EventHandler(this.btnAnnulerNvProduit_Click);
            // 
            // labelNvProduit
            // 
            this.labelNvProduit.AutoSize = true;
            this.labelNvProduit.ForeColor = System.Drawing.Color.YellowGreen;
            this.labelNvProduit.Location = new System.Drawing.Point(16, 5);
            this.labelNvProduit.Name = "labelNvProduit";
            this.labelNvProduit.Size = new System.Drawing.Size(0, 13);
            this.labelNvProduit.TabIndex = 2;
            // 
            // FormAjouterNvProduit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(407, 224);
            this.Controls.Add(this.labelNvProduit);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormAjouterNvProduit";
            this.Text = "Ajouter Nouveau Produit";
            this.Load += new System.EventHandler(this.FormAjouterNvProduit_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbAjProdTypeProd;
        private System.Windows.Forms.TextBox txtAjProdDes;
        private System.Windows.Forms.TextBox txtAjProdCode;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnAnnulerNvProduit;
        private System.Windows.Forms.Button btnValiderNvProduit;
        private System.Windows.Forms.Label labelNvProduit;
    }
}