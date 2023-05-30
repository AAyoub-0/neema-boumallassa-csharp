using _2SIO_FSI_Adminstration.Classe;
using Npgsql;
using System.Collections.Generic;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip;


namespace _2SIO_FSI_Adminstration.WinForm
{
    public partial class ListeCours : Form
    {
        Utilisateur utilisateur;
        Cours _cours = new Cours();
        Classe.Classe _classe = new Classe.Classe();
        List<Cours> mesCours = new List<Cours>();
        List<Classe.Classe> mesClasses = new List<Classe.Classe>();
        public ListeCours(Utilisateur uti)
        {
            InitializeComponent();
            mesCours = _cours.selectCours();
            mesClasses = _classe.selectClasse();
            this.utilisateur = uti;

            //Affichage dans le dataGridView
            foreach (var cours in mesCours)
            {
                foreach(var classe in mesClasses)
                {
                    if (cours.idClasse == classe.id) cours.libelleClasse = classe.lib;
                }
                dgvEtudiants.Rows.Add(cours.libelleCours, cours.libelleClasse, cours.descriptionCours);
            }
        }

        private void accueilToolStripMenuItem2_Click(object sender, System.EventArgs e)
        {
            Form accueil = new Accueil(utilisateur);
            accueil.Show();
            this.Close();
        }

        private void listeDesEtudiantsToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            Form accueil = new ListeEtudiant(utilisateur);
            accueil.Show();
            this.Close();
        }

        private void ajouterUnEtudiantToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            Form accueil = new AjoutEtudiant();
            accueil.Show();
        }

        private void listeDesClassesToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            Form accueil = new ListeClasse(utilisateur);
            accueil.Show();
            this.Close();
        }

        private void ajouterUneClasseToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            Form accueil = new AjoutClasse();
            accueil.Show();
        }

        private void listeCoursToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            Form accueil = new ListeCours(utilisateur);
            accueil.Show();
            this.Close();
        }

        private void ajouterCoursToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            Form accueil = new AjoutCours(this, utilisateur);
            accueil.Show();
        }

        private void modifierCoursToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            Form accueil = new Modifier_Cours(utilisateur);
            accueil.Show();
        }
    }
}
