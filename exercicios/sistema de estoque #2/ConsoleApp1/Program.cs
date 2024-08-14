using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static List<Iestoque> produtos = new List<Iestoque>();
        enum Menu { listagem = 1, adicionar, remover, entrada, saida, sair};
        static void Main(string[] args)
        {
            bool escolheuSair = false;

            while (!escolheuSair)
            {
                Console.WriteLine("< Sistema de estoque >");
                Console.WriteLine("\n1-listagem\n2-adicionar\n-remover\n4-entrada\n5-saida\n6-sair");
                string str = Console.ReadLine();
                int intop = int.Parse(str);
                Menu escolha = (Menu)intop;

                if (intop > 0 && intop > 7)
                {
                    switch (escolha)
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
                            escolheuSair = true;
                            break;
                    }
                }
                else
                {
                    escolheuSair = true;
                }
                Console.Clear();
            }
        }
    }
}
