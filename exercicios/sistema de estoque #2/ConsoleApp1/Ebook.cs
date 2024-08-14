using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Ebook : Produto, Iestoque
    {
        public string autor;
        private int vendas;

        public Ebook(string nome, float preco, string autor)
        {
            this.nome = nome;
            this.preco = preco;
            this.autor = autor;
        }

        public void Entrada()
        {
            Console.WriteLine("Não é possivel adicionar entrada em Ebook, produto digital!");
        }

        public void Exibir()
        {
            Console.WriteLine($"Nome: {nome}");
            Console.WriteLine($"Preço: {preco}");
            Console.WriteLine($"Autor: {autor}");
            Console.WriteLine("==============================");
        }

        public void Saida()
        {
            Console.WriteLine("Quanto de vendas quer dar saída?");
            int saida = int.Parse( Console.ReadLine() );
            vendas += saida;
            Console.WriteLine("Vendas registradas");
        }
    }
}
