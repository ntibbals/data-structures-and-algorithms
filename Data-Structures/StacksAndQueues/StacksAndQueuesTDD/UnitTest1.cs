using System;
using Xunit;
using StacksAndQueues.Classes;

namespace StacksAndQueuesTDD
{
    public class UnitTest1
    {
        [Fact]
        public void TestInstantiatesEmptyStack()
        {
            /// Test instantiation of null stack
            Stack testStack = new Stack();
            Assert.Null(testStack.Top);

        }

        [Fact]
        public void TestPushIntoEmptyStack()
        {
            /// Test that push works with an empty stack
            Stack testStack = new Stack();
            int testValue = 3;
            testStack.Push(testValue);
            int expectedValue = 3;
            Assert.Equal(expectedValue, testStack.Top.Value);
        }

        [Fact]
        public void TestPushIntoSingleStack()
        {
            /// test push into an instantiated stack with a single node
            Node testNode = new Node(3);
            int testValue2 = 7;
            Stack testStack = new Stack(testNode);
            testStack.Push(testValue2);
            Assert.Equal(testValue2, testStack.Top.Value);
        }
        [Fact]
        public void TestPushMoreThanOne()
        {
            /// test that multiple instances of push will work back to back
            Node testNode1 = new Node(5);
            int testValue1 = 10;
            int testValue2 = 15;
            Stack testStack = new Stack(testNode1);
            testStack.Push(testValue1);
            testStack.Push(testValue2);
            Assert.Equal(testValue2, testStack.Top.Value);
        }
        [Fact]
        public void TestPopOnEmptyStatck()
        {
            /// Test pop on empty stack
            Stack testStack = new Stack();
            Assert.Throws<NullReferenceException>(() => testStack.Pop());
        }
        [Fact]
        public void TestPopWillRemoveTopValue()
        {
            /// Test pop will remove top value
            Node testNode1 = new Node(5);
            int testValue1 = 10;
            int testValue2 = 15;
            Stack testStack = new Stack(testNode1);
            testStack.Push(testValue1);
            testStack.Push(testValue2);
            testStack.Pop();
            Assert.Equal(testValue1, testStack.Top.Value);
        }
        [Fact]
        public void TestPoppingMultipleValues()
        {
            /// test popping of multiple values back to back
            int testValue = 5;
            int testValue1 = 10;
            int testValue2 = 15;
            Stack testStack = new Stack();
            testStack.Push(testValue);
            testStack.Push(testValue1);
            testStack.Push(testValue2);
            testStack.Pop();
            testStack.Pop();
            Assert.Equal(5, testStack.Top.Value);
        }
        [Fact]
        public void PeekOnEmptyStack()
        {
            /// test peek on empty stack
            Stack testStack = new Stack();
            Assert.Null(testStack.Peek());
        }
        [Fact]
        public void PeekOnStackOfOne()
        {
            /// test peek on stack of One
            Node testNode = new Node(5);
            Stack testStack = new Stack(testNode);
            testStack.Push(10);
            Node expectedNode = new Node(10);
            Assert.Equal(testStack.Top, testStack.Peek());
        }
        [Fact]
        public void PeekWillNotAlterStack()
        {
            /// That that peek will not remove or alter the existing stack
            Node testNode = new Node(5);
            Stack testStack = new Stack(testNode);
            testStack.Push(10);
            testStack.Peek();
            Assert.Equal(10, testStack.Top.Value);
        }
        [Fact]
        public void TestInstantiatesEmptyQueue()
        {
            /// test instantiation of empty queue
            Queue testQueue = new Queue();
            Assert.Null(testQueue.Rear);

        }
        [Fact]
        public void TestEnqueRearValueOfQueue()
        {
            /// test enque will add value to end of queue(rear)
            Node testNode = new Node(3);
            Queue testQueue = new Queue(testNode);
            int testValue = 7;
            testQueue.Enqueue(testValue);
            int expectedValue = 7;
            Assert.Equal(expectedValue, testQueue.Rear.Value);
        }
        [Fact]
        public void TestEnqueueFrontValueOfQueue()
        {
            /// test enqueue will not alter front value of queue
            Node testNode = new Node(11);
            Queue testQueue = new Queue(testNode);
            int testValue = 13;
            testQueue.Enqueue(testValue);
            int expectedValue = 11;
            Assert.Equal(expectedValue, testQueue.Front.Value);
        }

        [Fact]
        public void TestDequeueOnEmptyQueue()
        {
            /// test dequeue on empty queue
            Queue testQueue = new Queue(); 
            Assert.Throws<NullReferenceException>(() => testQueue.Dequeue());
        }

        [Fact]
        public void TestDenqueueWillRemoveFrontOfQueue()
        {
            /// test dequeue will remove front of queue
            Node testNode = new Node(11);
            Queue testQueue = new Queue(testNode);
            int testValue = 13;
            testQueue.Enqueue(testValue);
            testQueue.Dequeue();
            int expectedValue = 13;
            Assert.Equal(expectedValue, testQueue.Rear.Value);
        }
        [Fact]
        public void TestDenqueueOnMultipleValues()
        {
            /// test dequeue on multiple values back to back
            Node testNode = new Node(5);
            Queue testQueue = new Queue(testNode);
            int testValue = 10;
            int testValue2 = 15;
            testQueue.Enqueue(testValue);
            testQueue.Enqueue(testValue2);
            testQueue.Dequeue();
            testQueue.Dequeue();
            int expectedValue = 15;
            Assert.Equal(expectedValue, testQueue.Rear.Value);
        }

        [Fact]
        public void PeekOnEmptyQueue()
        {
            /// test peek on empty queue
            Queue testQueue = new Queue();
            Assert.Null(testQueue.Peek());
        }
        [Fact]
        public void PeekOnQueueOfOne()
        {
            /// test peek on queue of one
            Node testNode = new Node(5);
            Queue testQueue = new Queue(testNode);
            int testValue = 10;
            int testValue2 = 15;
            testQueue.Enqueue(testValue);
            testQueue.Enqueue(testValue2);
            Assert.Equal(testQueue.Front, testQueue.Peek());
        }
        [Fact]
        public void PeekWillNotAlterQueue()
        {
            /// test peek will not alter/remove value in queue
            Node testNode = new Node(15);
            Queue testQueue = new Queue(testNode);
            testQueue.Enqueue(20);
            testQueue.Peek();
            Assert.Equal(20, testQueue.Rear.Value);
        }
    }
}
