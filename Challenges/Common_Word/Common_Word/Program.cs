using Common_Word.Classes;
using System;

namespace Common_Word
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            string dict = "This is the song that never ends it goes on and my it  on on it on it friend";

            Console.WriteLine(CommonWord(dict));
            Console.ReadLine();
        }

        /// <summary>
        /// Method takes in a phrase/book and returns the most common word
        /// </summary>
        /// <param name="book">book/phrase</param>
        /// <returns></returns>
        public static string CommonWord(string book)
        {
            HashT table = new HashT(50);
            char[] delimiters = { ' ', ':', ';', '/', ',', '.' };
            string[] sArray = book.ToLower().Split(delimiters);
            string word = "No Common Word"; /// holds most common word

            int topCount = 0; ////holds count for current most common word

            for (int i = 0; i < sArray.Length; i++)
            {

                if (table.Contains(sArray[i])) /// looks for if value is in table
                {

                    int compare = table.Get(sArray[i]);
                    NodeHT temp = table.Table[i];
                    while (temp != null)
                    {
                        compare++; /// keeps track of length of linked list within collision
                        temp = temp.Next;
                    }
                    if (compare > topCount) /// compares collided value with current top count value
                    {
                        topCount = compare;
                        word = sArray[i];
                    }
                    table.Add(sArray[i], compare); /// adds value to hash table

                }
                else
                {
                    table.Add(sArray[i], 1);
                }
            }

            return word;

        }
    }
}
