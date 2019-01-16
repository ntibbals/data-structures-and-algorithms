using System;
using LinkedList.Classes;

namespace Ll_kth_from_end
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int num = 3;
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
            myList.Current = myList.Head;
            Console.WriteLine($"k value: {k}");
            Console.WriteLine($"K value from end: {myList.FindKthFromEnd(k)}");
            Console.ReadLine();

        }

        /// <summary>
        /// Find the kth node from the end of a link list and return the value
        /// </summary>
        /// <param name="k">node position to return</param>
        /// <returns>kth node value from end</returns>
        public int FindKthFromEnd(LiList myList, int k)
        {
            myList.Current = myList.Head;
            int counter = 1;
            while (myList.Current.Next != null) /// interrate through linked list to get count, start at one in order to equate for positioning
            {
                myList.Current = myList.Current.Next;
                counter++;
            }
            if (k > (counter - 1))
            {
                return 0;
            }
            counter = counter - k; //set new counter eqaul to counter less k to find positioning
            myList.Current = myList.Head;
            while (counter > 1) /// interated through until counter less than one to find variable
            {
                myList.Current = myList.Current.Next;
                counter--; /// deduct from counter each iteration

            }
            return myList.Current.Value;

        }
    }
}
