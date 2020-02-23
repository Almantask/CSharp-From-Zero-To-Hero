namespace BootCamp.Chapter
{
    /// <summary>
    /// Caesar cipher which supports all ASCII character (256 in total)
    /// </summary>
    public static class CaesarCipher
    {
        public static string Encrypt(string message, byte shift)
        {
            return Lesson10.Cypher(message, shift);
        }

        public static string Decrypt(string message, byte shift)
        {
            return Lesson10.DecryptCypher(message, shift);
        }
    }
}
