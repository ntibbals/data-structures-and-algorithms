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

            QueueWithStacks();
            Console.ReadLine();

        }

        static void QueueWithStacks()
        {
            PseudoQueue psuedo = new PseudoQueue();
            psuedo.Enqueue1(10);
            psuedo.Enqueue1(15);
            psuedo.Enqueue1(20);
            psuedo.Enqueue1(25);
            psuedo.Dequeue1();
        }

    }
}
