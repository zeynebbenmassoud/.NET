using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Client
    {
        public int NumClient { get{ return NumClient; } set{ NumClient = value; }  }
        public string NomClient { get; set; }
        public string Rue { get; set; }
        public string Ville { get; set; }
        public int CP { get; set; }
        public int Tel { get; set; }

        public Client( string NomClient, string Rue, string Ville, int CP, int Tel)
        {
            this.NomClient = NomClient;
            this.Rue = Rue;
            this.Ville = Ville;
            this.CP = CP;
            this.Tel = Tel;
        }
    }
}
