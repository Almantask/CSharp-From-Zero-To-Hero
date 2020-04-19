using System;

namespace BootCamp.Chapter
{
    class Program
    {
        static void Main(string[] args)
        {
            var message =
                "If he had anything confidential to say, he wrote it in cipher, that is, by so changing the order of the letters of the alphabet, that not a word could be made out.";
            var message2 =
                "Frase. Frase é todo enunciado de sentido completo, podendo ser formada por uma só palavra ou por várias, podendo ter verbos ou não.";

            PrintEncDec(message, 230);
            PrintEncDec(message2, 10);
            
        }

        private static void PrintEncDec(string message, byte shift)
        {
            var encrypted = CaesarCipher.Encrypt(message, shift);
            var decrypted = CaesarCipher.Decrypt(encrypted, shift);
            Console.WriteLine("ENCRYPTED");
            Console.WriteLine(encrypted);
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("DECRYPTED");
            Console.WriteLine(decrypted);
            Console.WriteLine("==============================================================================");
        }
    }
}
