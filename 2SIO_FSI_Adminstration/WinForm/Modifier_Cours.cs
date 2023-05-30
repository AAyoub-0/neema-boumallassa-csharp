using _2SIO_FSI_Adminstration.Classe;
using Npgsql;
using NpgsqlTypes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2SIO_FSI_Adminstration.WinForm
{
    public partial class Modifier_Cours : Form
    {
        List<Cours> mesCours = new List<Cours>();
        List<Classe.Classe> mesClasse = new List<Classe.Classe>();
        Cours _cours = new Cours();
        Classe.Classe _classe = new Classe.Classe();
        Utilisateur uti;
        public Modifier_Cours(Utilisateur uti)
        {
            InitializeComponent();
            mesCours = _cours.selectCours();
            mesClasse = _classe.selectClasse();
            this.uti = uti;


            foreach (var cours in mesCours)
            {
                cbCours.Items.Add(cours.libelleCours);
            }
            foreach (var classe in mesClasse)
            {
                cbClasse.Items.Add(classe.lib);
            }
        }

        private void cbCours_SelectedIndexChanged(object sender, EventArgs e)
        {
            int _id_classe = 0;
            foreach (var cours in mesCours)
            {
                if (cbCours.SelectedItem.ToString() == cours.libelleCours)
                {
                    _id_classe = cours.idClasse;
                    _cours.idCours = cours.idCours;
                    tbAENom.Text = cours.libelleCours;
                    tbAEPrenom.Text = cours.descriptionCours;
                    foreach(var classe in mesClasse)
                    {
                        if(_id_classe == classe.id)
                            cbClasse.SelectedItem = classe.lib;
                    }
                }
            }
        }

        private void bouton1_Click(object sender, EventArgs e)
        {
            cbCours.SelectedItem = "";
            cbClasse.SelectedItem = "";
            tbAENom.Text = "";
            tbAEPrenom.Text = "";
        }

        private void bouton3_Click(object sender, EventArgs e)
        {
            Form formListCours = new ListeCours(uti);
            formListCours.Show();
            this.Close();
        }

        private void bouton2_Click(object sender, EventArgs e)
        {
            int id_classe = 0;
            string lib = tbAENom.Text;
            string desc = tbAEPrenom.Text;
            foreach (var classe in mesClasse)
            {
                if (cbClasse.SelectedItem.ToString() == classe.lib)
                {
                    id_classe = classe.id;
                }
            }
            
            _cours.libelleCours = lib;
            _cours.descriptionCours = desc;
            _cours.idClasse = id_classe;

            if (_cours.updateCours())
            {
                MessageBox.Show("Cours modifié");
            }
            else
            {
                MessageBox.Show("Erreur lors de la modification");
            }
        }
    }




    
}

