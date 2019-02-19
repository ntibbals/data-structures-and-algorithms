using Hashtables.Classes;
using System;

namespace Repeated_Word
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            string coco = "hot chocolate is hot toddy";
            Console.WriteLine(RepeatedWord(coco));
        }

        /// <summary>
        /// Method that identifies first repeated word in string
        /// </summary>
        /// <param name="phrase">lengthy string</param>
        /// <returns>first repeated word or the entire string if none is found</returns>
        public static string RepeatedWord(string phrase)
        {
            string[] array = phrase.ToLower().Split(" "); /// split into array

            Hashtable words = new Hashtable(100); ///instantiate new hash table to hold values
            for (int i = 0; i < array.Length; i++)
            {
                if(words.Contains(array[i]))
                {
                    return array[i]; /// return value if contained in hash table
                }
                else
                {
                    words.Add(array[i], array[i]); /// else add index value as key and value
                }
            }
            return phrase; /// if no repeated word is found, return phrase
        }


    }
}
