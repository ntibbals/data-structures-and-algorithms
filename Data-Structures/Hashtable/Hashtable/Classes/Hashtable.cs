using System;
using System.Collections.Generic;
using System.Text;

namespace Hashtables.Classes
{
    public class Hashtable
    {
        public NodeH[] Table { get; set; }

        public int Buckets { get; set; }


        public Hashtable(int buckets)
        {
            Buckets = buckets;
            Table = new NodeH[Buckets];
        }

        public int HashFunc(string key)
        {
            int value = 0;

            for (int i = 0; i < key.Length; i++)
            {
                int cValue = key[i];
                Console.WriteLine($"char value {cValue}");
                value = cValue + value;
                Console.WriteLine($"Current value{i} is {value}");
            }

            value = value * 499;

            value = value % Buckets;

            return value;
        }
        public object GetKey(string key)
        {
            int keyValue = Convert.ToInt32(key);
            int hash = (keyValue % Buckets);
            while (Table[hash] != null && Table[hash].getKey() != keyValue)
            {
                hash = (hash + 1) % Buckets;
            }

            if (Table[hash] == null)
            {
                return -1;
            }

            else
            {
                return Table[hash].getValue();
            }

        }
    }
}
