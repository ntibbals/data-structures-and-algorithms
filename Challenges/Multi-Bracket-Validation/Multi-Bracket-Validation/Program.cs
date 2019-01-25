using System;
using Multi_Bracket_Validation.Classes;

namespace Multi_Bracket_Validation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            string input = "{a)(}";
            Console.WriteLine(MultiBracketValidation(input));
        }

        public static string MultiBracketValidation(string input)
        {
            char[] testArray = new char[input.Length];
            Stack stackOpen = new Stack();
            Stack stackClose = new Stack();
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
                else if (testArray[i] == '(')
                {
                    stackOpen.Push(testArray[i]);
                }
                else if (testArray[i] == '[')
                {
                    stackOpen.Push(testArray[i]);
                }
                else if (testArray[i] == '}')
                {
                    stackClose.Push(testArray[i]);
                }
                else if (testArray[i] == ')')
                {
                    stackClose.Push(testArray[i]);
                }
                else if (testArray[i] == ']')
                {
                    stackClose.Push(testArray[i]);
                }
            }
            if (stackOpen.Size != stackClose.Size)
            {
                return "size not equal, false";
            }
            while (stackOpen.Top != null || stackClose.Top != null)
            {
                if (stackOpen.Top.Value == stackClose.Top.Value)
                {
                    stackOpen.Pop();
                    stackClose.Pop();
                }
                else if (stackOpen.Top.Value != stackClose.Top.Value)
                {
                    char reference = stackOpen.Top.Value;
                    stackOpen.Pop();
                    stackOpen.Push(reference);
                }
            }
            //  else if (stack.Top.Value == '(' && stack.Top.Next.Value == ')')
            //  {
            //      return "1st for loop true";
            //  }
            //  else if (stack.Top.Value == '[' && stack.Top.Next.Value == ']')
            //  {
            //      return "1st for loop true";
            //  }
            //  else if (stack.Top.Value != testArray[i])
            //  {
            //      return "1st for loop false";
            //  }
            //  stack.Pop();
            //}
            if (stackOpen.Size == stackClose.Size)
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
