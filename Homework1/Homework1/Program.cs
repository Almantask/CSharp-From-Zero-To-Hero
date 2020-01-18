using System;

namespace homework1
{
    class Program //commit
    {
        static void Main(string[] args)
        {   
            string firstname;
            string surname;
            int age;
            double weight;
            double height;
            string ans;

            do
            {
                Console.WriteLine("What is your Firstname?   ");
                firstname = Console.ReadLine();
                Console.WriteLine("What is your Surname?   ");
                surname = Console.ReadLine();
                Console.WriteLine("Age?");
                age = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Weight?");
                weight = Convert.ToInt32(Console.ReadLine());
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
