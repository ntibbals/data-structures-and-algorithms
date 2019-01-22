using System;
using StacksAndQueues.Classes;


namespace StacksAndQueues
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            CreateStack();
            CreateQueue();
        }

        static void CreateStack()
        {
            Node node = new Node(10);
            Stack myStack = new Stack(node);
            Console.WriteLine($"{ myStack}");

        }

        static void CreateQueue()
        {
            Node node = new Node(7);
            Queue myQueue = new Queue(node);
            Console.WriteLine(myQueue);
        }
    }
}
