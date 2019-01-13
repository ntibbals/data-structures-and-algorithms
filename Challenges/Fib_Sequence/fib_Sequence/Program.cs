using System;

namespace fib_Sequence
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int testNum = 8; //integer to pass into method

            Console.WriteLine(FibSeq(testNum));
            Console.ReadLine();
        }

        /// <summary>
        /// Fibonacci Sequence method to return nth integer of given argument
        /// </summary>
        /// <param name="num">integer to compute</param>
        /// <returns>nth integer of argument</returns>
        static int FibSeq (int num)
        {

            int[] fib= new int[num + 1]; /// initialize array length based on argument plus one
            fib[0] = 0;
            fib[1] = 1;

            for (int i = 2; i <= num; i++) /// for loop to iterate through array in doing the computations, returns nth integer based on position of argument
            {
                fib[i] = fib[i-1] + fib[i-2];
            }
            return fib[num];
        }
    }
}
