using System;
using System.Collections.Generic;
using System.Text;
using StacksAndQueues.Classes;

namespace fifo_animal_shelter.Classes
{
    class AnimalShelter
    {
        public string Type { get; set; }

        public AnimalShelter(string type)
        {
            Type = type;
        }
        public void Enqueue(string animal)
        {
            if(animal.Equals("dog") || animal.Equals("cat"))
            {
                Type = animal;
            }
        }
    }
}
