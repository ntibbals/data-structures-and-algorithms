using System;
using System.Collections.Generic;
using System.Text;

namespace Hashtable
{
    class Hashtable
    {
        public struct Point
        {
            private int a;
            private int b;

            public Point(int a, int b)
            {
                this.a = a;
                this.b = b;
            }

            public override bool Equals(object obj)
            {
                if (!(obj is Point)) return false;
                Point point = (Point)obj;
                return a == point.a & b == point.b;
            }

            public override int GetHashCode()
            {
                return ShiftAndWrap(a.GetHashCode(), 2) ^ b.GetHashCode();
            }

            private int ShiftAndWrap(int value, int positions)
            {
                positions = positions & 0x1F; // represents 32 bit integer

                uint num = BitConverter.ToUInt32(BitConverter.GetBytes(value), 0);
                uint wrapped = num >> (32 - positions);

                return BitConverter.ToInt32(BitConverter.GetBytes((num << positions) | wrapped), 0);
            }
        }

    }
}
