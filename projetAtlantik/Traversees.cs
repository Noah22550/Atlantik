using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projetAtlantik
{
    public class Traversees
    {
        private int notraversee;
        private string bateau;
        private DateTime heure;

        public Traversees(int notraversee, string bateau, DateTime heure)
        {
            this.notraversee = notraversee;
            this.bateau = bateau;
            this.heure = heure;
        }

        public int GetNoTraversee()
        {
            return notraversee;
        }
        public DateTime GetDateHeureDepart()
        {
            return heure;
        }
    }
}
