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
        public Bateau(string nom)
        {
            this.nom = nom;
        }
        public override string ToString()
        {
            return nom;
        }
    }
}
