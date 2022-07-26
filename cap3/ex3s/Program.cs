namespace ex3f
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, soma, divisao, multiplicacao, subtracao;
            
            Console.WriteLine("Informe o primeiro valor: ");
            a = double.Parse(Console.ReadLine());

            Console.WriteLine("Informe o segundo valor: ");
            b = double.Parse(Console.ReadLine());

            soma = a + b;
            subtracao = a - b;
            divisao = a/b;
            multiplicacao = a * b;
            
            Console.WriteLine("O valor da soma dos valores é: " + soma);
            Console.WriteLine("O valor da subtracao dos valores é: " + subtracao);
            Console.WriteLine("O valor da divisao dos valores é: " + divisao);
            Console.WriteLine("O valor da multiplicacao dos valores é: " + multiplicacao);

            
        }
    }
}