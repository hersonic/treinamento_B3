using System;

namespace Notas
{
    class Program
    {
        static void Main(string[] args)
        {
            int nota;
            int somanota;
            int media;
            int maiornota;
            int menornota;

            maiornota = 0;
            menornota = 100;
            somanota = 0;

            for (int i = 0; i < 22; i++)
            {
                Console.WriteLine("Digite uma nota: ");
                nota = int.Parse(Console.ReadLine());
            
            somanota = somanota + nota;
            }





        }
    }
}