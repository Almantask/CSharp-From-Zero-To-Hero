using System;
using System.Collections.Generic;
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
            if (message == null || message.Equals(""))
            {
                return message;
            }

            //Convert to char array to change chars
            char[] charMessage = message.ToCharArray();
            for (int i = 0; i < charMessage.Length; i++)
            {
                //Shift
                charMessage[i] += Convert.ToChar(shift);
                //Rollover
                charMessage[i] %= (char)255;
            }

            return string.Join("", charMessage);
        }

        public static string Decrypt(string message, byte shift)
        {
			if (message == null || message.Equals(""))
			{
				return message;
			}

			//Convert to char array to change chars
			char[] charMessage = message.ToCharArray();
			for (int i = 0; i < charMessage.Length; i++)
			{
				//Shift
				charMessage[i] = (char)(charMessage[i] - Convert.ToChar(shift));
				//Rollover
				charMessage[i] %= (char)255;
			}

			return string.Join("", charMessage);
        }
    }
}
