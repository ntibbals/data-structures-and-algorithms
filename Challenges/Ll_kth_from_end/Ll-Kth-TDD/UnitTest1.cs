using System;
using Xunit;
using Ll_Kth_TDD;
using LinkedList.Classes;

namespace Ll_Kth_TDD
{
    public class UnitTest1
    {
        [Fact]
        public void TestKthOnHeadNode()
        {
            /// Test head node value can be identified from end
            int testNum1 = 33;
            int testNum2 = 44;
            int testNum3 = 55;
            int testNum4 = 2;
            LiList testList = new LiList();
            testList.Insert(testNum1);
            testList.Insert(testNum2);
            testList.Insert(testNum3);
            int expectedValue = 55;
            Assert.Equal(expectedValue, (testList.FindKthFromEnd(testNum4)));
        }
        [Fact]
        public void TestKthOnEndNode()
        {
            /// Test the last node value
            int testNum1 = 33;
            int testNum2 = 44;
            int testNum3 = 55;
            int testNum4 = 0;
            LiList testList = new LiList();
            testList.Insert(testNum1);
            testList.Insert(testNum2);
            testList.Insert(testNum3);
            int expectedValue = 33;
            Assert.Equal(expectedValue, (testList.FindKthFromEnd(testNum4)));
        }
        [Fact]
        public void TestKthOnNodeNotInList()
        {
            /// Test the last node value
            int testNum1 = 33;
            int testNum2 = 44;
            int testNum3 = 55;
            int testNum4 = 3;
            LiList testList = new LiList();
            testList.Insert(testNum1);
            testList.Insert(testNum2);
            testList.Insert(testNum3);
            int expectedValue = 0;
            Assert.Equal(expectedValue, (testList.FindKthFromEnd(testNum4)));
        }
    }
}
