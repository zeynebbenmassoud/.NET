using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAL
{
    public class BALCommande
    {
        public static SqlDataReader GetCommande(SqlConnection cn)
        {
            SqlDataReader lect;
            lect = Global.ExecuterOleDBSelect(@"SELECT Numcmd, DateCmd, NomClient FROM dbo.Commande e, dbo.Client j WHERE e.NumClient = j.NumClient order by Numcmd desc", cn);
            return lect;
        }
        //
        public static int AjouterNouveauCommande(DAL.Commande cmd)
        {
            DataEntityTier.DataSetTableAdapters.CommandeTableAdapter cmdTableAdapter = new DataEntityTier.DataSetTableAdapters.CommandeTableAdapter();
            return cmdTableAdapter.AjouteNouveauCommande(cmd.DateCmd, cmd.NumClient);
        }

        public static int SupprimerCommande(int NumCmd)
        {
            DataEntityTier.DataSetTableAdapters.CommandeTableAdapter cmdTableAdapter = new DataEntityTier.DataSetTableAdapters.CommandeTableAdapter();
            return cmdTableAdapter.DeleteComande(NumCmd);
        }

        public static int ModifierCommande(DAL.Commande nv, DAL.Commande ancien)
        {
            DataEntityTier.DataSetTableAdapters.CommandeTableAdapter cmdTableAdapter = new DataEntityTier.DataSetTableAdapters.CommandeTableAdapter();
            return cmdTableAdapter.ModifierCommande(nv.DateCmd, nv.NumClient, ancien.NumCmd, ancien.DateCmd, ancien.NumClient, nv.NumCmd);
        }


        public static SqlDataReader GetCommandeById(SqlConnection cn, int NumCmd)
        {
            SqlDataReader lect;
            lect = Global.ExecuterOleDBSelect(@"SELECT Numcmd, DateCmd, NomClient FROM dbo.Commande e, dbo.Client j WHERE e.NumClient = j.NumClient AND Numcmd = " + NumCmd + " order by Numcmd desc", cn);
            return lect;
        }

        public static SqlDataReader GetCommandeByNomClient(SqlConnection cn, string NomClient)
        {
            SqlDataReader lect;
            lect = Global.ExecuterOleDBSelect(@"SELECT Numcmd, DateCmd, NomClient FROM dbo.Commande e, dbo.Client j WHERE e.NumClient = j.NumClient AND NomClient = " + NomClient + " order by Numcmd desc", cn);
            return lect;
        }

        public static SqlDataReader GetCommandeByDate(SqlConnection cn, DateTime dateDebut, DateTime DateFin)
        {
            SqlDataReader lect;
            lect = Global.ExecuterOleDBSelect(@"SELECT Numcmd, DateCmd, NomClient FROM dbo.Commande e, dbo.Client j WHERE e.NumClient = j.NumClient AND (DateCmd BETWEEN " + dateDebut + "AND " + DateFin + ") order by Numcmd desc", cn);
            return lect;
        }

        public static SqlDataReader rechercheCommande(string NomClient, string NumCmd, SqlConnection cn)
        {
            SqlDataReader lect;
            lect = Global.ExecuterOleDBSelect(@"SELECT Numcmd, DateCmd, NomClient FROM dbo.Commande e, dbo.Client j WHERE e.NumClient = j.NumClient AND NomClient " + NomClient + " AND Numcmd " + NumCmd + " order by Numcmd desc", cn);
            return lect;
            
        }
        
    }
}

