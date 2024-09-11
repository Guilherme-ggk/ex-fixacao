using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestor_de_Clientes_no_console
{
    internal class Program
    {
        struct Clientes
        {
            public string nome;
            public int idade;
        }

        static List<Clientes> clientes = new List<Clientes>();

        enum Menu { listagem = 1, adicionar, remover, sair };
        static void Main(string[] args)
        {
            Console.WriteLine("Gestor de Clientes");
            Console.WriteLine("1-listagem\n2-Adicionar\n3-remover\n4-sair");
            int intop = int.Parse(Console.ReadLine());
            Menu opcao = (Menu)intop;
            switch(opcao)
            {
                case Menu.listagem:
                    Listagem();
                    break;
                case Menu.adicionar:
                    break;
                case Menu.remover:
                    break;
                case Menu.sair:
                    break;
            }
        }
        static void Listagem()
        {
            if(clientes.Count > 0)
            {
                int id = 0;
                foreach (Clientes pessoa in clientes)
                {
                    Console.WriteLine($"ID: {id}");
                    Console.WriteLine(pessoa);
                    id++;
                }
            }
            else
            {
                Console.WriteLine("Nenhum cliente cadastrado!");
            }
            Console.ReadLine();
        }
    }
}
