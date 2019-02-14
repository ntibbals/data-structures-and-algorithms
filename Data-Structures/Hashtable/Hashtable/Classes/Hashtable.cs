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


        public void Add(string key, object value)
        {
            NodeH newHash = new NodeH(key, value);

            int hashKey = HashFunc(key);

            if(Table[hashKey] == null)
            {
                Table[hashKey] = newHash;
            }
            else
            {
                NodeH temp = Table[hashKey];
                while (temp.Next != null)
                {
                    temp = temp.Next;
                }

                temp.Next = newHash;
            }

        }

        public object GetKey(string key)
        {
            int keyValue = HashFunc(key);
            int hash = (keyValue % Buckets);
            while(Table[hash] != null && Table[hash].Key != key)
            {
                hash = (hash + 1) % Buckets;
            }

            if (Table[hash] == null)
            {
                ;
                return "Didn't find anything";
            }

            else
            {
                Console.WriteLine($"Found. Returning {Table[hash].getValue()}");
                return Table[hash].getValue();
            }
        }

        public bool Contains(string key)
        {
            int keyValue = HashFunc(key);
            int hash = (keyValue % Buckets);

            while(Table[hash] != null && Table[hash].Key != key)
            {
                hash = (hash + 1) % Buckets;
            }

            if(Table[hash] == null)
            {
                return false;
            }

            else
            {
                return true;
            }
        }




    }
}
