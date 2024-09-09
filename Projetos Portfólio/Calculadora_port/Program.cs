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
                        Sub();
                        break;
                    case Menu.div:
                        Div();
                        break;
                    case Menu.mult:
                        Mult();
                        break;
                    case Menu.pot:
                        Pot();
                        break;
                    case Menu.raiz:
                        Raiz();
                        break;
                    case Menu.sair:
                        escolheuSair = true;
                        break;

                }
                Console.Clear();
            }
        }
        static void Soma()
        {
            Console.WriteLine("< Soma de dois números >");
            Console.WriteLine("Digite o primeiro número:");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo número:");
            int b = int.Parse(Console.ReadLine());
            int resultado = a + b;
            Console.WriteLine($"O resultado é {resultado}.");
            Console.WriteLine("Aperte enter para voltar ao menu.");
            Console.ReadLine();
        }
        static void Sub()
        {
            Console.WriteLine("< Subtração de dois números >");
            Console.WriteLine("Digite o primeiro número:");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo número:");
            int b = int.Parse(Console.ReadLine());
            int resultado = a - b;
            Console.WriteLine($"O resultado é {resultado}.");
            Console.WriteLine("Aperte enter para voltar ao menu.");
            Console.ReadLine();
        }
        static void Div()
        {
            Console.WriteLine("< Divisão de dois números >");
            Console.WriteLine("Digite o primeiro número:");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo número:");
            int b = int.Parse(Console.ReadLine());
            float resultado = (float)a / (float)b;
            Console.WriteLine($"O resultado é {resultado}.");
            Console.WriteLine("Aperte enter para voltar ao menu.");
            Console.ReadLine();
        }
        static void Mult()
        {
            Console.WriteLine("< Multiplicação de dois números >");
            Console.WriteLine("Digite o primeiro número:");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo número:");
            int b = int.Parse(Console.ReadLine());
            int resultado = a * b;
            Console.WriteLine($"O resultado é {resultado}.");
            Console.WriteLine("Aperte enter para voltar ao menu.");
            Console.ReadLine();
        }
        static void Pot()
        {
            Console.WriteLine("< Potência de dois números >");
            Console.WriteLine("Digite o número base:");
            int numBase = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o número expoente:");
            int numExpo = int.Parse(Console.ReadLine());
            int resultado = (int)Math.Pow(numBase, numExpo);
            Console.WriteLine($"O resultado é {resultado}.");
            Console.WriteLine("Aperte enter para voltar ao menu.");
            Console.ReadLine();
        }
        static void Raiz()
        {
            Console.WriteLine("< Raiz de um número >");
            Console.WriteLine("Digite o número:");
            int a = int.Parse(Console.ReadLine());
            double resultado = Math.Sqrt(a);
            Console.WriteLine($"O resultado é {resultado}.");
            Console.WriteLine("Aperte enter para voltar ao menu.");
            Console.ReadLine();
        }
    }
}
