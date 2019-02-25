using System;
using Xunit;
using Common_Word;

namespace CommonWord_TDD
{
    public class UnitTest1
    {
        [Fact]
        public void CanFindSingleRepetitiveWord()
        {
            ///Can identify a single repetive word
            string phrase = "This is one is two";
            string expected = "is";

            Assert.Equal(expected, Program.CommonWord(phrase));
        }

        [Fact]
        public void CanFindCommonWithMultipleRepetitiveWord()
        {
            ///Look through phrase with multimple common words, find most common
            string phrase = "This is the song that never ends it goes On and my it  On on it On it friend";
            string expected = "on";

            Assert.Equal(expected, Program.CommonWord(phrase));
        }
        [Fact]
        public void CanFindCommonWithDelimiters()
        {
            ///run through a book with delimiters
            string phrase = "This is the song that, never ends it goes On, and my it  On, on it On. it friend";
            string expected = "on";

            Assert.Equal(expected, Program.CommonWord(phrase));
        }

        [Fact]
        public void NoCommonWord()
        {
            /// run through phrase without a common word
            string phrase = "This is one two";
            string expected = "No Common Word";

            Assert.Equal(expected, Program.CommonWord(phrase));
        }

    }
}
