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
        private string nombateau;
        private DateTime dateheure;

        public Traversees(int n, string nom, DateTime date)
        {
            notraversee = n;
            nombateau = nom;
            dateheure = date;
        }

        public int GetNoTraverse()
        {
            return notraversee;
        }

        public string GetNomBateau()
        {
            return nombateau;
        }

        public DateTime GetDateHeure()
        {
            return dateheure;
        }
    }
}