using System;
using Xunit;
using LinkedList.Classes;
using ll_merge;

namespace LL_Merge_TDD
{
    public class UnitTest1
    {
        [Fact]
        public void TestValueAfterMergeOfListTwoHead()
        {
            /// Test that post merge, head of list two is second position
            LiList listOne = new LiList();
            LiList listTwo = new LiList();
            listOne.Insert(1);
            listOne.InsertAfter(1, 2);
            listOne.InsertAfter(2, 3);
            listTwo.Insert(4);
            listTwo.InsertAfter(4, 5);
            listTwo.InsertAfter(5, 6);
            Program.Merge(listOne, listTwo);
            int expectedValue = 4;
            Assert.Equal(expectedValue, (listOne.Head.Next.Value));
        }
        [Fact]
        public void TestMergeListHead()
        {
            /// Test that post merge, head of list one remains the same
            LiList listOne = new LiList();
            LiList listTwo = new LiList();
            listOne.Insert(1);
            listOne.InsertAfter(1, 2);
            listOne.InsertAfter(2, 3);
            listTwo.Insert(4);
            listTwo.InsertAfter(4, 5);
            listTwo.InsertAfter(5, 6);
            Program.Merge(listOne, listTwo);
            int expectedValue = 1;
            Assert.Equal(expectedValue, (listOne.Head.Value));
        }
        [Fact]
        public void TestOddLengthMerge()
        {
            /// Test that merge will work on uneven list lengths
            LiList listOne = new LiList();
            LiList listTwo = new LiList();
            listOne.Insert(1);
            listOne.InsertAfter(1, 2);
            listTwo.Insert(4);
            Program.Merge(listOne, listTwo);
            int expectedValue = 2;
            Assert.Equal(expectedValue, (listOne.Head.Next.Value));
        }
    }
}
