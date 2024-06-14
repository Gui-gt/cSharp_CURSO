using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {

        struct Produto
        {
            public int peso;
            public int altura;
            public string nome;

            public Produto(int peso, int altura, string nome)
            {
                this.peso = peso;   
                this.altura = altura;   
                this.nome = nome;   
            }
        }


        enum Cor { Azul, Amarelo, Preto, Verde, Roxo};
        enum Opcao { Criar = 1, Deletar, Editar, Listar, Atualizar};
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

            Console.ReadLine();*/


            Produto carro = new Produto(2000, 1, "McLaren");
            Produto moto = new Produto(400, 1, "Kawazaki");

            Console.WriteLine(carro.nome);
            Console.WriteLine(moto.nome);   

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
