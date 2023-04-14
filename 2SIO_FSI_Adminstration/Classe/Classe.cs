using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2SIO_FSI_Adminstration.Classe
{
    public class Classe
    {
        public int id { get; set; }
        public string lib { get; set; }

        public Classe(int id, string classe)
        {
            this.id = id;
            this.lib = classe;
        }

    }
}