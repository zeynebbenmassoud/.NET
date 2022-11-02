using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAL
{
    public class BALProduit
    {
        public static SqlDataReader rechercheInfoProduit(string Designation, SqlConnection cn)
        {
            SqlDataReader lect;
            lect = Global.ExecuterOleDBSelect(@"SELECT codeProduit, Designation, CodeTProduit FROM dbo.Produit WHERE Designation " + Designation, cn);
            return lect;
        }

        public static SqlDataReader GetProduit(SqlConnection cn)
        {
            SqlDataReader lect;
            lect = Global.ExecuterOleDBSelect(@"SELECT codeProduit, Designation, CodeTProduit FROM dbo.Produit ", cn);
            return lect;
        }

        public static SqlDataReader GetProduitByID(SqlConnection cn, string produit)
        {
            SqlDataReader lect;
            lect = Global.ExecuterOleDBSelect(@"SELECT codeProduit, p.Designation, tp.Designation FROM dbo.Produit p, dbo.TProduit tp WHERE p.CodeTProduit= tp.CodeTProduit AND codeProduit = '" + produit + "'", cn);
            return lect;
        }

        public static int AjouterNouveauProduit(DAL.Produit produit)
        {
            DataEntityTier.DataSetTableAdapters.ProduitTableAdapter tProduitTableAdapter = new DataEntityTier.DataSetTableAdapters.ProduitTableAdapter();
            return tProduitTableAdapter.AjouterNouveauProduit(produit.CodeProduit, produit.Designation, produit.CodeTProduit);
        }
    }
}
