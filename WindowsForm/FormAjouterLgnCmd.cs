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
    public partial class FormAjouterLgnCmd : Form
    {
        
        public LigneCommande lc = AjoutDeCommande.lc;
        public Client cl = Form1.cl;
        public int NumCmd = Form1.NumCommande;
      

        public FormAjouterLgnCmd()
        {
            InitializeComponent();
        }

        private void FormAjouterLgnCmd_Load(object sender, EventArgs e)
        {
        }

    private void txtAjouNvLgCmdProduit_KeyPress(object sender, KeyPressEventArgs e)
        {
            RechercheProduit rechercheProduit = new RechercheProduit();
            this.Close();
            rechercheProduit.Show();
        }

        private void btnAnnulertxtAjouNvCl_Click(object sender, EventArgs e)
        {
            
            this.Close();
            AjoutDeCommande ajCmd = new AjoutDeCommande();

            if (Form1.modifier_Cmd_isopen)
            {
                ajCmd.txtClientAjoutCmd.Text = cl.NomClient;
                ajCmd.txtRueAjoutCmd.Text = cl.Rue;
                ajCmd.txtTelAjoutCmd.Text = cl.Tel.ToString();
                ajCmd.txtVilleAjoutCmd.Text = cl.Ville;
                ajCmd.txtCPAjoutCmd.Text = cl.CP.ToString();
                ajCmd.txtRefAjoutCmd.Text = NumCmd.ToString();
                ajCmd.Show();
            }
            else
            {
                ajCmd.Show();
            }
        }

        private void btnValiderAjouNvCl_Click(object sender, EventArgs e)
        {
            
            int RefCmd, Qte;
            decimal prix;

            bool erreur1 = false, erreur2 = false, erreur3 = false;
            if (txtProduit.Text.Length > 0 && txtQte.Text.Length > 0 && txtPrix.Text.Length > 0 && txtRefCmd.Text.Length > 0)
            {


                SqlConnection cn = new SqlConnection();
                cn = Global.seConnecter(Global.cs);
                int res = -1;
                try
                {

                    erreur1 = int.TryParse(txtRefCmd.Text, out RefCmd);
                    erreur2 = int.TryParse(txtQte.Text, out Qte);
                    erreur3 = decimal.TryParse(txtPrix.Text, out prix);
                   //erreur3 = int.TryParse(txtPrix.Text, out Prix);
                    if (erreur1 == false || erreur2 == false || erreur3 == false)
                    {
                        MessageBox.Show("les champs Référence produit et Quantité et Prix doivent être entier", "Erreur de Remplir", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    if (this.Text == "Ajouter une nouvelle Ligne de commande") {
                       
                        LigneCommande nv = new LigneCommande(txtProduit.Text, RefCmd, Qte, prix);
                        res = BALLigneCommande.AjouterNouveauLigneCmd(nv);

                    }
                    else
                    {
                        LigneCommande nv = new LigneCommande(txtProduit.Text, RefCmd, Qte, prix);
                        res = BALLigneCommande.ModifierLigneCmd(nv, lc);
                    }
                    if (res >= 0 && this.Text == "Ajouter une nouvelle Ligne de commande")
                    {
                        txtvalidation.ForeColor = System.Drawing.Color.GreenYellow;
                        txtvalidation.Text = "Ligne Commande Ajouter avec succès";
                        wait(4000);
                        txtvalidation.Text = "";
                    }
                    else if (res >= 0 && this.Text == "Modifier Ligne de commande")
                    {
                        txtvalidation.ForeColor = System.Drawing.Color.GreenYellow;
                        txtvalidation.Text = "Ligne Commande Modifier avec succès";
                        wait(4000);
                        txtvalidation.Text = "";

                    }else
                    {
                        txtvalidation.ForeColor = System.Drawing.Color.Red;
                        txtvalidation.Text = "Produit ne peut pas être ajouter";
                        wait(5000);
                        txtvalidation.Text = "";
                    }

                    Global.seDeconnecter(cn);
                }
                catch (Exception)
                {
                    MessageBox.Show("vérifie l'exsistance de La reference commande ", "Erreur de Remplir", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
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

      
    }
}


