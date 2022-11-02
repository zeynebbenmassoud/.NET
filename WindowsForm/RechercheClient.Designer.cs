
namespace WindowsForm
{
    partial class rechercheClient
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
            this.dataGridViewRechClient = new System.Windows.Forms.DataGridView();
            this.Client = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Rue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ville = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CodePostal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tél = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnValiderRechCl = new System.Windows.Forms.Button();
            this.btnAnullerRechCl = new System.Windows.Forms.Button();
            this.btnClientInexistantRechCl = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtRechCl = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.txtRechClcp = new System.Windows.Forms.TextBox();
            this.txtRechClVille = new System.Windows.Forms.TextBox();
            this.txtRechClRue = new System.Windows.Forms.TextBox();
            this.cbopérateurRechCl = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRechClient)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewRechClient
            // 
            this.dataGridViewRechClient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRechClient.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Client,
            this.Rue,
            this.Ville,
            this.CodePostal,
            this.Tél});
            this.dataGridViewRechClient.Location = new System.Drawing.Point(172, 19);
            this.dataGridViewRechClient.Name = "dataGridViewRechClient";
            this.dataGridViewRechClient.Size = new System.Drawing.Size(515, 501);
            this.dataGridViewRechClient.TabIndex = 0;
            this.dataGridViewRechClient.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewRechClient_CellContentClick);
            // 
            // Client
            // 
            this.Client.HeaderText = "Client";
            this.Client.Name = "Client";
            // 
            // Rue
            // 
            this.Rue.HeaderText = "Rue";
            this.Rue.Name = "Rue";
            // 
            // Ville
            // 
            this.Ville.HeaderText = "Ville";
            this.Ville.Name = "Ville";
            // 
            // CodePostal
            // 
            this.CodePostal.HeaderText = "Code Postal";
            this.CodePostal.Name = "CodePostal";
            // 
            // Tél
            // 
            this.Tél.HeaderText = "Tél";
            this.Tél.Name = "Tél";
            // 
            // btnValiderRechCl
            // 
            this.btnValiderRechCl.Location = new System.Drawing.Point(11, 25);
            this.btnValiderRechCl.Name = "btnValiderRechCl";
            this.btnValiderRechCl.Size = new System.Drawing.Size(80, 35);
            this.btnValiderRechCl.TabIndex = 1;
            this.btnValiderRechCl.Text = "Valider";
            this.btnValiderRechCl.UseVisualStyleBackColor = true;
            this.btnValiderRechCl.Click += new System.EventHandler(this.dataGridViewRechClient_SelectionChanged);
            // 
            // btnAnullerRechCl
            // 
            this.btnAnullerRechCl.Location = new System.Drawing.Point(11, 83);
            this.btnAnullerRechCl.Name = "btnAnullerRechCl";
            this.btnAnullerRechCl.Size = new System.Drawing.Size(80, 35);
            this.btnAnullerRechCl.TabIndex = 2;
            this.btnAnullerRechCl.Text = "Annuler";
            this.btnAnullerRechCl.UseVisualStyleBackColor = true;
            this.btnAnullerRechCl.Click += new System.EventHandler(this.btnAnullerRechCl_Click);
            // 
            // btnClientInexistantRechCl
            // 
            this.btnClientInexistantRechCl.Location = new System.Drawing.Point(11, 141);
            this.btnClientInexistantRechCl.Name = "btnClientInexistantRechCl";
            this.btnClientInexistantRechCl.Size = new System.Drawing.Size(80, 35);
            this.btnClientInexistantRechCl.TabIndex = 3;
            this.btnClientInexistantRechCl.Text = "Client inexistant";
            this.btnClientInexistantRechCl.UseVisualStyleBackColor = true;
            this.btnClientInexistantRechCl.Click += new System.EventHandler(this.btnClientInexistantRechCl_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnClientInexistantRechCl);
            this.groupBox1.Controls.Add(this.btnAnullerRechCl);
            this.groupBox1.Controls.Add(this.btnValiderRechCl);
            this.groupBox1.Location = new System.Drawing.Point(693, 109);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(104, 207);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 130);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Client";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 157);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Rue";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 188);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Ville";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(-1, 224);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Code Postal";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 257);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "label5";
            // 
            // txtRechCl
            // 
            this.txtRechCl.Location = new System.Drawing.Point(49, 127);
            this.txtRechCl.Name = "txtRechCl";
            this.txtRechCl.Size = new System.Drawing.Size(108, 20);
            this.txtRechCl.TabIndex = 10;
            this.txtRechCl.TextChanged += new System.EventHandler(this.txtRechCl_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(31, 76);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(108, 20);
            this.textBox2.TabIndex = 11;
            this.textBox2.Text = "Recherche de Client";
            // 
            // txtRechClcp
            // 
            this.txtRechClcp.Location = new System.Drawing.Point(69, 221);
            this.txtRechClcp.Name = "txtRechClcp";
            this.txtRechClcp.Size = new System.Drawing.Size(88, 20);
            this.txtRechClcp.TabIndex = 12;
            this.txtRechClcp.TextChanged += new System.EventHandler(this.txtRechCl_TextChanged);
            // 
            // txtRechClVille
            // 
            this.txtRechClVille.Location = new System.Drawing.Point(49, 188);
            this.txtRechClVille.Name = "txtRechClVille";
            this.txtRechClVille.Size = new System.Drawing.Size(108, 20);
            this.txtRechClVille.TabIndex = 13;
            this.txtRechClVille.TextChanged += new System.EventHandler(this.txtRechCl_TextChanged);
            // 
            // txtRechClRue
            // 
            this.txtRechClRue.Location = new System.Drawing.Point(49, 157);
            this.txtRechClRue.Name = "txtRechClRue";
            this.txtRechClRue.Size = new System.Drawing.Size(108, 20);
            this.txtRechClRue.TabIndex = 14;
            this.txtRechClRue.TextChanged += new System.EventHandler(this.txtRechCl_TextChanged);
            // 
            // cbopérateurRechCl
            // 
            this.cbopérateurRechCl.FormattingEnabled = true;
            this.cbopérateurRechCl.Location = new System.Drawing.Point(49, 254);
            this.cbopérateurRechCl.Name = "cbopérateurRechCl";
            this.cbopérateurRechCl.Size = new System.Drawing.Size(108, 21);
            this.cbopérateurRechCl.TabIndex = 15;
            this.cbopérateurRechCl.Text = "AND";
            this.cbopérateurRechCl.TextChanged += new System.EventHandler(this.txtRechCl_TextChanged);
            // 
            // rechercheClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 534);
            this.ControlBox = false;
            this.Controls.Add(this.cbopérateurRechCl);
            this.Controls.Add(this.txtRechClRue);
            this.Controls.Add(this.txtRechClVille);
            this.Controls.Add(this.txtRechClcp);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.txtRechCl);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridViewRechClient);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "rechercheClient";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Load += new System.EventHandler(this.rechercheClient_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRechClient)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewRechClient;
        private System.Windows.Forms.Button btnValiderRechCl;
        private System.Windows.Forms.Button btnAnullerRechCl;
        private System.Windows.Forms.Button btnClientInexistantRechCl;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtRechCl;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox txtRechClcp;
        private System.Windows.Forms.TextBox txtRechClVille;
        private System.Windows.Forms.TextBox txtRechClRue;
        private System.Windows.Forms.ComboBox cbopérateurRechCl;
        private System.Windows.Forms.DataGridViewTextBoxColumn Client;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rue;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ville;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodePostal;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tél;
    }
}