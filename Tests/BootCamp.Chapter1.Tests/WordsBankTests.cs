using System;
using System.IO;
using BootCamp1.Chapter;
using BootCamp1.Chapter.WordLoader;
using FluentAssertions;
using Xunit;

namespace BootCamp.Chapter1.Tests
{
    // You don't have to be here for a long time.
    public class WordsBankTests
    {
        private const string WordsDir = "Words";

        [Fact]
        public void PickRandomWord_NoFileFound_Throws_FileNotFoundException()
        {
            Action action = () => WordsBank.PickRandomWord("dfjlksdfjlskdf", 0);
            
            action.Should().Throw<FileNotFoundException>();
        }

        [Fact]
        public void PickRandomWord_EmptyFile_Throws_InvalidWordsFileException()
        {
            Action action = () => WordsBank.PickRandomWord($"{WordsDir}/Empty.txt", 0);

            action.Should().Throw<InvalidWordsFileException>();
        }

        [Fact]
        public void PickRandomWord_NoWordsWithDifficulty_Throws_InvalidWordsFileException()
        {
            Action action = () => WordsBank.PickRandomWord($"{WordsDir}/Animals.txt", 100);

            action.Should().Throw<InvalidWordsFileException>();
        }

        [Fact]
        public void PickRandomWord_InvalidWords_Throws_InvalidWordsFileException()
        {
            Action action = () => WordsBank.PickRandomWord($"{WordsDir}/Invalid.txt", 0);

            action.Should().Throw<InvalidWordsFileException>();
        }

        [Theory]
        [InlineData(3, "Cat")]
        [InlineData(4, "Wolf")]
        [InlineData(5, "Goose")]
        public void PickRandomWord_FromFile_WithSelectedDifficulty_Returns_Expected(int difficulty, string expectedWord)
        {
            var word = WordsBank.PickRandomWord($@"{WordsDir}/Animals.txt", difficulty);

            word.Should().Be(expectedWord);
        }
    }
}
