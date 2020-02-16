using System;
using System.Text;

namespace BootCamp.Chapter
{
    public static class CaesarCipher
    {
        public static int BaseCharacter { get; set; } = 32;
        public static int TopCharacter { get; set; } = 255;

        // 0 - use only the highest repeated char
        // 1 - use the top 2 highest repeated chars
        // n - use top n highest repeated chars
        public static int KeyAccuracy { get; set; }

        /// <summary>
        /// Decrypts a message previously encrypted using Caesar Cipher using a known key/shift
        /// using reversed Encrypt method.
        /// </summary>
        /// <param name="encryptedMessage">Message to be decrypted</param>
        /// <param name="cipherKey">character cipher (shift)</param>
        /// <returns>decrypted message using reverse shift for Encrypt method</returns>
        public static string Decrypt(string encryptedMessage, int cipherKey)
        {
            if (!Utils.IsStringValid(encryptedMessage))
            {
                Console.WriteLine("Input string is not valid");
                return encryptedMessage;
            }
            var decryptedMessage = Encrypt(encryptedMessage, TopCharacter - BaseCharacter + 1 - cipherKey);
            return decryptedMessage;
        }

        /// <summary>
        /// Encrypts a message using Caesar Cipher single character shift
        /// provided by EncodeCharacter method
        /// </summary>
        /// <param name="plainMessage">Message to be encrypted.</param>
        /// <param name="cipherKey">character cipher (shift)</param>
        /// <returns>Encrypted message using Caesar Cipher algorithm</returns>
        public static string Encrypt(string plainMessage, int cipherKey)
        {
            if (!Utils.IsStringValid(plainMessage))
            {
                Console.WriteLine("Input string is not valid");
                return plainMessage;
            }

            var output = new StringBuilder();
            foreach (var inputChar in plainMessage)
            {
                output.Append(EncodeCharacter(inputChar, cipherKey));
            }
            return output.ToString();
        }

        /// <summary>
        /// Prints decrypted messages for each possible key available in input array.
        /// </summary>
        /// <param name="encryptedMessage">Message to be decrypted</param>
        public static void PrintDecryptedVariants(string encryptedMessage)
        {
            bool arguementIsValid = Utils.IsStringValid(encryptedMessage);
            if (!arguementIsValid)
            {
                Console.WriteLine("Argument is not valid");
                return;
            }

            var characterOccurrences = AnalyseFrequency(encryptedMessage);
            var possibleKeys = FindPossibleKeys(characterOccurrences);

            Console.WriteLine($"{possibleKeys.Length} possible key(s) found.{Environment.NewLine}");
            Console.WriteLine($"Adjust the bellow settings for better results!");
            Console.WriteLine($"KeyAccuracy: {KeyAccuracy}");
            Console.WriteLine($"Top Character: {TopCharacter}");
            Console.WriteLine($"BaseCharacter: {BaseCharacter}");
            Console.WriteLine();

            Console.WriteLine($"Decryption results: ");
            foreach (var key in possibleKeys)
            {
                var crackedMessage = Decrypt(encryptedMessage, key);

                Console.WriteLine($"Key = {key} - {crackedMessage}");
                Console.WriteLine();
            }
        }

        /// <summary>
        /// Find character repetition frequency in a string.
        /// </summary>
        /// <param name="encryptedMessage"></param>
        /// <returns>Bi-dimensional array containing found characters and number of repetitions</returns>
        private static int[][] AnalyseFrequency(string encryptedMessage)
        {
            if (!Utils.IsStringValid(encryptedMessage))
            {
                Console.WriteLine("Input is not a valid string");
            }

            int[] characters = new int[char.MaxValue];

            foreach (char item in encryptedMessage)
            {
                characters[item]++;
            }

            int[] repeatedCharacters = Array.Empty<int>();
            int[] numberOfOccurrences = Array.Empty<int>();

            for (int i = 0; i < char.MaxValue; i++)
            {
                if (characters[i] > 0 && IsPrintableChar((char)i))
                {
                    repeatedCharacters = ArrayOps.InsertLast(repeatedCharacters, i);
                    numberOfOccurrences = ArrayOps.InsertLast(numberOfOccurrences, characters[i]);
                }
            }
            var analysisResult = Construct2DArray(repeatedCharacters, numberOfOccurrences);
            return analysisResult;
        }

