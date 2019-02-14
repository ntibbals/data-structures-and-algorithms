using System;
using Hashtables.Classes;

namespace Hashtables
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Hashtable hash = new Hashtable(3);

            Console.WriteLine(hash.HashFunc("Nate"));

            hash.Add("Nate", "Tibbss");

            hash.Add("Nate", "Switchup");

        }
    }
}
