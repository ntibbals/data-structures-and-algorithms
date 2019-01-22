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
            Stack testStack = new Stack();
            Assert.Null(testStack.Top);

        }

        [Fact]
        public void TestPushIntoEmptyStack()
        {
            Stack testStack = new Stack();
            int testValue = 3;
            testStack.Push(testValue);
            int expectedValue = 3;
            Assert.Equal(expectedValue, testStack.Top.Value);
        }

        [Fact]
        public void TestPushIntoStackofTwo()
        {
            int testValue = 11;
            int testValue2 = 7;
            Stack testStack = new Stack();
            testStack.Push(testValue);
            testStack.Push(testValue2);
            Assert.Equal(testValue2, testStack.Top.Value);
        }
        [Fact]
        public void TestPushMoreThanOne()
        {
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
            Stack testStack = new Stack();
            Assert.Throws<NullReferenceException>(() => testStack.Pop());
        }
        [Fact]
        public void TestPopWillRemoveTopValue()
        {
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
        public void PeekOnEmptyStatck()
        {
            Stack testStack = new Stack();
            Assert.Null(testStack.Peek());
        }
        [Fact]
        public void PeekOnStatckOfOne()
        {
            Node testNode = new Node(5);
            Stack testStack = new Stack(testNode);
            testStack.Push(10);
            Node expectedNode = new Node(10);
            Assert.Equal(testStack.Top, testStack.Peek());
        }
        [Fact]
        public void PeekWillNotAlterStack()
        {
            Node testNode = new Node(5);
            Stack testStack = new Stack(testNode);
            testStack.Push(10);
            testStack.Peek();
            Assert.Equal(10, testStack.Top.Value);
        }
        [Fact]
        public void TestInstantiatesEmptyQueue()
        {
            Queue testQueue = new Queue();
            Assert.Null(testQueue.Front);

        }
        [Fact]
        public void TestEnqueRearValueOfQueue()
        {
            Node testNode = new Node(3);
            Queue testQueue = new Queue(testNode);
            int testValue = 7;
            testQueue.Enqueue(testValue);
            int expectedValue = 7;
            Assert.Equal(expectedValue, testQueue.Rear.Value);
        }
        [Fact]
        public void TestEnqueFrontValueOfQueue()
        {
            Node testNode = new Node(11);
            Queue testQueue = new Queue(testNode);
            int testValue = 13;
            testQueue.Enqueue(testValue);
            int expectedValue = 11;
            Assert.Equal(expectedValue, testQueue.Front.Value);
        }


    }
}
