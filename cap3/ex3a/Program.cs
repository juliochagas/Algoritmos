using System;

namespace ex3a
{
    class Program
    {
        static void Main(string[] args)
        {
            double celsius, fahrenheit;
            Console.WriteLine("Digite a temperatura em graus celsius: ");
            celsius = double.Parse(Console.ReadLine());
            fahrenheit = ((9 * celsius) + 160) / 5;
            Console.WriteLine("A temperatura convertida para fahrenheit é: " + fahrenheit);
        }
    }
}