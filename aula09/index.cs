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

using System;

namespace Program
{
    public class Program
    {
        static void Main ()
        {
            soma(5,4);
        }

        static void soma(int n1, int n2)
        {
            int r = n1 + n2;
            
            r = n1 + n2;
            Console.WriteLine(r);
        }
    }
}
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
using System;

namespace Program
{
    public class Program
    {
        static void Main()
        {
            int tempo = 0;
            char escolha;

            inicio:

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

            Console.WriteLine("Deseja continuar com o programa?");
            Console.WriteLine("<<< S / N >>>");
            escolha = Char.Parse(Console.ReadLine());

            if(escolha == 'S' || escolha == 's'){
                Console.Clear();
                goto inicio;
            }
            else if(escolha == 'N' || escolha == 'n'){
                Console.Clear();
                Console.WriteLine("fim do programa :/");
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
            int tempo = 0;
            char escolha;

            inicio:

            Console.WriteLine("<<< Viagem de Rolândia para Londrina >>>");
            Console.WriteLine("Escolha seu meio de transporte:");
            Console.WriteLine("A) carro");
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

            Console.WriteLine("Deseja continuar com o programa?");
            Console.WriteLine("<<< S / N >>>");
            escolha = Char.Parse(Console.ReadLine());

            if(escolha == 'S' || escolha == 's'){
                Console.Clear();
                goto inicio;
            }
            else if(escolha == 'N' || escolha == 'n'){
                Console.Clear();
                Console.WriteLine("fim do programa :/");
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
            int[] macacos = new int[3]{10,22,33};

            Console.WriteLine(macacos[2]);
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
            string[] macacos = new string[]{'cesar','lula','bolsonaror'};
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
            lula();
        }

        static void lula() 
        {
            Console.WriteLine("Lula é ladrão?");
            Console.WriteLine("S OU N ?");
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
            lula();
        }

        static void lula() 
        {
        for(int i = 0;i <= 10;i++){
            Console.WriteLine("TE AMO <3!!!");
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
            int tempo = 0;
            char escolha;

            inicio:

            Console.WriteLine("<<< Viagem de Rolândia para Londrina >>>");
            Console.WriteLine("Escolha seu meio de transporte:");
            Console.WriteLine("A) carro");
            Console.WriteLine("B) moto");
            escolha = char.Parse(Console.ReadLine());

            switch (escolha)
            {

                case 'A':
                case 'a':
                tempo = 50;
                break;

                case 'b':
                case 'B':
                tempo = 120;
                break;
                
                default:
                tempo = -1;
                break;
            }

            if(tempo == 50){
                Console.WriteLine("Voçê escolheu ir de carro, cerca de 50 minutos.");
            }
            else if(tempo == 100){
                Console.WriteLine("Voçê escolheu ir de moto, cerca de 100 minutos.");
            }

            Console.WriteLine("Deseja continuar?");
            Console.WriteLine("S / N");
            escolha = char.Parse(Console.ReadLine());

            if(escolha == 'S' || escolha == 's'){
                Console.Clear();
                goto inicio;
            }
            else if(escolha == 'n' || escolha == 'N'){
                Console.Clear();
                Console.WriteLine("Fim do Programa");
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
            int tempo = 0;
            char escolha;

            inicio:

            Console.WriteLine("<<< Viagem de Rolândia para Londrina >>>");
            Console.WriteLine("Escolha seu meio de transporte:");
            Console.WriteLine("A) carro");
            Console.WriteLine("B) moto");
            escolha = char.Parse(Console.ReadLine());

            switch (escolha)
            {

                case 'A':
                case 'a':
                tempo = 50;
                break;

                case 'b':
                case 'B':
                tempo = 120;
                break;
                
                default:
                tempo = -1;
                break;
            }

            if(tempo == 50){
                Console.WriteLine("Voçê escolheu ir de carro, cerca de 50 minutos.");
            }
            else if(tempo == 120){
                Console.WriteLine("Voçê escolheu ir de moto, cerca de 120 minutos.");
            }

            Console.WriteLine("Deseja continuar?");
            Console.WriteLine("S / N");
            escolha = char.Parse(Console.ReadLine());

            if(escolha == 'S' || escolha == 's'){
                Console.Clear();
                goto inicio;
            }
            else if(escolha == 'n' || escolha == 'N'){
                Console.Clear();
                Console.WriteLine("Fim do Programa");
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
            int[] números = new int[3]{11,22,33};

            Console.WriteLine(números[1]);
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
            int[] números = new int[3]{11,22,33};

            Console.WriteLine(números[1]);
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
            Console.WriteLine("Deus é amor!!!");
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
            int n1 = 1, n2 = 3, soma = 0;

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
        static void Main ()
        {
            char escolha;
            int tempo = 0;

            inicio:

            Console.WriteLine("<<< Viagem de Rolândia para Londrina >>>");
            Console.WriteLine("escolha seu meio de transporte: ");
            Console.WriteLine("a) CARRO");
            Console.WriteLine("b) MOTO");
            escolha = char.Parse(Console.ReadLine());

            switch (escolha)
            {

                case'A':
                case'a':
                tempo = 50;
                break;

                case'B':
                case'b':
                tempo = 100;
                break;
                
                default:

                tempo = 0;

                break;
            }

            if(tempo == 50){
                Console.WriteLine("Voçê escolheu ir de carro, cerca de 50 minutos!");
            }
            else if(tempo == 100){
                Console.WriteLine("Voçê escolheu ir de moto, cerca de 100 minutos!");
            }

            Console.WriteLine("Voçê deseja continuar?");
            Console.WriteLine("SIM OU NÃO?");
            escolha = char.Parse(Console.ReadLine());

            if(escolha == 's' || escolha == 'S'){
                Console.Clear();
                goto inicio;
            }
            else if(escolha == 'N' || escolha == 'n'){
                Console.WriteLine("FIM DO PROGRAMA!");
                Console.Clear();
            }
        }
    }
}Console.WriteLine("hello Word");using System;

namespace Program
{
    public class Program
    {
        static void Main ()
        {
            soma();
        }

        static void soma()
        {
            int n1, n2,r=0;
            n1=int.Parse(Console.ReadLine());
            n2=int.Parse(Console.ReadLine());
            r = n1 + n2;
            Console.WriteLine(r);
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
            int v1,v2;
            v1=int.Parse(Console.ReadLine());
            v2=int.Parse(Console.ReadLine());

            soma(1,4);
        }

        static void soma()
        {
            int n1, n2,r=0;
            
            r = n1 + n2;
            Console.WriteLine(r);
        }
    }
}