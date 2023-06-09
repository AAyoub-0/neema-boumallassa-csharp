﻿using _2SIO_FSI_Adminstration.Classe;
using _2SIO_FSI_Adminstration.WinForm;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

        private void PanelInterieur_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Accueil_Load(object sender, EventArgs e)
        {

        }
    }
}
