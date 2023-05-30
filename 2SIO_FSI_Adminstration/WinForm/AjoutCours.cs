using _2SIO_FSI_Adminstration.Classe;
using Npgsql;
using NpgsqlTypes;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace _2SIO_FSI_Adminstration.WinForm
{
    public partial class AjoutCours : Form
    {
        List<Classe.Classe> mesClasses = new List<Classe.Classe>();
        Classe.Classe _classe = new Classe.Classe();
        Cours _cours = new Cours();
        Utilisateur utilisateur;
        Form formBack;

        public AjoutCours(Form formBack, Utilisateur uti)
        {
            InitializeComponent();
            this.utilisateur = uti;
            this.formBack = formBack;
        }

        private void reInitialisation()
        {
            tbAENom.Text = "";
            tbAEPrenom.Text = "";
        }

        private void bouton1_Click(object sender, EventArgs e)
        {
            reInitialisation();
        }

        private void bouton3_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void AjoutCours_Load(object sender, EventArgs e)
        {
            mesClasses = _classe.selectClasse();

            foreach (var classe in mesClasses)
            {
                cbClasse.Items.Add(classe.lib);
            }
        }

        private void bouton2_Click(object sender, EventArgs e)
        {

            string lib = tbAENom.Text;
            string desc = tbAEPrenom.Text;
            int id_classe = 0;


            if (lib != null && desc != null && cbClasse.SelectedItem.ToString() != "")
            {
                foreach (var classe in mesClasses)
                {
                    if (cbClasse.SelectedItem.ToString() == classe.lib)
                    {
                        id_classe = classe.id;
                    }
                }
                _cours.libelleCours = lib;
                _cours.descriptionCours = desc;
                _cours.idClasse = id_classe;

                if (_cours.insertCours())
                {
                    MessageBox.Show("Cours ajouté");
                    reInitialisation();
                }
                else
                {
                    MessageBox.Show("Erreur lors de la création du cours");
                }
                
            }
        }
    }
}
