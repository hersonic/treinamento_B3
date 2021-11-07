using System;

namespace Exercicio6
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            int b;
            int c;

            Console.WriteLine("Digite valor a: ");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite valor b: ");
            b = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite valor c: ");
            c = int.Parse(Console.ReadLine());

            if (a > b)
            {
                Console.WriteLine("O A é maior" +a);

            }
            else if (b > c)
            {
                Console.WriteLine("O B é maior" + b);
            }
            
            else  if(c > a)
            {
                Console.WriteLine("O C é maior" + c);
            }
        }
    }
}
