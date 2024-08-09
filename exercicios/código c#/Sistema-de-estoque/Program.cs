using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_estoque
{
    internal class Program
    {
        enum Menu { listagem = 1, adicionar, remover, entrada, saida, sair };

        static List<IEstoque> produtos = new List<IEstoque>();  

        static void Main(string[] args)
        {

            bool escolheuSair = false;

            while (escolheuSair == false)
            {
                Console.WriteLine("<<  Sistema de Estoque  >>");
                Console.WriteLine("\n1-listagem de produtos\n2-adicionar produto\n3-remover produto\n4-entrada de produtos\n5-saida de produtos\n6-sair");
                string instr = Console.ReadLine();
                int intop = int.Parse(instr);
                Menu opcao = (Menu)intop;

                if(intop > 0 && intop < 7)
                {
                    switch (opcao)
                    {
                        case Menu.listagem:
                            break;
                        case Menu.adicionar:
                            break;
                        case Menu.remover:
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
            }
        }

        static void Cadastro()
        {
            Console.WriteLine("Cadastro de Produtos");
            Console.WriteLine("\n1-Produto Fisico\n2-Ebook\n3-Curso");
            string instr = Console.ReadLine();
            int intop = int.Parse(instr);

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
        }
    }
}
