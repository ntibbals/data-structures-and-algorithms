using System;
using System.Collections.Generic;
using Hashtables.Classes;
using Trees.Classes;

namespace Tree_Intersection
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        /// <summary>
        /// Identify pairs between two binary trees
        /// </summary>
        /// <param name="treeOne">binary tree one</param>
        /// <param name="treeTwo">binary tree two</param>
        /// <returns>list of pair values between both trees</returns>
        public static List<int> TreeIntersection( BT treeOne, BT treeTwo)
        {
            List<int> values = new List<int>();
            Hashtable table = new Hashtable(100);

            Nodeb root1 = treeOne.Root;
            Nodeb root2 = treeTwo.Root;

            /// first helper method to traverse first tree adding to hash table
            void TraverseOne(Nodeb helperRoot)
            {
                if(helperRoot == null)
                {
                    return;
                }

                TraverseOne(helperRoot.Left);
                TraverseOne(helperRoot.Right);
                table.Add(helperRoot.Value.ToString(), helperRoot.Value);
            }
            TraverseOne(root1);
            ///second helper method to traverse second tree to cross reference table
            void TraverseTwo(Nodeb helperRoot)
            {
                if (helperRoot == null)
                {
                    return;
                }

                TraverseTwo(helperRoot.Left);
                TraverseTwo(helperRoot.Right);
                if(table.Contains(helperRoot.Value.ToString()))
                {
                    values.Add(helperRoot.Value);
                }

            }
            TraverseTwo(root2);        
            return values;
        }
    }
}
