using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAL
{
    public class BALTypeProduit
    {
        public static SqlDataReader GetDesignationTypeProduit(SqlConnection cn)
        {
            SqlDataReader lect;
            lect = Global.ExecuterOleDBSelect(@"SELECT Designation FROM dbo.TProduit", cn);
            return lect;
        }

        public static SqlDataReader GetCodeTypeProduit(SqlConnection cn, string Designation)
        {
            SqlDataReader lect;
            lect = Global.ExecuterOleDBSelect(@"SELECT CodeTProduit FROM dbo.TProduit WHERE Designation = '" + Designation + "'", cn);
            return lect;
        }

        public int AjouterNouveauProduit(string Desigantion)
        {
            DataEntityTier.DataSetTableAdapters.TProduitTableAdapter tProduitTableAdapter = new DataEntityTier.DataSetTableAdapters.TProduitTableAdapter();
            return tProduitTableAdapter.AjouterNouveauTypeProduit(Desigantion);
        }
    }
}
