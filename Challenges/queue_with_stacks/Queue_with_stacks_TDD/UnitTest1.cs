using System;
using Xunit;
using Queue_with_Stacks.Classes;
using StacksAndQueues.Classes;

namespace Queue_with_stacks_TDD
{
    public class UnitTest1
    {
        [Fact]
        public void InstantiationOfQueue()
        {
            Stack stack = new Stack(5);
            stack.Push(10);
            stack.Push(15);

            PseudoQueue psuedo = new PseudoQueue(stack);
            Assert.Equal(15, psuedo.Primary.Top.Value);
        }

        [Fact]
        public void EnqueuePseudoOne()
        {
            Stack stack = new Stack(5);
            stack.Push(10);
            stack.Push(15);

            PseudoQueue psuedo = new PseudoQueue(stack);
            psuedo.Enqueue1(25);
            Assert.Equal(25, psuedo.Primary.Top.Value);
        }
        [Fact]
        public void DequeuePseudoOne()
        {
            Stack stack = new Stack(5);
            stack.Push(10);
            stack.Push(15);

            PseudoQueue psuedo = new PseudoQueue(stack);
            psuedo.Dequeue1();
            Assert.Equal(10, psuedo.Primary.Top.Value);
        }
    }
}
