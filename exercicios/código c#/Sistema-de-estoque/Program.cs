using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_estoque
{
    internal class Program
    {

        enum Menu { listagem = 1, adicionar, remover, entrada, saida, sair };

        static void Main(string[] args)
        {

            bool escolheuSair = false;

            while (escolheuSair == false)
            {

                Console.WriteLine("<<  Sistema de Estoque  >>");
                Console.WriteLine("\n1-listagem de produtos\n2-adicionar produto\n3-remover produto\n4-entrada de produtos\n5-saida de produtos\n6-sair");
                string instr = Console.ReadLine();
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
                    case Menu.entrada:
                        break;
                    case Menu.saida:
                        break;
                    case Menu.sair:
                        escolheuSair = true;
                        break;

                }
            }
        }
    }
}
