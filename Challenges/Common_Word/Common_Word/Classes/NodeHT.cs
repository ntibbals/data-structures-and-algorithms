using System;
using System.Collections.Generic;
using System.Text;

namespace Common_Word.Classes
{
    class NodeHT
    {
        public string Key { get; set; }

        public int Value { get; set; }

        public NodeHT Next { get; set; }

        public NodeHT(string key, int value)
        {
            Key = key;
            Value = value;
            Next = null;
        }

        public int getKey()
        {
            return Convert.ToInt32(Key);
        }

        public int getValue()
        {
            return Value;
        }
    }
}
