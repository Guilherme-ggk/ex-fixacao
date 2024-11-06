using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
        struct Cliente
        {

        }

        enum Menu { listagem = 1, adicionar, remover, sair };
        static void Main(string[] args)
        {
            bool EscolheuSair = false;
            while (EscolheuSair == false)
            {
                Console.WriteLine("Gerenciador de Clientes no console");
                int intop = int.Parse(Console.ReadLine());
                Menu opcao = (Menu)intop;

                switch (opcao)
                {
                    case Menu.listagem:
                        break;
                    case Menu.adicionar:
                        break;
                    case Menu.remover:
                        break;
                    case Menu.sair:
                        EscolheuSair = true;
                        break;
                }
            }
        }
    }
}
