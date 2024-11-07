using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
        [System.Serializable]
        struct Cliente
        {
            public string nome;
            public int idade;
        }

        static List<Cliente> clientes = new List<Cliente>();

        enum Menu { listagem = 1, adicionar, remover, sair };
        static void Main(string[] args)
        {
            Carregar();
            bool EscolheuSair = false;
            while (EscolheuSair == false)
            {
                Console.WriteLine("Gerenciador de Clientes no console");
                Console.WriteLine("1-listagem\n2-adicionar\n3-remover\n4-sair");
                int intop = int.Parse(Console.ReadLine());
                Menu opcao = (Menu)intop;

                switch (opcao)
                {
                    case Menu.listagem:
                        Listagem();
                        break;
                    case Menu.adicionar:
                        Adicionar();
                        break;
                    case Menu.remover:
                        Remover();
                        break;
                    case Menu.sair:
                        EscolheuSair = true;
                        break;
                }
                Console.Clear();
            }
        }
        static void Remover()
        {
            Listagem();
            Console.WriteLine("Qual cliente deseja remover?(id)");
            int id = int.Parse(Console.ReadLine());
            if (id >= 0 && clientes.Count > id)
            {
                clientes.RemoveAt(id);
                Salvar();
            }
        }
        static void Listagem()
        {
            if(clientes.Count > 0)
            {
                int id = 0;
                foreach (var cliente in clientes)
                {
                    Console.WriteLine($"{id}");
                    Console.WriteLine($"Nome: {cliente.nome}");
                    Console.WriteLine($"Idade: {cliente.idade}");
                    id++;
                }
            }
            else
            {
                Console.WriteLine("Nenhum cliente cadastrado!");
            }
            Console.ReadLine();
        }

        static void Adicionar()
        {
            Cliente cliente = new Cliente();

            Console.WriteLine("Nome:");
            cliente.nome = Console.ReadLine();
            Console.WriteLine("Idade:");
            cliente.idade = int.Parse(Console.ReadLine());
            clientes.Add(cliente);
            Salvar();
        }

        static void Salvar()
        {
            FileStream stream = new FileStream("clientes.dat", FileMode.OpenOrCreate);
            BinaryFormatter encoder = new BinaryFormatter();

            encoder.Serialize(stream, clientes);

            stream.Close();
        }
        static void Carregar()
        {
            FileStream stream = new FileStream("clientes.dat", FileMode.OpenOrCreate);
            try
            {
                BinaryFormatter encoder = new BinaryFormatter();

                clientes = (List<Cliente>)encoder.Deserialize(stream);

                if(clientes == null)
                {
                    clientes = new List<Cliente>();
                }
            }
            catch (Exception)
            {
                clientes = new List<Cliente>();
            }
            stream.Close();
        }
    }
}
