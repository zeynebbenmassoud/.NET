
namespace WindowsForm
{
    partial class RechercheProduit
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
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.txtRechProduitDes = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnClientInexistantRechProduit = new System.Windows.Forms.Button();
            this.btnAnnulerRechProduit = new System.Windows.Forms.Button();
            this.btnValiderRechProduit = new System.Windows.Forms.Button();
            this.dataGridViewRechProduit = new System.Windows.Forms.DataGridView();
            this.CodeProduit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Produit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TypeProduit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRechProduit)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(29, 24);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(108, 20);
            this.textBox2.TabIndex = 24;
            this.textBox2.Text = "Recherche de Produit";
            // 
            // txtRechProduitDes
            // 
            this.txtRechProduitDes.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtRechProduitDes.Location = new System.Drawing.Point(66, 75);
            this.txtRechProduitDes.Name = "txtRechProduitDes";
            this.txtRechProduitDes.Size = new System.Drawing.Size(98, 20);
            this.txtRechProduitDes.TabIndex = 23;
            this.txtRechProduitDes.TextChanged += new System.EventHandler(this.txtRechProduitDes_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "Désignation";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnClientInexistantRechProduit);
            this.groupBox1.Controls.Add(this.btnAnnulerRechProduit);
            this.groupBox1.Controls.Add(this.btnValiderRechProduit);
            this.groupBox1.Location = new System.Drawing.Point(691, 102);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(104, 207);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            // 
            // btnClientInexistantRechProduit
            // 
            this.btnClientInexistantRechProduit.Location = new System.Drawing.Point(11, 141);
            this.btnClientInexistantRechProduit.Name = "btnClientInexistantRechProduit";
            this.btnClientInexistantRechProduit.Size = new System.Drawing.Size(80, 35);
            this.btnClientInexistantRechProduit.TabIndex = 3;
            this.btnClientInexistantRechProduit.Text = "Produit inexistant";
            this.btnClientInexistantRechProduit.UseVisualStyleBackColor = true;
            this.btnClientInexistantRechProduit.Click += new System.EventHandler(this.btnClientInexistantRechProduit_Click);
            // 
            // btnAnnulerRechProduit
            // 
            this.btnAnnulerRechProduit.Location = new System.Drawing.Point(11, 83);
            this.btnAnnulerRechProduit.Name = "btnAnnulerRechProduit";
            this.btnAnnulerRechProduit.Size = new System.Drawing.Size(80, 35);
            this.btnAnnulerRechProduit.TabIndex = 2;
            this.btnAnnulerRechProduit.Text = "Annuler";
            this.btnAnnulerRechProduit.UseVisualStyleBackColor = true;
            this.btnAnnulerRechProduit.Click += new System.EventHandler(this.btnAnnulerRechProduit_Click);
            // 
            // btnValiderRechProduit
            // 
            this.btnValiderRechProduit.Location = new System.Drawing.Point(11, 25);
            this.btnValiderRechProduit.Name = "btnValiderRechProduit";
            this.btnValiderRechProduit.Size = new System.Drawing.Size(80, 35);
            this.btnValiderRechProduit.TabIndex = 1;
            this.btnValiderRechProduit.Text = "Valider";
            this.btnValiderRechProduit.UseVisualStyleBackColor = true;
            this.btnValiderRechProduit.Click += new System.EventHandler(this.dataGridViewRechProduit_SelectionChanged);
            // 
            // dataGridViewRechProduit
            // 
            this.dataGridViewRechProduit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRechProduit.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CodeProduit,
            this.Produit,
            this.TypeProduit});
            this.dataGridViewRechProduit.Location = new System.Drawing.Point(177, 12);
            this.dataGridViewRechProduit.Name = "dataGridViewRechProduit";
            this.dataGridViewRechProduit.Size = new System.Drawing.Size(508, 501);
            this.dataGridViewRechProduit.TabIndex = 16;
            // 
            // CodeProduit
            // 
            this.CodeProduit.HeaderText = "Code Produit";
            this.CodeProduit.Name = "CodeProduit";
            // 
            // Produit
            // 
            this.Produit.HeaderText = "Produit";
            this.Produit.Name = "Produit";
            // 
            // TypeProduit
            // 
            this.TypeProduit.HeaderText = "TypeProduit";
            this.TypeProduit.Name = "TypeProduit";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBox2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.txtRechProduitDes);
            this.groupBox2.Location = new System.Drawing.Point(0, 66);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(171, 126);
            this.groupBox2.TabIndex = 25;
            this.groupBox2.TabStop = false;
            // 
            // RechercheProduit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridViewRechProduit);
            this.Name = "RechercheProduit";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.TransparencyKey = System.Drawing.Color.DimGray;
            this.Load += new System.EventHandler(this.RechercheProduit_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRechProduit)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox txtRechProduitDes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnClientInexistantRechProduit;
        private System.Windows.Forms.Button btnAnnulerRechProduit;
        private System.Windows.Forms.Button btnValiderRechProduit;
        private System.Windows.Forms.DataGridView dataGridViewRechProduit;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodeProduit;
        private System.Windows.Forms.DataGridViewTextBoxColumn Produit;
        private System.Windows.Forms.DataGridViewTextBoxColumn TypeProduit;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}