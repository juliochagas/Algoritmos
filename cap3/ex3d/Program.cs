using System;

namespace ex3d
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe o tempo de viagem: ");
            double T = double.Parse(Console.ReadLine());
            Console.WriteLine("Informe o velocidade media: ");
            double V = double.Parse(Console.ReadLine());
            double D = T * V;
            double litrosUsados = D / 12;
            Console.WriteLine("Litros usados na viagem: " + litrosUsados);
        }
    }
}