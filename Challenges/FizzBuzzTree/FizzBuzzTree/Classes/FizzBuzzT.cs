using System;
using System.Collections.Generic;
using System.Text;
using Trees.Classes;

namespace FizzBuzzTree.Classes
{
    public class FizzBuzzT<T>
    {


        static BinaryTree<object> FizzBuzzTree(BinaryTree<object> bt)
        {
            Node<object> root = bt.Root;

             void Helper(Node<object> helperRoot)
            {
                if (helperRoot == null)
                {
                    return;
                }
                Helper(helperRoot.Left);
                Helper(helperRoot.Right);
                if (Convert.ToInt32(helperRoot.Value) % 15 == 0)
                {
                    helperRoot.Value = "FizzBuzz";
                }
                else if (Convert.ToInt32(helperRoot.Value) % 5 == 0)
                {
                    helperRoot.Value = "Buzz";
                }
                else if (Convert.ToInt32(helperRoot.Value) % 3 == 0)
                {
                    helperRoot.Value = "Fizz";
                }
            }

            Helper(root);
            return bt;

        }
    }
}
