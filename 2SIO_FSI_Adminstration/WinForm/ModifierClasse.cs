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
    public partial class ModifierClasse : Form
    {
        private Classe.Classe classe;
        public ModifierClasse(Classe.Classe classe)
        {
            InitializeComponent();
            this.classe = classe;
        }

        private void ModifierClasse_Load_1(object sender, EventArgs e)
        {
            if (classe != null)
            {
                tbModifClasse.ForeColor = Color.Gray;
                tbModifClasse.Text = classe.lib;
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            //update
            actionMessage.ForeColor = Color.Green;
            actionMessage.Text = "modification enregistrée";
        }

        private void boutonDelete_Click(object sender, EventArgs e)
        {
            //delete
            //message box verif
            actionMessage.ForeColor = Color.Red;
            actionMessage.Text = "classe supprimé";
        }

        private void boutonBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
