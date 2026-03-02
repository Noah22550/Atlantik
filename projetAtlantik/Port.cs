using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace projetAtlantik
{
    internal class Port
    {
        private int noport;
        private string nomPort;

        public Port(int noport, string nomPort)
        {
            this.noport = noport;
            this.nomPort = nomPort;
        }

        public int GetNoport()
        {
            return noport;
        }

        public override string ToString()
        {
            return  nomPort ; 
        }
    }
}

