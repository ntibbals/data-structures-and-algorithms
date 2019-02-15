using System;

namespace Insertion_Sort
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int[] sortArray = new int[] { 1, 9, 5, 4, 2 };
            int[] sorted = InsertionSort(sortArray);
            for (int i = 0; i < sorted.Length; i++)
            {
                Console.Write($" {sorted[i]} ,");
            }
            Console.ReadLine();

        }

        public static int[] InsertionSort(int[] array)
        {
            for (int i = 1; i < array.Length; i++)
            {
                int x = i - 1;
                int temp = array[i];
                while( x >= 0 && temp < array[x] )
                {
                    array[x + 1] = array[x];
                    x = x - 1;
                }
                array[x + 1] = temp;
            }
            return array;
        }
    }
}
