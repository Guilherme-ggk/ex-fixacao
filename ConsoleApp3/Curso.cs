using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    [System.Serializable]
    internal class Curso: Produto, IEstoque
    {
        public string autor;
        private int vagas;

        public Curso(string nome, float preco, string autor)
        {
            this.nome = nome;
            this.preco = preco;
            this.autor = autor;
        }

        public void AddEntrada()
        {
            Console.WriteLine($"Quantas vagas deseja dar entrada para o curso {nome}?");
            int valor = int.Parse(Console.ReadLine());
            vagas += valor;
            Console.WriteLine("Adicionado com sucesso!");
            Console.ReadKey();
        }

        public void AddSaida()
        {
            Console.WriteLine($"Quantas vagas deseja dar saída para o curso {nome}?");
            int valor = int.Parse(Console.ReadLine());
            vagas -= valor;
            Console.WriteLine("Adicionado com sucesso!");
            Console.ReadKey();
        }

        public void Exibir()
        {
            Console.WriteLine($"Nome: {nome}");
            Console.WriteLine($"Preço: {preco}");
            Console.WriteLine($"Autor: {autor}");
            Console.WriteLine($"Vagas: {vagas}");
            Console.ReadKey();
        }
    }
}
