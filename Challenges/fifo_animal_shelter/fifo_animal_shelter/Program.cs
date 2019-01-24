using System;
using fifo_animal_shelter.Classes;

namespace fifo_animal_shelter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            FIFOAnimalShelter();
        }

        static void FIFOAnimalShelter()
        {
            AnimalShelter newShelter = new AnimalShelter();
            newShelter.Enqueue("dog");
            newShelter.Enqueue("cat");
            newShelter.Enqueue("mouse");
            Console.WriteLine(newShelter.Dequeue("cat"));
        }
    }
}
