using System;


namespace BootCamp.Chapter
{
    public class Lesson3
    {
        public static void Demo()
        {


            string firstName = " ";
            string lastName = " ";
            int age = 0;
            float weight = 0.00f;
            float height = 0.00f;



            for (int i = 0; i < 2; i++)
            {
                Console.Clear();
                Program.GatherData(ref firstName, ref lastName, ref age, ref weight, ref height);
                Program.DisplayOutput(firstName, lastName, age, weight, height);
            }
        }

    }
}