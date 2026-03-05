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
        private int NoLiaison;
        public Liaison( string NomportDepart, string NomportArrivee, int NoLiaison) 
        {
        this.NomportDepart = NomportDepart;
        this.NomportArrivee = NomportArrivee;
        this.NoLiaison = NoLiaison;
        }
        public int GetNoLiaison() { return NoLiaison;}
        public override string ToString()
        {
            return  NomportDepart.ToString() + " - " + NomportArrivee.ToString() ;
        }
    }
}
