using System;
using System.Collections.Generic;
using System.Text;
using StacksAndQueues.Classes;

namespace fifo_animal_shelter.Classes
{
    class AnimalShelter
    {
        public string Dog { get; set; }
        public string Cat { get; set; }
        public Queue Shelter { get; set; }

        public AnimalShelter()
        {
            Shelter = new Queue();
        }
        /// <summary>
        /// Determines if animal is dog or call, will enqueue in a value accordingly.
        /// </summary>
        /// <param name="animal">animal type</param>
        public void Enqueue(string animal)
        {
            if (animal.Equals("dog"))
            {
                Shelter.Enqueue(1);
            }
            else if (animal.Equals("cat"))
            {
                Shelter.Enqueue(2);
            }
            else
            {
                Console.WriteLine("Wrong Shelter");
            }
        }

        /// <summary>
        /// Determines if front is dog or cat, and removes front when it equals pref
        /// </summary>
        /// <param name="pref">preferred animal</param>
        /// <returns>removed type</returns>
        public string Dequeue(string pref)
        {
            if (pref.Equals("dog"))
            {
                if (Shelter.Front.Value == 1)
                {
                    Node temp = Shelter.Front;
                    Shelter.Front = Shelter.Front.Next;
                    if (temp.Value == 1)
                    {
                        return "dog";
                    }
                    else
                    {
                        return "cat";
                    }
                }
                else
                {
                    while (Shelter.Front.Value != 1)
                    {
                        Node temp = Shelter.Front;
                        Shelter.Front = Shelter.Front.Next;
                        Shelter.Rear.Next = temp;
                        Shelter.Rear = temp;
                    }
                    Node temp2 = Shelter.Front;
                    Shelter.Front = Shelter.Front.Next;
                    if (temp2.Value == 1)
                    {
                        return "dog";
                    }
                    else
                    {
                        return "cat";
                    }
                }

            }
            else if (pref.Equals("cat"))
            {
                if (Shelter.Front.Value == 2)
                {
                    Node temp = Shelter.Front;
                    Shelter.Front = Shelter.Front.Next;
                    if (temp.Value == 1)
                    {
                        return "dog";
                    }
                    else
                    {
                        return "cat";
                    }
                }
                else
                {
                    while (Shelter.Front.Value != 2)
                    {
                        Node temp = Shelter.Front;
                        Shelter.Front = Shelter.Front.Next;
                        Shelter.Rear.Next = temp;
                        Shelter.Rear = temp;
                    }
                    Node temp2 = Shelter.Front;
                    Shelter.Front = Shelter.Front.Next;
                    if (temp2.Value == 1)
                    {
                        return "dog";
                    }
                    else
                    {
                        return "cat";
                    }
                }

            }
            else
            {
                return "not working";
            }
        }
    }
}
