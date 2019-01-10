using System;

namespace Array_Binary_Search
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Challenge 2 Solution is: ");
            int[] array = { 5, 6, 7, 8, 9 };
            int key = 3;
            //int solution = BinarySearch(array, key);
            Console.WriteLine(BinarySearch(array, key));
            Console.ReadLine();
        }

        public static int BinarySearch( int[] array, int key)
        {
            int min = 0;
            int max = array.Length;
            while(min<max)
            {
                int mid = (max + min) / 2;
                if(key == array[mid])
                {
                    return mid;
                }
                else if(array[mid] > key)
                {
                    max = mid;
                }
                else 
                {
                    min = mid;
                }
            }
            return -1;
        }
    }
}
