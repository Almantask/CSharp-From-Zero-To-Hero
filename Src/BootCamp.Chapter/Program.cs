using System;

namespace BootCamp.Chapter
{
    class Program
    {
        static void Main(string[] args)
        {

            //Set variable
            var backtotop = true;
            

            //Start While loop
            while (backtotop)

            {
                
                backtotop = true;

                //USer data input

                Console.WriteLine("What is your first name?");
                var firstname = Console.ReadLine();

                Console.WriteLine("What is your second name?");
                var secondname = Console.ReadLine();

                Console.WriteLine("What is your age?");
                var age = Console.ReadLine();

                Console.WriteLine("What is your weight in kg?");
                var weight = Console.ReadLine();

                Console.WriteLine("What is your height in Meters?");
                var height = Console.ReadLine();


                //Convert to Singles
                var weightsingle = Convert.ToSingle(weight);
                var heightsingle = Convert.ToSingle(height);


                //Calc for BMI
                var Calc1 = weightsingle / heightsingle;
                var BMI = Calc1 / heightsingle;


                //Display output to user
                Console.WriteLine(firstname + " " + secondname + "is " + age + " years old, his weight is " + weightsingle + " kg and his height is " + heightsingle + " cm ");
                Console.WriteLine("Your BMI is " + BMI);


                // Calc BMI scale 
                if (BMI <= 18.5f)
                {
                    Console.WriteLine("You are underweight");
                }
                else if (BMI >= 18.6f && BMI <= 24.99f)
                {
                    Console.WriteLine("You are normal Weight");
                }
                else if (BMI >= 25 && BMI <= 29.99f)
                {
                    Console.WriteLine("You are overweight");
                }
                else if (BMI >= 30)
                {
                    Console.WriteLine("You are obese");
                }

                //Continue
                Console.WriteLine("Would you like to do another person Y/N?");
                var option = Console.ReadLine();
                if ((option) == "N" || (option) == "n")
                {
                    backtotop = false;
                }
               
            }
        }
    }
}


