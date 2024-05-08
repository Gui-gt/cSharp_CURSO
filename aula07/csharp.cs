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
using System;

namespace cccccc
{
    public class Program
    {
        static void Main()
        {
            
            int[] n=new int[3];
            int[] num=new int[3]{55,77,88};
            int[] nume = {55,77,88};

            n[0]=111;
            n[1]=222;
            n[2]=333;

            Console.Write(n[0]);
        }
    }
}
using System;
using System.Globalization;

namespace cccccc
{
    public class Program
    {
        static void Main ()
        {
        int[] num ={1,2};

        Console.Write(num[1]);
        }
    }
}
using System;

namespace cccccc
{
    public class Program
    {
        static void Main ()
        {
            int[,] n=new int[3,5];
            /*
            10 20 30 40 50
            60 70 80 90 15
            25 35 45 55 65
            */

            n[0,0]=10;
            n[0,1]=20;
            n[0,2]=30;
            n[0,3]=40;
            n[0,4]=50;

            n[1,0]=60;
            n[1,1]=70;
            n[1,2]=80;
            n[1,3]=90;
            n[1,4]=15;

            n[2,0]=25;
            n[2,1]=35;
            n[2,2]=45;
            n[2,3]=55;
            n[2,4]=65;

            Console.Write(n[2,1]);

        }
    }
}
using System;

