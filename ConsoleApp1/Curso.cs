﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Curso : Produto, IEstoque1
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
            Console.WriteLine("Quantas vagas deseja adicionar?");
            int valor = int.Parse(Console.ReadLine());
            vagas += valor;
            Console.WriteLine("Registrado!");
            Console.ReadLine();
        }

        public void AdicionarSaida()
        {
            Console.WriteLine("Quantas vagas deseja dar saída?");
            int valor = int.Parse(Console.ReadLine());
            vagas -= valor;
            Console.WriteLine("Registrado!");
            Console.ReadLine();
        }

        public void Exibir()
        {
            Console.WriteLine("=======================================");

            Console.WriteLine($"Nome: {nome}");
            Console.WriteLine($"Preço: {preco}");
            Console.WriteLine($"Autor: {autor}");
            Console.WriteLine($"Vagas: {vagas}");
            Console.ReadLine();

        }
    }
}