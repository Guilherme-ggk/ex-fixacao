using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static List<Iestoque> produtos = new List<Iestoque>();
        enum Menu { listagem = 1, adicionar, remover, entrada, saida, sair};
        static void Main(string[] args)
        {
            Carregar();

            bool escolheuSair = false;

            while (!escolheuSair)
            {
                Console.WriteLine("< Sistema de estoque >");
                Console.WriteLine("\n1-listagem\n2-adicionar\n-remover\n4-entrada\n5-saida\n6-sair");
                string str = Console.ReadLine();
                int intop = int.Parse(str);
                Menu escolha = (Menu)intop;

                if (intop > 0 && intop > 7)
                {
                    switch (escolha)
                    {
                        case Menu.listagem:
                            Listagem();
                            break;
                        case Menu.adicionar:
                            break;
                        case Menu.remover:
                            break;
                        case Menu.entrada:
                            break;
                        case Menu.saida:
                            escolheuSair = true;
                            break;
                    }
                }
                else
                {
                    escolheuSair = true;
                }
                Console.Clear();
            }
        }

        static void Listagem()
        {
            if(produtos.Count > 0)
            {
                foreach (Iestoque produto in produtos)
                {
                    produto.Exibir();

                }
            }
            else
            {
                Console.WriteLine("Nenhum produto cadastrado!");
            }
            Console.ReadLine();
        }
        static void Salvar()
        {
            FileStream stream = new FileStream("produtos.dat",FileMode.OpenOrCreate);
            BinaryFormatter encoder = new BinaryFormatter();

            encoder.Serialize(stream, produtos);

            stream.Close();
        }
        static void Carregar()
        {
            FileStream stream = new FileStream("produtos.dat", FileMode.OpenOrCreate);
            try
            {
                BinaryFormatter encoder = new BinaryFormatter();
                produtos = (List<Iestoque>)encoder.Deserialize(stream);
                if(produtos == null)
                {
                    produtos = new List<Iestoque>();
                }

            }
            catch (Exception)
            {
                produtos = new List<Iestoque>();
            }
            stream.Close();
        }
        static void Cadastrar()
        {
            Console.WriteLine("Cadastrando Produtos");
            Console.WriteLine("");
        }
    }
}
