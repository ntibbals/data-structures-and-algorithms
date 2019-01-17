using System;
using LinkedList.Classes;
using Ll_kth_from_end;

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
            lOne.Current = lOne.Head;
            int counterOne = 0;
            int counterTwo = 0;
            while (lOne.Current.Next != null) /// interrate through linked list to get count, start at one in order to equate for positioning
            {
                lOne.Current = lOne.Current.Next;
                counterOne++;
            }
            while (lTwo.Current.Next != null) /// interrate through linked list to get count, start at one in order to equate for positioning
            {
                lTwo.Current = lTwo.Current.Next;
                counterTwo++;
            }
            int newCount = counterOne + counterTwo;
            lOne.Current = lOne.Head;
            while(newCount > 1)
            {
                if (lOne.Current.Next.Next != null)
                {
                    lOne.InsertAfter(lOne.Head.Value, lOne.Head.Value);
                    lOne.Current = lOne.Current.Next.Next;
                }
                else
                {
                    lOne.Current = lTwo.Current.Next;
                }
                newCount--;
            }
            return lOne;
        }

    }
}
