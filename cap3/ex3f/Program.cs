using System;

namespace ex3f
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe o valor para a variavel A");
            int A = int.Parse(Console.ReadLine());

            Console.WriteLine("informe o valor para a variavel B");
            int B = int.Parse(Console.ReadLine());

            int X;
            X = A;
            A = B;
            B = X;

            Console.WriteLine("Variavel A: " + A + " variavel B: " + B);
        }
    }

}