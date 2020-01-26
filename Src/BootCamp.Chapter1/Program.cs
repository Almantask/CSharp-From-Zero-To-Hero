using System;

namespace BootCamp1.Chapter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Let's play Hangman!");
            Hangman.Play(1, "Animals.txt", 5);
        }
    }
}
