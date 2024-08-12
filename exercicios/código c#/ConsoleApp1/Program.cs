using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft;
using Newtonsoft.Json;
using System.Runtime.Serialization.Formatters.Binary;

namespace ConsoleApp1
{
    internal class Program
    {
        [System.Serializable]
        struct Cliente
        {
            public string nome;
            public string idade;
        }

        enum Menu { listagem = 1, adicionar, remover, sair }

        static List<Cliente> clientes = new List<Cliente>();
       
        static void Main()
        {
            bool escolheuSair = false;
            while (!escolheuSair)
            {
                Carregar();
                Console.WriteLine("<< Gestor de Cliente >>");
                Console.WriteLine("\n1-Listagem\n2-Adicionar\n3-Remover\n4-Sair");
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
                        escolheuSair = true;
                        break;
                }
                
                Console.Clear();
            }
            Console.ReadLine();
        }
       

        static void Listagem()
        {
            if(clientes.Count > 0)
            {
                int id = 0;
                foreach (var cliente in clientes)
                {
                    Console.WriteLine($"ID: {id}");
                    Console.WriteLine($"Nome: {cliente.nome}");
                    Console.WriteLine($"Idade: {cliente.idade}");
                    id++;
                }
            }
            else
            {
                Console.WriteLine("Nenhum cliente cadastrado!");
                Console.WriteLine("Aperte enter para voltar ao menu.");
            }
           Console.ReadLine();
        }
        static void Adicionar()
        {
            Cliente cliente = new Cliente();

            Console.WriteLine("Nome:");
            cliente.nome = Console.ReadLine();

            Console.WriteLine("Idade:");
            cliente.idade = Console.ReadLine(); 

            clientes.Add( cliente );
            Salvar();
        }
        static void Remover() 
        {
            Listagem();
            Console.WriteLine("Digite o cliente que deseja remover:(id)");
            int id = int.Parse(Console.ReadLine());
            if(id >= 0 && clientes.Count > id)
            {
                clientes.RemoveAt(id);
                Salvar();
            }
        }
        static void Salvar()
        {
            FileStream stream = new FileStream("clientes.dat",FileMode.OpenOrCreate);
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
            catch(Exception)
            {
                clientes = new List<Cliente>();
            }
            stream.Close();
        }
    }
}
