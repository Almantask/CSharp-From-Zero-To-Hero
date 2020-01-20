using System;

namespace BootCamp.Chapter
{
    class AddAnotherUser
    {
        public static bool AddAnotherPerson()
        { 
            bool moreEntries = true;
            
            Console.WriteLine("\nWould you like to enter another person? " +
                                                           "Press Y to enter another or any other button to exit.");

                //changed this to .ToLowerInvariant() as suggested
                string checkAnswer = Console.ReadLine().ToLowerInvariant();

                if (checkAnswer != "y")
                {
                    Console.WriteLine("You chose not to enter another user. Thank you, goodbye.");
                    moreEntries = false;
                }

            return moreEntries;

        }
    }
}
