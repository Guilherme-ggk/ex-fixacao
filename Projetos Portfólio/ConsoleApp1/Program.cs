using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        enum Menu { lista = 1, cadastrar, remover, entrada, saida, sair};

        

        static void Main(string[] args)
        {
            bool escolheuSair = false;
            while (escolheuSair == false)
            {

            }
            Console.WriteLine("0<Gestor de Produtos >0");
            Console.WriteLine("1-listagem\n2-cadastrar\n3-remover\n4-entrada\n5-saída\n6-sair");
            int intop = int.Parse(Console.ReadLine());
            Menu opcao = (Menu)intop;



        }
    }
}
