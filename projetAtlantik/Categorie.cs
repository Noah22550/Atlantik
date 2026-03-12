using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projetAtlantik
{
    internal class Categorie
    {
        private string lettre;
        private string libelle;
        public Categorie(string lettre, string libelle)
        {
            this.lettre = lettre;
            this.libelle = libelle;
        }
        public string getLettre() {  return lettre; }
        public override string ToString()
        {
            return lettre + " " + libelle;
        }
    }
}
