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

        /// <summary>
        /// Joins two tables based on Left Join principles. If the key does not exist in left table, joined value will be null
        /// </summary>
        /// <param name="Left">Left Hash table</param>
        /// <param name="Right">right hash table</param>
        /// <returns>List of left table keys and values including any values where keys also exist in the right table</returns>
        public static List<object> LeftJoin(Hashtable Left, Hashtable Right)
        {
            List<object> result = new List<object>();
            for (int i = 0; i < Left.Table.Length; i++)
            {
                if (Left.Table[i] != null)
                {
                    NodeH temp = Left.Table[i];
                    while (temp != null)
                    {
                        List<object> listi = new List<object>();

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
                        temp = temp.Next;
                        result.Add(listi);

                    }
                }                
            }
            return result;
        }
    }
}
