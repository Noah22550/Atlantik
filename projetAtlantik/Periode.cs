using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projetAtlantik
{
    internal class Periode
    {
        private double DateDebut;
        private double DateFin;
        public Periode (double DateDebut, double DateFin)
        {
            this.DateDebut = DateDebut;
            this.DateFin = DateFin;
        }
        public override string ToString()
        {
            return "Date de debut : " + DateDebut.ToString() + " Date de fin : " + DateFin.ToString();
        }
    }
}
