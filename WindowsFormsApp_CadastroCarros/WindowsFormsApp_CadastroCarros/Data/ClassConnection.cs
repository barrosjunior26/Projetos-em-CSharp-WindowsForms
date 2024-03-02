using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp_CadastroCarros.Data
{
    internal class ClassConnection
    {
        private static string Servidor = "DINIZ\\SQLEXPRESS";
        private static string Banco = "CadCarros";
        private static string Usuario = "sa";
        private static string Senha = "Nvidia12345@";

        public static string DefaultConnection
        {
            get { return $"Data Source = {Servidor}; Initial Catalog = {Banco}; Integrated Security = false; User id = {Usuario}; Password = {Senha}"; }
        }
    }
}
