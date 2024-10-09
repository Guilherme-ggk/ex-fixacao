using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conversor_de_temperatura
{
    internal class Program
    {
        enum Menu { soma = 1, sub, mult, div, raiz, pot, sair };
        static void Main(string[] args)
        {
            bool escolheuSair = false;
            while (escolheuSair == false)
            {
                Console.WriteLine("### Calculadora ###");
                Console.WriteLine("1-soma\n2-subtração\n3-multiplicação\n4-divisão\n5-raiz\n6-potência\n7-sair");
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
                    case Menu.raiz:
                        Raiz();
                        break;
                    case Menu.pot:
                        Pot();
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
            Console.WriteLine("Digite o primeiro número:");
            int n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo número:");
            int n2 = int.Parse(Console.ReadLine());
            int r = n1 + n2;
            Console.WriteLine($"Resultado: {r}");
            Console.ReadKey();
        }
        static void Sub()
        {
            Console.WriteLine("Digite o primeiro número:");
            int n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo número:");
            int n2 = int.Parse(Console.ReadLine());
            int r = n1 - n2;
            Console.WriteLine($"Resultado: {r}");
            Console.ReadKey();
        }
        static void Mult()
        {
            Console.WriteLine("Digite o primeiro número:");
            int n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo número:");
            int n2 = int.Parse(Console.ReadLine());
            int r = n1 * n2;
            Console.WriteLine($"Resultado: {r}");
            Console.ReadKey();
        }
        static void Div()
        {
            Console.WriteLine("Digite o primeiro número:");
            int n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo número:");
            int n2 = int.Parse(Console.ReadLine());
            float r = (float) n1 / (float) n2;
            Console.WriteLine($"Resultado: {r}");
            Console.ReadKey();
        }
        static void Raiz()
        {
            Console.WriteLine("Digite o número:");
            int n1 = int.Parse(Console.ReadLine());
            int r = (int)Math.Sqrt(n1);
            Console.WriteLine($"Resultado: {r}");
            Console.ReadKey();
        }
        static void Pot()
        {
            Console.WriteLine("Digite o número base:");
            int b1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o número expoente:");
            int e2 = int.Parse(Console.ReadLine());
            int r = (int)Math.Pow(b1, e2);
            Console.WriteLine($"Resultado: {r}");
            Console.ReadKey();
        }
    }
}
