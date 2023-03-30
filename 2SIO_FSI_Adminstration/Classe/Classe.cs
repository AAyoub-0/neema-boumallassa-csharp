using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2SIO_FSI_Adminstration.Classe
{
    internal class Classe
    {
        private int id { get; set; }
        private string lib { get; set; }

        public Classe(int id, string classe)
        {
            this.id = id;
            this.lib = classe;
        }

    }
}
