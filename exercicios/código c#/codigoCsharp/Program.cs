﻿using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.InteropServices;
using static System.Net.WebRequestMethods;

namespace ConsoleApp1
{
    class Filme
    {
        public string nome;
        public string ano;
        public string diretor;

        public Filme(string nome, string ano, string diretor)
        {
            this.nome = nome;
            this.ano = ano;
            this.diretor = diretor;
        }
    }

    public class Program
    {
        [System.Serializable]
        struct Produtu
        {
            public string nome;
            public float preco;

            public Produtu(string nome, float preco)
            {
                this.nome = nome;
                this.preco = preco;
            }
        }

        struct Produto
        {
            public string nome;
            public float preco;


            public Produto(string nome, float preco)
            {

                this.nome = nome;
                this.preco = preco;
            }


            public float AddDesc(float porc)
            {
                float desconto = this.preco * porc / 100f;
                return this.preco - desconto;
            }

            public void ExibirInfo()
            {
                Console.WriteLine($"Nome: {this.nome}");
                Console.WriteLine($"Preço: {this.preco} $");
            }
        }



        enum Cor { Azul, Amarelo, Preto, Verde, Roxo };
        enum Opcao { Criar = 1, Deletar, Editar, Listar, Atualizar };
        static void Main(string[] args)
        {

            //int = 8
            //float = 8.8f
            //string = "texto"
            //char = caracter = 'G'

            //const = valor que jamais muda
            //var = jeito preguiçoso de atribuir valores

            // C# pode fazer qualquer coisa, Jogos, aplicações desktop, sistemas web e muito mais.
            // .NET ou dotNet é uma plataforma que contém todos os módulos da linguagem, pois se não sobrecarregaria o código
            //using ( "usando uma módulo ou biblioteca C#, para certo fim")
            //existem várias bibliotecas com várias finalidades
            //.NET só é para Windows

            /*int numeroQualquer = 20 + 20 - 80;
            int numeroDiv = 6 / 2;
            float numeroX = 5.0f / 2;


            Console.WriteLine(numeroQualquer);
            Console.WriteLine(numeroDiv);
            Console.WriteLine(numeroX);*/

            //Ordem de precedência
            /*Primeiro * (MULTIPLICAÇÃO) e / (DIVISÃO)
            Depois + e -, Porém se ouver (), a ordem mudo e começa por eles.
            Exemplo:

            n = 2 + 2 * 10 = 22 sem parentêses
            n = (2 + 2) * 10 = 40 com () */

            //Operadores Aritméticos

            //> < = == >= <= !=

            //Operadores Lógicos

            //(AND e OR) && ||

            /*int n = 2 + 2 * 10;
              int num = (2 + 2) * 10;

            Console.WriteLine(n);
            Console.WriteLine(num);*/

            //Condicionais em C#

            /* Console.WriteLine("Digite sua idade");
            int idade = int.Parse(Console.ReadLine());    

            if(idade >= 0 && idade <= 11)
            {
            Console.WriteLine("Voçê é uma criança");
            }else if(idade  >= 11 && idade <= 18)
            {
            Console.WriteLine("Voçê é um adolescente");
            }else if(idade >= 19 && idade <= 60)
            {
                Console.WriteLine("Voçê é um adulto");
            }else
            {
                Console.WriteLine("Voçê é um idoso");
            }*/


            //Funçôes em C#

            // Uma função é um método que pode ser chamado no método principal (MAIN):
            //Por exemplo:

            /*static void Main()
            {
                Guilherme(); // Aqui será impresso o que está dentro da função Guilherme 
            }



            static void Guilherme ()
            {
                Console.WriteLine("Seja Bem vindo");
                Console.WriteLine("Estou aprendendo c#");
                Console.WriteLine("que curso show de bola");
            }*/

            // GerarProduto(-20, "Curso de Node JS");


            //string nome =Console.ReadLine(); 
            //Console.WriteLine(nome);
            //Console.ReadLine();

            // int soma1 = Somar(1 , 2, 3);

            //Console.WriteLine(soma1);


            // Arrays

            /*string produto1 = "Minecraft";
            string produto2 = "Call of Duty";
            string produto3 = "Street Fitgher";      //Para guardar muitos itens isso seria um problema, o mais ideal seria usando um array;
            string produto4 = "Dungeos";
            string produto5 = "Need for speed";

            string[] Produtos = new string[5]

                {   "Minecraft",
                    "Need For Speed",                   //Assim fica bem melhor e legível
                    "Fifa", 
                    "Dungeos",
                    "Street Fitgher"
                };

            Produtos[3] = "Minecraft Dungeos"; // Forma de alterar um item;

            Console.WriteLine(Produtos[3]);

            int[] valores = { 11,22,33,44,55,66 };      // mais simples e organizado;*/


            //Swith Case

            /* string cor = "preto";

             switch (cor)
             {
                     case "Vermelho":
                     Console.WriteLine("Sua cor preferida é vermelho!");
                     break;

                 case "Amarelo":
                     Console.WriteLine("Sua cor preferida é Amarelo!");
                     break;
                                                                                 // muito útil em casos que exigem muitos cases (casos);
                 case "Verde":
                     Console.WriteLine("Sua cor preferida é Verde!");
                     break;

                 case "Azul":
                     Console.WriteLine("Sua cor preferida é Azul!");
                     break;

                 default:
                     Console.WriteLine("Droga, não sei qual cor que é...");
                     break;
             }*/


            // Enums

            // Um Enum é como um irmão gemêo do var, ele guarda valores ou itens pequenos;


            /*Cor CorFavoritaGiovana = Cor.Verde;
            Cor CorFavoritaGuilherme = Cor.Roxo;

            Console.WriteLine((Cor)2);
            Console.WriteLine((int)CorFavoritaGuilherme);
            Console.WriteLine((int)CorFavoritaGiovana);*/

            /* Console.WriteLine("Seleciona uma das opções abaixo: ");
             Console.WriteLine(" 1-Criar\n 2-Deletar\n 3-Editar\n 4-Listar\n 5-Atualizar");

             int index =int.Parse(Console.ReadLine()); 
             Opcao opcaoSelecionada = (Opcao)index;

             switch(opcaoSelecionada)
             {
                 case Opcao.Criar:
                     Console.WriteLine("Voçê quer criar");
                     break;

                 case Opcao.Deletar:
                     Console.WriteLine("Delete tudo");
                     break;

                 case Opcao.Editar:
                     Console.WriteLine("Editando algo");
                     break;
                 case Opcao.Listar:
                     Console.WriteLine("Listando Listas");
                     break;
                 case Opcao.Atualizar:
                     Console.WriteLine("Atualizando o sistema");
                     break;
             }

             Console.WriteLine(opcaoSelecionada.ToString());*/

            // Laços de Repetição
            /*int contador = 0;
            while (contador < 10)
            {   
                Console.WriteLine("ADD MAIS UM");
                Console.WriteLine(contador + 1);
                contador++;
            }

            do
            {
                Console.WriteLine("Rodou uma vez sendo impossivel");
            } while (1000 < 1);

            string[] palavras = {"Carro", "Animal", "Naruto", "Anime", "Game" };

            /*foreach (string palavra in palavras)// para cada palavra(variavel tipo string) no Array Palavras, ele vai executar no bloco de código;
            {
                Console.WriteLine(palavra);
            }*/

            /* for(int c = 0;c < palavras.Length; c++)
            {
                Console.WriteLine("rodou for");
                Console.WriteLine(palavras[c]);    
            }

            for (int contador2 = palavras.Length-1; contador2 > 0; contador2--)
                {

                Console.WriteLine(palavras[contador2]);
            }

            Produto faca = new Produto("Tramontina", 100f);
            Produto bola = new Produto("Champios", 200f);

            float ValorFinal = bola.AddDesc(50f);
            Console.WriteLine(ValorFinal);

            faca.ExibirInfo();


            List<string> clientes  = new List<string>();
            clientes.Add("Giovana");
            string nome = "Guilherme";
            clientes.Add(nome);

            Console.WriteLine($"{clientes[0]} e {nome}");*/

            /* List<string> clientes = new List<string>();
            clientes.Add("Guilherme");
            clientes.Add("Henrique");
            clientes.Add("Maximo");
            clientes.Add("SANTOS");
            clientes.Add("DE");

            clientes.Count();
            Console.WriteLine(clientes.Count());

            foreach (string cliente in clientes)
            {
                Console.WriteLine(cliente);
            }
            Console.WriteLine("========================");


            Console.WriteLine("===========");
            string busca = clientes.Find(cliente => cliente.Length > 4);

            Console.WriteLine(busca);

            Console.WriteLine("===========");


            Console.WriteLine("====================");

            Console.WriteLine("Filtrando com FindAll");

             List<string> filtragem =clientes.FindAll(cliente  => cliente.Length > 5);

             foreach (string cliente in filtragem)
             {
                 Console.WriteLine(cliente); 
             }

             Console.WriteLine("====================");
             clientes.RemoveAt(0);

             //int quantidadeRemove = clientes.RemoveAll(cliente => cliente == "Maximo");






             //Console.WriteLine(quantidadeRemove);

            foreach (string cliente in clientes)
            {
                Console.WriteLine(cliente);
            }*/


            /*List<string> clientes = new List<string>();
            clientes.Add("Guilherme");
            clientes.Add("Henrique");
            clientes.Add("Maximo");
            clientes.Add("dos");
            clientes.Add("Santos");
            clientes.Add("Almeida");

            Console.WriteLine("----------------------");
            Console.WriteLine("Contando a lista");
            Console.WriteLine(clientes.Count());
            Console.WriteLine("----------------------");
            Console.WriteLine("Mostrando todos os clientes");
            foreach (string cliente in clientes)
            {
                Console.WriteLine(cliente);
            }

            Console.WriteLine("----------------------");
            Console.WriteLine("Removendo clientes");
            clientes.RemoveAt(0);//remove um cliente
            clientes.RemoveAll(cliente => cliente == "Maximo");//remove mais de um

            foreach (var cliente in clientes)
            {
                Console.WriteLine(cliente);
            }
            Console.WriteLine("----------------------");

            Console.WriteLine("Filtrando e buscando");

            string busca = clientes.Find(cliente => cliente == "dos");//buscando um cliente

            Console.WriteLine($"{busca}");

            List<string> filtragem = clientes.FindAll(cliente => cliente.Length > 5);

            foreach (var cliente in filtragem)
            {
                Console.WriteLine($"{cliente} (filtrado)");
            }*/


            //Manipulação de arquivos em C#
            //Arquivos TXT: como Html,Cs,Csv (Excel), podem ser lidos normalmente por um humano
            //Arquivos Binários: como Pdf,jpg,png e mp4, são números e simbolos diferentes que só um reprodutor de tal
            // é capaz de ler e reproduzir
            // usando Stream Str = que recebe e manipula o arquivo;

            /* StreamWriter escritor = new StreamWriter("teste.txt");// desse modo ele imprime as linhas mas se caso apagar uma delas, elas somem junto


            escritor.WriteLine("Curso de C#");
            escritor.Close();

            Console.WriteLine("Arquivo gerado");


            StreamWriter escritorr = File.AppendText("teste.txt");// toda vez que o codigo for executado, vai imprimir uma nova linha e guandando na memória
            escritorr.WriteLine("Udemy");
            escritorr.Close();*/


            // StreamReader leitor = new StreamReader("teste.txt");
            /*var conteúdo = leitor.ReadToEnd();

            Console.WriteLine(leitor.ReadLine());
            Console.WriteLine(leitor.ReadLine());
            Console.WriteLine(leitor.ReadLine());
            Console.WriteLine(leitor.ReadLine());
            Console.WriteLine(leitor.ReadLine());*/
            /*List<string> listas = new List<string>(); // lendo cada linha usando uma lista
            string linha = "";//cria a string linha com null

            while( linha != null ) // enquanto linha for diferente de null, leia
            {
                linha = leitor.ReadLine();      //repetidor while
                if( linha != null )  // se linha for diferente leia
                {
                    listas.Add( linha );    //lendo a lista e adcionando mais uma linha
                }
                
            }

            foreach (string nome in listas) // lendo cada linha por vez e printando 
            {
                Console.WriteLine(nome);
            }

            Console.WriteLine(listas[1]); // lendo só a linha desejada

            StreamReader sr = new StreamReader("teste.txt");
            //Console.WriteLine(sr.ReadToEnd());

            List<string> Linhas = new List<string>();
            string lista = "";

            while (lista != null)
            {
                lista = sr.ReadLine();
                if(lista != null)
                {
                    Linhas.Add(lista);
                }
            }

            foreach (var nome in  Linhas)
            {
                Console.WriteLine(nome);
            }*/

            Produtu fruta = new Produtu("banana", 1000f);

            string curso = "Curso de c#";

            List<string> Langs = new List<string>();
            Langs.Add("Java");
            Langs.Add("c#");


            FileStream stream = new FileStream("ARQ.gui", FileMode.OpenOrCreate);
            BinaryFormatter codificador = new BinaryFormatter();

            codificador.Serialize(stream, fruta);

            /* List<string> listadoarquivo = (List<String>)codificador.Deserialize(stream);
            Produtu prod = (Produtu)codificador.Deserialize(stream);


            Console.WriteLine(prod.nome);


             stream.Close(); */


            //<<  ORIENTAÇÃO A OBJETOS EM C# >>  //


            /*Programação orientada a objetos, até agora estava programando com o 
             * paradigma procedural, usando variaveis e funções, mas tem
             * um problema, com projetos maiores e media escala, acaba se criando um 
             * projeto monolitico, um grade bloco de código dentro de um arquivo (monolito), e chega o  momento
             * que copia e cola muito codigo, e por isso nasceu a POO, ao inves de fazer tudo
             * no mesmo arquivo, é separado por blocos logigos em arquivos diferentes, como um  sistema
             * de escola que vai ter só a parte
             * de matricula, outra de alunos e etc, ajuda a evitar muito copia e cola, vai deixar mais
             * organizado, que leve menos tempo, e mais barato também, essas unidades
             * dentro da POO, são chamadas de classes.*/


            //Abstração POO

            /*
            Abstração é a habilidade de conseguir construir classes, programas para os meus projetos ou de clientes
            Conseguir ver aspctos essenciais de determinado tema para o projeto, como um ecormece para apenas celulares, usando suas principais
            caracteristicas, como peso, altura, capacidades e etc.
                Lembrando que que cada "tema" tem seus atributos e métodos.
                
            Abstração é conseguir ver informações de dado tema para o projeto.
             */


            //Construtores 

            // um construtor é quase a mesma coisa que uma classe, nele vc pode definir objetos e guardar valores dentro deles



            // Emcapsulamento

            //static = deixa a linha estatica para usar em qualquer lugar do codigo
            //public = deixa a linha public para qualquer lugar do projeto
            //private = só vai aceitar dentro do seu escopo

            //Validação

            static AddAtores()
            {
                if (nome != null)
                {
                    AddAtores.Add("Brad pitt");
                }

                if(nome < atores.Length)
                {
                    AddAtores.Add("Brad pitt");
                }
            }

            
            //validação caso sem querer vc defina uma lista ou algo como null

            //emcapsular é mais para a integridade do codigo e segurança dependendo do que vc for fazer para evitar erros



            // Herança 

            //  Para melhorar o desenvolvimento, criamos filhos que herdam caracteristicas dos pais. Por exemplo:

            class Usuario
        {
            public string nome;
            public string email;
            public string senha;

            public void Login()
            {
                Console.WriteLine("Logando...");
            }

            public void Exibir()
            {
                Console.WriteLine($"Nome: {nome}");
                Console.WriteLine($"Email: {email}");
                Console.WriteLine($"Senha: {senha}");
            }
        }

        class Aluno : Usuario 
        {

            public string turno;
            public string sala;
        }

        Aluno a = new Aluno();
        a.nome = "Guilherme"
        a.email = "30755@gmail.com"
        a.senha = "30755"
        Exibir();


        // Protected - um meio de se trabalhar melhor com herança

        Exemplo:


            class Pai
        {
            public string nome;
            public string email;
            private string senha;  //Ela priva essa linha deixando ela acessivel só dentro da propria classe pai
            protected string sala; // Ela priva a linhas mas deixa ela ser compartilhada com seus irmãos

            public Pai(string nome, string email)
            {
                this.nome = nome;
                this.email = email;
            }
        }


        class Aluno : Usuario
        {

            public string turno;
            public string sala;


            public filho(string nome, string email, string senha, string sala):base(string nome, string sala)
            {
                    // cria-se primeiro o construtor dentro da classe pai e referencia ela com um novo
                    // construtor aluno com os parametros da classe e depois
                    // com base para os parametros do construtor 
            }
        }








        Console.ReadLine();

        }
        static void GerarProduto(int preco, string nome)
        {
            /*int precoAbs = Math.Abs(preco);
            int precoFinal = precoAbs + (precoAbs * 2);
            Console.WriteLine("Nome do Produto: " + nome);
            Console.WriteLine("Valor do produto: " + precoFinal);*/
        }

        static int Somar(int a, int b, int c)
        {
            Console.WriteLine("a");

            int ResultadoFinal = a + b + c;
            return ResultadoFinal;

            Console.WriteLine("B");
        }

    }
}