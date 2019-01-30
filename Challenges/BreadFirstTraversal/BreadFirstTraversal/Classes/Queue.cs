using System;
using System.Collections.Generic;
using System.Text;
using Trees.Classes;

namespace BreadFirstTraversal.Classes
{
    class Queue
    {
        /// <summary>
        /// Set property for queue of Front(top)
        /// </summary>
        public Nodeb Front { get; set; } = null;
        /// <summary>
        /// Set property for queue of Rear(end)
        /// </summary>
        public Nodeb Rear { get; set; } = null;
        /// <summary>
        /// Set counter variable for queue
        /// </summary>
        public int Size = 0;
        /// <summary>
        /// Instantiates empty queue
        /// </summary>
        public Queue()
        {

        }
        /// <summary>
        /// Instantiates queue with node value
        /// </summary>
        /// <param name="node">node</param>
        public Queue(Nodeb node)
        {
            Front = node;
            Rear = node;
        }
        /// <summary>
        /// Adds a node/value to queue
        /// </summary>
        /// <param name="value">integer value</param>
        public void Enqueue(int value)
        {
            if (Front == null)
            {
                Nodeb newNode = new Nodeb(value);
                Front = newNode;
                Rear = newNode;
                Size++;
            }
            else
            {
                Nodeb node = new Nodeb(value);
                Rear.Next = node;
                Rear = node;
                Size++;
            }
        }
        /// <summary>
        /// Removes a node value from queue
        /// </summary>
        /// <returns>temp node value</returns>
        public Nodeb Dequeue()
        {
            try
            {
                Nodeb temp = Front;
                Front = Front.Next;
                temp.Next = null;
                Size--;
                return temp;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return null;
        }
        /// <summary>
        /// Looks at the front of the queue
        /// </summary>
        /// <returns>front node value</returns>
        public Nodeb Peek()
        {
            return Front;
        }
    }
}
