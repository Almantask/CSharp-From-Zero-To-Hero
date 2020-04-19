using System;
using System.Text;

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

            var encrypted = CaesarCipher.Encrypt(message, 10);
            var decrypted = CaesarCipher.Decrypt(encrypted, 10);
            Console.WriteLine(encrypted);
            Console.WriteLine("-----------------------------------");
            Console.WriteLine(decrypted);
            Console.WriteLine("==============================================================================");
            
            var encrypted2 = CaesarCipher.Encrypt(message2, 230);
            var decrypted2 = CaesarCipher.Decrypt(encrypted2, 230);
            Console.WriteLine(encrypted2);
            Console.WriteLine("-----------------------------------");
            Console.WriteLine(decrypted2);
            
        }
    }
}
