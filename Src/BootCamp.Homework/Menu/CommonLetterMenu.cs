using System;

namespace BootCamp.Homework.Menu
{
    public class CommonLetterMenu
    {
        public void DisplayCommonLetterMenu()
        {
            Console.WriteLine("[Find Most Common Letter]");
            Console.WriteLine("Enter a sentence:");
            var sentence = ValidateSentence();
            var commonLetter = new MostCommonLetterFinder();

            Console.WriteLine($"Most common letter is \"{commonLetter.Find(sentence)}\"");
        }

        private string ValidateSentence()
        {
            do
            {
                var sentence = Console.ReadLine();
                if (string.IsNullOrEmpty(sentence))
                {
                    Console.WriteLine("Invalid sentence, try again");
                    continue;
                }

                return sentence;
            } while (true);
        }
    }
}