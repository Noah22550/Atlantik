using Org.BouncyCastle.Crypto.Digests;
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
        private int Nobateau;
        private DateTime heure;

        public Traversees(int notraversee, int Nobateau, DateTime heure)
        {
            this.notraversee = notraversee;
            this.Nobateau = Nobateau;
            this.heure = heure;
        }
        public int getNotraversee() { return notraversee; }
        public int getBateau() { return Nobateau; }
        public int GetNoTraversee()
        {
            return notraversee;
        }
        public DateTime GetDateHeureDepart()
        {
            return heure;
        }
        public override string ToString()
        {
            return bateau + " - " + notraversee + " - " + heure + " - ";
        }
    }
}
