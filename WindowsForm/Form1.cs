using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using BAL;
using DAL;
namespace WindowsForm
{
    public partial class Form1 : Form
    {
        public static bool modifier_Cmd_isopen = false;
        public static Client cl;
        public static int NumCommande;

        public Form1()
        {
            InitializeComponent();
        }

        private void remplirDatagrdviewCommande()
        {
            dgvCommande.Rows.Clear();
            SqlConnection cn = new SqlConnection();
            cn = Global.seConnecter(Global.cs);

            SqlDataReader lect = BALCommande.GetCommande(cn);
            while (lect.Read())
            {
                dgvCommande.Rows.Add(lect.GetValue(0), lect.GetDateTime(1), lect.GetValue(2).ToString());
            }
            Global.seDeconnecter(cn);
            lect.Close();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            this.remplirDatagrdviewCommande();
        }

        private void dgvCommande_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            dgvLigneCommande.Rows.Clear();
            SqlConnection cn = new SqlConnection();
            cn = Global.seConnecter(Global.cs);
            if (dgvCommande.SelectedRows.Count > 0)
            {
                string NomClient = dgvCommande.Rows[e.RowIndex].Cells["Client"].Value.ToString();
                SqlDataReader lect = BALClient.GetClient(cn, NomClient);
                if (lect.Read())
                {
                    tbInfoClient.Text = lect.GetValue(0).ToString();
                    tbInfoClAdresse.Text = lect.GetValue(2).ToString();
                    tbInfoCVille.Text = lect.GetValue(1).ToString();
                    tbInfoClcp.Text = lect.GetValue(3).ToString();
                    tbInfoClTel.Text = lect.GetValue(4).ToString();
                }
                lect.Close();

                int NumCmd = (int)dgvCommande.Rows[e.RowIndex].Cells["RefCmd"].Value;
                lect = BALLigneCommande.GetLigneCommande(cn, NumCmd);
                while (lect.Read())
                {
                    dgvLigneCommande.Rows.Add(lect.GetValue(0).ToString(), lect.GetValue(1), lect.GetValue(2));
                }
                lect.Close();
            }
            Global.seDeconnecter(cn);
        }

        private void btnAjouterCommande_Click(object sender, EventArgs e)
        {
            this.Hide();
            AjoutDeCommande formAjoutCommande = new AjoutDeCommande();
            formAjoutCommande.Show();
        }

        private void btnModifierCommande_Click(object sender, EventArgs e)
        {
            modifier_Cmd_isopen = true;
            if (dgvCommande.SelectedRows.Count > 0)
            {

                SqlConnection cn = new SqlConnection();
                cn = Global.seConnecter(Global.cs);

                string refcl = dgvCommande.SelectedRows[0].Cells[0].Value.ToString();
                NumCommande = int.Parse(refcl);
                DateTime dateTime = (DateTime)dgvCommande.SelectedRows[0].Cells[1].Value;
                string client = dgvCommande.SelectedRows[0].Cells[2].Value.ToString();
                AjoutDeCommande ajcm = new AjoutDeCommande();
                SqlDataReader lect = BALClient.GetClient(cn, client);
                if (lect.Read())
                {
                    ajcm.txtClientAjoutCmd.Text = lect.GetString(0);
                    ajcm.txtRueAjoutCmd.Text = lect.GetString(2);
                    ajcm.txtTelAjoutCmd.Text = lect.GetValue(4).ToString();
                    ajcm.txtVilleAjoutCmd.Text = lect.GetString(1);
                    ajcm.txtCPAjoutCmd.Text = lect.GetValue(3).ToString();
                    cl = new Client(lect.GetString(0), lect.GetString(2), lect.GetString(1), (int)lect.GetValue(3), (int)lect.GetValue(4));

                }
                lect.Close();

                ajcm.Text = "Modifier une commande";
                ajcm.txtRefAjoutCmd.Text = refcl;
                ajcm.dateTimePickerAjoutCmd.Value = dateTime;

                this.Hide();
                ajcm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Sélectionnez la ligne entière.\n" + "Cliquez sur le curseur à gauche du datagid.", "Erreur de sélection", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

        }

        //formAjoutCommande.Show();

        private void btnSuppCommande_Click(object sender, EventArgs e)
        {
            if (dgvCommande.SelectedRows.Count == 0)
            {
                MessageBox.Show("Sélectionnez la ligne entière.\n" + "Cliquez sur le curseur à gauche du datagid.", "Erreur de sélection", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (MessageBox.Show("Voulez vous suppimer ce client?", "Confirmation da la suppression", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            { 

                SqlConnection cn = new SqlConnection();
                cn = Global.seConnecter(Global.cs);

                int NumCmd = (int)dgvCommande.SelectedRows[0].Cells[0].Value;
                BALCommande.SupprimerCommande(NumCmd);
                this.remplirDatagrdviewCommande();
                Global.seDeconnecter(cn);
            }
        }
    
        private void btnQuitter_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        //AMODIFRIRRRRr

        private void tbCmdRecherche_TextChanged(object sender, EventArgs e)
        {
            dgvCommande.Rows.Clear();
            SqlConnection cn = new SqlConnection();
            cn = Global.seConnecter(Global.cs);

            string NumCmd = tbIDCmdRecherche.Text.Length <= 0 ? " > 0" : " = " + tbIDCmdRecherche.Text;
            string NomClient = tbRechercheNomClient.Text.Length <= 0 ? "like '%%' " : "like '%" + tbRechercheNomClient.Text + "%'";
            //DateTime dateDebut = (DateTime)cbDateDebut.SelectedItem;
            //DateTime dateFin =(DateTime) cbDateFin.SelectedItem;
            try
            {
                SqlDataReader lect = BALCommande.rechercheCommande(NomClient, NumCmd, cn);
          
            while (lect.Read())
            {
                dgvCommande.Rows.Add(lect.GetValue(0), lect.GetDateTime(1), lect.GetValue(2).ToString());
            }
            }
            catch
            {
                //
            }
            Global.seDeconnecter(cn);
        }

        private void dgvCommande_SelectionChanged(object sender, EventArgs e)
        {

        }
    }
}
