using _2SIO_FSI_Adminstration.Classe;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace _2SIO_FSI_Adminstration.WinForm
{
    public partial class ListeEtudiant : Form
    {
        Utilisateur utilisateur;
        Etudiant _etudiant = new Etudiant();
        Classe.Classe _classe = new Classe.Classe();
        List<Etudiant> mesEtudiants = new List<Etudiant>();
        List<Classe.Classe> mesClasses = new List<Classe.Classe>();
        public ListeEtudiant(Utilisateur utiConnecte)
        {
            InitializeComponent();
            utilisateur = utiConnecte;
            Form formAccueil = new Accueil(utilisateur);
            formAccueil.Close();
            mesEtudiants = _etudiant.selectEtudiant();
            mesClasses = _classe.selectClasse();

            //Affichage dans le dataGridView
            foreach (var etu in mesEtudiants)
            {
                foreach(var classe in mesClasses)
                {
                    if(classe.id == etu.IdClasse)
                    {
                        etu.ClasseEtudiant = classe.lib;
                    }
                }
                dgvEtudiants.Rows.Add(etu.NomEtudiant, etu.PrenomEtudiant, etu.ClasseEtudiant);
            }
        }

        private void bQuitter_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void dgvEtudiants_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvEtudiants.Rows[e.RowIndex].Cells[0].Value != null)
            {
                Etudiant etudiant_clicked = new Etudiant();
                foreach(var etud in mesEtudiants)
                {
                    if(etud.NomEtudiant == dgvEtudiants.Rows[e.RowIndex].Cells[0].Value.ToString())
                    {
                        etudiant_clicked = etud;
                    }
                }
                Form formModifEtud = new ModifierEtudiant(etudiant_clicked, utilisateur);
                formModifEtud.Show();
            }
        }

        private void accueilToolStripMenuItem2_Click_1(object sender, EventArgs e)
        {
            Form formAccueil = new Accueil(utilisateur);
            this.Close();
            formAccueil.Show();
        }

        private void listeDesEtudiantsToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Form formListeEtudiant = new ListeEtudiant(utilisateur);
            this.Close();
            formListeEtudiant.Show();
        }

        private void ajouterUnEtudiantToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Form formAjouterEtudiant = new AjoutEtudiant();
            formAjouterEtudiant.Show();
        }

        private void listeDesClassesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form formListeEtudiant = new ListeClasse(utilisateur);
            this.Close();
            formListeEtudiant.Show();
        }

        private void ajouterUneClasseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form formListeEtudiant = new AjoutClasse(this, utilisateur);
            formListeEtudiant.Show();
        }

        private void listeCoursToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form formListeEtudiant = new ListeCours(utilisateur);
            this.Close();
            formListeEtudiant.Show();
        }

        private void ajouterCoursToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form formListeEtudiant = new AjoutCours(this, utilisateur);
            formListeEtudiant.Show();
        }

        private void modifierCoursToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form formListeEtudiant = new Modifier_Cours(utilisateur);
            formListeEtudiant.Show();
        }
    }
}
