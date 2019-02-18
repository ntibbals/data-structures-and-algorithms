using System;
using Xunit;
using Insertion_Sort;

namespace InsertSort_TDD
{
    public class UnitTest1
    {
        [Fact]
        public void CanSortArrayofTwo()
        {
            int[] testArray = new int[] { 9, 1 };
            int[] expected = new int[] { 1, 9 };

            Assert.Equal(expected, Program.InsertionSort(testArray));

        }
    }
}
