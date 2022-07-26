using System;

namespace ex3i
{
    class Program
    {
        static void Main(string[] args)
        {
            double numero;
            Console.WriteLine("Informe o numero: ");
            numero = double.Parse(Console.ReadLine());

            numero = Math.Pow(numero, 2);

            Console.WriteLine("O numero ao quadrado é: " + numero);
        }
    }
}