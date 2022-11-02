using BAL;
using DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForm
{
    public partial class FormAjoutNvClient : Form
    {
        public FormAjoutNvClient()
        {
            InitializeComponent();
        }

        private void btnAnnulertxtAjouNvCl_Click(object sender, EventArgs e)
        {  
                this.Close();

                rechercheClient rechercheClient = new rechercheClient();
                rechercheClient.Show();
            
        }

        private void btnValiderAjouNvCl_Click(object sender, EventArgs e)
        {
            int res = -1, CP, Tel;
            if (int.TryParse(txtAjouNvClcp.Text, out CP) == true && int.TryParse(txtAjouNvClTel.Text, out Tel) == true)
            {
                Client cl = new Client(txtAjouNvCl.Text, txtAjouNvClRue.Text, txtAjouNvClVille.Text, CP, Tel);
                res = BALClient.AjouterClient(cl);
                if (res >= 0)
                {
                    txtResultat.Text = "Client ajoutée avec succès";
                    return;
                }
            }
            else 
            {
                txtResultat.ForeColor = System.Drawing.Color.Red;
                txtResultat.Text = "les champs code postale et Tel doivent être un nombre";
            }

        }

      
    }
}
