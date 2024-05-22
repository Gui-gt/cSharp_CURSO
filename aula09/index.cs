using System;

namespace CSHARP_CURSO
{
    public class index
    {
        static void Main()
        {
            cfb();
        }

        static void cfb()
        {
            Console.WriteLine("OLA MUNDO");
        }
    }
}

using System;

namespace Program
{
    public class Program
    {
        static void Main()
        {

            int v1,v2,r;
            v1 = int.Parse(Console.ReadLine());
            v2 = int.Parse(Console.ReadLine());
            r = soma(v1,v2);
            Console.WriteLine("A soma de {0} mais {1} é: {2}",v1, v2, r);
        }

        static int soma(int n1, int n2)
        {
            int res = n1 + n2;

            return res;
        }
    }
}using System;

namespace Program
{
    public class Program
    {
        static void Main()
        {
        soma(10,8);
        }

        static void soma(int n1, int n2)
        {
            int soma = n1 + n2;

            Console.WriteLine("A soma entre {0} e {1} é {2}",n1,n2,soma);
        }
    }
}
using System;

namespace Program
{
    public class Program
    {
        static void Main()
        {
            for(int i = 0;i <= 3;i++){
                cfb();
            }
        }

        static void cfb()
        {
            Console.WriteLine("Olá mundo!");
        }
    }
}
using System;

namespace Program
{
    public class Program
    {
        static void Main()
        {
            cfb();
        }

        static void cfb()
        {
            Console.WriteLine("Olá mundo!");
        }
    }
}
// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
Console.WriteLine("deixa o cara gozar");
using System;

namespace Program
{
    public class Program
    {
        static void Main ()
        {
            cola();
        }
        static void cola()
        {
            for(int i = 0;i < 10;i++){
                Console.WriteLine("FAÇA");
            }
            
        }
    }
}
using System;

namespace Program
{
    public class Program
    {
        static void Main ()
        {
            cola(10,4);
        }
        static void cola(int n1, int n2)
        {
            int soma;
            soma = n1 + n2;
            
            Console.WriteLine("A soma entre {0} e {1} é: {2}",n1,n2,soma);
        }
    }
}
using System;
namespace Program
{
    public class Program
    {
        static void Main ()
        {
            int v1,v2,res=0;
            v1 = int.Parse(Console.ReadLine());
            v2 = int.Parse(Console.ReadLine());
            soma(v1,v2);
        }

        static void soma(int n1, int n2)
        {
            int res;
            res = n1 + n2;
            Console.WriteLine("A soma entre {0} e {1} é {2}",n1,n2,res);
        }
    }
}
using System;

namespace Program
{
    public class Program
    {
        static void Main()
        {
            resultado(20,12);
        }

        static void resultado(int n1, int n2)
        {
            int soma =0;

            soma = n1 + n2;

            Console.WriteLine("{0} mais {1} é {2}",n1,n2,soma);
        }
    }
}
using System;

namespace Program
{
    public class Program
    {
        static void Main()
        {
            char escolha;
            int tempo = 0;

            Console.WriteLine("<<< Viagem de rolandia para Londrina >>>");
            Console.WriteLine("Escolha um meio de transporte");
            Console.WriteLine("A) moto");
            Console.WriteLine("B) carro");
            escolha = char.Parse(Console.ReadLine());

            switch(escolha)
            {
                case 'a':
                case 'A':
                tempo = 20;
                break;

                case 'b':
                case 'B':
                tempo = 50;
                break;
            }
        }
    }
}
using System;

namespace Program
{
    public class Program
    {
        static void Main()
        {
            char escolha;
            int tempo = 0;

            Console.WriteLine("<<< Viagem de rolandia para Londrina >>>");
            Console.WriteLine("Escolha um meio de transporte");
            Console.WriteLine("A) moto");
            Console.WriteLine("B) carro");
            escolha = char.Parse(Console.ReadLine());

            switch(escolha)
            {
                case 'a':
                case 'A':
                tempo = 20;
                break;

                case 'b':
                case 'B':
                tempo = 50;
                break;

                default:

                tempo = 0;

                break;
            }

            if(tempo == 20){
                Console.WriteLine("Vc escolheu moto, 20 minutos para chegar ao destino.");
            }
            else if(tempo == 50){
                Console.WriteLine("Vc escolheu carro, 50 minutos para chegar ao destino");
            }

            Console.WriteLine("Deseja Continuar?");
            Console.WriteLine("S/N");

            if(escolha == 'N' || escolha == 'n'){
                Console.Clear();
                Console.WriteLine("FIM DO PROGRAMA");
            }
            ELSE


        }
    }
}
using System;

