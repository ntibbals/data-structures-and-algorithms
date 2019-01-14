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
    }
}
