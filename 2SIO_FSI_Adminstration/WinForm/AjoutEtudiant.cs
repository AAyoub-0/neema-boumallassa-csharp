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
      public partial class AjoutEtudiant : Form
      {
            NpgsqlConnection maConnexion;
            NpgsqlCommand commande, classe_query;
            public AjoutEtudiant()
            {
                  InitializeComponent();
            }
            private void bouton1_Click(object sender, EventArgs e)
            {
            reInitialisation();


        }
            private void reInitialisation()
            {
            tbAENom.Text = "";
            tbAEPrenom.Text = "";
        }

            private void bouton3_Click(object sender, EventArgs e)
            {
                  
            string a = tbAENom.Text;
            string z = tbAEPrenom.Text;

            if(a != null && z != null)
            {
                try
                {
                    string connexion = "Server=localhost;Port=5432;Database=2SIO_Appli_Administration;User Id=postgres;Password=012356;";
                    maConnexion = new NpgsqlConnection(connexion);
                    maConnexion = new NpgsqlConnection(connexion);
                    maConnexion.Open();
                    string pufff = "INSERT INTO etudiant (nomEtudiant, prenometudiant, idClasse) values ( :1, :2, 1);";
                    string select_classe = "SELECT * from classe;";
                    commande = new NpgsqlCommand(pufff, maConnexion);
                    classe_query = new NpgsqlCommand(select_classe, maConnexion);
                    commande.Parameters.Add(new NpgsqlParameter("1", NpgsqlDbType.Varchar)).Value = a;
                    commande.Parameters.Add(new NpgsqlParameter("2", NpgsqlDbType.Varchar)).Value = z;
                    commande.Prepare();
                    commande.CommandType = CommandType.Text;
                    commande.ExecuteNonQuery();
                    NpgsqlDataReader dr = classe_query.ExecuteReader();


                    MessageBox.Show("Etudiant ajouté");
                    reInitialisation();
                }
                finally
                {
                    if (commande != null) commande.Dispose();
                    if (maConnexion != null) maConnexion.Close();
                }
            }
            else
            {
                MessageBox.Show("champs vide");
            }
            
        }

            private void bouton2_Click(object sender, EventArgs e)
            {
                  this.Close();
            }
      }
}
