using System;

namespace exercicio5
{
    class Program
    {
        static void Main(string[] args)
        {
            int meses;
            int dias;
            int anos;

            Console.WriteLine("digite sua idade em dias:");
            dias = int.Parse(Console.ReadLine());

            anos = dias / 365;
            meses = dias / 30;

            Console.WriteLine("Idade é: " + anos + "Anos " + meses + "Dias");


        }
    }
}
