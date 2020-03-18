using System.Text;

namespace BootCamp.Chapter
{
    public static class StringOps
    {
        private static readonly Encoding ascii = Encoding.ASCII;
        private static readonly Encoding unicode = Encoding.Unicode;

        public static string Encode(string password)
        {
            var temp = Encoding.Unicode.GetBytes(password);
            var encodedPassword = new StringBuilder();
            foreach (var character in temp)
            {
                encodedPassword.Append(character);
            }
            return encodedPassword.ToString();
        }

        public static bool IsValid(string input)
        {
            return string.IsNullOrWhiteSpace(input) || string.IsNullOrEmpty(input);
        }
    }
}