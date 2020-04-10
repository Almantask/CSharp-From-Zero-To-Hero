using System;

namespace BootCamp.Chapter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What's your first name?");
            string name = Console.ReadLine();

            Console.WriteLine("What's your surname?");
            string surname = Console.ReadLine();

            Console.WriteLine("How old are you?");
            var age = Console.ReadLine();

            Console.WriteLine("How much do you weight in kg?");
            var weight = float.Parse(Console.ReadLine());

            Console.WriteLine("How tall are you in cm?");
            var height = float.Parse(Console.ReadLine());

            float heightInMetres = height / 100;

            float bodyMassIndex = weight / (heightInMetres * heightInMetres);

            Console.WriteLine(name + " " + surname + " is " + age + " years old, his weight is " + weight + "kg and his height is " + height + " cm");

            Console.WriteLine("Their BMI is: " + bodyMassIndex);


            Console.WriteLine("\nWhat's your friend's first name?");
            string friendName = Console.ReadLine();

            Console.WriteLine("What's their surname?");
            string friendSurname = Console.ReadLine();

            Console.WriteLine("How old are they?");
            var friendAge = Console.ReadLine();

            Console.WriteLine("How much do they weight in kg?");
            var friendWeight = float.Parse(Console.ReadLine());

            Console.WriteLine("How tall are they in cm?");
            var friendHeight = float.Parse(Console.ReadLine());

            float friendHeightInMetres = friendHeight / 100;

            float friendBodyMassIndex = weight / (friendHeightInMetres * friendHeightInMetres);

            Console.WriteLine(friendName + " " + friendSurname + " is " + friendAge + " years old, his weight is " + friendWeight + "kg and his height is " + friendHeight + " cm");

            Console.WriteLine("Their BMI is: " + friendBodyMassIndex);
        }
    }
}
