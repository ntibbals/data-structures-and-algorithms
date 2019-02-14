using System;
using System.Collections.Generic;
using System.Text;

namespace Hashtable
{
    public class NodeH
    {

        public string Key { get; set; }

        public object Value { get; set; }

        public NodeH Next { get; set; }

        public NodeH (string key, object value)
        {
            Key = key;
            Value = value;
            Next = null;
        }

        public int getKey()
        {
            return Convert.ToInt32(Key);
        }

        public object getValue()
        {
            return Value;
        }
    }
}
