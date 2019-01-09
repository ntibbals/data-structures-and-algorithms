using System;
using Xunit;
using Array_Shift;

namespace Code_Challenge_02_TDD
{
    public class UnitTest1
    {
        [Fact]
        public void TestEvenArray()
        {
            //Test that given an even array it will insert in middle
            int[] testArray = { 6, 7, 8, 9 };
            int[] expectedArray = { 6, 7, 5, 8, 9 };
            Assert.Equal(expectedArray, Program.ArrayShift(testArray, 5));
               
        }
        [Fact]
        public void TestOddArray()
        {
            //Test that given an even array it will insert in middle
            int[] testArray = { 11, 12, 13, 14, 15};
            int[] expectedArray = { 11, 12, 16, 13, 14, 15 };
            Assert.Equal(expectedArray, Program.ArrayShift(testArray, 16));

        }
        [Fact]
        public void TestNegativeVariable()
        {
            //Test that given an array of constant variables, a negaitve integer will not impact insertion
            int[] testArray = { 33, 33, 33, 33 };
            int[] expectedArray = { 33, 33, -77, 33, 33 };
            Assert.Equal(expectedArray, Program.ArrayShift(testArray, -77));

        }
    }
}
