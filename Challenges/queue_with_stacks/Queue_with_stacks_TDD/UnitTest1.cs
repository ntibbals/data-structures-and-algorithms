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
            ///Instantiation of stack
            Stack stack = new Stack(5);
            stack.Push(10);
            stack.Push(15);
            PseudoQueue psuedo = new PseudoQueue();
            Assert.Null(psuedo.Primary.Top);
        }

        [Fact]
        public void EnqueuePseudoOnEmptyStack()
        {
            ///Testing that enqueue works on empty stack
            PseudoQueue psuedo = new PseudoQueue();
            psuedo.Enqueue1(10);
            Assert.Equal(10, psuedo.Primary.Top.Value);
        }
        [Fact]
        public void EnqueuePseudoWithNegativeNode()
        {
            /// Testing input of negative integer
            PseudoQueue psuedo = new PseudoQueue();
            psuedo.Enqueue1(-10);
            Assert.Equal(-10, psuedo.Primary.Top.Value);
        }
        [Fact]
        public void EnqueuePseudoWithThreeNodes()
        {
            /// testing that multiple enqueues can be used in succession
            PseudoQueue psuedo = new PseudoQueue();
            psuedo.Enqueue1(10);
            psuedo.Enqueue1(15);
            psuedo.Enqueue1(25);
            Assert.Equal(25, psuedo.Primary.Top.Value);
        }
        [Fact]
        public void DequeuePseudoOne()
        {
            ///testing single dequeue instance
            PseudoQueue psuedo = new PseudoQueue();
            psuedo.Enqueue1(10);
            psuedo.Enqueue1(15);
            psuedo.Dequeue1();
            Assert.Equal(15, psuedo.Primary.Top.Value);
        }
        [Fact]
        public void DequeuePseudoQueueOnFirstIn()
        {
            ///testing that dequeue removes first node in
            PseudoQueue psuedo = new PseudoQueue();
            psuedo.Enqueue1(10);
            psuedo.Enqueue1(15);
            psuedo.Enqueue1(20);
            psuedo.Enqueue1(25);
            psuedo.Dequeue1();
            Assert.Equal(15, psuedo.Primary.Top.Value);
        }
        [Fact]
        public void DequeueOnOneNodeStack()
        {
            PseudoQueue psuedo = new PseudoQueue();
            psuedo.Enqueue1(10);
            Assert.Equal(10, psuedo.Dequeue1().Value);
        }

    }
}
