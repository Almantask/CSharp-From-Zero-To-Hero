using System;

namespace BootCamp.Chapter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
class Program
{
    static void Main(string[] args)
    {

        String firstName = " ";
        String lastName = " ";
        int age = 0;
        float weight = 0.00f;
        float height = 0.00f;



        for (int i = 0; i < 2; i++)
        {
            Console.Clear();
            getInput(ref firstName, ref lastName, ref age, ref weight, ref height);
            String name = firstName + " " + lastName;
            displayOutput(firstName, age, weight, height);

        }




        // INput function
        void getInput(ref String firstName, ref String lastName, ref int age, ref float weight, ref float height)
        {



            Console.WriteLine("Hello, What is your First name? ");
            firstName = Console.ReadLine();
            Console.WriteLine("Hello, What is your Last name? ");
            lastName = Console.ReadLine();
            Console.WriteLine("How old are you?");
            age = (int)float.Parse(Console.ReadLine());
            Console.WriteLine("How much do you weigh in kilograms?");
            weight = float.Parse(Console.ReadLine());
            Console.WriteLine("How tall are you?");
            height = float.Parse(Console.ReadLine());
            Console.Clear();
        }


        // Output function
        void displayOutput(String name, int age, float weight, float height)
        {
            Console.WriteLine(name + " is " + age + " years old; his weight is " + weight + " kg and his height is " + height + " cm.");
            Console.WriteLine(name + "'s Body Mass Index is " + calcBMI(weight, height) + ".");
            Console.WriteLine("\n\n\n\n\nPress Enter");
            Console.ReadLine();

        }

        //Calculate BMI
        float calcBMI(float weight, float height)
        {
            return weight / ((height / 100) * (height / 100));

        }
    }
}
}
