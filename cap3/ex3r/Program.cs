using System;

namespace ex3r
{
    class Program
    {
        static void Main(string[] args)
        {
            double A, B, C, NULO, BRANCO, TOTALELEITORES, VOTOSVALIDOS;

            Console.WriteLine("Informe os votos do candidato A: ");
            A = double.Parse(Console.ReadLine());

            Console.WriteLine("Informe os votos do candidato B: ");
            B = double.Parse(Console.ReadLine());

            Console.WriteLine("Informe os votos do candidato C: ");
            C = double.Parse(Console.ReadLine());

            Console.WriteLine("Informe o total de votos nulos: ");
            NULO = double.Parse(Console.ReadLine());

            Console.WriteLine("Informe o total de votos em brancos: ");
            BRANCO = double.Parse(Console.ReadLine());

            TOTALELEITORES = A + B + C + BRANCO + NULO;
            VOTOSVALIDOS = A + B + C;
            Console.WriteLine("Os total de eleitores é: " + TOTALELEITORES);

            Console.WriteLine("Percentual de votos validos: " + (VOTOSVALIDOS/TOTALELEITORES)*100);

            Console.WriteLine("O percentual de votos validos do candidato A: " + ((A/TOTALELEITORES)*100) +"%");
            Console.WriteLine("O percentual de votos validos do candidato B: " + ((B/TOTALELEITORES)*100) +"%");
            Console.WriteLine("O percentual de votos validos do candidato C: " + ((C/TOTALELEITORES)*100) +"%");

            Console.WriteLine("O percentual de votos nulos: " + (NULO/TOTALELEITORES)*100 +"%");
            Console.WriteLine("O percentual de votos brancos: " + (BRANCO/TOTALELEITORES)*100 +"%");
        }
    }
}