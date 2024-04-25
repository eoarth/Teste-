using System;

namespace While
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            do
            {                
                i++;
                if (i == 3)
                {
                    continue;
                }
                Console.WriteLine(i);
            }
            while (i <= 10);
        }
    }
}
