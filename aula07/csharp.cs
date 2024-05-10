using Susing System;

namespace program
{
    public class Program
    {
            static void Main ()
            {
                int tempo = 0;
                char escolha;

                inicio:
                Console.WriteLine("Viagem de rolandia para londrina:");
                Console.WriteLine("ESCOLHA SEU MEIO DE TRANSPORTE: A) CARRO B) MOTO");
                escolha = char.Parse(Console.ReadLine());

                switch (escolha)
                {

                    case 'a':
                    case 'A':
                    tempo = 30;
                    break;

                    case 'b':
                    case 'B':
                    tempo = 20;
                    break;



                    
                    default:

                    tempo = -1;

                    break;
                }

                if(tempo == 30){
                    Console.WriteLine("VC ESCOLHEU IR DE CARRO, 30 MNTS");
                }
                else if(tempo == 20){
                    Console.WriteLine("VC ESCOLHEU IR DE MOTO, LEVARA 20 MNTS");
                }

                goto inicio;
            }
    }
}