using System;
using System.Collections.Generic;
using System.Text;

namespace Hashtable
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

        public object GetKey(int key)
        {
            int hash = (key % Buckets);
            while (Table[hash] != null && Table[hash].getKey() != key)
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
