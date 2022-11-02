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
    public partial class AjoutDeCommande : Form
    {
        public static LigneCommande lc;
        public static bool modifier_Lgcmd_isopen = false;
        public AjoutDeCommande()
        {
            InitializeComponent();
        }

        private void txtClientAjoutCmd_KeyPress(object sender, KeyPressEventArgs e)
        {
            rechercheClient formRechercheClient = new rechercheClient();
            this.Close();
            formRechercheClient.Show();
        }

        private void AjoutDeCommande_Load(object sender, EventArgs e)
        {
            
                this.remplirDataGridVueLigneCmd();
            
        }

        private void remplirDataGridVueLigneCmd()
        {
            if (txtClientAjoutCmd.Text.Length > 0)
            {
                string NomClient = txtClientAjoutCmd.Text;
                AjoutCommandeDataGridVie1.Rows.Clear();
                SqlConnection cn = new SqlConnection();
                cn = Global.seConnecter(Global.cs);

                SqlDataReader lect = BALLigneCommande.GetLigneCommandeByNomClient(cn, NomClient);
                while (lect.Read())
                {
                    AjoutCommandeDataGridVie1.Rows.Add(lect.GetValue(0).ToString(), lect.GetValue(1), lect.GetValue(2));
                }
                Global.seDeconnecter(cn);
                lect.Close();
            }
            
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnAjouterCmd_Click(object sender, EventArgs e)
        {
            FormAjouterLgnCmd ajouterLgnCmd = new FormAjouterLgnCmd();
            this.Close();
            ajouterLgnCmd.Show();
        }

        private void btnModifierCmd_Click(object sender, EventArgs e)
        {
            modifier_Lgcmd_isopen = true;

            if (AjoutCommandeDataGridVie1.SelectedRows.Count > 0)
            {

                SqlConnection cn = new SqlConnection();
                cn = Global.seConnecter(Global.cs);

                string Produit = AjoutCommandeDataGridVie1.SelectedRows[0].Cells[0].Value.ToString();
                int Qte = (int)AjoutCommandeDataGridVie1.SelectedRows[0].Cells[1].Value;
                decimal Prix = (decimal)AjoutCommandeDataGridVie1.SelectedRows[0].Cells[2].Value;
                int refCmd = Convert.ToInt32(txtRefAjoutCmd.Text);
                    lc = new LigneCommande(Produit, refCmd, Qte, Prix);

                    FormAjouterLgnCmd ajlcm = new FormAjouterLgnCmd();
                    ajlcm.Text = "Modifier Ligne de commande";
                    ajlcm.txtQte.Text = Qte.ToString();//
                    ajlcm.txtPrix.Text = Prix.ToString();//
                    SqlDataReader lect = BALProduit.GetProduitByID(cn, Produit);
                    if (lect.Read())
                    {
                        ajlcm.txtProduit.Text = lect.GetString(0);
                        ajlcm.txtDesig.Text = lect.GetString(1);
                        ajlcm.txtType.Text = lect.GetValue(2).ToString();
                        ajlcm.txtRefCmd.Text = refCmd.ToString();

                    }
                    lect.Close();

                    ajlcm.ShowDialog();

                }
                else
                {
                    MessageBox.Show("Sélectionnez la ligne entière.\n" + "Cliquez sur le curseur à gauche du datagid.", "Erreur de sélection", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            
        }

        private void btnSupprimerCmd_Click(object sender, EventArgs e)
        {
            if (AjoutCommandeDataGridVie1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Sélectionnez la ligne entière.\n" + "Cliquez sur le curseur à gauche du datagid.", "Erreur de sélection", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (MessageBox.Show("Voulez vous suppimer ce client?", "Confirmation da la suppression", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                SqlConnection cn = new SqlConnection();
                cn = Global.seConnecter(Global.cs);

                LigneCommande lc = new LigneCommande(AjoutCommandeDataGridVie1.SelectedRows[0].Cells[0].Value.ToString(), int.Parse(txtRefAjoutCmd.Text), (int)AjoutCommandeDataGridVie1.SelectedRows[0].Cells[1].Value, (decimal)AjoutCommandeDataGridVie1.SelectedRows[0].Cells[2].Value);
                BALLigneCommande.Supprimer(lc);
                this.remplirDataGridVueLigneCmd();
                Global.seDeconnecter(cn);
            }
        }

        private void btnValiderCmd_Click(object sender, EventArgs e)
        {
            if (txtClientAjoutCmd.Text.Length > 0 && txtCPAjoutCmd.Text.Length > 0 && txtRueAjoutCmd.Text.Length > 0 && txtTelAjoutCmd.Text.Length > 0 &&  txtVilleAjoutCmd.Text.Length > 0)
            {
                SqlConnection cn = new SqlConnection();
                cn = Global.seConnecter(Global.cs);
                int res = -1;
                string NumeroClient = txtTelAjoutCmd.Text;
                SqlDataReader lect = BALClient.GetNumClientbyNTel(cn, NumeroClient);
                if (lect.Read())
                {
                    try
                    {
                        Commande cmd = new Commande(lect.GetInt32(0), dateTimePickerAjoutCmd.Value);
                        res = BALCommande.AjouterNouveauCommande(cmd);
                        if (res >= 0)
                        {
                            MessageBox.Show("Commande ajouter avec succès","", MessageBoxButtons.OK);
                        }
                    }
                    catch
                    {
                        MessageBox.Show("Veuillez remplir tous les champs client", "", MessageBoxButtons.OK, MessageBoxIcon.Error);

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


        private void btnAnnulerCmd_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 f1 = new Form1();
            f1.Show();
        }

       
    }
}
