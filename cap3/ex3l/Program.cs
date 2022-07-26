using System;

namespace ex3l
{
    class Program
    {
        static void Main(string[] args)
        {
            double real, dolar, cotacao;

            Console.WriteLine("informe a quantidade de reais: ");
            real = double.Parse(Console.ReadLine());
            Console.WriteLine("Informe a cotacao do dolar: ");
            cotacao = double.Parse(Console.ReadLine());

            dolar = real / cotacao;

            Console.WriteLine("O valor em dolar é: " + dolar);
        }
    }
}
