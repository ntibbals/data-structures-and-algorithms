using System;
using System.Collections.Generic;
using System.Text;


namespace LinkedList.Classes
{
    public class LinkedList
    {
        public Node Head { get; set; }
        public Node Current { get; set; }


        public void Insert(int value)
        {
            Node node1 = new Node(value);
            node1.Next = Head;
            Head = node1;
        }
    }
}
