using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static List<IEstoque>  produtos = new List<IEstoque>();
        enum Menu { listagem = 1, cadastrar, remover, entrada, saida, sair };
        static void Main(string[] args)
        {
            Console.WriteLine("<<Sistema de estoque>>");
            Console.WriteLine();
        }
    }
}
