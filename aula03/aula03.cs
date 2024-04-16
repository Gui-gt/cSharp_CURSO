using System;

class aula03
{
    static void Main ()
    {

        int num1,num2, res;

        num1 = 10;
        num2 = 2;
        res = num1 * num2;


        byte n1 = 10;
        int num=0;//VARIAVEL DECLARADA
        char letra='c';
        float valor=5.3f;
        string nome="Giovana";

        var aux =nome; //se nn colocar o tipo, automaticamente ele determina o tipo

            Console.WriteLine("Valor da variavel: "+aux+ "...");
            Console.WriteLine("A multiplicação de "+ num1 +" com "+ num2 +" é igual a: " + res);
    }
}