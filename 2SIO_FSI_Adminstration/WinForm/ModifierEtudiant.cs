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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip;

namespace _2SIO_FSI_Adminstration.WinForm
{
    public partial class ModifierEtudiant : Form
    {
        Etudiant etudiant;
        List<Classe.Classe> mesClasse = new List<Classe.Classe>();
        Classe.Classe _classe = new Classe.Classe();
        Utilisateur uti;
        public ModifierEtudiant(Etudiant etudiant, Utilisateur uti)
        {
            InitializeComponent();
            this.etudiant = etudiant;
            mesClasse = _classe.selectClasse();
            this.uti = uti;
            foreach (var classe in mesClasse)
            {
                cbClasse.Items.Add(classe.lib);
                if (classe.id == etudiant.IdClasse) etudiant.ClasseEtudiant = classe.lib;
            }
            cbClasse.SelectedItem = etudiant.ClasseEtudiant;

            tbAENom.ForeColor = Color.Gray;
            tbAEPrenom.ForeColor = Color.Gray;
            tbMail.ForeColor = Color.Gray;
            tbTel.ForeColor = Color.Gray;
            cbClasse.ForeColor = Color.Gray;

            tbAENom.Text = etudiant.NomEtudiant;
            tbAEPrenom.Text = etudiant.PrenomEtudiant;
            tbMail.Text = etudiant.MaiEtu;
            tbTel.Text = etudiant.TelEtu;

            lbCancelEtu.Enabled = false;
            lbCancelEtu.Visible = false;
            lbCancelEtu.Text = "";
        }

        private void boutonSave_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show($"Êtes-vous sur de vouloir supprimer cet étudiant : \n{etudiant.IdEtudiant}, {etudiant.NomEtudiant}", "Modification étudiant", MessageBoxButtons.YesNo);
            if(result == DialogResult.Yes)
            {
                foreach(var classe in mesClasse)
                {
                    if(classe.lib == cbClasse.SelectedItem.ToString()) etudiant.IdClasse = classe.id;
                }
                etudiant.NomEtudiant = tbAENom.Text;
                etudiant.PrenomEtudiant = tbAEPrenom.Text;
                etudiant.MaiEtu = tbMail.Text;
                etudiant.TelEtu = tbTel.Text;
                if (etudiant.updateEtudiant())
                {
                    MessageBox.Show("Modification réussit");
                }
            }
        }
        private void boutonDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show($"Êtes-vous sur de vouloir supprimer cet étudiant : \n{etudiant.IdEtudiant}, {etudiant.NomEtudiant}", "caption", MessageBoxButtons.YesNo);
            if(result == DialogResult.Yes)
            {
                if(etudiant.deleteEtudiant())
                {
                    MessageBox.Show("étudiant supprimé");
                    lbCancelEtu.Enabled = true;
                    lbCancelEtu.Visible = true;
                    lbCancelEtu.Text = "Annuler la suppression";
                }
            }
        }

        private void boutonBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tbAENom_TextChanged(object sender, EventArgs e)
        {
            if(tbAENom.Text != etudiant.NomEtudiant) 
            {
                tbAENom.ForeColor = Color.Black;
            }
        }

        private void tbAEPrenom_TextChanged(object sender, EventArgs e)
        {
            if (tbAEPrenom.Text != etudiant.PrenomEtudiant)
            {
                tbAEPrenom.ForeColor = Color.Black;
            }
        }

        private void tbMail_TextChanged(object sender, EventArgs e)
        {
            if (tbMail.Text != etudiant.MaiEtu)
            {
                tbMail.ForeColor = Color.Black;
            }
        }

        private void tbTel_TextChanged(object sender, EventArgs e)
        {
            if (tbTel.Text != etudiant.TelEtu)
            {
                tbTel.ForeColor = Color.Black;
            }
        }

        private void cbClasse_SelectedValueChanged(object sender, EventArgs e)
        {
            if(cbClasse.SelectedItem.ToString() != etudiant.ClasseEtudiant)
            {
                cbClasse.ForeColor = Color.Black;
            }
        }

        private void lbCancelEtu_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if(lbCancelEtu.Text == "Annuler la suppression")
            {
                DialogResult result = MessageBox.Show($"Voulez-vous revenir en arrière et annuler la suppression : \n{etudiant.IdEtudiant}, {etudiant.NomEtudiant}", "caption", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    etudiant.insertEtudiant();
                    MessageBox.Show("suppression annulée");
                }
            }
        }
    }
}
