using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BAL
{
    public class BALClient
    {

        public static SqlDataReader GetInfoClient(SqlConnection cn)
        {
            SqlDataReader lect;
            lect = Global.ExecuterOleDBSelect(@"SELECT NomClient, Rue, Ville, CP, Tel FROM dbo.Client", cn);
            return lect;
        }

        public static SqlDataReader GetNumClientbyNTel(SqlConnection cn, string NumeroClient)
        {
            SqlDataReader lect;
            lect = Global.ExecuterOleDBSelect(@"SELECT NumClient FROM dbo.Client WHERE Tel = '" + NumeroClient + "'", cn);
            return lect;
        }

        public static int AjouterClient(DAL.Client cl)
        {
            DataEntityTier.DataSetTableAdapters.ClientTableAdapter clientTableAdapter = new DataEntityTier.DataSetTableAdapters.ClientTableAdapter();
            return clientTableAdapter.AjouterClient(cl.NomClient, cl.Rue, cl.Ville, cl.CP, cl.Tel);
        }


        public static int SupprimerClient(int NumClient)
        {
            DataEntityTier.DataSetTableAdapters.ClientTableAdapter clientTableAdapter = new DataEntityTier.DataSetTableAdapters.ClientTableAdapter();
            return clientTableAdapter.SupprimerClient(NumClient);
        }
        public static SqlDataReader GetClient(SqlConnection cn, string NomClient)
        {
            SqlDataReader lect;
            lect = Global.ExecuterOleDBSelect(@"SELECT NomClient, Ville, Rue, CP, Tel FROM dbo.Client WHERE NomClient = '" + NomClient + "'", cn);
            return lect;
        }

           
            
        /**
         *  private void btnAjoutClient_Click(object sender, EventArgs e)
        {
            OleDbConnection cn = new OleDbConnection();
            cn = Global.seConnecter(Global.cs);
            Global.ExecuterOleDBAction(@"insert into client (nom, adresse, solde) values('Nouveauclient','adesse',50.000)", cn);
            Global.seDeconnecter(cn);
            remplirDatagrdview();
        }

        private void btnSupprimerclient_Click(object sender, EventArgs e)
        {
            if (dgvClients.SelectedRows.Count == 0)
            {
                MessageBox.Show("Sélectionnez la ligne entière.\n" + "Cliquez sur le curseur à gauche du datagid.", "Erreur de sélection", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (MessageBox.Show("Voulez vous suppimer ce client?", "Confirmation da la suppression", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                OleDbConnection cn = new OleDbConnection();
                cn = Global.seConnecter(Global.cs);
                Global.ExecuterOleDBAction(@"delete from client where id = " + dgvClients.SelectedRows[0].Cells[0].Value.ToString(), cn);
                Global.seDeconnecter(cn);
                remplirDatagrdview();
            }

        }*/

        public static SqlDataReader rechercheInfoClientAND(string NomClient, string Rue, string Ville, string CP, SqlConnection cn)
        {
            SqlDataReader lect;
            lect = Global.ExecuterOleDBSelect(@"SELECT NomClient, Ville, Rue, CP, Tel FROM dbo.Client WHERE NomClient " + NomClient + " AND Rue " + Rue +" AND Ville " + Ville + "AND CP " + CP, cn);
            return lect;
        }

        public static SqlDataReader rechercheInfoClientOR(string NomClient, string Rue, string Ville, string CP, SqlConnection cn)
        {
            SqlDataReader lect;
            lect = Global.ExecuterOleDBSelect(@"SELECT NomClient, Ville, Rue, CP, Tel FROM dbo.Client WHERE NomClient " + NomClient + " OR Rue " + Rue + " OR Ville " + Ville + "OR CP " + CP, cn);
            return lect;
        }
    }
}
