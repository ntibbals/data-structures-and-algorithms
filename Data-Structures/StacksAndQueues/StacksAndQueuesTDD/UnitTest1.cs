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
            Stack testStatck = new Stack();
            Assert.Null(testStatck.Top);

        }
    }
}
