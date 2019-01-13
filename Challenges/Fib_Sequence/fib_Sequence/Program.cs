using System;

namespace fib_Sequence
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int testNum = 5;

            Console.WriteLine(FibSquence(testNum));
            Console.ReadLine();
        }

        static int FibSquence(int num)
        {
            int num1;
            int num2;
            num1 = 1;
            num2 = 1;
            if(num > num2)
            {
                while (num2 < num)
                {
                    num2 += num1;
                    num1 = num2 - num1;
                }
            }

            return num1;
        }
    }
}
