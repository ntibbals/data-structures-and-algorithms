using System;
using Hashtables.Classes;

namespace Hashtables
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Hashtable hash = new Hashtable(7);

            Console.WriteLine(hash.HashFunc("Nate"));
            Console.WriteLine(hash.HashFunc("Nate1"));

            hash.Add("Nate", "Tibbss");

            hash.Add("Nate1", "Switchup");

            Console.WriteLine(hash.Get("Nate1"));

            Console.WriteLine(hash.Contains("Mike"));

            Console.WriteLine(hash.Contains("Paul"));


        }
    }
}
