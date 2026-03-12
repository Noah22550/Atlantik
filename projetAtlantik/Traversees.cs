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
        private string nom;
        private DateTime dateheuredepart;

        public Traversees(int notraversee, string nom, DateTime dateheuredepart)
        {
            this.notraversee = notraversee;
            this.nom = nom;
            this.dateheuredepart = dateheuredepart;
        }

        public int GetNoTraversee()
        {
            return notraversee;
        }

        public string GetNom()
        {
            return nom;
        }

        public DateTime GetDateHeureDepart()
        {
            return dateheuredepart;
        }
    }
}
