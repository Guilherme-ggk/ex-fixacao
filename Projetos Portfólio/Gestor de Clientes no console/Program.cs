using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestor_de_Clientes_no_console
{
    internal class Program
    {
        enum Menu { listagem = 1, adicionar, remover, sair };
        static void Main(string[] args)
        {
            Console.WriteLine("Gestor de Clientes");
            Console.WriteLine("1-listagem\n2-Adicionar\n3-remover\n4-sair");
            int intop = int.Parse(Console.ReadLine());
            Menu opcao = (Menu)intop;
            switch(opcao)
            {
                case Menu.listagem:
                    break;
                case Menu.adicionar:



            }
        }
    }
}
