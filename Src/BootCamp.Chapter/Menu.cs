using BootCamp.Chapter.Grid2d;
using BootCamp.Chapter.JaggedGrid;
using System;

namespace BootCamp.Chapter
{
    public class Menu
    {
        public void Run()
        {
            bool quit = false;
            do
            {
                Console.WriteLine("---------------------------------------------");
                Console.WriteLine("Please choose:                               ");
                Console.WriteLine("---------------------------------------------");
                Console.WriteLine("1. Toggle cell in a jagged array.              ");
                Console.WriteLine("2. Toggle cell in a 2d array.                  ");
                Console.WriteLine("3. Find the most common symbol in a sentence.");
                Console.WriteLine("4. Quit.                                     ");
                Console.WriteLine("---------------------------------------------");

                char inputKeyStroke = Console.ReadKey(true).KeyChar;
                switch (inputKeyStroke)
                {
                    case '1':
                        JaggedApp.RunJaggedApp();
                        break;
                    case '2':
                        Grid2dApp.Run2dApp();
                        break;
                    case '3':
                        MostCommonLetterFinder.CharCountApp();
                        break;
                    case '4':
                        QuitMenu();
                        quit = true;
                        break;
                    default:
                        break;
                }
            } while (!quit);
        }

        private void QuitMenu()
        {
            Console.WriteLine("Welcome back! Goodbye!");
        }
    }
}
