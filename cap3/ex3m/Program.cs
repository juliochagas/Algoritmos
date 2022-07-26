using System;

namespace ex3m 
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c, soma;

            Console.WriteLine("Informe o valor de A: ");
            a = double.Parse(Console.ReadLine());

            Console.WriteLine("Informe o valor de B: ");
            b = double.Parse(Console.ReadLine());

            Console.WriteLine("Informe o valor de C: ");
            c = double.Parse(Console.ReadLine());

            soma = Math.Pow(a, 2) + Math.Pow(b, 2) + Math.Pow(c, 2);

            Console.WriteLine("O resultado da soma dos quadrados é: " + soma);
        }
    }
}