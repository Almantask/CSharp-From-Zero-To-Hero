using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace BootCamp.Chapter.Tests
{
    public class Tests
    {
        [Fact]
        public void Create_Substring_When_NullArg_Throws_NullArgumentException()
        {
            string s = null;

            string NullMethod() => Challenge.LongestSubstring(s);

            Assert.Throws<ArgumentNullException>(NullMethod);
        }

        [Theory]
        [InlineData("AAAaaa", "a")]
        [InlineData("AasdEefgg", "asdefg")]
        [InlineData("1233", "123")]
        [InlineData("", "")]
        public void Create_Substring_When_Has_Duplicated_Chars_Returns_One_Char(string testValue, string expectedValue)
        {

            string actualValue = Challenge.LongestSubstring(testValue);

            Assert.Equal(expectedValue, actualValue);
        }
        
    }
}
