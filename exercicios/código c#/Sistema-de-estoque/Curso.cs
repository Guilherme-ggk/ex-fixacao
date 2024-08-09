﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_estoque
{
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
           
        }

        public void AdicionarSaida()
        {
           
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
