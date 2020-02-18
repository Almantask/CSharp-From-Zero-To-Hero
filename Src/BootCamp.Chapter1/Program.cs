using System;

namespace BootCamp1.Chapter
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Let's play Hangman!");
            var outcome = Hangman.Play(1, "Animals.txt", 5);
            if (outcome)
            {
                Console.WriteLine("You won this game. Congrats");
            }
            else
            {
                Console.WriteLine("Sorry , you lost");
            }

        }
    }
}
