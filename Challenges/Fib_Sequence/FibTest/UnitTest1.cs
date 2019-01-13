using System;
using Xunit;
using fib_Sequence;

namespace FibTest
{
    public class UnitTest1
    {
        [Fact]
        public void TestIntOne()
        {
            /// Test that given an integer of one, correct nth will return of one
            int testOne = 1;
            int expectedResult = 1;
            Assert.Equal(expectedResult, Program.FibSeq(testOne));
        }
    }
}
