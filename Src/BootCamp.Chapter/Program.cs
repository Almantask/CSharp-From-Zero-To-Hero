using System;

namespace BootCamp.Chapter
{
    class Program
    {
        static void Main(string[] args) //First Commit
        {

            string ans
       
            do
            {
                string firstname;
                Console.WriteLine("What is your Firstname?   ");
                firstname = Console.ReadLine();
                string surname;
                Console.WriteLine("What is your Surname?   ");
                surname = Console.ReadLine();
                int age;
                Console.WriteLine("Age?");
                age = Convert.ToInt32(Console.ReadLine());
                double weight;
                Console.WriteLine("Weight?");
                weight = Convert.ToInt32(Console.ReadLine());
                double height;
                Console.WriteLine("Height?");
                height = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Your firstname is " + firstname + " and surname is " + surname + " , Age is " + age + ". Your weight is " + weight + " in kg and " +
                    "height is " + height + " in cm.");
                Console.WriteLine("Their BMI is " + (weight / (height / 100 * height / 100)));
                
                
                Console.WriteLine("Again?");
                ans = Console.ReadLine();

            } while (ans != "no");

            

        }
    }
}
