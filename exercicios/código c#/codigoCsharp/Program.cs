using System;
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
using System.Data;
using System.ComponentModel.Design;
using System.Net;

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

                if (nome < atores.Length)
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


            public filho(string nome, string email, string senha, string sala) : base(string nome, string sala)
            {
                // cria-se primeiro o construtor dentro da classe pai e referencia ela com um novo
                // construtor aluno com os parametros da classe e depois
                // com base para os parametros do construtor 
            }
        }

        //Tabelas 

        //usando a classe DataTable, DataColumn e DataRow, já consgigo criar uma tabela, que tbm pode converter para arquivos XML e XMLSchema

        //exemplo:

        DataTable tabela = new DataTable("Costumers");
        DataColumn coluna1 = new DataColumn("coluna1");
        DataColumn coluna2 = new DataColumn("coluna2");

        tabela.Columns.Add("coluna1");
        tabela.Columns.Add("coluna2");

        DataRow linha1 = tabela.newRow();
        linha1["coluna1"] = "valor1";
        linha1["coluna2"] = "valor2";
        tabela.Rows.Add(linha1);

        tabela.Xml("tabela.XML");
        tabela.XmlSchema("Tabela.Schema");

        //Polimorfismo de Herança
        //Guarda tipos diferentes em um só tipo
        //como a classe aluno do tipo aluno e zelador dentro do tipo usuario, e mesmo assim serem chamados 

         //Polimorfismo de sobrecarga
         //duas funções com o mesmo nome dentro da classe, o que muda entre eles são os parametros
         //assinatura do metodos com os parametros, para o c# o que vale nessas assinaturas é o tipo e a ordem

            //exemplo:

            static void Logar() //Logar(void) sem parametros
        {
            Console.WriteLine("Logando....");
        }

        static void Logar(string logandoSenha) // Logar(string)
        {
            Console.WriteLine("Login com senha...");
        }

        static void ogar(string email, string codigo) //Logar(string, string)
        {
            Console.WriteLine("Email e senha");
        }

        static void Logar(string email, int pin)// Logar(email, pin)
        {
            Console.WriteLine("Email, pin");
        }

        static void Logar(int pin, string email)// Logar(pin, email)
        {
            Console.WriteLine("pin, email");
        }



        //Polimorfismo de sobreposição
        // Para sobrepor a classe pai ao filho, printando primeiro com o metodo base e override
        //mais usado para criar bibliotecas, muito dificil algo para clientes finais, mais como alterações num projeto

        //Exemplo:

        static override void Exibir() // override = sobrepor
        {
            Console.WriteLine("Dados do aluno:");
            base.Exibir();                          //base = chama a função dentro do pai
            Console.WriteLine("Turno:" + turno);
        }



        //Irtefaces

        string FormaSelecionada = "RETANGULO";

        //  Line, Tri, Circ,    Rect,   Quad
        IDrawable shape = new Line();
        
        shape.Draw();

            //Desse modo é bem melhor do que ficar usando if e else adoidado
            //Chamo a interface e atribuo uma variavel a ela que recebe uma nova line que a variavel shape "Desenha" na tela.

        

        if(FormaSelecionada)
        {
                
            //Logica de Line
            if(FormaSelecionada == "Line")
            {

            }
            //Logica de Circ
            else if(FormaSelecionada == "Quad")
            {

            }
            //Logica de Tri
            else if(FormaSelecionada == "Tri")
            {

            }

            //Logica de Quade
            else if(FormaSelecionada == "Circ")
            {

            }

            //Logica de Rect
            else if(FormaSelecionada == "Rect")
            {
            
            }

            //Se caso esse Lógica tivesse 20 cases caso fosse um SWITCH tbm, daria muita repetição de código e um código macarronico.
            // E a interface ajuda para isso.
            //Uma interface é como se fosse um contrato que tem suas claúsulas 
            //NN tem modificadores de acesso, quando se trabalha com interface, tudp é publico
            // uma interface define um conjunto de metodos que uma classe precisa implementar



            interface IDrawable
        {
            void Draw(); //define o retorna e coloca os parametros
        }

        class Line() : Usuario, IDrawable, IFormattable, IDesigner // Só pode ter uma herança caso for usar uma e posso usar quantas interfaces eu quiser
        {
            public void Draw()
            {
                Console.WriteLine("--lINE--");//Pode se usar a lampada para implementar 
            }
        }

        class Tri() : IDrawable
        {
            public void Draw()
            {
                Console.WriteLine("--TRI--");
            }
        }
        class Circ() : IDrawable
        {
            public void Draw()
            {
               Console.WriteLine("--CIRC--");
            }
        }



        //Classe abstrada
        // é meio semelhante as Interfaces, nela você tem colocar sua assinatura, implementar os metodos mesmo que essas funções sejam vazias
        // ela pode ter atributos, variaveis e metodos dentro dela
        // Classe abstrada é praticamente uma mistura de Herança com Interface
        // A maioria dos programadores usam mais interfaces do que a classe abstrada


        //Exemplo:

            class Desenhar
        {

            public int size;
            public string name;  //variaveis
            string pintar()
            {
                return 0;
            }

            public abstract float area();  //Caso queira não retornar nada, é obrigatorio colocar public abstract e tirar os colchetes

        }

        

            //Namespaces 
                    // é o nome do seu bloco de código, como para bibliotecas e classes
                        //Exemplo:

                            //namespace Netflix
                            { 
                                //CÓDIGO
                            }

                            // pode se escrever com mais extenções tbm 

                            //namespace Netflix.com.br
                            { 
                                //CÓDIGO
                            }

                        // Tambem dá para referenciar um namesSpace no using

                                        using Netflix.com.br;


                            //É melhor para a organização de projetos e bibliotecas grandes e complexas.


                    // Struct vs Classes 

                      // Os dois criam novos tipos de dados, mas o que difere é o seu uso de armazenamento da memoria ram
                      // Struct trabalha com um mecanismo de cópia, criando uma variavel e copiando ela na memoria quando se aplica a mesma.
                      // Struct não tem como usar Polimorfismo, Herança e nem Interfaces e precisa passar os dados nos campos. é mais limitado.
                      // Sempre que possivel use classes.
                      // Uma classe trabalha com um mecanismo de referencia, apontando, fazendo assim não uso da memoria gerando copias, e melhorando a produtividade do código.
                      // E quando essa refencia é cortada, um agente do C# chamado GC (Garbage Colector), automaticamente quando o código é executado
                      // Ele joga as variaveis que não estão em uso no lixo.

                    // Protocolo HTTP
                    // é o protocolo que faz requisições de servidores para os clientes, por exemplo, um computador da goole(servidor) 
                    //contem paginas e arquivos que usuario x quer acessar e nisso o HTTP faz a requisão de lá para o cliente mostrando assim
                    //na sua tela ou celular
                    //Uma analogia, os computadores são  órgãos, as veias são as conexões de cabo e rede internet, e a corrente sanguinea é
                    // o HTTP levando informações e nutrientes para os computdores

                    //web request

                           //Requisição para web
                          var Requisicao = WebRequest.Create("https://jsonplaceholder.typicode.com/todos/");

                        Requisicao.Method = "GET";

                                using (var resposta = Requisicao.GetResponse())
                                {
                                        var stream = resposta.GetResponseStream();
                                        StreamReader leitor = new StreamReader(stream);
                                        object dados = leitor.ReadToEnd();


                                      Console.WriteLine(dados.ToString());

                                    stream.Close();  
    
                                    resposta.Close();
                                }


// mais sobre requisiçoes web

                    static void Main(string[] args)
                    {
                        //ReqList();
                        ReqUnica();

                    }
}
                static void ReqUnica()
                {
                    var requisicao = WebRequest.Create("https://jsonplaceholder.typicode.com/todos/5");
                    var resposta = requisicao.GetResponse();

                    using (resposta)
                    {
                        var stream = resposta.GetResponseStream();
                        StreamReader leitor = new StreamReader(stream);
                        object dados = leitor.ReadToEnd();


                        Tarefa tarefa = JsonConvert.DeserializeObject<Tarefa>(dados.ToString());

                        tarefa.Exibir();


                        resposta.Close();
                        leitor.Close();

                    }

                        //dev web
                        //aspnet
                        //aspnetcore

                        //dev mobile
                        //xamarin
                        //maui

                        //dev desktop
                        //WPF - Windows e talvez linux e Ios, pesquise sobre

                        //dev jogos
                        //unity

                        //faça um por vez 
                        //tem mais mercado no brasil para web e mobile, e mais jogos do que desktop

                        //Curso formação Csharp Finalizado!



}





        


                            Console.ReadLine();

   
                            /*static void GerarProduto(int preco, string nome)
                            {
                                /*int precoAbs = Math.Abs(preco);
                                int precoFinal = precoAbs + (precoAbs * 2);
                                Console.WriteLine("Nome do Produto: " + nome);
                                Console.WriteLine("Valor do produto: " + precoFinal);
                            }

                            static int Somar(int a, int b, int c)
                            {
                                Console.WriteLine("a");

                                int ResultadoFinal = a + b + c;
                                return ResultadoFinal;

                                Console.WriteLine("B");
                            }*/

                        }
                    }


                    Console.WriteLine("Hello Word!");
                    Console.ReadLine();
   