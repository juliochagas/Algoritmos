using System;

namespace ex3b
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal fahrenheit = int.Parse(Console.ReadLine());
            decimal celsius = ((fahrenheit - 32) * 5) / 9;
            Console.WriteLine(celsius);
        }
    }
}