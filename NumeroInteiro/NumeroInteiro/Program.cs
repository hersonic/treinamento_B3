using System;

namespace NumeroInteiro
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero;
            int num;
            int cont;

            num = 10;
            cont = 0;

            Console.WriteLine("Digite qualquer numero: ");
            numero = int.Parse(Console.ReadLine());

            while (cont < numero)
            {
                Console.WriteLine(num);

            }

            
        }
    }
}
