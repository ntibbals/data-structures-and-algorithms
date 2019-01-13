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
            long testOne = 1;
            long expectedResult = 1;
            Assert.Equal(expectedResult, Program.FibSeq(testOne));
        }

        [Fact]
        public void TestIntFour()
        {
            /// Test that given an integer of four, correct nth will return of three
            long testFour = 4;
            long expectedResult = 3;
            Assert.Equal(expectedResult, Program.FibSeq(testFour));
        }

        [Fact]
        public void TestLongFifty()
        {
            /// Test that given an integer of four, correct nth will return of three
            long testTen = 50;
            long expectedResult = 12586269025;
            Assert.Equal(expectedResult, Program.FibSeq(testTen));
        }

        [Fact]
        public void TestLongHundred()
        {
            /// Test that given an integer of four, correct nth will return of three
            long testTen = 100;
            long expectedResult = 3736710778780434371;
            Assert.Equal(expectedResult, Program.FibSeq(testTen));
        }

        [Fact]
        public void TestLongThousand()
        {
            /// Test that given an integer of four, correct nth will return of three
            long testTen = 1000;
            long expectedResult = 817770325994397771;
            Assert.Equal(expectedResult, Program.FibSeq(testTen));
        }
    }
}
