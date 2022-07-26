using System;

namespace ex3c
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe o raio:");
            double R = double.Parse(Console.ReadLine());
            Console.WriteLine("Informe a altura: ");
            double A = double.Parse(Console.ReadLine());

            double V = 3.14159 * Math.Pow(R, 2) * A;

            Console.WriteLine("O volume é: " + V);
        }
    }
}