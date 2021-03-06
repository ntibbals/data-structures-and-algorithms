﻿using System;
using Multi_Bracket_Validation.Classes;

namespace Multi_Bracket_Validation
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            string input = "{a{(f)[d]}";
            Console.WriteLine($"Testing {input}");
            Console.WriteLine(MultiBracketValidation(input));
            string input2 = "{a{f}(d)[e]}";
            Console.WriteLine($"Testing {input2}");
            Console.WriteLine(MultiBracketValidation(input2));
            Console.ReadLine();
        }

        /// <summary>
        /// Takes in a string and validates that the correct brackets are in place using stacks
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static bool MultiBracketValidation(string input)
        {
            char[] testArray = new char[input.Length]; ///char array for string
            Stack stackOpen = new Stack(); ///stack holds opening brackets
            for (int i = 0; i < testArray.Length; i++)
            {
                testArray[i] = input[i];
            }

            /// for loop pushes opening brackets into stack and then cross references char array with stack to pop matches accordingly
            for (int i = 0; i < testArray.Length; i++)
            {
                if (testArray[i] == '{')
                {
                    stackOpen.Push(testArray[i]);
                }
                if (testArray[i] == '(')
                {
                    stackOpen.Push(testArray[i]);
                }
                if (testArray[i] == '[')
                {
                    stackOpen.Push(testArray[i]);
                }
                if (testArray[i] == '}')
                {
                    if (stackOpen.Top != null && stackOpen.Top.Value == '{')
                    {
                        stackOpen.Pop();
                    }
                    else
                    {
                        return false;
                    }
                }
                if (testArray[i] == ']')
                {
                    if (stackOpen.Top != null && stackOpen.Top.Value == '[')
                    {
                        stackOpen.Pop();
                    }
                    else
                    {
                        return false;
                    }
                }
                if (testArray[i] == ')')
                {
                    if (stackOpen.Top != null && stackOpen.Top.Value == '(')
                    {
                        stackOpen.Pop();
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            if (stackOpen.Size == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
        
    
