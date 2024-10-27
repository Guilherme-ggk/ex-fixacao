using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] numeros = 
               {
                { 10, 20, 30 },
                { 40, 50, 60 },
                { 70, 80, 90 }
               };

            Console.Write("[" + numeros[0, 0] + "]");
            Console.Write("[" + numeros[0, 1] + "]");
            Console.Write("[" + numeros[0, 2] + "]");
            Console.WriteLine("\n");
            Console.Write("[" + numeros[1, 0] + "]");
            Console.Write("[" + numeros[1, 1] + "]");
            Console.Write("[" + numeros[1, 2] + "]");
            Console.WriteLine("\n");
            Console.Write("[" + numeros[2, 0] + "]");
            Console.Write("[" + numeros[2, 1] + "]");
            Console.Write("[" + numeros[2, 2] + "]");
            Console.WriteLine("\n");


            string[,] nome = 
             {
                { "Giovana", "Daurizio", "Santos" },
                { "Guilherme", "Henrique", "Maximo" },
                { "Kira", "Banguela", "Margot"}
             };

            Console.Write("[" + nome[0, 0] + "]");
            Console.Write("[" + nome[0, 1] + "]");
            Console.Write("[" + nome[0, 2] + "]");
            Console.WriteLine("\n");
            Console.Write("[" + nome[1, 0] + "]");
            Console.Write("[" + nome[1, 1] + "]");
            Console.Write("[" + nome[1, 2] + "]");
            Console.WriteLine("\n");
            Console.Write("[" + nome[2, 0] + "]");
            Console.Write("[" + nome[2, 1] + "]");
            Console.Write("[" + nome[2, 2] + "]");



            Console.ReadLine();
        }
    }
}
