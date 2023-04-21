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
    public partial class Modifier_Cours : Form
    {
        List<Cours> mesCours = new List<Cours>();
        NpgsqlConnection maConnexion;
        NpgsqlCommand commande, classe_query;
        private NpgsqlConnection classeConnexion;
        public Modifier_Cours()
        {
            InitializeComponent();
        }

       

        private void Modifier_Cours_Load(object sender, EventArgs e)
        {
            string connexion_classe = "Server=localhost;Port=5432;Database=2SIO_Appli_Administration;User Id=postgres;Password=Y@utub32112;";
            string select_classe = "SELECT * from Cours;";
            classeConnexion = new NpgsqlConnection(connexion_classe);
            classeConnexion.Open();
            classe_query = new NpgsqlCommand(select_classe, classeConnexion);
            NpgsqlDataReader ajouter = classe_query.ExecuteReader();



            while (ajouter.Read())
            {
                mesCours.Add(new Cours(ajouter.GetInt32(0), ajouter.GetString(1), ajouter.GetString(2)));

            }
            
            foreach (var Cours in mesCours)
            {
                
                cbCours.Items.Add(Cours.libelleCours);



            }
        }
    
        private void cbCours_SelectedIndexChanged(object sender, EventArgs e)
        {

            string test2 = "";
            string test = "";


            foreach (var Cours in mesCours)
            {
                if (cbCours.SelectedItem == Cours.libelleCours)
                {

                    test2 = Cours.libelleCours;
                    test = Cours.descriptionCours;
                }
            }

            tbAENom.Text = test2.ToString();
            tbAEPrenom.Text = test.ToString();
        }
        private void bouton2_Click(object sender, EventArgs e)
        {

            int id_classe = 0;
            string nom = tbAENom.Text;
            string premon = tbAEPrenom.Text;
            foreach (var Cours in mesCours)
            {
                if (cbCours.SelectedItem == Cours.libelleCours)
                {

                    id_classe = Cours.idCours;
                }
            }


            string connexion = "Server=localhost;Port=5432;Database=2SIO_Appli_Administration;User Id=postgres;Password=Y@utub32112;";
            maConnexion = new NpgsqlConnection(connexion);
            maConnexion.Open();
            string pufff = " UPDATE cours SET libellecours = @FirstName , descriptioncours = @LastName WHERE idcours = :3 ; ";
            commande = new NpgsqlCommand(pufff, maConnexion);
            commande.Parameters.Add(new NpgsqlParameter("@FirstName", NpgsqlDbType.Varchar)).Value = nom;
            commande.Parameters.Add(new NpgsqlParameter("@LastName", NpgsqlDbType.Varchar)).Value = premon;
            commande.Parameters.Add(new NpgsqlParameter("3", NpgsqlDbType.Integer)).Value = id_classe;
            commande.Prepare();
            commande.CommandType = CommandType.Text;
            commande.ExecuteNonQuery();
          

        }
    }




    
}

