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
    public partial class ListeCours : Form
    {
        Utilisateur x;
        public ListeCours()
        {
            InitializeComponent();
           

            string Conx = "Server=localhost;Port=5432;Database=2SIO_Appli_Administration;User Id=postgres;Password=Y@utub32112;";
            NpgsqlConnection MyCnx = new NpgsqlConnection(Conx);
            MyCnx = new NpgsqlConnection(Conx);
            MyCnx.Open();
            string select = "select * from cours c inner join classe c2 on c.idclasse   = c2.idclasse  ";
            NpgsqlCommand MyCmd = new NpgsqlCommand(select, MyCnx);
            NpgsqlDataReader dr = MyCmd.ExecuteReader();

            List<Cours> mesEtudiant = new List<Cours>();
            while (dr.Read())
            {
                // Création de l'objet etudiant
                int idCours = dr.GetInt32(0);
                string libelleCours = dr.GetString(1);
                string descriptionCours = dr.GetString(2);
                string libelleClasse = dr.GetString(5);

                Cours unEtudiant = new Cours(idCours, libelleCours, descriptionCours, libelleClasse);
                mesEtudiant.Add(unEtudiant);

            }

            //Affichage dans le dataGridView
            foreach (Cours etu in mesEtudiant)
            {
                dgvEtudiants.Rows.Add(etu.libelleClasse, etu.libelleCours);

            }
        }
    }
}
