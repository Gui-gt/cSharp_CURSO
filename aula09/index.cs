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