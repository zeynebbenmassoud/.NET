using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class LigneCommande
    {
        public string CodeProduit { get; set; }
        public int NumCmd { get; set; }
        public int Qte { get; set; }
        public decimal Prix { get; set; }

        public LigneCommande(string Cp, int numCmd, int qte, decimal prix)
        {
            this.CodeProduit = Cp;
            this.NumCmd = numCmd;
            this.Qte = qte;
            this.Prix = prix;
        }

    }

   
}
