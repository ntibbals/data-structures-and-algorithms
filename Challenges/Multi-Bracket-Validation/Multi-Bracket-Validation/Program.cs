using System;
using Multi_Bracket_Validation.Classes;

namespace Multi_Bracket_Validation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            string input = "{{fa}";
            MultiBracketValidation(input);
        }

        public static bool MultiBracketValidation(string input)
        {
            char[] testArray = new char[input.Length];
            Stack stack = new Stack();
            for (int i = 0; i < testArray.Length; i++)
            {
                testArray[i] = input[i];
            }

            for (int i = 0; i < testArray.Length; i++)
            {
                if(testArray[i] == '{')
                {
                    stack.Push(testArray[i]);
                }
                else if (testArray[i] == '(')
                {
                    stack.Push(testArray[i]);
                }
                else if (testArray[i] == '[')
                {
                    stack.Push(testArray[i]);
                }

            }

            return true;
        }
    }
}
