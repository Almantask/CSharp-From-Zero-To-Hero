using System;

namespace BootCamp.Chapter
{
    class Program
    {
        static void Main(string[] args)
        {


            string user1Name;
            string user2Name;
            string user1Surname;
            string user2Surname;
            string user1Age;
            string user2Age;
            string user1WeightKG;
            string user2WeightKG;
            string user1HeightCM;
            string user2HeightCM;
            float user1BMI;
            float user2BMI;

            Console.WriteLine("What is your name?");
            user1Name = Console.ReadLine();
            Console.WriteLine("What is your surname?");
            user1Surname = Console.ReadLine();
            Console.WriteLine("What is your age?");
            user1Age = Console.ReadLine();
            Console.WriteLine("What is your weight in kg?");
            user1WeightKG = Console.ReadLine();
            Console.WriteLine("What is your height in cm?");
            user1HeightCM = Console.ReadLine();

            //BMI Calculation. Convert strings to ints. 
            float user1HeightConv = int.Parse(user1HeightCM);
            float user1WeightConv = int.Parse(user1WeightKG);
            //Covert CM to M. Then square it for formula, then compute formula of BMI
            float user1HeightM = user1HeightConv / 100;
            user1HeightM = user1HeightM * user1HeightM;
            user1BMI = user1WeightConv / user1HeightM;

            Console.WriteLine(user1Name +" "+ user1Surname +" is "+user1Age+" years old, his weight is "+user1WeightKG+
                              " kg and his height is "+user1HeightCM+" cm. Your BMI is "+user1BMI.ToString("n2")+".");

            Console.WriteLine("Please enter details for another person what is your name?");
            user2Name = Console.ReadLine();
            Console.WriteLine("What is your surname?");
            user2Surname = Console.ReadLine();
            Console.WriteLine("What is your age?");
            user2Age = Console.ReadLine();
            Console.WriteLine("What is your weight in kg?");
            user2WeightKG = Console.ReadLine();
            Console.WriteLine("What is your height in cm?");
            user2HeightCM = Console.ReadLine();


            //BMI Calculation. Convert strings to ints. 
            float user2HeightConv = int.Parse(user2HeightCM);
            float user2WeightConv = int.Parse(user2WeightKG);
            //Covert CM to M. Then square it for formula, then compute formula of BMI
            float user2HeightM = user2HeightConv / 100;
            user2HeightM = user2HeightM * user2HeightM;
            user2BMI = user2WeightConv / user2HeightM;

            Console.WriteLine(user2Name + " " + user2Surname + " is " + user2Age + " years old, his weight is " + user2WeightKG +
                              " kg and his height is " + user2HeightCM + " cm. Your BMI is " + user2BMI.ToString("n2") + ".");


        }
    }
}
