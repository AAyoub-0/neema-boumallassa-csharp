using _2SIO_FSI_Adminstration.Classe;
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
    public partial class ListeClasse : Form
    {
        private Classe.Classe classe;
        List<Classe.Classe> classes;
        Utilisateur uti;
        public ListeClasse(Utilisateur uti)
        {
            InitializeComponent();
            classe = new Classe.Classe();
            this.uti = uti;
        }

        private void ListeClasse_Load_1(object sender, EventArgs e)
        {
            classes = classe.selectClasse();
            dgvCLasse.DataSource = classes;
        }

        public void updateForm()
        {
            classes = classe.selectClasse();
            dgvCLasse.DataSource = classes;
        }

        private void dgvCLasse_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvCLasse.Rows[e.RowIndex].Cells[0].Value != null)
            {
                Form formModifCLasse = new ModifierClasse(new Classe.Classe(int.Parse(dgvCLasse.Rows[e.RowIndex].Cells[0].Value.ToString()), dgvCLasse.Rows[e.RowIndex].Cells[1].Value.ToString()));
                formModifCLasse.Show();
            }
        }

        private void accueilToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Form accueil = new Accueil();
            accueil.Show();
            this.Close();
        }

        private void ajouterUneClasseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form formAjoutClasse = new AjoutClasse(this, uti);
            formAjoutClasse.Show();
        }

        private void listeDesClassesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.updateForm();
        }

        private void listeDesEtudiantsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form form = new ListeEtudiant(uti);
            form.Show();
            this.Close();
        }

        private void ajouterUnEtudiantToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form form = new AjoutEtudiant();
            form.Show();
        }

        private void lToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form form = new ListeCours(uti);
            form.Show();
            this.Close();
        }

        private void ajouterUnCoursToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form form = new AjoutCours(this, uti);
            form.Show();
        }

        private void modifierCoursToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form form = new Modifier_Cours(uti);
            form.Show();
        }
    }
}
