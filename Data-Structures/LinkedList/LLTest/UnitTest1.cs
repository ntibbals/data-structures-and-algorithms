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
            ///Test that link list is instantiated with null value
            LiList testList = new LiList();
            Assert.Null(testList.Head);
        }
        //[Fact]
        //public void TestAppendDoesNotInsertAtHead()
        //{
        //    ///Test append does not insert the new node at the head
        //    int testNum1 = 3;
        //    int testNum2 = 13;
        //    int testNum3 = 23;
        //    LiList testList = new LiList();
        //    testList.Insert(testNum1);
        //    testList.Insert(testNum2);
        //    testList.Append(testNum3);
        //    int expectedValue = 13;
        //    Assert.Equal(expectedValue, testList.Head.Value);
        //}

        [Fact]
        public void TestInsertBeforeDoesNotInsertAtHead()
        {
            ///Test insert before does not insert the new node at the head
            int testNum1 = 3;
            int testNum2 = 13;
            int testNum3 = 23;
            int testnum4 = 33;
            LiList testList = new LiList();
            testList.Insert(testNum1);
            testList.Insert(testNum2);
            testList.Insert(testNum3);
            testList.InsertBefore(testNum2, testnum4);
            int expectedValue = 23;
            Assert.Equal(expectedValue, testList.Head.Value);
        }

        [Fact]
        public void TestInsertBeforeInsertsInCorrectPosition()
        {
            ///Test insert before inserts in correct position based on if they are next to each other, will equal 30
            int testNum1 = 5;
            int testNum2 = 10;
            int testNum3 = 15;
            int testNum4 = 20;
            int testNum5 = 15;
            LiList testList = new LiList();
            testList.Insert(testNum1);
            testList.Insert(testNum2);
            testList.Insert(testNum3);
            testList.Insert(testNum4);
            testList.InsertBefore(testNum3, testNum5);
            int expectedValue = 30;
            Assert.Equal(expectedValue, (testList.Head.Next.Value + testList.Head.Next.Next.Value));
        }
        [Fact]
        public void TestInsertBeforeOnNull()
        {
            ///Test insert before inserts in correct position based on if they are next to each other, will equal 30
            int testNum1 = 5;
            int testNum2 = 10;
            LiList testList = new LiList();
            testList.Insert(testNum1);
            testList.InsertBefore(testNum1, testNum2);
            int expectedValue = 10;
            Assert.Equal(expectedValue, (testList.Head.Value));
        }
    }
}
