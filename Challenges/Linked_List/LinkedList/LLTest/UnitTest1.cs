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
        public void TestIfZeroIncluded()
        {
            ///Test if node does not exist, will return false
            int testNum = 0;
            LiList testList = new LiList();
            testList.Insert(testNum);
            Assert.True(testList.Includes(testNum));
        }
        [Fact]
        public void TestIfInsertsValue()
        {
            ///Test if insert function will insert accordingly
            int testNum = 13;
            LiList testList = new LiList();
            testList.Insert(testNum);
            Assert.Equal(13, testList.Head.Value);
        }

        [Fact]
        public void TestIfInsertsValueAtHeadChanges()
        {
            ///Test if insert function will change head value
            int testNum1 = 33;
            int testNum2 = 77;
            LiList testList = new LiList();
            testList.Insert(testNum1);
            testList.Insert(testNum2);
            Assert.NotEqual(testNum1, testList.Head.Value);
        }

        [Fact]
        public void TestIfInsertMultipleValues()
        {
            ///Test if insert multiple values, head will remain last inserted value
            int testNum1 = 3;
            int testNum2 = 13;
            int testNum3 = 23;
            int testNum4 = 33;
            int testNum5 = 43;
            LiList testList = new LiList();
            testList.Insert(testNum1);
            testList.Insert(testNum2);
            testList.Insert(testNum3);
            testList.Insert(testNum4);
            testList.Insert(testNum5);
            int expectedValue = 43;
            Assert.Equal(expectedValue, testList.Head.Value);
        }

        [Fact]
        public void InstantiateListAtNull()
        {
            LiList testList = new LiList();
            Assert.Null(testList.Head);
        }
            

    }
}
