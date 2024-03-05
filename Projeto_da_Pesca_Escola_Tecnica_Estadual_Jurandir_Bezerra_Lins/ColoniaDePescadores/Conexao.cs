using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace ColoniaDePescadores
{
    public class Conexao
    {
        SqlConnection conexao = new SqlConnection();

        private static string Servidor = "DINIZ\\SQLEXPRESS";
        private static string Banco = "Spark";
        private static string Usuario = "sa";
        private static string Senha = "Nvidia12345@";

        public static string Conectar
        {
            get { return $"Data Source = {Servidor}; Integrated Security = false; Initial Catalog = {Banco}; User ID = {Usuario}; PassWord = {Senha}"; }
        }
    }
}
