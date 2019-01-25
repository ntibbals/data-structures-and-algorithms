using System;
using Multi_Bracket_Validation.Classes;

namespace Multi_Bracket_Validation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            string input = "{a{()[]}";
            Console.WriteLine(MultiBracketValidation(input));
        }

        public static string MultiBracketValidation(string input)
        {
            char[] testArray = new char[input.Length]; ///char array for string
            Stack stackOpen = new Stack(); ///stack holds opening brackets
            for (int i = 0; i < testArray.Length; i++)
            {
                testArray[i] = input[i];
            }

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
                        return "for loop one false { }";
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
                        return "for loop one false [ ]";
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
                        return "for loop one false ( )";
                    }
                }
            }
            if (stackOpen.Size == 0)
            {
                return "2 for loop true";
            }
            else
            {
                return "2 for loop false";
            }
        }

    }
}
        
    
