using System;

namespace BootCamp.Chapter
{
    class PersonInfo
    {
        public static void UserInfo()
        {
            //ask for first input of name
            // then send call method to make sure it fits name paramter of only letters and assign to name variable
            Console.WriteLine("Please enter your first name.");
            string firstName = ValidateLettersOnly.CheckStringForLettersOnly();

            // same as first name but for last name
            Console.WriteLine("Please enter your last name.");
            string lastName = ValidateLettersOnly.CheckStringForLettersOnly();


            // same as name inputs but for age
            //call age method and check to make sure it fits parameter of numbers only.
            Console.WriteLine("Please enter your age.");
            //I went with float for age because maybe someone likes to put percent of new age such as 7.5 years old...
            float age = float.Parse(ValidateNumbersOnly.CheckStringForDigitsOnly());

            //same as age
            Console.WriteLine("Please enter your weight in kg.");
            float weightInKg = float.Parse(ValidateNumbersOnly.CheckStringForDigitsOnly());

            //same as age
            Console.WriteLine("Please enter your height in meters.");
            float height = float.Parse(ValidateNumbersOnly.CheckStringForDigitsOnly());

            //after all values added run this at end of program
            Console.WriteLine("Thank you for your information. You entered:");

            //now dispaly the data that was given in a sentence. 
            Console.WriteLine($"\n``` {firstName} {lastName} is {age} years old, your weight is {weightInKg} kg and" +
                              $" your height is {height} cm. ```");

            //Call class method and pss in the weight and height of person.
           BMI.CalculateBmi(weightInKg, height);
        }

        
    }
}
