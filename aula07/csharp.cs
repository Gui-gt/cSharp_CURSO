using System;// Biblioteca
namespace program//nome do diretorio
{
    public class Program//classe publica
    {
        static void Main () {//vazio estatico
            int tempo = 0;//tipo inteiro
            char escolha;//letras


            inicio:

            Console.Clear();//limpa o programa

            Console.Write("Viagem para Belo Horizonte/MG a Vitoria/ES");//string
            Console.Write("Escolha o meio de trasnporte: [A] AVIÃO  [C] CARRO  [O] ONIBUS");//escolhas
            escolha = char.Parse(Console.ReadLine());//colocando qual vai ser o tipo que vai ser digitado
            switch(escolha) 
            {
                case 'a':           
                case 'A':
                tempo=50;
                break;

                case 'c':
                case 'C':
                tempo=480;
                break;

                case 'o':
                case 'O':
                tempo=660;
                break;

                default:

                tempo=-1;

                break;

            }

            if(tempo < 0){
                Console.Write("Transporte indisponivel");
            }else{
                Console.Write("O tempo do transporte escolhido é de {0}",tempo);
            }

            Console.WriteLine("\nCalcular outro transporte?[S/N]");
            escolha=char.Parse(Console.ReadLine());

                if(escolha == 's' || escolha == 'S'){
                    goto inicio;
                }
                else{
                    Console.Clear();
                    Console.Write("FIM DO PROGRAMA");
                }

        }
    }
}
using System;

namespace program
{
    public class Program
    {
        static void Main ()
        {
            int tempo = 0;
            char escolha;

            inicio:
            Console.Clear();

            Console.Write("Viagem de Londrina para Maringá");
            Console.Write("Escolha seu meio de trasnporte: A) Carro B) Moto");
            escolha=char.Parse(Console.ReadLine());

            switch (escolha)
            {
                case 'a':
                case 'A':
                tempo = 50;
                break;

                case 'b':
                case 'B':
                tempo = 40;
                break;

                default:

                tempo =-1;

                break;
            }

                if(tempo < 0){
                    Console.Write("Transporte indisponivel");
                }
                else{
                    Console.Write("O transporte escolhido levara {0} minutos pra chegar",tempo);
                }

                Console.Write("\nContinuar escolhendo? N/S");
                escolha=char.Parse(Console.ReadLine());

                if(escolha == 's' || escolha == 'S'){
                    goto inicio;
                }else{
                    Console.Clear();
                    Console.Write("Fim das escolhas!");
                }

        }
    }
}
using System;

namespace program
{
    public class Program
    {
        static void Main (){
            int tempo = 0;
            char escolha;
            inicio:
            Console.Clear();
            Console.WriteLine("Viagem de rolandia a londrina");
            Console.WriteLine("Escolha um meio de transporte: \nA) carro \nB) Moto\nC) Teletransporte");
            escolha=char.Parse(Console.ReadLine());

            switch (escolha)
            {

                case 'a':
                case 'A':
                tempo=50;
                break;

                case 'b':
                case 'B':
                tempo = 180;
                break;

                case 'c':
                case 'C':
                tempo = 1;
                break;
                
                default:
                tempo = -1;
                break;
            }

            if(tempo < 0){
                Console.Write("Viagem indisponivel");
            }
            else{
                Console.Write("Sua viagem levara {0} minutos.",tempo);
            }

            Console.Write("\nContinuar com os testes? n/s");
            escolha=char.Parse(Console.ReadLine());

            if(escolha == 's' || escolha == 'S'){
                goto inicio;
            }else{
                Console.Clear();
                Console.Write("\nFim dos testes");
            }
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System;

namespace vvv
{
    public class Program
    {
        static void Main ()
        {
            int n1,n2,nota=0;

            Console.Write("Digite um valor: ");
            n1=int.Parse(Console.ReadLine());
            Console.Write("Digite um valor: ");
            n2=int.Parse(Console.ReadLine());

            nota=n1+n2;

            if(nota < 60){
                Console.Write("NOTA {0},REPROVADO",nota);
            }
            else if(nota >= 60){
                Console.Write("Nota {0}, APROVADO",nota);
            }
        }
    }
}
using System;

namespace vvv
{
    public class Program
    {
        static void Main () 
        {
            int tempo = 0;
            char escolha;

            inicio:

            Console.Clear();

            Console.Write("Viagem de rolandia para londrina. \n");
            Console.Write("Escolha seu meio de transporte \n A) CORRENDO \n B) BICICLETA");
            escolha=char.Parse(Console.ReadLine());

            switch (escolha)
            {

                case 'a':
                case 'A':
                tempo=300;
                break;
                case 'b':
                case 'B':
                tempo=100;
                break;
                default:
                tempo=0;
                break;
            }

            if(tempo == 100){
                Console.Write("Vc escolheu bicicleta, 100 minutos. ");
            }
            else if(tempo == 300){
                Console.Write("Vc escolheu correndo, 300 minutos. ");
            }

            Console.Write("Deseja continuar? S/N");
            escolha=char.Parse(Console.ReadLine());

            if(escolha == 's' || escolha == 'S'){
                goto inicio;
            }else{
                Console.Clear();
                Console.WriteLine("FIM DO PROGRAMA");
            }


        }
    }
}