using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_estoque
{
    [System.Serializable]
    class ProdutoFisico : Produto, IEstoque
    {
        public float frete;//classe filha que vai ter esses dois metodos e vai receber os do seu pai também
        private int estoque;//na maioria das vezes estoque e vendas sempre serão algo privado do metodo

        public ProdutoFisico(string nome, float preco,float frete)
        {
            this.nome = nome;
            this.preco = preco;
            this.frete = frete;
        }

        public void AdicionarEntrada()
        {
            Console.WriteLine($"Adicionando entrada de estoque no produto {nome}:");
            Console.WriteLine("Digite a quantidade que você quer dar entrada:");
            int entrada = int.Parse( Console.ReadLine());
            //estoque = estoque + entrada; mesma coisa
            estoque += entrada;
            Console.WriteLine("Entrada adicionada com sucesso!");
            Console.ReadLine();

        }

        public void AdicionarSaida()
        {
            Console.WriteLine($"Adicionando Saida de estoque no produto {nome}:");
            Console.WriteLine("Digite a quantidade que você quer dar baixa:");
            int entrada = int.Parse(Console.ReadLine());
            //estoque = estoque - entrada; mesma coisa
            estoque -= entrada;
            Console.WriteLine("Saida registrada com sucesso!");
            Console.ReadLine();
        }

        public void Exibir()
        {
            Console.WriteLine($"Nome: {nome}");
            Console.WriteLine($"Frete: {frete}");
            Console.WriteLine($"Preço: {preco}");
            Console.WriteLine($"Estoque: {estoque}");
            Console.WriteLine("===================================");
        }
    }
}
