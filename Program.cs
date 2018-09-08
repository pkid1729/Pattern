using System;

namespace Pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(i);
                }
                Console.WriteLine();
            }
            Console.ReadKey();
            // Console.WriteLine("Hello World!");
            for (int k = 9; k>=1; --k)
            {
                for (int l = 1; l <= k; ++l)
                {
                    Console.Write(k);
                }
                Console.WriteLine();
            }
            Console.ReadKey();

        }
    }
}
