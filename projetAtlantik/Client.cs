using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projetAtlantik
{
    public class Client
    {
        private int noClient;
        private string nom;
        private string prenom;

        public Client(int noClient, string nom, string prenom)
        {
            this.noClient = noClient;
            this.nom = nom;
            this.prenom = prenom;
        }

        public int GetNoClient()
        {
            return noClient;
        }

        public string GetNom()
        {
            return nom;
        }

        public string GetPrenom()
        {
            return prenom;
        }

        public override string ToString()
        {
            return nom + " " + prenom;
        }
    }
}
