using System;

namespace ex3q
{
    class Program
    {
        static void Main(string[] args)
        {
            double R,A;
            Console.WriteLine("Informe o Raio da circuferencia: ");
            R = double.Parse(Console.ReadLine());

            A = Math.PI * Math.Pow(R,2);

            Console.WriteLine("A area é: "+ A);
        }
    }
}