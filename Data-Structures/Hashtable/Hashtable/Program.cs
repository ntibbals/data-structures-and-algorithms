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

            Console.WriteLine(hash.Hash("Nate"));
            Console.WriteLine(hash.Hash("Nate1"));

            hash.Add("Nate", "Tibbss");

            hash.Add("Nate1", "Switchup");

            Console.WriteLine(hash.Get("FG"));

            //Console.WriteLine(hash.Contains("Mike"));

            //Console.WriteLine(hash.Contains("Paul"));
            Console.WriteLine(hash.Contains("FC"));


        }
    }
}
