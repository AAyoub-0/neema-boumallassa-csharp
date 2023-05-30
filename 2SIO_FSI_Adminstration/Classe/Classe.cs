using Npgsql;
using NpgsqlTypes;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2SIO_FSI_Adminstration.Classe
{
    public class Classe
    {
        public int id { get; set; }
        public string lib { get; set; }
        private Database db;

        public Classe(int id, string classe)
        {
            this.id = id;
            this.lib = classe;
        }

        public Classe() { }

        public List<Classe> selectClasse()
        {
            List<Classe> classes = new List<Classe>();
            try
            {
                db = new Database();
                var db_con = db.MyCnx;
                db_con.Open();

                string select_query = "SELECT * FROM classes ORDER BY id_cla ASC";
                NpgsqlCommand commande = new NpgsqlCommand(select_query, db_con);


                NpgsqlDataReader result = commande.ExecuteReader();
                while (result.Read())
                {
                    classes.Add(new Classe(result.GetInt32(0), result.GetString(1)));
                }
                db_con.Close();

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            
            return classes;
        }

        public Boolean insertClasse()
        {
            try
            {
                db = new Database();
                var db_con = db.MyCnx;
                db_con.Open();
                var batch = new NpgsqlBatch(db_con);

                string insert_query = "INSERT INTO classes (lib_cla) values (:lib) returning id_cla;";
                NpgsqlBatchCommand commande = new NpgsqlBatchCommand(insert_query);
                commande.Parameters.Add(new NpgsqlParameter("lib", NpgsqlDbType.Varchar)).Value = this.lib;
                batch.BatchCommands.Add(commande);

                var reader = batch.ExecuteReader();
                while (reader.Read())
                {
                    this.id = reader.GetInt32(0);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            return this.id != 0;
        }

        public Boolean updateClasse()
        {
            db = new Database();
            var db_con = db.MyCnx;
            db_con.Open();

            string delete_query = "update classes set lib_cla = :lib where id_cla = :id;";
            NpgsqlCommand commande = new NpgsqlCommand(delete_query, db_con);
            try
            {
                commande.Parameters.Add(new NpgsqlParameter("id", NpgsqlDbType.Integer)).Value = this.id;
                commande.Parameters.Add(new NpgsqlParameter("lib", NpgsqlDbType.Varchar)).Value = this.lib;
                commande.Prepare();
                commande.CommandType = CommandType.Text;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            return commande.ExecuteNonQuery() > 0;
        }

        public Boolean deleteClasse()
        {
            db = new Database();
            var db_con = db.MyCnx;
            db_con.Open();

            string delete_query = "delete from classes where id_cla = :id;";
            NpgsqlCommand commande = new NpgsqlCommand(delete_query, db_con);
            try
            {
                commande.Parameters.Add(new NpgsqlParameter("id", NpgsqlDbType.Integer)).Value = this.id;
                commande.Prepare();
                commande.CommandType = CommandType.Text;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

            return commande.ExecuteNonQuery() > 0;
        }


    }
}