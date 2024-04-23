using System;

namespace cSharp_CURSO
{
    public class Program
    {
        static void Main ()
        {
            int n1,n2,soma=0;
            Console.Write("DIGITE O PRIMEIRO VALOR: ");
            n1=int.Parse(Console.ReadLine());
            Console.Write("DIGITE O SEGUNDO VALOR: ");
            n2=int.Parse(Console.ReadLine());
            soma=n1+n2;
            Console.Write("{0} + {1} é {2}. ",n1,n2,soma);
        }
    }
}