using System;
using Xunit;
using System.Collections.Generic;

namespace PalindromeExercise.Tests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("racecar",true)]
        [InlineData("hello",false)]
        [InlineData("Racecar", true)]
        [InlineData("rotator",true)]
        [InlineData ("peep",true)]
        [InlineData ("thanks",false)]
        public void PalindromeTester(string word, bool expected)
        {
            var unittest = new WordSmith();

            var actual= unittest.IsAPalindrome(word);

            Assert.Equal(expected, actual);
        }
    }
}
