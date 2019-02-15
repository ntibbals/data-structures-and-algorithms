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

            Console.WriteLine($" Index key for Seattle: {hash.Hash("Seattle")}");
            Console.WriteLine($" Adding key value pair, Seattle and Pike Market");
            hash.Add("Seattle", "Pike Market");
            Console.WriteLine(hash.Get("Seattle"));
            Console.WriteLine("Looking for key: Seattle");
            Console.WriteLine(hash.Contains("Seattle"));
            Console.ReadLine();

        }
    }
}
