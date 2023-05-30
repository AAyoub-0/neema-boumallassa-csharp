using Npgsql;
using NpgsqlTypes;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2SIO_FSI_Adminstration.Classe
{
    public class Cours
    {
        
        private int idcours;
        private string libellecours;
        private string descriptioncours;
        private int idclasse;
        private string libelleclasse;
        private Database db;

        public Cours(int idCours, string libelleCours, string descriptionCours, int idclasse)
        {
            this.idCours = idCours;
            this.libelleCours = libelleCours;
            this.descriptionCours = descriptionCours;
            this.idclasse = idclasse;
        }

        public Cours(string lib, string description, string libclasse)
        {
            this.libellecours = lib;
            this.descriptionCours = description;
            this.libelleClasse = libclasse;
        }

        public Cours() { }

        public int idCours { get => idcours; set => idcours = value; }
        public string libelleCours { get => libellecours; set => libellecours = value; }
        public string descriptionCours { get => descriptioncours; set => descriptioncours = value; }
        public int idClasse { get => idclasse; set => idclasse = value; }
        public string libelleClasse { get => libelleclasse; set => libelleclasse = value; }

        public Cours coursView()
        {
            return new Cours(this.libellecours, this.descriptioncours, this.libelleClasse);
        }
        

        public List<Cours> selectCours()
        {
            List<Cours> cours = new List<Cours>();
            db = new Database();
            var db_con = db.MyCnx;
            db_con.Open();

            string select_query = "SELECT * FROM cours ORDER BY id_cour ASC";
            NpgsqlCommand commande = new NpgsqlCommand(select_query, db_con);

            NpgsqlDataReader result = commande.ExecuteReader();
            while (result.Read())
            {
                cours.Add(new Cours(result.GetInt32(0), result.GetString(1), result.GetString(2), result.GetInt32(3) != null ? result.GetInt32(3) : 0));
            }
            db_con.Close();

            return cours;
        }

        public Boolean insertCours()
        {
            db = new Database();
            var db_con = db.MyCnx;
            db_con.Open();
            var batch = new NpgsqlBatch(db_con);

            string insert_query = "INSERT INTO cours (lib_cour, desc_cour, id_cla) values (:lib, :desc, :idCla) returning id_cour;";
            NpgsqlBatchCommand commande = new NpgsqlBatchCommand(insert_query);
            commande.Parameters.Add(new NpgsqlParameter("lib", NpgsqlDbType.Varchar)).Value = this.libellecours;
            commande.Parameters.Add(new NpgsqlParameter("desc", NpgsqlDbType.Varchar)).Value = this.descriptioncours;
            commande.Parameters.Add(new NpgsqlParameter("idCla", NpgsqlDbType.Integer)).Value = this.idclasse;
            batch.BatchCommands.Add(commande);

            var reader = batch.ExecuteReader();
            while (reader.Read())
            {
                this.idCours = reader.GetInt32(0);
            }
            return this.idCours != 0;
        }

        public Boolean updateCours()
        {
            db = new Database();
            var db_con = db.MyCnx;
            db_con.Open();

            string delete_query = "update cours set lib_cour = :lib, desc_cour = :desc, id_cla = :idCla where id_cour = :id;";
            NpgsqlCommand commande = new NpgsqlCommand(delete_query, db_con);

            commande.Parameters.Add(new NpgsqlParameter("id", NpgsqlDbType.Integer)).Value = this.idcours;
            commande.Parameters.Add(new NpgsqlParameter("lib", NpgsqlDbType.Varchar)).Value = this.libellecours;
            commande.Parameters.Add(new NpgsqlParameter("desc", NpgsqlDbType.Varchar)).Value = this.descriptioncours;
            commande.Parameters.Add(new NpgsqlParameter("idCla", NpgsqlDbType.Integer)).Value = this.idclasse;
            commande.Prepare();
            commande.CommandType = CommandType.Text;
            return commande.ExecuteNonQuery() > 0;
        }

        public Boolean deleteCours()
        {
            db = new Database();
            var db_con = db.MyCnx;
            db_con.Open();

            string delete_query = "delete from cours where id_cour = :id;";
            NpgsqlCommand commande = new NpgsqlCommand(delete_query, db_con);

            commande.Parameters.Add(new NpgsqlParameter("id", NpgsqlDbType.Integer)).Value = this.idcours;
            commande.Prepare();
            commande.CommandType = CommandType.Text;
            return commande.ExecuteNonQuery() > 0;
        }

    }
}

