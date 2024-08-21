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
        enum Menu { listagem = 1, cadastrar, remover, entrada, saida, sair };

        static List<IEstoque1> produtos = new List<IEstoque1>();

        static void Main(string[] args)
        {
            bool escolheuSair = false;
            while (escolheuSair == false)
            {
                Console.WriteLine("Sistema de estoque");
                Console.WriteLine("1-listagem\n2-cadastrar\n3-remover\n4-entrada\n5-saída\n6-sair");
                int intop = int.Parse(Console.ReadLine());
                Menu escolha = (Menu)intop;

                if(intop > 0 && intop < 7)
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
                            Entrada();
                            break;
                        case Menu.saida:
                            Saida();
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
        static void Cadastrar()
        {
           Console.WriteLine("Cadastro de Produtos");
            Console.WriteLine("1-Produto Fisico\n2-Curso\n3-Ebook");
            int intop = int.Parse(Console.ReadLine());

            switch (intop)
            {
                case 1:
                    CadProdutoFisico();
                    break;
                case 2:
                    CadCurso();
                    break;
                case 3:
                    CadEbook();
                    break;
            }
        }
        static void CadProdutoFisico()
        {
            Console.WriteLine("Nome:");
            string nome = Console.ReadLine();
            
            Console.WriteLine("Preço:");
            float preco = float.Parse(Console.ReadLine());

            Console.WriteLine("Frete:");
            float frete = float.Parse(Console.ReadLine());

            ProdutoFisico pf = new ProdutoFisico(nome, preco, frete);
            produtos.Add(pf);
            
        }
        static void CadCurso()
        {
            Console.WriteLine("Nome:");
            string nome = Console.ReadLine();

            Console.WriteLine("Preço:");
            float preco = float.Parse(Console.ReadLine());

            Console.WriteLine("Autor:");
            string autor = Console.ReadLine();

            Curso cs = new Curso(nome, preco, autor);
            produtos.Add(cs);

        }
        static void CadEbook()
        {
            Console.WriteLine("Nome:");
            string nome = Console.ReadLine();

            Console.WriteLine("Preço:");
            float preco = float.Parse(Console.ReadLine());

            Console.WriteLine("Autor:");
            string autor = Console.ReadLine();

            Ebook eb = new Ebook(nome, preco, autor);
            produtos.Add(eb);

        }
        static void Listagem()
        {
            if (produtos.Count > 0)
            {
                int id = 0;
                foreach (IEstoque1 produto in produtos)
                {
                    Console.WriteLine($"ID: {id}");
                    produto.Exibir();
                    id++;
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
            Console.WriteLine("Qual produto deseja remover? (id)");
            int id = int.Parse(Console.ReadLine());
            if(id >= 0 && id < produtos.Count)
            {
                produtos.RemoveAt(id);
            }
        }
        static void Entrada()
        {
            Listagem();
            Console.WriteLine("Qual produto deseja dar entrada? (id)");
            int id = int.Parse(Console.ReadLine());
            if (id >= 0 && id < produtos.Count)
            {
                produtos[id].AdicionarEntrada();
            }
        }
        static void Saida()
        {
            Listagem();
            Console.WriteLine("Qual produto deseja dar saída? (id)");
            int id = int.Parse(Console.ReadLine());
            if (id >= 0 && id < produtos.Count)
            {
                produtos[id].AdicionarSaida();
            }
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

                produtos = (List<IEstoque1>)encoder.Deserialize(stream);

                if(produtos == null)
                {
                    produtos = new List<IEstoque1>();
                }

            }
            catch (Exception ex)
            {
                produtos = new List<IEstoque1>();
            }
            stream.Close();
        }


    }
}
