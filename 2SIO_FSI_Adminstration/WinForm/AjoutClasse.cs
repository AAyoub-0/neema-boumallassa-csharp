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
    public partial class AjoutClasse : Form
    {
        private Classe.Classe classe = new Classe.Classe();
        private Form formBack;
        Utilisateur utilisateur;
        public AjoutClasse()
        {
            InitializeComponent();
        }

        public AjoutClasse(Form form, Utilisateur uti)
        {
            InitializeComponent();
            this.formBack = form;
            this.utilisateur = uti;
        }

        private void bouton2_Click(object sender, EventArgs e)
        {
            string lib_classe = tbAjoutClasse.Text;

            if (!string.IsNullOrEmpty(lib_classe))
            {
                classe.lib = lib_classe;
                if (classe.insertClasse())
                {
                    actionMessage.ForeColor = Color.Green;
                    actionMessage.Text = $"Nouvelle classe : {lib_classe} ajoutée";
                    lbAnnuleAjout.Visible = true;
                    lbAnnuleAjout.Enabled = true;
                }
                else
                {
                    actionMessage.ForeColor = Color.Red;
                    actionMessage.Text = $"Erreur lors de l'ajout";
                }
            }
            else
            {
                actionMessage.ForeColor = Color.Red;
                actionMessage.Text = "Champ vide";
            }
        }

        private void lbAnnuleAjout_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (classe != null)
            {
                if (classe.deleteClasse())
                {
                    actionMessage.ForeColor = Color.Green;
                    actionMessage.Text = $"Ajout : {classe.lib};  annulé";
                }
                else
                {
                    actionMessage.ForeColor = Color.Red;
                    actionMessage.Text = $"Erreur lors de l'annulation";
                }
            }
            else
            {
                actionMessage.ForeColor = Color.Red;
                actionMessage.Text = $"Aucun ajout récent";
            }
        }

        private void AjoutClasse_Load_1(object sender, EventArgs e)
        {
            lbAnnuleAjout.Visible = false;
            lbAnnuleAjout.Enabled = false;
        }

        private void bouton3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