namespace cccccc
{
    public class Program
    {
        static void Main()
        {       int[] num = new int[10];
            for (int i = 0;i<10;i++)
            {
                    Console.Write(num[i]);
            }
            for (int i = 0;i<10;i++)
            {
                    Console.Write("Posição do valor {0}: {1}\n",i,num[i]);

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
            for (int i = 0; i < 10; i++)
            {
                Console.Write("Push \n");
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
            int n = 0;
            while (n < 10)
            {
                Console.Write("Push! \n");
                n++;
            }
        }
    }
}using System;

namespace program
{
    public class Program
    {
        static void Main()
        {
            int[] num = new int[10];
            int i = num.Length-1;
            while (i>0)
            {
                num[i]=0;
                Console.WriteLine(num[i]);
                i--;
            }
        }
    }
}using System;
namespace Program
{
    public class Program
    {
        static void Main()
        {
            int[] num = new int[10];
            int i = num.Length-1;
            while (i > 0)
            {
                Console.WriteLine(num[i]);
                i--;
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
            for (int n = 0;n < 5;n++){
                Console.Write("Te amo Giovana! \n");
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
            string senha = "123";
            string  senhauser;
            int tentativas=0;

            do
            {
                Console.Clear();
                Console.WriteLine("Coloque sua senha:");
                senhauser = Console.ReadLine();
                tentativas++;
            } while (senha != senhauser);
            Console.Clear();
            Console.Write("Senha correta, tentativas {0}",tentativas);
        }
    }
}using System;

namespace Program
{
    public class Program
    {
        static void Main ()
        {
            string senha = "123";
            string senhauser;
            int tentativas = 0;

            do
            {
                Console.Clear();
                Console.Write("Coloque sua senha:");
                senhauser = Console.ReadLine();
                tentativas++;
            } while (senha != senhauser);
            Console.Clear();
            Console.Write("Senha correta, tentativas {0}",tentativas);
        }
    }
}using System;

namespace Program
{
    public class Program
    {
        static void Main ()
        {
            string senha = "123";
            string senhauser;
            int tentativas = 0;

            do
            {
                Console.Clear();
                Console.Write("Coloque sua senha:");
                senhauser = Console.ReadLine();
                tentativas++;
            } while (senha != senhauser);
            Console.Clear();
            Console.Write("Senha correta, tentativas {0}",tentativas);
        }
    }
}using System;
namespace Program
{
    public class Program
    {
        static void Main ()
        {
            string senha = "123";
            string senhauser;
            int tentativas = 0;

            do
            {
                Console.Clear();
                Console.Write("Digite sua senha: ");
                senhauser = Console.ReadLine();
                tentativas++;
            } while (senha != senhauser);
            Console.Clear();
            Console.WriteLine("Senha correta, tentativas {0}...",tentativas);
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
            int n1,n2,nota=0;

            Console.Write("Digite a primeira nota: ");
            n1=int.Parse(Console.ReadLine());
            Console.Write("Digite a segunda nota:");
            n2= int.Parse(Console.ReadLine());
            
            nota = n1 + n2; 

            if(nota < 60){
                Console.Write("REPROVADO");
            }else if(nota > 60){
                Console.Write("{0} APROVADO",nota);
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
            Console.Clear();

            Console.Write("Viagem de rolandia para londrina:");
            Console.Write("Escolha seu meio de transporte: \n A)carro B) moto");
            escolha = char.Parse(Console.ReadLine());

            switch (escolha)
            {
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
                Console.Write("Vc escolheu ir de caro, levara 30 minutos");
            }
            else if(tempo == 20){
                Console.Write("Vc escolheu ir de moto, levara 20 minutos");
            }

            Console.Write("Continuar? S/N");
            escolha = char.Parse(Console.ReadLine());

            if(escolha == 'S' || escolha == 's'){
                Console.Clear();
                goto inicio;
            }
            else{
                Console.Clear();
                Console.Write("FIM DO PROGRAMA!");
            }
        }
    }   
}
using System;

namespace Program
{
    public class Program
    {
        static void Main (){
            
            string senha = "123";
            string usersenha;
            int tentativas = 0;

            do
            {
                Console.Clear();
                Console.Write("Digite seua senha:");
                usersenha = Console.ReadLine();
                tentativas++;
            } while (senha != usersenha);

            Console.Clear();
            Console.Write("Senha correta, tentativas {0}",tentativas);
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
            int[] num = new int[10];

            int i = num.Length-1;

            while (i > 0)
            {
                num[i]=0;
                Console.Write(num[i]);
                i--;
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
            int[] num = new int[5]{11,22,33,44,55};

            foreach (int n in num)
            {
                Console.Write(n);
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
            int[] num = new int[2]{11,22};

            for(int z = 0;z<num.Length;z++)
            {
                    Console.Write(num[z]);
            }
        }
    }
}
using System;
using System.IO.Compression;

namespace Program
{
    public class Program
    {
        static void Main()
        {
            int[] num = new int[2]{11,22};
            
        foreach(int z in num){
            Console.Write(z);
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
            int n1,n2,nota=0;

            Console.WriteLine("Digite a primeira nota: ");
            n1=int.Parse(Console.ReadLine());
            Console.Write("Digite o segundo valor: ");
            n2=int.Parse(Console.ReadLine());

            nota = n1 + n2;

            Console.Write("A nota foi {0}",nota);

            if(nota > 60){
                Console.Write(", Parabens vc foi aprovado!");
            }
            else if(nota < 60){
                Console.Write("HORRIVEL, REPROVADO!!!");
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

            Console.Write(">>>VIAGEM DE ROLANDIA PARA LONDRINA<<<\n");
            Console.Write("Escolha seu meio de transporte:\n A) CARRO B) MOTO");
            escolha = char.Parse(Console.ReadLine());

            switch (escolha)
            {
                case 'A':
                case 'a':
                tempo=50;
                break;

                case 'b':
                case 'B':
                tempo = 30;
                break;
                
                default:

                tempo = 0;

                break;
            }

            if(tempo == 50){
                Console.Write("Vc escolheu ir de carro, levara 50 minutos");
            }
            else if(tempo == 30){
                Console.Write("Vc escolheu ir de moto, levara 30 minutos");
            }

            Console.Write("\n Deseja continuar: S/N?");
            escolha=char.Parse(Console.ReadLine());

            if(escolha == 's' || escolha == 'S'){
                Console.Clear();
                goto inicio;
            }
            else if(escolha == 'n' || escolha == 'N'){
                Console.Clear();
                Console.Write("<<<FIM DA EXECUÇÃO>>>");
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
            int[] num = new int[3]{10,21,45};

            Console.Write(num[1]);


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
            int n1,n2,nota=0;

            Console.WriteLine("<<<Avaliação de notas>>>");
            Console.WriteLine("Digite a primeira nota abaixo:");
            n1=int.Parse(Console.ReadLine());
            Console.WriteLine("Agora a segunda nota");
            n2=int.Parse(Console.ReadLine());

            nota = n1+n2;

            if(nota <= 60){
                Console.Write("Nota {0}, Aluno Reprovado",nota);
                if(nota >= 50){
                    Console.WriteLine("Nota {0},Aluno de recuperação",nota);
                }
            }
            else if(nota > 60){
                Console.Write("Nota {0}, aluno aprovado",nota);
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

            Console.WriteLine("<<<Viagem de Rolândia para Londrina>>>");
            Console.WriteLine("Escolha uma meio de viagem: A) Carro B) Moto C) Bicicleta");
            escolha = char.Parse(Console.ReadLine());

            switch (escolha)
            {
                case 'A':
                case 'a':
                tempo = 30;
                break;

                case 'B':
                case 'b':
                tempo = 20;
                break;

                case 'C':
                case 'c':
                tempo = 120;
                break; 

                default:
                tempo = 0;
                break;
            }

            if(tempo == 30){
                Console.WriteLine("Carro levará 30 minutos até o destino...");
            }else if(tempo == 20){
                Console.WriteLine("Moto levará 20 minutos até o destino...");
            }else if(tempo == 120){
                Console.WriteLine("Bicicleta levará 2 horas até o destino...");
            }

            Console.WriteLine("Deseja continuar?");
            Console.WriteLine("S/N");
        escolha = char.Parse(Console.ReadLine());

        if(escolha == 'S' || escolha == 's'){
                Console.Clear();
                goto inicio;
        }else if(escolha == 'n' || escolha == 'N'){
            Console.Clear();
            Console.WriteLine("FIM DO PROGRAMA");
        }

        }
    }
}