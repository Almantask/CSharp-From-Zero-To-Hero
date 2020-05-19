using System;
using System.Collections.Generic;
using System.Text;

namespace BootCamp.Chapter
{
    public static class Encoder
    {
        public static string Encode(string input)
        {
            var buffer = Encoding.Unicode.GetBytes(input);
            StringBuilder stringBuilder = new StringBuilder();

            foreach (var character in buffer)
            {
                stringBuilder.Append(character);
            }

            return stringBuilder.ToString();
        }
    }
}
