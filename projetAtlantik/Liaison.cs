using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projetAtlantik
{
    internal class Liaison
    {

        private string NomportDepart;
        private string NomportArrivee;
        public Liaison( string NomportDepart, string NomportArrivee) 
        {
        this.NomportDepart = NomportDepart;
        this.NomportArrivee = NomportArrivee;
        }
        public override string ToString()
        {
            return  NomportDepart.ToString() + " - " + NomportArrivee.ToString() ;
        }
    }
}
