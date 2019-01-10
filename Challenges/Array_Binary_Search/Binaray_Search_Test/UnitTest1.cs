using System;
using Xunit;
using Array_Binary_Search;

namespace Binaray_Search_Test
{
    public class UnitTest1
    {
        [Fact]
        public void FindKey()
        {
            //Test that given a key, it will find the index positino
            int[] testArray = { 33, 44, 55, 66, 77, 88, 99 };
            int expectedResult = 4;
            int testKey = 77;
            Assert.Equal(expectedResult, Program.BinarySearch(testArray, testKey));
        }

        [Fact]
        public void KeyNotInArray()
        {
            //Test that given a key not in the array, will return accordinlgy
            int[] testArray = { 42, 54, 66, 78, 90, 102, 114 };
            int expectedResult = 1;
            int testKey = 54;
            Assert.Equal(expectedResult, Program.BinarySearch(testArray, testKey));

        }
    }
}
