using System;

namespace ex3k
{
    class Program
    {
        static void Main(string[] args)
        {
            double real, dolar, cotacao;

            Console.WriteLine("Informe a cotação do dolar: ");
            cotacao = double.Parse(Console.ReadLine());
            Console.WriteLine("Informe quantos dolares tem: ");
            dolar = double.Parse(Console.ReadLine());

            real = dolar * cotacao;

            Console.WriteLine("O valor em real é: " + real);
        }
    }
}