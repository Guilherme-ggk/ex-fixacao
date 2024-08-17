using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class ProdutoFisico : Produto, IEstoque
    {
        public float frete;
        private int estoque;

        public ProdutoFisico(float frete)
        {
            this.frete = frete;
        }

        public void AdicionarEntrada()
        {
            Console.WriteLine($"Quanto de estoque deseja dar entrada no produto {nome}?");
            int valor = int.Parse(Console.ReadLine());
            estoque += valor;
            Console.WriteLine("Resgitrado!");
            Console.ReadLine();

        }

        public void AdicionarSaida()
        {
            Console.WriteLine($"Quanto de estoque deseja dar saída no produto {nome}?");
            int valor = int.Parse(Console.ReadLine());
            estoque -= valor;
            Console.WriteLine("Resgitrado!");
            Console.ReadLine();
        }

        public void Exibir()
        {
            Console.WriteLine($"Nome: {nome}");
            Console.WriteLine($"Preço: {preco}");
            Console.WriteLine($"Frete: {frete}");
            Console.WriteLine($"Estoque: {estoque}");
            Console.ReadLine();
        }
    }
}
