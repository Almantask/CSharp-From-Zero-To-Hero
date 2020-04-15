using System;
using FluentAssertions;
using Xunit;
namespace BootCamp.Chapter.Tests
{
    // You don't have to be here for a long time.
    public class MostCommonLetterFinderTests
    {
        [Theory]
        [InlineData("")]
        [InlineData(" ")]
        [InlineData(null)]
        public void Find_Given_NullOrWhitespace_Throws_ArgumentNullExceptions(string sentence)
        {
            Action action = () => MostCommonLetterFinder.Find(sentence);

            action.Should().Throw<ArgumentNullException>();
        }

        [Theory]
        [InlineData("a", 'a')]
        [InlineData("abc", 'a')]
        [InlineData("abca", 'a')]
        [InlineData("uiopppaaaxxx", 'p')]
        [InlineData("II", 'I')]
        [InlineData("sfajlasbfklasjksahfksjbjbfkjahbgkfiyugtzvduytwerfgearkjbmnzvjhgliuwyeiuflkjfsjhvbmnxbvjugswugakjhsfksfjhkjbafkujhb", 'j')]
        public void Find_Given_Valid_String_Returns_Expected_Character(string sentence, char expected)
        {
            var mostCommonCharacter = MostCommonLetterFinder.Find(sentence);

            mostCommonCharacter.Should().Be(expected);
        }
    }
}
