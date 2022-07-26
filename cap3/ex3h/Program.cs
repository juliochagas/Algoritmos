using System;

namespace ex3h
{
    class Program
    {
        static void Main(String[] args)
        {
            int volume, comprimento, largura, altura;

            Console.WriteLine("Informe o comprimento");
            comprimento = int.Parse(Console.ReadLine());

            Console.WriteLine("Informe a largura");
            largura = int.Parse(Console.ReadLine());

            Console.WriteLine("informe a altura");
            altura = int.Parse(Console.ReadLine());

            volume = comprimento * largura * altura;

            Console.WriteLine("O volume é: " + volume);
        }
    }
}