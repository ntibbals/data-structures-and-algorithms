using System;
using LinkedList.Classes;

namespace Ll_kth_from_end
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int k = 2;
            TestKValue(k, num);

            Console.ReadLine();
        }
        static void TestKValue(int k, int num)
        {
            LiList myList = new LiList();
            myList.Insert(num);
            myList.Insert(num * 2);
            myList.Insert(num * 3);
            myList.Insert(num * 4);
            myList.Print();
            Console.WriteLine($"k value: {k}");
            Console.WriteLine($"K value from end: {myList.FindKthFromEnd(k)}");
            Console.ReadLine();

        }
    }
}
