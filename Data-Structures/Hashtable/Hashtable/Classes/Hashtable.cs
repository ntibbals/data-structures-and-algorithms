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
            Console.WriteLine($"Value after multiplied by 499 {value}");
            Console.WriteLine($" buckets = {Buckets}");
            value = value % Buckets;

            return value;
        }


        public void Add(string key, object value)
        {
            NodeH newHash = new NodeH(key, value);

            int hashKey = HashFunc(key);

            if (Table[hashKey] == null)
            {
                Table[hashKey] = newHash;
            }
            else
            {
                ///Collision occurred, create new linked list on node
                NodeH temp = Table[hashKey];
                while (temp.Next != null)
                {
                    temp = temp.Next;
                }

                temp.Next = newHash;
            }

        }

        public object Get(string key)
        {
            int keyValue = HashFunc(key);
            if (Table[keyValue].Key == key)
            {

                return Table[keyValue].getValue();
            }

            else
            {
                NodeH temp = Table[keyValue];
                while (temp.Key != key || temp == null)
                {
                    temp = temp.Next;
                }
                if (temp.Key == key)
                {

                    return temp.getValue();
                }
                else
                {
                    return null;
                }
            }
        }

        public bool Contains(string key)
        {
            int keyValue = HashFunc(key);
            if (Table[keyValue].Key == key)
            {

                return true;
            }

            else
            {
                NodeH temp = Table[keyValue];
                while (temp.Key != key || temp == null)
                {
                    temp = temp.Next;
                }
                if (temp.Key == key)
                {

                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
    }
}
