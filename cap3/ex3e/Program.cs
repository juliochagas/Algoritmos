using System;
namespace ex3e
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe o valor do bem: ");
            double VALOR = double.Parse(Console.ReadLine());
            Console.WriteLine("Informe a quantidade de parcelas: ");
            double TEMPO = double.Parse(Console.ReadLine());
            Console.WriteLine("Informe a taxa: ");
            double TAXA = double.Parse(Console.ReadLine());
            double PRESTACAO = VALOR + (VALOR * (TAXA / 100) * TEMPO);
            Console.WriteLine("O a prestação é: " + PRESTACAO);
        }
    }
}