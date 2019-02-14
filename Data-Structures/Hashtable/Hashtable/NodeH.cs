using System;
using System.Collections.Generic;
using System.Text;

namespace Hashtable
{
    public class NodeH
    {

        public int Key { get; set; }

        public object Value { get; set; }

        public NodeH Next { get; set; }

        public NodeH (int key, object value)
        {
            Key = key;
            Value = value;
            Next = null;
        }

        public int getKey()
        {
            return Key;
        }

        public object getValue()
        {
            return Value;
        }
    }
}
