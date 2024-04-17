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
}