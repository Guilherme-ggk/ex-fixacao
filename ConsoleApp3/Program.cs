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
    [System.Serializable]
    internal class Program
    {
        enum Menu { listagem = 1, cadastro, remover, saida, entrada, sair };

        static List<IEstoque> produtos = new List<IEstoque>();

        static void Main(string[] args)
        {
            Carregar();
            bool EscolheuSair = false;
            while (EscolheuSair == false)
            {
                Console.WriteLine("Gestor de produtos");
                Console.WriteLine("1-listagem de produtos\n2-cadastrar produtos\n3-remover\n4-adicionar saída\n5-adicionar entrada\n6-sair");
                int intop = int.Parse(Console.ReadLine());
                Menu opcao = (Menu)intop;

                if (intop > 0 && intop < 7)
                {
                    switch (opcao)
                    {
                        case Menu.listagem:
                            Listagem();
                            break;
                        case Menu.cadastro:
                            CadastroProdutos();
                            break;
                        case Menu.remover:
                            Remover();
                            break;
                        case Menu.saida:
                            AddSaida();
                            break;
                        case Menu.entrada:
                            AddEntrada();
                            break;
                        case Menu.sair:
                            EscolheuSair = true;
                            break;
                    }
                    Console.Clear();
                }
                else
                {
                    EscolheuSair = true;
                }
            }
        }
        static void CadastroProdutos()
        {
            Console.WriteLine("1-Produto Físico\n2-Ebook\n3-Curso");
            int intop = int.Parse(Console.ReadLine());
           switch(intop)
            {
                case 1:
                    CDProdutoFisico();
                break;
                case 2:
                    CDEbook();
                break;
                case 3:
                    CDCurso();
                break;
            }
        }
        static void CDEbook()
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
        static void CDCurso()
        {
            Console.WriteLine("Nome:");
            string nome = Console.ReadLine();
            Console.WriteLine("Preço:");
            float preco = float.Parse(Console.ReadLine());
            Console.WriteLine("Autor:");
            string autor = Console.ReadLine();
            Curso cs = new Curso(nome, preco, autor);
            produtos.Add(cs);
            Salvar();
        }
        static void CDProdutoFisico()
        {
            Console.WriteLine("Nome:");
            string nome = Console.ReadLine();
            Console.WriteLine("Preço:");
            float preco = float.Parse(Console.ReadLine());
            Console.WriteLine("Frete:");
            float frete = float.Parse(Console.ReadLine());
            ProdutoFisico pf = new ProdutoFisico(nome, preco, frete);
            produtos.Add(pf);
            Salvar();
        }
        static void Remover()
        {
            Listagem();
            Console.WriteLine("Qual produto deseja remover? (id)");
            int id = int.Parse(Console.ReadLine());
            if (id >= 0 && id < produtos.Count)
            {
                produtos.RemoveAt(id);
                Salvar();
            }
        }
        static void AddSaida()
        {
            Listagem();
            Console.WriteLine("Qual produto deseja dar saída? (id)");
            int id = int.Parse(Console.ReadLine());
            if (id >= 0 && id < produtos.Count)
            {
                produtos[id].AddSaida();
                Salvar();
            }
        }
        static void AddEntrada()
        {
            Listagem();
            Console.WriteLine("Qual produto deseja dar entrada? (id)");
            int id = int.Parse(Console.ReadLine());
            if (id >= 0 && id < produtos.Count)
            {
                produtos[id].AddEntrada();
                Salvar();
            }
        }
        static void Listagem()
        {
            if(produtos.Count > 0)
            {
                int id = 0;
                foreach (var produto in produtos)
                {
                    Console.WriteLine($"ID: {id}");
                    produto.Exibir();
                    id++;
                }
            }
            else
            {
                Console.WriteLine("Nenhum produto cadastrado.");
                Console.WriteLine("Aperte enter para voltar ao menu");
            }
            Console.ReadLine();
        }
        static void Salvar()
        {
            FileStream stream = new FileStream("produtos.dat", FileMode.OpenOrCreate);
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

                produtos = (List<IEstoque>)encoder.Deserialize(stream);

                if (produtos == null) 
                {
                    produtos = new List<IEstoque>();
                }

            }
            catch(Exception)
            {
                produtos = new List<IEstoque>();
            }
            stream.Close();
        }
    }
}
