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
            testStack.Push(3);
            int expectedValue = 3;
            Assert.Equal(expectedValue, testStack.Top.Value);
        }

        [Fact]
        public void TestPushIntoStackofTwo()
        {
            Node testNode1 = new Node(7);
            int testValue = 11;
            Stack testStack = new Stack(testNode1);
            testStack.Push(testValue);
            Assert.Equal(testValue, testStack.Top.Value);
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
    }
}
