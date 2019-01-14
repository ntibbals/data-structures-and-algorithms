using System;
using Xunit;
using LinkedList.Classes;

namespace LLTest
{
    public class UnitTest1
    {
        [Fact]
        public void TestIfNotIncluded()
        {
            ///Test if node does not exist, will return false
            int testNum = 7;
            LiList testList = new LiList();
            testList.Insert(testNum);
            int falseValue = 13;
            Assert.False(testList.Includes(falseValue));
        }

        [Fact]
        public void TestIfIncluded()
        {
            ///Test if node does not exist, will return false
            int testNum = 7;
            LiList testList = new LiList();
            testList.Insert(testNum);
            Assert.True(testList.Includes(testNum));
        }
        [Fact]
        public void TestIfZEROIncluded()
        {
            ///Test if node does not exist, will return false
            int testNum = 0;
            LiList testList = new LiList();
            testList.Insert(testNum);
            Assert.True(testList.Includes(testNum));
        }
        [Fact]
        public void TestIfInsertValue()
        {
            ///Test if insert function will insert accordingly
            int testNum = 13;
            LiList testList = new LiList();
            testList.Insert(testNum);
            Assert.Equal(13, testList.Head.Value);
        }

        [Fact]
        public void TestIfInsertsValueAtHead()
        {
            ///Test if insert function will insert value at head
            int testNum1 = 33;
            int testNum2 = 77;
            LiList testList = new LiList();
            testList.Insert(testNum1);
            testList.Insert(testNum2);
            int expectedValue = 77;
            Assert.Equal(expectedValue, testList.Head.Value);
        }

    }
}
