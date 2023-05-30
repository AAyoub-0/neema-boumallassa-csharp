using _2SIO_FSI_Adminstration.Classe;
using Npgsql;
using NpgsqlTypes;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Data;
using System.Windows.Forms;

namespace _2SIO_FSI_Adminstration.WinForm
{
    public partial class AjoutEtudiant : Form
    {
        private Etudiant etudiant;
        private Classe.Classe classe;
        private List<Classe.Classe> classes;
        private Form formBack;
        Utilisateur utilisateur;

        public AjoutEtudiant()
        {
            InitializeComponent();
        }

        public AjoutEtudiant(Form form, Utilisateur uti)
        {
            InitializeComponent();
            this.formBack = form;
            this.utilisateur = uti;
        }

        private void AjoutEtudiant_Load(object sender, EventArgs e)
        {
            classes = new List<Classe.Classe>();
            etudiant = new Etudiant();
            classe = new Classe.Classe();
            classes = classe.selectClasse();
            foreach (var _classe in classes)
            {
                cbClasse.Items.Add(_classe.lib);
            }
            
        }

        private void bouton3_Click(object sender, EventArgs e)
        {
            int id_classe = 0;

            if (tbAENom.Text != null && tbAEPrenom.Text != null && cbClasse.SelectedItem != null && tbMail.Text != null && tbTel.Text != null)
            {
                foreach (var _classe in classes)
                {
                    if(_classe.lib == cbClasse.SelectedItem.ToString())
                    {
                        id_classe =_classe.id;
                    }
                }
                etudiant.NomEtudiant = tbAENom.Text;
                etudiant.PrenomEtudiant = tbAEPrenom.Text;
                etudiant.MaiEtu = tbMail.Text;
                etudiant.TelEtu = tbTel.Text;
                etudiant.IdClasse = id_classe;

                if (etudiant.insertEtudiant())
                {
                    MessageBox.Show($"etudiant : {etudiant.NomEtudiant}, {etudiant.PrenomEtudiant} ajouté");
                }
                else
                {
                    MessageBox.Show($"Erreur lors de l'ajout");
                }
            }
            else
            {
                MessageBox.Show($"Champs vides");
            }
        }

        private void bouton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bouton1_Click(object sender, EventArgs e)
        {
            reInitialisation();
        }

        private void reInitialisation()
        {
            tbAENom.Text = "";
            tbAEPrenom.Text = "";
        }
    }
}