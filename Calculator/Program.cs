using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    internal class Program
    {
        enum Menu { soma = 1, sub, mult, div, pot, raiz, sair };
        static void Main(string[] args)
        {
            bool EscolheuSair = false;
            while (!EscolheuSair)
            {
                Console.WriteLine("Calculadora");
                Console.WriteLine("1-soma\n2-subtração\n3-multiplicação\n4-divisão\n5-potência\n6-raiz\n7-sair");
                int intop = int.Parse(Console.ReadLine());
                Menu opcao = (Menu)intop;

                switch (opcao)
                {
                    case Menu.soma:
                        break;
                    case Menu.sub:
                        break;
                    case Menu.mult:
                        break;
                    case Menu.div:
                        break;
                    case Menu.pot:
                        break;
                    case Menu.raiz:
                        break;
                    case Menu.sair:
                        EscolheuSair = true;
                        break;
                }
                Console.Clear();
            }
        }
        static void Soma()
        {
            Console.WriteLine("Digite o primeiro número:");
            int n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo número:");
            int n2 = int.Parse(Console.ReadLine());
            int r = n1 + n2;
            Console.WriteLine(r);
            Console.ReadKey();
        }
        static void Sub()
        {
            Console.WriteLine("Digite o primeiro número:");
            int n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo número:");
            int n2 = int.Parse(Console.ReadLine());
            int r = n1 - n2;
            Console.WriteLine(r);
            Console.ReadKey();
        }
        static void Mult()
        {
            Console.WriteLine("Digite o primeiro número:");
            int n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo número:");
            int n2 = int.Parse(Console.ReadLine());
            int r = n1 * n2;
            Console.WriteLine(r);
            Console.ReadKey();
        }
        static void Div()
        {
            Console.WriteLine("Digite o primeiro número:");
            int n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo número:");
            int n2 = int.Parse(Console.ReadLine());
            int r = n1 / n2;
            Console.WriteLine(r);
            Console.ReadKey();
        }
    }
}
