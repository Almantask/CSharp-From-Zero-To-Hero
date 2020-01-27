namespace BootCamp.Chapter
{
    class Lesson3
    {
        public static void Demo()
        {
            Console.WriteLine("Person 1:");

            //get input from user about name, age, height, weight, and calculate bmi
            string firstName = Program.getString("Enter your First Name: ");

            string lastName = Program.getString("Enter your Last Name: ");

            int age = Program.getInt("Enter your Age: ");

            float weight = Program.getFloat("Enter your Weight(kg): ");

            float height = Program.getFloat("Enter your Height(cm): ");

            Console.WriteLine(firstName + " " + lastName + " is " + age + " years old,\n" +
                "his weight is " + weight + " kg and his\n" +
                "height is " + height + " cm.");

            float bmi = Program.CalculateBmi(weight, height);

            Console.WriteLine("BMI: " + bmi + " \n");

            //do the same for another person
            Console.WriteLine("Person 2:");

            firstName = Program.getString("Enter your First Name: ");

            lastName = Program.getString("Enter your Last Name: ");

            age = Program.getInt("Enter your Age: ");

            weight = Program.getFloat("Enter your Weight(kg): ");

            height = Program.getFloat("Enter your Height(cm): ");

            Console.WriteLine(firstName + " " + lastName + " is " + age + " years old,\n" +
                "his weight is " + weight + " kg and his\n" +
                "height is " + height + " cm.");

            bmi = Program.CalculateBmi(weight, height);

            Console.WriteLine("BMI: " + bmi + " \n");

            Console.ReadLine();
        }
    }
}
