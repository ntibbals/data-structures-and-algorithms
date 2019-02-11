using Are_Characters_Unique;
using System;
using Xunit;

namespace Are_Character_Unique_TDD
{
    public class UnitTest1
    {
        [Fact]
        public void TestNonUniqueString()
        {
            /// test string without unique characters
            string testInput = "abcd";

            Assert.True(Program.AreCharactersUnique(testInput));
        }

        [Fact]
        public void TestUniqueString()
        {
            /// test string without unique characters
            string testInput = "abacd";

            Assert.False(Program.AreCharactersUnique(testInput));
        }

        [Fact]
        public void TestEmptyString()
        {
            /// test empty string
            string testInput = "";

            Assert.True(Program.AreCharactersUnique(testInput));
        }

        [Fact]
        public void TestSpecialString()
        {
            /// test special characters
            string testInput = "ab$cd$;lj";

            Assert.False(Program.AreCharactersUnique(testInput));
        }

    }
}
