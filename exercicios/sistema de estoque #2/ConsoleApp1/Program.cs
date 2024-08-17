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
        static List<IEstoque>  produtos = new List<IEstoque>();
        enum Menu { listagem = 1, cadastrar, remover, entrada, saida, sair };
        static void Main(string[] args)
        {
            Carregar();
            bool escolheuSair = false;
            while (escolheuSair == false)
            {
                Console.WriteLine("<<Sistema de estoque>>");
                Console.WriteLine("\n1-listagem\n2-cadastrar\n3-remover\n4-entrada\n5-sair\n6-sair");
                int intop = int.Parse(Console.ReadLine());
                Menu escolha = (Menu)intop;

                if (intop >= 0 && intop < 7)
                {
                    switch (escolha)
                    {
                        case Menu.listagem:
                            Listagem();
                            break;
                        case Menu.cadastrar:
                            Cadastrar();
                            break;
                        case Menu.remover:
                            Remover();
                            break;
                        case Menu.entrada:
                            break;
                        case Menu.saida:
                            break;
                        case Menu.sair:
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
                foreach (IEstoque produto in produtos)
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
        static void Remover()
        {
            Listagem();
            Console.WriteLine("Qual produto deseja remover?(id)");
            int id = int.Parse(Console.ReadLine());
            if(id >= 0 && id < produtos.Count)
            {
                produtos.RemoveAt(id);
                Salvar();
            }
        }
        static void Salvar()
        {
            FileStream stream = new FileStream("produto.dat", FileMode.OpenOrCreate);
            BinaryFormatter encoder = new BinaryFormatter();

            encoder.Serialize(stream, produtos);

            stream.Close();
        }
        static void Carregar()
        {
            FileStream stream = new FileStream("produto.dat", FileMode.OpenOrCreate);
            try
            {
                BinaryFormatter encoder = new BinaryFormatter();
                produtos = (List<IEstoque>)encoder.Deserialize(stream); 
                if(produtos == null)
                {
                    produtos = new List<IEstoque>();
                }

            }
            catch (Exception)
            {
                produtos = new List<IEstoque>();
            }
            stream.Close();
        }
        static void Cadastrar()
        {
            Console.WriteLine("Qual produto deseja cadastrar?");
            Console.WriteLine("1-Produto Fisico\n2-Ebook\n3-Curso");
            int intop = int.Parse(Console.ReadLine());
             switch(intop)
            {
                case 1:
                    Cadpf();
                    break;
                case 2:
                    Cadeb();
                    break;
                case 3:
                    Cadcs();
                    break;
            }
        }
        static void Cadpf()
        {
            Console.WriteLine("Nome:");
            string nome = Console.ReadLine();
            Console.WriteLine("Preço:");
            float preco = float.Parse(Console.ReadLine());
            float frete = float.Parse(Console.ReadLine());
            ProdutoFisico pf = new ProdutoFisico(nome, preco, frete);
            produtos.Add(pf);
            Salvar();
        }
        static void Cadcs()
        {
            Console.WriteLine("Nome:");
            string nome = Console.ReadLine();
            Console.WriteLine("Preço:");
            float preco = float.Parse(Console.ReadLine());
            Console.WriteLine("Autor:");
            string autor= Console.ReadLine();
            Curso cs = new Curso(nome, preco, autor);
            produtos.Add(cs);
            Salvar();
        }
        static void Cadeb()
        {
            Console.WriteLine("Nome:");
            string nome = Console.ReadLine();
            Console.WriteLine("Preço:");
            float preco = float.Parse(Console.ReadLine());
            Console.WriteLine("Autor:");
            string autor = Console.ReadLine();
            Ebook eb = new Ebook(nome, preco, autor);
            produtos.Add(eb);
            Salvar();
        }
        static void Entrada()
        {
            Listagem();
            Console.WriteLine("");
        }

    }
}
