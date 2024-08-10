using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_estoque
{
    [System.Serializable]
    class Curso : Produto, IEstoque
    {
        public string autor;
        private int vagas;

        public Curso(string nome, float preco, string autor)
        {
            this.nome = nome;   
            this.preco = preco;
            this.autor = autor;
        }

        public void AdicionarEntrada()
        {
            Console.WriteLine($"Adicionando entrada de vagas no curso {nome}:");
            Console.WriteLine("Digite a quantidade de vagas que você quer dar entrada:");
            int entrada = int.Parse(Console.ReadLine());
            //estoque = estoque + entrada; mesma coisa
            vagas += entrada;
            Console.WriteLine("Vaga adicionada com sucesso!");
            Console.ReadLine();
        }

        public void AdicionarSaida()
        {
            Console.WriteLine($"Adicionando Saida de vagas no produto {nome}:");
            Console.WriteLine("Digite a quantidade de vagas que você quer dar baixa:");
            int entrada = int.Parse(Console.ReadLine());
            //estoque = estoque - entrada; mesma coisa
            vagas -= entrada;
            Console.WriteLine("Saida registrada com sucesso!");
            Console.ReadLine();
        }

        public void Exibir()
        {
            Console.WriteLine($"Nome do Curso: {nome}");
            Console.WriteLine($"Autor: {autor}");
            Console.WriteLine($"Preço: {preco}");
            Console.WriteLine($"Vagas restantes: {vagas}");
            Console.WriteLine("===================================");
        }
    }
}
