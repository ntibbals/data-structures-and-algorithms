using System;
using Xunit;
using Hashtables.Classes;

namespace Hashtable_TDD
{
    public class UnitTest1
    {
        [Fact]
        public void CanCreateKey()
        {
            Hashtable testHash = new Hashtable(7);

            string key = "Test";
            /// ASCII VALUES: 84 101 115 116
            int expected = 6;

            Assert.Equal(expected, testHash.HashFunc(key));

        }

        [Fact]
        public void CanCreateKeyWithEmpty()
        {
            Hashtable testHash = new Hashtable(7);

            string key = "";
            /// Empty string has 0 length, will always be 0
            int expected = 0;

            Assert.Equal(expected, testHash.HashFunc(key));
        }

        [Fact]
        public void CanCreateMultipleKeys()
        {
            Hashtable testHash = new Hashtable(7);

            string key = "Test";
            /// ASCII VALUES: 84 101 115 116
            int expected = 6;

            string key2 = "Test1";
            /// ASCII VALUES: 84 101 115 116 1
            int expected2 = 6;

            Assert.Equal(expected, testHash.HashFunc(key));
            Assert.Equal(expected2, testHash.HashFunc(key2));

        }

        [Fact]
        public void CanAddSingleKeyValuePair()
        {
            Hashtable testHash = new Hashtable(6);

            testHash.Add("Test", "TestValue");
            int key = testHash.HashFunc("Test");
            string expected = "TestValue";
            Assert.Equal(expected, testHash.Table[key].getValue());
        }

        [Fact]
        public void CanAddMultipleKeyValuePair()
        {
            Hashtable testHash = new Hashtable(6);

            testHash.Add("Test", "TestValue");
            testHash.Add("TestTest", "TestTestValue");
            int key = testHash.HashFunc("TestTest");
            string expected = "TestTestValue";
            Assert.Equal(expected, testHash.Table[key].getValue());
        }
        [Fact]
        public void CanAddWithCollision()
        {
            Hashtable testHash = new Hashtable(7);

            testHash.Add("Test", "TestValue");
            testHash.Add("Test1", "Test1Value");
            int key = testHash.HashFunc("Test"); /// index 6
            int key1 = testHash.HashFunc("Test1"); /// index 6
            string expected = "TestValue";
            string expected1 = "Test1Value";
            Assert.Equal(expected, testHash.Table[key].getValue());
            Assert.Equal(expected1, testHash.Table[key1].Next.getValue());
        }

        [Fact]
        public void CanGetSingleKeyValuePair()
        {
            Hashtable testHash = new Hashtable(6);

            testHash.Add("Test", "TestValue");
            string expected = "TestValue";
            Assert.Equal(expected, testHash.Get("Test"));
        }

        [Fact]
        public void CanGetWithCollision()
        {
            Hashtable testHash = new Hashtable(7);

            testHash.Add("Test", "TestValue");
            testHash.Add("Test1", "Test1Value");
            string expected = "Test1Value";
            Assert.Equal(expected, testHash.Get("Test1"));
        }

        [Fact]
        public void CanGetWithTripleCollision()
        {
            Hashtable testHash = new Hashtable(7);

            testHash.Add("Test", "TestValue");
            testHash.Add("Test1", "Test1Value");
            testHash.Add("Test2", "Test2Value");
            string expected = "Test2Value";
            Assert.Equal(expected, testHash.Get("Test2"));
        }
        [Fact]
        public void CanGetNull()
        {
            Hashtable testHash = new Hashtable(7);

            testHash.Add("Test", "TestValue");
            testHash.Add("Test1", "Test1Value");
            testHash.Add("Test2", "Test2Value");
            Assert.Null(testHash.Get("Fail"));
        }
        [Fact]
        public void ContainSingleKeyValuePair()
        {
            Hashtable testHash = new Hashtable(6);
        
            testHash.Add("Test", "TestValue");
            Assert.True(testHash.Contains("Test"));
        }

        [Fact]
        public void ContainWithCollision()
        {
            Hashtable testHash = new Hashtable(7);

            testHash.Add("Test", "TestValue");
            testHash.Add("Test1", "Test1Value");
            Assert.True(testHash.Contains("Test1"));
        }

        [Fact]
        public void ContainWithTripleCollision()
        {
            Hashtable testHash = new Hashtable(7);

            testHash.Add("Test", "TestValue");
            testHash.Add("Test1", "Test1Value");
            testHash.Add("Test2", "Test2Value");
            Assert.True(testHash.Contains("Test2"));
        }
        [Fact]
        public void DoesNotContain()
        {
            Hashtable testHash = new Hashtable(7);

            testHash.Add("Test", "TestValue");
            testHash.Add("Test1", "Test1Value");
            testHash.Add("Test2", "Test2Value");
            Assert.False(testHash.Contains("Fail"));
        }
    }
}
