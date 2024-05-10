using System;

namespace program
{
    public class Program
    {
        static void Main ()
        {
            int n1,n2,nota=0;
            char escolha;

            inicio:

            Console.WriteLine("<<< AVALIAÇÕES >>>");
            Console.WriteLine("Digite a primeira nota: ");
            n1=int.Parse(Console.ReadLine());
            Console.WriteLine("Digite a segunda nota: ");
            n2=int.Parse(Console.ReadLine());

            nota = n1 + n2;

            if (nota > 60){
                Console.WriteLine("Nota {0}, Aluno aprovado",nota);
            }else if(nota < 60){
                Console.WriteLine("Nota {0}, Aluno reprovado",nota);
            }

            Console.WriteLine("Deseja continuar?");
            Console.WriteLine("S / N");
            escolha=char.Parse(Console.ReadLine());

            if(escolha == 's' || escolha == 'S'){
                Console.Clear();
                goto inicio;
            }else if(escolha == 'n' || escolha == 'N'){
                Console.Clear();
                Console.WriteLine("(((   FIM DA AVALIAÇÃO   )))");
            }

        }
    }
}