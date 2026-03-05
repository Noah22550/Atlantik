using Org.BouncyCastle.Bcpg.OpenPgp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projetAtlantik
{
    internal class Type
    {
        private string LettreCategorie;
        private int NoType;
        private string Libelle;
        public Type(string lettreCategorie, int noType, string libelle)
        {
            LettreCategorie = lettreCategorie;
            NoType = noType;
            Libelle = libelle;
        }
        public override string ToString() { return LettreCategorie + "  " + NoType + " - " + Libelle; }
    }
}
