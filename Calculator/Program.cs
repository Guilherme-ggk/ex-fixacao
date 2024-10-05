﻿using System;
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
        static void Pot()
        {
            Console.WriteLine("Digite o número base:");
            int b1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o número expoente:");
            int e2 = int.Parse(Console.ReadLine());
            int r = (int)Math.Pow(b1, e2);
            Console.WriteLine(r);
            Console.ReadKey();
        }
        static void Raiz()
        {
            Console.WriteLine("Digite o número:");
            int n = int.Parse(Console.ReadLine());
            int r = (int)Math.Sqrt(n);
            Console.WriteLine(r);
            Console.ReadKey();
        }
    }
}
