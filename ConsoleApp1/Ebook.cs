using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Ebook : Produto, IEstoque1
    {
        public string autor;
        private int vendas;
        public Ebook(string nome, float preco, string autor)
        {
            this.nome = nome;
            this.preco = preco;
            this.autor = autor;
        }

        public void AdicionarEntrada()
        {
            Console.WriteLine("Impossivel dar entrada em ebook, produto digital!");
            Console.ReadLine();
        }

        public void AdicionarSaida()
        {
            Console.WriteLine("Quantas vendas deseja dar saída?");
            int valor = int.Parse(Console.ReadLine());
            vendas += valor;
            Console.WriteLine("Registrado!");
            Console.ReadLine();
        }

        public void Exibir()
        {
            Console.WriteLine("=======================================");

            Console.WriteLine($"Nome: {nome}");
            Console.WriteLine($"Preço: {preco}");
            Console.WriteLine($"Autor: {autor}");
            Console.WriteLine($"Vendas: {vendas}");
            Console.ReadLine();
        }
    }
}
