using System;
using Hashtables.Classes;

namespace Hashtables
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Hashtable hash = new Hashtable(6);

            Console.WriteLine(hash.HashFunc("Nate"));

            hash.Add("Nate", "Tibbss");

            hash.Add("Mike", "Switchup");

            Console.WriteLine(hash.GetKey("Nate"));

            Console.WriteLine(hash.Contains("Mike"));

            Console.WriteLine(hash.Contains("Paul"));


        }
    }
}
