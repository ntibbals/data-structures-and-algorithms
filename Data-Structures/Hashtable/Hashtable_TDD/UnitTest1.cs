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
    }
}
