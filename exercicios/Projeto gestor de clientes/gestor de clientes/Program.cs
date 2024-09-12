using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestor_de_clientes
{
    internal class Program
    {
        struct Clientes
        {
            public string nome;
            public int idade;
        }
        static List<Clientes> clientes = new List<Clientes>();

        enum Menu { lista = 1, adicionar, remover, sair};
        static void Main(string[] args)
        {
            bool escolheuSair = false;
            while (escolheuSair == false)
            {
                Console.WriteLine("Gestor de Clientes");
                Console.WriteLine("1-listagem\n2-adicionar\n3-remover\n4-sair");
                int intop = int.Parse(Console.ReadLine());
                Menu opcao = (Menu)intop;

                switch (opcao)
                {
                    case Menu.lista:
                        Listagem();
                        break;
                    case Menu.adicionar:
                        break;
                    case Menu.remover:
                        break;
                    case Menu.sair:
                        escolheuSair = true;
                        break;
                }
                Console.Clear();
            }

            
        }
        static void Listagem()
        {
            if(clientes.Count > 0)
            {
                int ID = 0;
                foreach (Clientes cliente in clientes)
                {
                    Console.WriteLine($"ID: {ID}");
                    Console.WriteLine(cliente);
                    ID++;
                }
            }

            else
            {
                Console.WriteLine("Nenhum cliente cadastrado!");
            }
            Console.ReadLine();
        }
        static void Remover()
        {
            Listagem();
            Console.WriteLine("Qual cliente deseja remover?");
        }
    }
}
