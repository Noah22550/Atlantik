using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projetAtlantik
{
    internal class Liaison
    {
        private int NoLiaison;
        private int NoportDepart;
        private int NoSecteur;
        private int NoportArrivee;
        private double Distance;
        public Liaison(int NoLiaison, int NoportDepart, int NoSecteur, int NoportArrivee, double Distance) 
        {
        this.NoLiaison = NoLiaison;
        this.NoportDepart = NoportDepart;
        this.NoSecteur = NoSecteur;
        this.NoportArrivee = NoportArrivee;
        this.Distance = Distance;
        }
        public int GetNoportDepart() {return NoportDepart; }
        public int GetNoSecteur() { return NoSecteur; }
        public int GetNoPortArrivee() {  return NoportArrivee; }
        public double GetDistance() {  return Distance; }
        //public override string ToString()
       // {
            //return NoportDepart.ToString() + No ;
        //}
    }
}
