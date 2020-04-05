using System;

namespace BootCamp.Chapter
{
    class Program
    {
        static void Main(string[] args)
        {
            // READ ONE PERSON'S STUFF
            //Read name and surname
            Console.WriteLine("Input your name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Input your surname: ");
            string surname = Console.ReadLine();

            //Read age, weight and height
            Console.WriteLine("Input your age: ");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input your weight in kg: ");
            float weight = float.Parse(Console.ReadLine());
            Console.WriteLine("Input your height in cm: ");
            float height = float.Parse(Console.ReadLine());

            Console.WriteLine(name + " " + surname + " " + "is" + " " + age + " years old, his weight is " + weight + " kg and his height is " + height + " cm.");


            //Calculate BMI
            //Making the height into meters
            height = height / 100;

            //Making the height into square meters
            height = height * height;

            //Calculating the BMI
            float calculation = weight / height;

            Console.WriteLine("Your BMI is: ");
            Console.WriteLine(calculation);


            //SAME FOR OTHER PERSON'S

            //Read name and surname
            Console.WriteLine("Input your name: ");
             name = Console.ReadLine();
            Console.WriteLine("Input your surname: ");
            surname = Console.ReadLine();

            //Read age, weight and height
            Console.WriteLine("Input your age: ");
             age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input your weight in kg: ");
            weight = float.Parse(Console.ReadLine());
            Console.WriteLine("Input your height in cm: ");
             height = float.Parse(Console.ReadLine());

            Console.WriteLine(name + " " + surname + " " + "is" + " " + age + " years old, his weight is " + weight + " kg and his height is " + height + " cm.");

            //Calculating the BMI
            calculation = weight / height;

            Console.WriteLine("Your BMI is: ");
            Console.WriteLine(calculation);
        }
    }
}
