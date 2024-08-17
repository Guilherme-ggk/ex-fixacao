using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        enum Menu
        {
            listagem=1,
            cadastrar,
            remover, 
            entrada,
            saida,
            sair
        }

        static List<>
        static void Main(string[] args)
        {
            Console.WriteLine("   <<<Sistema de estoque >>>");
            Console.WriteLine("\n1-listagem\n2-cadastrar\n3-remover\n4-entrada\n5-saida\n6-sair");
            string str = Console.ReadLine();
            int intop = int.Parse(str);

        }
    }
}
