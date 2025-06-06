using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    static class Conn
    {
        private const string Servidor = "localhost";
        private const string BancoDados = "livros";
        private const string Usuario = "root";
        private const string Senha = "@Guilherme0830755";

        static public string StrConn = $"server={Servidor};database={BancoDados};user id={Usuario};password={Senha}";
    }
}
