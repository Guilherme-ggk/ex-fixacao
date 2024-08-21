using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class ProdutoFisico : Produto, IEstoque1
    {
        public float frete;
        private int estoque;


        public ProdutoFisico(string nome, float preco, float frete)
        {
            this.nome = nome;
            this.preco = preco;
            this.frete = frete;
        }

        public void AdicionarEntrada()
        {
            Console.WriteLine("Quanto estoque deseja dar entrada?");
            int valor = int.Parse(Console.ReadLine());
            estoque += valor;
            Console.WriteLine("Registrado!");
            Console.ReadLine();
        }

        public void AdicionarSaida()
        {
            Console.WriteLine("Quanto estoque deseja dar saída?");
            int valor = int.Parse(Console.ReadLine());
            estoque -= valor;
            Console.WriteLine("Registrado!");
            Console.ReadLine();
        }

        public void Exibir()
        {
            throw new NotImplementedException();
        }
    }
}
