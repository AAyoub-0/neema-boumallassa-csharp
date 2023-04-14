﻿using _2SIO_FSI_Adminstration.Classe;
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
        NpgsqlConnection maConnexion, classeConnexion;
        NpgsqlCommand commande, classe_query;
        List<Classe.Classe> classes = new List<Classe.Classe>();



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
            int id_classe = 0;

            if (a != null && z != null && cbClasse.SelectedItem != null)
            {
                try
                {
                    foreach (var classe in classes)
                    {
                        if (cbClasse.SelectedItem == classe.lib)
                        {
                            id_classe = classe.id;
                        }
                    }


                    string connexion = "Server=localhost;Port=5432;Database=2SIO_Appli_Administration;User Id=postgres;Password=Y@utub32112;";
                    maConnexion = new NpgsqlConnection(connexion);
                    maConnexion.Open();
                    string pufff = "INSERT INTO etudiant (nomEtudiant, prenometudiant, idClasse) values ( :1, :2, :3);";
                    commande = new NpgsqlCommand(pufff, maConnexion);
                    commande.Parameters.Add(new NpgsqlParameter("1", NpgsqlDbType.Varchar)).Value = a;
                    commande.Parameters.Add(new NpgsqlParameter("2", NpgsqlDbType.Varchar)).Value = z;
                    commande.Parameters.Add(new NpgsqlParameter("3", NpgsqlDbType.Integer)).Value = id_classe;
                    commande.Prepare();
                    commande.CommandType = CommandType.Text;
                    commande.ExecuteNonQuery();



                    MessageBox.Show("Etudiant ajoutÃ©");
                    reInitialisation();
                }
                finally
                {
                    if (commande != null) commande.Dispose();
                    if (maConnexion != null) maConnexion.Close();
                }
            }
            private void reInitialisation()
            {
                  tbAENom.Text = "";
                  tbAEPrenom.Text = "";
            }

        }

        private void AjoutEtudiant_Load(object sender, EventArgs e)
        {
            string connexion_classe = "Server=localhost;Port=5432;Database=2SIO_Appli_Administration;User Id=postgres;Password=Y@utub32112;";
            string select_classe = "SELECT * from classe;";
            classeConnexion = new NpgsqlConnection(connexion_classe);
            classeConnexion.Open();
            classe_query = new NpgsqlCommand(select_classe, classeConnexion);
            NpgsqlDataReader dr = classe_query.ExecuteReader();


            while (dr.Read())
            {
                classes.Add(new Classe.Classe(dr.GetInt32(0), dr.GetString(1)));

            }

            foreach (var classe in classes)
            {
                cbClasse.Items.Add(classe.lib);
            }

        }

        private void bouton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}