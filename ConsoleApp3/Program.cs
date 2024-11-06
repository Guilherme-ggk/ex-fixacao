using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
        enum Menu { soma = 1, sub, mult, div, pot, raiz, sair };
        static void Main(string[] args)
        {
            bool EscolheuSair = false;
            while (EscolheuSair == false)
            {
                Console.WriteLine("Calculadora");
                Console.WriteLine("1-Soma\n2-Subtração\n3-Multiplicação\n4-Divisão\n5-Potência\n6-Raiz\n7-Sair");
                int intop = int.Parse(Console.ReadLine());
                Menu opcao = (Menu)intop;

                switch (opcao)
                {
                    case Menu.soma:
                        Soma();
                        break;
                    case Menu.sub:
                        Sub();
                        break;
                    case Menu.mult:
                        Mult();
                        break;
                    case Menu.div:
                        Div();
                        break;
                    case Menu.pot:
                        Pot();
                        break;
                    case Menu.raiz:
                        Raiz();
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
            int resultado = n1 + n2;
            Console.WriteLine($"o resultado é {resultado}.");
            Console.ReadLine();
        }
        static void Sub()
        {
            Console.WriteLine("Digite o primeiro número:");
            int n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo número:");
            int n2 = int.Parse(Console.ReadLine());
            int resultado = n1 - n2;
            Console.WriteLine($"o resultado é {resultado}.");
            Console.ReadLine();
        }
        static void Mult()
        {
            Console.WriteLine("Digite o primeiro número:");
            int n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo número:");
            int n2 = int.Parse(Console.ReadLine());
            int resultado = n1 * n2;
            Console.WriteLine($"o resultado é {resultado}.");
            Console.ReadLine();
        }
        static void Div()
        {
            Console.WriteLine("Digite o primeiro número:");
            int n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo número:");
            int n2 = int.Parse(Console.ReadLine());
            float resultado = (float)n1 / (float)n2;
            Console.WriteLine($"o resultado é {resultado}.");
            Console.ReadLine();
        }
        static void Pot()
        {
            Console.WriteLine("Digite o número base:");
            int n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o número expoente:");
            int n2 = int.Parse(Console.ReadLine());
            int resultado = (int)Math.Pow(n1, n2);
            Console.WriteLine($"o resultado é {resultado}.");
            Console.ReadLine();
        }
        static void Raiz()
        {
            Console.WriteLine("Digite o número que deseja descobrir a base:");
            int n1 = int.Parse(Console.ReadLine());
            int resultado = (int)Math.Sqrt(n1);
            Console.WriteLine($"o resultado é {resultado}.");
            Console.ReadLine();
        }
    }
}
