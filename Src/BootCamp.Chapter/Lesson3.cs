using System;
namespace BootCamp.Chapter
{
    class Lesson3
    {
        public static void Demo()
        {
            string decision;
            do
            {
                Console.Clear(); //Clear console window
                decision = Program.AddNewPerson();

            } while (decision == "Y"); //Repeat if user wants to add new person's data
        }
    }
    
}
