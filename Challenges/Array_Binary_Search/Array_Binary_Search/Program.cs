using System;

namespace Array_Binary_Search
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Challenge 2 Solution is: ");
            int[] array = { 5, 6, 7, 8, 9 }; //given array for method
            int key = 3; // given search key for method
            //int solution = BinarySearch(array, key);
            Console.WriteLine(BinarySearch(array, key)); //call method with given arguments
            Console.ReadLine();
        }

        public static int BinarySearch( int[] array, int key)
        {
            int min = 0; //initialize variable to set minimum for binary search
            int max = array.Length; //instatiate a maximum for the binary search based on array length
            while(min<max) //have while loop run until max is no longer greater than min
            {
                int mid = (max + min) / 2; //initialize mid point by dividing result of max + min in half
                if(key == array[mid]) // if array at the mid is equal to key, return that index
                {
                    return mid;
                }
                else if(array[mid] > key) // if array index is greater than key, set max equal to mid to cut length
                {
                    max = mid;
                }
                else // if array index is less than key, set minimum to mid to cut length
                {
                    min = mid;
                }
            }
            return -1; // if all else is not true, key not found, return -1
        }
    }
}
