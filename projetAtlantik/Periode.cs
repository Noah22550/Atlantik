using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projetAtlantik
{
    internal class Periode
    {
        private string DateDebut;
        private string DateFin;
        private int NoPeriode;
        public Periode (string DateDebut, string DateFin, int noPeriode)
        {
            this.DateDebut = DateDebut;
            this.DateFin = DateFin;
            NoPeriode = noPeriode;  
        }
        public int GetNoPeriode() {  return NoPeriode; }
        public override string ToString()
        {
            return "Date de debut : " + DateDebut.ToString() + " Date de fin : " + DateFin.ToString();
        }
    }
}
