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

        public int GetKey(int key)
        {



            return key;
        }
    }
}
