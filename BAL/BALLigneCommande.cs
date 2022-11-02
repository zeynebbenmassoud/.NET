using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAL
{
    public class BALLigneCommande
    {
        public static SqlDataReader GetLigneCommande(SqlConnection cn, int NumCmd)
        {
            SqlDataReader lect;
            lect = Global.ExecuterOleDBSelect(@"SELECT  CodeProduit, Qte, Prix FROM dbo.LigCommande WHERE NumCmd = " + NumCmd, cn);
            return lect;
        }

        public static SqlDataReader GetLigneCommandeByNomClient(SqlConnection cn, string NomClient)
        {
            SqlDataReader lect;
            lect = Global.ExecuterOleDBSelect(@"SELECT  CodeProduit, Qte, Prix FROM dbo.LigCommande lc, dbo.Commande cm, dbo.Client cl
                                                WHERE lc.NumCmd = cm.Numcmd AND cm.NumClient = cl.NumClient
                                                AND cl.NomClient = '" + NomClient + "'", cn);
            return lect;
        }


        public static int AjouterNouveauLigneCmd(DAL.LigneCommande lc)
        {
            DataEntityTier.DataSetTableAdapters.LigCommandeTableAdapter lcTableAdapter = new DataEntityTier.DataSetTableAdapters.LigCommandeTableAdapter();
            return lcTableAdapter.AjouterNouveauLigneCommande(lc.CodeProduit, lc.NumCmd, lc.Qte, lc.Prix);
        }

        public static int ModifierLigneCmd(DAL.LigneCommande nv, DAL.LigneCommande lc)
        {
            DataEntityTier.DataSetTableAdapters.LigCommandeTableAdapter lcTableAdapter = new DataEntityTier.DataSetTableAdapters.LigCommandeTableAdapter();
            return lcTableAdapter.ModifierLigneCommande(nv.CodeProduit, nv.NumCmd, nv.Qte, nv.Prix, lc.CodeProduit, lc.NumCmd, lc.Qte, lc.Prix);
        }

        public static int Supprimer(DAL.LigneCommande lc)
        {
            DataEntityTier.DataSetTableAdapters.LigCommandeTableAdapter lcTableAdapter = new DataEntityTier.DataSetTableAdapters.LigCommandeTableAdapter();
            return lcTableAdapter.SupprimerLigneCommande(lc.CodeProduit, lc.NumCmd, lc.Qte, lc.Prix);
        }
    }
}

