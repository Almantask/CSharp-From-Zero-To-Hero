using System;

namespace BootCamp.Chapter
{
    class Program
    {
        static void Main(string[] args) //First Commit
        {

            string ans;
       
            do
            {
                
                Console.WriteLine("What is your Firstname?   ");
                string firstname = Console.ReadLine();
                Console.WriteLine("What is your Surname?   ");
                string surname = Console.ReadLine();
                Console.WriteLine("Age?");
                int age = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Weight?");
                double weight = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Height?");
                double height = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Your firstname is " + firstname + " and surname is " + surname + " , Age is " + age + ". Your weight is " + weight + " in kg and " +
                    "height is " + height + " in cm.");
                Console.WriteLine("Their BMI is " + (weight / (height / 100 * height / 100)));
                
                
                Console.WriteLine("Again? type no to be able to exit");
                ans = Console.ReadLine();

            } while (ans != "no");

            

        }
    }
}
