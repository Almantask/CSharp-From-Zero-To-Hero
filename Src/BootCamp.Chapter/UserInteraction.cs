using System;

namespace BootCamp.Chapter
{
    public static class UserInteraction
    {
        public static void DisplayMenu()
        {
            ConsoleInit();
            DisplayHeader();

            Console.WriteLine("(1) Encrypt message");
            Console.WriteLine("(2) Decrypt message");
            Console.WriteLine("(3) Crack encrypted message");
            Console.WriteLine();
            Console.WriteLine("(9) Settings");
            Console.WriteLine("(0) Exit program!");

            ChooseMenu();
        }

        private static void ChooseMenu()
        {
            ConsoleKey pressedKey = Console.ReadKey(true).Key;
            if (pressedKey == ConsoleKey.D0 || pressedKey == ConsoleKey.NumPad0)
            {
                Environment.Exit(0);
            }
            else if (pressedKey == ConsoleKey.D1 || pressedKey == ConsoleKey.NumPad1)
            {
                EncryptMessage();
            }
            else if (pressedKey == ConsoleKey.D2 || pressedKey == ConsoleKey.NumPad2)
            {
                DecryptMessage();
            }
            else if (pressedKey == ConsoleKey.D3 || pressedKey == ConsoleKey.NumPad3)
            {
                CrackMessage();
            }
            else if (pressedKey == ConsoleKey.D9 || pressedKey == ConsoleKey.NumPad9)
            {
                ChangeSettings();
            }
            DisplayMenu();
        }

        private static void ChangeSettings()
        {
            ConsoleInit(true);

            DisplayHeader();

            Console.WriteLine($"Key accuracy: {CaesarCipher.KeyAccuracy}");
            Console.WriteLine($"Base character: {CaesarCipher.BaseCharacter}");
            Console.WriteLine($"Top character: {CaesarCipher.TopCharacter}");

            Console.WriteLine();

            Console.Write("Do you want to change? (Y/N) ");
            var response = Console.ReadLine();
            if (response != "Y" || response == "N")
            {
                return;
            }

            UpdateKeyAccuracy();
            UpdateBaseCharacter();
            UpdateTopCharacter();

            Console.WriteLine("Settings updated.");
            Wait();
        }

        private static void UpdateBaseCharacter()
        {
            Console.Write("Input base character: ");
            var baseCharacter = Console.ReadLine();
            if (!Utils.IsNumeric(baseCharacter))
            {
                return;
            }
            CaesarCipher.BaseCharacter = Utils.ConvertToInt(baseCharacter);
        }

        private static void UpdateTopCharacter()
        {
            Console.Write("Input top character: ");
            var topCharacter = Console.ReadLine();
            if (!Utils.IsNumeric(topCharacter))
            {
                return;
            }
            CaesarCipher.TopCharacter = Utils.ConvertToInt(topCharacter);
        }

        private static void UpdateKeyAccuracy()
        {
            Console.Write("Input key accuracy: ");
            var keyAccuracy = Console.ReadLine();
            if (!Utils.IsNumeric(keyAccuracy))
            {
                return;
            }
            CaesarCipher.KeyAccuracy = Utils.ConvertToInt(keyAccuracy);
        }

        private static void CrackMessage()
        {
            ConsoleInit(true);

            DisplayHeader();

            Console.Write("Input message to try decryption on: ");
            string encryptedMessage = Console.ReadLine();

            if (!Utils.IsStringValid(encryptedMessage))
            {
                return;
            }

            Console.WriteLine($"Testing frequency attack...{Environment.NewLine}");
            CaesarCipher.PrintDecryptedVariants(encryptedMessage);

            Wait();
        }

        private static void EncryptMessage()
        {
            ConsoleInit(true);

            DisplayHeader();

            Console.Write("Input message to encrypt: ");
            var plainMessage = Console.ReadLine();

            if (!Utils.IsStringValid(plainMessage))
            {
                return;
            }

            Console.Write("Input encryption key (shift): ");
            string cipherKey = Console.ReadLine();
            if (!Utils.IsNumeric(cipherKey))
            {
                return;
            }
            var encryptedMessage = CaesarCipher.Encrypt(plainMessage, Utils.ConvertToInt(cipherKey));
            Console.Write($"Encrypted message: {encryptedMessage}");

            Wait();
        }

        private static void DecryptMessage()
        {
            ConsoleInit(true);

            DisplayHeader();

            Console.Write("Input message to decrypt: ");
            var encryptedMessage = Console.ReadLine();

            if (!Utils.IsStringValid(encryptedMessage))
            {
                return;
            }

            Console.Write("Input encryption key (shift): ");
            string cipherKey = Console.ReadLine();
            if (!Utils.IsNumeric(cipherKey))
            {
                return;
            }
            var decryptedMessage = CaesarCipher.Decrypt(encryptedMessage, Utils.ConvertToInt(cipherKey));
            Console.Write($"Decrypted message: {decryptedMessage}");

            Wait();
        }

        private static void Wait()
        {
            Console.CursorVisible = false;
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Press ENTER to continue");
            Console.ReadLine();
        }

        private static void ConsoleInit(bool cursorVisible = false)
        {
            Console.Clear();
            Console.CursorVisible = cursorVisible;
        }

        private static void DisplayHeader()
        {
            Console.WriteLine("Caesar Cipher demo");
            Console.WriteLine();
        }
    }
}