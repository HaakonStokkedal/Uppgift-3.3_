using System;

namespace Uppgift_3._3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hur länge vill du hyra bilen? (skriv i hela timmar)");
            int timmar = int.Parse(Console.ReadLine());

            int pris = timmar * 80;

            if (pris > 950)
                Console.WriteLine("Det kommer att kosta 950kr");
            else
                Console.WriteLine($"Det kommer att kosta {pris}kr.");

            Console.ReadKey();
        }
    }
}