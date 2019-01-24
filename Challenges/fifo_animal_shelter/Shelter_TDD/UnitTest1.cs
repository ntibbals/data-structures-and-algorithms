using System;
using Xunit;
using fifo_animal_shelter.Classes;
namespace Shelter_TDD
{
    public class UnitTest1
    {
        [Fact]
        public void EnqueueAddsDog()
        {
            ///enqueue will add dog
            AnimalShelter testShelter = new AnimalShelter();
            testShelter.Enqueue("dog");
            Assert.Equal(1, testShelter.Shelter.Front.Value);
        }

        [Fact]
        public void EnqueueAddsCat()
        {
            ///enqueue will add cat
            AnimalShelter testShelter = new AnimalShelter();
            testShelter.Enqueue("cat");
            Assert.Equal(2, testShelter.Shelter.Front.Value);
        }

        [Fact]
        public void EnqueueDoesNotAddIfNotCatOrDog()
        {
            ///enqueue will not add animal if it isn't a dog or cat
            AnimalShelter testShelter = new AnimalShelter();
            testShelter.Enqueue("rabbit");
            Assert.Null(testShelter.Shelter.Front);
        }
        [Fact]
        public void DequeueRemovesDog()
        {
            ///dequeue will remove dog from shelter
            AnimalShelter testShelter = new AnimalShelter();
            testShelter.Enqueue("dog");
            testShelter.Enqueue("cat");
            testShelter.Enqueue("dog");
            testShelter.Dequeue("dog");
            Assert.Equal(2, testShelter.Shelter.Front.Value);
        }

        [Fact]
        public void DequeueRemovesCat()
        {
            ///dequeue will remove cat from shelter
            AnimalShelter testShelter = new AnimalShelter();
            testShelter.Enqueue("dog");
            testShelter.Enqueue("cat");
            testShelter.Enqueue("dog");
            testShelter.Dequeue("cat");
            Assert.Equal(1, testShelter.Shelter.Front.Value);
        }

        [Fact]
        public void DequeueDoesNotRemoveIfNotCatOrDog()
        {
            ///dequeue will not remove animal if it isn't a dog or cat
            AnimalShelter testShelter = new AnimalShelter();
            testShelter.Enqueue("cat");
            testShelter.Enqueue("dog");
            testShelter.Enqueue("cat");
            testShelter.Dequeue("rabbit");
            Assert.Equal(2, testShelter.Shelter.Front.Value);
        }
    }
}
