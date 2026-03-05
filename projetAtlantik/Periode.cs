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
        public Periode (string DateDebut, string DateFin)
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
