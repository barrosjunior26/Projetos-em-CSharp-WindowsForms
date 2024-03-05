using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsAppCadastroViagem.Data
{
    internal class ClassConnection
    {
        private static string Servidor = "DINIZ\\SQLEXPRESS";
        private static string Banco_Dados = "CadastroAlunos";
        private static string Usuario = "sa";
        private static string Senha = "Nvidia12345@";

        public static string DefaultConnections
        {
            get { return $"Data Source = {Servidor}; Integrated Security = false; Initial Catalog = {Banco_Dados}; User Id = {Usuario}; Password = {Senha}"; }
        }
    }
}
