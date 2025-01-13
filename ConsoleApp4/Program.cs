using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Program
    {
        enum Menu { soma = 1, sub, mult, div, potencia, raiz, sair }

        static void Main(string[] args)
        {
            bool EscolheuSair = false;
            while (!EscolheuSair)
            {
                Console.WriteLine("Calculadora:");
                Console.WriteLine("1-soma\n2-subtração\n3-multiplicação\n4-divisão\n5-potência\n6-raiz\n7-sair");
                int intop = int.Parse(Console.ReadLine());
                Menu opcao = (Menu)intop;

                switch (opcao)
                {
                    case Menu.soma:
                        Soma();
                        break;
                    case Menu.sub:
                        Subtração();
                        break;
                    case Menu.mult:
                        Multiplicação();
                        break;
                    case Menu.div:
                        Divisão();
                        break;
                    case Menu.potencia:
                        Potencia();
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
            Console.WriteLine($"Resultado: {resultado}");
            Console.ReadLine();
        }
        static void Subtração()
        {
            Console.WriteLine("Digite o primeiro número:");
            int n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo número:");
            int n2 = int.Parse(Console.ReadLine());
            int resultado = n1 - n2;
            Console.WriteLine($"Resultado: {resultado}");
            Console.ReadLine();
        }
        static void Multiplicação()
        {
            Console.WriteLine("Digite o primeiro número:");
            int n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo número:");
            int n2 = int.Parse(Console.ReadLine());
            int resultado = n1 * n2;
            Console.WriteLine($"Resultado: {resultado}");
            Console.ReadLine();
        }
        static void Divisão()
        {
            Console.WriteLine("Digite o primeiro número:");
            int n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo número:");
            int n2 = int.Parse(Console.ReadLine());
            float resultado = (float)n1 + (float)n2;
            Console.WriteLine($"Resultado: {resultado}");
            Console.ReadLine();
        }
        static void Potencia()
        {
            Console.WriteLine("Digite o número base:");
            int n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o número expoente:");
            int n2 = int.Parse(Console.ReadLine());
            int resultado = (int)Math.Pow(n1, n2);
            Console.WriteLine($"Resultado: {resultado}");
            Console.ReadLine();
        }
        static void Raiz()
        {
            Console.WriteLine("Digite o número que deseja saber a raiz:");
            int r = int.Parse(Console.ReadLine());
            int resultado = (int)Math.Sqrt(r);
            Console.WriteLine($"Resultado: {resultado}");
            Console.ReadLine();
        }
    }
}
