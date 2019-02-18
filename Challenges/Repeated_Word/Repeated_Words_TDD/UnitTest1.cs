using Repeated_Word;
using Hashtables.Classes;
using System;
using Xunit;

namespace Repeated_Words_TDD
{
    public class UnitTest1
    {
        [Fact]
        public void CanFindWord()
        {
            string test = "racks on racks for stacks";
            string expected = "racks";
            Assert.Equal(expected, Program.RepeatedWord(test));

        }
        [Fact]
        public void CanFindCapitalWord()
        {
            string test = "A tree can also be a acorn";
            string expected = "a";
            Assert.Equal(expected, Program.RepeatedWord(test));

        }
        [Fact]
        public void CanFindEmpytString()
        {
            string test = "";
            string expected = "";
            Assert.Equal(expected, Program.RepeatedWord(test));

        }

        [Fact]
        public void CanFindFirstDuplicate()
        {
            string test = "A tree can also be a tree";
            string expected = "a";
            Assert.Equal(expected, Program.RepeatedWord(test));

        }
    }
}
