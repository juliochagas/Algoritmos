using System;

namespace ex3g
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe o valor da varivel A: ");
            int A = int.Parse(Console.ReadLine());
            Console.WriteLine("Informe o valor da varivel B: ");
            int B = int.Parse(Console.ReadLine());
            Console.WriteLine("Informe o valor da varivel C: ");
            int C = int.Parse(Console.ReadLine());
            Console.WriteLine("Informe o valor da varivel D: ");
            int D = int.Parse(Console.ReadLine());

            int A1,A2,A3,A4,A5,A6,M1,M2,M3,M4,M5,M6;

            A1 = A + B;
            A2 = A + C;
            A3 = A + D;
            A4 = B + C;
            A5 = B + D;
            A6 = C + D;
            M1 = A * B;
            M2 = A * C;
            M3 = A * D;
            M4 = B * C;
            M5 = B * D;
            M6 = C * D;

            Console.WriteLine(A1, A2, A3, A4, A5, A6, M1, M2, M3, M4, M5, M6);
        }
    }
}