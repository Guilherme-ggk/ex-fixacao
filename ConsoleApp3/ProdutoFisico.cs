using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class ProdutoFisico: Produto, IEstoque
    {
        public float frete;
        private int estoque;

        public ProdutoFisico(string nome, float preco, float frete)
        {
            this.nome = nome;
            this.preco = preco;
            this.frete = frete;
        }

        public void AddEntrada()
        {
            Console.WriteLine($"Quanto de estoque deseja dar entrada para o produto {nome}?");
            int valor = int.Parse(Console.ReadLine());
            estoque += valor;
            Console.WriteLine("Adicionado com sucesso!");
            Console.ReadKey();
        }

        public void AddSaida()
        {
            Console.WriteLine($"Quanto de estoque deseja dar saída para o produto {nome}?");
            int valor = int.Parse(Console.ReadLine());
            estoque -= valor;
            Console.WriteLine("Adicionado com sucesso!");
            Console.ReadKey();
        }

        public void Exibir()
        {
            Console.WriteLine($"Nome: {nome}");
            Console.WriteLine($"Preço: {preco}");
            Console.WriteLine($"Estoque: {estoque}");
            Console.WriteLine($"Frete: {frete}");
            Console.ReadKey();
        }
    }
}
