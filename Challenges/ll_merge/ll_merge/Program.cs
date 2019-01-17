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
            listOne.InsertAfter(1 , 2);
            listOne.InsertAfter(2, 3);
            listTwo.Insert(4);
            listTwo.InsertAfter(4, 5);
            listTwo.InsertAfter(5, 6);
            listOne.Print();
            listTwo.Print();
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
            lTwo.Current = lTwo.Head;
            while (lTwo.Current.Next != null) /// interrate through linked list to get count, start at one in order to equate for positioning
            {
                lTwo.Current = lTwo.Current.Next;
                counterTwo++;
            }
            int newCount = counterOne + counterTwo;
            lOne.Current = lOne.Head;
            while(newCount > 1)
            {
                if (lOne.Current.Next != null)
                {
                    lOne.InsertAfter(lOne.Head.Value, lTwo.Current.Value);
                    lOne.Current = lOne.Current.Next;
                    //lTwo.Current = lTwo.Current.Next;
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
