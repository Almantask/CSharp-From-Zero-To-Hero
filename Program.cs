

namespace Lesson_1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("What is your name and surname?");
            string name1 = Console.ReadLine();
            Console.WriteLine("How old are you?");
            string age1 = Console.ReadLine();
            Console.WriteLine("How much do you weigh?");
            double weight1 = double.Parse(Console.ReadLine());
            Console.WriteLine("How tall are you? Answer in CM.");
            double height1 = double.Parse(Console.ReadLine());

            double bmi1 = weight1 / ( (height1 / 100.0) * (height1 / 100.0) );
            Console.WriteLine("");

            Console.WriteLine($"{name1} is {age1} years old, his weight is {weight1} kg, and his height is {height1}.");
            Console.WriteLine($"His BMI is {bmi1}.");

            Console.Write("Now it is time for another one to write their info!");
            Console.WriteLine("");


            Console.WriteLine("What is your name and surname?");
            string name2 = Console.ReadLine();
            Console.WriteLine("How old are you?");
            string age2 = Console.ReadLine();
            Console.WriteLine("How much do you weigh?");
            double weight2 = double.Parse(Console.ReadLine());
            Console.WriteLine("How tall are you? Answer in CM.");
            double height2 = double.Parse(Console.ReadLine());

            
            Console.WriteLine("");
            Console.WriteLine($"{name2} is {age2} years old, his weight is {weight2} kg, and his height is {height2}.");
            Console.WriteLine($"His BMI is {bmi1}.\n");
            Console.WriteLine("Press any key to close.");












            Console.ReadKey();



        }
    }
}
