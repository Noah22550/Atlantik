using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projetAtlantik
{
    internal class Bateau
    {
        private string nom;
        public int NoBateau;
        public Bateau(string nom, int NoBateau)
        {
            this.nom = nom;
            this.NoBateau = NoBateau;
        }
        public int GetNoBateau()
        {
            return NoBateau;
        }
        public override string ToString()
        {
            return nom;
        }
    }
}
