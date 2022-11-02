using BAL;
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
using DAL;

namespace WindowsForm
{
    public partial class RechercheProduit : Form
    {
        public LigneCommande lc = AjoutDeCommande.lc;
        public RechercheProduit()
        {
            InitializeComponent();
        }

        private void remplirDatagrdview()
        {
            dataGridViewRechProduit.Rows.Clear();
            SqlConnection cn = new SqlConnection();
            cn = Global.seConnecter(Global.cs);

            SqlDataReader lect = BALProduit.GetProduit(cn);
            while (lect.Read())
            {
                dataGridViewRechProduit.Rows.Add(lect.GetValue(0).ToString(), lect.GetValue(1).ToString(), lect.GetValue(2));
            }
            Global.seDeconnecter(cn);
            lect.Close();
        }

        private void RechercheProduit_Load(object sender, EventArgs e)
        {
            this.remplirDatagrdview();
        }

        private void btnAnnulerRechProduit_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormAjouterLgnCmd ajouterLgnCmd = new FormAjouterLgnCmd();
            ajouterLgnCmd.Show();

        }

        private void txtRechProduitDes_TextChanged(object sender, EventArgs e)
        {

            dataGridViewRechProduit.Rows.Clear();
            SqlConnection cn = new SqlConnection();
            cn = Global.seConnecter(Global.cs);
            SqlDataReader lect;
            string Designation = txtRechProduitDes.Text.Length <= 0 ? "like '%%' " : "like '%" + txtRechProduitDes.Text + "%'";
            lect = BALProduit.rechercheInfoProduit(Designation, cn);
            while (lect.Read())
            {
                dataGridViewRechProduit.Rows.Add(lect.GetValue(0).ToString(), lect.GetValue(1).ToString(), lect.GetValue(2));
            }
            lect.Close();
            Global.seDeconnecter(cn);

        }

        private void btnClientInexistantRechProduit_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormAjouterNvProduit nvProduit = new FormAjouterNvProduit();
            nvProduit.Show();
        }

        private void dataGridViewRechProduit_SelectionChanged(object sender, EventArgs e)
        {

            if (dataGridViewRechProduit.SelectedRows.Count > 0)
            {
                string codeProduit = dataGridViewRechProduit.SelectedRows[0].Cells[0].Value.ToString();
                string Produit = dataGridViewRechProduit.SelectedRows[0].Cells[1].Value.ToString();
                int TProduit = (int)dataGridViewRechProduit.SelectedRows[0].Cells[2].Value;
                
                DAL.Produit produit = new DAL.Produit(codeProduit, Produit, TProduit);
                FormAjouterLgnCmd ajlc = new FormAjouterLgnCmd();
                ajlc.txtProduit.Text = produit.CodeProduit;
                ajlc.txtType.Text = produit.CodeTProduit.ToString();
                ajlc.txtDesig.Text = produit.Designation;

                if (AjoutDeCommande.modifier_Lgcmd_isopen)
                {
                    ajlc.Text = "Modifier Ligne de commande";
                    ajlc.txtRefCmd.Text = lc.NumCmd.ToString();
                    ajlc.txtQte.Text = lc.Qte.ToString();
                    ajlc.txtPrix.Text = lc.Prix.ToString();

                }
                this.Close();
                ajlc.ShowDialog();
            }
            else
            {
                MessageBox.Show("Sélectionnez la ligne entière.\n" + "Cliquez sur le curseur à gauche du datagid.", "Erreur de sélection", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
    }
}
