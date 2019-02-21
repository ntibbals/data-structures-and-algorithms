using System;
using Hashtables.Classes;

namespace Hashtables
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            //Hashtable hash = new Hashtable(7);

            //Console.WriteLine($" Index key for Seattle: {hash.Hash("Seattle")}");
            //Console.WriteLine($" Adding key value pair, Seattle and Pike Market");
            //hash.Add("Seattle", "Pike Market");
            //Console.WriteLine(hash.Get("Seattle"));
            //Console.WriteLine("Looking for key: Seattle");
            //Console.WriteLine(hash.Contains("Seattle"));
            Hashtable testLeft = new Hashtable(5);
            testLeft.Add("fond", "enamored");
            testLeft.Add("diligent", "employed");

            Hashtable testRight = new Hashtable(5);
            testRight.Add("fond", "averse");
            testRight.Add("flow", "jam");
            Console.WriteLine(testLeft.Contains("diligent"));
            Console.ReadLine();

        }
    }
}
