using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Program
    {
        [Serializable]
       struct Cliente
        {
            public string nome;
        }
        static List<Cliente> clientes = new List<Cliente>();

        enum Menu { listagem = 1, adicionar, remover, sair }

        static void Main(string[] args)
        {
            Carregar();
            bool EscolheuSair = false;
            while (!EscolheuSair)
            {
                Console.WriteLine("Gestor de clientes");
                Console.WriteLine("1-lista\n2-adicionar\n3-remover\n4-sair");
                int intop = int.Parse(Console.ReadLine());
                Menu opcao = (Menu)intop;

                switch (opcao)
                {
                    case Menu.listagem:
                        Lista();
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
        static void Adicionar()
        {
            Cliente cliente = new Cliente();
            Console.WriteLine("Digite o nome do cliente:");
            cliente.nome = Console.ReadLine();
            clientes.Add(cliente);
            Salvar();
        }
        static void Remover()
        {
            Lista();
            Console.WriteLine("Qual cliente deseja remover? (id)");
            int id = int.Parse(Console.ReadLine());
            if(id >= 0 && clientes.Count > id)
            {
                clientes.RemoveAt(id);
                Salvar();
            }
        }
        static void Lista()
        {
            if(clientes.Count > 0)
            {
                int id = 0;
                foreach(Cliente cliente in clientes)
                {
                    Console.WriteLine($"ID: {id}");
                    Console.WriteLine($"Nome: {cliente.nome}");
                    id++;
                }
            }
            else
            {
                Console.WriteLine("Nenhum cliente cadastrado");
            }
            Console.ReadLine();
        }
        static void Salvar()
        {
            FileStream stream = new FileStream("clientes.dot", FileMode.OpenOrCreate);
            BinaryFormatter encoder = new BinaryFormatter();

            encoder.Serialize(stream, clientes);

            stream.Close();
        }
        static void Carregar()
        {
            FileStream stream = new FileStream("clientes.dot", FileMode.OpenOrCreate);
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
