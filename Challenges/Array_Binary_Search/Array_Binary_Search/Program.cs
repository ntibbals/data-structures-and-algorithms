using System;

namespace Array_Binary_Search
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Challenge 2 Solution is: ");
            int[] array = { 1, 2, 3, 4, 5 };
            int key = 2;
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
                if(mid == key)
                {
                    return mid;
                }
                else if(mid > key)
                {
                    max = mid;
                }
                else if(mid < key)
                {
                    min = mid;
                }
                else
                {
                    return -1;
                }
            }
            return 0;
        }
    }
}
