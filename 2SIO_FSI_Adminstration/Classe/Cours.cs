using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2SIO_FSI_Adminstration.Classe
{
    public class Cours
    {
        
        private int idcours;
        private string libellecours;
        private string descriptioncours;
        private int idclasse;
        private string libelleclasse;




        public Cours(int idCours, string libelleCours, string descriptionCours, string libelleClasse)
        {
            this.idCours = idCours;
            this.libelleCours = libelleCours;
            this.descriptionCours = descriptionCours;
            this.libelleClasse = libelleClasse;
        }
        public Cours(int idCours, string libelleCours, string descriptionCours)
        {
            this.idCours = idCours;
            this.libelleCours = libelleCours;
            this.descriptionCours = descriptionCours;
        }
        public int idCours { get => idcours; set => idcours = value; }
            public string libelleCours { get => libellecours; set => libellecours = value; }
            public string descriptionCours { get => descriptioncours; set => descriptioncours = value; }
            public int idClasse { get => idclasse; set => idclasse = value; }
            public string libelleClasse { get => libelleclasse; set => libelleclasse = value;
        
    }

        }
    }

