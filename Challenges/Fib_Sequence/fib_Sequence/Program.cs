using System;

namespace fib_Sequence
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int testNum = 2;

            Console.WriteLine(FibSquence(testNum));
            Console.ReadLine();
        }

        static int FibSquence(int num)
        {
            if( num == 2 || num == 1)
            {
                return 1;
            }
            else
            {
                return FibSquence(num - 1) + FibSquence(num - 2);
            }
        }

    }
}
