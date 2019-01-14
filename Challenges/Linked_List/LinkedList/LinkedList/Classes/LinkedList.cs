using System;
using System.Collections.Generic;
using System.Text;


namespace LinkedList.Classes
{
    public class LiList
    {
        public Node Head { get; set; }
        public Node Current { get; set; }


        public void Insert(int value)
        {
            Node node1 = new Node(value);
            node1.Next = Head;
            Head = node1;
        }

        public bool Includes(int value)
        {
            Current = Head;
            while(Current.Next != null)
            {
                if(Current.Value == value)
                {
                    return true;
                }
                Current = Current.Next;
            }
            if(Current.Value == value)
            {
                return true;
            }
            return false;
        }
    }
}
