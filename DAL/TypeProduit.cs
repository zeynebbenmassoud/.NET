using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class TypeProduit
    {
        public  int CodeTProduit { get; set; }
        public  string Designation { get; set; }

        public TypeProduit(string Designation)
        {
            this.Designation = Designation;
        }

        public TypeProduit(int Ctp, string designation)
        {
            this.CodeTProduit = Ctp;
            this.Designation = designation;
        }

    }

   
}
