using System;

namespace BootCamp.Chapter
{
    class Program
    {
        static void Main(string[] args)
        {
            //Tell me if I did the task wrongly, because I wasn't really sure if I had had to define them and not ask them in.
            //Read name, surename, age, weight (in kg) and height (in cm) from console
            // calculate BMI index
            string namePerson1 = "Tom";
            string namePerson2 = "Daniel";
            string surnamePerson1 = "Hartz";
            string surnamePerson2 = "Lebrone";
            int agePerson1 = 32;
            int agePerson2 = 53;
            int weightPerson1 = 82;
            int weightPerson2 = 63;
            double heightPerson1 = 181;
            double heightPerson2 = 178;
            double heightmPerson1 = Math.Pow(heightPerson1 / 100.0,2); //just to convert centimeters into meters, then ^2 them
            double heightmPerson2 = Math.Pow(heightPerson2 / 100.0,2);
            double bmiPerson1 = weightPerson1 / heightmPerson1;
            double bmiPerson2 = weightPerson2 / heightmPerson2;
            Console.WriteLine("Welcome here at my code. Would you like to know more about person 1, or person 2?\n\t Select   1 or 2");
            ifcycle:
            int personNumber = int.Parse(Console.ReadLine());
            if (personNumber==1)
            {
                Console.WriteLine("{0} {1} is {2} years old, his weight is {3} kg and his height {4} cm.",namePerson1,surnamePerson1,agePerson1,weightPerson1,heightPerson1);
                Console.WriteLine("His BMI index is: {0}",bmiPerson1);
            }
            else if (personNumber==2)
            {
                Console.WriteLine("{0} {1} is {2} years old, his weight is {3} kg and his height {4} cm.", namePerson2, surnamePerson2, agePerson2, weightPerson2,heightPerson2);
                Console.WriteLine("His BMI index is: {0}",bmiPerson2);
                
            }
            else
            {
                Console.WriteLine("please select a valid number");
                Console.WriteLine();
                goto ifcycle;
            }
        }
    }
}
