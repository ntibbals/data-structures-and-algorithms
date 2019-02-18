using System;

namespace Insertion_Sort
{
    public class Program
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
            Console.WriteLine();
            int[] sort2Array = new int[] { 9, 5, 4, 2, 1 };
            int[] sorted2 = InsertionSort(sort2Array);
            for (int i = 0; i < sorted2.Length; i++)
            {
                Console.Write($" {sorted2[i]} ,");
            }
            Console.ReadLine();



        }

        /// <summary>
        /// Sorts given array in ascending order
        /// </summary>
        /// <param name="array">array to sort</param>
        /// <returns>sorted array</returns>
        public static int[] InsertionSort(int[] array)
        {
            for (int i = 1; i < array.Length; i++)
            {
                Console.WriteLine($"Iteration {i} at {array[i]}");
                int x = i - 1;
                int temp = array[i];
                Console.WriteLine($"Temp is {temp}");

                while ( x >= 0 && temp < array[x] )
                {
                    array[x + 1] = array[x];
                    x = x - 1;
                    Console.WriteLine($"X is {x}");

                }
                array[x + 1] = temp;
            }
            return array;
        }
    }
}
