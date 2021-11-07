using System;

namespace ExercicoSabado
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero1;
            int numero2;
            int substracao;

            Console.WriteLine("Digite primeiro numero:");
            numero1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite segundo numero:");
            numero2 = int.Parse(Console.ReadLine());

            substracao = numero1 - numero2;
            Console.WriteLine("O resultado de substração é: " + substracao);
        }
    }
}
