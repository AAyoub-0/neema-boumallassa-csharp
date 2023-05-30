﻿
using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2SIO_FSI_Adminstration.Classe
{
    internal class Database
    {
        private string _dbname = "2SIO_Appli_Administration_v2";
        private string _server = "localhost";
        private string _port = "5432";
        private string _user = "postgres";
        private string _password = "012356";
        public NpgsqlConnection MyCnx { get; set; }

        public Database()
        {
            string Conx = $"Server={_server};Port={_port};Database={_dbname};User Id={_user};Password={_password};";
            this.MyCnx = new NpgsqlConnection(Conx);
        }

    }
}
