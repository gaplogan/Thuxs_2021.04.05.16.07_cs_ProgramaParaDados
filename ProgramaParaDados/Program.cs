using System;

namespace ProgramaParaDados
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c, d;
            
            a = 12;
            b = 16;
            c = 10;
            d = 17;

            Console.WriteLine($"Dado 1: {a}");
            Console.WriteLine($"Dado 2: {b}");
            Console.WriteLine($"Dado 3: {c}");
            Console.WriteLine($"Dado 4: {d}");
            Console.WriteLine($"Dado final: {a + b * c / d}");
        }
    }
}
