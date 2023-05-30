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
            lbAnnuleAjout.Enabled = false;
            lbAnnuleAjout.Visible = false;
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
            classe.lib = tbModifClasse.Text;
            if (classe.updateClasse())
            {
                actionMessage.ForeColor = Color.Green;
                actionMessage.Text = "modification enregistrée";
                lbAnnuleAjout.Enabled = true;
                lbAnnuleAjout.Visible = true;
                lbAnnuleAjout.Text = "Annuler la modification";
            }
            else
            {
                actionMessage.ForeColor = Color.Red;
                actionMessage.Text = "erreur lors de la modification";
            }
           
        }

        private void boutonDelete_Click(object sender, EventArgs e)
        {
            //delete
            //message box verif
            DialogResult result = MessageBox.Show($"Êtes-vous sur de vouloir supprimer cette classe : \n{classe.id}, {classe.lib}", "caption", MessageBoxButtons.YesNo);
            if(result == DialogResult.Yes)
            {
                if (classe.deleteClasse())
                {
                    actionMessage.ForeColor = Color.Green;
                    actionMessage.Text = "classe supprimé";
                    lbAnnuleAjout.Enabled = true;
                    lbAnnuleAjout.Visible = true;
                    lbAnnuleAjout.Text = "Annuler la suppression";
                }
                else
                {
                    actionMessage.ForeColor = Color.Red;
                    actionMessage.Text = "erreur lors de la suppression";
                }
            }
        }

        private void boutonBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tbModifClasse_TextChanged(object sender, EventArgs e)
        {
            if(tbModifClasse.Text != classe.lib)
            {
                tbModifClasse.ForeColor = Color.Black;
            }
        }

        private void lbAnnuleAjout_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if(lbAnnuleAjout.Text == "Annuler la suppression")
            {
                DialogResult result = MessageBox.Show($"Voulez-vous revenir en arriere et sur la suppression : \n{classe.id}, {classe.lib}", "caption", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    classe.insertClasse();
                    actionMessage.ForeColor = Color.Green;
                    actionMessage.Text = $"suppression de : {classe.lib} annulée";
                    lbAnnuleAjout.Enabled = false;
                    lbAnnuleAjout.Visible = false;
                    lbAnnuleAjout.Text = "";
                }
            }
            else if(lbAnnuleAjout.Text == "Annuler la modification")
            {
                DialogResult result = MessageBox.Show($"Voulez-vous revenir en arriere et sur la modification : \n{classe.id}, {classe.lib}", "caption", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    //table log recup
                    actionMessage.ForeColor = Color.Green;
                    actionMessage.Text = $"modification de : {classe.lib} annulée";
                    lbAnnuleAjout.Enabled = false;
                    lbAnnuleAjout.Visible = false;
                    lbAnnuleAjout.Text = "";
                }
            }
           
        }
    }
}
