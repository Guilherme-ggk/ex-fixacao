using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace gestor_de_clientes
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

        enum Menu { lista = 1, adicionar, remover, sair};
        static void Main(string[] args)
        {
            Carregar();
            bool escolheuSair = false;
            while (escolheuSair == false)
            {
                Console.WriteLine("<< Gestor de Clientes >>");
                Console.WriteLine("1-listagem\n2-adicionar\n3-remover\n4-sair");
                int intop = int.Parse(Console.ReadLine());
                Menu opcao = (Menu)intop;

                switch (opcao)
                {
                    case Menu.lista:
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

            
        }
        static void Adicionar()
        {
            Clientes cliente = new Clientes();

            Console.WriteLine("Nome:");
            cliente.nome = Console.ReadLine();

            Console.WriteLine("Idade:");
            cliente.idade = int.Parse(Console.ReadLine());

            clientes.Add(cliente);
            Salvar();

            Console.WriteLine("Cliente adicionado com sucesso!");
            Console.WriteLine("Aperte enter para voltar ao menu.");


        }
        static void Listagem()
        {
            if(clientes.Count > 0)
            {
                int ID = 0;
                foreach (Clientes cliente in clientes)
                {
                    Console.WriteLine($"ID: {ID}");
                    Console.WriteLine(cliente.nome);
                    Console.WriteLine(cliente.idade);
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
            Console.WriteLine("Qual cliente deseja remover?(id)");
            int id = int.Parse(Console.ReadLine());
            if(id >= 0 && id < clientes.Count)
            {
                clientes.RemoveAt(id);
                Salvar();
            }
        }
        static void Salvar()
        {
            FileStream stream = new FileStream("clientes.30",FileMode.OpenOrCreate);
            BinaryFormatter encoder = new BinaryFormatter();

            encoder.Serialize(stream, clientes);
            
            stream.Close();
        }
        static void Carregar()
        {
            FileStream stream = new FileStream("clientes.30", FileMode.OpenOrCreate);
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
