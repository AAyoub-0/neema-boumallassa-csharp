using _2SIO_FSI_Adminstration.Classe;
using _2SIO_FSI_Adminstration.WinForm;
using System;
using System.Windows.Forms;

namespace _2SIO_FSI_Adminstration
{
    public partial class Accueil : Form
    {
        Utilisateur uti;
        public Accueil(Utilisateur utiConnecte)
        {
            InitializeComponent();
            uti = utiConnecte;
            Form formConnexion = new Connexion();
            formConnexion.Close();
            tbUserConnecte.Text = uti.LoginUtilisateur;
        }

        public Accueil() { }

        private void bQuitter_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void listeDesEtudiantsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form formListeEtudiant = new ListeEtudiant(uti);
            this.Close();
            formListeEtudiant.Show();
        }

        private void ajouterUnEtudiantToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form formAjouterEtudiant = new AjoutEtudiant();
            Form formListeEtudiant = new ListeEtudiant(uti);
            this.Close();
            formListeEtudiant.Show();
            formAjouterEtudiant.Show();
        }

        private void listeDesClassesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form formListeClasse = new ListeClasse(uti);
            this.Close();
            formListeClasse.Show();
        }

        private void lToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form formListeCours = new ListeCours(uti);
            formListeCours.Show();
        }

        private void ajouterUnCoursToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form formAjoutCours = new AjoutCours(this, uti);
            formAjoutCours.Show();
        }

        private void modifierCoursToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form formModifier_Cours = new Modifier_Cours(uti);
            formModifier_Cours.Show();
        }

        private void ajouterUneClasseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form formAjoutClasse = new AjoutClasse(this, uti);
            formAjoutClasse.Show();
        }
    }
}
