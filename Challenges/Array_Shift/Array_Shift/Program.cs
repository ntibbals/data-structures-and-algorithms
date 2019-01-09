using System;

namespace Array_Shift
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Challenge 1 solution is:");
            int[] array = { 1, 2, 3, 4 };
            int[] solution = (ArrayShift(array, 5));
            Console.Write("[ ");
            for (int i = 0; i < solution.Length; i++)
            {
                Console.Write($"{String.Join(", ",solution[i])} ");
            }
            Console.Write("]");
            Console.ReadLine();
        }

        static int [] ArrayShift(int[] array, int arg)
        {
            int[] newArray = new int[array.Length + 1];
            int variable = array.Length / 2;
            for( int i = 0; i < array.Length; i++)
            {
                if(array[i] == variable)
                {
                    newArray[i] = arg;
                }
                else
                {
                    newArray[i] = array[i];
                }
            }
            return newArray;
        }
    }
}
