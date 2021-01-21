using System;

namespace deneme
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int x = 1; x <= 10; x++)
            {
                for (int i = 1; i <= 10; i++)
                {
                    Console.Write("{0}*{1}={2}\t", i, x, (i * x));
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
