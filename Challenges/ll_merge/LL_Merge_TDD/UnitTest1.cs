using System;
using Xunit;
using LinkedList.Classes;
using ll_merge;

namespace LL_Merge_TDD
{
    public class UnitTest1
    {
        [Fact]
        public void InsertAfterHead()
        {
            /// Test that insert After method can insert after head
            LiList listOne = new LiList();
            LiList listTwo = new LiList();
            listOne.Insert(1);
            listOne.InsertAfter(1, 2);
            listOne.InsertAfter(2, 3);
            listTwo.Insert(4);
            listTwo.InsertAfter(4, 5);
            listTwo.InsertAfter(5, 6);
            Program.LlMerge(listOne, listTwo);
            int expectedValue = 4;
            Assert.Equal(expectedValue, (listOne.Head.Next.Value));
        }
    }
}
