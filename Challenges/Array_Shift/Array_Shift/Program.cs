using System;

namespace Array_Shift
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Challenge 1 solution is:");
            int[] array = { 1, 2, 3, 4 };
            int num = 5;//hard coded array for manipulation
            int[] solution = (ArrayShift(array, num)); //feeding method with created array, and varible
            Console.Write("[ "); //begin display of array with initial bracket
            for (int i = 0; i < solution.Length; i++) // for loop to run through and write each index in array
            {
                Console.Write($"{String.Join(", ",solution[i])} "); //write array 
            }
            Console.Write("]"); //closing bracket for dispalyed array
            Console.ReadLine();
        }

        public static int [] ArrayShift(int[] array, int arg)
        {

            int[] newArray = new int[array.Length + 1]; //instantiate new array based on argument plues one

            int variable = array.Length / 2; //divide given array length in half
            
            
            for ( int i = 0; i < array.Length; i++) //iterate through argument
            {
                if(i < variable) //if less than half, place index in arguement, in new array at each position
                {
                    newArray[i] = array[i];
                }
                else if (i == variable) //when equal to half of array lenght, first place new variable, then add one position and insert middle variable
                {
                    newArray[i] = arg;
                    newArray[i+1] = array[i];
                }

                else // else increase array position in new array and insert element accordinlgy
                {
                    newArray[i+ 1] = array[i];
                }
            }
            return newArray;
        }
    }
}
