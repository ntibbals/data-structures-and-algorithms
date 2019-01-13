using System;

namespace fib_Sequence
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int testNum = 8;

            Console.WriteLine(FibSeq(testNum));
            Console.ReadLine();
        }

        static int FibSeq (int num)
        {
            int[] fib= new int[num + 1];
            fib[0] = 0;
            fib[1] = 1;

            for (int i = 2; i <= num; i++)
            {
                fib[i] = fib[i-1] + fib[i-2];
            }
            return fib[num];
        }
    }
}
