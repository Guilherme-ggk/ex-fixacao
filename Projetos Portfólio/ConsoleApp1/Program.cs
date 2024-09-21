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
            bool EscolheuSair = false;
            while (EscolheuSair == false)
            {
                Console.WriteLine("0<Gestor de Produtos >0");
                Console.WriteLine("1-listagem\n2-cadastrar\n3-remover\n4-entrada\n5-saída\n6-sair");
                int intop = int.Parse(Console.ReadLine());
                Menu opcao = (Menu)intop;
               
                    switch (opcao)
                    {
                        case Menu.lista:
                            break;
                        case Menu.cadastrar:
                            break;
                        case Menu.remover:
                            break;
                        case Menu.entrada:
                            break;
                        case Menu.saida:
                            break;
                        case Menu.sair:
                            EscolheuSair = true;
                            break;
                    }
                Console.Clear();
            }
        }
    }
}
