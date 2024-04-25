using System;

namespace ClasseMath
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Valor máximo: " + Math.Max(5, 10));
            Console.WriteLine("Valor mínimo: " + Math.Min(5, 10));

            Console.WriteLine("Raiz quadrada: " + Math.Sqrt(64));
            Console.WriteLine("Arredondamento: " + Math.Round(9.99));
        }
    }
}
