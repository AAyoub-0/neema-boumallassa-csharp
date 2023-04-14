using _2SIO_FSI_Adminstration.Classe;
using Npgsql;
using NpgsqlTypes;
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
    public partial class ListeEtudiant : Form
    {
        Utilisateur x;
        public ListeEtudiant(Utilisateur utiConnecte)
        {
            InitializeComponent();
            x = utiConnecte;
            Form formAccueil = new Accueil(x);
            formAccueil.Close();



            //Contrôle de la connexion
            string Conx = "Server=localhost;Port=5432;Database=2SIO_Appli_Administration;User Id=postgres;Password=Y@utub32112;";
            NpgsqlConnection MyCnx = new NpgsqlConnection(Conx);
            MyCnx = new NpgsqlConnection(Conx);
            MyCnx.Open();
            string select = "SELECT * FROM etudiant e inner join classe c ON e.idclasse  = c.idclasse ";
            NpgsqlCommand MyCmd = new NpgsqlCommand(select, MyCnx);
            NpgsqlDataReader dr = MyCmd.ExecuteReader();

            List<Etudiant> mesEtudiant = new List<Etudiant>();
            while (dr.Read())
            {
                // Création de l'objet etudiant
                int idEtudiant = dr.GetInt32(0);
                string nomEtudiant = dr.GetString(1);
                string prenomEtudiant = dr.GetString(2);
                string classeEtudiant = dr.GetString(5);

                Etudiant unEtudiant = new Etudiant(idEtudiant, nomEtudiant, prenomEtudiant, classeEtudiant);
                mesEtudiant.Add(unEtudiant);

            }

            //Affichage dans le dataGridView
            foreach (Etudiant etu in mesEtudiant)
            {
                dgvEtudiants.Rows.Add(etu.NomEtudiant, etu.PrenomEtudiant, etu.ClasseEtudiant);

            }


            MyCnx.Close();

        }

        private void bQuitter_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bFermer_Click(object sender, EventArgs e)
        {
            Form formAccueil = new Accueil(x);
            this.Close();
            formAccueil.Show();
        }

        private void listeDesEtudiantsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form formListeEtudiant = new ListeEtudiant(x);
            this.Close();
            formListeEtudiant.Show();
        }

        private void ajouterUnEtudiantToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form formAjouterEtudiant = new AjoutEtudiant();
            formAjouterEtudiant.Show();
        }

        private void accueilToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Form formAccueil = new Accueil(x);
            this.Close();
            formAccueil.Show();
        }

        private void dgvEtudiants_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void msGlobal_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
