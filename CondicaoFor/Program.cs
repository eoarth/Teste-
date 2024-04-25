using System;

namespace CondicaoFor
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i <= 8; i++)
            {
                if (i == 4)
                {
                    continue;
                }
                Console.WriteLine(i);
            }

            //string[] carros = { "Fusca", "Brasilia", "Varianti" };

            //foreach (string y in carros)
            //{
            //    Console.WriteLine(y);
            //}
        }
    }
}
