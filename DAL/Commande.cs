using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Commande
    {
        public int NumCmd { get; set; }
        public DateTime DateCmd { get; set; }
        public int NumClient { get; set; }

        public Commande(int NumClient, DateTime DateCmd)
        {
            this.NumClient = NumClient;
            this.DateCmd = DateCmd;
        }

    }

}
