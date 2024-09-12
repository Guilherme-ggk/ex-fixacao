using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace Gestor_de_Clientes_no_console
{
    internal class Program
    {
        [System.Serializable]
        struct Clientes
        {
            public string nome;
            public int idade;
        }

        static List<Clientes> clientes = new List<Clientes>();

        enum Menu { listagem = 1, adicionar, remover, sair };
        static void Main(string[] args)
        {
            Carregar();
            bool escolheuSair = false;

            while (!escolheuSair)
            {
                Console.WriteLine("Gestor de Clientes");
                Console.WriteLine("1-listagem\n2-Adicionar\n3-remover\n4-sair");
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
                Console.ReadLine();
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
        static void Adicionar()
        {
            Clientes cliente = new Clientes();

            Console.WriteLine($"Nome:");
            cliente.nome = Console.ReadLine();
           
            Console.WriteLine($"Idade:");
            cliente.idade = int.Parse(Console.ReadLine());

            clientes.Add(cliente);
            Console.ReadLine ();
            Salvar();
            

        }
        static void Remover()
        {
            Listagem();
            Console.WriteLine("Qual cliente deseja remover?(id)");
            int id = int.Parse(Console.ReadLine());
            if(id > 0 && id < clientes.Count)
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
                
                clientes = (List<Clientes>)encoder.Deserialize(stream);

                if(clientes == null)
                {
                    clientes = new List<Clientes>();
                }

            }
            catch (Exception)
            {
                clientes = new List<Clientes>();
            }
            stream.Close();
        }
        }
    }
