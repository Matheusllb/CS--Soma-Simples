using System;

namespace CsE1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //EXERCICIO 1
            Console.Write("Soma simples\n\nValor 1: ");
            string num1 = Console.ReadLine();
            Console.Write("Valor 2: ");
            string num2 = Console.ReadLine();

            int n1 = int.Parse(num1);
            int n2 = int.Parse(num2);
            int soma = n1 + n2;

            Console.WriteLine("\n" + soma);
            Console.WriteLine("\nFim do Programa!\n");
        }
    }
}
