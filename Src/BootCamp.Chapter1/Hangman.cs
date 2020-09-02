using System;
using System.Collections.Generic;
using System.Linq;
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
            if(lives < 1 || difficulty < 3)
            {
                throw new SystemException();
            }

            var wordToGuess = WordsBank.PickRandomWord(@$"Words/{wordsFile}", difficulty);           
            bool[] isVisible = new bool[wordToGuess.Length];

            while (true)
            {
                var playersGuess = GuessCharacter(lives);

                bool isCharacterPresent = CheckForCharacter(wordToGuess, playersGuess, ref isVisible);

                PrintKnownCharacters(wordToGuess, isVisible);

                if (!isCharacterPresent)
                {
                    lives--;
                }

                if (lives == 0)
                {
                    Console.WriteLine("Too bad! You lost.");
                    Console.WriteLine($"The correct word was {wordToGuess}.");
                    return false;
                }

                else if (isVisible.All(x => x == true))
                {
                    Console.WriteLine("Congratulations! You guessed the correct word!");
                    return true;
                }
            }
        }

        private static void PrintKnownCharacters(string wordToGuess, bool[] isVisible)
        {
            string result = "";

            for (int i = 0; i < wordToGuess.Length; i++)
            {
                result += (isVisible[i] ? wordToGuess[i] : '_');
                result += ((i == wordToGuess.Length - 1) ? "" : " ");
            }

            Console.WriteLine(result);
        }

        private static bool CheckForCharacter(string wordToGuess, char playersGuess, ref bool[] isVisible)
        {
            bool foundCharacter = false;

            for (int i = 0; i < wordToGuess.Length; i++)
            {
                if (wordToGuess[i].ToString().ToLower() == playersGuess.ToString().ToLower() && isVisible[i] != true)
                {
                    isVisible[i] = true;
                    foundCharacter = true;
                }
            }

            return foundCharacter;
        }

        private static char GuessCharacter(int lives)
        {
            Console.Write($"You have {lives} lives left. Guess a character: ");
            var character = Console.ReadLine();
            return character[0];
        }
    }
}
