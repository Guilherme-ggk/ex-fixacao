using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
        enum Menu { listagem = 1, cadastro, remover, saida, entrada, sair };
        static void Main(string[] args)
        {
            bool EscolheuSair = false;
            while (EscolheuSair == false)
            {
                Console.WriteLine("Gestor de produtos");
                Console.WriteLine("1-listagem de produtos\n2-cadastrar produtos\n3-remover\n4-adicionar saída\n5-adicionar entrada\n6-sair");
                int intop = int.Parse(Console.ReadLine());
                Menu opcao = (Menu)intop;

                if (intop > 0 && intop < 7)
                {
                    switch (opcao)
                    {
                        case Menu.listagem:
                            break;
                        case Menu.cadastro:
                            break;
                        case Menu.remover:
                            break;
                        case Menu.saida:
                            break;
                        case Menu.entrada:
                            break;
                        case Menu.sair:
                            EscolheuSair = true;
                            break;
                    }
                }
                else
                {
                    EscolheuSair = true;
                }
            }
        }
    }
}
