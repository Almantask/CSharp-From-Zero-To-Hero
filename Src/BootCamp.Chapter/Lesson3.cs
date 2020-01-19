using System;


namespace BootCamp.Chapter
{
    public class Lesson3
    {
        public static void Demo()
        {


          


            for (int i = 0; i < 2; i++)
            {
                Console.Clear();
                Program.GatherData(out string firstName, out string lastName, out int age, out float weight, out float height);
                Program.DisplayOutput(firstName, lastName, age, weight, height);
            }
        }

    }
}