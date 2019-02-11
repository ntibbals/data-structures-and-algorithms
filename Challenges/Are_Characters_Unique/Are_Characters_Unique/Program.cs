using System;

namespace Are_Characters_Unique
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            string inpu = "abcadef";
            Console.WriteLine(AreCharactersUnique(inpu));
        }

        public static bool AreCharactersUnique (string input)
        {

            string[] array = new string [input.Length];

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = input[i].ToString();
            }
            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = i+ 1; j < array.Length - 1; j++)
                {
                    Console.WriteLine($"{array[i]} and {array[j + 1]}");
                    if (array[i] == array[j + 1])
                    {
                        return false;
                    }
                }
            }
            return true;

        }
    }
}
