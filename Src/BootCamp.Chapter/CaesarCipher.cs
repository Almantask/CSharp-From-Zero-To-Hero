using System.Text;

namespace BootCamp.Chapter
{
    /// <summary>
    /// Caesar cipher which supports all ASCII character (256 in total)
    /// </summary>
    public static class CaesarCipher
    {
        public static string Encrypt(string message, byte shift)
        {
            return ConvertString(shift, message, true);
        }

        public static string Decrypt(string message, byte shift)
        {
            return ConvertString(shift, message, false);
        }

        private static string ConvertString(int shift, string input, bool isEncryption)
        {
            if (!string.IsNullOrEmpty(input))
            {
                shift = isEncryption ? shift : -shift;

                StringBuilder sb = new StringBuilder();
                
                foreach (var letter in input)
                {
                    char newChar = (char)(letter + shift);
                    sb.Append(newChar);
                }
                return sb.ToString();
            }

            return input == null ? null : "";
        }
    }
}