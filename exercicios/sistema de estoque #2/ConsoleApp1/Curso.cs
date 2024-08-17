using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    [System.Serializable]
    internal class Curso : Produto, IEstoque
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
            Console.WriteLine($"Quanto de vagas deseja dar entrada no curso {nome}?");
            int valor = int.Parse(Console.ReadLine());
            vagas += valor;
            Console.WriteLine("Resgitrado!");
            Console.ReadLine();
        }

        public void AdicionarSaida()
        {
            Console.WriteLine($"Quanto de vagas deseja dar saída no curso {nome}?");
            int valor = int.Parse(Console.ReadLine());
            vagas -= valor;
            Console.WriteLine("Resgitrado!");
            Console.ReadLine();
        }

        public void Exibir()
        {
            Console.WriteLine($"Nome: {nome}");
            Console.WriteLine($"Preço: {preco}");
            Console.WriteLine($"Autor: {autor}");
            Console.WriteLine($"Vagas: {vagas}");
            Console.ReadLine();
        }
    }
}
