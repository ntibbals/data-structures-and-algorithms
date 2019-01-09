using System;
using Xunit;
using Array_Shift;

namespace Code_Challenge_02_TDD
{
    public class UnitTest1
    {
        [Fact]
        public void TestArrayLength()
        {
            //Test that array length in incrementally growing
            int[] testArray = { 6, 7, 8, 9 };
            int[] expectedArray = { 6, 7, 5, 8, 9 };
            Assert.Equal(expectedArray, Program.ArrayShift(testArray, 5));
               
        }
    }
}
