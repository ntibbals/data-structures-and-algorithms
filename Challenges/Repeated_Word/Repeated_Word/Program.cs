﻿using Hashtables.Classes;
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

        public static string RepeatedWord(string phrase)
        {
            string[] array = phrase.ToLower().Split(" ");

            Hashtable words = new Hashtable(100);
            for (int i = 0; i < array.Length; i++)
            {
                if(words.Contains(array[i]))
                {
                    return array[i];
                }
                else
                {
                    words.Add(array[i], array[i]);
                }
            }
            return phrase;
        }


    }
}