namespace Program
{
    public class Program
    {
        static void Main()
        {
            char escolha;
            int tempo = 0;

            inicio:

            Console.WriteLine("<<< Viagem de rolandia para Londrina >>>");
            Console.WriteLine("Escolha um meio de transporte");
            Console.WriteLine("A) moto");
            Console.WriteLine("B) carro");
            escolha = char.Parse(Console.ReadLine());

            switch(escolha)
            {
                case 'a':
                case 'A':
                tempo = 20;
                break;

                case 'b':
                case 'B':
                tempo = 50;
                break;

                default:

                tempo = 0;

                break;
            }

            if(tempo == 20){
                Console.WriteLine("Vc escolheu moto, 20 minutos para chegar ao destino.");
            }
            else if(tempo == 50){
                Console.WriteLine("Vc escolheu carro, 50 minutos para chegar ao destino");
            }

            Console.WriteLine("Deseja Continuar?");
            Console.WriteLine("S/N");

            if(escolha == 'N' || escolha == 'n'){
                Console.Clear();
                Console.WriteLine("FIM DO PROGRAMA");
            }
            else if(escolha == 'S' || escolha == 's'){
                Console.Clear();
                goto inicio;
            }


        }
    }
}
using System;

namespace Program
{
    public class Program
    {
        static void Main()
        {
            char escolha;
            int tempo = 0;

            inicio:

            Console.WriteLine("<<< Viagem de rolandia para Londrina >>>");
            Console.WriteLine("Escolha um meio de transporte");
            Console.WriteLine("A) moto");
            Console.WriteLine("B) carro");
            escolha = char.Parse(Console.ReadLine());

            switch(escolha)
            {
                case 'a':
                case 'A':
                tempo = 20;
                break;

                case 'b':
                case 'B':
                tempo = 50;
                break;

                default:

                tempo = 0;

                break;
            }

            if(tempo == 20){
                Console.WriteLine("Vc escolheu moto, 20 minutos para chegar ao destino.");
            }
            else if(tempo == 50){
                Console.WriteLine("Vc escolheu carro, 50 minutos para chegar ao destino");
            }

            Console.WriteLine("Deseja Continuar?");
            Console.WriteLine("S/N");
            escolha = char.Parse(Console.ReadLine());

            if(escolha == 'N' || escolha == 'n'){
                Console.Clear();
                Console.WriteLine("FIM DO PROGRAMA");
            }
            else if(escolha == 'S' || escolha == 's'){
                Console.Clear();
                goto inicio;
            }


        }
    }
}
using System;

namespace Program
{
    public class Program
    {
        static void Main()
        {
            Console.WriteLine("Hello Word");
        }
    }
}
using System;

namespace Program
{
    public class Program
    {
        static void Main()
        {
            int n1 = 30;

            Console.WriteLine(n1);
        }
    }
}
using System;

namespace Program
{
    public class Program
    {
        static void Main()
        {
            int n1= 10, n2=20, soma = 0;

            Console.WriteLine("SOMA DAS NOTAS");
            soma = n1 + n2;
            Console.WriteLine("{0} + {1} = {2}",n1,n2,soma);
        }
    }
}
using System;

namespace Program
{
    public class Program
    {
        static void Main()
        {
            int n1,n2,soma;

            Console.WriteLine("<<< Notas da escola >>>");
            Console.WriteLine("Digite a primeira nota");
            n1=int.Parse(Console.ReadLine());
            Console.WriteLine("Digite a segunda nota");
            n2=int.Parse(Console.ReadLine());

            soma = n1 + n2;

            Console.WriteLine("NOTA {0}",soma);
        }
    }
}
using System;

namespace Program
{
    public class Program
    {
        static void Main()
        {
            int tempo = 0;
            char escolha;

            Console.WriteLine("<<< Viagem de Rolândia para Londrina >>>");
            Console.WriteLine("Escolha seu meio de transporte:");
            Console.WriteLine("A) carro");
            escolha = char.Parse(Console.ReadLine());
            Console.WriteLine("B) moto");
            escolha = char.Parse(Console.ReadLine());

            

            switch(escolha){

                    case 'a':
                    case 'A':
                    tempo = 30;
                    break;

                    case 'B':
                    case 'b':
                    tempo = 20;
                    break;

                    default:
                    tempo = -1;
                    break;
            }

            if(tempo == 30){
                Console.WriteLine("Voçê escolheu ir de carro, cerca de 30 minutos até o seu destino...");
            }
            else if(tempo == 20){
                Console.WriteLine("Voçê escolheu ir de moto, cerca de 20 minutos até o seu destino...");
            }
        }
    }
}