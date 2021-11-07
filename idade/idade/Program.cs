using System;

namespace idade
{
    class Program
    {
        static void Main(string[] args)
        {
            int idade;
            int meses = 12;
            int dias = 365;

            Console.WriteLine("Coloque sua idade: ");
            idade = int.Parse(Console.ReadLine());

            idade = meses * dias;

            Console.WriteLine("Idade é: " + idade + " em dias");
        }

    }
}