        /// <summary>
        /// Transfers the contents of two one dimension arrays to one bi-dimensional array.
        /// </summary>
        /// <param name="array1">First int one dimension input array.</param>
        /// <param name="array2">Second int one dimension input array.</param>
        /// <returns>A new Bi-dimensional int array created from array1 and array2.</returns>
        private static int[][] Construct2DArray(int[] array1, int[] array2)
        {
            if (ArrayOps.IsNullOrEmpty(array1) || ArrayOps.IsNullOrEmpty(array2))
            {
                System.Console.WriteLine("Input arrays are not valid!");
                return default;
            }

            int[][] newBiDiArr = new int[][] { array1, array2 };
            for (int i = 0; i < array1.Length; i++)
            {
                newBiDiArr[0][i] = array1[i];
            }
            for (int i = 0; i < array2.Length; i++)
            {
                newBiDiArr[1][i] = array2[i];
            }

            return newBiDiArr;
        }

        /// <summary>
        /// Transfers the elements from one of the arrays in the bi-dimensional array to one dimension array.
        /// </summary>
        /// <param name="inputArray">The array from witch the transfer</param>
        /// <param name="arrayNumber"></param>
        /// <returns>One dimension array based on argument 0 or 1</returns>
        private static int[] Deconstruct2DArray(int[][] inputArray, int arrayNumber)
        {
            bool argumentsAreNotValid = (inputArray == null || inputArray.Length == 0) && (arrayNumber < 0 || arrayNumber > 1);
            if (argumentsAreNotValid)
            {
                System.Console.WriteLine("Arguments are not valid!");
                return default;
            }

            var newArray = new int[inputArray[arrayNumber].Length];
            for (int i = 0; i < newArray.Length; i++)
            {
                newArray[i] = inputArray[arrayNumber][i];
            }
            return newArray;
        }

        /// <summary>
        /// Implementation of Caesar Cipher character shift algorithm
        /// </summary>
        /// <param name="inputCharacter">character to be shifted</param>
        /// <param name="shift">numbers of characters to be shifted</param>
        /// <returns>resulting character after shift is performed</returns>
        private static char EncodeCharacter(char inputCharacter, int shift)
        {
            if (!IsPrintableChar(inputCharacter))
            {
                return inputCharacter;
            }

            var output = (char)(Mod(inputCharacter + shift - BaseCharacter, TopCharacter - BaseCharacter + 1) + BaseCharacter);
            return output;
        }

        /// <summary>
        /// Finds possible encryption keys for Caesar Cipher based on character repetition array
        /// </summary>
        /// <param name="characterOccurrences">bi-dimensional array containing</param>
        /// <returns>an array with possible decryption keys</returns>
        private static int[] FindPossibleKeys(int[][] characterOccurrences)
        {
            // I could have done a characterOccurrences[0] and [1] but
            // despite the fact It's more complicated I learned more about arrays.
            var repeatedCharacters = Deconstruct2DArray(characterOccurrences, 0);
            var numberOfOccurrences = Deconstruct2DArray(characterOccurrences, 1);
            var highestOccurrence = ArrayOps.FindMaxValue(numberOfOccurrences);

            var possibleKeys = new int[0];
            int currentKey;

            for (int i = 0; i < repeatedCharacters.Length; i++)
            {
                if (numberOfOccurrences[i] >= highestOccurrence - KeyAccuracy)
                {
                    currentKey = repeatedCharacters[i] - BaseCharacter;
                    possibleKeys = ArrayOps.InsertLast(possibleKeys, currentKey);
                }
            }
            return possibleKeys;
        }

        /// <summary>
        /// Checks if a character is a printable character
        /// </summary>
        /// <param name="inputCharacter">character to be checked</param>
        private static bool IsPrintableChar(char inputCharacter)
        {
            return inputCharacter >= BaseCharacter || inputCharacter < TopCharacter;
        }

        // this method exists for the cases when dividend % divisor returns negative number
        private static int Mod(int dividend, int divisor)
        {
            if (divisor == 0)
            {
                return dividend;
            }
            int remainder = dividend % divisor;
            if (remainder < 0)
            {
                return remainder + divisor;
            }
            return remainder;
        }
    }
}