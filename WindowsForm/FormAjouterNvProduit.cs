using BAL;
using DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForm
{
    public partial class FormAjouterNvProduit : Form
    {
        public FormAjouterNvProduit()
        {
            InitializeComponent();
        }

        private void remplirCbTypePrduit()
        {
            cbAjProdTypeProd.Items.Clear();

            SqlConnection cn = new SqlConnection();
            SqlDataReader lect;
            cn = Global.seConnecter(Global.cs);
            lect = BALTypeProduit.GetDesignationTypeProduit(cn);
            while (lect.Read())
            {
                TypeProduit designation = new TypeProduit(lect.GetString(0));
                cbAjProdTypeProd.Items.Add(designation);
                cbAjProdTypeProd.Text = lect.GetString(0);

            }

            Global.seDeconnecter(cn);
            lect.Close();
        }

        private void FormAjouterNvProduit_Load(object sender, EventArgs e)
        {
            cbAjProdTypeProd.DisplayMember = "Designation";
            remplirCbTypePrduit();
        }

        private void btnValiderNvProduit_Click(object sender, EventArgs e)
        {
            if (txtAjProdCode.Text.Length > 0 && txtAjProdDes.Text.Length > 0 && cbAjProdTypeProd.Text.Length > 0)
            {
                SqlConnection cn = new SqlConnection();
                cn = Global.seConnecter(Global.cs);
                int res = -1;
                string Designation = cbAjProdTypeProd.Text;
                SqlDataReader lect = BALTypeProduit.GetCodeTypeProduit(cn, Designation);
                if (lect.Read())
                {
                    try
                    {
                        Produit produit = new Produit(txtAjProdCode.Text, txtAjProdDes.Text, lect.GetInt32(0));
                        res = BALProduit.AjouterNouveauProduit(produit);
                        if (res >= 0)
                        {
                            labelNvProduit.Text = "Produit Ajouter avec succès";
                            wait(4000);
                            labelNvProduit.Text = "";
                        }
                    }
                    catch {
                   
                            labelNvProduit.ForeColor = System.Drawing.Color.Red;
                            labelNvProduit.Text = "Produit ne peut pas être ajouter";
                            wait(5000);
                            labelNvProduit.Text = "";
                         }
                }
                lect.Close();
                Global.seDeconnecter(cn);
            }
            else
            {
                MessageBox.Show("s'il vous plait remplir tout les champs..!", "Erreur de Remplir", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }  
            
        }

        public void wait(int milliseconds)
        {
            var timer1 = new System.Windows.Forms.Timer();
            if (milliseconds == 0 || milliseconds < 0) return;

            // Console.WriteLine("start wait timer");
            timer1.Interval = milliseconds;
            timer1.Enabled = true;
            timer1.Start();

            timer1.Tick += (s, e) =>
            {
                timer1.Enabled = false;
                timer1.Stop();
                // Console.WriteLine("stop wait timer");
            };

            while (timer1.Enabled)
            {
                Application.DoEvents();
            }
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnAnnulerNvProduit_Click(object sender, EventArgs e)
        {
            this.Close();
            RechercheProduit rechercheProduit = new RechercheProduit();
            rechercheProduit.Show();
                     
        }
    }
}
