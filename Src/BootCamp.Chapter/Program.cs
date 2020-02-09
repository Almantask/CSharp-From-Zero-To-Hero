using System;
using System.Text;
using static BootCamp.Chapter.Emojis;

namespace BootCamp.Chapter
{
    class Program
    {

        public static void Main()
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;

            var emojis = $"{Stop}{Skull}{Smile}{GayFlag}{PirateFlag}{Warning}{HappyChill}{VerySad}";

            // Encode
            byte[] asciiBytes = Encoding.ASCII.GetBytes(emojis);
            // Decode
            char[] asciiChars = Encoding.ASCII.GetChars(asciiBytes);
            string asciiString = new string(asciiChars);

            byte[] unicodeBytes = Encoding.Unicode.GetBytes(emojis);

            var asciiBytesString = ToHexedString(asciiBytes);
            var unicodeBytesString = ToHexedString(unicodeBytes);

            Console.WriteLine($"Ascii: {asciiString}");
            Console.WriteLine($"Unicode: {emojis}");

            int a = 0;

            Console.WriteLine($"Ascii: {asciiBytesString}");
            Console.WriteLine($"Unicode: {unicodeBytesString}");

            Console.ReadLine();
        }

        private static string ToHexedString(byte[] bytes)
        {
            var sb = new StringBuilder();
            foreach (var b in bytes)
            {
                sb.Append($"{b:X} ");
            }

            return sb.ToString();
        }
    }
}
