using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_estoque
{
    [System.Serializable]
    class Ebook : Produto ,IEstoque
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
           Console.WriteLine("Não é possivel dar entrada em ebook, pois é um produto digital!");
            Console.ReadLine();
        }

        public void AdicionarSaida()
        {
            Console.WriteLine($"Adicionando saida de vendas no ebook {nome}:");
            Console.WriteLine("Digite a quantidade de vendas que você quer dar saida:");
            int entrada = int.Parse(Console.ReadLine());
            //estoque = estoque + entrada; mesma coisa
            vendas += entrada;
            Console.WriteLine("Vendas registradas com sucesso!");
            Console.ReadLine();
        }

        public void Exibir()
        {
            Console.WriteLine($"Nome: {nome}");
            Console.WriteLine($"Autor: {autor}");
            Console.WriteLine($"Preço: {preco}");
            Console.WriteLine($"Vagas restantes: {vendas}");
            Console.WriteLine("===================================");
        }
    }
}
