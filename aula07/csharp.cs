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