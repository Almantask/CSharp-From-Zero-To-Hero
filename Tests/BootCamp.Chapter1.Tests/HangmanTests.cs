using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using BootCamp1.Chapter;
using FluentAssertions;
using Xunit;

namespace BootCamp.Chapter1.Tests
{
    public class HangmanTests
    {
        private const string FileWithBOnly = "bbb.txt";
        private const string FileWithAOnly = "aaa.txt";

        private const int ValidLives = 1;
        private const string ValidFile = "Animals.txt";
        private const int ValidDifficulty = 3;


        /// <summary>
        /// Stubs <see cref="Console.ReadLine()"/> with the value set.
        /// </summary>
        protected string ConsoleInput
        {
            set
            {
                var input = new StringReader(value);
                Console.SetIn(input);
            }
        }

        [Fact]
        public void Play_WithZeroLives_Throws()
        {
            Action action = () => Hangman.Play(0, ValidFile, ValidDifficulty);

            action.Should().Throw<Exception>();
        }

        [Fact]
        public void Play_DifficultyUnder3_Throws()
        {
            Action action = () => Hangman.Play(ValidDifficulty, ValidFile, 2);
            
            action.Should().Throw<Exception>();
        }

        [Fact]
        public void Play_AlwaysGuessTheSame_With_ValidCharacter_Returns_False()
        {
            ConsoleInput = "a";
            var isWin = Hangman.Play(ValidLives, FileWithBOnly, ValidDifficulty);
            
            isWin.Should().BeFalse();
        }
        
        [Fact]
        public void Play_AlwaysGuessCorrect_Returns_True()
        {
            ConsoleInput = "b";
            var isWin = Hangman.Play(ValidLives, FileWithBOnly, ValidDifficulty);

            isWin.Should().BeTrue();
        }
    }
}
