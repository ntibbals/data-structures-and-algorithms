using System;
using System.Collections.Generic;
using System.Text;

namespace Common_Word.Classes
{
    class HashT
    {
        public NodeHT[] Table { get; set; }

        public int Buckets { get; set; }


        public HashT(int buckets)
        {
            Buckets = buckets;
            Table = new NodeHT[Buckets];
        }

        /// <summary>
        /// Hash function to create key
        /// </summary>
        /// <param name="key">string key</param>
        /// <returns>integer key index in hash table</returns>
        public int Hash(string key)
        {
            int value = 0;

            for (int i = 0; i < key.Length; i++)
            {
                int cValue = key[i];
                value = cValue + value;
            }


            value = value * 499;
            value = value % Buckets;

            return value;
        }

        /// <summary>
        /// Adds key value pairs to hash table
        /// </summary>
        /// <param name="key">key to add</param>
        /// <param name="value">value to retrieve</param>
        public void Add(string key, int value)
        {
            NodeHT newHash = new NodeHT(key, value);

            int hashKey = Hash(key);

            if (Table[hashKey] == null)
            {
                Table[hashKey] = newHash;
            }
            else
            {
                ///Collision occurred, create new linked list on node
                NodeHT temp = Table[hashKey];
                while (temp.Next != null)
                {
                    temp = temp.Next;
                }

                temp.Next = newHash;
            }

        }

        /// <summary>
        /// Retrieves value from hash table with given key
        /// </summary>
        /// <param name="key">key</param>
        /// <returns>value </returns>
        public int Get(string key)
        {
            int keyValue = Hash(key);
            if (Table[keyValue] == null)
            {

                return 0;
            }

            else if (Table[keyValue].Key == key)
            {

                return Table[keyValue].getValue();
            }
            else
            {
                NodeHT temp = Table[keyValue];
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
                    return 0;
                }
            }
        }

        /// <summary>
        /// Chechks to determine if key exists
        /// </summary>
        /// <param name="key">key </param>
        /// <returns>true/false</returns>
        public bool Contains(string key)
        {
            int keyValue = Hash(key);
            if (Table[keyValue] == null)
            {

                return false;
            }

            else if (Table[keyValue].Key == key)
            {

                return true;
            }
            else
            {
                NodeHT temp = Table[keyValue];
                while (temp.Key != key && temp.Next != null)
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
