using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_estoque
{
    internal class Program
    {
        enum Menu { listagem = 1, adicionar, remover, entrada, saida, sair };

        static List<IEstoque> produtos = new List<IEstoque>();  

        static void Main(string[] args) //criando o projeto
        {
            Carregar();

            bool escolheuSair = false;

            while (escolheuSair == false)
            {
                Console.WriteLine("<<  Sistema de Estoque  >>");
                Console.WriteLine("\n1-listagem de produtos\n2-adicionar produto\n3-remover produto\n4-entrada de produtos\n5-saida de produtos\n6-sair");
                string instr = Console.ReadLine();
                int intop = int.Parse(instr);
                Menu opcao = (Menu)intop;

                if(intop > 0 && intop < 7) //validando para escolher entre as 6 opções
                {
                    switch (opcao)
                    {
                        case Menu.listagem:
                            Listagem();
                            break;
                        case Menu.adicionar:
                            Cadastro();
                            break;
                        case Menu.remover:
                            Remover();
                            break;
                        case Menu.entrada:
                            AdicionarEntrada();
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
                Console.Clear(); // limpando o console depois de sair 
            }
        }
        static void Cadastro() //cadastrando novos produtos para o estoque
        {
            Console.WriteLine("Cadastro de Produtos");
            Console.WriteLine("\n1-Produto Fisico\n2-Ebook\n3-Curso");
            string instr = Console.ReadLine(); //passando via string
            int intop = int.Parse(instr);

            switch(intop)
            {
                case 1:
                    CadastrarPFisico();
                    break;
                        case 2:
                    CadastrarEbook();
                            break;
                                case 3:
                    CadastrarCurso();
                    break;

            }

           
        }
        static void CadastrarPFisico()
        {
                Console.WriteLine("Cadastrando Produto Fisico");
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
        static void CadastrarEbook()
        {
            Console.WriteLine("Cadastrando Ebook");
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
        static void CadastrarCurso()
        {
            Console.WriteLine("Cadastrando Curso");
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

        static void Salvar()
        {
            FileStream stream = new FileStream("produtos.dat",FileMode.OpenOrCreate);
            BinaryFormatter encoder = new BinaryFormatter();

            encoder.Serialize(stream, produtos);

            stream.Close();
        }
        static void Carregar()
        {
            FileStream stream = new FileStream("produtos.dat",FileMode.OpenOrCreate);

            try
            {
                BinaryFormatter encoder = new BinaryFormatter();

                produtos = (List<IEstoque>)encoder.Deserialize(stream); 

                if(produtos == null)
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
        static void Listagem()
        {
            int id = 0;
            foreach (IEstoque produto in produtos)
            {
                Console.WriteLine($"ID:{id}");
                produto.Exibir();
                id++;
            }
            Console.ReadLine();
        }
        static void Remover()
        {
            Listagem();
            Console.WriteLine("Digite o produto que deseja remover:(ID)");
            int id = int.Parse(Console.ReadLine());
            if(id >= 0 && produtos.Count > id)
            {
                produtos.RemoveAt(id);
                Salvar();
            }
        }
        static void AdicionarEntrada()
        {
            Listagem();
            Console.WriteLine("Digite o produto que deseja adicionar entrada:(ID)");
            int id = int.Parse(Console.ReadLine());
            if (id >= 0 && produtos.Count > id)
            {
                produtos[id].AdicionarEntrada();
                Salvar();
            }
            
        }
        static void Saida()
        {
            Listagem();
            Console.WriteLine("Digite o produto que deseja registrar a saida:(ID)");
            int id = int.Parse(Console.ReadLine());
            if (id >= 0 && produtos.Count > id)
            {
                produtos[id].AdicionarSaida();
                Salvar();
            }
        }
    }
}
