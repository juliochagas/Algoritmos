using System;

namespace ex3p
{
    class Program
    {
        static void Main(string[] args)
        {
            double sm, pr, ns;

            Console.WriteLine("Informe o salario mensal: ");
            sm = double.Parse(Console.ReadLine());

            Console.WriteLine("Informe o valor de reajuste em porcentagem: ");
            pr = double.Parse(Console.ReadLine());

            ns = sm + (sm * pr / 100);

            Console.WriteLine("O valor do novo salario é: " + ns);
        }
    }
}