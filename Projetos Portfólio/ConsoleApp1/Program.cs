using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        enum Menu { lista = 1, cadastrar, remover, entrada, saida, sair};

        static List<IEstoque> produtos = new List<IEstoque>();

        static void Main(string[] args)
        {
            bool EscolheuSair = false;
            while (EscolheuSair == false)
            {
                Console.WriteLine("0<Gestor de Produtos >0");
                Console.WriteLine("1-listagem\n2-cadastrar\n3-remover\n4-entrada\n5-saída\n6-sair");
                int intop = int.Parse(Console.ReadLine());
                Menu opcao = (Menu)intop;
               
                    switch (opcao)
                    {
                        case Menu.lista:
                            break;
                        case Menu.cadastrar:
                            break;
                        case Menu.remover:
                            break;
                        case Menu.entrada:
                            break;
                        case Menu.saida:
                            break;
                        case Menu.sair:
                            EscolheuSair = true;
                            break;
                    }
                Console.Clear();
            }
        }
        static void Listagem()
        {
            if(produtos.Count > 0)
            {
                int id = 0;
                foreach (IEstoque produto in produtos)
                {
                    Console.WriteLine($"ID:{id}");
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
            Console.WriteLine("Qual produto deseja remover?(id)");
            int id = int.Parse(Console.ReadLine());
            if(id >= 0 && id < produtos.Count)
            {
                produtos.RemoveAt(id);
                Salvar();
            }
        }
        
        static void Cadastrar()
        {
            Console.WriteLine("Cadastro de Produtos");
            Console.WriteLine("1-Ebook\n2-Produto Fisico\n3-Cursos");
            int intop = int.Parse(Console.ReadLine());

            switch(intop)
            {
                case 1:
                    break;
                case 2:
                    break;
                case 3:
                    break;
            }

        }

        static void ADebook()
        {
            Console.WriteLine("Nome:");
            string nome = Console.ReadLine();

            Console.WriteLine("Preço:");
            float preco = float.Parse(Console.ReadLine());

            Console.WriteLine("Autor:");
            string autor = Console.ReadLine();

            Ebook eb = new Ebook(nome,preco,autor);
            produtos.Add(eb);
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
            FileStream stream = new FileStream("produtos.dat", FileMode.OpenOrCreate);
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
    }
}
