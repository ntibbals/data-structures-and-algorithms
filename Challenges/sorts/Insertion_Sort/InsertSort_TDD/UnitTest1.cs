using System;
using Xunit;
using Insertion_Sort;

namespace InsertSort_TDD
{
    public class UnitTest1
    {
        [Fact]
        public void CanSortSingle()
        {
            // Sort array with single index
            int[] testArray = new int[] { 9 };
            int[] expected = new int[] {  9 };

            Assert.Equal(expected, Program.InsertionSort(testArray));

        }

        [Fact]
        public void CanSortArrayofFive()
        {
            // sort array with length of five
            int[] testArray = new int[] { 1, 9, 5, 4, 2 };
            int[] expected = new int[] { 1, 2, 4, 5, 9 };

            Assert.Equal(expected, Program.InsertionSort(testArray));

        }
        [Fact]
        public void CanSortWithDuplicates()
        {
            // can sort with multiple duplicates
            int[] testArray = new int[] { 9, 9, 5, 2, 2 };
            int[] expected = new int[] { 2, 2, 5, 9, 9 };

            Assert.Equal(expected, Program.InsertionSort(testArray));

        }
        [Fact]
        public void CanSortWithEmptyArray()
        {
            // can sort an empty array
            int[] testArray = new int[] { };
            int[] expected = new int[] { };

            Assert.Equal(expected, Program.InsertionSort(testArray));

        }
        [Fact]
        public void CanSortNegativeIntegers()
        {
            // can sort negative integers
            int[] testArray = new int[] { 1, 9, -5, 4, 2 };
            int[] expected = new int[] { -5, 1, 2, 4, 9 };

            Assert.Equal(expected, Program.InsertionSort(testArray));

        }
        [Fact]
        public void CanSortSortedArray()
        {
            // sort array that is already sorted
            int[] testArray = new int[] { 1, 2, 4, 5, 9 };
            int[] expected = new int[] { 1, 2, 4, 5, 9 };

            Assert.Equal(expected, Program.InsertionSort(testArray));

        }
        [Fact]
        public void CanSortBackwardsSortedArray()
        {
            // sort array that is already sorted
            int[] testArray = new int[] { 9, 8, 7, 6 };
            int[] expected = new int[] { 6, 7, 8, 9 };

            Assert.Equal(expected, Program.InsertionSort(testArray));

        }
    }
}
