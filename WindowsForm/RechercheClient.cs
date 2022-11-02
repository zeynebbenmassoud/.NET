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
using BAL;

namespace WindowsForm
{
    public partial class rechercheClient : Form
    {
        public rechercheClient()
        {
            InitializeComponent();
        }

        private void dataGridViewRechClient_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void rechercheClient_Load(object sender, EventArgs e)
        {
            this.remplirDatagrdview();
        }


        private void remplirDatagrdview()
        {
            dataGridViewRechClient.Rows.Clear();
            SqlConnection cn = new SqlConnection();
            cn = Global.seConnecter(Global.cs);

            SqlDataReader lect = BALClient.GetInfoClient(cn);
            while (lect.Read())
            {
                dataGridViewRechClient.Rows.Add(lect.GetValue(0).ToString(), lect.GetValue(1).ToString(), lect.GetValue(2).ToString(), lect.GetValue(3), lect.GetValue(4));
            }
            Global.seDeconnecter(cn);
            lect.Close();
        }

       

        private void btnAnullerRechCl_Click(object sender, EventArgs e)
        {
            this.Hide();
            AjoutDeCommande ajCm = new AjoutDeCommande();
            ajCm.Show();
        }

        private void btnClientInexistantRechCl_Click(object sender, EventArgs e)
        {
            FormAjoutNvClient formAjoutNvClient = new FormAjoutNvClient();
            formAjoutNvClient.Show();

        }

        private void txtRechCl_TextChanged(object sender, EventArgs e)
        {
            dataGridViewRechClient.Rows.Clear();
            SqlConnection cn = new SqlConnection();
            cn = Global.seConnecter(Global.cs);
            SqlDataReader lect, lect1;
            string NomClient = txtRechCl.Text.Length <= 0 ? "like '%%' " : "like '%" + txtRechCl.Text + "%'";
            string Rue = txtRechClRue.Text.Length <= 0 ? "like '%%' " : "like '%" + txtRechClRue.Text + "%'";
            string Ville = txtRechClVille.Text.Length <= 0 ? "like '%%' " : "like '" + txtRechClVille.Text + "%'";
            string CP = txtRechClcp.Text.Length <= 0 ? " > 0" : " = " + txtRechClcp.Text;
            if (cbopérateurRechCl.Text == "AND")
            {
                lect = BALClient.rechercheInfoClientAND(NomClient, Rue, Ville, CP, cn);
                while (lect.Read())
                {
                    dataGridViewRechClient.Rows.Add(lect.GetValue(0).ToString(), lect.GetValue(1).ToString(), lect.GetValue(2).ToString(), lect.GetValue(3), lect.GetValue(4));
                }
                lect.Close();
            }
            //AMODIFIER !!!!!!!!!!!!!!!!!!
            if (cbopérateurRechCl.Text == "OR")
            {
                 NomClient = txtRechCl.Text.Length <= 0 ? "=''" : "like '%" + txtRechCl.Text + "%'";
                 Rue = txtRechClRue.Text.Length <= 0 ? "=''" : "like '%" + txtRechClRue.Text + "%'";
                 Ville = txtRechClVille.Text.Length <= 0 ? "=''" : "like '" + txtRechClVille.Text + "%'";

                lect1 = BALClient.rechercheInfoClientOR(NomClient, Rue, Ville, CP, cn);
                while (lect1.Read())
                {
                    dataGridViewRechClient.Rows.Add(lect1.GetValue(0).ToString(), lect1.GetValue(1).ToString(), lect1.GetValue(2).ToString(), lect1.GetValue(3), lect1.GetValue(4));
                }
                lect1.Close();
            }
            Global.seDeconnecter(cn);
            

            }

        private void dataGridViewRechClient_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewRechClient.SelectedRows.Count > 0)
            {
                string NomClient= dataGridViewRechClient.SelectedRows[0].Cells[0].Value.ToString();
                string Rue = dataGridViewRechClient.SelectedRows[0].Cells[1].Value.ToString();
                string Ville = dataGridViewRechClient.SelectedRows[0].Cells[2].Value.ToString();
                int CP = (int)dataGridViewRechClient.SelectedRows[0].Cells[3].Value;
                int Tel = (int)dataGridViewRechClient.SelectedRows[0].Cells[4].Value;

                DAL.Client cl = new DAL.Client(NomClient, Rue, Ville, CP, Tel);
                AjoutDeCommande ajcmd = new AjoutDeCommande();
                ajcmd.txtClientAjoutCmd.Text = cl.NomClient;
                ajcmd.txtRueAjoutCmd.Text = cl.Rue;
                ajcmd.txtVilleAjoutCmd.Text = cl.Ville;
                ajcmd.txtCPAjoutCmd.Text = cl.CP.ToString();
                ajcmd.txtTelAjoutCmd.Text = cl.Tel.ToString();
                this.Hide();
                ajcmd.ShowDialog();
                
                 
            }
            else
            {
                MessageBox.Show("Sélectionnez la ligne entière.\n" + "Cliquez sur le curseur à gauche du datagid.", "Erreur de sélection", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

        }
    }
}
