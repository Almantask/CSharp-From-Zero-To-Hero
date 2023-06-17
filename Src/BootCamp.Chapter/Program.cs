using System;
using System.Text;

namespace BootCamp.Chapter
{
	class Program
	{
		static void Main(string[] args)
		{
			//Make a random word
			Random random = new Random();
			byte[] rndBytes = new byte[16];
			random.NextBytes(rndBytes);
			string rndText = Encoding.ASCII.GetString(rndBytes);

			Console.WriteLine($"Random text: {rndText}");

			//Encrypt
			Byte shift = 4;
			string encryptedText = CaesarCipher.Encrypt(rndText, shift);
			Console.WriteLine($"Encrypted: {encryptedText}");

			//Decrypt
			string decryptedText = CaesarCipher.Decrypt(encryptedText, shift);
			Console.WriteLine($"Decrypted: {decryptedText}");

			Console.ReadLine();
		}
	}
}
