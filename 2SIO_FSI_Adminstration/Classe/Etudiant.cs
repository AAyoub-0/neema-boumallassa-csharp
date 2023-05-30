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
    public class Etudiant
    {
        private int idEtudiant;
        private string nomEtudiant;
        private string prenomEtudiant;
        private string classeEtudiant;
        private string telEtu;
        private string maiEtu;
        private int idClasse;
        private Database db;


        public Etudiant(int id, string nom, string prenom, string telEtu, string maiEtu, int id_classe)
        {
            this.idEtudiant = id;
            this.nomEtudiant = nom;
            this.prenomEtudiant = prenom;
            this.idClasse = id_classe;
            this.telEtu = telEtu;
            this.maiEtu = maiEtu;
        }

        public Etudiant() { }

        public int IdEtudiant { get => idEtudiant; set => idEtudiant = value; }
        public string NomEtudiant { get => nomEtudiant; set => nomEtudiant = value; }
        public string PrenomEtudiant { get => prenomEtudiant; set => prenomEtudiant = value; }
        public string ClasseEtudiant { get => classeEtudiant; set => classeEtudiant = value; }
        public string TelEtu { get => telEtu; set => telEtu = value; }
        public string MaiEtu { get => maiEtu; set => maiEtu = value; }
        public int IdClasse { get => idClasse; set => idClasse = value; }

        public override string ToString()
        {
            return "Etudiant " + NomEtudiant;
        }


        public List<Etudiant> selectEtudiant()
        {
            List<Etudiant> etudiants = new List<Etudiant>();
            db = new Database();
            var db_con = db.MyCnx;
            db_con.Open();

            string select_query = "SELECT * FROM etudiants ORDER BY id_etu ASC";
            NpgsqlCommand commande = new NpgsqlCommand(select_query, db_con);


            NpgsqlDataReader result = commande.ExecuteReader();
            while (result.Read())
            {
                etudiants.Add(new Etudiant(result.GetInt32(0), result.GetString(1), result.GetString(2), result.GetString(3), result.GetString(4), result.GetInt32(5) != null ? result.GetInt32(5) : 0));
            }
            db_con.Close();

            return etudiants;
        }

        public Boolean insertEtudiant()
        {
            db = new Database();
            var db_con = db.MyCnx;
            db_con.Open();
            var batch = new NpgsqlBatch(db_con);

            string insert_query = "INSERT INTO etudiants (nom_etu, pre_etu, tel_etu, mai_etu, id_cla) values (:nom, :pre, :tel, :mai, :idCla) returning id_etu;";
            NpgsqlBatchCommand commande = new NpgsqlBatchCommand(insert_query);
            commande.Parameters.Add(new NpgsqlParameter("nom", NpgsqlDbType.Varchar)).Value = this.nomEtudiant;
            commande.Parameters.Add(new NpgsqlParameter("pre", NpgsqlDbType.Varchar)).Value = this.prenomEtudiant;
            commande.Parameters.Add(new NpgsqlParameter("tel", NpgsqlDbType.Varchar)).Value = this.telEtu;
            commande.Parameters.Add(new NpgsqlParameter("mai", NpgsqlDbType.Varchar)).Value = this.maiEtu;
            commande.Parameters.Add(new NpgsqlParameter("idCla", NpgsqlDbType.Integer)).Value = this.idClasse;
            batch.BatchCommands.Add(commande);

            var reader = batch.ExecuteReader();
            while (reader.Read())
            {
                this.idEtudiant = reader.GetInt32(0);
            }
            return this.idEtudiant != 0;
        }

        public Boolean updateEtudiant()
        {
            db = new Database();
            var db_con = db.MyCnx;
            db_con.Open();

            string delete_query = "update etudiants set nom_etu = :nom, pre_etu = :pre, tel_etu = :tel, mai_etu = :mai, id_cla = :idCla where id_etu = :id;";
            NpgsqlCommand commande = new NpgsqlCommand(delete_query, db_con);

            commande.Parameters.Add(new NpgsqlParameter("id", NpgsqlDbType.Integer)).Value = this.idEtudiant;
            commande.Parameters.Add(new NpgsqlParameter("nom", NpgsqlDbType.Varchar)).Value = this.nomEtudiant;
            commande.Parameters.Add(new NpgsqlParameter("pre", NpgsqlDbType.Varchar)).Value = this.prenomEtudiant;
            commande.Parameters.Add(new NpgsqlParameter("tel", NpgsqlDbType.Varchar)).Value = this.telEtu;
            commande.Parameters.Add(new NpgsqlParameter("mai", NpgsqlDbType.Varchar)).Value = this.maiEtu;
            commande.Parameters.Add(new NpgsqlParameter("idCla", NpgsqlDbType.Integer)).Value = this.idClasse;
            commande.Prepare();
            commande.CommandType = CommandType.Text;
            return commande.ExecuteNonQuery() > 0;
        }

        public Boolean deleteEtudiant()
        {
            db = new Database();
            var db_con = db.MyCnx;
            db_con.Open();

            string delete_query = "delete from etudiants where id_etu = :id;";
            NpgsqlCommand commande = new NpgsqlCommand(delete_query, db_con);

            commande.Parameters.Add(new NpgsqlParameter("id", NpgsqlDbType.Integer)).Value = this.idEtudiant;
            commande.Prepare();
            commande.CommandType = CommandType.Text;
            return commande.ExecuteNonQuery() > 0;
        }
    }
}
