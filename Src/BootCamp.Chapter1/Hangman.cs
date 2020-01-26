using System;
using System.Collections.Generic;
using System.Text;

namespace BootCamp1.Chapter
{
    public static class Hangman
    {
        /// <summary>
        /// Play the game!. The rules are simple:
        /// 1) Game starts with a random word hidden from a player and n lives.
        /// For example hidden word "dog" would become _ _ _
        /// 2) Player guesses one character at a time:
        ///    a) If they guess a letter correctly, that character gets filled in the right spot
        ///    b) If they miss, the loose one life.
        /// 3) The game ends when:
        ///     a) Player guesses the word before lives run out- game is won.
        ///     b) Player looses all lives- games is lost.
        /// </summary>
        /// <param name="lives">Amount of tries a player has. >1.</param>
        /// <param name="wordsFile">Words input file in Words directory.</param>
        /// <param name="difficulty">Length of word. >2.</param>
        /// <returns>True if game was won or false if game was lost.</returns>
        public static bool Play(int lives, string wordsFile, int difficulty)
        {
            var wordToGuess = WordsBank.PickRandomWord(@$"Words/{wordsFile}", difficulty);
            // ToDo: finish the game!
            var playersGuess = GuessCharacter();

            return false;
        }

        private static char GuessCharacter()
        {
            var character = '-';

            return character;
        }
    }
}
