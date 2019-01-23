using System;
using StacksAndQueues.Classes;
using Queue_with_Stacks.Classes;

namespace Queue_with_Stacks
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Stack stack = new Stack(5);
            stack.Push(10);
            stack.Push(15);

            PseudoQueue psuedo = new PseudoQueue(stack);
            Console.WriteLine($"{psuedo.Primary.Peek()}");
        }
    }
}
