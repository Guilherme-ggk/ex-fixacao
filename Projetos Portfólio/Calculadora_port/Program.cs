using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora_port
{
    internal class Program
    {
        enum Menu { soma = 1, sub, div, mult, pot, raiz, sair };
        static void Main(string[] args)
        {
            bool escolheuSair = false;

            while (escolheuSair == false)
            {
                Console.WriteLine(" <<< Calculadora >>>");
                Console.WriteLine("1-Soma\n2-Subtração\n3-Divisão\n4-Multiplicação\n5-Potência\n6-Raiz\n7-Sair");

                Menu opcao = (Menu)int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case Menu.soma:
                        Soma();
                        break;
                    case Menu.sub:
                        break;
                    case Menu.div:
                        break;
                    case Menu.mult:
                        break;
                    case Menu.pot:
                        break;
                    case Menu.raiz:
                        break;
                    case Menu.sair:
                        escolheuSair = true;
                        break;

                }
            }
        }
        static void Soma()
        {
            Console.WriteLine("");
        }
    }
}
