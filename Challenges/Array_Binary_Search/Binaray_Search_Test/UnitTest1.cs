using System;
using Xunit;
using Array_Binary_Search;

namespace Binaray_Search_Test
{
    public class UnitTest1
    {
        [Fact]
        public void FindKeyInOddArray()
        {
            //Test that given a key, it will find the index position in 
            int[] testArray = { 33, 44, 55, 66, 77, 88, 99 };
            int expectedResult = 4;
            int testKey = 77;
            Assert.Equal(expectedResult, Program.BinarySearch(testArray, testKey));
        }

        [Fact]
        public void FindKeyInEvenArray()
        {
            //Test that given a key, it will find the index positino
            int[] testArray = { 66, 77, 88, 99 };
            int expectedResult = 3;
            int testKey = 99;
            Assert.Equal(expectedResult, Program.BinarySearch(testArray, testKey));
        }
        [Fact]
        public void KeyNotInArray()
        {
            //Test that given a key not in the array, will return accordinlgy
            int[] testArray = { 23, 31, 40, 49 };
            int expectedResult = -1;
            int testKey = 20;
            Assert.Equal(expectedResult, Program.BinarySearch(testArray, testKey));
        }

    }
}
