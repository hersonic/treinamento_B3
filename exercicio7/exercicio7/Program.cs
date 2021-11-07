using System;

namespace exercicio7
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            int b;
            int c;

            Console.WriteLine("Escreva numero 1: ");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Escreva numero 2: ");
            b = int.Parse(Console.ReadLine());
            Console.WriteLine("Escreva numero 3: ");
            c = int.Parse(Console.ReadLine());

            if (a > b && b > c){
                   Console.WriteLine("A ordem crescente é:" + a + b + c);
            }

            else if (b > a && a > c){
                Console.WriteLine("A ordem crescente é:" + b + a + c);
            }

            else if (c > a && a > b)
            {
                Console.WriteLine("A ordem crescente é:" + c + a + b);
            }
                

        }
    }
}
