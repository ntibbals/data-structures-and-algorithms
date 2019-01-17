using System;
using LinkedList.Classes;

namespace ll_merge
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            LiList listOne = new LiList();
            LiList listTwo = new LiList();
            listOne.Insert(1);
            listOne.Insert(2);
            listOne.Insert(3);

            listTwo.Insert(4);
            listTwo.Insert(5);
            listTwo.Insert(6);
            LlMerge(listOne, listTwo);
            listOne.Print();
        }

        public static LiList LlMerge(LiList lOne, LiList lTwo)
        {
            
            return lOne;
        }

    }
}
