using Hashtables.Classes;
using System;
using System.Collections.Generic;

namespace Left_Join
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Hashtable testLeft = new Hashtable(5);
            testLeft.Add("fond", "enamored");
            testLeft.Add("diligent", "employed");

            Hashtable testRight = new Hashtable(5);
            testRight.Add("fond", "averse");
            testRight.Add("flow", "jam");

            LeftJoin(testLeft, testRight);
        }

        public static List<object> LeftJoin(Hashtable Left, Hashtable Right)
        {
            List<object> result = new List<object>();
            for (int i = 0; i < Left.Table.Length; i++)
            {
                if (Left.Table[i] != null)
                {
                    List<object> listi = new List<object>();
                    NodeH temp = Left.Table[i];
                    if (Right.Contains(temp.Key))
                    {
                        listi.Add(temp.Key);
                        listi.Add(temp.Value.ToString());
                        listi.Add(Right.Get(temp.Key));
                    }
                    else
                    {
                        listi.Add(temp.Key);
                        listi.Add(temp.Value.ToString());
                        listi.Add("NULL");
                    }

                    result.Add(listi);
                }                
            }
            return result;
        }
    }
}
