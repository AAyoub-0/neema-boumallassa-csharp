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
        public ListeClasse()
        {
            InitializeComponent();
            classe = new Classe.Classe();
            updateForm();
        }

        private void ListeClasse_Load_1(object sender, EventArgs e)
        {
            classes = classe.selectClasse();
            dgvCLasse.DataSource = classes;
        }

        private void ajouterUneClasseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form formAjoutClasse = new AjoutClasse(this);
            formAjoutClasse.Show();
        }

        private void listeDesClassesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.updateForm();
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
    }
}
