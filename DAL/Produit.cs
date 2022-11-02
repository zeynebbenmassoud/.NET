using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Produit
    {
        public string CodeProduit { get; set; }
        public int CodeTProduit { get; set; }
        public string Designation { get; set; }

        public Produit(string CodeProduit, string Designation, int TProduit)
        {
            this.CodeProduit = CodeProduit;
            this.CodeTProduit = TProduit;
            this.Designation = Designation;
        }

    }
}
