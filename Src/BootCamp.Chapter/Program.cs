using System;

namespace BootCamp.Chapter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");


			 Console.WriteLine("What is your Name?.");
            string name = Console.ReadLine();
		
		
		 Console.WriteLine("What is your sex? (M/F)");
            string gender = Console.ReadLine();
             string M;
           

            Console.WriteLine("How old are you?");
            string stoneAge = Console.ReadLine();
            int age = int.Parse(stoneAge);

            Console.WriteLine("Your Weight in Kg?");
            string gumWeight = Console.ReadLine();
            int weight = int.Parse(gumWeight);

            Console.WriteLine("Your Height in CM?");
            string saneHeight = Console.ReadLine();
            double height = double.Parse(saneHeight);



            // BMI formula weight(kg) divided by (height(cm))^2 multiplied by 10000
            double sum = height * height;
            double sum2 = weight / sum;
            double bmi = sum2 * 10000;
            bmi = Convert.ToInt32(bmi);
          

                if (bmi < 18.5)
            { Console.WriteLine($"Your BMI is {bmi}. Which is feather weight. Have a pie :("); }
            if (bmi >= 18.5 & bmi <= 24.9)
            { Console.WriteLine($"Your BMI is {bmi}. Great, go and chill but keep an eye on your diet :)"); }
            if (bmi >= 25 & bmi <= 29.9)
            { Console.WriteLine($"your BMI is {bmi}. You're overweight mate hit the gym"); }
            if (bmi >= 30.0)
            { Console.WriteLine($"Your BMI is {bmi}. obese, stop eating junk mate and hit the gym 5 times a week"); }
		
            if (gender == "M")
            Console.WriteLine($"{name} is {age} years old, his weight is {weight} kg and his height is {height} cm. His BMI is {bmi} ");
		 else
                Console.WriteLine($"{name} is {age} years old, her weight is {weight} kg and her height is {height} cm. Her BMI is {bmi} ");
		

		}
    }
}
