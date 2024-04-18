using System;

namespace CSHARP_CURSO
{
    public class aula06
    {
        static void Main ()
        {
            int n1=10, n2=20, n3=30;

            Console.Write("n1={0},n2={1},n3={2}"n1,n2,n3);
        }
    }
}using System;

namespace CSHARP_CURSO
{
    public class Program
    {
        static void Main ()
        {
            double valorCompra = 5.50;
            double venda;
            double lucro=0.1;
            string produto = "Pastel";

            venda = valorCompra+(valorCompra*lucro);

            Console.Write("Produto.....{0,15}",produto);
            Console.Write("Val.compra.....{0,15:c}",valorCompra);//formatando valores/operações
            Console.Write("Lucro.....{0,15:p}",lucro);
            Console.Write("Val.Venda.....{0,15:c}",venda);
        }
    }
}using System;

namespace Program
{
    public class Program
    {
        static void Main ()
        {
            const string nome = "Guilherme";//Usando constantes e formatando Textos
            const double pi = 1.654;
            Console.Write("Canal {0} \n Pi {1}",nome,pi);
        }
    }
}using System;

namespace Program
{
    public class Program
    {
        static void Main ()
        {
            int v1,v2,soma;
            

        Console.Write("Digite o primeiro Valor:");
        v1=int.Parse (Console.ReadLine());
        Console.Write("Digite o segundo Valor:");
        v2=int.Parse(Console.ReadLine());
        soma= v1+v2;
        Console.WriteLine("A soma entre {0} e {1} é {2}",v1,v2,soma);

        
        }
    }
}using System;

namespace Program
{
    public class Program
    {
        static void Main ()
        {
            int n1,n2,soma;

            Console.Write("Digite o primeiro valor: ");
            n1=int.Parse(Console.ReadLine());
            Console.Write("Digite o segundo Valor: ");
            n2=int.Parse(Console.ReadLine());
            soma =  n1 + n2;
            Console.WriteLine("A soma entre {0} e {1} é igual a: {2}!!!",n1,n2,soma);
        }
    }
}
using System;

namespace atapa
{
    public class Program
    {
        static void Main ()
        {
            int n1,n2,n3,soma;

            Console.Write("Digite o primeiro valor: ");
            n1=int.Parse(Console.ReadLine());
            Console.Write("Digite o segundo valor: ");
            n2=int.Parse(Console.ReadLine());
            Console.Write("Digite o terceiro valor: ");
            n3=int.Parse(Console.ReadLine());
            soma = n1+n2+n3;
            Console.Write("A soma entre os 3 valores é: {3} ",n1,n2,n3,soma);
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
            int num = 10;

            num=num<<1;

            Console.Write(num);
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
            int num = 10;

            num=num>>1;//BITWISE //ELE DOBRA A MAIS E TIRA A METADE DE UM VALOR

            Console.Write(num);
        }
    }
}
using System;

class Program
{
    enum DiasSemana{Domingo,segunda,terça,quarta,quinta,sexta,sábado};

    static void Main ()
    {
        DiasSemana ds = (DiasSemana)3;

        Console.Write(ds);
    }
}
using System;

class Program
{
    static void Main ()
    {
        int n1 = 10;
        float n2 = n1; ///Conversão implicita e segura

        Console.Write(n2);
    }
}
using System;

class Program
{
    static void Main ()
    {
        float n1 = 10.5f;
        int n2 = (int)n1;//Conversão typecast

        Console.Write(n2);
    }
}
using System;

class Program
{
    static void Main ()
    {
        int nota = 70;
        string resultado = "REPROVADO";
        

        if(nota >= 60){
            resultado = "Aprovado";
        }
        Console.Write("Resultado: {0} ",resultado);
    }
}using System;

class Program
{
    static void Main ()
    {
        int nota = 70;
        string resultado = "REPROVADO";
        

        if(nota >= 60){
            resultado = "Aprovado";
        }
        Console.Write("Resultado: {0} ",resultado);
    }
}
using System;

class Program
{
    static void Main ()
    {
        int n1,n2,n3,n4,res;
        res=n1=n2=n3=n4=0;
        string resultado = "REPROVADO";

        Console.Write("Digite a primeira nota: ");
        n1=int.Parse(Console.ReadLine());

        Console.Write("Digite a segunda nota: ");
        n2=int.Parse(Console.ReadLine());

        Console.Write("Digite a terceira nota: ");
        n3=int.Parse(Console.ReadLine());

        Console.Write("Digite a quarta nota: ");
        n4=int.Parse(Console.ReadLine());

        res=n1+n2+n3+n4;

        if(res >= 60){
            resultado = "Aprovado";
        }
        Console.Write("Resultado: {0} ",resultado);
    }
}
using System;

class Program
{
    static void Main ()
    {
        int n1,n2,n3,n4,res;
        res=n1=n2=n3=n4=0;
        string resultado = "REPROVADO";

        Console.Write("Digite a primeira nota: ");
        n1=int.Parse(Console.ReadLine());

        Console.Write("Digite a segunda nota: ");
        n2=int.Parse(Console.ReadLine());

        Console.Write("Digite a terceira nota: ");
        n3=int.Parse(Console.ReadLine());

        Console.Write("Digite a quarta nota: ");
        n4=int.Parse(Console.ReadLine());

        res=n1+n2+n3+n4;

        if(res < 40){
            resultado = "REPROVADO";
        }
        else if(res < 60){
            resultado="RECUPERAÇÃO";
        }else{
            resultado="APROVADO";
        }
        Console.Write("Resultado: {0} ",resultado);
    }
}
using System;

class Program
{
    static void Main ()
    {
        int n1,n2,n3,n4,res;
        res=n1=n2=n3=n4=0;
        string resultado = "REPROVADO";

        Console.Write("Digite a primeira nota: ");
        n1=int.Parse(Console.ReadLine());

        Console.Write("Digite a segunda nota: ");
        n2=int.Parse(Console.ReadLine());

        Console.Write("Digite a terceira nota: ");
        n3=int.Parse(Console.ReadLine());

        Console.Write("Digite a quarta nota: ");
        n4=int.Parse(Console.ReadLine());

        res=n1+n2+n3+n4;

        if(res < 40){
            resultado = "REPROVADO";
        }
        else if(res < 60){
            resultado="RECUPERAÇÃO";
        }else{
            resultado="APROVADO";
        }
        Console.Write("NOTA {0}  Resultado: {1} ",res,resultado);
    }
}
using System;

namespace program
{
    public class Program
    {
        static void Main ()
        {
            int nota = 0;
            string resultado;

            Console.WriteLine("Digite a nota: ");
            nota=int.Parse(Console.ReadLine());
            if(nota >= 60){
                resultado = "aprovado";
            }
            else{
                resultado = "REPROVADO";
            }
            Console.WriteLine("VC FOI {1} ",resultado);
        }
    }
}