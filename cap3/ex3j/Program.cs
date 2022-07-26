using System;

namespace ex3j
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b;

            Console.WriteLine("Informe o valor de A: ");
            a = double.Parse(Console.ReadLine());

            Console.WriteLine("Informe o valor de B: ");
            b = double.Parse(Console.ReadLine());

            Console.WriteLine("O resiltado é: " + (Math.Pow(a - b, 2)));
        }
    }
}