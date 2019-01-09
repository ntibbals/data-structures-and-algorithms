using System;

namespace Array_Shift
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int[] array = { 1, 2, 3, 4 };
            int[] solution = (InsertShiftArray(array, 5));
            Console.ReadLine();
        }

        static int [] InsertShiftArray(int[] array, int arg)
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
