using System;
using LinkedList.Classes;
using Ll_kth_from_end;

namespace ll_merge
{
    public class Program
    {
        public static void Main(string[] args)
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

        /// <summary>
        /// Zip two linked lists together
        /// </summary>
        /// <param name="lOne">list one</param>
        /// <param name="lTwo">list two</param>
        /// <returns>zipped list</returns>
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
            int newCount = counterOne + counterTwo; /// length of both lists for new list
            Node C1 = lOne.Head; ///reference holder 1
            Node C2 = lTwo.Head; /// reference holder 2
   
            while(newCount > 1)
            {
      
                if (lTwo.Current != null)
                {
                    lOne.InsertAfter(C1.Value, C2.Value);
                    C1 = C1.Next.Next;
                    C2 = C2.Next;
                    lOne.Print();
                }
                else
                {
                    lOne.Append(C2.Value);
                    C2 = C2.Next;
                    lOne.Print();
                }
                newCount--;
            }
            return lOne;
        }

    }
}
