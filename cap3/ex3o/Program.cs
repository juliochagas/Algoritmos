using System;

namespace ex3o 
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c, d, s, p;

            Console.WriteLine("Informe o valor de A: ");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Informe o valor de B: ");
            b = int.Parse(Console.ReadLine());
            Console.WriteLine("Informe o valor de C: ");
            c = int.Parse(Console.ReadLine());
            Console.WriteLine("Informe o valor de D: ");
            d = int.Parse(Console.ReadLine());

            p = a * c;
            s = b + d;

            Console.WriteLine("O produto do dos valos de a e c é: " + p);
            Console.WriteLine("A soma dos valores de b e d é: " + s);
        }
    }
}