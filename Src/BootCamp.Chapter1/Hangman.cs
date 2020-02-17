using System;
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
            var anymousWord = ConvertWordSoUserCannotReadit(wordToGuess);

            Console.WriteLine($"Word to guess: { anymousWord} {Environment.NewLine}");

            Console.WriteLine(wordToGuess);
            
            do
            {
                char input = InputUser();

                var sb = anymousWord.ToCharArray();
                var counter = 0;
                for (int i = 0; i < sb.Length; i++)
                {
                    if (String.Equals(input.ToString(), wordToGuess[i].ToString(), StringComparison.OrdinalIgnoreCase))
                    {
                        sb[i] = input;
                        counter += 1;

                    }
                }

                anymousWord = new String(sb);
                Console.WriteLine(anymousWord);
                // message to the user if a word is in the word to guess and adapt lives;

            } while (lives != 0 && anymousWord.Contains('-'));

            return false;
        }

        private static char InputUser()
        {
            Console.Write("Give me a guess of a character: ");
            var isValid = char.TryParse(Console.ReadLine(), out char input);
            while (!isValid)
            {
                Console.WriteLine("You only have to enter 1 character");
                Console.Write("Give me a guess of a character: ");
                isValid = char.TryParse(Console.ReadLine(), out input);
            }

            return input;
        }

        private static string ConvertWordSoUserCannotReadit(string wordToGuess)
        {
            var output = "";
            foreach (var character in wordToGuess)
            {
                output += GuessCharacter();
            }

            return output;
        }

        private static char GuessCharacter()
        {
            var character = '-';

            return character;
        }
    }
}