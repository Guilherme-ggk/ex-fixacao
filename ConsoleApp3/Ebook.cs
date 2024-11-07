using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Ebook: Produto, IEstoque
    {
        public string autor;
        private int vendas;

        public Ebook(string nome, float preco, string autor)
        {
            this.nome = nome;
            this.preco = preco;
            this.autor = autor;
        }

        public void AddEntrada()
        {
            Console.WriteLine("Impossível adicionar entrada em Ebook, produto digital.");
        }

        public void AddSaida()
        {
            Console.WriteLine($"Quantas vendas deseja adicionar para o ebook {nome}?");
            int valor = int.Parse(Console.ReadLine());
            vendas += valor;
            Console.WriteLine("Adicionado com sucesso!");
            Console.ReadKey();
        }

        public void Exibir()
        {
            Console.WriteLine($"Nome: {nome}");
            Console.WriteLine($"Preço: {preco}");
            Console.WriteLine($"Autor: {autor}");
            Console.WriteLine($"Vendas: {vendas}");
            Console.ReadKey();
        }
    }
}
