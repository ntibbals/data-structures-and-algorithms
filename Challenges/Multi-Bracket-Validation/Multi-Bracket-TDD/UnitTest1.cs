using System;
using Xunit;
using Multi_Bracket_Validation;


namespace Multi_Bracket_TDD
{
    public class UnitTest1
    {
        [Fact]
        public void ValidateNestedBrackets()
        {
            ///Validate Nested rackets
            string testInput = "(C{o}d)e [Fellows]";
            Assert.True(Program.MultiBracketValidation(testInput));
        }

        [Fact]
        public void ValidateOutOfOrderBrackets()
        {
            ///Validate Nested Brackets in wrong order
            string testInput = "(C{o)d}e [Fellows]";
            Assert.False(Program.MultiBracketValidation(testInput));
        }
        [Fact]
        public void ValidateUnevenBrackets()
        {
            ///Validate false for uneven amoutn of brackets
            string testInput = "(Co)de [[Fellows]";
            Assert.False(Program.MultiBracketValidation(testInput));
        }
        [Fact]
        public void ValidateEvenBrackets()
        {
            ///Validate Even number of brackets given
            string testInput = "(Code) [Fellows]";
            Assert.True(Program.MultiBracketValidation(testInput));
        }

    }
}
