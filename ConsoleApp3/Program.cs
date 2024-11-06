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
        struct Cliente
        {
            public string nome;
            public string idade;
        }

        static List<Cliente> clientes = new List<Cliente>();

        enum Menu { listagem = 1, adicionar, remover, sair };
        static void Main(string[] args)
        {
            bool EscolheuSair = false;
            while (EscolheuSair == false)
            {
                Console.WriteLine("Gerenciador de Clientes no console");
                int intop = int.Parse(Console.ReadLine());
                Menu opcao = (Menu)intop;

                switch (opcao)
                {
                    case Menu.listagem:
                        break;
                    case Menu.adicionar:
                        break;
                    case Menu.remover:
                        Remover();
                        break;
                    case Menu.sair:
                        EscolheuSair = true;
                        break;
                }
            }
        }



        static void Remover()
        {
            Console.WriteLine("Qual cliente deseja remover?(id)");
            int id = int.Parse(Console.ReadLine());
            if (id >= 0 && clientes.Count > id)
            {
                clientes.RemoveAt(id);
                Salvar();
            }
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
